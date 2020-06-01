<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperacionesBasicas
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
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ChbSuma = New System.Windows.Forms.CheckBox()
        Me.ChbMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.ChbResta = New System.Windows.Forms.CheckBox()
        Me.ChbDivision = New System.Windows.Forms.CheckBox()
        Me.ChbRaizCuadrada = New System.Windows.Forms.CheckBox()
        Me.ChbPotencia = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor 2"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(115, 28)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 8
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(115, 57)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 9
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(309, 188)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 14
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(265, 227)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 16
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(380, 223)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(334, 258)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ChbSuma
        '
        Me.ChbSuma.AutoSize = True
        Me.ChbSuma.Location = New System.Drawing.Point(24, 150)
        Me.ChbSuma.Name = "ChbSuma"
        Me.ChbSuma.Size = New System.Drawing.Size(53, 17)
        Me.ChbSuma.TabIndex = 19
        Me.ChbSuma.Text = "Suma"
        Me.ChbSuma.UseVisualStyleBackColor = True
        '
        'ChbMultiplicacion
        '
        Me.ChbMultiplicacion.AutoSize = True
        Me.ChbMultiplicacion.Location = New System.Drawing.Point(28, 191)
        Me.ChbMultiplicacion.Name = "ChbMultiplicacion"
        Me.ChbMultiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.ChbMultiplicacion.TabIndex = 20
        Me.ChbMultiplicacion.Text = "Multiplicacion"
        Me.ChbMultiplicacion.UseVisualStyleBackColor = True
        '
        'ChbResta
        '
        Me.ChbResta.AutoSize = True
        Me.ChbResta.Location = New System.Drawing.Point(28, 227)
        Me.ChbResta.Name = "ChbResta"
        Me.ChbResta.Size = New System.Drawing.Size(54, 17)
        Me.ChbResta.TabIndex = 21
        Me.ChbResta.Text = "Resta"
        Me.ChbResta.UseVisualStyleBackColor = True
        '
        'ChbDivision
        '
        Me.ChbDivision.AutoSize = True
        Me.ChbDivision.Location = New System.Drawing.Point(144, 227)
        Me.ChbDivision.Name = "ChbDivision"
        Me.ChbDivision.Size = New System.Drawing.Size(63, 17)
        Me.ChbDivision.TabIndex = 22
        Me.ChbDivision.Text = "Division"
        Me.ChbDivision.UseVisualStyleBackColor = True
        '
        'ChbRaizCuadrada
        '
        Me.ChbRaizCuadrada.AutoSize = True
        Me.ChbRaizCuadrada.Location = New System.Drawing.Point(144, 150)
        Me.ChbRaizCuadrada.Name = "ChbRaizCuadrada"
        Me.ChbRaizCuadrada.Size = New System.Drawing.Size(96, 17)
        Me.ChbRaizCuadrada.TabIndex = 23
        Me.ChbRaizCuadrada.Text = "Raiz Cuadrada"
        Me.ChbRaizCuadrada.UseVisualStyleBackColor = True
        '
        'ChbPotencia
        '
        Me.ChbPotencia.AutoSize = True
        Me.ChbPotencia.Location = New System.Drawing.Point(144, 191)
        Me.ChbPotencia.Name = "ChbPotencia"
        Me.ChbPotencia.Size = New System.Drawing.Size(68, 17)
        Me.ChbPotencia.TabIndex = 24
        Me.ChbPotencia.Text = "Potencia"
        Me.ChbPotencia.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Resultado"
        '
        'OperacionesBasicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 293)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChbPotencia)
        Me.Controls.Add(Me.ChbRaizCuadrada)
        Me.Controls.Add(Me.ChbDivision)
        Me.Controls.Add(Me.ChbResta)
        Me.Controls.Add(Me.ChbMultiplicacion)
        Me.Controls.Add(Me.ChbSuma)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OperacionesBasicas"
        Me.Text = "OperacionesBasicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ChbSuma As CheckBox
    Friend WithEvents ChbMultiplicacion As CheckBox
    Friend WithEvents ChbResta As CheckBox
    Friend WithEvents ChbDivision As CheckBox
    Friend WithEvents ChbRaizCuadrada As CheckBox
    Friend WithEvents ChbPotencia As CheckBox
    Friend WithEvents Label3 As Label
End Class
