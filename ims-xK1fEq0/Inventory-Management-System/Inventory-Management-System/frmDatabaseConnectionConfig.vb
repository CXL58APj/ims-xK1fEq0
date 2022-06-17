Public Class frmDatabaseConnectionConfig

    Dim _title As String = "Inventory Management System"
    Private Sub frmDatabaseConnectionConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatabaseConnectionConfig()

    End Sub

    Sub loadDatabaseConnectionConfig()
        txtServer.Text = My.Settings.dbserver
        txtPort.Text = My.Settings.dbport
        txtUsername.Text = My.Settings.dbusername
        txtPassword.Text = My.Settings.dbpassword
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim _result As DialogResult = MessageBox.Show("Do you want to save the changes?", _title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If _result = DialogResult.Yes Then
            My.Settings.dbserver = txtServer.Text.Trim
            My.Settings.dbport = txtPort.Text.Trim
            My.Settings.dbusername = txtUsername.Text.Trim
            My.Settings.dbpassword = txtPassword.Text.Trim
            My.Settings.Save()
            My.Settings.Reload()
            loadDatabaseConnectionConfig()
            MessageBox.Show("Changes has been saved. The application will restart.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Restart()
        ElseIf _result = DialogResult.No Then
            MsgBox("No changes has been saved. The application will restart.", vbInformation)
            Application.Restart()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Do you want to restore the default configuration?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            My.Settings.Reset()
            My.Settings.Reload()
            loadDatabaseConnectionConfig()
            MessageBox.Show("Default configuration has been restored.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TestConnectionToDatabase() = True Then
            MsgBox("Connection Success", vbInformation)
        Else
            MsgBox("Connection Failed. Please try the following options below and try again." + Environment.NewLine + Environment.NewLine + "• Check the connection credentials." + Environment.NewLine + "• Check if Apache and MySQL is running in XAMPP.", vbCritical)
        End If
        cn.Close()
    End Sub

    Function TestConnectionToDatabase() As Boolean
        Try
            With cn
                .ConnectionString = "server=" & txtServer.Text.Trim & ";port=" & txtPort.Text.Trim & ";user id=" & txtUsername.Text.Trim & ";password=" & txtPassword.Text.Trim & ";database=imsdb"
                .Open()
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class