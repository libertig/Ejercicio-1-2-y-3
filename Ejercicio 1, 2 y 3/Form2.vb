Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Module1.Mensaje
        Form1.Hide()
    End Sub
End Class