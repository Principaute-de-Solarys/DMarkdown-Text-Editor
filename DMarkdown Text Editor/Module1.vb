Module Module1
    Dim normalSize As Single = 9 * My.Settings.taille, smallSize As Single = 7 * My.Settings.taille, h3Size As Single = 11 * My.Settings.taille, h2Size As Single = 13 * My.Settings.taille, h1Size As Single = 15 * My.Settings.taille
    Function RtfToMarkdown(rtb As RichTextBox) As String
        Dim result As New Text.StringBuilder()
        Dim prevLineIndex As Integer = -1
        Dim openTags As New Stack(Of String)
        Dim i As Integer = 0

        While i < rtb.TextLength
            rtb.Select(i, 1)
            Dim ch As String = rtb.SelectedText

            If ch = vbCr OrElse ch = vbLf Then
                While openTags.Count > 0
                    result.Append(openTags.Pop())
                End While
                result.Append(ch)
                prevLineIndex = -1
                i += 1
                Continue While
            End If

            Dim font = rtb.SelectionFont
            If font Is Nothing Then
                result.Append(ch)
                i += 1
                Continue While
            End If

            Dim size = font.Size
            Dim isBold = font.Bold
            Dim isItalic = font.Italic
            Dim isUnderline = font.Underline
            Dim isStrikeout = font.Strikeout

            Dim isSmall = (size = smallSize)
            Dim ish1 = (size = h1Size)
            Dim ish2 = (size = h2Size)
            Dim ish3 = (size = h3Size)

            Dim lineIndex = rtb.GetLineFromCharIndex(i)
            If lineIndex <> prevLineIndex Then
                Dim originalLine = rtb.Lines(lineIndex)
                Dim tempLine = originalLine
                Dim quotePrefix As String = ""
                Dim bulletPrefix As String = ""
                Dim prefixLen As Integer = 0

                While tempLine.StartsWith("> ")
                    quotePrefix &= "> "
                    tempLine = tempLine.Substring(2)
                    prefixLen += 2
                End While
                If tempLine.StartsWith("- ") Then
                    bulletPrefix = "- "
                    tempLine = tempLine.Substring(2)
                    prefixLen += 2
                End If

                Dim sizeMarker As String = ""
                If ish1 Then sizeMarker = "# "
                If ish2 Then sizeMarker = "## "
                If ish3 Then sizeMarker = "### "
                If isSmall Then sizeMarker = "-# "

                Dim newPrefix = quotePrefix & sizeMarker & bulletPrefix
                result.Append(newPrefix)

                i += prefixLen
                prevLineIndex = lineIndex
                Continue While
            End If

            Dim currentTags As New List(Of String)
            If isBold Then currentTags.Add("**")
            If isItalic Then currentTags.Add("*")
            If isUnderline Then currentTags.Add("__")
            If isStrikeout Then currentTags.Add("~~")

            Dim previousTags As List(Of String) = openTags.Reverse().ToList()
            Dim commonCount = 0
            While commonCount < Math.Min(previousTags.Count, currentTags.Count) _
              AndAlso previousTags(commonCount) = currentTags(commonCount)
                commonCount += 1
            End While

            For j = previousTags.Count - 1 To commonCount Step -1
                result.Append(previousTags(j))
                openTags.Pop()
            Next
            For j = commonCount To currentTags.Count - 1
                result.Append(currentTags(j))
                openTags.Push(currentTags(j))
            Next

            result.Append(ch)
            i += 1
        End While

        While openTags.Count > 0
            result.Append(openTags.Pop())
        End While

        Return result.ToString()
    End Function

    Function MarkdownToRtf(rtb As RichTextBox, markdown As String) As Boolean
        Try
            rtb.Clear()
            Dim lines = markdown.Split(New String() {vbLf}, StringSplitOptions.None)

            For Each line As String In lines
                Dim working = line
                Dim quotePrefix As String = ""
                Dim bulletPrefix As String = ""
                Dim size As Single = normalSize

                While working.StartsWith("> ")
                    quotePrefix &= "> "
                    working = working.Substring(2)
                End While
                If working.StartsWith("- ") Then
                    bulletPrefix = "- "
                    working = working.Substring(2)
                End If

                If working.StartsWith("### ") Then
                    size = h3Size : working = working.Substring(4)
                ElseIf working.StartsWith("## ") Then
                    size = h2Size : working = working.Substring(3)
                ElseIf working.StartsWith("# ") Then
                    size = h1Size : working = working.Substring(2)
                ElseIf working.StartsWith("-# ") Then
                    size = smallSize : working = working.Substring(3)
                End If

                Dim styleSpans As New List(Of (Start As Integer, Length As Integer, Style As FontStyle))
                Dim patterns = New List(Of (Pattern As String, Style As FontStyle)) From {
                    ("\*\*\*__(.+?)__\*\*\*", FontStyle.Bold + FontStyle.Italic + FontStyle.Underline),
                    ("\*\*__(.+?)__\*\*", FontStyle.Bold + FontStyle.Underline),
                    ("\*__(.+?)__\*", FontStyle.Italic + FontStyle.Underline),
                    ("\*\*\*~~(.+?)~~\*\*\*", FontStyle.Bold Or FontStyle.Italic + FontStyle.Strikeout),
                    ("\*\*~~(.+?)~~\*\*", FontStyle.Bold + FontStyle.Strikeout),
                    ("\*~~(.+?)~~\*", FontStyle.Italic + FontStyle.Strikeout),
                    ("\*\*\*(.+?)\*\*\*", FontStyle.Bold Or FontStyle.Italic),
                    ("\*\*(.+?)\*\*", FontStyle.Bold),
                    ("\*(.+?)\*", FontStyle.Italic),
                    ("__(.+?)__", FontStyle.Underline),
                    ("__~~(.+?)~~__", FontStyle.Underline + FontStyle.Strikeout),
                    ("~~(.+?)~~", FontStyle.Strikeout)
                }
                For Each pat In patterns
                    Dim regex = New System.Text.RegularExpressions.Regex(pat.Pattern)
                    Dim matches = regex.Matches(working)
                    For mIdx As Integer = matches.Count - 1 To 0 Step -1
                        Dim m = matches(mIdx)
                        styleSpans.Add((m.Index, m.Groups(1).Length, pat.Style))
                        working = working.Remove(m.Index, m.Length).Insert(m.Index, m.Groups(1).Value)
                    Next
                Next

                Dim textLine = quotePrefix & bulletPrefix & working & vbCrLf
                Dim startIdx = rtb.TextLength
                rtb.AppendText(textLine)
                Dim lineLen = textLine.Length - vbCrLf.Length
                rtb.Select(startIdx, lineLen)
                rtb.SelectionFont = New Font(rtb.Font.FontFamily, size, FontStyle.Regular)

                For Each span In styleSpans
                    Dim spanStart = startIdx + quotePrefix.Length + bulletPrefix.Length + span.Start
                    rtb.Select(spanStart, span.Length)
                    rtb.SelectionFont = New Font(rtb.SelectionFont, span.Style)
                Next

                rtb.Select(rtb.TextLength, 0)
            Next
            Return True
        Catch
            Return False
        End Try
    End Function
End Module
