<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizzeria
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
        Me.components = New System.ComponentModel.Container()
        Me.GbPizza = New System.Windows.Forms.GroupBox()
        Me.RdbFamiliar = New System.Windows.Forms.RadioButton()
        Me.RdbGrande = New System.Windows.Forms.RadioButton()
        Me.RdbMediana = New System.Windows.Forms.RadioButton()
        Me.RdbChica = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChbPeperoni = New System.Windows.Forms.CheckBox()
        Me.ChbQueso = New System.Windows.Forms.CheckBox()
        Me.ChbChampinones = New System.Windows.Forms.CheckBox()
        Me.ChbCarne = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NumeroCantidad = New System.Windows.Forms.NumericUpDown()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbBebidas = New System.Windows.Forms.ComboBox()
        Me.GbPizza.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumeroCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbPizza
        '
        Me.GbPizza.BackColor = System.Drawing.Color.Aquamarine
        Me.GbPizza.Controls.Add(Me.RdbFamiliar)
        Me.GbPizza.Controls.Add(Me.RdbGrande)
        Me.GbPizza.Controls.Add(Me.RdbMediana)
        Me.GbPizza.Controls.Add(Me.RdbChica)
        Me.GbPizza.Location = New System.Drawing.Point(12, 41)
        Me.GbPizza.Name = "GbPizza"
        Me.GbPizza.Size = New System.Drawing.Size(200, 129)
        Me.GbPizza.TabIndex = 0
        Me.GbPizza.TabStop = False
        Me.GbPizza.Text = "Pizza"
        '
        'RdbFamiliar
        '
        Me.RdbFamiliar.AutoSize = True
        Me.RdbFamiliar.Location = New System.Drawing.Point(7, 92)
        Me.RdbFamiliar.Name = "RdbFamiliar"
        Me.RdbFamiliar.Size = New System.Drawing.Size(87, 17)
        Me.RdbFamiliar.TabIndex = 3
        Me.RdbFamiliar.TabStop = True
        Me.RdbFamiliar.Text = "Familiar $200"
        Me.RdbFamiliar.UseVisualStyleBackColor = True
        '
        'RdbGrande
        '
        Me.RdbGrande.AutoSize = True
        Me.RdbGrande.Location = New System.Drawing.Point(7, 68)
        Me.RdbGrande.Name = "RdbGrande"
        Me.RdbGrande.Size = New System.Drawing.Size(87, 17)
        Me.RdbGrande.TabIndex = 2
        Me.RdbGrande.TabStop = True
        Me.RdbGrande.Text = "Grande $150"
        Me.RdbGrande.UseVisualStyleBackColor = True
        '
        'RdbMediana
        '
        Me.RdbMediana.AutoSize = True
        Me.RdbMediana.Location = New System.Drawing.Point(7, 44)
        Me.RdbMediana.Name = "RdbMediana"
        Me.RdbMediana.Size = New System.Drawing.Size(93, 17)
        Me.RdbMediana.TabIndex = 1
        Me.RdbMediana.TabStop = True
        Me.RdbMediana.Text = "Mediana $100"
        Me.RdbMediana.UseVisualStyleBackColor = True
        '
        'RdbChica
        '
        Me.RdbChica.AutoSize = True
        Me.RdbChica.Location = New System.Drawing.Point(7, 20)
        Me.RdbChica.Name = "RdbChica"
        Me.RdbChica.Size = New System.Drawing.Size(73, 17)
        Me.RdbChica.TabIndex = 0
        Me.RdbChica.TabStop = True
        Me.RdbChica.Text = "Chica $50"
        Me.RdbChica.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox2.Controls.Add(Me.ChbPeperoni)
        Me.GroupBox2.Controls.Add(Me.ChbQueso)
        Me.GroupBox2.Controls.Add(Me.ChbChampinones)
        Me.GroupBox2.Controls.Add(Me.ChbCarne)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 129)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingredientes extra"
        '
        'ChbPeperoni
        '
        Me.ChbPeperoni.AutoSize = True
        Me.ChbPeperoni.Location = New System.Drawing.Point(7, 92)
        Me.ChbPeperoni.Name = "ChbPeperoni"
        Me.ChbPeperoni.Size = New System.Drawing.Size(89, 17)
        Me.ChbPeperoni.TabIndex = 3
        Me.ChbPeperoni.Text = "Peperoni $15"
        Me.ChbPeperoni.UseVisualStyleBackColor = True
        '
        'ChbQueso
        '
        Me.ChbQueso.AutoSize = True
        Me.ChbQueso.Location = New System.Drawing.Point(7, 68)
        Me.ChbQueso.Name = "ChbQueso"
        Me.ChbQueso.Size = New System.Drawing.Size(105, 17)
        Me.ChbQueso.TabIndex = 2
        Me.ChbQueso.Text = "Extra Queso $10"
        Me.ChbQueso.UseVisualStyleBackColor = True
        '
        'ChbChampinones
        '
        Me.ChbChampinones.AutoSize = True
        Me.ChbChampinones.Location = New System.Drawing.Point(7, 44)
        Me.ChbChampinones.Name = "ChbChampinones"
        Me.ChbChampinones.Size = New System.Drawing.Size(111, 17)
        Me.ChbChampinones.TabIndex = 1
        Me.ChbChampinones.Text = "Champinones $10"
        Me.ChbChampinones.UseVisualStyleBackColor = True
        '
        'ChbCarne
        '
        Me.ChbCarne.AutoSize = True
        Me.ChbCarne.Location = New System.Drawing.Point(7, 20)
        Me.ChbCarne.Name = "ChbCarne"
        Me.ChbCarne.Size = New System.Drawing.Size(74, 17)
        Me.ChbCarne.TabIndex = 0
        Me.ChbCarne.Text = "carne $20"
        Me.ChbCarne.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SpringGreen
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.txtImpuesto)
        Me.GroupBox3.Controls.Add(Me.txtSubtotal)
        Me.GroupBox3.Location = New System.Drawing.Point(433, 205)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(191, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total: $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Impuesto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Subtotal"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(91, 74)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(50, 20)
        Me.txtTotal.TabIndex = 4
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(91, 48)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(50, 20)
        Me.txtImpuesto.TabIndex = 2
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(91, 19)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(50, 20)
        Me.txtSubtotal.TabIndex = 0
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.Black
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCalcular.Location = New System.Drawing.Point(298, 176)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 40)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.Location = New System.Drawing.Point(298, 222)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 40)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(298, 272)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 33)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBox4.Controls.Add(Me.NumeroCantidad)
        Me.GroupBox4.Location = New System.Drawing.Point(424, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 129)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Numero de Pizzas que desee"
        '
        'NumeroCantidad
        '
        Me.NumeroCantidad.BackColor = System.Drawing.Color.LimeGreen
        Me.NumeroCantidad.Location = New System.Drawing.Point(40, 43)
        Me.NumeroCantidad.Name = "NumeroCantidad"
        Me.NumeroCantidad.Size = New System.Drawing.Size(120, 20)
        Me.NumeroCantidad.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkGreen
        Me.DateTimePicker1.Location = New System.Drawing.Point(433, 305)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(191, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(237, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pizzeria"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox1.Controls.Add(Me.CmbBebidas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bebidas"
        '
        'CmbBebidas
        '
        Me.CmbBebidas.BackColor = System.Drawing.Color.LimeGreen
        Me.CmbBebidas.FormattingEnabled = True
        Me.CmbBebidas.Items.AddRange(New Object() {"Coca cola $10", "Pepsi $8", "Tropical banana $5", "Tropical uva $5", "", ""})
        Me.CmbBebidas.Location = New System.Drawing.Point(25, 36)
        Me.CmbBebidas.Name = "CmbBebidas"
        Me.CmbBebidas.Size = New System.Drawing.Size(121, 21)
        Me.CmbBebidas.TabIndex = 0
        '
        'Pizzeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(653, 328)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbPizza)
        Me.Name = "Pizzeria"
        Me.Text = "Pizzeria"
        Me.GbPizza.ResumeLayout(False)
        Me.GbPizza.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.NumeroCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbPizza As GroupBox
    Friend WithEvents RdbFamiliar As RadioButton
    Friend WithEvents RdbGrande As RadioButton
    Friend WithEvents RdbMediana As RadioButton
    Friend WithEvents RdbChica As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChbPeperoni As CheckBox
    Friend WithEvents ChbQueso As CheckBox
    Friend WithEvents ChbChampinones As CheckBox
    Friend WithEvents ChbCarne As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents NumeroCantidad As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbBebidas As ComboBox
    Friend WithEvents Label2 As Label
End Class
