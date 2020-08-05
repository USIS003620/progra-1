Public Class Form1

    Private Sub btnprocesar_Click(sender As Object, e As EventArgs) Handles btnprocesar.Click
        Dim nTabla, i As SByte
        nTabla = txtNtabla.Text
        lstTabla.Items.Clear()
        If nTabla <= 12 Then
            For i = 1 To 10
                lstTabla.Items.Add(nTabla.ToString() + "x" + i.ToString() + "=" + (nTabla * i).ToString())
            Next
        Else
            lstTabla.Items.Add("por favor ingrese solo tablas menores o iguales a 12")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



