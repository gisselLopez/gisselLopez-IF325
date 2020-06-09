Public Class Numeros


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click


        Try
            Dim suma As Integer
            Dim numero, impar, par, negativo, positivo, i As Integer
            par = 0
            impar = 0
            positivo = 0
            negativo = 0
            numero = Val(txtNumero.Text)

            If txtNumero.Text = "" Then
                MsgBox("ingrese los numeros que desee")
                txtNumero.Focus()

            Else
                For i = 1 To txtNumero.Text
                    numero = InputBox("Numero", "Ingresado")
                    txtNumero.Text = numero
                    CmbLista.DropDownStyle = ComboBoxStyle.DropDownList
                    CmbLista.Items.Add(numero)
                    ' el x mod y sirve para sacar resoduo donde x se divide sobre y
                    If numero Mod 2 = 0 Then
                        par += 1
                    Else
                        impar += 1
                    End If
                    If numero > 0 Then
                        positivo += 1
                    ElseIf numero < 0 Then
                        negativo += 1
                    End If
                Next
                suma = suma + numero
                numero = numero + 1
            End If
            'Total de numeros ingresados


            txtTotalSuma.Text = suma
            txtimpar.Text = impar
            txtpar.Text = par
            txtnegativo.Text = negativo
            txtpositivo.Text = positivo
            txtTotal.Text = numero
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtTotal.Clear()
        txtTotalSuma.Clear()
        txtpositivo.Clear()
        txtnegativo.Clear()
        txtpar.Clear()
        txtimpar.Clear()
        txtNumero.Clear()
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        MenuGuia.Show()
    End Sub
End Class