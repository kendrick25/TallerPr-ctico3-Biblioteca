<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarLibros1
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Data2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.borrarLibro = New System.Windows.Forms.Button()
        Me.comboToDelete = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.data3 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deleteSinLibro = New System.Windows.Forms.Button()
        Me.autoresSinLibro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnFinalizarEliminar = New System.Windows.Forms.Button()
        CType(Me.Data2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.data3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Data2
        '
        Me.Data2.AllowUserToAddRows = False
        Me.Data2.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.Data2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Data2.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.Data2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Data2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Data2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Data2.ColumnHeadersHeight = 29
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Data2.DefaultCellStyle = DataGridViewCellStyle9
        Me.Data2.Location = New System.Drawing.Point(344, 40)
        Me.Data2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Data2.Name = "Data2"
        Me.Data2.ReadOnly = True
        Me.Data2.RowHeadersVisible = False
        Me.Data2.RowHeadersWidth = 51
        Me.Data2.RowTemplate.Height = 29
        Me.Data2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data2.Size = New System.Drawing.Size(410, 225)
        Me.Data2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.borrarLibro)
        Me.GroupBox1.Controls.Add(Me.comboToDelete)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(276, 148)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eliminar Ejemplar"
        '
        'borrarLibro
        '
        Me.borrarLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.borrarLibro.Location = New System.Drawing.Point(83, 100)
        Me.borrarLibro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.borrarLibro.Name = "borrarLibro"
        Me.borrarLibro.Size = New System.Drawing.Size(94, 34)
        Me.borrarLibro.TabIndex = 2
        Me.borrarLibro.Text = "Eliminar"
        Me.borrarLibro.UseVisualStyleBackColor = False
        '
        'comboToDelete
        '
        Me.comboToDelete.FormattingEnabled = True
        Me.comboToDelete.Location = New System.Drawing.Point(71, 38)
        Me.comboToDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboToDelete.Name = "comboToDelete"
        Me.comboToDelete.Size = New System.Drawing.Size(184, 29)
        Me.comboToDelete.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elige"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(451, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "EJEMPLARES DISPONIBLES"
        '
        'data3
        '
        Me.data3.AllowUserToAddRows = False
        Me.data3.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.data3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.data3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data3.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.data3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.data3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.data3.ColumnHeadersHeight = 29
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data3.DefaultCellStyle = DataGridViewCellStyle12
        Me.data3.Location = New System.Drawing.Point(344, 320)
        Me.data3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data3.Name = "data3"
        Me.data3.ReadOnly = True
        Me.data3.RowHeadersVisible = False
        Me.data3.RowHeadersWidth = 51
        Me.data3.RowTemplate.Height = 29
        Me.data3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data3.Size = New System.Drawing.Size(410, 57)
        Me.data3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(451, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "EJEMPLARES PRESTADOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.deleteSinLibro)
        Me.GroupBox2.Controls.Add(Me.autoresSinLibro)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 224)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(270, 182)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Autores sin ejemplares"
        '
        'deleteSinLibro
        '
        Me.deleteSinLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deleteSinLibro.Location = New System.Drawing.Point(77, 95)
        Me.deleteSinLibro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deleteSinLibro.Name = "deleteSinLibro"
        Me.deleteSinLibro.Size = New System.Drawing.Size(94, 37)
        Me.deleteSinLibro.TabIndex = 1
        Me.deleteSinLibro.Text = "CLEAN"
        Me.deleteSinLibro.UseVisualStyleBackColor = False
        '
        'autoresSinLibro
        '
        Me.autoresSinLibro.FormattingEnabled = True
        Me.autoresSinLibro.Location = New System.Drawing.Point(38, 48)
        Me.autoresSinLibro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.autoresSinLibro.Name = "autoresSinLibro"
        Me.autoresSinLibro.Size = New System.Drawing.Size(184, 29)
        Me.autoresSinLibro.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(397, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No puedes eliminar los ejemplares en préstamo"
        '
        'BtnFinalizarEliminar
        '
        Me.BtnFinalizarEliminar.Location = New System.Drawing.Point(697, 12)
        Me.BtnFinalizarEliminar.Name = "BtnFinalizarEliminar"
        Me.BtnFinalizarEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnFinalizarEliminar.TabIndex = 9
        Me.BtnFinalizarEliminar.Text = "Finalizar"
        Me.BtnFinalizarEliminar.UseVisualStyleBackColor = True
        '
        'EliminarLibros1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnFinalizarEliminar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.data3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Data2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EliminarLibros1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form2"
        CType(Me.Data2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.data3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Data2 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents comboToDelete As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents data3 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents borrarLibro As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents autoresSinLibro As ComboBox
    Friend WithEvents deleteSinLibro As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnFinalizarEliminar As Button
End Class
