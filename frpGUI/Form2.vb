Public Class SvrMgr
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        Main.Enabled = True
        Main.ReloadGUI()
        Main.Activate()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/server/config")
            ServerList.Items.Add(node.SelectSingleNode("name").InnerText)
        Next
        DelBtn.Enabled = False
        ReBtn.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Main.Enabled = True
        Main.ReloadGUI()
        Main.Activate()
        Me.Close()
    End Sub

    Private Sub ServerList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ServerList.SelectedIndexChanged
        If ServerList.SelectedItems.Count <> 0 Then
            DelBtn.Enabled = True
        Else
            DelBtn.Enabled = False
        End If
        If ServerList.SelectedItems.Count = 1 Then
            ReBtn.Enabled = True
        Else
            ReBtn.Enabled = False
        End If
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Dim response = MsgBox("Are you sure want to delete selected " & ServerList.SelectedItems.Count & "item(s)? This operation can not be undone!", MsgBoxStyle.YesNo, "frp GUI")
        If response = MsgBoxResult.Yes Then
            For Each item In ServerList.SelectedItems
                For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/server/config")
                    If node.SelectSingleNode("name").innertext = item Then
                        node.ParentNode.RemoveChild(node)
                        Exit For
                    End If
                Next
            Next
            ServerList.Items.Remove(ServerList.SelectedItem)
            Main.config.Save(Main.path & "/config.xml")
        End If
    End Sub
End Class