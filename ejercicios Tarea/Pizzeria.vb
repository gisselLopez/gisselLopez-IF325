Imports System.ComponentModel

Public Class Pizzeria


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Dim cantidad As Integer
            Dim subtotal, impuesto As Double
            Dim total As Double
            Dim acumulador As Double = 0

            If RdbChica.Checked = True Then
                subtotal = +50
            End If
            If RdbMediana.Checked = True Then
                subtotal = +100
            End If
            If RdbGrande.Checked = True Then
                subtotal = +150
            End If
            If RdbFamiliar.Checked = True Then
                subtotal = +200
            End If


            'Ingredientes 
            If ChbChampinones.Checked = True Then
                subtotal = subtotal + 10
            End If
            If ChbPeperoni.Checked = True Then
                subtotal = subtotal + 15
            End If
            If ChbQueso.Checked = True Then
                subtotal = subtotal + 10
            End If
            If ChbCarne.Checked = True Then
                subtotal = subtotal + 20
            End If


            Select Case CmbBebidas.SelectedIndex


                Case 0
                    subtotal = subtotal + 10

                Case 1
                    subtotal = subtotal + 8

                Case 2
                    subtotal = subtotal + 5

                Case 3
                    subtotal = subtotal + 5

            End Select
            cantidad = Convert.ToDouble(NumeroCantidad.Text)
            subtotal = Convert.ToDouble(NumeroCantidad.Text) * subtotal
            acumulador = acumulador + subtotal
            impuesto = subtotal * 0.15
            total = acumulador + impuesto


            txtTotal.Text = total.ToString
            txtImpuesto.Text = impuesto
            txtSubtotal.Text = subtotal

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTotal.Clear()
        txtSubtotal.Clear()
        txtImpuesto.Clear()
        CmbBebidas.Items.Clear()
        NumeroCantidad.Value = 1
        RdbChica.Checked = False
        RdbFamiliar.Checked = False
        RdbGrande.Checked = False
        RdbGrande.Checked = False
        ChbCarne.Checked = False
        ChbChampinones.Checked = False
        ChbPeperoni.Checked = False
        ChbQueso.Checked = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

End Class