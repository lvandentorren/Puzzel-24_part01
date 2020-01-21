Public Class Puzzel24

    Private Sub Einde_Click(sender As Object, e As EventArgs) Handles Einde.Click
        ActiveForm.Close()
    End Sub

    Private Sub Puzzel24_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim box As Control
        For Each box In Controls
            If TypeOf (box) Is TextBox Then
                box.Text = ""
                box.BackColor = Color.GhostWhite

            End If
        Next

        'For s = 1 To 36
        '    gebruikt(s) = False
        '    rotatie(s) = 0
        'Next

        'For p = 1 To 36
        '    startletter(p) = 1
        '    laatstenietgebruikt(p) = 36
        '    stuk(p) = Nothing
        'Next

        'LeesStukken()




        Dim p As Byte = 18
        ProgressBar1.Value = p

    End Sub
End Class
