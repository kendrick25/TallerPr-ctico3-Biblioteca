<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Data = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.opcionNuevo = New System.Windows.Forms.CheckBox()
        Me.opcionExiste = New System.Windows.Forms.CheckBox()
        Me.procesar = New System.Windows.Forms.Button()
        Me.autoresExisCombo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inputCountry = New System.Windows.Forms.TextBox()
        Me.residenciaAutorLb = New System.Windows.Forms.Label()
        Me.agregar = New System.Windows.Forms.Button()
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.nombreAutorNew = New System.Windows.Forms.Label()
        Me.inputLibro = New System.Windows.Forms.TextBox()
        Me.tituloLibroLb = New System.Windows.Forms.Label()
        Me.autorExistenteLb = New System.Windows.Forms.Label()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Data
        '
        Me.Data.AllowUserToAddRows = False
        Me.Data.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.Data.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Data.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Data.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Data.DefaultCellStyle = DataGridViewCellStyle3
        Me.Data.Location = New System.Drawing.Point(344, 70)
        Me.Data.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.RowHeadersVisible = False
        Me.Data.RowHeadersWidth = 51
        Me.Data.RowTemplate.Height = 29
        Me.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data.Size = New System.Drawing.Size(422, 265)
        Me.Data.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(472, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AGREGA LIBRO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(5, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de Autor"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.opcionNuevo)
        Me.GroupBox1.Controls.Add(Me.opcionExiste)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(308, 106)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(33, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Existente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(165, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nuevo"
        '
        'opcionNuevo
        '
        Me.opcionNuevo.AutoSize = True
        Me.opcionNuevo.Location = New System.Drawing.Point(144, 67)
        Me.opcionNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.opcionNuevo.Name = "opcionNuevo"
        Me.opcionNuevo.Size = New System.Drawing.Size(15, 14)
        Me.opcionNuevo.TabIndex = 5
        Me.opcionNuevo.UseVisualStyleBackColor = True
        '
        'opcionExiste
        '
        Me.opcionExiste.AutoSize = True
        Me.opcionExiste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.opcionExiste.Font = New System.Drawing.Font("MS Outlook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.opcionExiste.Location = New System.Drawing.Point(12, 68)
        Me.opcionExiste.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.opcionExiste.Name = "opcionExiste"
        Me.opcionExiste.Size = New System.Drawing.Size(15, 14)
        Me.opcionExiste.TabIndex = 4
        Me.opcionExiste.UseVisualStyleBackColor = True
        '
        'procesar
        '
        Me.procesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.procesar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.procesar.Location = New System.Drawing.Point(114, 148)
        Me.procesar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.procesar.Name = "procesar"
        Me.procesar.Size = New System.Drawing.Size(100, 30)
        Me.procesar.TabIndex = 5
        Me.procesar.Text = "Procesar"
        Me.procesar.UseVisualStyleBackColor = False
        '
        'autoresExisCombo
        '
        Me.autoresExisCombo.FormattingEnabled = True
        Me.autoresExisCombo.Location = New System.Drawing.Point(76, 32)
        Me.autoresExisCombo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.autoresExisCombo.Name = "autoresExisCombo"
        Me.autoresExisCombo.Size = New System.Drawing.Size(176, 29)
        Me.autoresExisCombo.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.inputCountry)
        Me.GroupBox2.Controls.Add(Me.residenciaAutorLb)
        Me.GroupBox2.Controls.Add(Me.agregar)
        Me.GroupBox2.Controls.Add(Me.inputNombre)
        Me.GroupBox2.Controls.Add(Me.nombreAutorNew)
        Me.GroupBox2.Controls.Add(Me.inputLibro)
        Me.GroupBox2.Controls.Add(Me.tituloLibroLb)
        Me.GroupBox2.Controls.Add(Me.autorExistenteLb)
        Me.GroupBox2.Controls.Add(Me.autoresExisCombo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 182)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(308, 224)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Procesar"
        '
        'inputCountry
        '
        Me.inputCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCountry.Location = New System.Drawing.Point(103, 97)
        Me.inputCountry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.inputCountry.Name = "inputCountry"
        Me.inputCountry.Size = New System.Drawing.Size(175, 29)
        Me.inputCountry.TabIndex = 14
        '
        'residenciaAutorLb
        '
        Me.residenciaAutorLb.AutoSize = True
        Me.residenciaAutorLb.Location = New System.Drawing.Point(33, 98)
        Me.residenciaAutorLb.Name = "residenciaAutorLb"
        Me.residenciaAutorLb.Size = New System.Drawing.Size(44, 21)
        Me.residenciaAutorLb.TabIndex = 13
        Me.residenciaAutorLb.Text = "País: "
        '
        'agregar
        '
        Me.agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.agregar.Location = New System.Drawing.Point(204, 181)
        Me.agregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(99, 38)
        Me.agregar.TabIndex = 8
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = False
        '
        'inputNombre
        '
        Me.inputNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombre.Location = New System.Drawing.Point(128, 63)
        Me.inputNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(175, 29)
        Me.inputNombre.TabIndex = 12
        '
        'nombreAutorNew
        '
        Me.nombreAutorNew.AutoSize = True
        Me.nombreAutorNew.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nombreAutorNew.Location = New System.Drawing.Point(0, 64)
        Me.nombreAutorNew.Name = "nombreAutorNew"
        Me.nombreAutorNew.Size = New System.Drawing.Size(114, 21)
        Me.nombreAutorNew.TabIndex = 11
        Me.nombreAutorNew.Text = "Nombre Autor:"
        '
        'inputLibro
        '
        Me.inputLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputLibro.Location = New System.Drawing.Point(103, 131)
        Me.inputLibro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.inputLibro.Name = "inputLibro"
        Me.inputLibro.Size = New System.Drawing.Size(175, 29)
        Me.inputLibro.TabIndex = 10
        '
        'tituloLibroLb
        '
        Me.tituloLibroLb.AutoSize = True
        Me.tituloLibroLb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tituloLibroLb.Location = New System.Drawing.Point(18, 131)
        Me.tituloLibroLb.Name = "tituloLibroLb"
        Me.tituloLibroLb.Size = New System.Drawing.Size(56, 21)
        Me.tituloLibroLb.TabIndex = 9
        Me.tituloLibroLb.Text = "Título: "
        '
        'autorExistenteLb
        '
        Me.autorExistenteLb.AutoSize = True
        Me.autorExistenteLb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.autorExistenteLb.Location = New System.Drawing.Point(9, 34)
        Me.autorExistenteLb.Name = "autorExistenteLb"
        Me.autorExistenteLb.Size = New System.Drawing.Size(56, 21)
        Me.autorExistenteLb.TabIndex = 8
        Me.autorExistenteLb.Text = "Autor: "
        '
        'Agregar1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.procesar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Agregar1"
        Me.ShowIcon = False
        Me.Text = "Agregar"
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Data As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents opcionExiste As CheckBox
    Friend WithEvents opcionNuevo As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents procesar As Button
    Friend WithEvents autoresExisCombo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents autorExistenteLb As Label
    Friend WithEvents inputNombre As TextBox
    Friend WithEvents nombreAutorNew As Label
    Friend WithEvents inputLibro As TextBox
    Friend WithEvents tituloLibroLb As Label
    Friend WithEvents agregar As Button
    Friend WithEvents inputCountry As TextBox
    Friend WithEvents residenciaAutorLb As Label
End Class
