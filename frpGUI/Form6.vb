Public Class AdvSetting
    Private Sub AdvSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim node = Main.config.DocumentElement.SelectSingleNode("/FRPGUI/default/client")
        If node.SelectSingleNode("encrypt").InnerText = "1" Then
            UseEncrypt.Checked = True
        Else
            UseEncrypt.Checked = False
        End If
        If node.SelectSingleNode("gzip").InnerText = "1" Then
            UseGzip.Checked = True
        Else
            UseGzip.Checked = False
        End If
        If node.SelectSingleNode("passpro").InnerText = "1" Then
            EnaPass.Checked = True
            username.Enabled = True
            password.Enabled = True
        Else
            EnaPass.Checked = False
            username.Enabled = False
            password.Enabled = False
        End If
        username.Text = node.SelectSingleNode("username").InnerText
        password.Text = node.SelectSingleNode("passwd").InnerText
        If node.SelectSingleNode("rewrite").InnerText = "1" Then
            EnaRew.Checked = True
            RewHost.Enabled = True
        Else
            EnaRew.Checked = False
            RewHost.Enabled = False
        End If
        RewHost.Text = node.SelectSingleNode("host").InnerText
        UrlLoc.Text = node.SelectSingleNode("urlroute").InnerText
        If node.SelectSingleNode("proxy").InnerText = "1" Then
            EnaProxy.Checked = True
            HttpProxy.Enabled = True
        Else
            EnaProxy.Checked = False
            HttpProxy.Enabled = False
        End If
        HttpProxy.Text = node.SelectSingleNode("proxyaddr").InnerText
        If Main.CliProto.Text <> "HTTP" Then
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
        Else
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
        End If
    End Sub
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        Main.Activate()
    End Sub
    Private Sub EnaRew_CheckedChanged(sender As Object, e As EventArgs) Handles EnaRew.CheckedChanged
        If EnaRew.Checked Then
            RewHost.Enabled = True
        Else
            RewHost.Enabled = False
        End If
    End Sub

    Private Sub EnaProxy_CheckedChanged(sender As Object, e As EventArgs) Handles EnaProxy.CheckedChanged
        If EnaProxy.Checked Then
            HttpProxy.Enabled = True
        Else
            HttpProxy.Enabled = False
        End If
    End Sub

    Private Sub EnaPass_CheckedChanged(sender As Object, e As EventArgs) Handles EnaPass.CheckedChanged
        If EnaPass.Checked Then
            username.Enabled = True
            password.Enabled = True
        Else
            username.Enabled = False
            password.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UseEncrypt.Checked = False
        UseGzip.Checked = False
        EnaPass.Checked = False
        EnaRew.Checked = False
        UrlLoc.Text = ""
        EnaProxy.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Activate()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim node = Main.config.DocumentElement.SelectSingleNode("/FRPGUI/default/client")
        If UseEncrypt.Checked Then
            node.SelectSingleNode("encrypt").InnerText = 1
        Else
            node.SelectSingleNode("encrypt").InnerText = 0
        End If
        If UseGzip.Checked Then
            node.SelectSingleNode("gzip").InnerText = 1
        Else
            node.SelectSingleNode("gzip").InnerText = 0
        End If
        If EnaPass.Checked Then
            node.SelectSingleNode("passpro").InnerText = 1
        Else
            node.SelectSingleNode("passpro").InnerText = 0
        End If
        node.SelectSingleNode("username").InnerText = username.Text
        node.SelectSingleNode("passwd").InnerText = password.Text
        If EnaRew.Checked Then
            node.SelectSingleNode("rewrite").InnerText = 1
        Else
            node.SelectSingleNode("rewrite").InnerText = 0
        End If
        node.SelectSingleNode("host").InnerText = RewHost.Text
        node.SelectSingleNode("urlroute").InnerText = UrlLoc.Text
        If EnaProxy.Checked Then
            node.SelectSingleNode("proxy").InnerText = 1
        Else
            node.SelectSingleNode("proxy").InnerText = 0
        End If
        node.SelectSingleNode("proxyaddr").InnerText = HttpProxy.Text
        Main.config.Save(Main.path & "/config.xml")
        Main.Activate()
        Me.Close()
    End Sub
End Class