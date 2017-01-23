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
    End Sub
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        Main.ReloadGUI()
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
End Class