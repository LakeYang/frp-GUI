Imports System
Imports System.IO
Imports System.Text
Imports System.Reflection
Imports System.Xml

Public Class Main
    Dim frpon As Boolean
    Dim manuexit As Boolean
    Public path As String = Application.StartupPath()
    Public config As New Xml.XmlDocument
    Dim silenceMode As Boolean = False

    Sub terminate()
        If frpon Then
            MyProcess.CancelOutputRead()
            MyProcess.CancelErrorRead()
            MyProcess.Kill()
            MyProcess.Close()
        End If
        Application.Exit()
    End Sub

    Sub ReloadGUI()
        ServerToolStripMenuItem.DropDownItems.Clear()
        For Each node In config.DocumentElement.SelectNodes("/FRPGUI/server/config")
            ServerToolStripMenuItem.DropDownItems.Add(node.SelectSingleNode("name").InnerText, Nothing, AddressOf ToolStripMenuItem_Click)
        Next
        If ServerToolStripMenuItem.DropDownItems.Count = 0 Then
            ServerToolStripMenuItem.DropDownItems.Add("No server profile")
            ServerToolStripMenuItem.DropDownItems(0).Enabled = False
        End If
        CliConfig.Items.Clear()
        For Each node In config.DocumentElement.SelectNodes("/FRPGUI/client/config")
            CliConfig.Items.Add(node.SelectSingleNode("name").InnerText)
            If node.SelectSingleNode("inlist").InnerText = "1" Then
                CliConfig.Visible = False
                CliProto.Enabled = False
                CliDom.Enabled = False
                CliIsSub.Enabled = False
                CliIP.Enabled = False
                CliPort.Enabled = False
                CliRemPort.Enabled = False
                CliSave.Enabled = False
                CliAdvSet.Enabled = False
                CliConfHint.Text = "Multiple mode enabled." & vbCrLf & "Config Disabled."
                Exit Sub
            End If
        Next
        CliConfHint.Text = "Config"
        CliConfig.Visible = True
        CliProto.Enabled = True
        CliDom.Enabled = True
        CliIsSub.Enabled = True
        CliIP.Enabled = True
        CliPort.Enabled = True
        CliRemPort.Enabled = True
        CliSave.Enabled = True
        CliAdvSet.Enabled = True
        Dim cnode = config.DocumentElement.SelectSingleNode("/FRPGUI/default/server")
        ServerAddr.Text = cnode.SelectSingleNode("address").InnerText
        ServerPort.Text = cnode.SelectSingleNode("port").InnerText
        cnode = config.DocumentElement.SelectSingleNode("/FRPGUI/default/client")
        CliConfig.Text = cnode.SelectSingleNode("name").InnerText
        CliPort.Text = cnode.SelectSingleNode("port").InnerText
        CliDom.Text = cnode.SelectSingleNode("domain").InnerText
        If cnode.SelectSingleNode("issub").InnerText = "1" Then
            CliIsSub.Checked = True
        Else
            CliIsSub.Checked = False
        End If
        CliIP.Text = cnode.SelectSingleNode("ip").InnerText
        CliRemPort.Text = cnode.SelectSingleNode("rport").InnerText
    End Sub

    Private WithEvents MyProcess As Process

    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loading code
        AppendOutputText("Initiating frp GUI")
        frpon = 0
        manuexit = 0
        If My.Computer.FileSystem.FileExists(path & "/frpc.exe") Then
            AppendOutputText("frpc.exe found")
        Else
            AppendOutputText("frpc.exe not found.")
            AppendOutputText("Extracting frpc.exe")
            My.Computer.FileSystem.WriteAllBytes(path & "/frpc.exe", My.Resources.Resource1.frpc, False)
            AppendOutputText("Done extraction")
        End If
        If My.Computer.FileSystem.FileExists(path & "/config.xml") Then
            AppendOutputText("config found")
            Try
                config.Load(path & "/config.xml")
            Catch ex As Exception
                MessageBox.Show("Cannot parse config.xml. Modify or delete it to fix this issue.", "Error")
                End
            End Try
            AppendOutputText("config loaded")
        Else
            AppendOutputText("config file not found.")
            AppendOutputText("Creating config.xml")
            My.Computer.FileSystem.WriteAllText(path & "/config.xml", My.Resources.Resource1.config, False)
            config.Load(path & "/config.xml")
            AppendOutputText("config loaded")
        End If
        ReloadGUI()

        If config.DocumentElement.SelectSingleNode("/FRPGUI/startup").InnerText = "1" Then
            BootSetMenu.Checked = True
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath & " -s")

        End If
    End Sub
    Private Sub ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim menuItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If menuItem IsNot Nothing Then
            'item just clicked. 
            For Each node In config.DocumentElement.SelectNodes("/FRPGUI/server/config")
                If node.SelectSingleNode("name").InnerText = menuItem.Text Then
                    ServerAddr.Text = node.SelectSingleNode("address").InnerText
                    ServerPort.Text = node.SelectSingleNode("port").InnerText
                End If
            Next

        End If
    End Sub

    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived
        If Not manuexit Then
            AppendOutputText("frpc throwned an error " & e.Data)
            manuexit = 0
        End If

    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived
        AppendOutputText(e.Data)
        If MyProcess.HasExited And frpon Then
            AppendOutputText("frpc process has ended")
            frpon = 0
            Switch.Text = "Start"
        End If
    End Sub

    Private Sub AppendOutputText(ByVal text As String)
        If OutputTextBox.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            If text <> "" Or text <> " " Or text <> vbCrLf Then
                OutputTextBox.AppendText(DateTime.Now.ToString("[HH:mm:ss]") & text & vbCrLf)
            End If
        End If
        If silenceMode Then
            Me.Hide()
        End If
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        Me.Hide()
        NotifyIcon1.BalloonTipTitle = "Notice"
        NotifyIcon1.BalloonTipText = "frp GUI is running in the background"
        NotifyIcon1.ShowBalloonTip(2)
        e.Cancel = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ExportConfigToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.Opacity = 100%
        silenceMode = False
        Me.Activate()
    End Sub

    Private Sub SToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem1.Click
        terminate()
    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        Me.Show()
        Me.Opacity = 100%
        silenceMode = False
        Me.Activate()
    End Sub

    Private Sub FrpOnGithubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrpOnGithubToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/fatedier/frp")
    End Sub

    Private Sub AboutFrpGUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutFrpGUIToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim response = MsgBox("Are you sure want to eixt?", MsgBoxStyle.YesNo, "frp GUI")
        If response = MsgBoxResult.Yes Then
            terminate()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles CliConfHint.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CliAdvSet.Click
        AdvSetting.ShowDialog()
    End Sub

    Private Sub Switch_Click(sender As Object, e As EventArgs) Handles Switch.Click
        If frpon Then
            MyProcess.Kill()
            frpon = 0
            manuexit = 1
            Switch.Text = "Start"
            AppendOutputText("frpc process stopped")
        Else
            If Not silenceMode Then
                If CliRemPort.Text = "" And (CliProto.Text = "TCP" Or CliProto.Text = "UDP") Then
                    MessageBox.Show("Remote port cannot be empty in UDP and TCP.", "Error")
                    Exit Sub
                End If
                AppendOutputText("Updating config.xml")
                Dim cnode = config.DocumentElement.SelectSingleNode("/FRPGUI/default/server")
                cnode.SelectSingleNode("address").InnerText = ServerAddr.Text
                cnode.SelectSingleNode("port").InnerText = ServerPort.Text
                cnode = config.DocumentElement.SelectSingleNode("/FRPGUI/default/client")
                cnode.SelectSingleNode("name").InnerText = CliConfig.Text
                cnode.SelectSingleNode("proto").InnerText = CliProto.Text
                cnode.SelectSingleNode("port").InnerText = CliPort.Text
                cnode.SelectSingleNode("domain").InnerText = CliDom.Text
                If CliIsSub.Checked Then
                    cnode.SelectSingleNode("issub").InnerText = 1
                Else
                    cnode.SelectSingleNode("issub").InnerText = 0
                End If
                cnode.SelectSingleNode("ip").InnerText = CliIP.Text
                cnode.SelectSingleNode("rport").InnerText = CliRemPort.Text
                config.Save(path & "/config.xml")
                AppendOutputText("Generating frpc config file")
                Try
                    My.Computer.FileSystem.DeleteFile(path & "/frpc.ini")
                Catch ex As Exception
                End Try


                Using outputFile As New StreamWriter(path & "/frpc.ini")
                    outputFile.WriteLine("# frpc.ini generated by frp GUI")
                    outputFile.WriteLine("[common]")
                    outputFile.WriteLine("server_addr = " & ServerAddr.Text)
                    outputFile.WriteLine("server_port = " & ServerPort.Text)
                    If CliConfHint.Text = "Config" Then
                        outputFile.WriteLine("")
                        outputFile.WriteLine("[service]")
                        outputFile.WriteLine("type = " & CliProto.Text.ToLower())
                        If CliDom.Text <> "" Then
                            If CliIsSub.Checked Then
                                outputFile.WriteLine("subdomain = " & CliDom.Text)
                            Else
                                outputFile.WriteLine("custom_domains = " & CliDom.Text)
                            End If
                        End If
                        outputFile.WriteLine("local_port = " & CliPort.Text)
                        outputFile.WriteLine("local_ip = " & CliIP.Text)
                        If CliProto.Text <> "HTTP" And CliProto.Text <> "HTTPS" Then
                            outputFile.WriteLine("remote_port = " & CliRemPort.Text)
                        End If
                        If cnode.SelectSingleNode("encrypt").InnerText = "1" Then
                            outputFile.WriteLine("use_encryption = true")
                        End If
                        If cnode.SelectSingleNode("gzip").InnerText = "1" Then
                            outputFile.WriteLine("use_gzip = true")
                        End If
                        If CliProto.Text = "HTTP" Then
                            If cnode.SelectSingleNode("passpro").InnerText = "1" Then
                                outputFile.WriteLine("http_user = " & cnode.SelectSingleNode("username").InnerText)
                                outputFile.WriteLine("http_pwd = " & cnode.SelectSingleNode("passwd").InnerText)
                            End If
                            If cnode.SelectSingleNode("rewrite").InnerText = "1" Then
                                outputFile.WriteLine("host_header_rewrite = " & cnode.SelectSingleNode("host").InnerText)
                            End If
                            If cnode.SelectSingleNode("urlroute").InnerText <> "" Then
                                outputFile.WriteLine("locations = " & cnode.SelectSingleNode("urlroute").InnerText)
                            End If
                            If cnode.SelectSingleNode("proxy").InnerText = "1" Then
                                outputFile.WriteLine("http_proxy = " & cnode.SelectSingleNode("proxyaddr").InnerText)
                            End If
                        End If
                    Else
                        AppendOutputText("Multiple mode enabled")
                        Dim servicecount = 0
                        For Each node In config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                            If node.SelectSingleNode("inlist").InnerText = "1" Then
                                servicecount += 1
                                outputFile.WriteLine("")
                                outputFile.WriteLine("[service" & servicecount & "]")
                                outputFile.WriteLine("type = " & node.SelectSingleNode("proto").InnerText.ToLower())
                                If CliDom.Text <> "" Then
                                    If CliIsSub.Checked Then
                                        outputFile.WriteLine("subdomain = " & node.SelectSingleNode("domain").InnerText)
                                    Else
                                        outputFile.WriteLine("custom_domains = " & node.SelectSingleNode("domain").InnerText)
                                    End If
                                End If
                                outputFile.WriteLine("local_port = " & node.SelectSingleNode("port").InnerText)
                                outputFile.WriteLine("local_ip = " & node.SelectSingleNode("ip").InnerText)
                                outputFile.WriteLine("remote_port = " & node.SelectSingleNode("rport").InnerText)
                                If node.SelectSingleNode("encrypt").InnerText = "1" Then
                                    outputFile.WriteLine("use_encryption = true")
                                End If
                                If node.SelectSingleNode("gzip").InnerText = "1" Then
                                    outputFile.WriteLine("use_gzip = true")
                                End If
                                If CliProto.Text = "HTTP" Then
                                    If node.SelectSingleNode("passpro").InnerText = "1" Then
                                        outputFile.WriteLine("http_user = " & node.SelectSingleNode("username").InnerText)
                                        outputFile.WriteLine("http_pwd = " & node.SelectSingleNode("passwd").InnerText)
                                    End If
                                    If node.SelectSingleNode("rewrite").InnerText = "1" Then
                                        outputFile.WriteLine("host_header_rewrite = " & cnode.SelectSingleNode("host").InnerText)
                                    End If
                                    If node.SelectSingleNode("urlroute").InnerText <> "" Then
                                        outputFile.WriteLine("locations = " & node.SelectSingleNode("urlroute").InnerText)
                                    End If
                                    If node.SelectSingleNode("proxy").InnerText = "1" Then
                                        outputFile.WriteLine("http_proxy = " & node.SelectSingleNode("proxyaddr").InnerText)
                                    End If
                                End If
                            End If
                        Next
                    End If
                End Using
            End If
            AppendOutputText("Starting frps service")
            MyProcess = New Process
            With MyProcess.StartInfo
                .FileName = "frpc.exe"
                .Arguments = "-c """ & path & "\frpc.ini"""
                .UseShellExecute = False
                .CreateNoWindow = True
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
                .RedirectStandardError = True
            End With
            Control.CheckForIllegalCrossThreadCalls = False
            MyProcess.Start()
            frpon = 1
            Switch.Text = "Stop"
            MyProcess.BeginErrorReadLine()
            MyProcess.BeginOutputReadLine()
            AppendOutputText("frpc process started")
        End If
    End Sub

    Private Sub BootSetMenu_Click(sender As Object, e As EventArgs) Handles BootSetMenu.Click
        If BootSetMenu.Checked Then
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            BootSetMenu.Checked = False
            config.DocumentElement.SelectSingleNode("/FRPGUI/startup").InnerText = 0
            AppendOutputText("Registry key was deleted")
        Else
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath & " -s")
            BootSetMenu.Checked = True
            config.DocumentElement.SelectSingleNode("/FRPGUI/startup").InnerText = 1
            AppendOutputText("frp GUI starts when current user login. The configuration last used will be the configuration that frp GUI uses at next startup")
        End If
        config.Save(path & "/config.xml")
    End Sub

    Private Sub OutputTextBox_TextChanged(sender As Object, e As EventArgs) Handles OutputTextBox.TextChanged

    End Sub

    Private Sub ClientConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientConfigToolStripMenuItem.Click
        SvrMgr.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim servername = InputBox("Pick a name for this server:", "Save server config")

        If servername <> "" Then
            For Each node In config.DocumentElement.SelectNodes("/FRPGUI/server/config")
                If node.SelectSingleNode("name").InnerText = servername Then
                    Dim response = MsgBox("Profile [" & servername & "] already exists. Overwrite?", MsgBoxStyle.YesNo, "frp GUI")
                    If response = MsgBoxResult.Yes Then
                        node.SelectSingleNode("name").InnerText = servername
                        node.SelectSingleNode("address").InnerText = ServerAddr.Text
                        node.SelectSingleNode("port").InnerText = ServerPort.Text
                        config.Save(path & "/config.xml")
                        ReloadGUI()
                        MessageBox.Show("Server profile [" & servername & "] updated.", "Success")
                    Else
                        AppendOutputText("Profile overwrition cancelled")
                        Exit Sub
                    End If
                End If
            Next
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").AppendChild(config.CreateElement("config"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").LastChild.AppendChild(config.CreateElement("name"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").LastChild.AppendChild(config.CreateElement("address"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").LastChild.AppendChild(config.CreateElement("port"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").LastChild.AppendChild(config.CreateElement("mode"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").LastChild.AppendChild(config.CreateElement("token"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").LastChild.SelectSingleNode("name").InnerText = servername
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").LastChild.SelectSingleNode("address").InnerText = ServerAddr.Text
            config.DocumentElement.SelectSingleNode("/FRPGUI/server").LastChild.SelectSingleNode("port").InnerText = ServerPort.Text
            config.Save(path & "/config.xml")
            ReloadGUI()
            MessageBox.Show("Server profile [" & servername & "] added.", "Success")

        End If
    End Sub

    Private Sub CliConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CliConfig.SelectedIndexChanged
        For Each node In config.DocumentElement.SelectNodes("/FRPGUI/client/config")
            If node.SelectSingleNode("name").InnerText = CliConfig.Text Then
                CliProto.Text = node.SelectSingleNode("proto").InnerText
                CliPort.Text = node.SelectSingleNode("port").InnerText
                CliDom.Text = node.SelectSingleNode("domain").InnerText
                CliIP.Text = node.SelectSingleNode("ip").InnerText
                CliRemPort.Text = node.SelectSingleNode("rport").InnerText
                If node.SelectSingleNode("issub").InnerText = "1" Then
                    CliIsSub.Checked = True
                    DomType.Text = "Subdomain"
                Else
                    CliIsSub.Checked = False
                    DomType.Text = "Domain"
                End If
                Dim cnode = config.DocumentElement.SelectSingleNode("/FRPGUI/default/client")
                cnode.SelectSingleNode("encrypt").InnerText = node.SelectSingleNode("encrypt").InnerText
                cnode.SelectSingleNode("gzip").InnerText = node.SelectSingleNode("gzip").InnerText
                cnode.SelectSingleNode("passpro").InnerText = node.SelectSingleNode("passpro").InnerText
                cnode.SelectSingleNode("username").InnerText = node.SelectSingleNode("username").InnerText
                cnode.SelectSingleNode("passwd").InnerText = node.SelectSingleNode("passwd").InnerText
                cnode.SelectSingleNode("rewrite").InnerText = node.SelectSingleNode("rewrite").InnerText
                cnode.SelectSingleNode("host").InnerText = node.SelectSingleNode("host").InnerText
                cnode.SelectSingleNode("urlroute").InnerText = node.SelectSingleNode("urlroute").InnerText
                cnode.SelectSingleNode("proxy").InnerText = node.SelectSingleNode("proxy").InnerText
                cnode.SelectSingleNode("proxyaddr").InnerText = node.SelectSingleNode("proxyaddr").InnerText
                Exit For
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CliIsSub.CheckedChanged
        If DomType.Text = "Subdomain" Then
            DomType.Text = "Domain"
        Else
            DomType.Text = "Subdomain"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CliSave.Click
        Dim clintname = InputBox("Pick a name for this client config:", "Save client config", CliConfig.Text)

        If clintname <> "" Then
            For Each node In config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                If node.SelectSingleNode("name").InnerText = clintname Then
                    Dim response = MsgBox("Profile [" & clintname & "] already exists. Overwrite?", MsgBoxStyle.YesNo, "frp GUI")
                    If response = MsgBoxResult.Yes Then
                        node.SelectSingleNode("name").InnerText = clintname
                        node.SelectSingleNode("proto").InnerText = CliProto.Text
                        node.SelectSingleNode("port").InnerText = CliPort.Text
                        node.SelectSingleNode("domain").InnerText = CliDom.Text
                        If CliIsSub.Checked Then
                            node.SelectSingleNode("issub").InnerText = 1
                        Else
                            node.SelectSingleNode("issub").InnerText = 0
                        End If
                        node.SelectSingleNode("ip").InnerText = CliIP.Text
                        node.SelectSingleNode("rport").InnerText = CliRemPort.Text
                        config.Save(path & "/config.xml")
                        AppendOutputText("Client profile [" & clintname & "] updated")
                        Exit Sub
                    Else
                        AppendOutputText("Profile overwrition cancelled")
                        Exit Sub
                    End If
                End If
            Next
            'Creating new
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").AppendChild(config.CreateElement("config"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("name"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("proto"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("port"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("domain"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("issub"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("ip"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("rport"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("inlist"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("encrypt"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("gzip"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("passpro"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("username"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("passwd"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("rewrite"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("host"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("urlroute"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("proxy"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.AppendChild(config.CreateElement("proxyaddr"))
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("name").InnerText = clintname
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("proto").InnerText = CliProto.Text
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("port").InnerText = CliPort.Text
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("domain").InnerText = CliDom.Text
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("inlist").InnerText = 0
            If CliIsSub.Checked Then
                config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("issub").InnerText = 1
            Else
                config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("issub").InnerText = 0
            End If
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("ip").InnerText = CliIP.Text
            config.DocumentElement.SelectSingleNode("/FRPGUI/client").LastChild.SelectSingleNode("rport").InnerText = CliRemPort.Text
            config.Save(path & "/config.xml")
            CliConfig.Items.Add(clintname)
            AppendOutputText("Client profile [" & clintname & "] saved")
        Else
            AppendOutputText("Profile creation cancelled")
        End If
    End Sub

    Private Sub ClientManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientManagerToolStripMenuItem.Click
        CliMgr.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MultiSetting.ShowDialog()
    End Sub

    Private Sub CliProto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CliProto.SelectedIndexChanged
        If CliProto.Text = "HTTP" Or CliProto.Text = "HTTPS" Then
            CliRemPort.Enabled = False
        Else
            CliRemPort.Enabled = True
        End If
    End Sub

    Private Sub OpenFrpciniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFrpciniToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start(path & "/frpc.ini")
        Catch ex As Exception
            MsgBox("Unable to open frpc.ini. Maybe it was deleted?")
        End Try
    End Sub
End Class
