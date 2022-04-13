Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public dr As MySqlDataReader
    Public table As New DataTable
    Public sql As String

    Sub openCon()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.ConnectionString = "server=localhost;username=root;password=;database=sorteos"
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        con.Open()
        dr = cmd.ExecuteReader
    End Sub

    Sub Comprobarcon()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.ConnectionString = "server=localhost;username=root;password=;database=sorteos"
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        con.Open()
    End Sub
End Module