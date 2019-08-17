<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ofdOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lblStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfdSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.msMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ttpMDIForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.ssStatusStrip.SuspendLayout()
        Me.msMenuStrip.SuspendLayout()
        Me.tsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 403)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ofdOpenFileDialog
        '
        Me.ofdOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'lblStatusLabel
        '
        Me.lblStatusLabel.Name = "lblStatusLabel"
        Me.lblStatusLabel.Size = New System.Drawing.Size(75, 20)
        Me.lblStatusLabel.Text = "Welcome!"
        '
        'ssStatusStrip
        '
        Me.ssStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusLabel})
        Me.ssStatusStrip.Location = New System.Drawing.Point(0, 425)
        Me.ssStatusStrip.Name = "ssStatusStrip"
        Me.ssStatusStrip.Size = New System.Drawing.Size(800, 25)
        Me.ssStatusStrip.TabIndex = 15
        Me.ssStatusStrip.Text = "StatusStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        Me.AboutToolStripMenuItem.ToolTipText = "To see the more information"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Tag = ""
        Me.HelpToolStripMenuItem.Text = "He&lp"
        Me.HelpToolStripMenuItem.ToolTipText = "Help menu"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        Me.TileHorizontalToolStripMenuItem.ToolTipText = "To make file's horizontal screen"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        Me.TileVerticalToolStripMenuItem.ToolTipText = "To make file's vertical screen"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.CascadeToolStripMenuItem.Text = "Casca&de"
        Me.CascadeToolStripMenuItem.ToolTipText = "To cascade the file screen "
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.WindowsToolStripMenuItem.Text = "&Windows"
        Me.WindowsToolStripMenuItem.ToolTipText = "Windows menu"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        Me.PasteToolStripMenuItem.ToolTipText = "Paste cut/copied text"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CopyToolStripMenuItem.Text = "Cop&y"
        Me.CopyToolStripMenuItem.ToolTipText = "Copy selected text"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CutToolStripMenuItem.Text = "C&ut"
        Me.CutToolStripMenuItem.ToolTipText = "Cut selected text"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.ToolTipText = "Edit menu"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CloseToolStripMenuItem.Text = "&Close"
        Me.CloseToolStripMenuItem.ToolTipText = "Close file"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        Me.SaveAsToolStripMenuItem.ToolTipText = "To save a file already exist with different name"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        Me.SaveToolStripMenuItem.ToolTipText = "To save file"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.OpenToolStripMenuItem.Text = "&Open"
        Me.OpenToolStripMenuItem.ToolTipText = "To open existing file"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.NewToolStripMenuItem.Text = "&New"
        Me.NewToolStripMenuItem.ToolTipText = "To generate new file"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        Me.FileToolStripMenuItem.ToolTipText = "File menu"
        '
        'msMenuStrip
        '
        Me.msMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.msMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.msMenuStrip.MdiWindowListItem = Me.WindowsToolStripMenuItem
        Me.msMenuStrip.Name = "msMenuStrip"
        Me.msMenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.msMenuStrip.TabIndex = 13
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'tsToolStrip
        '
        Me.tsToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton})
        Me.tsToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.tsToolStrip.Name = "tsToolStrip"
        Me.tsToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.tsToolStrip.TabIndex = 14
        Me.tsToolStrip.Text = "ToolStrip1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ssStatusStrip)
        Me.Controls.Add(Me.tsToolStrip)
        Me.Controls.Add(Me.msMenuStrip)
        Me.IsMdiContainer = True
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.MinimumSize = New System.Drawing.Size(818, 497)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.ssStatusStrip.ResumeLayout(False)
        Me.ssStatusStrip.PerformLayout()
        Me.msMenuStrip.ResumeLayout(False)
        Me.msMenuStrip.PerformLayout()
        Me.tsToolStrip.ResumeLayout(False)
        Me.tsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ofdOpenFileDialog As OpenFileDialog
    Friend WithEvents lblStatusLabel As ToolStripStatusLabel
    Friend WithEvents ssStatusStrip As StatusStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sfdSaveFileDialog As SaveFileDialog
    Friend WithEvents msMenuStrip As MenuStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents tsToolStrip As ToolStrip
    Friend WithEvents ttpMDIForm As ToolTip
End Class
