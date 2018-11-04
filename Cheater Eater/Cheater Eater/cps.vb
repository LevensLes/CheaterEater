Public Class cps
    Dim clickCount, TimeCount As UInteger
    Dim clickRate As Single


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        clickCount = 0
        clickRate = 0
        TimeCount = 0
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()

        If TimeBaseGenerator.Enabled = False Then
            TimeBaseGenerator.Enabled = True
        End If
        If clickCount < 99999999 Then
            clickCount += 1
            FlatTextBox2.Text = clickCount.ToString
        Else
            MessageBox.Show("Stop, God Dammit")
        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        clickCount = 0
        TimeCount = 0
        Timer1.Stop()
        FlatProgressBar1.Value = 0
        FlatTextBox1.ResetText()
        FlatTextBox2.ResetText()
        Button1.Enabled = True
        Button1.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FlatProgressBar1.Increment(1)
        If FlatProgressBar1.Value = 100 Then
            FlatProgressBar1.Value = 0
            TimeBaseGenerator.Stop()
            Button1.Enabled = False
            Button1.BackColor = Color.Gray
            Timer1.Stop()

        End If
    End Sub

    Private Sub TimeBaseGenerator_Tick(sender As Object, e As EventArgs) Handles TimeBaseGenerator.Tick
        TimeCount += 1
        clickRate = clickCount / TimeCount
        'ClickRateOut.Text = clickRate.ToString
        FlatTextBox1.Text = clickRate.ToString

    End Sub

End Class
