<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.ChbAplicarDescuento = New System.Windows.Forms.CheckBox()
        Me.ChbAplicarImpuesto = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.CombDescuento = New System.Windows.Forms.ComboBox()
        Me.CombImpuesto = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos Requeridos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio Unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'ChbAplicarDescuento
        '
        Me.ChbAplicarDescuento.AutoSize = True
        Me.ChbAplicarDescuento.Location = New System.Drawing.Point(64, 129)
        Me.ChbAplicarDescuento.Name = "ChbAplicarDescuento"
        Me.ChbAplicarDescuento.Size = New System.Drawing.Size(119, 17)
        Me.ChbAplicarDescuento.TabIndex = 3
        Me.ChbAplicarDescuento.Text = "Aplicar Descuentod"
        Me.ChbAplicarDescuento.UseVisualStyleBackColor = True
        '
        'ChbAplicarImpuesto
        '
        Me.ChbAplicarImpuesto.AutoSize = True
        Me.ChbAplicarImpuesto.Location = New System.Drawing.Point(64, 178)
        Me.ChbAplicarImpuesto.Name = "ChbAplicarImpuesto"
        Me.ChbAplicarImpuesto.Size = New System.Drawing.Size(104, 17)
        Me.ChbAplicarImpuesto.TabIndex = 4
        Me.ChbAplicarImpuesto.Text = "Aplicar Impuesto"
        Me.ChbAplicarImpuesto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(273, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Detalle de factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Impuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(347, 46)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 10
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(347, 82)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 11
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Location = New System.Drawing.Point(347, 115)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuesto.TabIndex = 12
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(347, 152)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 13
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(75, 270)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 14
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(247, 270)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(425, 270)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(122, 43)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 17
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(122, 74)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 18
        '
        'CombDescuento
        '
        Me.CombDescuento.FormattingEnabled = True
        Me.CombDescuento.Location = New System.Drawing.Point(64, 151)
        Me.CombDescuento.Name = "CombDescuento"
        Me.CombDescuento.Size = New System.Drawing.Size(121, 21)
        Me.CombDescuento.TabIndex = 19
        '
        'CombImpuesto
        '
        Me.CombImpuesto.FormattingEnabled = True
        Me.CombImpuesto.Location = New System.Drawing.Point(64, 202)
        Me.CombImpuesto.Name = "CombImpuesto"
        Me.CombImpuesto.Size = New System.Drawing.Size(121, 21)
        Me.CombImpuesto.TabIndex = 20
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 328)
        Me.Controls.Add(Me.CombImpuesto)
        Me.Controls.Add(Me.CombDescuento)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.TxtImpuesto)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChbAplicarImpuesto)
        Me.Controls.Add(Me.ChbAplicarDescuento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ChbAplicarDescuento As CheckBox
    Friend WithEvents ChbAplicarImpuesto As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents CombDescuento As ComboBox
    Friend WithEvents CombImpuesto As ComboBox
End Class
