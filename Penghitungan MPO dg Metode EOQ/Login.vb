Imports System.Data.SqlClient


Public Class Login

    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public rd As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub koneksi()
        Try
            Dim str As String = "data source=DESKTOP-EADIQOK;initial catalog=EOQ;integrated security=true;"
            conn = New SqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Hide()
        Dashboard.Show()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try
            Call koneksi()
            Dim str As String
            str = "select * from Login where username = '" & TextBox1.Text & "' and pass = '" & TextBox2.Text & "'"
            cmd = New SqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                Hide()
                Admin.Show()
            Else
                rd.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox2.Text = ""
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class