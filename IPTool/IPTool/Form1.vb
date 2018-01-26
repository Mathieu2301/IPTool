Imports System.Net

Public Class Form1

    Function CmdRequest(ByVal Command As String)

        'Shell(Command.Replace("%WiFiname%", wifiname1_txt.Text).
        '        Replace("%newIP%", newip_txt.Text).
        '        Replace("%netmask%", netmask_txt.Text).
        '        Replace("%gateway%", gateway_txt.Text).
        '        Replace("%metric%", metric_txt.Text).
        '        Replace("%DNS1%", DNS1_txt.Text).
        '        Replace("%DNS2%", DNS2_txt.Text).
        '        Replace("%WiFissid%", wifissid_txt.Text).
        '        Replace("%WiFikey%", wifikey_txt.Text))

        Try
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\request.usp-data")
        Catch ex As Exception
        End Try

        System.IO.File.WriteAllLines(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "/run.bat", New String() {Command.
                Replace("%WiFiname%", wifiname1_txt.Text).
                Replace("%newIP%", newip_txt.Text).
                Replace("%netmask%", netmask_txt.Text).
                Replace("%gateway%", gateway_txt.Text).
                Replace("%metric%", metric_txt.Text).
                Replace("%DNS1%", DNS1_txt.Text).
                Replace("%DNS2%", DNS2_txt.Text).
                Replace("%WiFissid%", wifissid_txt.Text).
                Replace("%WiFikey%", wifikey_txt.Text) & " > " & """" & My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\request.usp-data"""})
        Shell(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "/run.bat")

        Dim w As New WebClient
        While True
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\request.usp-data") Then
                MsgBox(w.DownloadString(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\request.usp-data"))
                Return w.DownloadString(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\request.usp-data")
            End If
        End While

    End Function

    Private Sub dhcp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dhcp_btn.Click
        Try
            Console_lst.Items.Add(CmdRequest("netsh interface ip set address ""%WiFiname%"" dhcp"))
        Catch ex As Exception
            Console_lst.Items.Add("Mode DHCP activé")
        End Try
    End Sub

    Private Sub changip_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changip_btn.Click
        Try
            Console_lst.Items.Add(CmdRequest("netsh interface ip set address ""%WiFiname%"" static %newIP% %netmask% %gateway% %metric%"))
        Catch ex As Exception
            Console_lst.Items.Add("Adresse IP modifiée")
        End Try
    End Sub

    Private Sub dns1_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dns1_btn.Click
        Try
            Console_lst.Items.Add(CmdRequest("netsh interface ip add dns ""%WiFiname%"" %DNS1% 1"))
        Catch ex As Exception
            Console_lst.Items.Add("DNS modifié")
        End Try
    End Sub

    Private Sub dns2_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dns2_btn.Click
        Try
            Console_lst.Items.Add(CmdRequest("netsh interface ip add dns ""%WiFiname%"" %DNS2% 2"))
        Catch ex As Exception
            Console_lst.Items.Add("DNS modifié")
        End Try
    End Sub

    Private Sub openwifi_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openwifi_btn.Click
        Try
            Console_lst.Items.Add(CmdRequest("netsh wlan stop hostednetwork"))
        Catch ex As Exception
            Console_lst.Items.Add("Réseau WiFi fermé")
        End Try
        Try
            Console_lst.Items.Add(CmdRequest("netsh wlan set hostednetwork mode=allow ssid=%WiFissid% key=%WiFikey%"))
        Catch ex As Exception
            Console_lst.Items.Add("Enregistrement des paramètres")
        End Try
        Try
            Console_lst.Items.Add(CmdRequest("netsh wlan start hostednetwork"))
        Catch ex As Exception
            Console_lst.Items.Add("Réseau WiFi ouvert")
        End Try

    End Sub

    Private Sub closewifi_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closewifi_btn.Click
        Try
            Console_lst.Items.Add(CmdRequest("netsh wlan stop hostednetwork"))
        Catch ex As Exception
            Console_lst.Items.Add("Réseau WiFi fermé")
        End Try
    End Sub
End Class
