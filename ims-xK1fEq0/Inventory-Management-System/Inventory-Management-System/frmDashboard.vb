Public Class frmDashboard
    Dim _title As String = "Inventory Management System"
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dddd, MMMM dd, yyy hh:mm:ss tt")
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        If MessageBox.Show("Do you want to logout?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmLogin.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub ACCOUNTSETTINGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACCOUNTSETTINGSToolStripMenuItem.Click
        frmAccountSettings.ShowDialog()
    End Sub

    Private Sub DATABASECONNECTIONCONFIGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATABASECONNECTIONCONFIGToolStripMenuItem.Click
        frmDatabaseConnectionConfig.ShowDialog()
    End Sub
End Class