<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CicloFor
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
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbMostrarSuma = New System.Windows.Forms.ComboBox()
        Me.CmbMostrarMultiplicacion = New System.Windows.Forms.ComboBox()
        Me.CmbMostrarResta = New System.Windows.Forms.ComboBox()
        Me.CmbMostarDivision = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar valor"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(35, 44)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 1
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(125, 47)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Operaciones"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(38, 131)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(156, 130)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Suma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Multiplicacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Resta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Division"
        '
        'cmbMostrarSuma
        '
        Me.cmbMostrarSuma.FormattingEnabled = True
        Me.cmbMostrarSuma.Location = New System.Drawing.Point(35, 197)
        Me.cmbMostrarSuma.Name = "cmbMostrarSuma"
        Me.cmbMostrarSuma.Size = New System.Drawing.Size(121, 21)
        Me.cmbMostrarSuma.TabIndex = 10
        Me.cmbMostrarSuma.Text = "Mostrar Suma"
        '
        'CmbMostrarMultiplicacion
        '
        Me.CmbMostrarMultiplicacion.FormattingEnabled = True
        Me.CmbMostrarMultiplicacion.Location = New System.Drawing.Point(38, 247)
        Me.CmbMostrarMultiplicacion.Name = "CmbMostrarMultiplicacion"
        Me.CmbMostrarMultiplicacion.Size = New System.Drawing.Size(121, 21)
        Me.CmbMostrarMultiplicacion.TabIndex = 11
        Me.CmbMostrarMultiplicacion.Text = "Mostrar Multiplicacion"
        '
        'CmbMostrarResta
        '
        Me.CmbMostrarResta.FormattingEnabled = True
        Me.CmbMostrarResta.Location = New System.Drawing.Point(278, 197)
        Me.CmbMostrarResta.Name = "CmbMostrarResta"
        Me.CmbMostrarResta.Size = New System.Drawing.Size(121, 21)
        Me.CmbMostrarResta.TabIndex = 12
        Me.CmbMostrarResta.Text = "Mostar Resta"
        '
        'CmbMostarDivision
        '
        Me.CmbMostarDivision.FormattingEnabled = True
        Me.CmbMostarDivision.Location = New System.Drawing.Point(275, 246)
        Me.CmbMostarDivision.Name = "CmbMostarDivision"
        Me.CmbMostarDivision.Size = New System.Drawing.Size(121, 21)
        Me.CmbMostarDivision.TabIndex = 13
        Me.CmbMostarDivision.Text = "Mostrar Division"
        '
        'CicloFor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 268)
        Me.Controls.Add(Me.CmbMostarDivision)
        Me.Controls.Add(Me.CmbMostrarResta)
        Me.Controls.Add(Me.CmbMostrarMultiplicacion)
        Me.Controls.Add(Me.cmbMostrarSuma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CicloFor"
        Me.Text = "CicloFor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbMostrarSuma As ComboBox
    Friend WithEvents CmbMostrarMultiplicacion As ComboBox
    Friend WithEvents CmbMostrarResta As ComboBox
    Friend WithEvents CmbMostarDivision As ComboBox
End Class
