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
        Me.directoryBox = New System.Windows.Forms.TextBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.pageToOpenBar = New System.Windows.Forms.TextBox()
        Me.textToSend = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'directoryBox
        '
        Me.directoryBox.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.directoryBox.Location = New System.Drawing.Point(12, 12)
        Me.directoryBox.Name = "directoryBox"
        Me.directoryBox.Size = New System.Drawing.Size(221, 20)
        Me.directoryBox.TabIndex = 0
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(12, 227)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 2
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'pageToOpenBar
        '
        Me.pageToOpenBar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.pageToOpenBar.Location = New System.Drawing.Point(14, 45)
        Me.pageToOpenBar.Name = "pageToOpenBar"
        Me.pageToOpenBar.Size = New System.Drawing.Size(128, 20)
        Me.pageToOpenBar.TabIndex = 3
        '
        'textToSend
        '
        Me.textToSend.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.textToSend.Location = New System.Drawing.Point(16, 78)
        Me.textToSend.Multiline = True
        Me.textToSend.Name = "textToSend"
        Me.textToSend.Size = New System.Drawing.Size(217, 136)
        Me.textToSend.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 262)
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

End Class
