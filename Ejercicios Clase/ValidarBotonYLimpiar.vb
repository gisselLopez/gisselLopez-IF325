Public Class ValidarBotonYLimpiar
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim valor As Integer

        If txtNumero.Text = " " Then
            MsgBox("Debe ingresar un valor", vbInformation)
        ElseIf Not IsNumeric(txtNumero.Text) Then
            MsgBox("Debe ingresar un valor Numerico", vbInformation)
            txtNumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtNumero.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Numero positivo")
            ElseIf valor < 0 Then
                MsgBox("Numero Negativo")
            End If
            End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNumero.Clear()
        txtNumero.Focus()
    End Sub
End Class