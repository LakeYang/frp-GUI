<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServerAddr = New System.Windows.Forms.TextBox()
        Me.ServerPort = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportConfigToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BootSetMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrpOnGithubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutFrpGUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ServerToken = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServerMode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CliSave = New System.Windows.Forms.Button()
        Me.CliIsSub = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CliRemPort = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CliAdvSet = New System.Windows.Forms.Button()
        Me.CliPort = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CliIP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CliDom = New System.Windows.Forms.TextBox()
        Me.DomType = New System.Windows.Forms.Label()
        Me.CliProto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CliConfig = New System.Windows.Forms.ComboBox()
        Me.CliConfHint = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.Switch = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Address"
        '
        'ServerAddr
        '
        Me.ServerAddr.Location = New System.Drawing.Point(74, 14)
        Me.ServerAddr.Name = "ServerAddr"
        Me.ServerAddr.Size = New System.Drawing.Size(100, 21)
        Me.ServerAddr.TabIndex = 1
        '
        'ServerPort
        '
        Me.ServerPort.Location = New System.Drawing.Point(215, 14)
        Me.ServerPort.MaxLength = 5
        Me.ServerPort.Name = "ServerPort"
        Me.ServerPort.Size = New System.Drawing.Size(43, 21)
        Me.ServerPort.TabIndex = 3
        Me.ServerPort.Text = "7000"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(516, 25)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerToolStripMenuItem, Me.ClientConfigToolStripMenuItem, Me.ClientManagerToolStripMenuItem, Me.ToolStripSeparator2, Me.ExportConfigToolStripMenuItem, Me.ExportConfigToolStripMenuItem1})
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ServerToolStripMenuItem.Text = "Apply Server"
        '
        'ClientConfigToolStripMenuItem
        '
        Me.ClientConfigToolStripMenuItem.Name = "ClientConfigToolStripMenuItem"
        Me.ClientConfigToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ClientConfigToolStripMenuItem.Text = "Server Manager"
        '
        'ClientManagerToolStripMenuItem
        '
        Me.ClientManagerToolStripMenuItem.Name = "ClientManagerToolStripMenuItem"
        Me.ClientManagerToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ClientManagerToolStripMenuItem.Text = "Client Manager"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'ExportConfigToolStripMenuItem
        '
        Me.ExportConfigToolStripMenuItem.Name = "ExportConfigToolStripMenuItem"
        Me.ExportConfigToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ExportConfigToolStripMenuItem.Text = "Import config"
        '
        'ExportConfigToolStripMenuItem1
        '
        Me.ExportConfigToolStripMenuItem1.Name = "ExportConfigToolStripMenuItem1"
        Me.ExportConfigToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ExportConfigToolStripMenuItem1.Text = "Export config"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BootSetMenu})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BootSetMenu
        '
        Me.BootSetMenu.Name = "BootSetMenu"
        Me.BootSetMenu.Size = New System.Drawing.Size(211, 22)
        Me.BootSetMenu.Text = "Start on system startup"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrpOnGithubToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutFrpGUIToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FrpOnGithubToolStripMenuItem
        '
        Me.FrpOnGithubToolStripMenuItem.Name = "FrpOnGithubToolStripMenuItem"
        Me.FrpOnGithubToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.FrpOnGithubToolStripMenuItem.Text = "frp on Github"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'AboutFrpGUIToolStripMenuItem
        '
        Me.AboutFrpGUIToolStripMenuItem.Name = "AboutFrpGUIToolStripMenuItem"
        Me.AboutFrpGUIToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AboutFrpGUIToolStripMenuItem.Text = "About frp GUI"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(40, 21)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "frp GUI 1.0"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SToolStripMenuItem, Me.SToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 48)
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SToolStripMenuItem.Text = "Open GUI"
        '
        'SToolStripMenuItem1
        '
        Me.SToolStripMenuItem1.Name = "SToolStripMenuItem1"
        Me.SToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.SToolStripMenuItem1.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ServerToken)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ServerMode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ServerAddr)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ServerPort)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 90)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(230, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ServerToken
        '
        Me.ServerToken.Location = New System.Drawing.Point(122, 61)
        Me.ServerToken.Name = "ServerToken"
        Me.ServerToken.Size = New System.Drawing.Size(100, 21)
        Me.ServerToken.TabIndex = 9
        Me.ServerToken.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Privilege_token"
        '
        'ServerMode
        '
        Me.ServerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ServerMode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ServerMode.FormattingEnabled = True
        Me.ServerMode.Items.AddRange(New Object() {"Privilege", "Normal"})
        Me.ServerMode.Location = New System.Drawing.Point(74, 38)
        Me.ServerMode.Name = "ServerMode"
        Me.ServerMode.Size = New System.Drawing.Size(87, 20)
        Me.ServerMode.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Port"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CliSave)
        Me.GroupBox2.Controls.Add(Me.CliIsSub)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.CliRemPort)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CliAdvSet)
        Me.GroupBox2.Controls.Add(Me.CliPort)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.CliIP)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CliDom)
        Me.GroupBox2.Controls.Add(Me.DomType)
        Me.GroupBox2.Controls.Add(Me.CliProto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CliConfig)
        Me.GroupBox2.Controls.Add(Me.CliConfHint)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 131)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client"
        '
        'CliSave
        '
        Me.CliSave.BackgroundImage = CType(resources.GetObject("CliSave.BackgroundImage"), System.Drawing.Image)
        Me.CliSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.CliSave.Location = New System.Drawing.Point(144, 96)
        Me.CliSave.Name = "CliSave"
        Me.CliSave.Size = New System.Drawing.Size(30, 30)
        Me.CliSave.TabIndex = 14
        Me.CliSave.UseVisualStyleBackColor = True
        '
        'CliIsSub
        '
        Me.CliIsSub.AutoSize = True
        Me.CliIsSub.Location = New System.Drawing.Point(249, 52)
        Me.CliIsSub.Name = "CliIsSub"
        Me.CliIsSub.Size = New System.Drawing.Size(15, 14)
        Me.CliIsSub.TabIndex = 9
        Me.CliIsSub.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(195, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Multiple"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CliRemPort
        '
        Me.CliRemPort.Location = New System.Drawing.Point(85, 97)
        Me.CliRemPort.MaxLength = 5
        Me.CliRemPort.Name = "CliRemPort"
        Me.CliRemPort.Size = New System.Drawing.Size(43, 21)
        Me.CliRemPort.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 12)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Remote Port"
        '
        'CliAdvSet
        '
        Me.CliAdvSet.Location = New System.Drawing.Point(182, 100)
        Me.CliAdvSet.Name = "CliAdvSet"
        Me.CliAdvSet.Size = New System.Drawing.Size(75, 23)
        Me.CliAdvSet.TabIndex = 10
        Me.CliAdvSet.Text = "Advanced"
        Me.CliAdvSet.UseVisualStyleBackColor = True
        '
        'CliPort
        '
        Me.CliPort.Location = New System.Drawing.Point(215, 73)
        Me.CliPort.MaxLength = 5
        Me.CliPort.Name = "CliPort"
        Me.CliPort.Size = New System.Drawing.Size(43, 21)
        Me.CliPort.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(180, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Port"
        '
        'CliIP
        '
        Me.CliIP.Location = New System.Drawing.Point(60, 73)
        Me.CliIP.Name = "CliIP"
        Me.CliIP.Size = New System.Drawing.Size(101, 21)
        Me.CliIP.TabIndex = 7
        Me.CliIP.Text = "127.0.0.1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Local_ip"
        '
        'CliDom
        '
        Me.CliDom.Location = New System.Drawing.Point(166, 49)
        Me.CliDom.Name = "CliDom"
        Me.CliDom.Size = New System.Drawing.Size(77, 21)
        Me.CliDom.TabIndex = 5
        '
        'DomType
        '
        Me.DomType.AutoSize = True
        Me.DomType.Location = New System.Drawing.Point(106, 52)
        Me.DomType.Name = "DomType"
        Me.DomType.Size = New System.Drawing.Size(59, 12)
        Me.DomType.TabIndex = 4
        Me.DomType.Text = "Subdomain"
        Me.DomType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CliProto
        '
        Me.CliProto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CliProto.FormattingEnabled = True
        Me.CliProto.Items.AddRange(New Object() {"TCP", "UDP", "HTTP", "HTTPS"})
        Me.CliProto.Location = New System.Drawing.Point(41, 50)
        Me.CliProto.Name = "CliProto"
        Me.CliProto.Size = New System.Drawing.Size(59, 20)
        Me.CliProto.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Proto"
        '
        'CliConfig
        '
        Me.CliConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CliConfig.FormattingEnabled = True
        Me.CliConfig.Location = New System.Drawing.Point(74, 14)
        Me.CliConfig.Name = "CliConfig"
        Me.CliConfig.Size = New System.Drawing.Size(107, 20)
        Me.CliConfig.TabIndex = 1
        '
        'CliConfHint
        '
        Me.CliConfHint.AutoSize = True
        Me.CliConfHint.Location = New System.Drawing.Point(21, 17)
        Me.CliConfHint.Name = "CliConfHint"
        Me.CliConfHint.Size = New System.Drawing.Size(41, 12)
        Me.CliConfHint.TabIndex = 0
        Me.CliConfHint.Text = "Config"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutputTextBox.Location = New System.Drawing.Point(300, 35)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputTextBox.Size = New System.Drawing.Size(197, 183)
        Me.OutputTextBox.TabIndex = 7
        '
        'Switch
        '
        Me.Switch.Location = New System.Drawing.Point(422, 224)
        Me.Switch.Name = "Switch"
        Me.Switch.Size = New System.Drawing.Size(75, 23)
        Me.Switch.TabIndex = 8
        Me.Switch.Text = "Start"
        Me.Switch.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 273)
        Me.Controls.Add(Me.Switch)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "frp GUI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ServerAddr As TextBox
    Friend WithEvents ServerPort As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BootSetMenu As ToolStripMenuItem
    Friend WithEvents ExportConfigToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FrpOnGithubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutFrpGUIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ServerMode As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ServerToken As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CliConfHint As Label
    Friend WithEvents DomType As Label
    Friend WithEvents CliProto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CliConfig As ComboBox
    Friend WithEvents CliAdvSet As Button
    Friend WithEvents CliPort As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CliIP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CliDom As TextBox
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents Switch As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CliRemPort As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ClientManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CliIsSub As CheckBox
    Friend WithEvents CliSave As Button
End Class
