Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim h, w, bmi As Single

        h = TextBox1.Text
        w = TextBox2.Text
        bmi = w / (h / 100) ^ 2
        TextBox3.Text = bmi
        If TextBox1.Text = 0 Then
            MessageBox.Show("รับค่าตั้งแต่ 1 ขึ้นไป !!!")
        ElseIf TextBox2.Text = 0 Then
            MessageBox.Show("รับค่าตั้งแต่ 1 ขึ้นไป !!!")
        End If
       
        If bmi >= 30 Then

            TextBox4.Text = "อ้วนมาก"

        ElseIf bmi >= 25 Then

            TextBox4.Text = "เริ่มอ้วนแล้ว"

        ElseIf bmi >= 23 Then

            TextBox4.Text = "อวบ"

        ElseIf bmi >= 18.5 Then

            TextBox4.Text = "สมส่วน"

        Else

            TextBox4.Text = "ผอม"

        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("รับค่าเฉพาะตัวเลขเท่านั้น !!!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("รับค่าเฉพาะตัวเลขเท่านั้น !!!")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
       
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox1.Text = 0 Then
            TextBox3.Text = 0
        ElseIf TextBox2.Text = 0 Then
            TextBox3.Text = 0
        End If
    End Sub
End Class
