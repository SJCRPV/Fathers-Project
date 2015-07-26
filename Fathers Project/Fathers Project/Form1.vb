Imports Microsoft.Office.Interop.Excel
Imports System.IO

Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        Dim fileWriter As StreamWriter
        workBook = App.Workbooks.Open(directoryBox.Text)
        workSheet = App.Worksheets(pageToOpenBar.Text)
        range = workSheet.Range("A1", "A" & howBig().ToString)
        'fileWriter = File.CreateText("TextToSend.txt")
        fileWriter = New StreamWriter("TextToSend.txt", False, System.Text.Encoding.Default)
        fileWriter.WriteLine(textToSend.Text)
        fileWriter.Close()
        startCycle()
    End Sub
End Class
