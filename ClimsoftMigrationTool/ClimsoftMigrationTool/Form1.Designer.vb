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
        Me.txtV3Username = New System.Windows.Forms.TextBox()
        Me.txtV3Password = New System.Windows.Forms.TextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpV3Details = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblV3Password = New System.Windows.Forms.Label()
        Me.lblV3Username = New System.Windows.Forms.Label()
        Me.lblV3Port = New System.Windows.Forms.Label()
        Me.cboV3Database = New System.Windows.Forms.ComboBox()
        Me.lblV3Server = New System.Windows.Forms.Label()
        Me.txtV3Port = New System.Windows.Forms.TextBox()
        Me.txtV3Server = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblV4Database = New System.Windows.Forms.Label()
        Me.lblV4Password = New System.Windows.Forms.Label()
        Me.lblV4Username = New System.Windows.Forms.Label()
        Me.lblV4Port = New System.Windows.Forms.Label()
        Me.cboV4Database = New System.Windows.Forms.ComboBox()
        Me.lblV4Server = New System.Windows.Forms.Label()
        Me.txtV4Port = New System.Windows.Forms.TextBox()
        Me.txtV4Server = New System.Windows.Forms.TextBox()
        Me.txtV4Password = New System.Windows.Forms.TextBox()
        Me.txtV4Username = New System.Windows.Forms.TextBox()
        Me.grpV3Details.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtV3Username
        '
        Me.txtV3Username.Location = New System.Drawing.Point(97, 103)
        Me.txtV3Username.Name = "txtV3Username"
        Me.txtV3Username.Size = New System.Drawing.Size(120, 20)
        Me.txtV3Username.TabIndex = 4
        Me.txtV3Username.Text = "root"
        '
        'txtV3Password
        '
        Me.txtV3Password.Location = New System.Drawing.Point(97, 129)
        Me.txtV3Password.Name = "txtV3Password"
        Me.txtV3Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtV3Password.Size = New System.Drawing.Size(120, 20)
        Me.txtV3Password.TabIndex = 7
        Me.txtV3Password.Text = "admin"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(334, 246)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 16
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(415, 246)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'grpV3Details
        '
        Me.grpV3Details.Controls.Add(Me.Label2)
        Me.grpV3Details.Controls.Add(Me.lblV3Password)
        Me.grpV3Details.Controls.Add(Me.lblV3Username)
        Me.grpV3Details.Controls.Add(Me.lblV3Port)
        Me.grpV3Details.Controls.Add(Me.cboV3Database)
        Me.grpV3Details.Controls.Add(Me.lblV3Server)
        Me.grpV3Details.Controls.Add(Me.txtV3Port)
        Me.grpV3Details.Controls.Add(Me.txtV3Server)
        Me.grpV3Details.Controls.Add(Me.txtV3Username)
        Me.grpV3Details.Controls.Add(Me.txtV3Password)
        Me.grpV3Details.Location = New System.Drawing.Point(12, 12)
        Me.grpV3Details.Name = "grpV3Details"
        Me.grpV3Details.Size = New System.Drawing.Size(233, 218)
        Me.grpV3Details.TabIndex = 25
        Me.grpV3Details.TabStop = False
        Me.grpV3Details.Text = "Climsoft 3.2 Database Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Database"
        '
        'lblV3Password
        '
        Me.lblV3Password.AutoSize = True
        Me.lblV3Password.Location = New System.Drawing.Point(22, 132)
        Me.lblV3Password.Name = "lblV3Password"
        Me.lblV3Password.Size = New System.Drawing.Size(53, 13)
        Me.lblV3Password.TabIndex = 32
        Me.lblV3Password.Text = "Password"
        '
        'lblV3Username
        '
        Me.lblV3Username.AutoSize = True
        Me.lblV3Username.Location = New System.Drawing.Point(22, 106)
        Me.lblV3Username.Name = "lblV3Username"
        Me.lblV3Username.Size = New System.Drawing.Size(55, 13)
        Me.lblV3Username.TabIndex = 31
        Me.lblV3Username.Text = "Username"
        '
        'lblV3Port
        '
        Me.lblV3Port.AutoSize = True
        Me.lblV3Port.Location = New System.Drawing.Point(22, 58)
        Me.lblV3Port.Name = "lblV3Port"
        Me.lblV3Port.Size = New System.Drawing.Size(26, 13)
        Me.lblV3Port.TabIndex = 30
        Me.lblV3Port.Text = "Port"
        '
        'cboV3Database
        '
        Me.cboV3Database.FormattingEnabled = True
        Me.cboV3Database.Location = New System.Drawing.Point(97, 170)
        Me.cboV3Database.Name = "cboV3Database"
        Me.cboV3Database.Size = New System.Drawing.Size(120, 21)
        Me.cboV3Database.TabIndex = 29
        Me.cboV3Database.Text = "mysql_main_climsoft_db_v3_sadc"
        '
        'lblV3Server
        '
        Me.lblV3Server.AutoSize = True
        Me.lblV3Server.Location = New System.Drawing.Point(22, 32)
        Me.lblV3Server.Name = "lblV3Server"
        Me.lblV3Server.Size = New System.Drawing.Size(38, 13)
        Me.lblV3Server.TabIndex = 28
        Me.lblV3Server.Text = "Server"
        '
        'txtV3Port
        '
        Me.txtV3Port.Location = New System.Drawing.Point(97, 55)
        Me.txtV3Port.Name = "txtV3Port"
        Me.txtV3Port.Size = New System.Drawing.Size(120, 20)
        Me.txtV3Port.TabIndex = 27
        Me.txtV3Port.Text = "3306"
        '
        'txtV3Server
        '
        Me.txtV3Server.Location = New System.Drawing.Point(97, 29)
        Me.txtV3Server.Name = "txtV3Server"
        Me.txtV3Server.Size = New System.Drawing.Size(120, 20)
        Me.txtV3Server.TabIndex = 26
        Me.txtV3Server.Text = "localhost"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblV4Database)
        Me.GroupBox1.Controls.Add(Me.lblV4Password)
        Me.GroupBox1.Controls.Add(Me.lblV4Username)
        Me.GroupBox1.Controls.Add(Me.lblV4Port)
        Me.GroupBox1.Controls.Add(Me.cboV4Database)
        Me.GroupBox1.Controls.Add(Me.lblV4Server)
        Me.GroupBox1.Controls.Add(Me.txtV4Port)
        Me.GroupBox1.Controls.Add(Me.txtV4Server)
        Me.GroupBox1.Controls.Add(Me.txtV4Password)
        Me.GroupBox1.Controls.Add(Me.txtV4Username)
        Me.GroupBox1.Location = New System.Drawing.Point(257, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 218)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Climsoft 4 Database Details"
        '
        'lblV4Database
        '
        Me.lblV4Database.AutoSize = True
        Me.lblV4Database.Location = New System.Drawing.Point(25, 175)
        Me.lblV4Database.Name = "lblV4Database"
        Me.lblV4Database.Size = New System.Drawing.Size(53, 13)
        Me.lblV4Database.TabIndex = 36
        Me.lblV4Database.Text = "Database"
        '
        'lblV4Password
        '
        Me.lblV4Password.AutoSize = True
        Me.lblV4Password.Location = New System.Drawing.Point(25, 136)
        Me.lblV4Password.Name = "lblV4Password"
        Me.lblV4Password.Size = New System.Drawing.Size(53, 13)
        Me.lblV4Password.TabIndex = 35
        Me.lblV4Password.Text = "Password"
        '
        'lblV4Username
        '
        Me.lblV4Username.AutoSize = True
        Me.lblV4Username.Location = New System.Drawing.Point(25, 110)
        Me.lblV4Username.Name = "lblV4Username"
        Me.lblV4Username.Size = New System.Drawing.Size(55, 13)
        Me.lblV4Username.TabIndex = 34
        Me.lblV4Username.Text = "Username"
        '
        'lblV4Port
        '
        Me.lblV4Port.AutoSize = True
        Me.lblV4Port.Location = New System.Drawing.Point(25, 61)
        Me.lblV4Port.Name = "lblV4Port"
        Me.lblV4Port.Size = New System.Drawing.Size(26, 13)
        Me.lblV4Port.TabIndex = 32
        Me.lblV4Port.Text = "Port"
        '
        'cboV4Database
        '
        Me.cboV4Database.FormattingEnabled = True
        Me.cboV4Database.Location = New System.Drawing.Point(98, 170)
        Me.cboV4Database.Name = "cboV4Database"
        Me.cboV4Database.Size = New System.Drawing.Size(120, 21)
        Me.cboV4Database.TabIndex = 31
        Me.cboV4Database.Text = "mysql_climsoft_db_v4"
        '
        'lblV4Server
        '
        Me.lblV4Server.AutoSize = True
        Me.lblV4Server.Location = New System.Drawing.Point(25, 32)
        Me.lblV4Server.Name = "lblV4Server"
        Me.lblV4Server.Size = New System.Drawing.Size(38, 13)
        Me.lblV4Server.TabIndex = 30
        Me.lblV4Server.Text = "Server"
        '
        'txtV4Port
        '
        Me.txtV4Port.Location = New System.Drawing.Point(98, 58)
        Me.txtV4Port.Name = "txtV4Port"
        Me.txtV4Port.Size = New System.Drawing.Size(120, 20)
        Me.txtV4Port.TabIndex = 29
        Me.txtV4Port.Text = "3306"
        '
        'txtV4Server
        '
        Me.txtV4Server.Location = New System.Drawing.Point(98, 29)
        Me.txtV4Server.Name = "txtV4Server"
        Me.txtV4Server.Size = New System.Drawing.Size(120, 20)
        Me.txtV4Server.TabIndex = 28
        Me.txtV4Server.Text = "localhost"
        '
        'txtV4Password
        '
        Me.txtV4Password.Location = New System.Drawing.Point(98, 132)
        Me.txtV4Password.Name = "txtV4Password"
        Me.txtV4Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtV4Password.Size = New System.Drawing.Size(120, 20)
        Me.txtV4Password.TabIndex = 27
        Me.txtV4Password.Text = "admin"
        '
        'txtV4Username
        '
        Me.txtV4Username.Location = New System.Drawing.Point(98, 106)
        Me.txtV4Username.Name = "txtV4Username"
        Me.txtV4Username.Size = New System.Drawing.Size(120, 20)
        Me.txtV4Username.TabIndex = 26
        Me.txtV4Username.Text = "root"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 293)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpV3Details)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOK)
        Me.Name = "Form1"
        Me.Text = "Climsoft Database Migration Tool"
        Me.grpV3Details.ResumeLayout(False)
        Me.grpV3Details.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtV3Username As TextBox
    Friend WithEvents txtV3Password As TextBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents grpV3Details As GroupBox
    Friend WithEvents lblV3Server As Label
    Friend WithEvents txtV3Port As TextBox
    Friend WithEvents txtV3Server As TextBox
    Friend WithEvents lblV3Password As Label
    Friend WithEvents lblV3Username As Label
    Friend WithEvents lblV3Port As Label
    Friend WithEvents cboV3Database As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblV4Database As Label
    Friend WithEvents lblV4Password As Label
    Friend WithEvents lblV4Username As Label
    Friend WithEvents lblV4Port As Label
    Friend WithEvents cboV4Database As ComboBox
    Friend WithEvents lblV4Server As Label
    Friend WithEvents txtV4Port As TextBox
    Friend WithEvents txtV4Server As TextBox
    Friend WithEvents txtV4Password As TextBox
    Friend WithEvents txtV4Username As TextBox
End Class
