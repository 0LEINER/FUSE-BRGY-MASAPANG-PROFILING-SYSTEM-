<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPerson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPerson))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.personinfoview = New System.Windows.Forms.DataGridView()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Middle_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Suffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Household_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Civil_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.contactnumberbox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.birthdatepicker = New System.Windows.Forms.DateTimePicker()
        Me.genderbox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.civilstatusbox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.purokbox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.householdbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.suffixbox = New System.Windows.Forms.TextBox()
        Me.middlenamebox = New System.Windows.Forms.TextBox()
        Me.firstnamebox = New System.Windows.Forms.TextBox()
        Me.lastnamebox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.personinfoview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 535)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(860, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(126, 87)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.clearbtn)
        Me.Panel5.Controls.Add(Me.savebtn)
        Me.Panel5.Location = New System.Drawing.Point(756, 288)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(187, 223)
        Me.Panel5.TabIndex = 3
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.Tan
        Me.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearbtn.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.Location = New System.Drawing.Point(29, 126)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(127, 43)
        Me.clearbtn.TabIndex = 1
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.Location = New System.Drawing.Point(29, 47)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(127, 43)
        Me.savebtn.TabIndex = 0
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.personinfoview)
        Me.Panel4.Location = New System.Drawing.Point(46, 288)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(692, 224)
        Me.Panel4.TabIndex = 2
        '
        'personinfoview
        '
        Me.personinfoview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.personinfoview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Last_Name, Me.First_Name, Me.Middle_Name, Me.Suffix, Me.Household_ID, Me.Purok, Me.Civil_Status, Me.Gender, Me.Birthdate, Me.Contact_No})
        Me.personinfoview.Location = New System.Drawing.Point(12, 10)
        Me.personinfoview.Name = "personinfoview"
        Me.personinfoview.Size = New System.Drawing.Size(662, 203)
        Me.personinfoview.TabIndex = 31
        '
        'Last_Name
        '
        Me.Last_Name.HeaderText = "Last_Name"
        Me.Last_Name.Name = "Last_Name"
        '
        'First_Name
        '
        Me.First_Name.HeaderText = "First_Name"
        Me.First_Name.Name = "First_Name"
        '
        'Middle_Name
        '
        Me.Middle_Name.HeaderText = "Middle_Name"
        Me.Middle_Name.Name = "Middle_Name"
        '
        'Suffix
        '
        Me.Suffix.HeaderText = "Suffix"
        Me.Suffix.Name = "Suffix"
        '
        'Household_ID
        '
        Me.Household_ID.HeaderText = "Household_ID"
        Me.Household_ID.Name = "Household_ID"
        '
        'Purok
        '
        Me.Purok.HeaderText = "Purok"
        Me.Purok.Name = "Purok"
        '
        'Civil_Status
        '
        Me.Civil_Status.HeaderText = "Civil_Status"
        Me.Civil_Status.Name = "Civil_Status"
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        '
        'Birthdate
        '
        Me.Birthdate.HeaderText = "Birthdate"
        Me.Birthdate.Name = "Birthdate"
        '
        'Contact_No
        '
        Me.Contact_No.HeaderText = "Contact_No"
        Me.Contact_No.Name = "Contact_No"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.contactnumberbox)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.birthdatepicker)
        Me.Panel3.Controls.Add(Me.genderbox)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.civilstatusbox)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.purokbox)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.householdbox)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.suffixbox)
        Me.Panel3.Controls.Add(Me.middlenamebox)
        Me.Panel3.Controls.Add(Me.firstnamebox)
        Me.Panel3.Controls.Add(Me.lastnamebox)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(46, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(898, 179)
        Me.Panel3.TabIndex = 1
        '
        'contactnumberbox
        '
        Me.contactnumberbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactnumberbox.Location = New System.Drawing.Point(727, 125)
        Me.contactnumberbox.Name = "contactnumberbox"
        Me.contactnumberbox.Size = New System.Drawing.Size(124, 24)
        Me.contactnumberbox.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(722, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 26)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Contact No:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(547, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 26)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Birthdate:"
        '
        'birthdatepicker
        '
        Me.birthdatepicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.birthdatepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.birthdatepicker.Location = New System.Drawing.Point(552, 123)
        Me.birthdatepicker.Name = "birthdatepicker"
        Me.birthdatepicker.Size = New System.Drawing.Size(138, 26)
        Me.birthdatepicker.TabIndex = 26
        '
        'genderbox
        '
        Me.genderbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.genderbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.genderbox.FormattingEnabled = True
        Me.genderbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.genderbox.Location = New System.Drawing.Point(430, 123)
        Me.genderbox.Name = "genderbox"
        Me.genderbox.Size = New System.Drawing.Size(91, 26)
        Me.genderbox.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(425, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 26)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Gender:"
        '
        'civilstatusbox
        '
        Me.civilstatusbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.civilstatusbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.civilstatusbox.FormattingEnabled = True
        Me.civilstatusbox.Items.AddRange(New Object() {"single", "married", "separated", "divorced", "widowed"})
        Me.civilstatusbox.Location = New System.Drawing.Point(284, 123)
        Me.civilstatusbox.Name = "civilstatusbox"
        Me.civilstatusbox.Size = New System.Drawing.Size(107, 26)
        Me.civilstatusbox.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(279, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 26)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Civil Status:"
        '
        'purokbox
        '
        Me.purokbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purokbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.purokbox.FormattingEnabled = True
        Me.purokbox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.purokbox.Location = New System.Drawing.Point(174, 123)
        Me.purokbox.Name = "purokbox"
        Me.purokbox.Size = New System.Drawing.Size(71, 26)
        Me.purokbox.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(169, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 26)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Purok:"
        '
        'householdbox
        '
        Me.householdbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.householdbox.Location = New System.Drawing.Point(45, 125)
        Me.householdbox.Name = "householdbox"
        Me.householdbox.Size = New System.Drawing.Size(92, 24)
        Me.householdbox.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Household id:"
        '
        'suffixbox
        '
        Me.suffixbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suffixbox.Location = New System.Drawing.Point(758, 45)
        Me.suffixbox.Name = "suffixbox"
        Me.suffixbox.Size = New System.Drawing.Size(93, 24)
        Me.suffixbox.TabIndex = 16
        '
        'middlenamebox
        '
        Me.middlenamebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlenamebox.Location = New System.Drawing.Point(519, 45)
        Me.middlenamebox.Name = "middlenamebox"
        Me.middlenamebox.Size = New System.Drawing.Size(200, 24)
        Me.middlenamebox.TabIndex = 15
        '
        'firstnamebox
        '
        Me.firstnamebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnamebox.Location = New System.Drawing.Point(284, 45)
        Me.firstnamebox.Name = "firstnamebox"
        Me.firstnamebox.Size = New System.Drawing.Size(200, 24)
        Me.firstnamebox.TabIndex = 14
        '
        'lastnamebox
        '
        Me.lastnamebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnamebox.Location = New System.Drawing.Point(45, 45)
        Me.lastnamebox.Name = "lastnamebox"
        Me.lastnamebox.Size = New System.Drawing.Size(200, 24)
        Me.lastnamebox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(753, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Suffix:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(514, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Middle Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(279, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Uighur", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Personal Information:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 69)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(946, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 37)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(11, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(251, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(517, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BARANGAY RESIDENTS ADMISSION"
        '
        'AddPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1000, 604)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddPerson"
        Me.Text = "AddPerson"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.personinfoview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents suffixbox As TextBox
    Friend WithEvents middlenamebox As TextBox
    Friend WithEvents firstnamebox As TextBox
    Friend WithEvents lastnamebox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents birthdatepicker As DateTimePicker
    Friend WithEvents genderbox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents civilstatusbox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents purokbox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents householdbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents contactnumberbox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents clearbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents personinfoview As DataGridView
    Friend WithEvents Last_Name As DataGridViewTextBoxColumn
    Friend WithEvents First_Name As DataGridViewTextBoxColumn
    Friend WithEvents Middle_Name As DataGridViewTextBoxColumn
    Friend WithEvents Suffix As DataGridViewTextBoxColumn
    Friend WithEvents Household_ID As DataGridViewTextBoxColumn
    Friend WithEvents Purok As DataGridViewTextBoxColumn
    Friend WithEvents Civil_Status As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Birthdate As DataGridViewTextBoxColumn
    Friend WithEvents Contact_No As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
End Class
