Public Class Factura
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim precio, cantidad As Integer
        Dim descuento, subtotal, total As Double
        Dim aplicaDescuento As Boolean

        precio = Val(txtprecio.Text)
        cantidad = Val(txtcantidad.Text)

        aplicaDescuento = ChbAplicarDescuento.Checked
        descuento = 0
        subtotal = precio * cantidad

        If aplicaDescuento = True Then
            descuento = subtotal * 0.05
        End If
        total = subtotal - descuento

        txtSubtotal.Text = subtotal
        txtDescuento.Text = descuento
        txtTotal.Text = total
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtprecio.Clear()
        txtcantidad.Clear()
        txtSubtotal.Clear()
        txtDescuento.Clear()
        TxtImpuesto.Clear()
        ChbAplicarImpuesto.Checked = False
        ChbAplicarDescuento.Checked = False
        CombDescuento.ResetText()
        CombImpuesto.ResetText()


    End Sub
End Class