Public Class OperacionesBasicas
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1, valor2, resp As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        If txtValor1.Text = "" Or Not IsNumeric(txtValor1.Text) Then
            MsgBox("ingrese un valor numerico", vbInformation)
        End If
        If txtValor2.Text = "" Or Not IsNumeric(txtValor2.Text) Then
            MsgBox("ingrese un valor numerico", vbInformation)
        End If
        If ChbSuma.Checked = False And ChbResta.Checked = False And ChbMultiplicacion.Checked = False And ChbDivision.Checked = False And ChbRaizCuadrada.Checked = False And ChbPotencia.Checked = False Then
            MsgBox("escoja una opcion", vbInformation)
        End If

        If ChbSuma.Checked = True Then
            resp = valor1 + valor2


        End If
        If ChbResta.Checked = True Then
            resp = valor1 - valor2

        End If
        If ChbMultiplicacion.Checked = True Then
            resp = valor1 * valor2

        End If
        If ChbDivision.Checked = True Then
            resp = valor1 / valor2

        End If

        If ChbRaizCuadrada.Checked = True Then
            resp = valor1 ^ 0.5

        End If
        If ChbPotencia.Checked = True Then
            resp = valor1 ^ valor2

        End If
        txtResultado.Text = resp
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtValor1.Clear()
        txtValor2.Clear()
        txtResultado.Clear()
        ChbMultiplicacion.Checked = False
        ChbPotencia.Checked = False
        ChbDivision.Checked = False
        ChbRaizCuadrada.Checked = False
        ChbSuma.Checked = False



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub ChbSuma_CheckedChanged(sender As Object, e As EventArgs) Handles ChbSuma.CheckedChanged
        If ChbSuma.Checked = True Then
            ChbMultiplicacion.Enabled = False
            ChbResta.Enabled = False
            ChbDivision.Enabled = False
            ChbRaizCuadrada.Enabled = False
            ChbPotencia.Enabled = False
        ElseIf ChbSuma.Checked = False Then

            ChbMultiplicacion.Enabled = True
            ChbResta.Enabled = True
            ChbDivision.Enabled = True
            ChbRaizCuadrada.Enabled = True
            ChbPotencia.Enabled = True
        End If
    End Sub

    Private Sub ChbMultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles ChbMultiplicacion.CheckedChanged
        If ChbMultiplicacion.Checked = True Then
            ChbSuma.Enabled = False
            ChbResta.Enabled = False
            ChbDivision.Enabled = False
            ChbRaizCuadrada.Enabled = False
            ChbPotencia.Enabled = False
        ElseIf ChbMultiplicacion.Checked = False Then

            ChbSuma.Enabled = True
            ChbResta.Enabled = True
            ChbDivision.Enabled = True
            ChbRaizCuadrada.Enabled = True
            ChbPotencia.Enabled = True

        End If
    End Sub

    Private Sub ChbResta_CheckedChanged(sender As Object, e As EventArgs) Handles ChbResta.CheckedChanged
        If ChbResta.Checked = True Then
            ChbMultiplicacion.Enabled = False
            ChbSuma.Enabled = False
            ChbDivision.Enabled = False
            ChbRaizCuadrada.Enabled = False
            ChbPotencia.Enabled = False
        ElseIf ChbResta.Checked = False Then

            ChbMultiplicacion.Enabled = True
            ChbSuma.Enabled = True
            ChbDivision.Enabled = True
            ChbRaizCuadrada.Enabled = True
            ChbPotencia.Enabled = True

        End If
    End Sub

    Private Sub ChbRaizCuadrada_CheckedChanged(sender As Object, e As EventArgs) Handles ChbRaizCuadrada.CheckedChanged
        If ChbRaizCuadrada.Checked = True Then
            ChbMultiplicacion.Enabled = False
            ChbResta.Enabled = False
            ChbDivision.Enabled = False
            ChbSuma.Enabled = False
            ChbPotencia.Enabled = False
        ElseIf ChbRaizCuadrada.Checked = False Then

            ChbMultiplicacion.Enabled = True
            ChbResta.Enabled = True
            ChbDivision.Enabled = True
            ChbSuma.Enabled = True
            ChbPotencia.Enabled = True

        End If
    End Sub

    Private Sub ChbPotencia_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPotencia.CheckedChanged
        If ChbPotencia.Checked = True Then
            ChbMultiplicacion.Enabled = False
            ChbResta.Enabled = False
            ChbDivision.Enabled = False
            ChbRaizCuadrada.Enabled = False
            ChbSuma.Enabled = False
        ElseIf ChbPotencia.Checked = False Then

            ChbMultiplicacion.Enabled = True
            ChbResta.Enabled = True
            ChbDivision.Enabled = True
            ChbRaizCuadrada.Enabled = True
            ChbSuma.Enabled = True

        End If
    End Sub

    Private Sub ChbDivision_CheckedChanged(sender As Object, e As EventArgs) Handles ChbDivision.CheckedChanged
        If ChbDivision.Checked = True Then
            ChbMultiplicacion.Enabled = False
            ChbResta.Enabled = False
            ChbSuma.Enabled = False
            ChbRaizCuadrada.Enabled = False
            ChbPotencia.Enabled = False
        ElseIf ChbDivision.Checked = False Then

            ChbMultiplicacion.Enabled = True
            ChbResta.Enabled = True
            ChbSuma.Enabled = True
            ChbRaizCuadrada.Enabled = True
            ChbPotencia.Enabled = True

        End If
    End Sub
End Class