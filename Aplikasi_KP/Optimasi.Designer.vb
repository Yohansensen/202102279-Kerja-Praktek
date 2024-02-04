<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Optimasi
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbNomorPlat = New System.Windows.Forms.ComboBox()
        Me.btnOptimasi = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBarOptimasi = New System.Windows.Forms.ToolStripProgressBar()
        Me.gbOptimasi = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.gbOptimasi.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(235, 11)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(890, 533)
        Me.DataGridView1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No. Plat"
        '
        'cbNomorPlat
        '
        Me.cbNomorPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNomorPlat.FormattingEnabled = True
        Me.cbNomorPlat.Location = New System.Drawing.Point(57, 27)
        Me.cbNomorPlat.Name = "cbNomorPlat"
        Me.cbNomorPlat.Size = New System.Drawing.Size(132, 21)
        Me.cbNomorPlat.TabIndex = 3
        '
        'btnOptimasi
        '
        Me.btnOptimasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOptimasi.Location = New System.Drawing.Point(9, 65)
        Me.btnOptimasi.Name = "btnOptimasi"
        Me.btnOptimasi.Size = New System.Drawing.Size(180, 30)
        Me.btnOptimasi.TabIndex = 4
        Me.btnOptimasi.Text = "Optimasi"
        Me.btnOptimasi.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusText, Me.ProgressBarOptimasi})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 558)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1136, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusText
        '
        Me.statusText.Name = "statusText"
        Me.statusText.Size = New System.Drawing.Size(26, 17)
        Me.statusText.Text = "Idle"
        '
        'ProgressBarOptimasi
        '
        Me.ProgressBarOptimasi.Name = "ProgressBarOptimasi"
        Me.ProgressBarOptimasi.Size = New System.Drawing.Size(100, 16)
        '
        'gbOptimasi
        '
        Me.gbOptimasi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbOptimasi.Controls.Add(Me.Label2)
        Me.gbOptimasi.Controls.Add(Me.cbNomorPlat)
        Me.gbOptimasi.Controls.Add(Me.btnOptimasi)
        Me.gbOptimasi.Location = New System.Drawing.Point(12, 234)
        Me.gbOptimasi.Name = "gbOptimasi"
        Me.gbOptimasi.Size = New System.Drawing.Size(202, 112)
        Me.gbOptimasi.TabIndex = 7
        Me.gbOptimasi.TabStop = False
        Me.gbOptimasi.Text = "Konfigurasi Optimasi"
        '
        'Optimasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 580)
        Me.Controls.Add(Me.gbOptimasi)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Optimasi"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Optimasi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbOptimasi.ResumeLayout(False)
        Me.gbOptimasi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbNomorPlat As ComboBox
    Friend WithEvents btnOptimasi As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusText As ToolStripStatusLabel
    Friend WithEvents ProgressBarOptimasi As ToolStripProgressBar
    Friend WithEvents gbOptimasi As GroupBox
End Class
