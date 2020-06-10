Imports System.ComponentModel

Public Class Loguin
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim usuario, contrasena As String
        usuario = txtUsuario.Text
        contrasena = txtContrasena.Text

        If (usuario = "Administrador") And (contrasena = "SinHacer2020") Then
            MsgBox("usuario y contrasena correctos")
            Me.Hide()
            Ingreso.Show()
        Else
            MsgBox("usuario y contrasena incorrectos intenta de nuevo")
        End If

    End Sub


    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese El usuario, este campo es obligatorio")
        End If
    End Sub


    Private Sub txtContrasena_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese La contrasena, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtContrasena_MouseHover(sender As Object, e As EventArgs) Handles txtContrasena.MouseHover
        Toolmensaje.SetToolTip(txtContrasena, "ingrese la contrasena")
        Toolmensaje.ToolTipTitle = "contrasena"
        Toolmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolMensaje.SetToolTip(txtUsuario, "ingrese El usuario")
        ToolMensaje.ToolTipTitle = "Usuario"
        ToolMensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class