Public Class Calculadora_basica
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "0"
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btnP.Click
        txtResultado.Text &= "."
        EvaluaRestriccionesParaConcatenar()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If
    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtResultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub
    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(txtResultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            txtResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub
    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            txtResultado.Text = ""
            SePresionaOperador = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub
End Class