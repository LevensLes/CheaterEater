Public Class Form2
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        If FlatTextBox2.Text = ("nigger") Then
            Form1.FlatToggle1.Checked = False
            Form1.FlatToggle1.Enabled = True
            Form1.FlatToggle1.Refresh()

            Me.Close()

        Else
            MessageBox.Show("Incorect Password",
        "Error",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1)

            If Form1.FlatToggle1.Checked = True Then
                Form1.FlatToggle1.Enabled = True
                Form1.FlatToggle1.Refresh()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Form1.FlatToggle1.Checked = True
        Form1.FlatToggle1.Enabled = True
        Form1.FlatToggle1.Refresh()

        Me.Hide()
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
End Class