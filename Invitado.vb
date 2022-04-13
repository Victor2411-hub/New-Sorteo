Public Class Invitado
    Private Sub Invitado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sql = "SELECT * FROM `invitados` WHERE Nombre = '" & TextBox1.Text & "' AND Teléfono = '" & TextBox2.Text & "'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

        If dr.Read Then
            MsgBox("Este Invitado ya Existe!")
            Return
        End If

        sql = "INSERT INTO `invitados`(`Nombre`, `Teléfono`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "') "

        Try
            openCon()
            MsgBox("Operación Exitosa!")
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

    End Sub
End Class