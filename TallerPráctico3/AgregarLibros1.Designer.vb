<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarLibros1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.nombreAutorNew = New System.Windows.Forms.Label()
        Me.inputLibro = New System.Windows.Forms.TextBox()
        Me.tituloLibroLb = New System.Windows.Forms.Label()
        Me.autorExistenteLb = New System.Windows.Forms.Label()
        Me.agregar = New System.Windows.Forms.Button()
        Me.FinalizarForm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.retrocederAccion = New System.Windows.Forms.Button()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Data.Location = New System.Drawing.Point(3, 230)
        Me.Data.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.RowHeadersVisible = False
        Me.Data.RowHeadersWidth = 51
        Me.Data.RowTemplate.Height = 29
        Me.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data.Size = New System.Drawing.Size(701, 230)
        Me.Data.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 200)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(707, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AGREGA LIBRO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.opcionNuevo)
        Me.GroupBox1.Controls.Add(Me.opcionExiste)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(236, 95)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(236, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(236, 95)
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
        Me.procesar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.procesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.procesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.procesar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.procesar.Image = Global.TallerPráctico3.My.Resources.Resources.comprobar
        Me.procesar.Location = New System.Drawing.Point(81, 132)
        Me.procesar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.procesar.MaximumSize = New System.Drawing.Size(43, 36)
        Me.procesar.MinimumSize = New System.Drawing.Size(43, 36)
        Me.procesar.Name = "procesar"
        Me.procesar.Size = New System.Drawing.Size(43, 36)
        Me.procesar.TabIndex = 5
        Me.procesar.UseVisualStyleBackColor = False
        '
        'autoresExisCombo
        '
        Me.autoresExisCombo.FormattingEnabled = True
        Me.autoresExisCombo.Location = New System.Drawing.Point(127, 29)
        Me.autoresExisCombo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.autoresExisCombo.Name = "autoresExisCombo"
        Me.autoresExisCombo.Size = New System.Drawing.Size(176, 29)
        Me.autoresExisCombo.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.inputCountry)
        Me.GroupBox2.Controls.Add(Me.residenciaAutorLb)
        Me.GroupBox2.Controls.Add(Me.inputNombre)
        Me.GroupBox2.Controls.Add(Me.nombreAutorNew)
        Me.GroupBox2.Controls.Add(Me.inputLibro)
        Me.GroupBox2.Controls.Add(Me.tituloLibroLb)
        Me.GroupBox2.Controls.Add(Me.autorExistenteLb)
        Me.GroupBox2.Controls.Add(Me.autoresExisCombo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.MaximumSize = New System.Drawing.Size(312, 169)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(312, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(312, 169)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Procesar"
        '
        'inputCountry
        '
        Me.inputCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCountry.Location = New System.Drawing.Point(127, 98)
        Me.inputCountry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.inputCountry.Name = "inputCountry"
        Me.inputCountry.Size = New System.Drawing.Size(175, 29)
        Me.inputCountry.TabIndex = 14
        '
        'residenciaAutorLb
        '
        Me.residenciaAutorLb.AutoSize = True
        Me.residenciaAutorLb.Location = New System.Drawing.Point(70, 100)
        Me.residenciaAutorLb.Name = "residenciaAutorLb"
        Me.residenciaAutorLb.Size = New System.Drawing.Size(44, 21)
        Me.residenciaAutorLb.TabIndex = 13
        Me.residenciaAutorLb.Text = "País: "
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
        Me.inputLibro.Location = New System.Drawing.Point(127, 131)
        Me.inputLibro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.inputLibro.Name = "inputLibro"
        Me.inputLibro.Size = New System.Drawing.Size(175, 29)
        Me.inputLibro.TabIndex = 10
        '
        'tituloLibroLb
        '
        Me.tituloLibroLb.AutoSize = True
        Me.tituloLibroLb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tituloLibroLb.Location = New System.Drawing.Point(58, 126)
        Me.tituloLibroLb.Name = "tituloLibroLb"
        Me.tituloLibroLb.Size = New System.Drawing.Size(56, 21)
        Me.tituloLibroLb.TabIndex = 9
        Me.tituloLibroLb.Text = "Título: "
        '
        'autorExistenteLb
        '
        Me.autorExistenteLb.AutoSize = True
        Me.autorExistenteLb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.autorExistenteLb.Location = New System.Drawing.Point(58, 32)
        Me.autorExistenteLb.Name = "autorExistenteLb"
        Me.autorExistenteLb.Size = New System.Drawing.Size(56, 21)
        Me.autorExistenteLb.TabIndex = 8
        Me.autorExistenteLb.Text = "Autor: "
        '
        'agregar
        '
        Me.agregar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregar.Location = New System.Drawing.Point(600, 64)
        Me.agregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.agregar.MaximumSize = New System.Drawing.Size(99, 38)
        Me.agregar.MinimumSize = New System.Drawing.Size(99, 38)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(99, 38)
        Me.agregar.TabIndex = 8
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = False
        '
        'FinalizarForm
        '
        Me.FinalizarForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalizarForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FinalizarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FinalizarForm.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FinalizarForm.Location = New System.Drawing.Point(600, 132)
        Me.FinalizarForm.MaximumSize = New System.Drawing.Size(99, 36)
        Me.FinalizarForm.MinimumSize = New System.Drawing.Size(99, 36)
        Me.FinalizarForm.Name = "FinalizarForm"
        Me.FinalizarForm.Size = New System.Drawing.Size(99, 36)
        Me.FinalizarForm.TabIndex = 8
        Me.FinalizarForm.Text = "Finalizar"
        Me.FinalizarForm.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Data, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(707, 462)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.retrocederAccion)
        Me.Panel1.Controls.Add(Me.agregar)
        Me.Panel1.Controls.Add(Me.FinalizarForm)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.procesar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 200)
        Me.Panel1.TabIndex = 0
        '
        'retrocederAccion
        '
        Me.retrocederAccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.retrocederAccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.retrocederAccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.retrocederAccion.Image = Global.TallerPráctico3.My.Resources.Resources.boton
        Me.retrocederAccion.Location = New System.Drawing.Point(158, 132)
        Me.retrocederAccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.retrocederAccion.MaximumSize = New System.Drawing.Size(43, 36)
        Me.retrocederAccion.MinimumSize = New System.Drawing.Size(43, 36)
        Me.retrocederAccion.Name = "retrocederAccion"
        Me.retrocederAccion.Size = New System.Drawing.Size(43, 36)
        Me.retrocederAccion.TabIndex = 9
        Me.retrocederAccion.UseVisualStyleBackColor = False
        '
        'AgregarLibros1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(707, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarLibros1"
        Me.ShowIcon = False
        Me.Text = "Agregar"
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents FinalizarForm As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents retrocederAccion As Button
End Class
