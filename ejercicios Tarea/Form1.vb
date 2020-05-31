Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1, valor2, Suma, Resta, Multiplicacion As Integer
        Dim division As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        Suma = valor1 + valor2
        Resta = valor1 - valor2
        Multiplicacion = valor1 * valor2
        division = valor1 / valor2

        txtsuma.Text = Suma
        txtResta.Text = Resta
        txtMultiplicacion.Text = Multiplicacion

        If valor2 = 0 Then
            MsgBox("No se puede dividir por cero")
        ElseIf valor2 <> 0 Then
            txtDivision.Text = division
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtsuma.Clear()
        txtResta.Clear()
        txtMultiplicacion.Clear()
        txtDivision.Clear()
        txtValor1.Clear()
        txtValor2.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
