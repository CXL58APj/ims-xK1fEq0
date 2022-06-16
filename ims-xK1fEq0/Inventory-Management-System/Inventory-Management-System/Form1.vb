Imports MySql.Data.MySqlClient
Public Class frmSplashScreen
    Dim _loading As Integer = 0
    Dim _title As String = "Inventory Management System"
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        _loading += 1
        If _loading = 3 Then
            Timer1.Stop()
            If ConnectToDatabase() = True Then
                MsgBox("Connected", vbInformation)
                cn.Close()
                frmLogin.Show()
                Me.Hide()
            Else
                If MessageBox.Show("Connection to the database failed. Do you want to open the connection configuration form?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    frmDatabaseConnectionConfig.Show()
                    Me.Hide()
                    cn.Close()
                Else
                    MsgBox("Failed to establish connection to the database. The application will now close.", vbCritical)
                    Me.Dispose()
                End If
            End If

            End If
    End Sub
End Class
