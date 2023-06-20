<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Border = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MovForm = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BibliotecaArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContForms = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ContenidoMenuPrincipal = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnEliminarLibro = New System.Windows.Forms.Button()
        Me.AbrirForm1 = New System.Windows.Forms.Button()
        Me.Border.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MovForm.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContForms.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContenidoMenuPrincipal.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Border
        '
        Me.Border.Controls.Add(Me.TableLayoutPanel1)
        Me.Border.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Border.Location = New System.Drawing.Point(0, 0)
        Me.Border.Margin = New System.Windows.Forms.Padding(0)
        Me.Border.Name = "Border"
        Me.Border.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Border.Size = New System.Drawing.Size(920, 500)
        Me.Border.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MovForm, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(916, 496)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MovForm
        '
        Me.MovForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MovForm.ColumnCount = 5
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MovForm.Controls.Add(Me.Label1, 0, 0)
        Me.MovForm.Controls.Add(Me.BtnMin, 2, 0)
        Me.MovForm.Controls.Add(Me.BtnMax, 3, 0)
        Me.MovForm.Controls.Add(Me.BtnClose, 4, 0)
        Me.MovForm.Controls.Add(Me.MenuStrip1, 1, 0)
        Me.MovForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MovForm.Location = New System.Drawing.Point(0, 0)
        Me.MovForm.Margin = New System.Windows.Forms.Padding(0)
        Me.MovForm.Name = "MovForm"
        Me.MovForm.RowCount = 1
        Me.MovForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MovForm.Size = New System.Drawing.Size(916, 32)
        Me.MovForm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "    DK - CODE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnMin
        '
        Me.BtnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMin.BackgroundImage = Global.TallerPráctico3.My.Resources.Resources.minimizar
        Me.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnMin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Location = New System.Drawing.Point(766, 0)
        Me.BtnMin.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(50, 32)
        Me.BtnMin.TabIndex = 2
        Me.BtnMin.UseVisualStyleBackColor = False
        '
        'BtnMax
        '
        Me.BtnMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMax.BackgroundImage = Global.TallerPráctico3.My.Resources.Resources.max
        Me.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMax.FlatAppearance.BorderSize = 0
        Me.BtnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMax.Location = New System.Drawing.Point(816, 0)
        Me.BtnMax.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(50, 32)
        Me.BtnMax.TabIndex = 3
        Me.BtnMax.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClose.BackgroundImage = Global.TallerPráctico3.My.Resources.Resources.cerrar
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(866, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 32)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BibliotecaArchivosToolStripMenuItem, Me.OtrosToolStripMenuItem, Me.NosotrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(110, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.MenuStrip1.Size = New System.Drawing.Size(239, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BibliotecaArchivosToolStripMenuItem
        '
        Me.BibliotecaArchivosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BibliotecaArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLibrosToolStripMenuItem, Me.VerMenuToolStripMenuItem, Me.CerrarTodoToolStripMenuItem1})
        Me.BibliotecaArchivosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BibliotecaArchivosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BibliotecaArchivosToolStripMenuItem.Name = "BibliotecaArchivosToolStripMenuItem"
        Me.BibliotecaArchivosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.BibliotecaArchivosToolStripMenuItem.Size = New System.Drawing.Size(80, 28)
        Me.BibliotecaArchivosToolStripMenuItem.Text = "Biblioteca"
        '
        'VerLibrosToolStripMenuItem
        '
        Me.VerLibrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VerLibrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VerLibrosToolStripMenuItem.Name = "VerLibrosToolStripMenuItem"
        Me.VerLibrosToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.VerLibrosToolStripMenuItem.Text = "Ver Libros"
        '
        'VerMenuToolStripMenuItem
        '
        Me.VerMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VerMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.AgregarLibroToolStripMenuItem, Me.EliminarLibrosToolStripMenuItem})
        Me.VerMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VerMenuToolStripMenuItem.Name = "VerMenuToolStripMenuItem"
        Me.VerMenuToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.VerMenuToolStripMenuItem.Text = "Opciones"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AgregarLibroToolStripMenuItem
        '
        Me.AgregarLibroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AgregarLibroToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarLibroToolStripMenuItem.Name = "AgregarLibroToolStripMenuItem"
        Me.AgregarLibroToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.AgregarLibroToolStripMenuItem.Text = "Agregar Libros"
        '
        'EliminarLibrosToolStripMenuItem
        '
        Me.EliminarLibrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EliminarLibrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EliminarLibrosToolStripMenuItem.Name = "EliminarLibrosToolStripMenuItem"
        Me.EliminarLibrosToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.EliminarLibrosToolStripMenuItem.Text = "Eliminar Libros"
        '
        'CerrarTodoToolStripMenuItem1
        '
        Me.CerrarTodoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CerrarTodoToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.CerrarTodoToolStripMenuItem1.Name = "CerrarTodoToolStripMenuItem1"
        Me.CerrarTodoToolStripMenuItem1.Size = New System.Drawing.Size(159, 24)
        Me.CerrarTodoToolStripMenuItem1.Text = "Cerrar Todo"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OtrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(75, 28)
        Me.OtrosToolStripMenuItem.Text = "Soporte"
        '
        'NosotrosToolStripMenuItem
        '
        Me.NosotrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NosotrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NosotrosToolStripMenuItem.Name = "NosotrosToolStripMenuItem"
        Me.NosotrosToolStripMenuItem.Size = New System.Drawing.Size(82, 28)
        Me.NosotrosToolStripMenuItem.Text = "Nosotros"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ContForms)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 464)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.TallerPráctico3.My.Resources.Resources.Logo_2023
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(340, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(298, 213)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(298, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 213)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(120, 332)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.MaximumSize = New System.Drawing.Size(56, 44)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(56, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 44)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(439, 332)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.PictureBox3.MaximumSize = New System.Drawing.Size(56, 44)
        Me.PictureBox3.MinimumSize = New System.Drawing.Size(56, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 44)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(517, 344)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.MaximumSize = New System.Drawing.Size(295, 21)
        Me.Label6.MinimumSize = New System.Drawing.Size(295, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Correo : DKCodeSolution@gmail.com"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(176, 344)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.MaximumSize = New System.Drawing.Size(213, 21)
        Me.Label5.MinimumSize = New System.Drawing.Size(213, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telefono :  +507 6592-1274"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(407, 300)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.MaximumSize = New System.Drawing.Size(105, 21)
        Me.Label4.MinimumSize = New System.Drawing.Size(105, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contáctenos"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(257, 225)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.MaximumSize = New System.Drawing.Size(464, 63)
        Me.Label3.MinimumSize = New System.Drawing.Size(464, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(464, 63)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Somos una Empresa de Desarrollo de Sistemas informáticos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que brinda soluciones ó" &
    "ptimas para el cálculo de cualquier " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "índole que se requiera."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContForms
        '
        Me.ContForms.Controls.Add(Me.TabPage1)
        Me.ContForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContForms.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ContForms.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ContForms.Location = New System.Drawing.Point(0, 0)
        Me.ContForms.Margin = New System.Windows.Forms.Padding(0)
        Me.ContForms.Multiline = True
        Me.ContForms.Name = "ContForms"
        Me.ContForms.Padding = New System.Drawing.Point(5, 3)
        Me.ContForms.SelectedIndex = 0
        Me.ContForms.Size = New System.Drawing.Size(916, 464)
        Me.ContForms.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ContenidoMenuPrincipal)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(908, 434)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menu Principal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ContenidoMenuPrincipal
        '
        Me.ContenidoMenuPrincipal.AutoScroll = True
        Me.ContenidoMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContenidoMenuPrincipal.Controls.Add(Me.Label2)
        Me.ContenidoMenuPrincipal.Controls.Add(Me.DataGridView1)
        Me.ContenidoMenuPrincipal.Controls.Add(Me.BtnEliminarLibro)
        Me.ContenidoMenuPrincipal.Controls.Add(Me.AbrirForm1)
        Me.ContenidoMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContenidoMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ContenidoMenuPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.ContenidoMenuPrincipal.Name = "ContenidoMenuPrincipal"
        Me.ContenidoMenuPrincipal.Size = New System.Drawing.Size(908, 434)
        Me.ContenidoMenuPrincipal.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(336, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LIBROS DISPONIBLES"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.LightSkyBlue
        Me.DataGridView1.Location = New System.Drawing.Point(63, 88)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(771, 303)
        Me.DataGridView1.TabIndex = 2
        '
        'BtnEliminarLibro
        '
        Me.BtnEliminarLibro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminarLibro.BackColor = System.Drawing.Color.Red
        Me.BtnEliminarLibro.FlatAppearance.BorderSize = 0
        Me.BtnEliminarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarLibro.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEliminarLibro.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarLibro.Location = New System.Drawing.Point(700, 50)
        Me.BtnEliminarLibro.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnEliminarLibro.MaximumSize = New System.Drawing.Size(134, 32)
        Me.BtnEliminarLibro.MinimumSize = New System.Drawing.Size(134, 32)
        Me.BtnEliminarLibro.Name = "BtnEliminarLibro"
        Me.BtnEliminarLibro.Size = New System.Drawing.Size(134, 32)
        Me.BtnEliminarLibro.TabIndex = 1
        Me.BtnEliminarLibro.Text = "Eliminar Libro"
        Me.BtnEliminarLibro.UseVisualStyleBackColor = False
        '
        'AbrirForm1
        '
        Me.AbrirForm1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AbrirForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AbrirForm1.FlatAppearance.BorderSize = 0
        Me.AbrirForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbrirForm1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AbrirForm1.ForeColor = System.Drawing.Color.White
        Me.AbrirForm1.Location = New System.Drawing.Point(555, 50)
        Me.AbrirForm1.Margin = New System.Windows.Forms.Padding(0)
        Me.AbrirForm1.MaximumSize = New System.Drawing.Size(134, 32)
        Me.AbrirForm1.MinimumSize = New System.Drawing.Size(134, 32)
        Me.AbrirForm1.Name = "AbrirForm1"
        Me.AbrirForm1.Size = New System.Drawing.Size(134, 32)
        Me.AbrirForm1.TabIndex = 0
        Me.AbrirForm1.Text = "Agregar Libro"
        Me.AbrirForm1.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(920, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Border)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(920, 500)
        Me.Name = "MenuPrincipal"
        Me.Text = " - CODE"
        Me.Border.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MovForm.ResumeLayout(False)
        Me.MovForm.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContForms.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ContenidoMenuPrincipal.ResumeLayout(False)
        Me.ContenidoMenuPrincipal.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Border As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MovForm As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BibliotecaArchivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContForms As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents NosotrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContenidoMenuPrincipal As Panel
    Friend WithEvents VerMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirForm1 As Button
    Friend WithEvents AgregarLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BtnEliminarLibro As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
