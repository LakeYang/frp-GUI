<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SvrMgr
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
        Me.ServerList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.ReBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ServerList
        '
        Me.ServerList.FormattingEnabled = True
        Me.ServerList.ItemHeight = 12
        Me.ServerList.Location = New System.Drawing.Point(14, 102)
        Me.ServerList.Name = "ServerList"
        Me.ServerList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ServerList.Size = New System.Drawing.Size(134, 124)
        Me.ServerList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.MaximumSize = New System.Drawing.Size(200, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select one or multiple servers to perform actions. Use ctrl or shift to select mu" &
    "ltiple servers"
        '
        'DelBtn
        '
        Me.DelBtn.Location = New System.Drawing.Point(154, 102)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(75, 23)
        Me.DelBtn.TabIndex = 2
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'ReBtn
        '
        Me.ReBtn.Location = New System.Drawing.Point(154, 131)
        Me.ReBtn.Name = "ReBtn"
        Me.ReBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReBtn.TabIndex = 3
        Me.ReBtn.Text = "Rename"
        Me.ReBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.MaximumSize = New System.Drawing.Size(200, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "If you want to create a new server, go to main page and save one."
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(155, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "OK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SvrMgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 238)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ServerList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SvrMgr"
        Me.Text = "Server Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ServerList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DelBtn As Button
    Friend WithEvents ReBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
End Class
