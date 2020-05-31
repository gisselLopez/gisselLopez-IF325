Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1, valor2, Suma As Integer


        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        Suma = valor1 + valor2
        txtSuma.Text = Suma
    End Sub
End Class
