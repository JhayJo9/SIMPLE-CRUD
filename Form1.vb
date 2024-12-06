Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Form1

    Public Sub fetchdata()
        Try
            If openconnection() Then
                Dim query As String = "SELECT * from tb_employee"
                Using cmd As New MySqlCommand(query, conn)
                    Using dtreader As MySqlDataReader = cmd.ExecuteReader

                        While dtreader.Read
                            Dim empId As Integer = dtreader.GetInt32("empID")
                            Dim empName As String = dtreader.GetString("empname")
                            Dim empLastname As String = dtreader.GetString("emplastname")
                            Dim contactNo As String = dtreader.GetString("contactNo")
                            Dim dateofbirth As Date = dtreader.GetDateTime("dateofbirth").Date
                            Dim gender As String = dtreader.GetString("gender")
                            DataGridView1.Rows.Add(empId, empName, empLastname, contactNo, dateofbirth.ToString("yyyy-MM-dd"), gender)

                        End While


                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub deleteedata()
        Try
            If openconnection() Then
                Dim delete As String = "DELETE FROM tb_employee WHERE empID=@empID"
                Using cmd As New MySqlCommand(delete, conn)
                    cmd.Parameters.AddWithValue("@empID", txtempID.Text)
                    cmd.ExecuteNonQuery()

                    DataGridView1.Rows.Clear()
                    fetchdata()
                    MsgBox("Success")
                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub insertdata()
        Try

            DataGridView1.Rows.Clear()

            If openconnection() Then
                Dim insert As String = "INSERT INTO tb_employee values (null, @firstname, @lastname, @contactno, @dateofbirth, @gender)"
                Using cmd As New MySqlCommand(insert, conn)
                    cmd.Parameters.AddWithValue("@firstname", TextBox1.Text)
                    cmd.Parameters.AddWithValue("lastname", TextBox2.Text)
                    cmd.Parameters.AddWithValue("contactno", TextBox3.Text)
                    cmd.Parameters.AddWithValue("dateofbirth", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("gender", CheckedListBox1.SelectedItem)

                    cmd.ExecuteNonQuery()

                    MsgBox("Success")
                End Using


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub updatedata()
        Try
            If openconnection() Then
                Dim update As String = "UPDATE tb_employee SET empname=@empname, emplastname=@emplastname, contactNo=@contactNo, dateofbirth=@dateofbirth, gender=@gender WHERE empID=@empID"
                Using cmd As New MySqlCommand(update, conn)
                    cmd.Parameters.AddWithValue("@empID", txtempID.Text)
                    cmd.Parameters.AddWithValue("@empname", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@emplastname", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@contactNo", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@dateofbirth", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@gender", CheckedListBox1.SelectedItem)

                    cmd.ExecuteNonQuery()
                    MsgBox("Success")
                End Using
                DataGridView1.Rows.Clear()
                fetchdata()
            End If
        Catch ex As Exception
            MsgBox("UPDATE: " & ex.Message)
        End Try
    End Sub

    Public Sub clear()
        txtempID.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DateTimePicker1.Value = DateTime.Now
        CheckedListBox1.SelectedItem = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openconnection()
        fetchdata()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeconnection()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        insertdata()
        fetchdata()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtempID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        'DateTimePicker1.Value = DateTime.Parse(DataGridView1.CurrentRow.Cells(4).Value.ToString())
        CheckedListBox1.SelectedItem = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updatedata()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        deleteedata()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub
End Class
