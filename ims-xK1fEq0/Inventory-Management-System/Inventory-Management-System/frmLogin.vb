Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim _loginAttempts As Integer = 0
    Dim _timer As Integer = 0
    Dim _sec As String = "s"
    Dim _fullname, _type, _id As String
    Dim _title = "Inventory Management System"

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loginAttempts = 0
        If My.Settings.logintimer <> 0 Then
            txtId.Enabled = False
            txtPassword.Enabled = False
            CheckBox1.Enabled = False
            btnLogin.Enabled = False
            btnClose.Enabled = False
            _timer = My.Settings.logintimer
            Timer2.Start()
        Else
            _timer = 30
        End If
        txtId.Clear()
        txtPassword.Clear()
        txtId.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dddd, MMMM dd, yyy hh:mm:ss tt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmDashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        _timer -= 1
        My.Settings.logintimer = _timer
        My.Settings.Save()
        btnLogin.Text = _timer.ToString + "'" + _sec
        If _timer = 0 Then
            Timer2.Stop()
            btnLogin.Text = "Login"
            btnLogin.Enabled = True
            btnClose.Enabled = True
            txtId.Enabled = True
            txtPassword.Enabled = True
            CheckBox1.Enabled = True
            _loginAttempts = 0
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Login attempt
        If _loginAttempts = 5 Then
            Timer2.Start()
            txtId.Clear()
            txtPassword.Clear()
            txtId.Enabled = False
            txtPassword.Enabled = False
            CheckBox1.Enabled = False
            btnLogin.Enabled = False
            btnClose.Enabled = False
            MessageBox.Show("You have tried to login with incorrect credentials for several times. Please try again later.", _title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Check fields if empty
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("Id Number is required. Please do not leave the fields empty and try again.", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _loginAttempts += 1
            txtId.Select()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password is required. Please do not leave the fields empty and try again.", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _loginAttempts += 1
            txtPassword.Select()
            Exit Sub
        End If

        Dim _hash As String = ""
        Dim _password As String = txtPassword.Text
        For Each letter As String In _password
            _hash += Chr(Asc(letter) + _password.Length)
        Next
        cn.Open()
        cm = New MySqlCommand("SELECT * FROM tblusers WHERE `user-id` = @userid AND `password`=MD5(@password)", cn)
        With cm
            .Parameters.AddWithValue("@userid", txtId.Text.Trim)
            .Parameters.AddWithValue("@password", _hash)
        End With

        dr = cm.ExecuteReader()

        If (dr.HasRows) Then
            While (dr.Read())
                'Check if the account is active.
                If dr.GetValue(dr.GetOrdinal("active")) = "TRUE" Then
                    'Set the UI depending in the privilages of the account.
                    If dr.GetValue(dr.GetOrdinal("type")) = "ADMINISTRATOR" Then
                        ' DO SOMETHING
                    Else
                        ' DO SOMETHING
                    End If
                    _type = dr.Item("type").ToString()
                    _fullname = dr.Item("fname").ToString() + "  " + dr.Item("lname").ToString()
                    _id = dr.Item("user-id").ToString()
                    frmDashboard.txtId.Text = _id
                    frmDashboard.txtuserpassword.Text = txtPassword.Text
                    frmDashboard.lblFullnameType.Text = "Logged in as: " + _fullname + " - " + _type
                    frmDashboard.Show()
                    Me.Dispose()
                    MsgBox("Welcome back " + _fullname + "!", vbInformation)
                Else
                    MessageBox.Show("Account is no longer active. Please contact your administrator  to request for the reactivation of your account.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dr.Close()
                    cm.Dispose()
                    cn.Close()
                    _loginAttempts += 1
                    Exit Sub
                End If
            End While
            dr.Close()
            cm.Dispose()
            cn.Close()
            txtId.Clear()
            txtPassword.Clear()
            txtId.Focus()
            ' DO SOMETHING
        Else
            _loginAttempts += 1
            MessageBox.Show("Invalid credentials. Please try again", _title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            dr.Close()
            cm.Dispose()
            cn.Close()
        End If

    End Sub
End Class