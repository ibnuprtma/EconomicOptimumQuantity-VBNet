Imports System.Data.SqlClient

Public Class Daftarper

    Dim conn As New SqlConnection("data source=DESKTOP-EADIQOK;initial catalog=EOQ;integrated security=true;")

    Dim adapter As New SqlDataAdapter("select * from perusahaan", conn)

    Dim table As New DataTable

    Private Sub Daftarper_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim cb As New SqlCommandBuilder(adapter)
        adapter.Update(table)
    End Sub

    Private Sub Daftarper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

End Class