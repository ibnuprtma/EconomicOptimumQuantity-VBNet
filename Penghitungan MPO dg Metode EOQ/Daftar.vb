Imports System.Data.SqlClient

Public Class Daftar

    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim comm3 As SqlCommand
    Dim reader As SqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Hide()
        Dashboard.Show()
    End Sub

    Private Sub clearform()
        nama.Clear()
        alamat.Clear()
        notelp.Clear()
    End Sub

    Private Sub Daftarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Daftarbtn.Click

        conn = New SqlConnection("data source=DESKTOP-EADIQOK;initial catalog=EOQ;integrated security=true;")
        conn.Open()

        Dim ID As String
        Dim namas As String = nama.Text
        Dim alamats As String = alamat.Text
        Dim no As String = notelp.Text
        Dim check As Integer

        comm3 = New SqlCommand
        comm3.Connection = conn
        comm3.CommandType = CommandType.Text
        comm3.CommandText = "SELECT (COUNT(id_per)+1) FROM PERUSAHAAN"
        ID = comm3.ExecuteScalar

        Try
            comm = New SqlCommand
            comm.Connection = conn
            comm.CommandType = CommandType.Text
            comm.CommandText = "SELECT COUNT(id_per) FROM PERUSAHAAN WHERE ID_PER='" & ID & "'"
            check = comm.ExecuteScalar
            If check = 0 Then
                Try
                    comm2 = New SqlCommand
                    comm2.Connection = conn
                    comm2.CommandType = CommandType.Text
                    comm2.CommandText = "INSERT INTO perusahaan VALUES ('" & ID & "','" & namas & "','" & alamats & "','" & no & "')"
                    comm2.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Simpan")
                    clearform()
                Catch ex As Exception
                    MsgBox("Terjadi Error")
                    clearform()
                End Try
            End If
        Catch ex As Exception
            MsgBox("Terjadi Eror bos")
        End Try

        conn.Close()

    End Sub
End Class
