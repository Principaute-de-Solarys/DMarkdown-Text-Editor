<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        ApplyBtn = New Button()
        CancelBtn = New Button()
        LanguageLbl = New Label()
        SizeLbl = New Label()
        LanguageTxt = New TextBox()
        SizeTxt = New TextBox()
        Label1 = New Label()
        updateBtn = New Button()
        nitroBtn = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' ApplyBtn
        ' 
        ApplyBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ApplyBtn.BackColor = SystemColors.Control
        ApplyBtn.Location = New Point(616, 326)
        ApplyBtn.Name = "ApplyBtn"
        ApplyBtn.Size = New Size(75, 23)
        ApplyBtn.TabIndex = 0
        ApplyBtn.Text = "Apply"
        ApplyBtn.UseVisualStyleBackColor = False
        ' 
        ' CancelBtn
        ' 
        CancelBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        CancelBtn.BackColor = SystemColors.Control
        CancelBtn.Location = New Point(697, 326)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(75, 23)
        CancelBtn.TabIndex = 1
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' LanguageLbl
        ' 
        LanguageLbl.AutoSize = True
        LanguageLbl.Location = New Point(12, 9)
        LanguageLbl.Name = "LanguageLbl"
        LanguageLbl.Size = New Size(65, 15)
        LanguageLbl.TabIndex = 2
        LanguageLbl.Text = "Language :"
        ' 
        ' SizeLbl
        ' 
        SizeLbl.AutoSize = True
        SizeLbl.Location = New Point(12, 38)
        SizeLbl.Name = "SizeLbl"
        SizeLbl.Size = New Size(33, 15)
        SizeLbl.TabIndex = 3
        SizeLbl.Text = "Size :"
        ' 
        ' LanguageTxt
        ' 
        LanguageTxt.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LanguageTxt.Location = New Point(172, 6)
        LanguageTxt.Name = "LanguageTxt"
        LanguageTxt.Size = New Size(600, 23)
        LanguageTxt.TabIndex = 4
        LanguageTxt.Text = "en"
        ' 
        ' SizeTxt
        ' 
        SizeTxt.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SizeTxt.Location = New Point(172, 35)
        SizeTxt.Name = "SizeTxt"
        SizeTxt.Size = New Size(600, 23)
        SizeTxt.TabIndex = 5
        SizeTxt.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 6
        Label1.Text = "Auto-update :"
        ' 
        ' updateBtn
        ' 
        updateBtn.Location = New Point(172, 63)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(600, 23)
        updateBtn.TabIndex = 7
        updateBtn.Text = "Button1"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' nitroBtn
        ' 
        nitroBtn.Location = New Point(172, 92)
        nitroBtn.Name = "nitroBtn"
        nitroBtn.Size = New Size(600, 23)
        nitroBtn.TabIndex = 9
        nitroBtn.Text = "Button1"
        nitroBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 8
        Label2.Text = "Discord Nitro :"
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(784, 361)
        Controls.Add(nitroBtn)
        Controls.Add(Label2)
        Controls.Add(updateBtn)
        Controls.Add(Label1)
        Controls.Add(SizeTxt)
        Controls.Add(LanguageTxt)
        Controls.Add(SizeLbl)
        Controls.Add(LanguageLbl)
        Controls.Add(CancelBtn)
        Controls.Add(ApplyBtn)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Settings"
        Text = "Settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ApplyBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents LanguageLbl As Label
    Friend WithEvents SizeLbl As Label
    Friend WithEvents LanguageTxt As TextBox
    Friend WithEvents SizeTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents nitroBtn As Button
    Friend WithEvents Label2 As Label
End Class
