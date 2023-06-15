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
        Me.Button1 = New System.Windows.Forms.Button()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(889, 287)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(387, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLIENTES"
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(97, 62)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(138, 23)
        Me.TextName.TabIndex = 3
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelName.Location = New System.Drawing.Point(12, 62)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(77, 19)
        Me.LabelName.TabIndex = 4
        Me.LabelName.Text = " Nombre :"
        '
        'OpcionAgregar
        '
        Me.OpcionAgregar.AutoSize = True
        Me.OpcionAgregar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OpcionAgregar.Location = New System.Drawing.Point(12, 9)
        Me.OpcionAgregar.Name = "OpcionAgregar"
        Me.OpcionAgregar.Size = New System.Drawing.Size(77, 23)
        Me.OpcionAgregar.TabIndex = 5
        Me.OpcionAgregar.Text = "Agregar"
        Me.OpcionAgregar.UseVisualStyleBackColor = True
        '
        'OpcionImprimir
        '
        Me.OpcionImprimir.AutoSize = True
        Me.OpcionImprimir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OpcionImprimir.Location = New System.Drawing.Point(103, 9)
        Me.OpcionImprimir.Name = "OpcionImprimir"
        Me.OpcionImprimir.Size = New System.Drawing.Size(129, 23)
        Me.OpcionImprimir.TabIndex = 6
        Me.OpcionImprimir.Text = "Imprimir Factura"
        Me.OpcionImprimir.UseVisualStyleBackColor = True
        '
        'BtnAccion
        '
        Me.BtnAccion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAccion.Location = New System.Drawing.Point(637, 59)
        Me.BtnAccion.Name = "BtnAccion"
        Me.BtnAccion.Size = New System.Drawing.Size(129, 32)
        Me.BtnAccion.TabIndex = 7
        Me.BtnAccion.UseVisualStyleBackColor = True
        '
        'TxtPrestamo
        '
        Me.TxtPrestamo.Location = New System.Drawing.Point(484, 63)
        Me.TxtPrestamo.Name = "TxtPrestamo"
        Me.TxtPrestamo.Size = New System.Drawing.Size(120, 23)
        Me.TxtPrestamo.TabIndex = 8
        '
        'LabelDiasPrestamos
        '
        Me.LabelDiasPrestamos.AutoSize = True
        Me.LabelDiasPrestamos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelDiasPrestamos.Location = New System.Drawing.Point(484, 42)
        Me.LabelDiasPrestamos.Name = "LabelDiasPrestamos"
        Me.LabelDiasPrestamos.Size = New System.Drawing.Size(120, 17)
        Me.LabelDiasPrestamos.TabIndex = 9
        Me.LabelDiasPrestamos.Text = "Dias de Prestamo:"
        '
        'CheckSi
        '
        Me.CheckSi.AutoSize = True
        Me.CheckSi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckSi.Location = New System.Drawing.Point(198, 125)
        Me.CheckSi.Name = "CheckSi"
        Me.CheckSi.Size = New System.Drawing.Size(37, 23)
        Me.CheckSi.TabIndex = 10
        Me.CheckSi.Text = "si"
        Me.CheckSi.UseVisualStyleBackColor = True
        Me.CheckSi.Visible = False
        '
        'LabelAtraso
        '
        Me.LabelAtraso.AutoSize = True
        Me.LabelAtraso.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelAtraso.Location = New System.Drawing.Point(189, 92)
        Me.LabelAtraso.Name = "LabelAtraso"
        Me.LabelAtraso.Size = New System.Drawing.Size(138, 19)
        Me.LabelAtraso.TabIndex = 11
        Me.LabelAtraso.Text = "Atraso de entrega :"
        Me.LabelAtraso.Visible = False
        '
        'CheckNo
        '
        Me.CheckNo.AutoSize = True
        Me.CheckNo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckNo.Location = New System.Drawing.Point(281, 122)
        Me.CheckNo.Name = "CheckNo"
        Me.CheckNo.Size = New System.Drawing.Size(46, 23)
        Me.CheckNo.TabIndex = 12
        Me.CheckNo.Text = "No"
        Me.CheckNo.UseVisualStyleBackColor = True
        Me.CheckNo.Visible = False
        '
        'TextMorosidad
        '
        Me.TextMorosidad.Location = New System.Drawing.Point(356, 120)
        Me.TextMorosidad.Name = "TextMorosidad"
        Me.TextMorosidad.Size = New System.Drawing.Size(120, 23)
        Me.TextMorosidad.TabIndex = 13
        Me.TextMorosidad.Visible = False
        '
        'LabelMorosidad
        '
        Me.LabelMorosidad.AutoSize = True
        Me.LabelMorosidad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelMorosidad.Location = New System.Drawing.Point(355, 92)
        Me.LabelMorosidad.Name = "LabelMorosidad"
        Me.LabelMorosidad.Size = New System.Drawing.Size(143, 19)
        Me.LabelMorosidad.TabIndex = 14
        Me.LabelMorosidad.Text = "Dias de Morosidad :"
        Me.LabelMorosidad.Visible = False
        '
        'labelLibros
        '
        Me.labelLibros.AutoSize = True
        Me.labelLibros.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelLibros.Location = New System.Drawing.Point(256, 63)
        Me.labelLibros.Name = "labelLibros"
        Me.labelLibros.Size = New System.Drawing.Size(58, 19)
        Me.labelLibros.TabIndex = 15
        Me.labelLibros.Text = "Libros :"
        '
        'ComboLibros
        '
        Me.ComboLibros.FormattingEnabled = True
        Me.ComboLibros.Location = New System.Drawing.Point(320, 63)
        Me.ComboLibros.Name = "ComboLibros"
        Me.ComboLibros.Size = New System.Drawing.Size(138, 23)
        Me.ComboLibros.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(826, 9)
        Me.Button1.MaximumSize = New System.Drawing.Size(75, 31)
        Me.Button1.MinimumSize = New System.Drawing.Size(75, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Finalizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EstadoDañado
        '
        Me.EstadoDañado.AutoSize = True
        Me.EstadoDañado.Enabled = False
        Me.EstadoDañado.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EstadoDañado.Location = New System.Drawing.Point(103, 122)
        Me.EstadoDañado.Name = "EstadoDañado"
        Me.EstadoDañado.Size = New System.Drawing.Size(76, 23)
        Me.EstadoDañado.TabIndex = 20
        Me.EstadoDañado.Text = "Dañado"
        Me.EstadoDañado.UseVisualStyleBackColor = True
        '
        'LabelEstadoLibro
        '
        Me.LabelEstadoLibro.AutoSize = True
        Me.LabelEstadoLibro.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelEstadoLibro.Location = New System.Drawing.Point(31, 92)
        Me.LabelEstadoLibro.Name = "LabelEstadoLibro"
        Me.LabelEstadoLibro.Size = New System.Drawing.Size(121, 19)
        Me.LabelEstadoLibro.TabIndex = 19
        Me.LabelEstadoLibro.Text = "Estado de Libro :"
        '
        'EstadoNormal
        '
        Me.EstadoNormal.AutoSize = True
        Me.EstadoNormal.Enabled = False
        Me.EstadoNormal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EstadoNormal.Location = New System.Drawing.Point(12, 122)
        Me.EstadoNormal.Name = "EstadoNormal"
        Me.EstadoNormal.Size = New System.Drawing.Size(73, 23)
        Me.EstadoNormal.TabIndex = 18
        Me.EstadoNormal.Text = "Normal"
        Me.EstadoNormal.UseVisualStyleBackColor = True
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(215, 39)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(17, 21)
        Me.ErrorName.TabIndex = 22
        Me.ErrorName.Text = "*"
        Me.ErrorName.Visible = False
        '
        'ErrorLibro
        '
        Me.ErrorLibro.AutoSize = True
        Me.ErrorLibro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ErrorLibro.ForeColor = System.Drawing.Color.Red
        Me.ErrorLibro.Location = New System.Drawing.Point(441, 39)
        Me.ErrorLibro.Name = "ErrorLibro"
        Me.ErrorLibro.Size = New System.Drawing.Size(17, 21)
        Me.ErrorLibro.TabIndex = 23
        Me.ErrorLibro.Text = "*"
        Me.ErrorLibro.Visible = False
        '
        'ErrorPrestamo
        '
        Me.ErrorPrestamo.AutoSize = True
        Me.ErrorPrestamo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ErrorPrestamo.ForeColor = System.Drawing.Color.Red
        Me.ErrorPrestamo.Location = New System.Drawing.Point(610, 64)
        Me.ErrorPrestamo.Name = "ErrorPrestamo"
        Me.ErrorPrestamo.Size = New System.Drawing.Size(17, 21)
        Me.ErrorPrestamo.TabIndex = 24
        Me.ErrorPrestamo.Text = "*"
        Me.ErrorPrestamo.Visible = False
        '
        'PagarTodo
        '
        Me.PagarTodo.Location = New System.Drawing.Point(772, 59)
        Me.PagarTodo.Name = "PagarTodo"
        Me.PagarTodo.Size = New System.Drawing.Size(129, 32)
        Me.PagarTodo.TabIndex = 25
        Me.PagarTodo.UseVisualStyleBackColor = True
        '
        'ErrorMorosidad
        '
        Me.ErrorMorosidad.AutoSize = True
        Me.ErrorMorosidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ErrorMorosidad.ForeColor = System.Drawing.Color.Red
        Me.ErrorMorosidad.Location = New System.Drawing.Point(481, 121)
        Me.ErrorMorosidad.Name = "ErrorMorosidad"
        Me.ErrorMorosidad.Size = New System.Drawing.Size(17, 21)
        Me.ErrorMorosidad.TabIndex = 26
        Me.ErrorMorosidad.Text = "*"
        Me.ErrorMorosidad.Visible = False
        '
        'LabelDeudaPendiente
        '
        Me.LabelDeudaPendiente.AutoSize = True
        Me.LabelDeudaPendiente.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelDeudaPendiente.Location = New System.Drawing.Point(526, 122)
        Me.LabelDeudaPendiente.Name = "LabelDeudaPendiente"
        Me.LabelDeudaPendiente.Size = New System.Drawing.Size(97, 19)
        Me.LabelDeudaPendiente.TabIndex = 27
        Me.LabelDeudaPendiente.Text = "Deuda Total :"
        '
        'LabelPrecioPagarLibro
        '
        Me.LabelPrecioPagarLibro.AutoSize = True
        Me.LabelPrecioPagarLibro.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPrecioPagarLibro.ForeColor = System.Drawing.Color.Red
        Me.LabelPrecioPagarLibro.Location = New System.Drawing.Point(629, 124)
        Me.LabelPrecioPagarLibro.Name = "LabelPrecioPagarLibro"
        Me.LabelPrecioPagarLibro.Size = New System.Drawing.Size(15, 19)
        Me.LabelPrecioPagarLibro.TabIndex = 28
        Me.LabelPrecioPagarLibro.Text = "*"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(921, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelPrecioPagarLibro)
        Me.Controls.Add(Me.LabelDeudaPendiente)
        Me.Controls.Add(Me.ErrorMorosidad)
        Me.Controls.Add(Me.PagarTodo)
        Me.Controls.Add(Me.ErrorPrestamo)
        Me.Controls.Add(Me.ErrorLibro)
        Me.Controls.Add(Me.ErrorName)
        Me.Controls.Add(Me.EstadoDañado)
        Me.Controls.Add(Me.LabelEstadoLibro)
        Me.Controls.Add(Me.EstadoNormal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboLibros)
        Me.Controls.Add(Me.labelLibros)
        Me.Controls.Add(Me.LabelMorosidad)
        Me.Controls.Add(Me.TextMorosidad)
        Me.Controls.Add(Me.CheckNo)
        Me.Controls.Add(Me.LabelAtraso)
        Me.Controls.Add(Me.CheckSi)
        Me.Controls.Add(Me.LabelDiasPrestamos)
        Me.Controls.Add(Me.TxtPrestamo)
        Me.Controls.Add(Me.BtnAccion)
        Me.Controls.Add(Me.OpcionImprimir)
        Me.Controls.Add(Me.OpcionAgregar)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clientes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Button1 As Button
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
End Class
