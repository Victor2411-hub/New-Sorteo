Public Class Temp
    Private Sub Up1_Click(sender As Object, e As EventArgs) Handles Up1.Click
        L_min.Text += 1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles L_min.Click
        Up1.Visible = True
        Down1.Visible = True
        Up2.Visible = False
        Down2.Visible = False

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles L_seg.Click
        Up1.Visible = False
        Down1.Visible = False
        Up2.Visible = True
        Down2.Visible = True

    End Sub

    Private Sub Up2_Click(sender As Object, e As EventArgs) Handles Up2.Click
        L_seg.Text += 1
    End Sub

    Private Sub Down2_Click(sender As Object, e As EventArgs) Handles Down2.Click
        If L_seg.Text <> 0 Then
            L_seg.Text -= 1
        End If
    End Sub

    Private Sub Down1_Click(sender As Object, e As EventArgs) Handles Down1.Click
        If L_min.Text <> 0 Then
            L_min.Text -= 1
        End If

    End Sub

    Private Sub Control_Tick(sender As Object, e As EventArgs) Handles Control.Tick
        L_min.Left = Up1.Left - ((L_min.Width - Up1.Width) / 2)
        L_seg.Left = Up2.Left - ((L_seg.Width - Up2.Width) / 2)

    End Sub
    Dim minutos As Integer
    Dim segundos As Integer
    Dim pro As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Iniciar1.Click
        Up1.Visible = False
        Up2.Visible = False
        Down1.Visible = False
        Down2.Visible = False
        minutos = L_min.Text
        segundos = L_seg.Text
        If pro = True Then
            Progreso.Enabled = True
        End If
        Parar.BringToFront()
        Temporizador.Interval = 1000
        Temporizador.Start()

    End Sub

    Private Sub Parar_Click(sender As Object, e As EventArgs) Handles Parar.Click
        Iniciar1.BringToFront()
        Temporizador.Enabled = False
        Progreso.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Up1.Visible = True
        Down1.Visible = True
        Up2.Visible = False
        Down2.Visible = False
        Progreso.Stop()
        Temporizador.Stop()
        Iniciar1.BringToFront()
        L_min.Text = "00"
        L_seg.Text = "30"

    End Sub

    Private Sub Temporizador_Tick(sender As Object, e As EventArgs) Handles Temporizador.Tick
        If segundos = 0 And minutos > 0 Then
            segundos = 60
            minutos -= 1
            L_min.Text -= 1
            L_seg.Text = 60
        End If
        segundos -= 1
        L_seg.Text -= 1
        If L_seg.Text = "0" Or L_seg.Text = "00" Then
            If L_min.Text = "0" Or L_min.Text = "00" Then
                Temporizador.Enabled = False
                Parar.Enabled = False

            End If
        End If
    End Sub

    Private Sub Temp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
