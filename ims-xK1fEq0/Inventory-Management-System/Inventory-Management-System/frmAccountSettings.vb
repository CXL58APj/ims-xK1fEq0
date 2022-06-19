Imports MySql.Data.MySqlClient
Imports System.Text
Public Class frmAccountSettings
    Dim _title As String = "Inventory Management System"

    Private Sub frmAccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProfile()
    End Sub
    Sub loadProfile()
        cn.Open()
        cm = New MySqlCommand("SELECT * FROM tblusers WHERE `user-id` = '" & frmDashboard.txtId.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read()
            txtIdNumber.Tag = dr.Item("user-id").ToString()
            txtfname.Tag = dr.Item("fname").ToString()
            txtlname.Tag = dr.Item("lname").ToString()
            txtType.Tag = dr.Item("type").ToString()
            txtIdNumber.Text = dr.Item("user-id").ToString()
            txtfname.Text = dr.Item("fname").ToString()
            txtlname.Text = dr.Item("lname").ToString()
            txtType.Text = dr.Item("type").ToString()
        End While
        dr.Close()
        cn.Close()
        cm.Dispose()
    End Sub

    Sub updateProfile()
        Try
            cn.Open()
            cm = New MySqlCommand("UPDATE tblusers set `fname` = @fname , `lname` = @lname WHERE `user-id` = '" & txtIdNumber.Text & "'", cn)
            With cm
                .Parameters.AddWithValue("@fname", txtfname.Text.ToUpper)
                .Parameters.AddWithValue("@lname", txtlname.Text.ToUpper)
                .ExecuteNonQuery()
            End With
            cm.Dispose()
            cn.Close()
            MessageBox.Show("Update success! " + txtfname.Tag + " " + txtlname.Tag + " has been updated to " + txtfname.Text + " " + txtlname.Text, _title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            If MessageBox.Show("Update failed! Please try to check your connection to the database and try again." + "Error Log:" + Environment.NewLine + Environment.NewLine + ex.ToString, _title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Retry Then
                updateProfile()
            End If
        End Try
    End Sub

    Sub updatePassword()
        Try
            Dim _hash As String = ""
            Dim _password As String = txtpassword.Text
            For Each letter As String In _password
                _hash += Chr(Asc(letter) + _password.Length)
            Next
            cn.Open()
            cm = New MySqlCommand("UPDATE tblusers set `password` = MD5(@password) WHERE `user-id` = '" & txtIdNumber.Text & "'", cn)
            With cm
                .Parameters.AddWithValue("@password", _hash)
                .ExecuteNonQuery()
            End With
            cm.Dispose()
            cn.Close()
            clearFields()
            MessageBox.Show("Your password has been successfully updated.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            If MessageBox.Show("Update failed! Please try to check your connection to the database and try again." + "Error Log:" + Environment.NewLine + Environment.NewLine + ex.ToString, _title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Retry Then
                updatePassword()
            End If
        End Try
    End Sub

    Sub deactivateAccount()
        Try
            Dim _isActive As String = "FALSE"
            cn.Open()
            cm = New MySqlCommand("UPDATE tblusers set `active` = @isActive WHERE `user-id` = '" & txtIdNumber.Text & "'", cn)
            With cm
                .Parameters.AddWithValue("@isActive", _isActive)
                .ExecuteNonQuery()
            End With
            cm.Dispose()
            cn.Close()
            MessageBox.Show("Your account has been successfully deactivated. You will be now logged out.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Update failed! Please try to check your connection to the database and try again." + "Error Log:" + Environment.NewLine + Environment.NewLine + ex.ToString, _title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub clearFields()
        txtcpassword.Clear()
        txtpassword.Clear()
        txtpassword2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname As String = txtfname.Text
        Dim lname As String = txtlname.Text
        ' check fields if empty or whitespace
        If String.IsNullOrWhiteSpace(fname) Then
            MessageBox.Show("Firstname is required. Please do not leave the fields empty and try again.", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtfname.Select()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(lname) Then
            MessageBox.Show("Lastname is required. Please do not leave the fields empty and try again.", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlname.Select()
            Exit Sub
        End If

        ' Validate if the firstname and lastname characters are more than 2
        fname = fname.Trim
        lname = lname.Trim
        If fname.Length < 2 Then
            MessageBox.Show("The minimum length for firstname is two(2).", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtfname.Select()
            Exit Sub
        End If
        If lname.Length < 2 Then
            MessageBox.Show("The minimum length for lastname is two(2).", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlname.Select()
            Exit Sub
        End If

        ' check if there's changes
        If txtfname.Tag <> fname.Trim Or txtlname.Tag <> lname.Trim Then
            Dim _result As DialogResult = MessageBox.Show("Do you want to save the changes?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If _result = DialogResult.Yes Then
                updateProfile()
            End If
        Else
            MessageBox.Show("No changes has been made.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub

    Private Sub txtfname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub txtlname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim password As String = txtpassword.Text
        Dim currentpassword As String = txtcpassword.Text
        Dim password2 As String = txtpassword2.Text
        If String.IsNullOrWhiteSpace(currentpassword) Then
            MessageBox.Show("The current password is required to confirm your identity. Please do not leave the current password empty.", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcpassword.Select()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("The new password is reqiured to replace your current password. Please do not leave the fields empty. Your new password may contain whitespaces and not entirely.", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Select()
            Exit Sub
        End If

        If password.Length < 6 Then
            MessageBox.Show("The minimum length for a password is six(6).", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Select()
            Exit Sub
        End If

        If password <> password2 Then
            MessageBox.Show("The new password does not match. Please re-type your new password and try again.", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword2.Select()
            Exit Sub
        End If


        If currentpassword <> frmDashboard.txtuserpassword.Text Then
            MessageBox.Show("Incorrect current password. Please re-type your new password and try again.", _title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword2.Select()
            Exit Sub
        End If

        If password = frmDashboard.txtuserpassword.Text Then
            MessageBox.Show("No changes has been made.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearFields()
            txtcpassword.Select()
            Exit Sub
        Else
            updatePassword()
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Do you want to deactivate your account?" + Environment.NewLine + Environment.NewLine + "Note: You will need contact your administrator for the reactivation of your account.", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            deactivateAccount()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtcpassword.UseSystemPasswordChar = False
        Else
            txtcpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            txtpassword2.UseSystemPasswordChar = False
        Else
            txtpassword2.UseSystemPasswordChar = True
        End If
    End Sub
End Class