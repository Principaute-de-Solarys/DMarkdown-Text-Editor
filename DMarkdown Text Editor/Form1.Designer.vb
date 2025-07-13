<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DMarkdown
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DMarkdown))
        RichTextBox1 = New RichTextBox()
        MenuStrip1 = New MenuStrip()
        NewToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem1 = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        BoldToolStripMenuItem = New ToolStripMenuItem()
        ItalicToolStripMenuItem = New ToolStripMenuItem()
        UnderlineToolStripMenuItem = New ToolStripMenuItem()
        StrikethroughToolStripMenuItem = New ToolStripMenuItem()
        IncreaseSizeToolStripMenuItem = New ToolStripMenuItem()
        DecreaseSizeToolStripMenuItem = New ToolStripMenuItem()
        DecreaseIndentationToolStripMenuItem = New ToolStripMenuItem()
        IndentToolStripMenuItem = New ToolStripMenuItem()
        UnorderedListToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBox1.BackColor = SystemColors.ControlDark
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Location = New Point(0, 35)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(784, 326)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlDarkDark
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {NewToolStripMenuItem, SaveToolStripMenuItem, SaveToolStripMenuItem1, OpenToolStripMenuItem, ExportToolStripMenuItem, BoldToolStripMenuItem, ItalicToolStripMenuItem, UnderlineToolStripMenuItem, StrikethroughToolStripMenuItem, IncreaseSizeToolStripMenuItem, DecreaseSizeToolStripMenuItem, DecreaseIndentationToolStripMenuItem, IndentToolStripMenuItem, UnorderedListToolStripMenuItem, SettingsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(784, 32)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewToolStripMenuItem.Image = My.Resources.Resources.NewDocument
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(36, 28)
        NewToolStripMenuItem.Text = "New document"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripMenuItem.Image = My.Resources.Resources.SaveAs
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.S
        SaveToolStripMenuItem.Size = New Size(36, 28)
        SaveToolStripMenuItem.Text = "Save as"
        ' 
        ' SaveToolStripMenuItem1
        ' 
        SaveToolStripMenuItem1.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripMenuItem1.Image = My.Resources.Resources.Save
        SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        SaveToolStripMenuItem1.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem1.Size = New Size(36, 28)
        SaveToolStripMenuItem1.Text = "Save"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripMenuItem.Image = My.Resources.Resources.OpenFile
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(36, 28)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        ExportToolStripMenuItem.Image = My.Resources.Resources.Export
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.E
        ExportToolStripMenuItem.Size = New Size(36, 28)
        ExportToolStripMenuItem.Text = "Export as messages"
        ' 
        ' BoldToolStripMenuItem
        ' 
        BoldToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        BoldToolStripMenuItem.Image = My.Resources.Resources.Bold
        BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        BoldToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.B
        BoldToolStripMenuItem.Size = New Size(36, 28)
        BoldToolStripMenuItem.Text = "Bold"
        ' 
        ' ItalicToolStripMenuItem
        ' 
        ItalicToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        ItalicToolStripMenuItem.Image = My.Resources.Resources.Italic
        ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem"
        ItalicToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.I
        ItalicToolStripMenuItem.Size = New Size(36, 28)
        ItalicToolStripMenuItem.Text = "Italic"
        ' 
        ' UnderlineToolStripMenuItem
        ' 
        UnderlineToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        UnderlineToolStripMenuItem.Image = My.Resources.Resources.Underline
        UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem"
        UnderlineToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.U
        UnderlineToolStripMenuItem.Size = New Size(36, 28)
        UnderlineToolStripMenuItem.Text = "Underline"
        ' 
        ' StrikethroughToolStripMenuItem
        ' 
        StrikethroughToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        StrikethroughToolStripMenuItem.Image = My.Resources.Resources.StrikeThrough
        StrikethroughToolStripMenuItem.Name = "StrikethroughToolStripMenuItem"
        StrikethroughToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.T
        StrikethroughToolStripMenuItem.Size = New Size(36, 28)
        StrikethroughToolStripMenuItem.Text = "Strike through"
        ' 
        ' IncreaseSizeToolStripMenuItem
        ' 
        IncreaseSizeToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        IncreaseSizeToolStripMenuItem.Image = My.Resources.Resources.IncreaseFontSize
        IncreaseSizeToolStripMenuItem.Name = "IncreaseSizeToolStripMenuItem"
        IncreaseSizeToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.Up
        IncreaseSizeToolStripMenuItem.Size = New Size(36, 28)
        IncreaseSizeToolStripMenuItem.Text = "Increase size"
        ' 
        ' DecreaseSizeToolStripMenuItem
        ' 
        DecreaseSizeToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        DecreaseSizeToolStripMenuItem.Image = My.Resources.Resources.DecreaseFontSize
        DecreaseSizeToolStripMenuItem.Name = "DecreaseSizeToolStripMenuItem"
        DecreaseSizeToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.Down
        DecreaseSizeToolStripMenuItem.Size = New Size(36, 28)
        DecreaseSizeToolStripMenuItem.Text = "Decrease size"
        ' 
        ' DecreaseIndentationToolStripMenuItem
        ' 
        DecreaseIndentationToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        DecreaseIndentationToolStripMenuItem.Image = My.Resources.Resources.DecreaseIndent
        DecreaseIndentationToolStripMenuItem.Name = "DecreaseIndentationToolStripMenuItem"
        DecreaseIndentationToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Left
        DecreaseIndentationToolStripMenuItem.Size = New Size(36, 28)
        DecreaseIndentationToolStripMenuItem.Text = "Decrease indentation"
        ' 
        ' IndentToolStripMenuItem
        ' 
        IndentToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndentToolStripMenuItem.Image = My.Resources.Resources.IncreaseIndent
        IndentToolStripMenuItem.Name = "IndentToolStripMenuItem"
        IndentToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Right
        IndentToolStripMenuItem.Size = New Size(36, 28)
        IndentToolStripMenuItem.Text = "Indent"
        ' 
        ' UnorderedListToolStripMenuItem
        ' 
        UnorderedListToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        UnorderedListToolStripMenuItem.Image = My.Resources.Resources.RadioButtonList
        UnorderedListToolStripMenuItem.Name = "UnorderedListToolStripMenuItem"
        UnorderedListToolStripMenuItem.ShortcutKeyDisplayString = ""
        UnorderedListToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.L
        UnorderedListToolStripMenuItem.Size = New Size(36, 28)
        UnorderedListToolStripMenuItem.Text = "Unordered list"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        SettingsToolStripMenuItem.Image = My.Resources.Resources.Settings
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        SettingsToolStripMenuItem.Size = New Size(36, 28)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' DMarkdown
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(784, 361)
        Controls.Add(MenuStrip1)
        Controls.Add(RichTextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(800, 400)
        Name = "DMarkdown"
        Text = "DMarkdown Text Editor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoldToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItalicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnderlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncreaseSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecreaseSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StrikethroughToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecreaseIndentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnorderedListToolStripMenuItem As ToolStripMenuItem

End Class
