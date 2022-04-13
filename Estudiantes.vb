Public Class Estudiantes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sql = "SELECT * FROM `estudiantes` WHERE Nombre = '" & TextBox1.Text & "' AND Curso = '" & TextBox2.Text & "' AND Número = '" & TextBox3.Text & "'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try

        If dr.Read Then
            MsgBox("Este Estudiante ya Existe!")
            Return
        End If

        sql = "INSERT INTO `estudiantes`(`Nombre`, `Curso`, `Número`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"

        Try
            openCon()
            MsgBox("Operación Exitosa!")
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try
    End Sub

    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class