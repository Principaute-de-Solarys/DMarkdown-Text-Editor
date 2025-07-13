Imports System.Net
Public Class Settings
    Dim ver As String = "0.0.0.1"
    Dim msgSizeErrStr As String = "The text entered for the size isn't in a valid format, please enter a number between 1 and 2 with a comma.", msgSizeErrTtl As String = "Error"
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SizeTxt.Text = My.Settings.taille
        If My.Settings.langue = "fr" Then
            LanguageLbl.Text = "Langue :"
            SizeLbl.Text = "Taille :"
            LanguageTxt.Text = "fr"
            msgSizeErrStr = "Le texte mis pour la taille n'est pas dans un format valide, mettez un nombre entre 1 et 2 avec une virgule."
            msgSizeErrTtl = "Erreur"
            ApplyBtn.Text = "Appliquer"
            CancelBtn.Text = "Annuler"
            UpdateBtn.Text = "Mettre à jour"
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub ApplyBtn_Click(sender As Object, e As EventArgs) Handles ApplyBtn.Click
        If LanguageTxt.Text = "en" OrElse LanguageTxt.Text = "fr" Then
            My.Settings.langue = LanguageTxt.Text
        Else
            MessageBox.Show("This language isn't supported, please try 'en' or 'fr'.", "Language error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            If CSng(SizeTxt.Text) >= 1 AndAlso CSng(SizeTxt.Text) <= 2 Then
                My.Settings.taille = CSng(SizeTxt.Text)
            Else
                MessageBox.Show(msgSizeErrStr, msgSizeErrTtl, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(msgSizeErrStr, msgSizeErrTtl, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DMarkdown.Close()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click

    End Sub
End Class