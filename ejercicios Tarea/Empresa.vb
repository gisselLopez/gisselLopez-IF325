Imports System.ComponentModel

Public Class Empresa
    Private grbvalores As Object

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim valor, i As Integer
        Dim ventamedio As Integer
        Dim cantidad, Ventas, promedio As Double
        ventamedio = 10000
        If txtCantidad.Text = "" Then
            MsgBox("Debe ingresar la cantidad de ventas mensuales que desea ingresar")
            txtCantidad.Focus()
        Else
            For i = 1 To txtCantidad.Text
                cantidad = txtCantidad.Text
                valor = InputBox("Ingrese la venta mensual", "Ingresada")
                txtVentas.Text = valor
                Ventas = Ventas + valor
                promedio = Ventas / cantidad

            Next
            txtVentas.Text = Ventas
            txtpromedio.Text = promedio
        End If
        If cmbAlmacenes.Text = "Almacen Titan" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen Titan"

        ElseIf cmbAlmacenes.Text = "Almacen samy" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen samy"

        ElseIf cmbAlmacenes.Text = "Almacen olivos" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen olivos"

        ElseIf cmbAlmacenes.Text = "Almacen El compadre" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "almacen El compadre"

        ElseIf cmbAlmacenes.Text = "Almacen el baratillo" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen San Pedro"

        ElseIf cmbAlmacenes.Text = "Almacen Bola de oro" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen Bola de oro"

        ElseIf cmbAlmacenes.Text = "Almacen la perla" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen la perla"

        ElseIf cmbAlmacenes.Text = "Almacen los andes" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen los andes"

        ElseIf cmbAlmacenes.Text = "Almacen salame" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen salame"

        ElseIf cmbAlmacenes.Text = "Almacen san juan" And txtpromedio.Text >= ventamedio Then
            txtLista.Text += "Almacen san juan"
        End If
    End Sub

    Private Sub cmbAlmacenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlmacenes.SelectedIndexChanged
        Select Case cmbAlmacenes.SelectedIndex
            Case 0

                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 1
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 2
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 3
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 4
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 5
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 6
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 7
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 8
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 9
                grbvalores.Visible = True
                txtCantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
        End Select
    End Sub


    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un valor, este campo es obligatorio")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantidad.Clear()
        txtLista.Clear()
        txtpromedio.Clear()
        txtVentas.Clear()


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        MenuGuia.Show()
    End Sub
End Class