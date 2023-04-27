Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'app position to center screen  
        Dim screen As Screen = Screen.FromPoint(Me.Location)
        Dim x As Integer = screen.WorkingArea.Width / 2 - Me.Width / 2
        Dim y As Integer = screen.WorkingArea.Height / 2 - Me.Height / 2
        Me.Location = New Point(x, y)

    End Sub
    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        'exit application
        Dim ex As DialogResult
        ex = MessageBox.Show("Are you sure you want to EXIT OPERATION?", "EXIT", MessageBoxButtons.YesNo)
        If ex = DialogResult.No Then

        Else
            Application.Exit()
        End If
    End Sub
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        'navigate to addperson file
        AddPerson.Show()
        Me.Hide()
    End Sub

    Private Sub residentsbtn_Click(sender As Object, e As EventArgs) Handles residentsbtn.Click
        'navigate to record file
        Record.Show()
        Me.Hide()
    End Sub
End Class