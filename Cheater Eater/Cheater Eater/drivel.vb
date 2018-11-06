Public Class drivel
    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Dim drive As String = FlatListBox1.SelectedItem
        Process.Start("explorer.exe", drive)
    End Sub
End Class