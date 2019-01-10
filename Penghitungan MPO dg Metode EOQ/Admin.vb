Imports System.Data.SqlClient

Public Class Admin

    Dim conn As New SqlConnection("data source=DESKTOP-EADIQOK;initial catalog=EOQ;integrated security=true;")

    Dim table As New DataTable

    Dim adapter As New SqlDataAdapter("SELECT * from Hasil_EOQ", conn)

    Private Sub Admin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim cb As New SqlCommandBuilder(adapter)
        adapter.Update(table)
    End Sub


    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        adapter.Fill(table)

        DataGridView1.DataSource = table

        Dim adapman As New SqlDataAdapter("SELECT ID_PER,NM_PER FROM PERUSAHAAN ", conn)
        Dim dtPER As New DataTable
        adapman.Fill(dtPER)


        ComboBox1.DataSource = dtPER
        ComboBox1.DisplayMember = "NM_PER"
        ComboBox1.ValueMember = "ID_PER"


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim da As New SqlDataAdapter("SELECT * FROM Hasil_EOQ where id_per like '" & ComboBox1.SelectedValue & "' ", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hide()
        Dashboard.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Daftarper.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        adapter.Fill(table)

        DataGridView1.DataSource = table

        Dim adapman As New SqlDataAdapter("SELECT ID_PER,NM_PER FROM PERUSAHAAN ", conn)
        Dim dtPER As New DataTable
        adapman.Fill(dtPER)


        ComboBox1.DataSource = dtPER
        ComboBox1.DisplayMember = "NM_PER"
        ComboBox1.ValueMember = "ID_PER"

    End Sub
End Class