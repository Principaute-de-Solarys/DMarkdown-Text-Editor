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
        UpdateBtn = New Button()
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
        ' UpdateBtn
        ' 
        UpdateBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        UpdateBtn.BackColor = SystemColors.Control
        UpdateBtn.Location = New Point(505, 326)
        UpdateBtn.Name = "UpdateBtn"
        UpdateBtn.Size = New Size(105, 23)
        UpdateBtn.TabIndex = 6
        UpdateBtn.Text = "Update"
        UpdateBtn.UseVisualStyleBackColor = False
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(784, 361)
        Controls.Add(UpdateBtn)
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
    Friend WithEvents UpdateBtn As Button
End Class
