Public Class Login
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'app position to center screen  
        Dim screen As Screen = Screen.FromPoint(Me.Location)
        Dim x As Integer = screen.WorkingArea.Width / 2 - Me.Width / 2
        Dim y As Integer = screen.WorkingArea.Height / 2 - Me.Height / 2
        Me.Location = New Point(x, y)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        'condition every try to login
        Dim attemp As Integer = 0
        If (userbox.Text = "fuse" And passbox.Text = "admin") Then
            Dashboard.Show()
            Me.Hide()
            passbox.Text = ""
            userbox.Text = ""
        Else
            passbox.Text = ""
            userbox.Text = ""
            userbox.Clear()
            userbox.Focus()
            attemp += 1
            MessageBox.Show("WARNING: INVALID INPUT!!!")
            'maximum of 5 try
            If attemp = 5 Then
                passbox.Text = ""
                passbox.Enabled = False
                userbox.Enabled = False
                signupbtn.Enabled = False
                MessageBox.Show("ERROR: TOO MANY ATTEMPS!!")
            End If
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'exit
        Application.Exit()
    End Sub
    Private Sub passbox_TextChanged(sender As Object, e As EventArgs) Handles passbox.TextChanged
        'Set the password character to unviewable
        passbox.PasswordChar = "*"
    End Sub
End Class
