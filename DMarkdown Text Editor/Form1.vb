Imports System.IO
Public Class DMarkdown
    Dim ver As String = "0.0.0.1"
    Dim msgNewDocStr As String = "Do you really want to create a new document ?", msgNewDocTtl As String = "New document", msgCloseSaveStr As String = "You are closing while your document isn't saved. Do you want to save it ?", msgCloseSaveTtl As String = "Unsaved"
    Dim dmd As String = "DMarkdown file|*.dmd"
    Dim curFile As String
    Dim normalSize As Single = 9 * My.Settings.taille, smallSize As Single = 7 * My.Settings.taille, h3Size As Single = 11 * My.Settings.taille, h2Size As Single = 13 * My.Settings.taille, h1Size As Single = 15 * My.Settings.taille
    Private Sub DMarkdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, normalSize, FontStyle.Regular)
        If My.Settings.langue = "fr" Then
            msgNewDocStr = "Voulez-vous vraiment créer un nouveau document ?"
            msgNewDocTtl = "Nouveau document"
            msgCloseSaveStr = "Vous êtes en train de fermer l'application alors que votre document n'est pas sauvegardé. Voulez-vous le sauvegarder ?"
            msgCloseSaveTtl = "Non sauvegardé"
            NewToolStripMenuItem.Text = "Nouveau document"
            SaveToolStripMenuItem.Text = "Sauvegarder en tant que..."
            SaveToolStripMenuItem1.Text = "Sauvegarder"
            OpenToolStripMenuItem.Text = "Ouvrir"
            ExportToolStripMenuItem.Text = "Exporter en messages"
            BoldToolStripMenuItem.Text = "Gras"
            ItalicToolStripMenuItem.Text = "Italique"
            UnderlineToolStripMenuItem.Text = "Souligner"
            StrikethroughToolStripMenuItem.Text = "Barrer"
            IncreaseSizeToolStripMenuItem.Text = "Augmenter la taille"
            DecreaseSizeToolStripMenuItem.Text = "Diminuer la taille"
            DecreaseIndentationToolStripMenuItem.Text = "Désindenter"
            IndentToolStripMenuItem.Text = "Indenter"
            UnorderedListToolStripMenuItem.Text = "Créer une liste"
            SettingsToolStripMenuItem.Text = "Paramètres"
            If Not My.Settings.dernier = "" Then
                Dim nomsDernier() As String = My.Settings.dernier.Split(New String() {"\"}, StringSplitOptions.None)
                Me.Text = "DMarkdown Text Editor - " & nomsDernier(nomsDernier.Length - 1)
                curFile = My.Settings.dernier
                MarkdownToRtf(RichTextBox1, IO.File.ReadAllText(curFile))
            Else
                Me.Text = "DMarkdown Text Editor - Sans titre"
            End If
        Else
            If Not My.Settings.dernier = "" Then
                Dim nomsDernier() As String = My.Settings.dernier.Split(New String() {"\"}, StringSplitOptions.None)
                Me.Text = "DMarkdown Text Editor - " & nomsDernier(nomsDernier.Length - 1)
                curFile = My.Settings.dernier
                MarkdownToRtf(RichTextBox1, IO.File.ReadAllText(curFile))
            Else
                Me.Text = "DMarkdown Text Editor - Untitled"
            End If
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If MessageBox.Show(msgNewDocStr, msgNewDocTtl, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            RichTextBox1.Clear()
            curFile = ""
            My.Settings.dernier = ""
            Me.Text = "DMarkdown Text Editor - Untitled"
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If Not Me.Text.Substring(Me.Text.Length - 1, 1) = "*" Then
            Me.Text = Me.Text & "*"
        End If
    End Sub
    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        If Not RichTextBox1.SelectionFont.Style = FontStyle.Bold AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Underline + FontStyle.Bold AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Strikeout + FontStyle.Bold AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Underline + FontStyle.Strikeout + FontStyle.Bold AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Underline + FontStyle.Strikeout Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style Or FontStyle.Bold)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style Xor FontStyle.Bold)
        End If
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        If Not RichTextBox1.SelectionFont.Style = FontStyle.Italic AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Strikeout + FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Underline + FontStyle.Strikeout Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style Or FontStyle.Italic)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style Xor FontStyle.Italic)
        End If
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click
        If Not RichTextBox1.SelectionFont.Style = FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Underline + FontStyle.Bold AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Underline + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Strikeout + FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Underline + FontStyle.Bold + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Underline + FontStyle.Strikeout Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style Or FontStyle.Underline)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style Xor FontStyle.Underline)
        End If
    End Sub

    Private Sub StrikethroughToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrikethroughToolStripMenuItem.Click
        If Not RichTextBox1.SelectionFont.Style = FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Strikeout + FontStyle.Bold AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Underline + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Strikeout + FontStyle.Underline AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Underline + FontStyle.Bold + FontStyle.Strikeout AndAlso Not RichTextBox1.SelectionFont.Style = FontStyle.Italic + FontStyle.Bold + FontStyle.Underline + FontStyle.Strikeout Then
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style Or FontStyle.Strikeout)
        Else
            RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style Xor FontStyle.Strikeout)
        End If
    End Sub

    Private Sub IncreaseSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseSizeToolStripMenuItem.Click
        If RichTextBox1.SelectionLength = 0 Then Exit Sub

        Dim startLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
        Dim endLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart + RichTextBox1.SelectionLength - 1)

        Dim startIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(startLine)
        Dim endIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(endLine) + RichTextBox1.Lines(endLine).Length

        RichTextBox1.Select(startIndex, endIndex - startIndex)

        For i = 0 To RichTextBox1.SelectionLength - 1
            RichTextBox1.Select(startIndex + i, 1)
            Dim f = RichTextBox1.SelectionFont
            If f Is Nothing Then Continue For

            Dim newSize As Single = f.Size
            If newSize = smallSize Then
                newSize = normalSize
            ElseIf newSize = normalSize Then
                newSize = h3Size
            ElseIf newSize = h3Size Then
                newSize = h2Size
            ElseIf newSize = h2Size Then
                newSize = h1Size
            Else
                Continue For
            End If

            RichTextBox1.SelectionFont = New Font(f.FontFamily, newSize, f.Style)
        Next

        RichTextBox1.Select(startIndex, endIndex - startIndex)
    End Sub

    Private Sub DecreaseSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseSizeToolStripMenuItem.Click
        If RichTextBox1.SelectionLength = 0 Then Exit Sub

        Dim startLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
        Dim endLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart + RichTextBox1.SelectionLength - 1)

        Dim startIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(startLine)
        Dim endIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(endLine) + RichTextBox1.Lines(endLine).Length

        RichTextBox1.Select(startIndex, endIndex - startIndex)

        For i = 0 To RichTextBox1.SelectionLength - 1
            RichTextBox1.Select(startIndex + i, 1)
            Dim f = RichTextBox1.SelectionFont
            If f Is Nothing Then Continue For

            Dim newSize As Single = f.Size
            If newSize = h1Size Then
                newSize = h2Size
            ElseIf newSize = h2Size Then
                newSize = h3Size
            ElseIf newSize = h3Size Then
                newSize = normalSize
            ElseIf newSize = normalSize Then
                newSize = smallSize
            Else
                Continue For
            End If

            RichTextBox1.SelectionFont = New Font(f.FontFamily, newSize, f.Style)
        Next

        RichTextBox1.Select(startIndex, endIndex - startIndex)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        save.Filter = dmd
        If save.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllText(save.FileName, RtfToMarkdown(RichTextBox1))
            curFile = save.FileName
            My.Settings.dernier = curFile
            Dim nomsDernier() As String = curFile.Split(New String() {"\"}, StringSplitOptions.None)
            Me.Text = "DMarkdown Text Editor - " & nomsDernier(nomsDernier.Length - 1)
        End If
    End Sub

    Private Sub IndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndentToolStripMenuItem.Click
        Dim startLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
        Dim endLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart + RichTextBox1.SelectionLength - 1)

        Dim startIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(startLine)
        Dim endIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(endLine) + RichTextBox1.Lines(endLine).Length

        RichTextBox1.Select(startIndex, endIndex - startIndex)

        Dim lines() = RichTextBox1.SelectedText.Split(New String() {vbLf}, StringSplitOptions.None)
        For i = 0 To lines.Length - 1
            If Not lines(i).StartsWith("> ") Then
                lines(i) = "> " & lines(i)
            End If
        Next

        Dim newText = String.Join(vbCrLf, lines)
        RichTextBox1.SelectedText = newText
        RichTextBox1.Select(startIndex, newText.Length)
    End Sub

    Private Sub DecreaseIndentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseIndentationToolStripMenuItem.Click
        Dim startLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
        Dim endLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart + RichTextBox1.SelectionLength - 1)

        Dim startIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(startLine)
        Dim endIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(endLine) + RichTextBox1.Lines(endLine).Length

        RichTextBox1.Select(startIndex, endIndex - startIndex)

        Dim lines() = RichTextBox1.SelectedText.Split(New String() {vbLf}, StringSplitOptions.None)
        For i = 0 To lines.Length - 1
            If lines(i).StartsWith("> ") OrElse lines(i).StartsWith("- ") Then
                lines(i) = lines(i).Substring(2)
            End If
        Next

        Dim newText = String.Join(vbCrLf, lines)
        RichTextBox1.SelectedText = newText
        RichTextBox1.Select(startIndex, newText.Length)
    End Sub

    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim pos = RichTextBox1.SelectionStart
            Dim currLine = RichTextBox1.GetLineFromCharIndex(pos)

            If currLine >= 0 AndAlso currLine < RichTextBox1.Lines.Length Then
                Dim prevLine = RichTextBox1.Lines(currLine)
                If prevLine.StartsWith("> ") Then
                    e.SuppressKeyPress = True
                    RichTextBox1.SelectedText = vbCrLf & "> "
                    If prevLine.StartsWith("> - ") AndAlso prevLine <> "> - " Then
                        RichTextBox1.SelectedText = "- "
                    End If
                ElseIf prevLine.StartsWith("- ") AndAlso prevLine <> "- " Then
                    e.SuppressKeyPress = True
                    RichTextBox1.SelectedText = vbCrLf & "- "
                End If
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        If curFile <> "" Then
            IO.File.WriteAllText(curFile, RtfToMarkdown(RichTextBox1))
            Dim nomsDernier() As String = curFile.Split(New String() {"\"}, StringSplitOptions.None)
            Me.Text = "DMarkdown Text Editor - " & nomsDernier(nomsDernier.Length - 1)
        Else
            SaveToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub DMarkdown_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Text.Substring(Me.Text.Length - 1, 1) = "*" Then
            Dim msgCloseSave = MessageBox.Show(msgCloseSaveStr, msgCloseSaveTtl, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            If msgCloseSave = DialogResult.Yes Then
                SaveToolStripMenuItem1.PerformClick()
            ElseIf msgCloseSave = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub UnorderedListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnorderedListToolStripMenuItem.Click
        Dim startLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
        Dim endLine As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart + RichTextBox1.SelectionLength - 1)

        Dim startIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(startLine)
        Dim endIndex As Integer = RichTextBox1.GetFirstCharIndexFromLine(endLine) + RichTextBox1.Lines(endLine).Length

        RichTextBox1.Select(startIndex, endIndex - startIndex)

        Dim lines() = RichTextBox1.SelectedText.Split(New String() {vbLf}, StringSplitOptions.None)
        For i = 0 To lines.Length - 1
            If Not lines(i).StartsWith("- ") Then
                lines(i) = "- " & lines(i)
            End If
        Next

        Dim newText = String.Join(vbCrLf, lines)
        RichTextBox1.SelectedText = newText
        RichTextBox1.Select(startIndex, newText.Length)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim open As New OpenFileDialog
        open.Filter = dmd
        If open.ShowDialog = DialogResult.OK Then
            Dim md = IO.File.ReadAllText(open.FileName)
            MarkdownToRtf(RichTextBox1, md)
            curFile = open.FileName
            My.Settings.dernier = curFile
            Dim nomsDernier() As String = curFile.Split(New String() {"\"}, StringSplitOptions.None)
            Me.Text = "DMarkdown Text Editor - " & nomsDernier(nomsDernier.Length - 1)
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub
End Class
