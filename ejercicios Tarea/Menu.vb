Public Class MenuGuia


    Private Sub btnCalculadoraBasica_Click(sender As Object, e As EventArgs) Handles btnCalculadoraBasica.Click
        Me.Hide()
        Calculadora_basica.Show()
    End Sub

    Private Sub btnFormula_Click(sender As Object, e As EventArgs) Handles btnFormula.Click
        Me.Hide()
        Formula_General.Show()
    End Sub

    Private Sub btnNumeros_Click(sender As Object, e As EventArgs) Handles btnNumeros.Click
        Me.Hide()
        Numeros.Show()
    End Sub

    Private Sub btnalmacenes_Click(sender As Object, e As EventArgs) Handles btnalmacenes.Click
        Me.Hide()
        Empresa.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        SAR_Honduras.Show()
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        End
    End Sub
End Class