Public Class Player

    Public pictureBox As PictureBox
    Public won As Boolean = False
    Public name As String
    Public moveSpeed = 20, velocX As Double, friction As Double = 0.83, percent = 0
    Public startingX As Int16
    Private keyReleased As Boolean = True
    Private key As Keys = Keys.D
    Private label As Label

    Public Sub New(player As PictureBox, key As Keys, label As Label, name As String)
        Me.pictureBox = player
        Me.key = key
        Me.startingX = pictureBox.Left
        Me.label = label
        Me.name = name
    End Sub

    Public Sub update()
        If Not won Then
            If velocX > 0 Then
                pictureBox.Left += (moveSpeed * velocX)
                velocX *= friction
            End If

            percent = Math.Min(1, ((pictureBox.Left + pictureBox.Width) - startingX) / (Form1.Width - (pictureBox.Width / 2)))

            If percent < 0.1 Then
                percent = 0
            End If

            label.Text = CStr(Math.Round(percent * 100, 2)) + "%"

            If percent >= 1 Then
                won = True
            End If
            velocX = Math.Max(0, velocX)
        End If
    End Sub

    Public Sub KeyUp(e As KeyEventArgs)
        If Not won And e.KeyCode = key Then
            keyReleased = True
        End If
    End Sub

    Public Sub KeyDown(e As KeyEventArgs)
        If Not won And keyReleased Then
            If e.KeyCode = key Then
                velocX = 1
                pictureBox.Left += 20
                keyReleased = False
            End If
        End If
    End Sub

End Class
