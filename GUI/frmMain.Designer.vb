<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrderFormItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSummaryFormItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsNewWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsCloseAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsArrangeIcons = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout
        Me.StatusStrip.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.WindowsMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(919, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileSave, Me.mnuFileDelete, Me.mnuFileClose, Me.mnuFileExit})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOrderFormItem, Me.mnuSummaryFormItem})
        Me.mnuFileNew.Image = CType(resources.GetObject("mnuFileNew.Image"),System.Drawing.Image)
        Me.mnuFileNew.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileNew.Text = "&New"
        '
        'mnuOrderFormItem
        '
        Me.mnuOrderFormItem.Name = "mnuOrderFormItem"
        Me.mnuOrderFormItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
        Me.mnuOrderFormItem.Size = New System.Drawing.Size(198, 22)
        Me.mnuOrderFormItem.Text = "&Order Form"
        '
        'mnuSummaryFormItem
        '
        Me.mnuSummaryFormItem.Name = "mnuSummaryFormItem"
        Me.mnuSummaryFormItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U),System.Windows.Forms.Keys)
        Me.mnuSummaryFormItem.Size = New System.Drawing.Size(198, 22)
        Me.mnuSummaryFormItem.Text = "S&ummary Form"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileDelete
        '
        Me.mnuFileDelete.Name = "mnuFileDelete"
        Me.mnuFileDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D),System.Windows.Forms.Keys)
        Me.mnuFileDelete.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileDelete.Text = "&Delete"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L),System.Windows.Forms.Keys)
        Me.mnuFileClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileClose.Text = "C&lose"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E),System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(39, 20)
        Me.EditMenu.Text = "&Edit"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Image = CType(resources.GetObject("mnuEditCut.Image"),System.Drawing.Image)
        Me.mnuEditCut.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditCut.Text = "Cu&t"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Image = CType(resources.GetObject("mnuEditCopy.Image"),System.Drawing.Image)
        Me.mnuEditCopy.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditCopy.Text = "&Copy"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Image = CType(resources.GetObject("mnuEditPaste.Image"),System.Drawing.Image)
        Me.mnuEditPaste.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditPaste.Text = "&Paste"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsNewWindow, Me.WindowsCascade, Me.WindowsTileVertical, Me.WindowsTileHorizontal, Me.WindowsCloseAll, Me.WindowsArrangeIcons})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'WindowsNewWindow
        '
        Me.WindowsNewWindow.Name = "WindowsNewWindow"
        Me.WindowsNewWindow.Size = New System.Drawing.Size(151, 22)
        Me.WindowsNewWindow.Text = "&New Window"
        '
        'WindowsCascade
        '
        Me.WindowsCascade.Name = "WindowsCascade"
        Me.WindowsCascade.Size = New System.Drawing.Size(151, 22)
        Me.WindowsCascade.Text = "&Cascade"
        '
        'WindowsTileVertical
        '
        Me.WindowsTileVertical.Name = "WindowsTileVertical"
        Me.WindowsTileVertical.Size = New System.Drawing.Size(151, 22)
        Me.WindowsTileVertical.Text = "Tile &Vertical"
        '
        'WindowsTileHorizontal
        '
        Me.WindowsTileHorizontal.Name = "WindowsTileHorizontal"
        Me.WindowsTileHorizontal.Size = New System.Drawing.Size(151, 22)
        Me.WindowsTileHorizontal.Text = "Tile &Horizontal"
        '
        'WindowsCloseAll
        '
        Me.WindowsCloseAll.Name = "WindowsCloseAll"
        Me.WindowsCloseAll.Size = New System.Drawing.Size(151, 22)
        Me.WindowsCloseAll.Text = "C&lose All"
        '
        'WindowsArrangeIcons
        '
        Me.WindowsArrangeIcons.Name = "WindowsArrangeIcons"
        Me.WindowsArrangeIcons.Size = New System.Drawing.Size(151, 22)
        Me.WindowsArrangeIcons.Text = "&Arrange Icons"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 616)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(919, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 638)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.Text = "Cal Poly Coffee Roasters"
        Me.MenuStrip.ResumeLayout(false)
        Me.MenuStrip.PerformLayout
        Me.StatusStrip.ResumeLayout(false)
        Me.StatusStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents WindowsArrangeIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsCloseAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsNewWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsTileVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsTileHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOrderFormItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSummaryFormItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileDelete As System.Windows.Forms.ToolStripMenuItem

End Class
