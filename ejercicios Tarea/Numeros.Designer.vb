<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Numeros
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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtpar = New System.Windows.Forms.TextBox()
        Me.txtimpar = New System.Windows.Forms.TextBox()
        Me.txtpositivo = New System.Windows.Forms.TextBox()
        Me.txtnegativo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.CmbLista = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalSuma = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbimpar = New System.Windows.Forms.Label()
        Me.Lbpar = New System.Windows.Forms.Label()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese un numero"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(126, 43)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero.TabIndex = 1
        '
        'txtpar
        '
        Me.txtpar.Location = New System.Drawing.Point(132, 159)
        Me.txtpar.Name = "txtpar"
        Me.txtpar.Size = New System.Drawing.Size(100, 20)
        Me.txtpar.TabIndex = 2
        '
        'txtimpar
        '
        Me.txtimpar.Location = New System.Drawing.Point(132, 227)
        Me.txtimpar.Name = "txtimpar"
        Me.txtimpar.Size = New System.Drawing.Size(100, 20)
        Me.txtimpar.TabIndex = 3
        '
        'txtpositivo
        '
        Me.txtpositivo.Location = New System.Drawing.Point(132, 192)
        Me.txtpositivo.Name = "txtpositivo"
        Me.txtpositivo.Size = New System.Drawing.Size(100, 20)
        Me.txtpositivo.TabIndex = 4
        '
        'txtnegativo
        '
        Me.txtnegativo.Location = New System.Drawing.Point(132, 263)
        Me.txtnegativo.Name = "txtnegativo"
        Me.txtnegativo.Size = New System.Drawing.Size(100, 20)
        Me.txtnegativo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Numeros pares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Numeros impares"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Numeros positivos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numeros negativos"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Location = New System.Drawing.Point(146, 84)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 36)
        Me.btnMostrar.TabIndex = 10
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(257, 183)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 36)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(257, 243)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 36)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'CmbLista
        '
        Me.CmbLista.FormattingEnabled = True
        Me.CmbLista.Location = New System.Drawing.Point(294, 43)
        Me.CmbLista.Name = "CmbLista"
        Me.CmbLista.Size = New System.Drawing.Size(121, 21)
        Me.CmbLista.TabIndex = 13
        Me.CmbLista.Text = "Numeros ingresados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(357, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Suma total"
        '
        'txtTotalSuma
        '
        Me.txtTotalSuma.Location = New System.Drawing.Point(360, 202)
        Me.txtTotalSuma.Name = "txtTotalSuma"
        Me.txtTotalSuma.Size = New System.Drawing.Size(55, 20)
        Me.txtTotalSuma.TabIndex = 15
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(360, 160)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(55, 20)
        Me.txtTotal.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(303, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total Numeros ingresados"
        '
        'Lbimpar
        '
        Me.Lbimpar.AutoSize = True
        Me.Lbimpar.Location = New System.Drawing.Point(239, 156)
        Me.Lbimpar.Name = "Lbimpar"
        Me.Lbimpar.Size = New System.Drawing.Size(0, 13)
        Me.Lbimpar.TabIndex = 18
        '
        'Lbpar
        '
        Me.Lbpar.AutoSize = True
        Me.Lbpar.Location = New System.Drawing.Point(239, 227)
        Me.Lbpar.Name = "Lbpar"
        Me.Lbpar.Size = New System.Drawing.Size(0, 13)
        Me.Lbpar.TabIndex = 19
        '
        'btnregresar
        '
        Me.btnregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregresar.Location = New System.Drawing.Point(375, 255)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(86, 31)
        Me.btnregresar.TabIndex = 20
        Me.btnregresar.Text = "Regresar"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'Numeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 295)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.Lbpar)
        Me.Controls.Add(Me.Lbimpar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTotalSuma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbLista)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnegativo)
        Me.Controls.Add(Me.txtpositivo)
        Me.Controls.Add(Me.txtimpar)
        Me.Controls.Add(Me.txtpar)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Numeros"
        Me.Text = "Numeros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtpar As TextBox
    Friend WithEvents txtimpar As TextBox
    Friend WithEvents txtpositivo As TextBox
    Friend WithEvents txtnegativo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents CmbLista As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalSuma As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Lbimpar As Label
    Friend WithEvents Lbpar As Label
    Friend WithEvents btnregresar As Button
End Class
