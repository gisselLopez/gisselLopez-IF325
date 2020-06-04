Public Class Formula_General
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim A, B, C As Double


        A = Val(txtValor1.Text)
        B = Val(txtValor2.Text)
        C = Val(txtValor3.Text)


        If txtValor1.Text = "" Then
            MsgBox("Digite un valor para la variable a", vbInformation)
            txtValor1.Text = 1

        End If
        If txtValor2.Text = "" Then
            MsgBox("Digite un valor para la variable a", vbInformation)
            txtValor2.Text = 1

        End If
        If txtValor3.Text = "" Then
            MsgBox("Digite un valor para la variable a", vbInformation)
            txtValor3.Text = 0

        End If
        If txtValor1.Text = 0 Then
            MsgBox("Digite un valor para la variable a", vbInformation)
            txtValor1.Text = 1

        End If
        If txtValor2.Text < (4 * (txtValor1.Text * txtValor3.Text)) Then

            txtValor1.Text = 1
            txtValor2.Text = 1
            txtValor3.Text = 0

        End If

        txtX1.Text = ((-B + Math.Sqrt((B * B) - (4 * A * C))) / (2 * A))
        txtX2.Text = ((-B - Math.Sqrt((B * B) - (4 * A * C))) / (2 * A))


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtValor3.Clear()
        txtX1.Clear()
        txtX2.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class