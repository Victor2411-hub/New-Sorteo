Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Comprobar()

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        sql = "Select * From Empleados Where Nombre= '" & TxtUser.Text & "' And Clave= '" & TxtPass.Text & "'"

        Try
            openCon()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos")
            Return
        End Try


        If dr.Read Then
            Pantalla_Principal.Show()
            Me.Hide()
            con.Close()
        Else
            ErrorProvider1.SetError(Button1, "Usuario o Contraceña incorrectos")


        End If
    End Sub

    Private Function Comprobar() As Boolean
        If TxtUser.Text = "" Then
            ErrorProvider1.SetError(TxtUser, "Digite el Usuario")
        Else
            ErrorProvider1.SetError(TxtUser, Nothing)
        End If

        If TxtPass.Text = "" Then
            ErrorProvider1.SetError(TxtPass, "Digite la Contraceña")
        Else
            ErrorProvider1.SetError(TxtPass, Nothing)
        End If

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub
End Class
