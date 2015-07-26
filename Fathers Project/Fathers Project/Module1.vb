Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Imports System.IO

Module Module1

    Public App As New Excel.Application
    Public workSheet As Excel.Worksheet
    Public workBook As Excel.Workbook
    Public range As Excel.Range
    Public length As Long

    Dim scriptFullPath As String
    Dim scriptDirectory As String
    Dim runningDirectory As String
    Dim addressWriter As StreamWriter
    Dim columns As Integer
    Dim rows As Integer
    Dim i As Integer
    Dim cycleOver As Boolean
    Dim cursor As Cursor

    Sub openProcesses()
        Try
            cursor = Cursors.AppStarting
            scriptFullPath = Path.Combine(scriptDirectory, "ProcessMacro.exe")
            Debug.WriteLine(scriptFullPath)
            Process.Start(scriptFullPath)
        Finally
            cursor = Cursors.Default
        End Try

    End Sub

    Function noteDownLinks() As String
        Dim tempString As String
        tempString = range.Hyperlinks(i).Address
        Return tempString
    End Function

    Sub convertToText(ByVal stringToConvert As String)
        addressWriter.WriteLine(stringToConvert)
    End Sub

    Public Function howBig() As Long
        Dim temp As Long

        temp = workSheet.Range("A" & workSheet.Rows.Count).End(Excel.XlDirection.xlUp).Row
        System.Diagnostics.Debug.WriteLine(temp)
        Return temp
    End Function

    Function getScriptDirectory() As String
        Dim tempString As String

        tempString = My.Computer.FileSystem.GetParentPath(runningDirectory)
        tempString = My.Computer.FileSystem.GetParentPath(tempString)
        tempString = My.Computer.FileSystem.GetParentPath(tempString)
        Return tempString
    End Function

    Function getRunningDirectory() As String
        Dim tempString As String

        tempString = System.Reflection.Assembly.GetExecutingAssembly().Location
        Return tempString
    End Function

    Public Sub startCycle()
        Dim addressContainer(howBig()) As String
        runningDirectory = getRunningDirectory()
        scriptDirectory = getScriptDirectory()
        openProcesses()
        addressWriter = File.CreateText("AddressList.txt")
        length = howBig()
        i = 1
        While i <= length
            addressContainer(i) = noteDownLinks()
            convertToText(addressContainer(i))
            i += 1
        End While
        addressWriter.Close()
        System.Threading.Thread.Sleep(1000)
        SendKeys.Send("^0")
        Debug.WriteLine("Cycle ended")
    End Sub
End Module
