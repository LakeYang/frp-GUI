Public Class MultiSetting
    Sub refreshUI()
        InConfig.Items.Clear()
        OutConfig.Items.Clear()
        For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
            If node.SelectSingleNode("inlist").InnerText = "1" Then
                InConfig.Items.Add(node.SelectSingleNode("name").InnerText)
            Else
                OutConfig.Items.Add(node.SelectSingleNode("name").InnerText)
            End If
        Next
        AddBtn.Enabled = False
        RemBtn.Enabled = False
        If InConfig.Items.Count = 0 Then
            ClearBtn.Enabled = False
        Else
            ClearBtn.Enabled = True
        End If
    End Sub
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        Main.config.Save(Main.path & "/config.xml")
        Main.ReloadGUI()
        Main.Activate()
    End Sub
    Private Sub MultiSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshUI()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.config.Save(Main.path & "/config.xml")
        Main.ReloadGUI()
        Main.Activate()
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        For Each item In OutConfig.SelectedItems
            For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                If node.SelectSingleNode("name").innertext = item Then
                    node.SelectSingleNode("inlist").innertext = 1
                    Exit For
                End If
            Next
        Next
        refreshUI()
    End Sub

    Private Sub OutConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutConfig.SelectedIndexChanged
        If OutConfig.SelectedItems.Count <> 0 Then
            AddBtn.Enabled = True
        Else
            AddBtn.Enabled = False
        End If
    End Sub

    Private Sub InConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InConfig.SelectedIndexChanged
        If InConfig.SelectedItems.Count <> 0 Then
            RemBtn.Enabled = True
        Else
            RemBtn.Enabled = False
        End If
    End Sub

    Private Sub RemBtn_Click(sender As Object, e As EventArgs) Handles RemBtn.Click
        For Each item In InConfig.SelectedItems
            For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                If node.SelectSingleNode("name").innertext = item Then
                    node.SelectSingleNode("inlist").innertext = 0
                    Exit For
                End If
            Next
        Next
        refreshUI()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        For Each item In InConfig.Items
            For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                If node.SelectSingleNode("name").innertext = item Then
                    node.SelectSingleNode("inlist").innertext = 0
                    Exit For
                End If
            Next
        Next
        refreshUI()
    End Sub
End Class