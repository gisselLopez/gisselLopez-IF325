Public Class CicloFor
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valor As Integer

        valor = InputBox("ingrese numero", "ingreso")
        txtValor.Text = valor
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma, resta, Multiplicacion, valor As Integer
        Dim Division As Double

        valor = Val(txtValor.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            Multiplicacion = valor * i
            Division = (valor / i)
            'Items.Add agregar de forma automatica nuestros items
            '&(concatenar)
            cmbMostrarSuma.Items.Add(valor & "+" & i & "=" & suma)
            CmbMostrarResta.Items.Add(valor & "-" & i & "=" & resta)
            CmbMostrarMultiplicacion.Items.Add(valor & "x" & i & "=" & Multiplicacion)
            CmbMostarDivision.Items.Add(valor & "/" & i & "=" & Division)


        Next
    End Sub
End Class