﻿Public Class Pantalla_Principal
    Private Sub Pantalla_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelChildForm.Visible = True
        Panel2.Visible = False
        openChildForm(New Invitado())
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelChildForm.Visible = True
        Panel2.Visible = False
        openChildForm(New Estudiantes())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelChildForm.Visible = True
        Panel2.Visible = False
        openChildForm(New Empleados())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
        Else
            Panel2.BringToFront()
            Panel2.Visible = True
        End If

        If Panel9.Visible = True Then
            Panel9.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Panel9.Visible = True Then
            Panel9.Visible = False
        Else
            Panel9.BringToFront()
            Panel9.Visible = True
        End If

        If Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

    Private Sub PanelChildForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelChildForm.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    'Private Sub Pantalla_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Button1.FlatStyle = FlatStyle.Flat
    '    Button2.FlatStyle = FlatStyle.Flat

    ' End Sub
End Class