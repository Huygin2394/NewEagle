<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.工事件名 = New System.Windows.Forms.Label()
		Me.杭工法 = New System.Windows.Forms.Label()
		Me.コメント = New System.Windows.Forms.Label()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.決定 = New System.Windows.Forms.Button()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton4 = New System.Windows.Forms.RadioButton()
		Me.全クリア = New System.Windows.Forms.Button()
		Me.新規追加 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(124, 46)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(531, 55)
		Me.TextBox1.TabIndex = 0
		'
		'TextBox2
		'
		Me.TextBox2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.TextBox2.Location = New System.Drawing.Point(124, 107)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(531, 46)
		Me.TextBox2.TabIndex = 1
		'
		'TextBox3
		'
		Me.TextBox3.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.TextBox3.Location = New System.Drawing.Point(124, 222)
		Me.TextBox3.Multiline = True
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(531, 57)
		Me.TextBox3.TabIndex = 2
		'
		'工事件名
		'
		Me.工事件名.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
		Me.工事件名.Location = New System.Drawing.Point(12, 64)
		Me.工事件名.Name = "工事件名"
		Me.工事件名.Size = New System.Drawing.Size(93, 25)
		Me.工事件名.TabIndex = 3
		Me.工事件名.Text = "工事件名:"
		'
		'杭工法
		'
		Me.杭工法.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
		Me.杭工法.Location = New System.Drawing.Point(33, 114)
		Me.杭工法.Name = "杭工法"
		Me.杭工法.Size = New System.Drawing.Size(78, 31)
		Me.杭工法.TabIndex = 4
		Me.杭工法.Text = "杭工法:"
		'
		'コメント
		'
		Me.コメント.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
		Me.コメント.Location = New System.Drawing.Point(39, 229)
		Me.コメント.Name = "コメント"
		Me.コメント.Size = New System.Drawing.Size(72, 31)
		Me.コメント.TabIndex = 5
		Me.コメント.Text = "コメント:"
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(135, 168)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(154, 16)
		Me.RadioButton1.TabIndex = 6
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "場所打ち確定杭＜3.2倍＞"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'決定
		'
		Me.決定.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
		Me.決定.Location = New System.Drawing.Point(241, 302)
		Me.決定.Name = "決定"
		Me.決定.Size = New System.Drawing.Size(116, 39)
		Me.決定.TabIndex = 7
		Me.決定.Text = "決定"
		Me.決定.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(386, 168)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(164, 16)
		Me.RadioButton2.TabIndex = 8
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "場所打ち確定杭＜EAGLE＞"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(135, 190)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(114, 16)
		Me.RadioButton3.TabIndex = 9
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "TB 杭＜EAGLE＞"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Location = New System.Drawing.Point(386, 190)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(59, 16)
		Me.RadioButton4.TabIndex = 10
		Me.RadioButton4.TabStop = True
		Me.RadioButton4.Text = "回転杭"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'全クリア
		'
		Me.全クリア.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
		Me.全クリア.Location = New System.Drawing.Point(373, 302)
		Me.全クリア.Name = "全クリア"
		Me.全クリア.Size = New System.Drawing.Size(116, 39)
		Me.全クリア.TabIndex = 11
		Me.全クリア.Text = "全クリア"
		Me.全クリア.UseVisualStyleBackColor = True
		'
		'新規追加
		'
		Me.新規追加.Font = New System.Drawing.Font("MS UI Gothic", 25.0!)
		Me.新規追加.Location = New System.Drawing.Point(279, 5)
		Me.新規追加.Name = "新規追加"
		Me.新規追加.Size = New System.Drawing.Size(159, 39)
		Me.新規追加.TabIndex = 12
		Me.新規追加.Text = "新規追加"
		'
		'Register
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(684, 362)
		Me.Controls.Add(Me.新規追加)
		Me.Controls.Add(Me.全クリア)
		Me.Controls.Add(Me.RadioButton4)
		Me.Controls.Add(Me.RadioButton3)
		Me.Controls.Add(Me.RadioButton2)
		Me.Controls.Add(Me.決定)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.コメント)
		Me.Controls.Add(Me.杭工法)
		Me.Controls.Add(Me.工事件名)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "Register"
		Me.Text = "Register"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents 工事件名 As Label
	Friend WithEvents 杭工法 As Label
	Friend WithEvents コメント As Label
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents 決定 As Button
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents 全クリア As Button
	Friend WithEvents 新規追加 As Label
End Class
