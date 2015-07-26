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
        Me.components = New System.ComponentModel.Container()
        Me.directoryBox = New System.Windows.Forms.TextBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.pageToOpenBar = New System.Windows.Forms.TextBox()
        Me.textToSend = New System.Windows.Forms.TextBox()
        Me.SearchFileButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.pageToLoadToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.fileDirectoryToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'directoryBox
        '
        Me.directoryBox.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.directoryBox.Location = New System.Drawing.Point(12, 12)
        Me.directoryBox.Name = "directoryBox"
        Me.directoryBox.Size = New System.Drawing.Size(166, 20)
        Me.directoryBox.TabIndex = 0
        Me.directoryBox.Text = "Diretoria do Ficheiro"
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(12, 227)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 4
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'pageToOpenBar
        '
        Me.pageToOpenBar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.pageToOpenBar.Location = New System.Drawing.Point(14, 45)
        Me.pageToOpenBar.Name = "pageToOpenBar"
        Me.pageToOpenBar.Size = New System.Drawing.Size(128, 20)
        Me.pageToOpenBar.TabIndex = 2
        Me.pageToOpenBar.Text = "Folha do Ficheiro"
        '
        'textToSend
        '
        Me.textToSend.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.textToSend.Location = New System.Drawing.Point(16, 78)
        Me.textToSend.Multiline = True
        Me.textToSend.Name = "textToSend"
        Me.textToSend.Size = New System.Drawing.Size(217, 136)
        Me.textToSend.TabIndex = 3
        Me.textToSend.Text = "Escreva o texto a enviar aqui"
        '
        'SearchFileButton
        '
        Me.SearchFileButton.Location = New System.Drawing.Point(184, 11)
        Me.SearchFileButton.Name = "SearchFileButton"
        Me.SearchFileButton.Size = New System.Drawing.Size(59, 20)
        Me.SearchFileButton.TabIndex = 1
        Me.SearchFileButton.Text = "Procurar"
        Me.SearchFileButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'pageToLoadToolTip
        '
        Me.pageToLoadToolTip.AutomaticDelay = 100
        Me.pageToLoadToolTip.ShowAlways = True
        '
        'fileDirectoryToolTip
        '
        Me.fileDirectoryToolTip.AutomaticDelay = 100
        Me.fileDirectoryToolTip.ShowAlways = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 262)
        Me.Controls.Add(Me.SearchFileButton)
        Me.Controls.Add(Me.textToSend)
        Me.Controls.Add(Me.pageToOpenBar)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.directoryBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents directoryBox As System.Windows.Forms.TextBox
    Friend WithEvents startButton As System.Windows.Forms.Button
    Friend WithEvents pageToOpenBar As System.Windows.Forms.TextBox
    Friend WithEvents textToSend As System.Windows.Forms.TextBox
    Friend WithEvents SearchFileButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pageToLoadToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents fileDirectoryToolTip As System.Windows.Forms.ToolTip

End Class
