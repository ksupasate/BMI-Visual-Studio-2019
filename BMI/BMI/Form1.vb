Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, BMI As Single
        height = TextBox2.Text
        weight = TextBox1.Text
        BMI = (weight) / (height ^ 2)
        TextBox3.Text = BMI


    End Sub
End Class
