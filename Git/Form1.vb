Public Class Form1

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        End
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub
End Class
