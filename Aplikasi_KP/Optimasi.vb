﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Optimasi
    Dim PopulationSize As Integer = 10
    Dim Dimension As Integer = 3
    Dim MaxIterations As Integer = 5

    Private hasilOptimasiList As New List(Of HasilOptimasi)
    Private Positions As New List(Of List(Of Double))
    Private Velocities As New List(Of List(Of Double))
    Private PbestPositions As New List(Of List(Of Double))
    Private GbestPosition As New List(Of Double)

    Dim conn As New koneksi

    Private WithEvents backgroundWorkerOptimasi As New BackgroundWorker()


    Private Sub DisplayResultsInDataGridView()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("k", "Kode")
        DataGridView1.Columns.Add("p", "Nama Barang")
        DataGridView1.Columns.Add("posx", "Posisi X")
        DataGridView1.Columns.Add("posy", "Posisi Y")
        DataGridView1.Columns.Add("posz", "Posisi Z")
        DataGridView1.Columns.Add("r", "Rotasi")
        DataGridView1.Columns.Add("v", "Volume")

        ' Mengatur format angka dengan dua digit di belakang koma untuk kolom PosisiX, PosisiY, PosisiZ, dan Volume
        For Each kolom As DataGridViewColumn In DataGridView1.Columns
            If kolom.Name.StartsWith("pos") OrElse kolom.Name = "v" Then
                kolom.DefaultCellStyle.Format = "N2" ' N2 untuk format numerik dengan dua digit di belakang koma
            End If
        Next

        For Each hasilBarang In hasilOptimasiList
            DataGridView1.Rows.Add(
            hasilBarang.KodeBarang,
            hasilBarang.NamaBarang,
            hasilBarang.PosisiX,
            hasilBarang.PosisiY,
            hasilBarang.PosisiZ,
            IIf(hasilBarang.Rotasi, "Ya", "Tidak"),
            hasilBarang.Volume
        )
        Next
    End Sub

    ' Mendapatkan dimensi mobil dari database berdasarkan nomor plat
    Private Function GetDimensiMobilFromDatabase(nomorPlat As String) As Tuple(Of Double, Double, Double)
        ' Query database untuk mendapatkan dimensi mobil
        ' Sesuaikan query ini dengan struktur tabel tb_mobil
        Using connection As MySqlConnection = conn.koneksi()
            'connection.Open()

            ' Sesuaikan query berdasarkan struktur tabel tb_mobil
            Dim query As String = "SELECT lebarmobil, tinggimobil, panjangmobil FROM tb_mobil WHERE kb = @kb"
            Using sqlCommand As New MySqlCommand(query, connection)
                sqlCommand.Parameters.AddWithValue("@kb", nomorPlat)

                Using reader As MySqlDataReader = sqlCommand.ExecuteReader()
                    If reader.Read() Then
                        ' Membaca dimensi mobil dari database
                        Dim lebar As Double = Convert.ToDouble(reader("lebarmobil"))
                        Dim tinggi As Double = Convert.ToDouble(reader("tinggimobil"))
                        Dim panjang As Double = Convert.ToDouble(reader("panjangmobil"))

                        ' Mengembalikan Tuple lebar, tinggi, dan panjang
                        Return Tuple.Create(lebar, tinggi, panjang)
                    End If
                End Using
            End Using
        End Using

        ' Jika tidak ada data ditemukan, kembalikan Nothing
        Return Nothing
    End Function

    ' Mendapatkan dimensi barang dari database berdasarkan ID barang
    Private Function GetDimensiBarangFromDatabase(idBarang As Integer) As Tuple(Of Double, Double, Double)
        ' Query database untuk mendapatkan dimensi barang
        ' Sesuaikan query ini dengan struktur tabel tb_barang
        Using connection As MySqlConnection = conn.koneksi()
            'connection.Open()

            ' Sesuaikan query berdasarkan struktur tabel tb_barang
            Dim query As String = "SELECT lebar, tinggi, panjang FROM tb_barang WHERE kode = @kode"
            Using sqlCommand As New MySqlCommand(query, connection)
                sqlCommand.Parameters.AddWithValue("@kode", idBarang)

                Using reader As MySqlDataReader = sqlCommand.ExecuteReader()
                    If reader.Read() Then
                        ' Membaca dimensi barang dari database
                        Dim lebar As Double = Convert.ToDouble(reader("lebar"))
                        Dim tinggi As Double = Convert.ToDouble(reader("tinggi"))
                        Dim panjang As Double = Convert.ToDouble(reader("panjang"))

                        ' Mengembalikan objek Tuple lebar, tinggi, dan panjang
                        Return Tuple.Create(lebar, tinggi, panjang)
                    End If
                End Using
            End Using
        End Using

        ' Jika tidak ada data ditemukan, kembalikan Nothing
        Return Nothing
    End Function


    Private Function ObjectiveFunction(position As List(Of Double)) As Double

        Dim dimensiMobil As Tuple(Of Double, Double, Double)

        Me.Invoke(Sub() dimensiMobil = GetDimensiMobilFromDatabase(cbNomorPlat.SelectedItem.ToString()))

        If dimensiMobil IsNot Nothing Then
            ' Inisialisasi variabel total volume
            Dim totalVolume As Double = 0

            ' Iterasi untuk setiap partikel (barang)
            For i As Integer = 0 To PopulationSize - 1
                ' Koordinat partikel (posisi barang)
                Dim x As Double
                Dim y As Double
                Dim z As Double

                ' Pastikan indeks dalam range
                If i * 3 < position.Count Then
                    x = position(i * 3) ' x
                Else
                    ' Jika indeks keluar dari range, atur ke nilai default atau ambil tindakan yang sesuai
                    x = 0
                End If

                ' Pastikan indeks dalam range
                If i * 3 + 1 < position.Count Then
                    y = position(i * 3 + 1) ' y
                Else
                    ' Jika indeks keluar dari range, atur ke nilai default atau ambil tindakan yang sesuai
                    y = 0
                End If

                ' Pastikan indeks dalam range
                If i * 3 + 2 < position.Count Then
                    z = position(i * 3 + 2) ' z
                Else
                    ' Jika indeks keluar dari range, atur ke nilai default atau ambil tindakan yang sesuai
                    z = 0
                End If

                ' Mengambil dimensi barang dari database (tb_barang)
                Dim dimensiBarang As Tuple(Of Double, Double, Double) = GetDimensiBarangFromDatabase(i + 1)

                If dimensiBarang IsNot Nothing Then
                    ' Hitung volume barang
                    Dim volumeBarang As Double = dimensiBarang.Item1 * dimensiBarang.Item2 * dimensiBarang.Item3

                    ' Hitung total volume (maksimalkan penggunaan ruang)
                    totalVolume += volumeBarang
                End If
            Next

            ' Hitung sisa ruang di dalam mobil
            Dim sisaVolume As Double = dimensiMobil.Item1 * dimensiMobil.Item2 * dimensiMobil.Item3 - totalVolume

            Return sisaVolume
        End If

        Return 0
    End Function




    Private Sub InitializePSO(nomorPlat As String)
        Dim rand As New Random()

        Dim dimensiMobil As Tuple(Of Double, Double, Double) = GetDimensiMobilFromDatabase(nomorPlat)

        If dimensiMobil IsNot Nothing Then
            For i As Integer = 0 To PopulationSize - 1
                Dim position As New List(Of Double) From {
                    rand.NextDouble() * dimensiMobil.Item2, ' x (lebar)
                    rand.NextDouble() * dimensiMobil.Item1, ' y (tinggi)
                    rand.NextDouble() * dimensiMobil.Item3  ' z (panjang)
                }

                Dim velocity As New List(Of Double) From {
                    rand.NextDouble(),
                    rand.NextDouble(),
                    rand.NextDouble()
                }

                Positions.Add(position)
                Velocities.Add(velocity)
                PbestPositions.Add(New List(Of Double)(position))
            Next
        End If
    End Sub

    ' Iterasi PSO
    Private Sub PSOIteration()
        Dim rand As New Random()

        Dim listBarang As List(Of HasilOptimasi) = GetBarangDataFromDatabase()

        For i As Integer = 0 To PopulationSize - 1
            ' Koordinat partikel (posisi barang)
            Dim x As Double
            Dim y As Double
            Dim z As Double

            ' Pastikan indeks dalam range
            If i * 3 < Positions.Count Then
                x = Positions(i)(0) ' x
            Else
                x = 0
            End If

            ' Pastikan indeks dalam range
            If i * 3 + 1 < Positions.Count Then
                y = Positions(i)(1) ' y
            Else

                y = 0
            End If

            ' Pastikan indeks dalam range
            If i * 3 + 2 < Positions.Count Then
                z = Positions(i)(2) ' z
            Else
                z = 0
            End If

            ' Hitung kebugaran (nilai objektif) saat ini
            Dim currentFitness As Double = ObjectiveFunction(Positions(i))

            ' Hitung kebugaran terbaik pribadi saat ini
            Dim currentPbestFitness As Double = ObjectiveFunction(PbestPositions(i))

            ' Inisialisasi GBest jika masih kosong
            If GbestPosition.Count = 0 Then
                GbestPosition = New List(Of Double)(Positions(i))
            End If

            ' Hitung kebugaran terbaik global saat ini
            Dim currentGbestFitness As Double = ObjectiveFunction(GbestPosition)

            ' Memperbarui PBest jika ditemukan solusi yang lebih baik
            If currentFitness > currentPbestFitness Then
                PbestPositions(i) = New List(Of Double)(Positions(i))
            End If

            ' Memperbarui GBest jika ditemukan solusi yang lebih baik
            If currentFitness > currentGbestFitness Then
                GbestPosition = New List(Of Double)(Positions(i))
            End If

            ' Update velocity and position
            For j As Integer = 0 To Dimension - 1
                Dim inertia As Double = 0.5
                Dim c1 As Double = 2.0
                Dim c2 As Double = 2.0

                Velocities(i)(j) = inertia * Velocities(i)(j) +
                               rand.NextDouble() * c1 * (PbestPositions(i)(j) - Positions(i)(j)) +
                               rand.NextDouble() * c2 * (GbestPosition(j) - Positions(i)(j))

                Positions(i)(j) = Positions(i)(j) + Velocities(i)(j)
            Next
            Dim volume As Double = HitungVolumeBarang(x, y, z)
            hasilOptimasiList.Add(New HasilOptimasi With {
            .KodeBarang = If(i < listBarang.Count, listBarang(i).KodeBarang, "KodeDefault"),
            .NamaBarang = If(i < listBarang.Count, listBarang(i).NamaBarang, "BarangDefault"),
            .PosisiX = x,
            .PosisiY = y,
            .PosisiZ = z,
            .Rotasi = If(i < listBarang.Count, listBarang(i).Rotasi, False),
            .Volume = volume
        })
        Next
    End Sub

    ' Fungsi untuk menghitung volume barang berdasarkan posisi XYZ
    Private Function HitungVolumeBarang(panjang As Double, lebar As Double, tinggi As Double) As Double
        Return panjang * lebar * tinggi
    End Function


    Private Function GetBarangDataFromDatabase() As List(Of HasilOptimasi)
        Dim listBarang As New List(Of HasilOptimasi)

        Using connection As MySqlConnection = conn.koneksi

            Dim query As String = "SELECT kode, nama, rotasi FROM tb_barang"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim hasilBarang As New HasilOptimasi()
                        hasilBarang.KodeBarang = reader("kode").ToString()
                        hasilBarang.NamaBarang = reader("nama").ToString()
                        hasilBarang.Rotasi = IIf(reader("rotasi").ToString().Trim().ToLower() = "ya", True, False)

                        ' ... (Tambahkan informasi lainnya sesuai kebutuhan)
                        listBarang.Add(hasilBarang)
                    End While
                End Using
            End Using
        End Using

        Return listBarang
    End Function


    Private Sub Optimasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMobilDataToComboBox()

        ' Inisialisasi komponen dan atur properti ProgressBar
        ProgressBarOptimasi.Minimum = 0
        ProgressBarOptimasi.Maximum = MaxIterations
        ProgressBarOptimasi.Step = 1

        ' Konfigurasi BackgroundWorker
        backgroundWorkerOptimasi.WorkerReportsProgress = True
        backgroundWorkerOptimasi.WorkerSupportsCancellation = True
    End Sub

    ' Mengisi ComboBox dengan data mobil dari tabel tb_mobil
    Private Sub LoadMobilDataToComboBox()
        Using connection As MySqlConnection = conn.koneksi()
            'connection.Open()

            Using sqlCommand As New MySqlCommand("SELECT kb FROM tb_mobil", connection)
                Using reader As MySqlDataReader = sqlCommand.ExecuteReader()
                    While reader.Read()
                        cbNomorPlat.Items.Add(reader("kb").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnOptimasi_Click(sender As Object, e As EventArgs) Handles btnOptimasi.Click


        ' Pastikan ada nomor plat yang dipilih
        If cbNomorPlat.SelectedItem IsNot Nothing Then
            statusText.Text = "Memulai optimisasi..."
            ' Jalankan proses optimasi di latar belakang
            backgroundWorkerOptimasi.RunWorkerAsync()
        Else
            MessageBox.Show("Pilih nomor plat mobil terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event yang dipicu ketika proses optimasi dimulai
    Private Sub backgroundWorkerOptimasi_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundWorkerOptimasi.DoWork
        ' Inisialisasi PSO
        Me.Invoke(Sub() InitializePSO(cbNomorPlat.SelectedItem.ToString()))

        ' Iterasi PSO
        For iteration As Integer = 1 To MaxIterations
            PSOIteration()

            ' Laporan kemajuan ke ProgressBar
            backgroundWorkerOptimasi.ReportProgress(iteration)
        Next

        ' Tampilkan hasil PSO di DataGridView
        Me.Invoke(Sub() DisplayResultsInDataGridView())

    End Sub

    ' Event yang dipicu ketika ada pembaruan kemajuan
    Private Sub backgroundWorkerOptimasi_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles backgroundWorkerOptimasi.ProgressChanged
        ' Perbarui nilai ProgressBar
        ProgressBarOptimasi.Value = e.ProgressPercentage

        ' Tambahan: Tampilkan status atau informasi kemajuan di label atau tempat lain
        statusText.Text = $"Iteration {e.ProgressPercentage} of {MaxIterations}"
    End Sub

    ' Event yang dipicu ketika proses optimasi selesai
    Private Sub backgroundWorkerOptimasi_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles backgroundWorkerOptimasi.RunWorkerCompleted
        ' Lakukan tindakan yang diperlukan ketika proses selesai, misalnya, tampilkan pesan, atur kontrol, dll.

        ' Tambahan: Tampilkan pesan atau status akhir di label atau tempat lain
        statusText.Text = "Optimization completed!"
    End Sub
End Class