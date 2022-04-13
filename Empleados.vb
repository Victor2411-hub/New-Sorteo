Public Class Empleados

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT * FROM `empleados` WHERE Nombre = '" & TextBox1.Text & "' AND Contraceña = '" & TextBox2.Text & "' AND Correo = '" & TextBox3.Text & "'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

        If dr.Read Then
            MsgBox("Este Empleado ya Existe!")
            Return
        End If

        sql = "INSERT INTO `empleados`(`Nombre`, `Contraceña`, `Correo`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"

        Try
            openCon()
            MsgBox("Operación Exitosa!")
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class