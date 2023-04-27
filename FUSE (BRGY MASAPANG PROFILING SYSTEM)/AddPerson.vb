Imports System.Data.OleDb
Public Class AddPerson


    Private Sub AddPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'app position to center screen  
        Dim screen As Screen = Screen.FromPoint(Me.Location)
        Dim x As Integer = screen.WorkingArea.Width / 2 - Me.Width / 2
        Dim y As Integer = screen.WorkingArea.Height / 2 - Me.Height / 2
        Me.Location = New Point(x, y)

        'customize the bithdate format
        birthdatepicker.Format = DateTimePickerFormat.Custom
        birthdatepicker.CustomFormat = " "

    End Sub
    Sub clearText()
        'to clear the text
        lastnamebox.Text = ""
        firstnamebox.Text = ""
        middlenamebox.Text = ""
        suffixbox.Text = ""
        purokbox.Text = ""
        birthdatepicker.Text = ""
        genderbox.Text = ""
        civilstatusbox.Text = ""
        contactnumberbox.Text = ""
        householdbox.Text = ""
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
    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        'clear button
        clearText()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        'hold the user if the box is empty
        If String.IsNullOrEmpty(firstnamebox.Text) Then
            MessageBox.Show("Please fill the First Name.")
            Return
        End If

        If String.IsNullOrEmpty(lastnamebox.Text) Then
            MessageBox.Show("Please fill the Last Name")
            Return
        End If
        If String.IsNullOrEmpty(middlenamebox.Text) Then
            MessageBox.Show("Please fill the Middle Name.")
            Return
        End If

        If String.IsNullOrEmpty(householdbox.Text) Then
            MessageBox.Show("Please fill the Household ID.")
            Return
        End If

        If String.IsNullOrEmpty(purokbox.Text) Then
            MessageBox.Show("Please fill the Purok.")
            Return
        End If
        If String.IsNullOrEmpty(civilstatusbox.Text) Then
            MessageBox.Show("Please fill the Civil Status.")
            Return
        End If

        If String.IsNullOrEmpty(genderbox.Text) Then
            MessageBox.Show("Please fill the Gender.")
            Return
        End If
        If String.IsNullOrEmpty(birthdatepicker.Text) Then
            MessageBox.Show("Please fill the Birthdate.")
            Return
        End If

        If String.IsNullOrEmpty(contactnumberbox.Text) Then
            MessageBox.Show("Please fill the Contact No.")
            Return
        End If

        ' create a new row for the DataGridView
        Dim newRow As DataGridViewRow = New DataGridViewRow()

        ' create cells for the new row and set their values
        Dim Last_Name As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Last_Name.Value = lastnamebox.Text
        newRow.Cells.Add(Last_Name)

        Dim First_Name As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        First_Name.Value = firstnamebox.Text
        newRow.Cells.Add(First_Name)

        Dim Middle_Name As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Middle_Name.Value = middlenamebox.Text
        newRow.Cells.Add(Middle_Name)

        Dim Suffix As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Suffix.Value = suffixbox.Text
        newRow.Cells.Add(Suffix)

        Dim Household_ID As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Household_ID.Value = householdbox.Text
        newRow.Cells.Add(Household_ID)

        Dim Purok As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Purok.Value = purokbox.Text
        newRow.Cells.Add(Purok)

        Dim Civil_Status As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Civil_Status.Value = civilstatusbox.Text
        newRow.Cells.Add(Civil_Status)

        Dim Gender As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Gender.Value = genderbox.Text
        newRow.Cells.Add(Gender)

        Dim Birthdate As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Birthdate.Value = birthdatepicker.Value.ToString("dd/MM/yyyy")
        newRow.Cells.Add(Birthdate)

        Dim Contact_No As DataGridViewTextBoxCell = New DataGridViewTextBoxCell()
        Contact_No.Value = contactnumberbox.Text
        newRow.Cells.Add(Contact_No)

        ' add the new row to the DataGridView
        personinfoview.Rows.Add(newRow)

        ' clear the input fields
        lastnamebox.Clear()
        firstnamebox.Clear()
        middlenamebox.Clear()
        suffixbox.Clear()
        householdbox.Clear()
        purokbox.SelectedIndex = -1
        civilstatusbox.SelectedIndex = -1
        genderbox.SelectedIndex = -1
        birthdatepicker.ResetText()
        contactnumberbox.Clear()

        ' save the data to the database
        Try
            'call GetConnection() from dbconnection.vb
            Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
            'select tb
            Dim adapter As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM personalinfotb", conn)
            'where to insert
            Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO personalinfotb(Last_Name, First_Name, Middle_Name, Suffix, Household_ID, Purok, Civil_Status, Gender, Birthdate, Contact_No) VALUES(@Last_Name, @First_Name, @Middle_Name, @Suffix, @Household_ID, @Purok, @Civil_Status, @Gender, @Birthdate, @Contact_No)", conn)
            'input value
            cmd.Parameters.AddWithValue("@Last_Name", Last_Name.Value)
            cmd.Parameters.AddWithValue("@First_Name", First_Name.Value)
            cmd.Parameters.AddWithValue("@Middle_Name", Middle_Name.Value)
            cmd.Parameters.AddWithValue("@Suffix", Suffix.Value)
            cmd.Parameters.AddWithValue("@Household_ID", Household_ID.Value)
            cmd.Parameters.AddWithValue("@Purok", Purok.Value)
            cmd.Parameters.AddWithValue("@Civil_Status", Civil_Status.Value)
            cmd.Parameters.AddWithValue("@Gender", Gender.Value)
            cmd.Parameters.AddWithValue("@Birthdate", Birthdate.Value)
            cmd.Parameters.AddWithValue("@Contact_No", Contact_No.Value)

            'execute SQL statements that do not return a result set
            cmd.ExecuteNonQuery()

            ' show message box if data saved successfully
            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'error message
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class