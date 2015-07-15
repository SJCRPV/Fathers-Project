<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hi_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ohai_SaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuzImBlackYoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlicktyBlackBlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AwwYeahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorDeFundoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_Yodawg = New System.Windows.Forms.TextBox()
        Me.dlg_Save = New System.Windows.Forms.SaveFileDialog()
        Me.dlg_Colour = New System.Windows.Forms.ColorDialog()
        Me.dlg_Font = New System.Windows.Forms.FontDialog()
        Me.dlg_Open = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.FormatarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Hi_Open, Me.HelloToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'Hi_Open
        '
        Me.Hi_Open.Name = "Hi_Open"
        Me.Hi_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.Hi_Open.Size = New System.Drawing.Size(169, 22)
        Me.Hi_Open.Text = "Hi (Open)"
        '
        'HelloToolStripMenuItem
        '
        Me.HelloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ohai_SaveFile, Me.YellowToolStripMenuItem})
        Me.HelloToolStripMenuItem.Name = "HelloToolStripMenuItem"
        Me.HelloToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.HelloToolStripMenuItem.Text = "Hello"
        '
        'Ohai_SaveFile
        '
        Me.Ohai_SaveFile.Name = "Ohai_SaveFile"
        Me.Ohai_SaveFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.Ohai_SaveFile.Size = New System.Drawing.Size(174, 22)
        Me.Ohai_SaveFile.Text = "Ohai (Save)"
        '
        'YellowToolStripMenuItem
        '
        Me.YellowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuzImBlackYoToolStripMenuItem, Me.BlicktyBlackBlackToolStripMenuItem})
        Me.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        Me.YellowToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.YellowToolStripMenuItem.Text = "Yellow"
        '
        'CuzImBlackYoToolStripMenuItem
        '
        Me.CuzImBlackYoToolStripMenuItem.Name = "CuzImBlackYoToolStripMenuItem"
        Me.CuzImBlackYoToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CuzImBlackYoToolStripMenuItem.Text = "Cuz I'm black yo!"
        '
        'BlicktyBlackBlackToolStripMenuItem
        '
        Me.BlicktyBlackBlackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AwwYeahToolStripMenuItem})
        Me.BlicktyBlackBlackToolStripMenuItem.Name = "BlicktyBlackBlackToolStripMenuItem"
        Me.BlicktyBlackBlackToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.BlicktyBlackBlackToolStripMenuItem.Text = "Blickty black black"
        '
        'AwwYeahToolStripMenuItem
        '
        Me.AwwYeahToolStripMenuItem.Name = "AwwYeahToolStripMenuItem"
        Me.AwwYeahToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.AwwYeahToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AwwYeahToolStripMenuItem.Text = "Aww yeah! (Exit)"
        '
        'FormatarToolStripMenuItem
        '
        Me.FormatarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorDeFundoToolStripMenuItem, Me.TextoToolStripMenuItem})
        Me.FormatarToolStripMenuItem.Name = "FormatarToolStripMenuItem"
        Me.FormatarToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.FormatarToolStripMenuItem.Text = "Formatar"
        '
        'CorDeFundoToolStripMenuItem
        '
        Me.CorDeFundoToolStripMenuItem.Name = "CorDeFundoToolStripMenuItem"
        Me.CorDeFundoToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CorDeFundoToolStripMenuItem.Text = "Cor de Fundo"
        '
        'TextoToolStripMenuItem
        '
        Me.TextoToolStripMenuItem.Name = "TextoToolStripMenuItem"
        Me.TextoToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TextoToolStripMenuItem.Text = "Texto"
        '
        'txt_Yodawg
        '
        Me.txt_Yodawg.Location = New System.Drawing.Point(0, 28)
        Me.txt_Yodawg.Multiline = True
        Me.txt_Yodawg.Name = "txt_Yodawg"
        Me.txt_Yodawg.Size = New System.Drawing.Size(284, 234)
        Me.txt_Yodawg.TabIndex = 1
        Me.txt_Yodawg.Text = "Yo dawg"
        '
        'dlg_Save
        '
        Me.dlg_Save.FileName = "3o3"
        Me.dlg_Save.Filter = "Ficheiros de texto (*.txt)|*.txt|Ficheiros de dados (*.dat)|*.dat"""
        Me.dlg_Save.Title = "Guardar como..."
        '
        'dlg_Font
        '
        Me.dlg_Font.ShowColor = True
        '
        'dlg_Open
        '
        Me.dlg_Open.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.txt_Yodawg)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hi_Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ohai_SaveFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuzImBlackYoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlicktyBlackBlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AwwYeahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_Yodawg As System.Windows.Forms.TextBox
    Friend WithEvents dlg_Save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FormatarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorDeFundoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlg_Colour As System.Windows.Forms.ColorDialog
    Friend WithEvents dlg_Font As System.Windows.Forms.FontDialog
    Friend WithEvents dlg_Open As System.Windows.Forms.OpenFileDialog
End Class
