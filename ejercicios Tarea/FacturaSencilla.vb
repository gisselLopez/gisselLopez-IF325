Public Class FacturaSencilla
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim PrecioUnitario, Cantidad, Total, Subtotal As Integer
        Dim Impuesto, Descuento As Double


        PrecioUnitario = Val(txtPrecioUnitario.Text)
        Cantidad = Val(txtCantidad.Text)

        If txtPrecioUnitario.Text = "" Then
            MsgBox("Escriba un numero en la casilla, no puede estar vacia", vbInformation)

        ElseIf Not IsNumeric(txtPrecioUnitario.Text) Then
            MsgBox("Escriba un valor numerico", vbInformation)
            txtPrecioUnitario.Text = ""

        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Escriba un valor numerico", vbInformation)
            txtCantidad.Text = ""

        ElseIf txtCantidad.Text = "" Then
            MsgBox("Escriba un numero en la casilla, no puede estar vacia", vbInformation)


        ElseIf txtPrecioUnitario.Text < 0 Then
            MsgBox("Numero negativo", vbInformation)

        ElseIf txtCantidad.Text < 0 Then
            MsgBox("Numero negativo", vbInformation)

        End If

        Subtotal = PrecioUnitario * Cantidad

        Select Case CmbDescuento.SelectedIndex

            Case 0
                Descuento = (Subtotal * 0.5)

            Case 1
                Descuento = (Subtotal * 0.3)

            Case 2
                Descuento = (Subtotal * 0.4)

            Case 3
                Descuento = (Subtotal * 0.6)

            Case 4
                Descuento = (Subtotal * 0.15)

            Case 5
                Descuento = (Subtotal * 0.05)
        End Select

        Select Case CmbImpuesto.SelectedIndex
            Case 1
                Impuesto = Subtotal * 0.15
            Case 2
                Impuesto = Subtotal * 0.17

        End Select


        Total = (Subtotal - Descuento) + Impuesto


        'salida
        txtSubtotal.Text = Subtotal
        txtDescuento.Text = Descuento
        txtImpuesto.Text = Impuesto
        txtTotal.Text = Total



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If txtPrecioUnitario.Text = False And txtCantidad.Text = False Then
            btnNuevo.Enabled = True

        End If
        txtPrecioUnitario.Clear()
        txtDescuento.Clear()
        txtImpuesto.Clear()
        txtCantidad.Clear()
        txtTotal.Clear()
        txtSubtotal.Clear()
        CmbDescuento.ResetText()
        CmbImpuesto.ResetText()

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txtPrecioUnitario.Text = "" And txtCantidad.Text = "" Then
            btnNuevo.Enabled = False

        ElseIf txtPrecioUnitario.Text = "" And Not (txtCantidad.Text = "") Then
            btnNuevo.Enabled = False

        ElseIf Not (txtPrecioUnitario.Text = "") And txtCantidad.Text = "" Then
            btnNuevo.Enabled = False

        Else
            btnNuevo.Enabled = True
        End If
    End Sub

    Private Sub ChbDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles ChbDescuento.CheckedChanged
        'Bloquear checkbox en caso de no ser elegido
        If ChbDescuento.Checked = True Then
            ChbImpuesto.Enabled = False

        ElseIf ChbImpuesto.Enabled = True Then
            ChbDescuento.Enabled = False


        End If
    End Sub

    Private Sub ChbImpuesto_CheckedChanged(sender As Object, e As EventArgs) Handles ChbImpuesto.CheckedChanged
        'Bloquear checkbox en caso de no ser elegido
        If ChbImpuesto.Enabled = True Then
            ChbDescuento.Enabled = False
        ElseIf ChbDescuento.Checked = False Then
            ChbImpuesto.Enabled = True
        End If

    End Sub
End Class