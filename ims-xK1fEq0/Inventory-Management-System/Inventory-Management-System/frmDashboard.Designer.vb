<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.INVENTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAINTENANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATABASECONNECTIONCONFIGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYSTEMSETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACCOUNTSETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFullnameType = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtuserpassword = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.MenuStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(878, 380)
        Me.Panel3.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INVENTORYToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.MAINTENANCEToolStripMenuItem, Me.ACCOUNTSETTINGSToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'INVENTORYToolStripMenuItem
        '
        Me.INVENTORYToolStripMenuItem.Name = "INVENTORYToolStripMenuItem"
        Me.INVENTORYToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.INVENTORYToolStripMenuItem.Text = "&INVENTORY"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.REPORTSToolStripMenuItem.Text = "&REPORTS"
        '
        'MAINTENANCEToolStripMenuItem
        '
        Me.MAINTENANCEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATABASECONNECTIONCONFIGToolStripMenuItem, Me.SYSTEMSETTINGSToolStripMenuItem, Me.USERSToolStripMenuItem})
        Me.MAINTENANCEToolStripMenuItem.Name = "MAINTENANCEToolStripMenuItem"
        Me.MAINTENANCEToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.MAINTENANCEToolStripMenuItem.Text = "&MAINTENANCE"
        '
        'DATABASECONNECTIONCONFIGToolStripMenuItem
        '
        Me.DATABASECONNECTIONCONFIGToolStripMenuItem.Name = "DATABASECONNECTIONCONFIGToolStripMenuItem"
        Me.DATABASECONNECTIONCONFIGToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.DATABASECONNECTIONCONFIGToolStripMenuItem.Text = "&DATABASE CONNECTION"
        '
        'SYSTEMSETTINGSToolStripMenuItem
        '
        Me.SYSTEMSETTINGSToolStripMenuItem.Name = "SYSTEMSETTINGSToolStripMenuItem"
        Me.SYSTEMSETTINGSToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SYSTEMSETTINGSToolStripMenuItem.Text = "&SETTINGS"
        '
        'USERSToolStripMenuItem
        '
        Me.USERSToolStripMenuItem.Name = "USERSToolStripMenuItem"
        Me.USERSToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.USERSToolStripMenuItem.Text = "&USERS"
        '
        'ACCOUNTSETTINGSToolStripMenuItem
        '
        Me.ACCOUNTSETTINGSToolStripMenuItem.Name = "ACCOUNTSETTINGSToolStripMenuItem"
        Me.ACCOUNTSETTINGSToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.ACCOUNTSETTINGSToolStripMenuItem.Text = "&ACCOUNT SETTINGS"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.LOGOUTToolStripMenuItem.Text = "&LOGOUT"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblFullnameType)
        Me.Panel2.Controls.Add(Me.lblDateTime)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 415)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(878, 35)
        Me.Panel2.TabIndex = 4
        '
        'lblFullnameType
        '
        Me.lblFullnameType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFullnameType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullnameType.Location = New System.Drawing.Point(12, 10)
        Me.lblFullnameType.Name = "lblFullnameType"
        Me.lblFullnameType.Size = New System.Drawing.Size(470, 23)
        Me.lblFullnameType.TabIndex = 2
        Me.lblFullnameType.Text = "Logged in as: "
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(606, 10)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDateTime.Size = New System.Drawing.Size(260, 23)
        Me.lblDateTime.TabIndex = 1
        Me.lblDateTime.Text = "Day, dd/mm/yyyy 00:00:00 PM"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtuserpassword)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 35)
        Me.Panel1.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(746, 9)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 11
        Me.txtId.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Inventory Management System"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(7, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "IMS"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txtuserpassword
        '
        Me.txtuserpassword.Location = New System.Drawing.Point(640, 9)
        Me.txtuserpassword.Name = "txtuserpassword"
        Me.txtuserpassword.ReadOnly = True
        Me.txtuserpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtuserpassword.TabIndex = 12
        Me.txtuserpassword.Visible = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblFullnameType As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents INVENTORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MAINTENANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATABASECONNECTIONCONFIGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SYSTEMSETTINGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACCOUNTSETTINGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtuserpassword As TextBox
End Class
