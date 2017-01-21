Public Class CliMgr
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        Main.ReloadGUI()
        Main.Activate()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientList.Items.Clear()
        For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
            ClientList.Items.Add(node.SelectSingleNode("name").InnerText)
        Next
        DelBtn.Enabled = False
        RenBtn.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Main.ReloadGUI()
        Main.Activate()
        Me.Close()
    End Sub

    Private Sub ClientList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClientList.SelectedIndexChanged
        If ClientList.SelectedItems.Count <> 0 Then
            DelBtn.Enabled = True
        Else
            DelBtn.Enabled = False
        End If
        If ClientList.SelectedItems.Count = 1 Then
            RenBtn.Enabled = True
        Else
            RenBtn.Enabled = False
        End If
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Dim response = MsgBox("Are you sure want to delete the selected " & ClientList.SelectedItems.Count & " item(s)? This operation can not be undone!", MsgBoxStyle.YesNo, "frp GUI")
        If response = MsgBoxResult.Yes Then
            For Each item In ClientList.SelectedItems
                For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                    If node.SelectSingleNode("name").innertext = item Then
                        node.ParentNode.RemoveChild(node)
                        Exit For
                    End If
                Next
            Next
            ClientList.Items.Remove(ClientList.SelectedItem)
            Main.config.Save(Main.path & "/config.xml")
        End If
    End Sub

    Private Sub RenBtn_Click(sender As Object, e As EventArgs) Handles RenBtn.Click
        Dim clientname = InputBox("Pick a new name for configuration [" & ClientList.SelectedItems(0) & "] :", "Rename")
        If clientname <> "" Then
            For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                If node.SelectSingleNode("name").innertext = clientname Then
                    MessageBox.Show("Name [" & clientname & "] is already used!", "Error")
                    Exit Sub
                End If
            Next
            For Each node In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                If node.SelectSingleNode("name").innertext = ClientList.SelectedItems(0) Then
                    node.SelectSingleNode("name").innertext = clientname
                    ClientList.Items.Clear()
                    For Each node1 In Main.config.DocumentElement.SelectNodes("/FRPGUI/client/config")
                        ClientList.Items.Add(node1.SelectSingleNode("name").InnerText)
                    Next
                    Exit For
                End If
            Next
            Main.config.Save(Main.path & "/config.xml")
        End If
    End Sub
End Class