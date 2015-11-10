<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnv3Username = New System.Windows.Forms.Button()
        Me.btnv4Username = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.btnv3Password = New System.Windows.Forms.Button()
        Me.txtv3Username = New System.Windows.Forms.TextBox()
        Me.txtv4Username = New System.Windows.Forms.TextBox()
        Me.txtv4Password = New System.Windows.Forms.TextBox()
        Me.txtv3Password = New System.Windows.Forms.TextBox()
        Me.btnv32_Server = New System.Windows.Forms.Button()
        Me.txtv3server = New System.Windows.Forms.TextBox()
        Me.txtv3Port = New System.Windows.Forms.TextBox()
        Me.btnV4_Server = New System.Windows.Forms.Button()
        Me.txtv4server = New System.Windows.Forms.TextBox()
        Me.txtv4Port = New System.Windows.Forms.TextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cbov3 = New System.Windows.Forms.ComboBox()
        Me.cbov4 = New System.Windows.Forms.ComboBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtv3Database = New System.Windows.Forms.TextBox()
        Me.txtv4Database = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnv3Username
        '
        Me.btnv3Username.Location = New System.Drawing.Point(12, 122)
        Me.btnv3Username.Name = "btnv3Username"
        Me.btnv3Username.Size = New System.Drawing.Size(75, 23)
        Me.btnv3Username.TabIndex = 0
        Me.btnv3Username.Text = "Username"
        Me.btnv3Username.UseVisualStyleBackColor = True
        '
        'btnv4Username
        '
        Me.btnv4Username.Location = New System.Drawing.Point(300, 122)
        Me.btnv4Username.Name = "btnv4Username"
        Me.btnv4Username.Size = New System.Drawing.Size(75, 23)
        Me.btnv4Username.TabIndex = 1
        Me.btnv4Username.Text = "Username"
        Me.btnv4Username.UseVisualStyleBackColor = True
        '
        'btnPassword
        '
        Me.btnPassword.Location = New System.Drawing.Point(300, 179)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(75, 23)
        Me.btnPassword.TabIndex = 2
        Me.btnPassword.Text = "Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'btnv3Password
        '
        Me.btnv3Password.Location = New System.Drawing.Point(12, 182)
        Me.btnv3Password.Name = "btnv3Password"
        Me.btnv3Password.Size = New System.Drawing.Size(75, 23)
        Me.btnv3Password.TabIndex = 3
        Me.btnv3Password.Text = "Password"
        Me.btnv3Password.UseVisualStyleBackColor = True
        '
        'txtv3Username
        '
        Me.txtv3Username.Location = New System.Drawing.Point(137, 122)
        Me.txtv3Username.Name = "txtv3Username"
        Me.txtv3Username.Size = New System.Drawing.Size(100, 20)
        Me.txtv3Username.TabIndex = 4
        Me.txtv3Username.Text = "root"
        '
        'txtv4Username
        '
        Me.txtv4Username.Location = New System.Drawing.Point(395, 122)
        Me.txtv4Username.Name = "txtv4Username"
        Me.txtv4Username.Size = New System.Drawing.Size(100, 20)
        Me.txtv4Username.TabIndex = 5
        Me.txtv4Username.Text = "root"
        '
        'txtv4Password
        '
        Me.txtv4Password.Location = New System.Drawing.Point(395, 181)
        Me.txtv4Password.Name = "txtv4Password"
        Me.txtv4Password.Size = New System.Drawing.Size(100, 20)
        Me.txtv4Password.TabIndex = 6
        Me.txtv4Password.Text = "admin"
        '
        'txtv3Password
        '
        Me.txtv3Password.Location = New System.Drawing.Point(137, 179)
        Me.txtv3Password.Name = "txtv3Password"
        Me.txtv3Password.Size = New System.Drawing.Size(100, 20)
        Me.txtv3Password.TabIndex = 7
        Me.txtv3Password.Text = "admin"
        '
        'btnv32_Server
        '
        Me.btnv32_Server.Location = New System.Drawing.Point(12, 12)
        Me.btnv32_Server.Name = "btnv32_Server"
        Me.btnv32_Server.Size = New System.Drawing.Size(75, 23)
        Me.btnv32_Server.TabIndex = 8
        Me.btnv32_Server.Text = "V32 Server"
        Me.btnv32_Server.UseVisualStyleBackColor = True
        '
        'txtv3server
        '
        Me.txtv3server.Location = New System.Drawing.Point(137, 14)
        Me.txtv3server.Name = "txtv3server"
        Me.txtv3server.Size = New System.Drawing.Size(100, 20)
        Me.txtv3server.TabIndex = 9
        Me.txtv3server.Text = "localhost"
        '
        'txtv3Port
        '
        Me.txtv3Port.Location = New System.Drawing.Point(137, 60)
        Me.txtv3Port.Name = "txtv3Port"
        Me.txtv3Port.Size = New System.Drawing.Size(100, 20)
        Me.txtv3Port.TabIndex = 10
        Me.txtv3Port.Text = "3306"
        '
        'btnV4_Server
        '
        Me.btnV4_Server.Location = New System.Drawing.Point(300, 15)
        Me.btnV4_Server.Name = "btnV4_Server"
        Me.btnV4_Server.Size = New System.Drawing.Size(75, 23)
        Me.btnV4_Server.TabIndex = 11
        Me.btnV4_Server.Text = "V4 Server"
        Me.btnV4_Server.UseVisualStyleBackColor = True
        '
        'txtv4server
        '
        Me.txtv4server.Location = New System.Drawing.Point(395, 17)
        Me.txtv4server.Name = "txtv4server"
        Me.txtv4server.Size = New System.Drawing.Size(100, 20)
        Me.txtv4server.TabIndex = 12
        Me.txtv4server.Text = "localhost"
        '
        'txtv4Port
        '
        Me.txtv4Port.Location = New System.Drawing.Point(395, 60)
        Me.txtv4Port.Name = "txtv4Port"
        Me.txtv4Port.Size = New System.Drawing.Size(100, 20)
        Me.txtv4Port.TabIndex = 13
        Me.txtv4Port.Text = "3306"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(329, 317)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 16
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cbov3
        '
        Me.cbov3.FormattingEnabled = True
        Me.cbov3.Location = New System.Drawing.Point(41, 278)
        Me.cbov3.Name = "cbov3"
        Me.cbov3.Size = New System.Drawing.Size(121, 21)
        Me.cbov3.TabIndex = 17
        '
        'cbov4
        '
        Me.cbov4.FormattingEnabled = True
        Me.cbov4.Location = New System.Drawing.Point(369, 278)
        Me.cbov4.Name = "cbov4"
        Me.cbov4.Size = New System.Drawing.Size(121, 21)
        Me.cbov4.TabIndex = 18
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(415, 317)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtv3Database
        '
        Me.txtv3Database.Location = New System.Drawing.Point(41, 234)
        Me.txtv3Database.Name = "txtv3Database"
        Me.txtv3Database.Size = New System.Drawing.Size(196, 20)
        Me.txtv3Database.TabIndex = 20
        Me.txtv3Database.Text = "mysql_climsoft_db_v4"
        '
        'txtv4Database
        '
        Me.txtv4Database.Location = New System.Drawing.Point(294, 234)
        Me.txtv4Database.Name = "txtv4Database"
        Me.txtv4Database.Size = New System.Drawing.Size(196, 20)
        Me.txtv4Database.TabIndex = 21
        Me.txtv4Database.Text = "mysql_climsoft_db_v4_copy"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 352)
        Me.Controls.Add(Me.txtv4Database)
        Me.Controls.Add(Me.txtv3Database)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cbov4)
        Me.Controls.Add(Me.cbov3)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtv4Port)
        Me.Controls.Add(Me.txtv4server)
        Me.Controls.Add(Me.btnV4_Server)
        Me.Controls.Add(Me.txtv3Port)
        Me.Controls.Add(Me.txtv3server)
        Me.Controls.Add(Me.btnv32_Server)
        Me.Controls.Add(Me.txtv3Password)
        Me.Controls.Add(Me.txtv4Password)
        Me.Controls.Add(Me.txtv4Username)
        Me.Controls.Add(Me.txtv3Username)
        Me.Controls.Add(Me.btnv3Password)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.btnv4Username)
        Me.Controls.Add(Me.btnv3Username)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnv3Username As Button
    Friend WithEvents btnv4Username As Button
    Friend WithEvents btnPassword As Button
    Friend WithEvents btnv3Password As Button
    Friend WithEvents txtv3Username As TextBox
    Friend WithEvents txtv4Username As TextBox
    Friend WithEvents txtv4Password As TextBox
    Friend WithEvents txtv3Password As TextBox
    Friend WithEvents btnv32_Server As Button
    Friend WithEvents txtv3server As TextBox
    Friend WithEvents txtv3Port As TextBox
    Friend WithEvents btnV4_Server As Button
    Friend WithEvents txtv4server As TextBox
    Friend WithEvents txtv4Port As TextBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cbov3 As ComboBox
    Friend WithEvents cbov4 As ComboBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents txtv3Database As TextBox
    Friend WithEvents txtv4Database As TextBox
End Class
