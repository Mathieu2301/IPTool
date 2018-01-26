<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wifiname1_txt = New System.Windows.Forms.TextBox()
        Me.newip_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.netmask_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gateway_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.metric_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.changip_btn = New System.Windows.Forms.Button()
        Me.dhcp_btn = New System.Windows.Forms.Button()
        Me.dns2_btn = New System.Windows.Forms.Button()
        Me.dns1_btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DNS1_txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DNS2_txt = New System.Windows.Forms.TextBox()
        Me.openwifi_btn = New System.Windows.Forms.Button()
        Me.closewifi_btn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.wifissid_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.wifikey_txt = New System.Windows.Forms.TextBox()
        Me.Console_lst = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom du réseau donné par la carte réseau :"
        '
        'wifiname1_txt
        '
        Me.wifiname1_txt.Location = New System.Drawing.Point(239, 29)
        Me.wifiname1_txt.Name = "wifiname1_txt"
        Me.wifiname1_txt.Size = New System.Drawing.Size(95, 20)
        Me.wifiname1_txt.TabIndex = 1
        Me.wifiname1_txt.Text = "Wi-FI"
        '
        'newip_txt
        '
        Me.newip_txt.Location = New System.Drawing.Point(239, 55)
        Me.newip_txt.Name = "newip_txt"
        Me.newip_txt.Size = New System.Drawing.Size(95, 20)
        Me.newip_txt.TabIndex = 3
        Me.newip_txt.Text = "192.168.0.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nouvelle adresse IP :"
        '
        'netmask_txt
        '
        Me.netmask_txt.Location = New System.Drawing.Point(239, 81)
        Me.netmask_txt.Name = "netmask_txt"
        Me.netmask_txt.Size = New System.Drawing.Size(95, 20)
        Me.netmask_txt.TabIndex = 5
        Me.netmask_txt.Text = "255.255.255.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Masque de sous-réseau :"
        '
        'gateway_txt
        '
        Me.gateway_txt.Location = New System.Drawing.Point(239, 107)
        Me.gateway_txt.Name = "gateway_txt"
        Me.gateway_txt.Size = New System.Drawing.Size(95, 20)
        Me.gateway_txt.TabIndex = 7
        Me.gateway_txt.Text = "192.168.0.254"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Adresse IP de la passerelle :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "(Laissez vide si innconnu)"
        '
        'metric_txt
        '
        Me.metric_txt.Location = New System.Drawing.Point(239, 133)
        Me.metric_txt.Name = "metric_txt"
        Me.metric_txt.Size = New System.Drawing.Size(95, 20)
        Me.metric_txt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Metric de la carte réseau (en générale = 1) :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.metric_txt)
        Me.GroupBox1.Controls.Add(Me.wifiname1_txt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.newip_txt)
        Me.GroupBox1.Controls.Add(Me.gateway_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.netmask_txt)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 170)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Changer adresse IP"
        '
        'changip_btn
        '
        Me.changip_btn.Location = New System.Drawing.Point(426, 96)
        Me.changip_btn.Name = "changip_btn"
        Me.changip_btn.Size = New System.Drawing.Size(169, 34)
        Me.changip_btn.TabIndex = 12
        Me.changip_btn.Text = "Changer IP"
        Me.changip_btn.UseVisualStyleBackColor = True
        '
        'dhcp_btn
        '
        Me.dhcp_btn.Location = New System.Drawing.Point(426, 56)
        Me.dhcp_btn.Name = "dhcp_btn"
        Me.dhcp_btn.Size = New System.Drawing.Size(169, 34)
        Me.dhcp_btn.TabIndex = 13
        Me.dhcp_btn.Text = "Activer DHCP"
        Me.dhcp_btn.UseVisualStyleBackColor = True
        '
        'dns2_btn
        '
        Me.dns2_btn.Location = New System.Drawing.Point(449, 33)
        Me.dns2_btn.Name = "dns2_btn"
        Me.dns2_btn.Size = New System.Drawing.Size(125, 34)
        Me.dns2_btn.TabIndex = 16
        Me.dns2_btn.Text = "Définir DNS 2"
        Me.dns2_btn.UseVisualStyleBackColor = True
        '
        'dns1_btn
        '
        Me.dns1_btn.Location = New System.Drawing.Point(292, 33)
        Me.dns1_btn.Name = "dns1_btn"
        Me.dns1_btn.Size = New System.Drawing.Size(125, 34)
        Me.dns1_btn.TabIndex = 15
        Me.dns1_btn.Text = "Définir DNS 1"
        Me.dns1_btn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dns1_btn)
        Me.GroupBox2.Controls.Add(Me.dns2_btn)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DNS1_txt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DNS2_txt)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 95)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paramètres DNS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Serveur DNS principal :"
        '
        'DNS1_txt
        '
        Me.DNS1_txt.Location = New System.Drawing.Point(158, 29)
        Me.DNS1_txt.Name = "DNS1_txt"
        Me.DNS1_txt.Size = New System.Drawing.Size(95, 20)
        Me.DNS1_txt.TabIndex = 1
        Me.DNS1_txt.Text = "8.8.4.4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Serveur DNS secondaire :"
        '
        'DNS2_txt
        '
        Me.DNS2_txt.Location = New System.Drawing.Point(158, 55)
        Me.DNS2_txt.Name = "DNS2_txt"
        Me.DNS2_txt.Size = New System.Drawing.Size(95, 20)
        Me.DNS2_txt.TabIndex = 3
        Me.DNS2_txt.Text = "8.8.8.8"
        '
        'openwifi_btn
        '
        Me.openwifi_btn.Location = New System.Drawing.Point(392, 21)
        Me.openwifi_btn.Name = "openwifi_btn"
        Me.openwifi_btn.Size = New System.Drawing.Size(160, 27)
        Me.openwifi_btn.TabIndex = 15
        Me.openwifi_btn.Text = "Ouvrir point d'acces WiFi"
        Me.openwifi_btn.UseVisualStyleBackColor = True
        '
        'closewifi_btn
        '
        Me.closewifi_btn.Location = New System.Drawing.Point(392, 54)
        Me.closewifi_btn.Name = "closewifi_btn"
        Me.closewifi_btn.Size = New System.Drawing.Size(160, 27)
        Me.closewifi_btn.TabIndex = 16
        Me.closewifi_btn.Text = "Fermer point d'acces WiFi"
        Me.closewifi_btn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.closewifi_btn)
        Me.GroupBox3.Controls.Add(Me.openwifi_btn)
        Me.GroupBox3.Controls.Add(Me.wifissid_txt)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.wifikey_txt)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 293)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(615, 95)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Paramètres DNS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "SSID du réseau WiFi :"
        '
        'wifissid_txt
        '
        Me.wifissid_txt.Location = New System.Drawing.Point(158, 29)
        Me.wifissid_txt.Name = "wifissid_txt"
        Me.wifissid_txt.Size = New System.Drawing.Size(176, 20)
        Me.wifissid_txt.TabIndex = 1
        Me.wifissid_txt.Text = "USP_Wifi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Clé de sécurité réseau :"
        '
        'wifikey_txt
        '
        Me.wifikey_txt.Location = New System.Drawing.Point(158, 55)
        Me.wifikey_txt.Name = "wifikey_txt"
        Me.wifikey_txt.Size = New System.Drawing.Size(176, 20)
        Me.wifikey_txt.TabIndex = 3
        Me.wifikey_txt.Text = "12345678"
        '
        'Console_lst
        '
        Me.Console_lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Console_lst.FormattingEnabled = True
        Me.Console_lst.ItemHeight = 16
        Me.Console_lst.Location = New System.Drawing.Point(17, 23)
        Me.Console_lst.Name = "Console_lst"
        Me.Console_lst.Size = New System.Drawing.Size(494, 324)
        Me.Console_lst.TabIndex = 18
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Console_lst)
        Me.GroupBox4.Location = New System.Drawing.Point(653, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(527, 372)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Console"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 408)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dhcp_btn)
        Me.Controls.Add(Me.changip_btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "IPTool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wifiname1_txt As System.Windows.Forms.TextBox
    Friend WithEvents newip_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents netmask_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gateway_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents metric_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents changip_btn As System.Windows.Forms.Button
    Friend WithEvents dhcp_btn As System.Windows.Forms.Button
    Friend WithEvents dns2_btn As System.Windows.Forms.Button
    Friend WithEvents dns1_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DNS1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DNS2_txt As System.Windows.Forms.TextBox
    Friend WithEvents openwifi_btn As System.Windows.Forms.Button
    Friend WithEvents closewifi_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents wifissid_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents wifikey_txt As System.Windows.Forms.TextBox
    Friend WithEvents Console_lst As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
