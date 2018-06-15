Imports System.Data.DataTable

Public Class Home
	Dim table As New DataTable("Table")

	Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		table.Columns.Add("No.", Type.GetType("System.Int32"))
		table.Columns.Add("工事件名", Type.GetType("System.String"))
		table.Columns.Add("杭工法", Type.GetType("System.String"))
		table.Columns.Add("コメント", Type.GetType("System.String"))

		DataGridView1.DataSource = table

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Register.Show()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

	End Sub


End Class
