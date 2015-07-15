Imports System.IO
Public Class Form1

    Private Sub Ohai_SaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ohai_SaveFile.Click
        dlg_Save.ShowDialog()
        Dim fic As String = dlg_Save.FileName

        If fic <> "" Then
            Dim oEscrever As StreamWriter
            oEscrever = File.CreateText(fic)
            oEscrever.WriteLine(txt_Yodawg.Text)
            oEscrever.Close()
        End If
    End Sub

    Private Sub CorDeFundoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorDeFundoToolStripMenuItem.Click
        dlg_Colour.ShowDialog()
        txt_Yodawg.BackColor = dlg_Colour.Color
    End Sub

    Private Sub TextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoToolStripMenuItem.Click
        dlg_Font.ShowDialog()
        txt_Yodawg.ForeColor = dlg_Font.Color
        txt_Yodawg.Font = dlg_Font.Font
    End Sub

    
    Private Sub Hi_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hi_Open.Click
        dlg_Open.ShowDialog()
        Dim fic As String = dlg_Open.FileName

        If fic <> "" Then
            Dim oLeitura As StreamReader
            Dim Linha As String = ""
            oLeitura = File.OpenText(fic)
            While Not oLeitura.EndOfStream
                'chr(13) = Enter, chr(10) = Quebra de Linha
                Linha = Linha & oLeitura.ReadLine & Chr(13) & Chr(10) '& são o mesmo que os +
            End While
            txt_Yodawg.Text = Linha
            oLeitura.Close()
            Me.Text = nmFic(fic)
            If Not ExisteFic(fic) Then
                MenuToolStripMenuItem.DropDownItems.Add(ContFic + 1 & " " & fic)
                Ficheiros(ContFic) = fic
                ContFic += 1
            End If
            

        End If
    End Sub

    Private Sub AwwYeahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AwwYeahToolStripMenuItem.Click
        Dim res As Integer = MsgBox("You bailin' on me, scrub?", vbQuestion + vbYesNoCancel, "Leavin'?")
        If res = vbYes Then
            End
        ElseIf res = vbCancel Then

        Else

        End If

    End Sub

    Private Sub MenuToolStripMenuItem_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuToolStripMenuItem.DropDownItemClicked
        'MsgBox(e.ClickedItem.Text)
        Dim f, a1 As String
        a1 = Microsoft.VisualBasic.Left(e.ClickedItem.Text, 1)

        If IsNumeric(a1) Then
            f = Ficheiros(CInt(a1) - 1)

            Dim oLeitura As StreamReader
            Dim Linha As String = ""
            oLeitura = File.OpenText(f)
            While Not oLeitura.EndOfStream
                'chr(13) = Enter, chr(10) = Quebra de Linha
                Linha = Linha & oLeitura.ReadLine & Chr(13) & Chr(10) '& são o mesmo que os +
            End While
            txt_Yodawg.Text = Linha
            oLeitura.Close()
            Me.Text = nmFic(f)
        End If
    End Sub

    Private Sub txt_Yodawg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Yodawg.TextChanged

    End Sub
End Class