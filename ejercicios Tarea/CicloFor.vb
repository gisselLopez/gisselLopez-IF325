Public Class CicloFor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numero As Integer

        Numero = txtTabla.Text
        txtMostrar.Text = ""
        If Numero > 10 Then
            MsgBox("Ingrese una tabla que este entre 1-10")
        Else

            For i = 1 To 10

                'vbCrLf es para hacer salto en cada multiplicacion de cada numero
                txtMostrar.Text = txtMostrar.Text & Numero & " * " & i & " = " & Numero * i & vbCrLf

            Next
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTabla.Clear()
        txtMostrar.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class