Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormMobil
    Dim comtambah, comtampil, comdelete, comsimpan, comupd As New MySqlCommand
    Dim adapmobil As New MySqlDataAdapter
    Dim dabelmobil As New DataTable
    Dim conn As New koneksi
    Dim tampilsql As String
    Dim kb_ As String


    Sub tampilanmobil()
        dabelmobil.Clear()
        comtampil.Connection = conn.koneksi
        tampilsql = "SELECT * FROM view_mobil"
        Try
            comtampil.CommandText = tampilsql
            adapmobil.SelectCommand = comtampil
            adapmobil.Fill(dabelmobil)
            DataGridView2.DataSource = dabelmobil
            DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow

        Catch ex As Exception
        Finally
            conn.koneksi.Dispose()
            conn.koneksi.Close()
        End Try
    End Sub

    Sub clearmobil()
        txtkb.Text = ""
        txtnamasupir.Text = ""
        txttinggim.Text = ""
        txtlebarm.Text = ""
        txtpanjangm.Text = ""
    End Sub

    Sub deletemobil()
        Dim hasil As Integer
        Dim hapus As MsgBoxResult
        Dim sqlhapus As String
        comdelete.Parameters.Clear()
        If (txtkb.Text <> "") Then
            hapus = MessageBox.Show("Yakin data dihapus?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If hapus = MsgBoxResult.Yes Then
                sqlhapus = "DELETE FROM tb_mobil WHERE (kb='" & txtkb.Text & "')"
                Try
                    comdelete.Connection = conn.koneksi
                    comdelete.CommandText = sqlhapus
                    hasil = comdelete.ExecuteNonQuery()
                    If hasil > 0 Then
                        MessageBox.Show("Record berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call tampilanmobil()
                        Call clearmobil()
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

    Private Sub FormMobil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call tampilanmobil()
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim hasil As Integer
        Dim sql As String
        comtambah.Parameters.Clear()
        If (txtkb.Text <> "" And txtnamasupir.Text <> "") Then
            sql = "INSERT INTO tb_mobil (kb, namasupir, tinggimobil, lebarmobil, panjangmobil)" & _
                "VALUES (@kb, @namasupir, @tinggimobil, @lebarmobil, @panjangmobil)"
            Try
                comtambah.Connection = conn.koneksi
                comtambah.CommandText = sql
                comtambah.Parameters.Add("@kb", MySqlDbType.String, 10).Value = txtkb.Text
                comtambah.Parameters.Add("@namasupir", MySqlDbType.String, 9).Value = txtnamasupir.Text
                comtambah.Parameters.Add("@tinggimobil", MySqlDbType.String, 9).Value = txttinggim.Text
                comtambah.Parameters.Add("@lebarmobil", MySqlDbType.String, 9).Value = txtlebarm.Text
                comtambah.Parameters.Add("@panjangmobil", MySqlDbType.String, 9).Value = txtpanjangm.Text

                hasil = comtambah.ExecuteNonQuery()
                If hasil > 0 Then
                    MessageBox.Show("Record Berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtkb.Focus()

                    Call clearmobil()
                    Call tampilanmobil()

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
        Call deletemobil()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.SelectionChanged

        If (DataGridView2.SelectedRows.Count > 0) Then
            kb_ = DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value.ToString()
            txtkb.Text = kb_
            txtnamasupir.Text = DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value.ToString()
            txttinggim.Text = DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value.ToString()
            txtlebarm.Text = DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value.ToString()
            txtpanjangm.Text = DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value.ToString()
          
        End If


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim hasil As Integer
        Dim sqlsimpan As String

        comsimpan.Parameters.Clear()
        If (txtkb.Text <> "" And txtnamasupir.Text <> "") Then
            sqlsimpan = "UPDATE tb_mobil SET namasupir=@namasupir,tinggimobil=@tinggimobil,lebarmobil=@lebarmobil,panjangmobil=@panjangmobil WHERE (kb='" & txtkb.Text & "')"
            Try
                comsimpan.Connection = conn.koneksi
                comsimpan.CommandText = sqlsimpan
                comsimpan.Parameters.Add("@namasupir", MySqlDbType.String, 60).Value = txtnamasupir.Text
                comsimpan.Parameters.Add("@tinggimobil", MySqlDbType.LongText, 0).Value = txttinggim.Text
                comsimpan.Parameters.Add("@lebarmobil", MySqlDbType.String, 20).Value = txtlebarm.Text
                comsimpan.Parameters.Add("@panjangmobil", MySqlDbType.String, 20).Value = txtpanjangm.Text

                hasil = comsimpan.ExecuteNonQuery()
                If hasil > 0 Then
                    MessageBox.Show("Record berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call clearmobil()
                    Call tampilanmobil()

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
        txtkb.Text = ""
        txtnamasupir.Text = ""
        txttinggim.Text = ""
        txtlebarm.Text = ""
        txtpanjangm.Text = ""
      
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Close()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class