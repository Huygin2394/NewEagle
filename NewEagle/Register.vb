Imports System.IO

Public Class Register

	Dim FileName As String = "C:\Users\sfujita\source\repos\NewEagle\NewEagle\save.dat"

	Private Sub 決定_Click(sender As Object, e As EventArgs) Handles 決定.Click
		Dim table As New DataTable("Table")


		table.Columns.Add("No.", Type.GetType("System.Int32"))
		table.Columns.Add("工事件名", Type.GetType("System.String"))
		table.Columns.Add("杭工法", Type.GetType("System.String"))
		table.Columns.Add("コメント", Type.GetType("System.String"))

		table.Rows.Add("1", TextBox1.Text, TextBox2.Text, TextBox3.Text)
		Home.DataGridView1.DataSource = table
		File.AppendAllText(FileName, vbCrLf & "1" & " " & TextBox1.Text & TextBox2.Text & TextBox3.Text)

		Me.Close()

	End Sub

	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
		TextBox2.Text = RadioButton1.Text
	End Sub

	Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
		TextBox2.Text = RadioButton2.Text
	End Sub

	Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
		TextBox2.Text = RadioButton3.Text
	End Sub

	Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
		TextBox2.Text = RadioButton4.Text
	End Sub
End Class