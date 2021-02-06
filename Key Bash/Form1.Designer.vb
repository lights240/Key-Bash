<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.labelPlayer1 = New System.Windows.Forms.Label()
        Me.labelPlayer2 = New System.Windows.Forms.Label()
        Me.player1 = New System.Windows.Forms.PictureBox()
        Me.player2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wonLabel = New System.Windows.Forms.Label()
        Me.restartButton = New System.Windows.Forms.Button()
        Me.timerLabel = New System.Windows.Forms.Label()
        CType(Me.player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelPlayer1
        '
        Me.labelPlayer1.AutoSize = True
        Me.labelPlayer1.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlayer1.ForeColor = System.Drawing.Color.White
        Me.labelPlayer1.Location = New System.Drawing.Point(147, 9)
        Me.labelPlayer1.Name = "labelPlayer1"
        Me.labelPlayer1.Size = New System.Drawing.Size(72, 31)
        Me.labelPlayer1.TabIndex = 0
        Me.labelPlayer1.Text = "0.0%"
        '
        'labelPlayer2
        '
        Me.labelPlayer2.AutoSize = True
        Me.labelPlayer2.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlayer2.ForeColor = System.Drawing.Color.White
        Me.labelPlayer2.Location = New System.Drawing.Point(1335, 9)
        Me.labelPlayer2.Name = "labelPlayer2"
        Me.labelPlayer2.Size = New System.Drawing.Size(72, 31)
        Me.labelPlayer2.TabIndex = 0
        Me.labelPlayer2.Text = "0.0%"
        '
        'player1
        '
        Me.player1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.player1.Location = New System.Drawing.Point(27, 370)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(100, 50)
        Me.player1.TabIndex = 1
        Me.player1.TabStop = False
        '
        'player2
        '
        Me.player2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.player2.Location = New System.Drawing.Point(27, 500)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(100, 50)
        Me.player2.TabIndex = 1
        Me.player2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1222, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Player 2:"
        '
        'wonLabel
        '
        Me.wonLabel.AutoSize = True
        Me.wonLabel.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wonLabel.ForeColor = System.Drawing.Color.White
        Me.wonLabel.Location = New System.Drawing.Point(626, 9)
        Me.wonLabel.Name = "wonLabel"
        Me.wonLabel.Size = New System.Drawing.Size(0, 31)
        Me.wonLabel.TabIndex = 0
        Me.wonLabel.Visible = False
        '
        'restartButton
        '
        Me.restartButton.Enabled = False
        Me.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.restartButton.Font = New System.Drawing.Font("Raleway", 15.0!)
        Me.restartButton.ForeColor = System.Drawing.Color.White
        Me.restartButton.Location = New System.Drawing.Point(644, 112)
        Me.restartButton.Name = "restartButton"
        Me.restartButton.Size = New System.Drawing.Size(181, 66)
        Me.restartButton.TabIndex = 2
        Me.restartButton.Text = "Restart"
        Me.restartButton.UseVisualStyleBackColor = True
        Me.restartButton.Visible = False
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerLabel.ForeColor = System.Drawing.Color.White
        Me.timerLabel.Location = New System.Drawing.Point(654, 63)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(166, 31)
        Me.timerLabel.TabIndex = 3
        Me.timerLabel.Text = "0.0 seconds"
        Me.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1458, 677)
        Me.Controls.Add(Me.timerLabel)
        Me.Controls.Add(Me.restartButton)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelPlayer2)
        Me.Controls.Add(Me.wonLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelPlayer1)
        Me.Name = "Form1"
        Me.Text = "Key Bash"
        CType(Me.player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelPlayer1 As Label
    Friend WithEvents labelPlayer2 As Label
    Friend WithEvents player1 As PictureBox
    Friend WithEvents player2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents wonLabel As Label
    Friend WithEvents restartButton As Button
    Friend WithEvents timerLabel As Label
End Class
