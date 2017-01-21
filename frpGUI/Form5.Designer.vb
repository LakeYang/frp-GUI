<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiSetting
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
        Me.OutConfig = New System.Windows.Forms.ListBox()
        Me.InConfig = New System.Windows.Forms.ListBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.RemBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.MaximumSize = New System.Drawing.Size(330, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "If you want to apply multiple client configurations in one frpc instance, choose " &
    "them below."
        '
        'OutConfig
        '
        Me.OutConfig.FormattingEnabled = True
        Me.OutConfig.ItemHeight = 12
        Me.OutConfig.Location = New System.Drawing.Point(15, 98)
        Me.OutConfig.Name = "OutConfig"
        Me.OutConfig.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.OutConfig.Size = New System.Drawing.Size(120, 124)
        Me.OutConfig.TabIndex = 1
        '
        'InConfig
        '
        Me.InConfig.FormattingEnabled = True
        Me.InConfig.ItemHeight = 12
        Me.InConfig.Location = New System.Drawing.Point(223, 98)
        Me.InConfig.Name = "InConfig"
        Me.InConfig.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.InConfig.Size = New System.Drawing.Size(120, 124)
        Me.InConfig.TabIndex = 2
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(142, 98)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 3
        Me.AddBtn.Text = "Add>"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'RemBtn
        '
        Me.RemBtn.Location = New System.Drawing.Point(142, 127)
        Me.RemBtn.Name = "RemBtn"
        Me.RemBtn.Size = New System.Drawing.Size(75, 23)
        Me.RemBtn.TabIndex = 4
        Me.RemBtn.Text = "<Remove"
        Me.RemBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(142, 199)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearBtn.TabIndex = 5
        Me.ClearBtn.Text = "<<Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.MaximumSize = New System.Drawing.Size(330, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(329, 36)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "If you have added any configuration in the right list, client config settings in " &
    "main page is disabled until all items in the right list is removed."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MultiSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 272)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.RemBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.InConfig)
        Me.Controls.Add(Me.OutConfig)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MultiSetting"
        Me.Text = "Multiple Client Config Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OutConfig As ListBox
    Friend WithEvents InConfig As ListBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents RemBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
