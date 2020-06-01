<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaSencilla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.ChbDescuento = New System.Windows.Forms.CheckBox()
        Me.ChbImpuesto = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbDescuento = New System.Windows.Forms.ComboBox()
        Me.CmbImpuesto = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos requeridos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio Unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(139, 39)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioUnitario.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(139, 68)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'ChbDescuento
        '
        Me.ChbDescuento.AutoSize = True
        Me.ChbDescuento.Location = New System.Drawing.Point(30, 113)
        Me.ChbDescuento.Name = "ChbDescuento"
        Me.ChbDescuento.Size = New System.Drawing.Size(108, 17)
        Me.ChbDescuento.TabIndex = 5
        Me.ChbDescuento.Text = "Aplica descuento"
        Me.ChbDescuento.UseVisualStyleBackColor = True
        '
        'ChbImpuesto
        '
        Me.ChbImpuesto.AutoSize = True
        Me.ChbImpuesto.Location = New System.Drawing.Point(172, 113)
        Me.ChbImpuesto.Name = "ChbImpuesto"
        Me.ChbImpuesto.Size = New System.Drawing.Size(100, 17)
        Me.ChbImpuesto.TabIndex = 6
        Me.ChbImpuesto.Text = "Aplica impuesto"
        Me.ChbImpuesto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Subtotal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Impuesto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(405, 214)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 11
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(114, 292)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto.TabIndex = 12
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(114, 218)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(405, 288)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 14
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(316, 39)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(316, 96)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 16
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(460, 75)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Detalle factura"
        '
        'CmbDescuento
        '
        Me.CmbDescuento.FormattingEnabled = True
        Me.CmbDescuento.Items.AddRange(New Object() {"Tercera edad 50%", "Estudiante 30%", "Promocional 40%", "Por cantidad 60%", "Empleado 15%", "Por temporada 5%"})
        Me.CmbDescuento.Location = New System.Drawing.Point(30, 137)
        Me.CmbDescuento.Name = "CmbDescuento"
        Me.CmbDescuento.Size = New System.Drawing.Size(121, 21)
        Me.CmbDescuento.TabIndex = 19
        '
        'CmbImpuesto
        '
        Me.CmbImpuesto.FormattingEnabled = True
        Me.CmbImpuesto.Items.AddRange(New Object() {"15 %", "17 %"})
        Me.CmbImpuesto.Location = New System.Drawing.Point(172, 136)
        Me.CmbImpuesto.Name = "CmbImpuesto"
        Me.CmbImpuesto.Size = New System.Drawing.Size(121, 21)
        Me.CmbImpuesto.TabIndex = 20
        '
        'FacturaSencilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 344)
        Me.Controls.Add(Me.CmbImpuesto)
        Me.Controls.Add(Me.CmbDescuento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChbImpuesto)
        Me.Controls.Add(Me.ChbDescuento)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FacturaSencilla"
        Me.Text = "FacturaSencilla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents ChbDescuento As CheckBox
    Friend WithEvents ChbImpuesto As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbDescuento As ComboBox
    Friend WithEvents CmbImpuesto As ComboBox
End Class
