Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1

    Function howBig() As Long
        Dim lenght As Long

        lenght = workSheet.Range("A" & workSheet.Rows.Count).End(Excel.XlDirection.xlUp).Row

        Return lenght
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        workBook = App.Workbooks.Open(directoryBox.Text)
        workSheet = App.Worksheets(pageToOpenBar.Text)
        range = workSheet.Range("A1", howBig().ToString)
        length = howBig()
        startCycle()
    End Sub
End Class
