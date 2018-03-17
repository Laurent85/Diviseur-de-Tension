Public Class Form1

    Dim R = {1, 1.1, 1.2, 1.3, 1.5, 1.6, 1.8, 2, 2.2, 2.4, 2.7, 3, 3.3, 3.6, 3.9, 4.3, 4.7, 5.1, 5.6, 6.2, 6.8, 7.5, 8.2, 9.1}
    Dim diff As Double
    Dim mini As Double
    Dim R1_bis As Double
    Dim R2_bis As Double
    Dim R1_ter As Double
    Dim R2_ter As Double
    Dim R1_str As String
    Dim R2_str As String
    Dim V As Double
    Dim VR2 As Double
    Dim h As Integer

    Sub calculs()
        mini = Val(Précision.Text)
        For p As Integer = 0 To 5
            h = 10 ^ p
            For j As Integer = 0 To 23
                For k As Integer = 0 To 23
                    V = Val(Vin.Text) * ((h * R(k)) / ((h * R(j)) + (h * R(k))))
                    diff = Math.Abs(Val(Vout.Text) - V)
                    If diff <= mini Then
                        'mini = diff
                        R1_ter = h * R(j)
                        R2_ter = h * R(k)
                        R1_str = "R1 = " & R1_ter & "Ω"
                        R2_str = "R2 = " & R2_ter & "Ω"
                        If R1_ter >= 1000 Then
                            R1_ter = R1_ter / 1000
                            R1_str = "R1 = " & R1_ter & " " & "KΩ"
                        End If
                        If R2_ter >= 1000 Then
                            R2_ter = R2_ter / 1000
                            R2_str = "R2 = " & R2_ter & " " & "KΩ"
                        End If
                        If diff = 0 Then
                            VR2 = Math.Round(V, 2)
                            Tableau1.Text = Tableau1.Text & R1_str & "          " & R2_str & "          " & "(Vout=" & VR2 & "V)" & vbCrLf
                        Else
                            VR2 = Math.Round(V, 2)
                            Tableau2.Text = Tableau2.Text & R1_str & "          " & R2_str & "          " & "(Vout=" & VR2 & "V)" & vbCrLf
                        End If
                        Tableau.Text = "Valeurs exactes" & vbCrLf & Tableau1.Text & vbCrLf & "Valeurs approchées" & vbCrLf & Tableau2.Text
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub Vout_TextChanged(sender As Object, e As EventArgs) Handles Vout.TextChanged
        Précision.Text = "0.1"
        Tableau.Clear()
        Tableau1.Clear()
        Tableau2.Clear()
        calculs()
    End Sub

    Private Sub Précision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Précision.SelectedIndexChanged
        Tableau.Clear()
        Tableau1.Clear()
        Tableau2.Clear()
        calculs()
    End Sub

    Private Sub Vin_TextChanged(sender As Object, e As EventArgs) Handles Vin.TextChanged
        Précision.Text = "0.1"
        Tableau.Clear()
        Tableau1.Clear()
        Tableau2.Clear()
        calculs()
    End Sub
End Class
