Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Record
    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'app position to center screen  
        Dim screen As Screen = Screen.FromPoint(Me.Location)
        Dim x As Integer = screen.WorkingArea.Width / 2 - Me.Width / 2
        Dim y As Integer = screen.WorkingArea.Height / 2 - Me.Height / 2
        Me.Location = New Point(x, y)


        'call GetConnection() from dbconnection.vb
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
        'adapting query
        Dim adapter As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM personalinfotb", conn)
        Dim table As New DataTable()
        'showing data in datagridview
        adapter.Fill(table)
        personinfoview.DataSource = table

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'exit application
        Dim ex As DialogResult
        ex = MessageBox.Show("Are you sure you want to close the application?", "EXIT", MessageBoxButtons.YesNo)
        If ex = DialogResult.No Then

        Else
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'navigate to dashboard file
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        'call GetConnection() from dbconnection.vb
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
        'searchvalue variable 
        Dim searchValue As String = searchbox.Text
        'selecting colums
        Dim query As String = "SELECT * FROM personalinfotb WHERE Last_Name Like '%" & searchValue & "%' OR First_Name LIKE '%" & searchValue & "%' OR Middle_Name LIKE '%" & searchValue & "%' OR Suffix LIKE '%" & searchValue & "%' OR Household_ID LIKE '%" & searchValue & "%' OR Purok LIKE '%" & searchValue & "%' OR Civil_Status LIKE '%" & searchValue & "%' OR Gender LIKE '%" & searchValue & "%' OR Birthdate LIKE '%" & searchValue & "%' OR Contact_No LIKE '%" & searchValue & "%'"
        'use db
        Using command As New OleDbCommand(query, conn)
            'adapting query
            Dim adapter As New OleDbDataAdapter(command)
            Dim table As New DataTable()
            'showing data in datagridview
            adapter.Fill(table)
            personinfoview.DataSource = table
        End Using
    End Sub

    Public Sub personinfoview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles personinfoview.CellContentClick
        ' Get the index of the selected row
        Dim rowIndex As Integer = e.RowIndex
        ' Load the data of the selected row to the input controls
        If rowIndex >= 0 Then
            'declair variable
            Dim row As DataGridViewRow = personinfoview.Rows(rowIndex)
            Dim Last_Name, First_Name, Middle_Name, Suffix, Household_ID, Purok, Civil_Status, Gender, Birthdate, Contact_No As String
            ' Set the values of the input controls
            Last_Name = row.Cells("Last_Name").Value.ToString()
            First_Name = row.Cells("First_Name").Value.ToString()
            Middle_Name = row.Cells("Middle_Name").Value.ToString()
            Suffix = row.Cells("Suffix").Value.ToString()
            Household_ID = row.Cells("Household_ID").Value.ToString()
            Purok = row.Cells("Purok").Value.ToString()
            Civil_Status = row.Cells("Civil_Status").Value.ToString()
            Gender = row.Cells("Gender").Value.ToString()
            Birthdate = row.Cells("Birthdate").Value.ToString()
            Contact_No = row.Cells("Contact_No").Value.ToString()

            ' Pass the variables to onclickeddata method
            onclickeddata(Last_Name, First_Name, Middle_Name, Suffix, Household_ID, Purok, Civil_Status, Gender, Birthdate, Contact_No)
        End If
    End Sub
    Public Sub onclickeddata(Last_Name As String, First_Name As String, Middle_Name As String, Suffix As String, Household_ID As String, Purok As String, Civil_Status As String, Gender As String, Birthdate As String, Contact_No As String)
        'i'm not done here
        'todo: archive
    End Sub
End Class