Imports System.IO
Imports System.Net

Public Class alts
    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Me.Hide()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim Acc As String = FlatListBox1.SelectedItem
        Process.Start("https://namemc.com/" + Acc)
    End Sub
End Class