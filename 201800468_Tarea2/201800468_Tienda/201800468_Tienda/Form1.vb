Imports System.Math

Public Class Form1
    Const precioarroz As Double = 2.0
    Const pfrijol As Double = 1.75
    Const precioazucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagosiniva As Double = 0
    Dim valordeliva As Double = 0
    Dim pagoconiva As Double = 0
    Dim Desc As Double = 0
    Dim tot As Double = 0



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'aqui va el codigo
        pagosiniva = (Val(lbsArroz.Text) * precioarroz) + (Val(lbsFrijol.Text) * pfrijol) + (Val(lbsAzucar.Text) * precioazucar)
        valordeliva = pagosiniva * IVA
        pagoconiva = valordeliva + pagosiniva
        Desc = pagoconiva * 0.025
        tot = pagoconiva - Desc

        PadIVA.Text = Round(pagosiniva, 2)
        vdIVA.Text = Round(valordeliva, 2)
        PceIVA.Text = Round(pagoconiva, 2)
        Descuento.Text = Round(Desc, 2)
        Total.Text = Round(tot, 2)






        GroupBox2.Visible = True



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbsArroz.Clear()
        lbsAzucar.Clear()
        lbsFrijol.Clear()
        lbsArroz.Focus()



        GroupBox2.Visible = False
    End Sub

    Private Sub lbsArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lbsArroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lbsFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lbsFrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lbsAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lbsAzucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
