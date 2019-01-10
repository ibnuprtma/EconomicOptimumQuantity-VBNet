Imports System.Data.SqlClient
Imports System.Math

Public Class User

    Dim conn As New SqlConnection("data source=DESKTOP-EADIQOK;initial catalog=EOQ;integrated security=true;")
    Dim Qop As String
    Dim HasilQop As String
    Dim Fre As String
    Dim Interval As String
    Dim TIC As String
    Dim TC As String
    Dim ID As String
    Dim IDPER As String
    Dim check As String
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim comm3 As SqlCommand
    Dim comm4 As SqlCommand
    Dim reader As SqlDataReader

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Hide()
        Dashboard.Show()
    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adapman As New SqlDataAdapter("SELECT ID_PER,NM_PER FROM PERUSAHAAN", conn)
        Dim dtPER As New DataTable
        adapman.Fill(dtPER)

        ComboBox1.DataSource = dtPER
        ComboBox1.DisplayMember = "NM_PER"
        ComboBox1.ValueMember = "NM_PER"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        conn.Open()

        comm3 = New SqlCommand
        comm3.Connection = conn
        comm3.CommandType = CommandType.Text
        comm3.CommandText = "SELECT (COUNT(id_hasil)+1) FROM Hasil_EOQ"
        ID = comm3.ExecuteScalar

        comm4 = New SqlCommand
        comm4.Connection = conn
        comm4.CommandType = CommandType.Text
        comm4.CommandText = "SELECT ID_PER FROM PERUSAHAAN WHERE NM_PER ='" & ComboBox1.SelectedValue & "'"
        IDPER = comm4.ExecuteScalar


        Try
            comm = New SqlCommand
            comm.Connection = conn
            comm.CommandType = CommandType.Text
            comm.CommandText = "SELECT COUNT(ID_Hasil) FROM Hasil_EOQ WHERE ID_Hasil='" & ID & "'"
            check = comm.ExecuteScalar
            If check = 0 Then
                Try
                    'Qoptimum()
                    Qop = (2 * Stxt.Text * Dtxt.Text / Htxt.Text)
                    HasilQop = Round(Sqrt(Qop), 2)

                    'Frekuensi()
                    Fre = Round((Dtxt.Text / HasilQop), 0)

                    'Interval()
                    Interval = Round((Atxt.Text / Fre), 0)

                    'TC()
                    TC = Round((((HasilQop / 2) * Htxt.Text) + ((Dtxt.Text / HasilQop) * Stxt.Text)), 0)

                    'TIC()
                    TIC = Round((((HasilQop / 2) * Htxt.Text) + ((Dtxt.Text / HasilQop) * Stxt.Text) + (Ptxt.Text * Dtxt.Text)), 0)

                    comm2 = New SqlCommand
                    comm2.Connection = conn
                    comm2.CommandType = CommandType.Text
                    comm2.CommandText = "INSERT INTO HASIL_EOQ VALUES ('" & ID & "', '" & IDPER & "', '" & Dtxt.Text & "', '" & Atxt.Text & "', '" & Stxt.Text & "','" & Htxt.Text & "','" & Ptxt.Text & "','" & HasilQop & "','" & TIC & "','" & Interval & "','" & Fre & "','" & TC & "','" & tahun.Text & "')"
                    comm2.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Simpan")

                    Label1.Text = ComboBox1.SelectedValue
                    D.Text = Dtxt.Text
                    S.Text = Stxt.Text
                    H.Text = Htxt.Text
                    P.Text = Ptxt.Text
                    A.Text = Atxt.Text
                    Label35.Text = HasilQop
                    Label36.Text = Fre
                    Label37.Text = Interval
                    Label38.Text = TC
                    Label39.Text = TIC

                Catch ex As Exception
                    MsgBox("maaf data tidak bisa masuk")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Terjadi Eror bos")
        End Try

        conn.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim adapman As New SqlDataAdapter("SELECT ID_PER,NM_PER FROM PERUSAHAAN", conn)
        Dim dtPER As New DataTable
        adapman.Fill(dtPER)

        ComboBox1.DataSource = dtPER
        ComboBox1.DisplayMember = "NM_PER"
        ComboBox1.ValueMember = "NM_PER"
    End Sub
End Class