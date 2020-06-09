Imports System.ComponentModel

Public Class SAR_Honduras
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim excento, imp1, imp2, sueldo As Double
        excento = 16582.92
        imp1 = 23536.61
        imp2 = 50317.69

        If txtSueldo.Text <= excento Then
            sueldo = txtSueldo.Text

            MsgBox(" Usted esta excento del impuesto")
        ElseIf txtSueldo.Text >= 16528.93 Or txtSueldo.Text <= imp1 Then

            MsgBox(" Usted no esta excento al impuesto de 15%")
            sueldo = txtSueldo.Text * 0.15
        ElseIf txtSueldo.Text > imp1 Or txtSueldo.Text <= imp2 Then

            MsgBox(" Usted no esta excento al impuesto de 20%")
            sueldo = txtSueldo.Text * 0.2
        Else

            MsgBox(" Usted no esta excento al impuesto de 25%")
            sueldo = txtSueldo.Text * 0.25
        End If
        txtSueldoNeto.Text = sueldo + txtSueldo.Text
    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub txtSueldo_Validating(sender As Object, e As CancelEventArgs) Handles txtSueldo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un valor, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtSueldoNeto_TextChanged(sender As Object, e As EventArgs) Handles txtSueldoNeto.TextChanged

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtSueldo.Clear()
        txtSueldoNeto.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        MenuGuia.Show()
    End Sub
End Class