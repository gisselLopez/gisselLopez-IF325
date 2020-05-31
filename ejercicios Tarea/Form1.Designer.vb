<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.txtMultiplicacion = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "valor 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "valor 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Suma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Multiplicacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Resta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Division"
        '
        'txtsuma
        '
        Me.txtsuma.Location = New System.Drawing.Point(109, 179)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(100, 20)
        Me.txtsuma.TabIndex = 6
        '
        'txtMultiplicacion
        '
        Me.txtMultiplicacion.Location = New System.Drawing.Point(109, 218)
        Me.txtMultiplicacion.Name = "txtMultiplicacion"
        Me.txtMultiplicacion.Size = New System.Drawing.Size(100, 20)
        Me.txtMultiplicacion.TabIndex = 7
        '
        'txtResta
        '
        Me.txtResta.Location = New System.Drawing.Point(326, 179)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(100, 20)
        Me.txtResta.TabIndex = 8
        '
        'txtDivision
        '
        Me.txtDivision.Location = New System.Drawing.Point(326, 217)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(100, 20)
        Me.txtDivision.TabIndex = 9
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(92, 121)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(209, 121)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(120, 36)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 12
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(120, 71)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 13
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(336, 120)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 335)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtDivision)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtMultiplicacion)
        Me.Controls.Add(Me.txtsuma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "4 operaciones Matematicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txtMultiplicacion As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtDivision As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents btnSalir As Button
End Class
