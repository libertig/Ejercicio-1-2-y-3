﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.Mensaje = TextBox1.Text
        Form2.Show()
    End Sub
End Class
