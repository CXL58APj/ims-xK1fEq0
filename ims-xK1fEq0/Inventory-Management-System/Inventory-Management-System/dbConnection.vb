Imports MySql.Data.MySqlClient
Module dbConnection
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader

    Function ConnectToDatabase() As Boolean
        Try
            With cn
                .ConnectionString = "server=" & My.Settings.dbserver & ";port=" & My.Settings.dbport & ";user id=" & My.Settings.dbusername & ";password=" & My.Settings.dbpassword & ";database=imsdb"
                .Open()
            End With
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function
End Module
