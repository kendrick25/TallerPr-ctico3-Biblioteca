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
        Me.AgregarLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContForms = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ContenidoMenuPrincipal = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnEliminarLibro = New System.Windows.Forms.Button()
        Me.AbrirForm1 = New System.Windows.Forms.Button()
        Me.Border.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MovForm.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Border.Padding = New System.Windows.Forms.Padding(2)
        Me.Border.Size = New System.Drawing.Size(736, 453)
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(732, 449)
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
        Me.MovForm.Size = New System.Drawing.Size(732, 30)
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
        Me.Label1.Size = New System.Drawing.Size(78, 30)
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
        Me.BtnMin.Location = New System.Drawing.Point(582, 0)
        Me.BtnMin.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(50, 30)
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
        Me.BtnMax.Location = New System.Drawing.Point(632, 0)
        Me.BtnMax.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(50, 30)
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
        Me.BtnClose.Location = New System.Drawing.Point(682, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 30)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BibliotecaArchivosToolStripMenuItem, Me.OtrosToolStripMenuItem, Me.NosotrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(110, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
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
        Me.BibliotecaArchivosToolStripMenuItem.Size = New System.Drawing.Size(80, 30)
        Me.BibliotecaArchivosToolStripMenuItem.Text = "Biblioteca"
        '
        'VerLibrosToolStripMenuItem
        '
        Me.VerLibrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VerLibrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VerLibrosToolStripMenuItem.Name = "VerLibrosToolStripMenuItem"
        Me.VerLibrosToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.VerLibrosToolStripMenuItem.Text = "Ver Libros"
        '
        'VerMenuToolStripMenuItem
        '
        Me.VerMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VerMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarLibroToolStripMenuItem, Me.EliminarLibrosToolStripMenuItem})
        Me.VerMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VerMenuToolStripMenuItem.Name = "VerMenuToolStripMenuItem"
        Me.VerMenuToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.VerMenuToolStripMenuItem.Text = "Opciones"
        '
        'AgregarLibroToolStripMenuItem
        '
        Me.AgregarLibroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AgregarLibroToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarLibroToolStripMenuItem.Name = "AgregarLibroToolStripMenuItem"
        Me.AgregarLibroToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.AgregarLibroToolStripMenuItem.Text = "Agregar Libros"
        '
        'EliminarLibrosToolStripMenuItem
        '
        Me.EliminarLibrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EliminarLibrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EliminarLibrosToolStripMenuItem.Name = "EliminarLibrosToolStripMenuItem"
        Me.EliminarLibrosToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.EliminarLibrosToolStripMenuItem.Text = "Eliminar Libros"
        '
        'CerrarTodoToolStripMenuItem1
        '
        Me.CerrarTodoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CerrarTodoToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.CerrarTodoToolStripMenuItem1.Name = "CerrarTodoToolStripMenuItem1"
        Me.CerrarTodoToolStripMenuItem1.Size = New System.Drawing.Size(180, 24)
        Me.CerrarTodoToolStripMenuItem1.Text = "Cerrar Todo"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OtrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(75, 30)
        Me.OtrosToolStripMenuItem.Text = "Soporte"
        '
        'NosotrosToolStripMenuItem
        '
        Me.NosotrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NosotrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NosotrosToolStripMenuItem.Name = "NosotrosToolStripMenuItem"
        Me.NosotrosToolStripMenuItem.Size = New System.Drawing.Size(82, 30)
        Me.NosotrosToolStripMenuItem.Text = "Nosotros"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.ContForms)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 419)
        Me.Panel1.TabIndex = 1
        '
        'ContForms
        '
        Me.ContForms.Controls.Add(Me.TabPage1)
        Me.ContForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContForms.Location = New System.Drawing.Point(0, 0)
        Me.ContForms.Margin = New System.Windows.Forms.Padding(0)
        Me.ContForms.Name = "ContForms"
        Me.ContForms.SelectedIndex = 0
        Me.ContForms.Size = New System.Drawing.Size(732, 419)
        Me.ContForms.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ContenidoMenuPrincipal)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(724, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menu Principal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ContenidoMenuPrincipal
        '
        Me.ContenidoMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ContenidoMenuPrincipal.Controls.Add(Me.DataGridView1)
        Me.ContenidoMenuPrincipal.Controls.Add(Me.BtnEliminarLibro)
        Me.ContenidoMenuPrincipal.Controls.Add(Me.AbrirForm1)
        Me.ContenidoMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContenidoMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ContenidoMenuPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.ContenidoMenuPrincipal.Name = "ContenidoMenuPrincipal"
        Me.ContenidoMenuPrincipal.Size = New System.Drawing.Size(724, 391)
        Me.ContenidoMenuPrincipal.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(57, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'BtnEliminarLibro
        '
        Me.BtnEliminarLibro.Location = New System.Drawing.Point(346, 77)
        Me.BtnEliminarLibro.Name = "BtnEliminarLibro"
        Me.BtnEliminarLibro.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarLibro.TabIndex = 1
        Me.BtnEliminarLibro.Text = "Eliminar Libro"
        Me.BtnEliminarLibro.UseVisualStyleBackColor = True
        '
        'AbrirForm1
        '
        Me.AbrirForm1.Location = New System.Drawing.Point(335, 28)
        Me.AbrirForm1.Name = "AbrirForm1"
        Me.AbrirForm1.Size = New System.Drawing.Size(100, 23)
        Me.AbrirForm1.TabIndex = 0
        Me.AbrirForm1.Text = "Agregar Libro"
        Me.AbrirForm1.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(736, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.Border)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(736, 453)
        Me.Name = "MenuPrincipal"
        Me.Text = "DK - CODE"
        Me.Border.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MovForm.ResumeLayout(False)
        Me.MovForm.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ContForms.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ContenidoMenuPrincipal.ResumeLayout(False)
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
End Class
