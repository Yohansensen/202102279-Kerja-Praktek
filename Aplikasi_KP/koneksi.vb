Imports MySql.Data.MySqlClient
Imports System.Data

Public Class koneksi
    Private conn As MySqlConnection
    Public Function koneksi() As MySqlConnection

        Dim connstring As String
        connstring = ";server=localhost" & ";user=root" & ";password=''" & ";database=db_kp_hansen"
        Try
            conn = New MySqlConnection(connstring)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error" + ex.Message)
        End Try
        Return conn

    End Function

End Class


