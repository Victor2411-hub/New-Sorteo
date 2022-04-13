Public Class Estudiantes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Llene el campo")
            Return
        End If

        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Llene el campo")
            Return
        End If

        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Llene el campo")
            Return
        End If

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pantalla_Principal.currentForm.Close()
    End Sub
End Class