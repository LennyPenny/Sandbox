Public Class Form1

    Dim FormMove As Boolean

    Dim Dif_X As Integer
    Dim Dif_Y As Integer

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    Dim ShowOptions As Boolean = False
    Dim Counter_AnimationFrames As Integer

    Dim DynamicColors As Boolean = True

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.BackColor = System.Drawing.Color.FromArgb(Me.Location.X / screenWidth * 256, Me.Location.Y / screenHeight * 256, Hour(Now) * 10)

    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        Dif_X = MousePosition.X - Me.Location.X
        Dif_Y = MousePosition.Y - Me.Location.Y

        FormMove = True

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If FormMove = True Then

            Me.Location = New Point(MousePosition.X - Dif_X, MousePosition.Y - Dif_Y)

            If DynamicColors = True Then

                Me.BackColor = System.Drawing.Color.FromArgb(Me.Location.X / screenWidth * 256, Me.Location.Y / screenHeight * 256, 100)

            Else : Me.BackColor = Color.White

            End If
        End If

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        FormMove = False

    End Sub

    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel

        Me.Opacity += e.Delta / 12000

    End Sub


    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim Pen_BlackLine As New Drawing.Pen(Color.Black, 3)
        e.Graphics.DrawRectangle(Pen_BlackLine, 1, 1, Me.Width - 3, Me.Height - 3)

        Button_Options.Location = New Point(100, Me.Height - 20)

    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click

        Me.Close()

    End Sub

    Private Sub Button_Options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Options.Click

        If ShowOptions = False Then

            ShowOptions = True

            Timer_Animation.Start()

        Else

            ShowOptions = False

            Timer_Animation.Start()

        End If

    End Sub

    Private Sub Timer_Animation_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Animation.Tick

        If ShowOptions = True Then

            If Me.Height < 499 Then

                Me.Height += 10

                Me.Invalidate()

            Else

                Timer_Animation.Stop()



            End If

        Else

            If Me.Height > 309 Then

                Me.Height -= 10

                Me.Invalidate()

            Else

                Timer_Animation.Stop()

            End If
        End If

    End Sub

    Private Sub Button_SwitchDynamicColors_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_SwitchDynamicColors.Click

        If DynamicColors = False Then

            DynamicColors = True
            Me.Invalidate()

        Else

            DynamicColors = False
            Me.Invalidate()

        End If



    End Sub
End Class
