<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.OpcionAgregar = New System.Windows.Forms.CheckBox()
        Me.OpcionImprimir = New System.Windows.Forms.CheckBox()
        Me.BtnAccion = New System.Windows.Forms.Button()
        Me.TxtPrestamo = New System.Windows.Forms.TextBox()
        Me.LabelDiasPrestamos = New System.Windows.Forms.Label()
        Me.CheckSi = New System.Windows.Forms.CheckBox()
        Me.LabelAtraso = New System.Windows.Forms.Label()
        Me.CheckNo = New System.Windows.Forms.CheckBox()
        Me.TextMorosidad = New System.Windows.Forms.TextBox()
        Me.LabelMorosidad = New System.Windows.Forms.Label()
        Me.labelLibros = New System.Windows.Forms.Label()
        Me.ComboLibros = New System.Windows.Forms.ComboBox()
        Me.FinzalizarClientes = New System.Windows.Forms.Button()
        Me.EstadoDañado = New System.Windows.Forms.CheckBox()
        Me.LabelEstadoLibro = New System.Windows.Forms.Label()
        Me.EstadoNormal = New System.Windows.Forms.CheckBox()
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.ErrorLibro = New System.Windows.Forms.Label()
        Me.ErrorPrestamo = New System.Windows.Forms.Label()
        Me.PagarTodo = New System.Windows.Forms.Button()
        Me.ErrorMorosidad = New System.Windows.Forms.Label()
        Me.LabelDeudaPendiente = New System.Windows.Forms.Label()
        Me.LabelPrecioPagarLibro = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.LightSkyBlue
        Me.DataGridView1.Location = New System.Drawing.Point(0, 230)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1133, 386)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(506, 25)
        Me.Label1.MaximumSize = New System.Drawing.Size(127, 40)
        Me.Label1.MinimumSize = New System.Drawing.Size(127, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLIENTES"
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(86, 101)
        Me.TextName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(157, 27)
        Me.TextName.TabIndex = 3
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelName.ForeColor = System.Drawing.Color.White
        Me.LabelName.Location = New System.Drawing.Point(-9, 103)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(91, 23)
        Me.LabelName.TabIndex = 4
        Me.LabelName.Text = " Nombre :"
        '
        'OpcionAgregar
        '
        Me.OpcionAgregar.AutoSize = True
        Me.OpcionAgregar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OpcionAgregar.ForeColor = System.Drawing.Color.White
        Me.OpcionAgregar.Location = New System.Drawing.Point(4, 38)
        Me.OpcionAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OpcionAgregar.Name = "OpcionAgregar"
        Me.OpcionAgregar.Size = New System.Drawing.Size(93, 27)
        Me.OpcionAgregar.TabIndex = 5
        Me.OpcionAgregar.Text = "Agregar"
        Me.OpcionAgregar.UseVisualStyleBackColor = True
        '
        'OpcionImprimir
        '
        Me.OpcionImprimir.AutoSize = True
        Me.OpcionImprimir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OpcionImprimir.ForeColor = System.Drawing.Color.White
        Me.OpcionImprimir.Location = New System.Drawing.Point(103, 36)
        Me.OpcionImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OpcionImprimir.Name = "OpcionImprimir"
        Me.OpcionImprimir.Size = New System.Drawing.Size(157, 27)
        Me.OpcionImprimir.TabIndex = 6
        Me.OpcionImprimir.Text = "Imprimir Factura"
        Me.OpcionImprimir.UseVisualStyleBackColor = True
        '
        'BtnAccion
        '
        Me.BtnAccion.BackColor = System.Drawing.Color.Gray
        Me.BtnAccion.FlatAppearance.BorderSize = 0
        Me.BtnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAccion.ForeColor = System.Drawing.Color.White
        Me.BtnAccion.Location = New System.Drawing.Point(704, 95)
        Me.BtnAccion.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAccion.MaximumSize = New System.Drawing.Size(147, 43)
        Me.BtnAccion.MinimumSize = New System.Drawing.Size(147, 43)
        Me.BtnAccion.Name = "BtnAccion"
        Me.BtnAccion.Size = New System.Drawing.Size(147, 43)
        Me.BtnAccion.TabIndex = 7
        Me.BtnAccion.UseVisualStyleBackColor = False
        '
        'TxtPrestamo
        '
        Me.TxtPrestamo.Location = New System.Drawing.Point(535, 103)
        Me.TxtPrestamo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPrestamo.Name = "TxtPrestamo"
        Me.TxtPrestamo.Size = New System.Drawing.Size(137, 27)
        Me.TxtPrestamo.TabIndex = 8
        '
        'LabelDiasPrestamos
        '
        Me.LabelDiasPrestamos.AutoSize = True
        Me.LabelDiasPrestamos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelDiasPrestamos.ForeColor = System.Drawing.Color.White
        Me.LabelDiasPrestamos.Location = New System.Drawing.Point(535, 76)
        Me.LabelDiasPrestamos.Name = "LabelDiasPrestamos"
        Me.LabelDiasPrestamos.Size = New System.Drawing.Size(154, 23)
        Me.LabelDiasPrestamos.TabIndex = 9
        Me.LabelDiasPrestamos.Text = "Dias de Prestamo:"
        '
        'CheckSi
        '
        Me.CheckSi.AutoSize = True
        Me.CheckSi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckSi.ForeColor = System.Drawing.Color.White
        Me.CheckSi.Location = New System.Drawing.Point(211, 191)
        Me.CheckSi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckSi.Name = "CheckSi"
        Me.CheckSi.Size = New System.Drawing.Size(43, 27)
        Me.CheckSi.TabIndex = 10
        Me.CheckSi.Text = "si"
        Me.CheckSi.UseVisualStyleBackColor = True
        Me.CheckSi.Visible = False
        '
        'LabelAtraso
        '
        Me.LabelAtraso.AutoSize = True
        Me.LabelAtraso.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelAtraso.ForeColor = System.Drawing.Color.White
        Me.LabelAtraso.Location = New System.Drawing.Point(201, 147)
        Me.LabelAtraso.Name = "LabelAtraso"
        Me.LabelAtraso.Size = New System.Drawing.Size(164, 23)
        Me.LabelAtraso.TabIndex = 11
        Me.LabelAtraso.Text = "Atraso de Entrega :"
        Me.LabelAtraso.Visible = False
        '
        'CheckNo
        '
        Me.CheckNo.AutoSize = True
        Me.CheckNo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckNo.ForeColor = System.Drawing.Color.White
        Me.CheckNo.Location = New System.Drawing.Point(306, 187)
        Me.CheckNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckNo.Name = "CheckNo"
        Me.CheckNo.Size = New System.Drawing.Size(55, 27)
        Me.CheckNo.TabIndex = 12
        Me.CheckNo.Text = "No"
        Me.CheckNo.UseVisualStyleBackColor = True
        Me.CheckNo.Visible = False
        '
        'TextMorosidad
        '
        Me.TextMorosidad.Location = New System.Drawing.Point(392, 184)
        Me.TextMorosidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextMorosidad.Name = "TextMorosidad"
        Me.TextMorosidad.Size = New System.Drawing.Size(137, 27)
        Me.TextMorosidad.TabIndex = 13
        Me.TextMorosidad.Visible = False
        '
        'LabelMorosidad
        '
        Me.LabelMorosidad.AutoSize = True
        Me.LabelMorosidad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelMorosidad.ForeColor = System.Drawing.Color.White
        Me.LabelMorosidad.Location = New System.Drawing.Point(391, 147)
        Me.LabelMorosidad.Name = "LabelMorosidad"
        Me.LabelMorosidad.Size = New System.Drawing.Size(170, 23)
        Me.LabelMorosidad.TabIndex = 14
        Me.LabelMorosidad.Text = "Dias de Morosidad :"
        Me.LabelMorosidad.Visible = False
        '
        'labelLibros
        '
        Me.labelLibros.AutoSize = True
        Me.labelLibros.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelLibros.ForeColor = System.Drawing.Color.White
        Me.labelLibros.Location = New System.Drawing.Point(276, 101)
        Me.labelLibros.Name = "labelLibros"
        Me.labelLibros.Size = New System.Drawing.Size(69, 23)
        Me.labelLibros.TabIndex = 15
        Me.labelLibros.Text = "Libros :"
        '
        'ComboLibros
        '
        Me.ComboLibros.FormattingEnabled = True
        Me.ComboLibros.Location = New System.Drawing.Point(350, 101)
        Me.ComboLibros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboLibros.Name = "ComboLibros"
        Me.ComboLibros.Size = New System.Drawing.Size(157, 28)
        Me.ComboLibros.TabIndex = 16
        '
        'FinzalizarClientes
        '
        Me.FinzalizarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinzalizarClientes.BackColor = System.Drawing.Color.Red
        Me.FinzalizarClientes.FlatAppearance.BorderSize = 0
        Me.FinzalizarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.FinzalizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinzalizarClientes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FinzalizarClientes.ForeColor = System.Drawing.Color.White
        Me.FinzalizarClientes.Location = New System.Drawing.Point(1007, 25)
        Me.FinzalizarClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.FinzalizarClientes.MaximumSize = New System.Drawing.Size(86, 41)
        Me.FinzalizarClientes.MinimumSize = New System.Drawing.Size(86, 41)
        Me.FinzalizarClientes.Name = "FinzalizarClientes"
        Me.FinzalizarClientes.Size = New System.Drawing.Size(86, 41)
        Me.FinzalizarClientes.TabIndex = 17
        Me.FinzalizarClientes.Text = "Finalizar"
        Me.FinzalizarClientes.UseVisualStyleBackColor = False
        '
        'EstadoDañado
        '
        Me.EstadoDañado.AutoSize = True
        Me.EstadoDañado.Enabled = False
        Me.EstadoDañado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EstadoDañado.ForeColor = System.Drawing.Color.White
        Me.EstadoDañado.Location = New System.Drawing.Point(103, 187)
        Me.EstadoDañado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EstadoDañado.Name = "EstadoDañado"
        Me.EstadoDañado.Size = New System.Drawing.Size(92, 27)
        Me.EstadoDañado.TabIndex = 20
        Me.EstadoDañado.Text = "Dañado"
        Me.EstadoDañado.UseVisualStyleBackColor = True
        '
        'LabelEstadoLibro
        '
        Me.LabelEstadoLibro.AutoSize = True
        Me.LabelEstadoLibro.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelEstadoLibro.ForeColor = System.Drawing.Color.White
        Me.LabelEstadoLibro.Location = New System.Drawing.Point(20, 147)
        Me.LabelEstadoLibro.Name = "LabelEstadoLibro"
        Me.LabelEstadoLibro.Size = New System.Drawing.Size(145, 23)
        Me.LabelEstadoLibro.TabIndex = 19
        Me.LabelEstadoLibro.Text = "Estado de Libro :"
        '
        'EstadoNormal
        '
        Me.EstadoNormal.AutoSize = True
        Me.EstadoNormal.Enabled = False
        Me.EstadoNormal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EstadoNormal.ForeColor = System.Drawing.Color.White
        Me.EstadoNormal.Location = New System.Drawing.Point(-1, 187)
        Me.EstadoNormal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EstadoNormal.Name = "EstadoNormal"
        Me.EstadoNormal.Size = New System.Drawing.Size(89, 27)
        Me.EstadoNormal.TabIndex = 18
        Me.EstadoNormal.Text = "Normal"
        Me.EstadoNormal.UseVisualStyleBackColor = True
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(250, 101)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(21, 28)
        Me.ErrorName.TabIndex = 22
        Me.ErrorName.Text = "*"
        Me.ErrorName.Visible = False
        '
        'ErrorLibro
        '
        Me.ErrorLibro.AutoSize = True
        Me.ErrorLibro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ErrorLibro.ForeColor = System.Drawing.Color.Red
        Me.ErrorLibro.Location = New System.Drawing.Point(510, 101)
        Me.ErrorLibro.Name = "ErrorLibro"
        Me.ErrorLibro.Size = New System.Drawing.Size(21, 28)
        Me.ErrorLibro.TabIndex = 23
        Me.ErrorLibro.Text = "*"
        Me.ErrorLibro.Visible = False
        '
        'ErrorPrestamo
        '
        Me.ErrorPrestamo.AutoSize = True
        Me.ErrorPrestamo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ErrorPrestamo.ForeColor = System.Drawing.Color.Red
        Me.ErrorPrestamo.Location = New System.Drawing.Point(679, 101)
        Me.ErrorPrestamo.Name = "ErrorPrestamo"
        Me.ErrorPrestamo.Size = New System.Drawing.Size(21, 28)
        Me.ErrorPrestamo.TabIndex = 24
        Me.ErrorPrestamo.Text = "*"
        Me.ErrorPrestamo.Visible = False
        '
        'PagarTodo
        '
        Me.PagarTodo.BackColor = System.Drawing.Color.Gray
        Me.PagarTodo.FlatAppearance.BorderSize = 0
        Me.PagarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PagarTodo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PagarTodo.ForeColor = System.Drawing.Color.White
        Me.PagarTodo.Location = New System.Drawing.Point(858, 95)
        Me.PagarTodo.Margin = New System.Windows.Forms.Padding(0)
        Me.PagarTodo.MaximumSize = New System.Drawing.Size(147, 43)
        Me.PagarTodo.MinimumSize = New System.Drawing.Size(147, 43)
        Me.PagarTodo.Name = "PagarTodo"
        Me.PagarTodo.Size = New System.Drawing.Size(147, 43)
        Me.PagarTodo.TabIndex = 25
        Me.PagarTodo.UseVisualStyleBackColor = False
        '
        'ErrorMorosidad
        '
        Me.ErrorMorosidad.AutoSize = True
        Me.ErrorMorosidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ErrorMorosidad.ForeColor = System.Drawing.Color.Red
        Me.ErrorMorosidad.Location = New System.Drawing.Point(535, 185)
        Me.ErrorMorosidad.Name = "ErrorMorosidad"
        Me.ErrorMorosidad.Size = New System.Drawing.Size(21, 28)
        Me.ErrorMorosidad.TabIndex = 26
        Me.ErrorMorosidad.Text = "*"
        Me.ErrorMorosidad.Visible = False
        '
        'LabelDeudaPendiente
        '
        Me.LabelDeudaPendiente.AutoSize = True
        Me.LabelDeudaPendiente.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelDeudaPendiente.ForeColor = System.Drawing.Color.White
        Me.LabelDeudaPendiente.Location = New System.Drawing.Point(586, 187)
        Me.LabelDeudaPendiente.Name = "LabelDeudaPendiente"
        Me.LabelDeudaPendiente.Size = New System.Drawing.Size(116, 23)
        Me.LabelDeudaPendiente.TabIndex = 27
        Me.LabelDeudaPendiente.Text = "Deuda Total :"
        '
        'LabelPrecioPagarLibro
        '
        Me.LabelPrecioPagarLibro.AutoSize = True
        Me.LabelPrecioPagarLibro.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPrecioPagarLibro.ForeColor = System.Drawing.Color.Red
        Me.LabelPrecioPagarLibro.Location = New System.Drawing.Point(704, 189)
        Me.LabelPrecioPagarLibro.Name = "LabelPrecioPagarLibro"
        Me.LabelPrecioPagarLibro.Size = New System.Drawing.Size(18, 23)
        Me.LabelPrecioPagarLibro.TabIndex = 28
        Me.LabelPrecioPagarLibro.Text = "*"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1133, 616)
        Me.TableLayoutPanel1.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.labelLibros)
        Me.Panel1.Controls.Add(Me.LabelDiasPrestamos)
        Me.Panel1.Controls.Add(Me.LabelPrecioPagarLibro)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelDeudaPendiente)
        Me.Panel1.Controls.Add(Me.TextName)
        Me.Panel1.Controls.Add(Me.ErrorMorosidad)
        Me.Panel1.Controls.Add(Me.LabelName)
        Me.Panel1.Controls.Add(Me.PagarTodo)
        Me.Panel1.Controls.Add(Me.OpcionAgregar)
        Me.Panel1.Controls.Add(Me.ErrorPrestamo)
        Me.Panel1.Controls.Add(Me.OpcionImprimir)
        Me.Panel1.Controls.Add(Me.ErrorLibro)
        Me.Panel1.Controls.Add(Me.BtnAccion)
        Me.Panel1.Controls.Add(Me.ErrorName)
        Me.Panel1.Controls.Add(Me.TxtPrestamo)
        Me.Panel1.Controls.Add(Me.EstadoDañado)
        Me.Panel1.Controls.Add(Me.CheckSi)
        Me.Panel1.Controls.Add(Me.LabelEstadoLibro)
        Me.Panel1.Controls.Add(Me.LabelAtraso)
        Me.Panel1.Controls.Add(Me.EstadoNormal)
        Me.Panel1.Controls.Add(Me.CheckNo)
        Me.Panel1.Controls.Add(Me.FinzalizarClientes)
        Me.Panel1.Controls.Add(Me.TextMorosidad)
        Me.Panel1.Controls.Add(Me.ComboLibros)
        Me.Panel1.Controls.Add(Me.LabelMorosidad)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1127, 224)
        Me.Panel1.TabIndex = 0
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1133, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(466, 604)
        Me.Name = "Clientes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextName As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents OpcionAgregar As CheckBox
    Friend WithEvents OpcionImprimir As CheckBox
    Friend WithEvents BtnAccion As Button
    Friend WithEvents TxtPrestamo As TextBox
    Friend WithEvents LabelDiasPrestamos As Label
    Friend WithEvents CheckSi As CheckBox
    Friend WithEvents LabelAtraso As Label
    Friend WithEvents CheckNo As CheckBox
    Friend WithEvents TextMorosidad As TextBox
    Friend WithEvents LabelMorosidad As Label
    Friend WithEvents labelLibros As Label
    Friend WithEvents ComboLibros As ComboBox
    Friend WithEvents FinzalizarClientes As Button
    Friend WithEvents EstadoDañado As CheckBox
    Friend WithEvents LabelEstadoLibro As Label
    Friend WithEvents EstadoNormal As CheckBox
    Friend WithEvents ErrorName As Label
    Friend WithEvents ErrorLibro As Label
    Friend WithEvents ErrorPrestamo As Label
    Friend WithEvents PagarTodo As Button
    Friend WithEvents ErrorMorosidad As Label
    Friend WithEvents LabelDeudaPendiente As Label
    Friend WithEvents LabelPrecioPagarLibro As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
