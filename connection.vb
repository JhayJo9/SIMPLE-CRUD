Imports MySql.Data
Imports MySql.Data.MySqlClient
Module connection

    Public conn As New MySqlConnection
    Dim strconn As String
    Dim rs As Boolean

    Public Function openconnection() As Boolean

        Try
            If conn.State = ConnectionState.Closed Then
                conn = New MySqlConnection
            End If

            If conn.State = ConnectionState.Closed Then
                strconn = "server=127.0.0.1;user=Yohan;password=Yohan;port=3307;database=exam;sslmode=none;Convert Zero DateTime=True"
                conn.ConnectionString = strconn
                conn.Open()

                rs = True
            End If
        Catch ex As Exception
            MsgBox("Module: " & ex.Message)
            rs = False
        End Try
        Return rs
    End Function


    Public Sub closeconnection()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
