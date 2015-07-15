Imports System.IO
Module Module1
    Public Ficheiros(4) As String
    Public ContFic As Byte = 0

    Function ExisteFic(ByVal fic As String) As Boolean
        ExisteFic = False

        For i = 0 To 4
            If Ficheiros(i) = fic Then
                ExisteFic = True
                Exit For
            End If
        Next
    End Function
    Sub Main()
        'Este bloco escreve
        Dim i As Integer
        Dim oEscrever As StreamWriter
        oEscrever = File.CreateText("c:\teste.txt")
        For i = 1 To 10
            oEscrever.WriteLine("linha:" & i.ToString)
        Next
        oEscrever.Close()

        'Este bloco lê
        Dim oLeitura As StreamReader
        Dim Linha As String = ""
        oLeitura = File.OpenText("c:\teste.txt")
        While Not oLeitura.EndOfStream
            Linha = Linha & oLeitura.ReadLine & Chr(13)
        End While
        'MsgBox(Linha)
        oLeitura.Close()
    End Sub

    Function nmFic(ByVal fic As String) As String
        nmFic = Mid(StrReverse(fic), 1, InStr(StrReverse(fic), "\") - 1)
        nmFic = StrReverse(nmFic)
    End Function
End Module
