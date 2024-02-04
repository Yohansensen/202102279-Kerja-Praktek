Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Formbarang
    Dim comtambah, comtampil, comdelete, comsimpan, comupd As New MySqlCommand
    Dim adapbarang As New MySqlDataAdapter
    Dim dabelbarang As New DataTable
    Dim conn As New koneksi
    Dim tampilsql As String
    Dim kode_ As String

    Sub tampilanbarang()
        dabelbarang.Clear()
        comtampil.Connection = conn.koneksi
        tampilsql = "SELECT * FROM view_barang"
        Try
            comtampil.CommandText = tampilsql
            adapbarang.SelectCommand = comtampil
            adapbarang.Fill(dabelbarang)
            DataGridView1.DataSource = dabelbarang
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow

        Catch ex As Exception
        Finally
            conn.koneksi.Dispose()
            conn.koneksi.Close()
        End Try
    End Sub

    Private Sub FormDosen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call tampilanbarang()
    End Sub
    Sub clearbarang()
        txtkode.Text = ""
        txtnama.Text = ""
        txttinggi.Text = ""
        txtlebar.Text = ""
        txtpanjang.Text = ""
        rbya.Checked = False
        rbtidak.Checked = False
    End Sub

    Sub deletebarang()
        Dim hasil As Integer
        Dim hapus As MsgBoxResult
        Dim sqlhapus As String
        comdelete.Parameters.Clear()
        If (txtkode.Text <> "") Then
            hapus = MessageBox.Show("Yakin data dihapus?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If hapus = MsgBoxResult.Yes Then
                sqlhapus = "DELETE FROM tb_barang WHERE (kode='" & txtkode.Text & "')"
                Try
                    comdelete.Connection = conn.koneksi
                    comdelete.CommandText = sqlhapus
                    hasil = comdelete.ExecuteNonQuery()
                    If hasil > 0 Then
                        MessageBox.Show("Record berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call tampilanbarang()
                        Call clearbarang()
                    End If
                Catch ex As Exception
                Finally
                    comdelete.Dispose()
                    conn.koneksi.Dispose()
                    conn.koneksi.Clone()
                End Try
            End If
        End If
    End Sub

    Private Sub Formbarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call tampilanbarang()
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim hasil As Integer
        Dim rotasi, sql As String
        comtambah.Parameters.Clear()
        If (txtkode.Text <> "" And txtnama.Text <> "") Then
            sql = "INSERT INTO tb_barang (kode, nama, tinggi, lebar, panjang, rotasi)" & _
                "VALUES (@kode, @nama, @tinggi, @lebar, @panjang, @rotasi)"
            Try
                comtambah.Connection = conn.koneksi
                comtambah.CommandText = sql
                comtambah.Parameters.Add("@kode", MySqlDbType.String, 9).Value = txtkode.Text
                comtambah.Parameters.Add("@nama", MySqlDbType.String, 9).Value = txtnama.Text
                comtambah.Parameters.Add("@tinggi", MySqlDbType.String, 9).Value = txttinggi.Text
                comtambah.Parameters.Add("@lebar", MySqlDbType.String, 9).Value = txtlebar.Text
                comtambah.Parameters.Add("@panjang", MySqlDbType.String, 9).Value = txtpanjang.Text
                If rbya.Checked = True Then
                    rotasi = "YA"
                Else
                    rotasi = "TIDAK"
                End If
                comtambah.Parameters.Add("@rotasi", MySqlDbType.String, 9).Value = rotasi
                hasil = comtambah.ExecuteNonQuery()
                If hasil > 0 Then
                    MessageBox.Show("Record Berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtkode.Focus()

                    Call tampilanbarang()
                    Call clearbarang()
                End If
            Catch ex As Exception
            Finally
                comtambah.Dispose()
                conn.koneksi.Close()
            End Try
        Else
            MessageBox.Show("Data Belum Lengkap", "Informasi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Call deletebarang()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Dim rotasi As String

        If (DataGridView1.SelectedRows.Count > 0) Then
            kode_ = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString()
            txtkode.Text = kode_
            txtnama.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString()
            txttinggi.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString()
            txtlebar.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString()
            txtpanjang.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString()


            rotasi = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString()

            If (rotasi = "YA") Then
                rbya.Checked = True
            Else
                rbtidak.Checked = True
            End If
        End If


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim hasil As Integer
        Dim rotasi, sqlsimpan As String

        comsimpan.Parameters.Clear()
        If (txtkode.Text <> "" And txtnama.Text <> "") Then
            sqlsimpan = "UPDATE tb_barang SET nama=@nama,tinggi=@tinggi,lebar=@lebar,panjang=@panjang,rotasi=@rotasi WHERE (kode='" & txtkode.Text & "')"
            Try
                comsimpan.Connection = conn.koneksi
                comsimpan.CommandText = sqlsimpan
                comsimpan.Parameters.Add("@nama", MySqlDbType.String, 60).Value = txtnama.Text
                comsimpan.Parameters.Add("@tinggi", MySqlDbType.LongText, 0).Value = txttinggi.Text
                comsimpan.Parameters.Add("@lebar", MySqlDbType.String, 20).Value = txtlebar.Text
                comsimpan.Parameters.Add("@panjang", MySqlDbType.String, 20).Value = txtpanjang.Text
                If rbya.Checked = True Then
                    rotasi = "YA"
                Else
                    rotasi = "TIDAK"
                End If
                comsimpan.Parameters.Add("@rotasi", MySqlDbType.String, 15).Value = rotasi
                hasil = comsimpan.ExecuteNonQuery()
                If hasil > 0 Then
                    MessageBox.Show("Record berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call tampilanbarang()
                    Call clearbarang()
                End If
            Catch ex As Exception
            Finally
                comsimpan.Dispose()
                conn.koneksi.Dispose()
                conn.koneksi.Clone()
            End Try
        End If
    End Sub

    Private Sub btnundo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnundo.Click
        txtkode.Text = ""
        txtnama.Text = ""
        txttinggi.Text = ""
        txtlebar.Text = ""
        txtpanjang.Text = ""
        rbya.Checked = False
        rbtidak.Checked = False
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()
    End Sub

  
End Class