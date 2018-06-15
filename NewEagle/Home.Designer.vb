<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label1.Location = New System.Drawing.Point(30, 28)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 29)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "物件数"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label2.Location = New System.Drawing.Point(109, 28)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(33, 29)
		Me.Label2.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Button1.Location = New System.Drawing.Point(198, 12)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(115, 45)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "開く"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Button2.Location = New System.Drawing.Point(198, 63)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(115, 45)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "新規追加"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Button3.Location = New System.Drawing.Point(345, 12)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(115, 45)
		Me.Button3.TabIndex = 4
		Me.Button3.Text = "コピー"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Button4.Location = New System.Drawing.Point(345, 63)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(115, 45)
		Me.Button4.TabIndex = 5
		Me.Button4.Text = "選択"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Button5.Location = New System.Drawing.Point(492, 12)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(115, 45)
		Me.Button5.TabIndex = 6
		Me.Button5.Text = "保存"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Button6.Location = New System.Drawing.Point(492, 63)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(115, 45)
		Me.Button6.TabIndex = 7
		Me.Button6.Text = "削除"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label3.Location = New System.Drawing.Point(297, 125)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(174, 30)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "登録物件一覧"
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(12, 158)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowTemplate.Height = 21
		Me.DataGridView1.Size = New System.Drawing.Size(776, 280)
		Me.DataGridView1.TabIndex = 9
		'
		'Home
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Home"
		Me.Text = "Home"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents DataGridView1 As DataGridView
End Class
