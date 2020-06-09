<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGuia
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnalmacenes = New System.Windows.Forms.Button()
        Me.btnNumeros = New System.Windows.Forms.Button()
        Me.btnFormula = New System.Windows.Forms.Button()
        Me.btnCalculadoraBasica = New System.Windows.Forms.Button()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.btnalmacenes)
        Me.GroupBox1.Controls.Add(Me.btnNumeros)
        Me.GroupBox1.Controls.Add(Me.btnFormula)
        Me.GroupBox1.Controls.Add(Me.btnCalculadoraBasica)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 171)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(35, 139)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "SAR Hondura"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnalmacenes
        '
        Me.btnalmacenes.Location = New System.Drawing.Point(35, 109)
        Me.btnalmacenes.Name = "btnalmacenes"
        Me.btnalmacenes.Size = New System.Drawing.Size(176, 23)
        Me.btnalmacenes.TabIndex = 3
        Me.btnalmacenes.Text = "Empresa"
        Me.btnalmacenes.UseVisualStyleBackColor = True
        '
        'btnNumeros
        '
        Me.btnNumeros.Location = New System.Drawing.Point(35, 80)
        Me.btnNumeros.Name = "btnNumeros"
        Me.btnNumeros.Size = New System.Drawing.Size(176, 23)
        Me.btnNumeros.TabIndex = 2
        Me.btnNumeros.Text = "Numeros"
        Me.btnNumeros.UseVisualStyleBackColor = True
        '
        'btnFormula
        '
        Me.btnFormula.Location = New System.Drawing.Point(35, 51)
        Me.btnFormula.Name = "btnFormula"
        Me.btnFormula.Size = New System.Drawing.Size(176, 23)
        Me.btnFormula.TabIndex = 1
        Me.btnFormula.Text = "Formula General"
        Me.btnFormula.UseVisualStyleBackColor = True
        '
        'btnCalculadoraBasica
        '
        Me.btnCalculadoraBasica.Location = New System.Drawing.Point(35, 22)
        Me.btnCalculadoraBasica.Name = "btnCalculadoraBasica"
        Me.btnCalculadoraBasica.Size = New System.Drawing.Size(176, 23)
        Me.btnCalculadoraBasica.TabIndex = 0
        Me.btnCalculadoraBasica.Text = "Calculadora Basica"
        Me.btnCalculadoraBasica.UseVisualStyleBackColor = True
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitar.Location = New System.Drawing.Point(121, 198)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(84, 35)
        Me.btnSolicitar.TabIndex = 6
        Me.btnSolicitar.Text = "salir"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'MenuGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 258)
        Me.Controls.Add(Me.btnSolicitar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MenuGuia"
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnalmacenes As Button
    Friend WithEvents btnNumeros As Button
    Friend WithEvents btnFormula As Button
    Friend WithEvents btnCalculadoraBasica As Button
End Class
