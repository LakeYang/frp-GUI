<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvSetting
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UseEncrypt = New System.Windows.Forms.CheckBox()
        Me.UseGzip = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.EnaPass = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RewHost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EnaRew = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UrlLoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HttpProxy = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EnaProxy = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You are editing advanced settings for client config." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "These settings will also be" &
    " saved to client config."
        '
        'UseEncrypt
        '
        Me.UseEncrypt.AutoSize = True
        Me.UseEncrypt.Location = New System.Drawing.Point(12, 20)
        Me.UseEncrypt.Name = "UseEncrypt"
        Me.UseEncrypt.Size = New System.Drawing.Size(108, 16)
        Me.UseEncrypt.TabIndex = 3
        Me.UseEncrypt.Text = "Use encryption"
        Me.UseEncrypt.UseVisualStyleBackColor = True
        '
        'UseGzip
        '
        Me.UseGzip.AutoSize = True
        Me.UseGzip.Location = New System.Drawing.Point(189, 20)
        Me.UseGzip.Name = "UseGzip"
        Me.UseGzip.Size = New System.Drawing.Size(72, 16)
        Me.UseGzip.TabIndex = 4
        Me.UseGzip.Text = "Use gzip"
        Me.UseGzip.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UseGzip)
        Me.GroupBox1.Controls.Add(Me.UseEncrypt)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 47)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Transfer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.password)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.username)
        Me.GroupBox2.Controls.Add(Me.EnaPass)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 76)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Web Service Protect (Only available in HTTP)"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(212, 42)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(86, 21)
        Me.password.TabIndex = 4
        Me.password.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(69, 42)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(64, 21)
        Me.username.TabIndex = 1
        '
        'EnaPass
        '
        Me.EnaPass.AutoSize = True
        Me.EnaPass.Location = New System.Drawing.Point(12, 20)
        Me.EnaPass.Name = "EnaPass"
        Me.EnaPass.Size = New System.Drawing.Size(180, 16)
        Me.EnaPass.TabIndex = 0
        Me.EnaPass.Text = "Enable Password Protection"
        Me.EnaPass.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RewHost)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.EnaRew)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 52)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Host Header Rewrite"
        '
        'RewHost
        '
        Me.RewHost.Location = New System.Drawing.Point(203, 18)
        Me.RewHost.Name = "RewHost"
        Me.RewHost.Size = New System.Drawing.Size(95, 21)
        Me.RewHost.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Rewrite to"
        '
        'EnaRew
        '
        Me.EnaRew.AutoSize = True
        Me.EnaRew.Location = New System.Drawing.Point(12, 20)
        Me.EnaRew.Name = "EnaRew"
        Me.EnaRew.Size = New System.Drawing.Size(108, 16)
        Me.EnaRew.TabIndex = 0
        Me.EnaRew.Text = "Enable Rewrite"
        Me.EnaRew.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.UrlLoc)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 52)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "URL routing (Only available in HTTP)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 12)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "(Use "","" to seperate)"
        '
        'UrlLoc
        '
        Me.UrlLoc.Location = New System.Drawing.Point(69, 18)
        Me.UrlLoc.Name = "UrlLoc"
        Me.UrlLoc.Size = New System.Drawing.Size(102, 21)
        Me.UrlLoc.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Locations"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.HttpProxy)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.EnaProxy)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 298)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(315, 66)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Connect frps by HTTP PROXY"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(245, 12)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "e.g.  http://user:pwd@192.168.1.128:8080"
        '
        'HttpProxy
        '
        Me.HttpProxy.Location = New System.Drawing.Point(126, 18)
        Me.HttpProxy.Name = "HttpProxy"
        Me.HttpProxy.Size = New System.Drawing.Size(172, 21)
        Me.HttpProxy.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 12)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Proxy"
        '
        'EnaProxy
        '
        Me.EnaProxy.AutoSize = True
        Me.EnaProxy.Location = New System.Drawing.Point(12, 20)
        Me.EnaProxy.Name = "EnaProxy"
        Me.EnaProxy.Size = New System.Drawing.Size(60, 16)
        Me.EnaProxy.TabIndex = 0
        Me.EnaProxy.Text = "Enable"
        Me.EnaProxy.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(249, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 379)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Default"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AdvSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 416)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdvSetting"
        Me.Text = "Advanced"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UseEncrypt As CheckBox
    Friend WithEvents UseGzip As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents EnaPass As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RewHost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EnaRew As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents UrlLoc As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents HttpProxy As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents EnaProxy As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
