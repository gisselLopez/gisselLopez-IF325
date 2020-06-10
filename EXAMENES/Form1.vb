Imports System.ComponentModel

Public Class Ingreso

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errores.SetError(sender, "")
        Else
            Me.Errores.SetError(sender, "Ingrese el nombre, este campo es obligatorio")
        End If
    End Sub


    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errores.SetError(sender, "")
        Else
            Me.Errores.SetError(sender, "Ingrese la edad, este campo es obligatorio")
        End If
    End Sub


    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        Toolmensaje.SetToolTip(txtNombre, "ingrese su nombre")
        Toolmensaje.ToolTipTitle = "Nombre"
        Toolmensaje.ToolTipIcon = ToolTipIcon.Info

    End Sub


    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        Toolmensaje.SetToolTip(txtNombre, "ingrese su edad")
        Toolmensaje.ToolTipTitle = "edad"
        Toolmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errores.SetError(sender, "")
        Else
            Me.Errores.SetError(sender, "Ingrese Su Municipio, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        Toolmensaje.SetToolTip(txtNombre, "ingrese su Municipio")
        Toolmensaje.ToolTipTitle = "Municipio"
        Toolmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim activo, muertos, recuperados As Integer
        Select Case CmbEstado.SelectedIndex
            Case 0
                activo = activo + 1
                txtactivo.Text = activo
            Case 1
                recuperados = recuperados + 1
                txtRecuperados.text = recuperados
            Case 2
                muertos = muertos + 1
                txtMuertos.text = muertos

        End Select


        If txtNombre.Text = "" Or txtEdad.Text = "" Or CmbDepartamento.SelectedItem = "" Or txtMunicipio.Text = "" Or CmbEstado.SelectedItem = "" Or CmbResultado.SelectedItem = "" Then
            MsgBox("Debe ingresar un dato o seleccionarlo")

        Else
            Dim n As Short = DataGrid.Rows.Count - 1
            'variable cualquiera
            'DataGrid.Rows.Count - 1 sirve para ir incrementando y si no se pone va ir cambiando 
            'y va ir aumentando por lo que concidero no es correcto

            'se podria decir que da salto de linea e ir aumentando filas
            DataGrid.Rows.Add()
            DataGrid(0, n).Value = txtNombre.Text
            DataGrid(1, n).Value = txtEdad.Text
            DataGrid(2, n).Value = CmbDepartamento.SelectedItem
            DataGrid(3, n).Value = txtMunicipio.Text
            DataGrid(4, n).Value = CmbEstado.SelectedItem
            DataGrid(5, n).Value = CmbResultado.SelectedItem

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtNombre.Clear()
        CmbDepartamento.SelectedIndex = False
        CmbEstado.SelectedIndex = False
        CmbResultado.SelectedIndex = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Desea salir ", vbQuestion + vbYesNo, "pregunta") Then
            End
        End If
    End Sub


End Class
