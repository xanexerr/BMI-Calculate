Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 65 To 90 'A-Z
                e.Handled = False
            Case 97 To 122 'a-z
                e.Handled = False
            Case 161 To 240 'พยัญชนะและสระไทย
                e.Handled = False
            Case 8, 13, Keys.Delete 'ปุ่ม backspace,enterและ delete
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("อนุญาติให้กรอกเฉพาะตัวอักษร", "ผิดพลาด!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select
    End Sub


    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 46 To 57 'ตรวจสอบตัวเลข 0-9
                e.Handled = False
            Case 8, 13, Keys.Delete
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("อนุญาติให้ป้อนเฉพาะตัวเลขเท่านั้น", "การป้อนคะแนน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox5.KeyPress
        Select Case Asc(e.KeyChar)
            Case 46 To 57 'ตรวจสอบตัวเลข 0-9
                e.Handled = False
            Case 8, 13, Keys.Delete
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("อนุญาติให้ป้อนเฉพาะตัวเลขเท่านั้น", "เกิดข้อผิดำลาด!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Select Case Asc(e.KeyChar)
            Case 46 To 57 'ตรวจสอบตัวเลข 0-9
                e.Handled = False
            Case 8, 13, Keys.Delete
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("อนุญาติให้ป้อนเฉพาะตัวเลขเท่านั้น", "เกิดข้อผิดำลาด!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub TextBox3_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Q As Integer
        Q = MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "BMI Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If Q = DialogResult.Yes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim age As Integer
        age = Val(TextBox2.Text)
        If TextBox4.Text = "" Then 'ถ้า textbox 1 เป็นค่าว่าง
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "ข้อควรระวังการป้อนข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error) 'แสดงข้อความกรุณาป้อนคะแนน...
            TextBox4.Focus() 'ให้ขึ้น cursor ใน textbox 1
        ElseIf TextBox3.Text = "" Then 'ถ้า textbox 1 เป็นค่าว่าง
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "ข้อควรระวังการป้อนข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error) 'แสดงข้อความกรุณาป้อนคะแนน...
            TextBox3.Focus() 'ให้ขึ้น cursor ใน textbox 1
        ElseIf TextBox2.Text = "" Then 'ถ้า textbox 1 เป็นค่าว่าง
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "ข้อควรระวังการป้อนข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error) 'แสดงข้อความกรุณาป้อนคะแนน...
            TextBox2.Focus() 'ให้ขึ้น cursor ใน textbox 
        ElseIf TextBox5.Text = "" Then 'ถ้า textbox 1 เป็นค่าว่าง
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "ข้อควรระวังการป้อนข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error) 'แสดงข้อความกรุณาป้อนคะแนน...
            TextBox5.Focus() 'ให้ขึ้น cursor ใน textbox 1
        ElseIf Age < 20 Or Age > 150 Then 'ถ้า score มีค่าน้อยกว่า 0 และมากกว่า 60
            MessageBox.Show("โปรแกรมคำนวณค่าดัชนีมวลการนี้ ผู้ใช้งานต้องอายุอย่างน้อย 20 ปีขึ้นไป", "มีบางอย่างผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Clear() 'clear textbox1
            TextBox2.Focus()
        Else



            Dim weight As Double
            Dim height As Double
            Dim bmi As Double

            weight = TextBox3.Text
            height = TextBox5.Text
            bmi = weight / ((height * 0.01) ^ 2)
            bmi = Math.Round(bmi, 2)

            'bmi = Format(CDbl(bmi), "#,#.#")
            Dim imge As String
            If weight > height Then
                TextBox1.Text = ("มีบางอย่างผิดพลาด กรุณากรอกข้อมูลใหม่")
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
                Button2.Enabled = True
                Button3.Enabled = True
                Button1.Enabled = False
                Button3.Enabled = False
                Exit Sub
            Else
                Select Case bmi
                    Case Is >= 40
                        TextBox1.Text = ("ค่าดัชนีมวลกายของคุณ คือ " & bmi & " คุณคือโรคอ้วนขั้นสูงสุด")
                        imge = "6.png"
                    Case Is >= 35.0
                        TextBox1.Text = ("ค่าดัชนีมวลกายของคุณ คือ " & bmi & " คุณคือโรคอ้วนขั้นที่ 2")
                        imge = "5.png"
                    Case Is >= 28.5
                        TextBox1.Text = ("ค่าดัชนีมวลกายของคุณ คือ " & bmi & " คุณคือโรคอ้วนขั้นที่ 1")
                        imge = "4.png"
                    Case Is >= 23.5
                        TextBox1.Text = ("ค่าดัชนีมวลกายของคุณ คือ " & bmi & " คุณน้ำหนักเกิน/อ้วน")
                        imge = "3.png"
                    Case Is >= 18.5
                        TextBox1.Text = ("ค่าดัชนีมวลกายของคุณ คือ " & bmi & " คุณน้ำหนักปกติ สมส่วน")
                        imge = "2.png"
                    Case Is < 18.5
                        TextBox1.Text = ("ค่าดัชนีมวลกายของคุณ คือ " & bmi & " คุณน้ำหนักต่่ำกว่าเกณฑ์")
                        imge = "1.png"
                End Select
            End If
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox5.Enabled = False
            TextBox4.Enabled = False
            Button2.Enabled = True
            Button1.Enabled = False
            Button3.Enabled = True
            PictureBox1.Image = System.Drawing.Image.FromFile("G:\WorkStudy\VC2_2\VB_Natthapumin\Work9_Natthapumin\BMI\" & imge)

        End If
    End Sub

    Private Sub TextBox4_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Select Case Asc(e.KeyChar)
            Case 65 To 90 'A-Z
                e.Handled = False
            Case 97 To 122 'a-z
                e.Handled = False
            Case 161 To 240 'พยัญชนะและสระไทย
                e.Handled = False
            Case 8, 13, Keys.Delete, Keys.Space 'ปุ่ม backspace,enterและ delete
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("อนุญาติให้กรอกเฉพาะตัวอักษร", "ผิดพลาด!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim imge As String

        imge = "BM.png"
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Text = "แสดงค่าดัชนีมวลกาย"

        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox5.Enabled = True
        TextBox4.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        PictureBox1.Image = System.Drawing.Image.FromFile("G:\WorkStudy\VC2_2\VB_Natthapumin\Work9_Natthapumin\BMI\" & imge)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim report As String = ""
        report += "คุณ" + TextBox4.Text + vbCrLf
        report += "น้ำหนักและส่วนสูงของคุณนั้น" + vbCrLf + vbCrLf
        report += "จัดอยู่ในระดับ : " + TextBox1.Text + vbCrLf
        MessageBox.Show(report, "รายงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

        
    End Sub
End Class
