Public Class Form1

    Dim Counter As Integer




    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        Counter += 1


        If UnitMinutes.Checked Then
            If Counter = TimeValue.Value Then
                Counter = 0
                My.Computer.Audio.Play("C:\Windows\Media\notify.wav", AudioPlayMode.Background)
                MsgBox(TextReminder.Text)




            End If

        ElseIf UnitHours.Checked Then
            If Counter = TimeValue.Value * 60 Then
                MsgBox(TextReminder.Text)
                Counter = 0


            End If



        End If



    End Sub

    Private Sub ToggleTimer_CheckedChanged(sender As Object, e As EventArgs) Handles ToggleTimer.CheckedChanged
        If ToggleTimer.Checked Then
            Timer.Start()
        Else
            Timer.Stop()


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        NotifyIcon1.Visible = True
        NotifyIcon1.Text = "Open"
 

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub
End Class




