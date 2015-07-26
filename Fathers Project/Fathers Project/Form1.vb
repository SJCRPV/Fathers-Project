Imports Microsoft.Office.Interop.Excel
Imports System.IO

Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        Dim fileWriter As StreamWriter
        workBook = App.Workbooks.Open(directoryBox.Text)
        If (String.Compare(pageToOpenBar.Text, defaultDirectoryText)) Then
            workSheet = App.Worksheets("Folha1")
        Else
            workSheet = App.Worksheets(pageToOpenBar.Text)
        End If

        range = workSheet.Range("A1", "A" & howBig().ToString)
        fileWriter = New StreamWriter("TextToSend.txt", False, System.Text.Encoding.Default)
        fileWriter.WriteLine(textToSend.Text)
        fileWriter.Close()
        startCycle()
    End Sub

    Private Sub SearchFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchFileButton.Click
        OpenFileDialog.ShowDialog()
        Dim fileDirectory As String = OpenFileDialog.FileName

        directoryBox.Text = fileDirectory
        directoryBox.ForeColor = Color.Black
    End Sub

    Private Sub directoryBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles directoryBox.Enter
        If (directoryBox.ForeColor <> Color.Black) Then
            defaultDirectoryText = directoryBox.Text
            directoryBox.Text = ""
            directoryBox.ForeColor = Color.Black
        End If

    End Sub

    Private Sub directoryBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles directoryBox.Leave
        If (directoryBox.Text = "") Then
            directoryBox.Text = defaultDirectoryText
            directoryBox.ForeColor = Color.DarkGray
        End If

    End Sub

    Private Sub pageToOpenBar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pageToOpenBar.Enter
        If (pageToOpenBar.ForeColor <> Color.Black) Then
            defaultPageToOpenText = pageToOpenBar.Text
            pageToOpenBar.Text = ""
            pageToOpenBar.ForeColor = Color.Black
        End If

    End Sub

    Private Sub pageToOpenBar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pageToOpenBar.Leave
        If (pageToOpenBar.Text = "") Then
            pageToOpenBar.Text = defaultPageToOpenText
            pageToOpenBar.ForeColor = Color.DarkGray
        End If

    End Sub

    Private Sub textToSend_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textToSend.Enter
        If (textToSend.ForeColor <> Color.Black) Then
            defaultTextToSendText = textToSend.Text
            textToSend.Text = ""
            textToSend.ForeColor = Color.Black
        End If

    End Sub

    Private Sub textToSend_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textToSend.Leave
        If (textToSend.Text = "") Then
            textToSend.Text = defaultTextToSendText
            textToSend.ForeColor = Color.DarkGray
        End If

    End Sub

    
    Private Sub pageToLoadToolTip_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles pageToLoadToolTip.Popup
        pageToLoadToolTip.SetToolTip(Me.pageToOpenBar, "Folha do ficheiro Excel a abrir. Se deixado em branco, irá assumir 'Folha1'")
    End Sub

    Private Sub fileDirectoryToolTip_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles fileDirectoryToolTip.Popup
        fileDirectoryToolTip.SetToolTip(Me.directoryBox, "A diretoria completa do ficheiro a abrir")
    End Sub
End Class
