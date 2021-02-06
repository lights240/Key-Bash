Public Class Form1

    Public player1Released = True, player2Released = True
    Public players As Dictionary(Of Keys, Player) = New Dictionary(Of Keys, Player)
    Public since As Date = New DateTime(1970, 1, 1), start As Date

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        players.Add(Keys.D, New Player(player1, Keys.D, labelPlayer1, "Player 1"))
        players.Add(Keys.C, New Player(player2, Keys.C, labelPlayer2, "Player 2"))
        start = DateTime.Now
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not wonLabel.Visible Then
            timerLabel.Text = CStr(Math.Round((DateTime.Now - start).TotalMilliseconds / 1000, 2)) + " seconds"
        End If

        If players.Count > 0 Then
            For Each player As Player In players.Values
                player.update()

                If player.won Then
                    If Not wonLabel.Visible Then
                        wonLabel.Text = player.name + " has won!"
                        wonLabel.Visible = True
                        restartButton.Visible = True
                        restartButton.Enabled = True
                    End If
                End If

            Next
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If players.Count > 0 Then
            For Each player As Player In players.Values
                player.KeyUp(e)
            Next
        End If
    End Sub

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles restartButton.Click
        For Each player As Player In players.Values
            player.won = False
            player.pictureBox.Left = player.startingX
            player.velocX = 0
        Next
        start = DateTime.Now
        wonLabel.Visible = False
        restartButton.Visible = False
        restartButton.Enabled = False
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If players.Count > 0 Then
            For Each player As Player In players.Values
                player.KeyDown(e)
            Next
        End If
    End Sub


End Class
