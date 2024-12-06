<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        CheckedListBox1 = New CheckedListBox()
        DataGridView1 = New DataGridView()
        empID = New DataGridViewTextBoxColumn()
        firstname = New DataGridViewTextBoxColumn()
        Lastname = New DataGridViewTextBoxColumn()
        contact = New DataGridViewTextBoxColumn()
        DateofBirth = New DataGridViewTextBoxColumn()
        gender = New DataGridViewTextBoxColumn()
        btnSave = New Button()
        btnUpdate = New Button()
        btndelete = New Button()
        btnclear = New Button()
        txtempID = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(25, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(25, 98)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(25, 131)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 2
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(24, 163)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 3
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Male", "Female"})
        CheckedListBox1.Location = New Point(25, 196)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(150, 48)
        CheckedListBox1.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {empID, firstname, Lastname, contact, DateofBirth, gender})
        DataGridView1.Location = New Point(297, 61)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(612, 349)
        DataGridView1.TabIndex = 5
        ' 
        ' empID
        ' 
        empID.HeaderText = "empID"
        empID.MinimumWidth = 6
        empID.Name = "empID"
        empID.Width = 125
        ' 
        ' firstname
        ' 
        firstname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        firstname.HeaderText = "Firstname"
        firstname.MinimumWidth = 6
        firstname.Name = "firstname"
        firstname.Width = 102
        ' 
        ' Lastname
        ' 
        Lastname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Lastname.HeaderText = "Lastname"
        Lastname.MinimumWidth = 6
        Lastname.Name = "Lastname"
        Lastname.Width = 101
        ' 
        ' contact
        ' 
        contact.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        contact.HeaderText = "Contact Number"
        contact.MinimumWidth = 6
        contact.Name = "contact"
        contact.Width = 147
        ' 
        ' DateofBirth
        ' 
        DateofBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DateofBirth.HeaderText = "Date of Birth"
        DateofBirth.MinimumWidth = 6
        DateofBirth.Name = "DateofBirth"
        DateofBirth.Width = 123
        ' 
        ' gender
        ' 
        gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        gender.HeaderText = "Gender"
        gender.MinimumWidth = 6
        gender.Name = "gender"
        gender.Width = 86
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(25, 267)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 6
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(144, 267)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(25, 302)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 29)
        btndelete.TabIndex = 8
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.Location = New Point(144, 302)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(94, 29)
        btnclear.TabIndex = 9
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' txtempID
        ' 
        txtempID.Location = New Point(166, 65)
        txtempID.Name = "txtempID"
        txtempID.Size = New Size(125, 27)
        txtempID.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 450)
        Controls.Add(txtempID)
        Controls.Add(btnclear)
        Controls.Add(btndelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(DataGridView1)
        Controls.Add(CheckedListBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents empID As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents DateofBirth As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents txtempID As TextBox

End Class
