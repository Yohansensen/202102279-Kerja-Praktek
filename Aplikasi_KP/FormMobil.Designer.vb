<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMobil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMobil))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnundo = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtpanjangm = New System.Windows.Forms.TextBox()
        Me.txtlebarm = New System.Windows.Forms.TextBox()
        Me.txtnamasupir = New System.Windows.Forms.TextBox()
        Me.txtkb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txttinggim = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtcarimobil = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Azure
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnexit.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.btnexit.Image = CType(resources.GetObject("btnexit.Image"), System.Drawing.Image)
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnexit.Location = New System.Drawing.Point(275, 345)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(60, 60)
        Me.btnexit.TabIndex = 16
        Me.btnexit.Text = "Exit"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnundo
        '
        Me.btnundo.BackColor = System.Drawing.Color.Azure
        Me.btnundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnundo.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.btnundo.Image = CType(resources.GetObject("btnundo.Image"), System.Drawing.Image)
        Me.btnundo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnundo.Location = New System.Drawing.Point(209, 345)
        Me.btnundo.Name = "btnundo"
        Me.btnundo.Size = New System.Drawing.Size(60, 60)
        Me.btnundo.TabIndex = 15
        Me.btnundo.Text = "Undo"
        Me.btnundo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnundo.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Azure
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsave.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsave.Location = New System.Drawing.Point(143, 345)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(60, 60)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Azure
        Me.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnadd.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnadd.Location = New System.Drawing.Point(11, 345)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(60, 60)
        Me.btnadd.TabIndex = 13
        Me.btnadd.Text = "Add"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Azure
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndelete.Location = New System.Drawing.Point(77, 345)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(60, 60)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'txtpanjangm
        '
        Me.txtpanjangm.Location = New System.Drawing.Point(109, 309)
        Me.txtpanjangm.Name = "txtpanjangm"
        Me.txtpanjangm.Size = New System.Drawing.Size(226, 20)
        Me.txtpanjangm.TabIndex = 9
        '
        'txtlebarm
        '
        Me.txtlebarm.Location = New System.Drawing.Point(109, 283)
        Me.txtlebarm.Name = "txtlebarm"
        Me.txtlebarm.Size = New System.Drawing.Size(226, 20)
        Me.txtlebarm.TabIndex = 8
        '
        'txtnamasupir
        '
        Me.txtnamasupir.Location = New System.Drawing.Point(109, 231)
        Me.txtnamasupir.Name = "txtnamasupir"
        Me.txtnamasupir.Size = New System.Drawing.Size(226, 20)
        Me.txtnamasupir.TabIndex = 6
        '
        'txtkb
        '
        Me.txtkb.Location = New System.Drawing.Point(109, 205)
        Me.txtkb.Name = "txtkb"
        Me.txtkb.Size = New System.Drawing.Size(226, 20)
        Me.txtkb.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.Label6.Location = New System.Drawing.Point(12, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Panjang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.btnundo)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.txtpanjangm)
        Me.Panel1.Controls.Add(Me.txtlebarm)
        Me.Panel1.Controls.Add(Me.txttinggim)
        Me.Panel1.Controls.Add(Me.txtnamasupir)
        Me.Panel1.Controls.Add(Me.txtkb)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 610)
        Me.Panel1.TabIndex = 15
        '
        'txttinggim
        '
        Me.txttinggim.Location = New System.Drawing.Point(109, 257)
        Me.txttinggim.Name = "txttinggim"
        Me.txttinggim.Size = New System.Drawing.Size(226, 20)
        Me.txttinggim.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.Label5.Location = New System.Drawing.Point(12, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Lebar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.Label4.Location = New System.Drawing.Point(12, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tinggi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.Label3.Location = New System.Drawing.Point(12, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.Label1.Location = New System.Drawing.Point(12, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KB Mobil"
        '
        'DataGridView2
        '
        Me.DataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(16, 51)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(581, 481)
        Me.DataGridView2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.Label7.Location = New System.Drawing.Point(13, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cari Mobil"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(360, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(616, 53)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "DATA MOBIL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Controls.Add(Me.txtcarimobil)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(360, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(616, 547)
        Me.Panel3.TabIndex = 16
        '
        'txtcarimobil
        '
        Me.txtcarimobil.Location = New System.Drawing.Point(84, 14)
        Me.txtcarimobil.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcarimobil.Name = "txtcarimobil"
        Me.txtcarimobil.Size = New System.Drawing.Size(122, 20)
        Me.txtcarimobil.TabIndex = 1
        '
        'FormMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 610)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMobil"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Mobil"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnundo As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents txtpanjangm As System.Windows.Forms.TextBox
    Friend WithEvents txtlebarm As System.Windows.Forms.TextBox
    Friend WithEvents txtnamasupir As System.Windows.Forms.TextBox
    Friend WithEvents txtkb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txttinggim As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtcarimobil As System.Windows.Forms.TextBox
End Class
