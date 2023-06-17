Imports System.Data.SqlClient
Public Class Clientes
    'conexion kendrick
    'Public conex As New SqlConnection("Data Source=DESKTOP-GQPJ6BS;Initial Catalog=Biblioteca;Integrated Security=True")
    'Conexion dilan
    Public conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=Biblioteca;Integrated Security=True")
    Const ValorMaxEnterosSQL As Double = 2147483648
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FinzalizarClientes.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el Progreso actual de registro de Clientes?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            'borrar Pagina actual
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            Me.Close()
        End If
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True
        MostrarClientes()
        BtnAccion.Visible = False
        ComboLibros.DropDownStyle = ComboBoxStyle.DropDownList
        MostrarLibros()
        NoVisible()
    End Sub
    Public Sub MostrarClientes()
        conex.Open()
        Dim consulta As String = "select idPrestamos,nombreCl,LibroUso,fechaPrestamo,fechaDevol,deterioro,morosidad,precio from Cliente"
        Dim ejecutar As New SqlCommand(consulta, conex)
        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Cliente")
            Me.DataGridView1.DataSource = dss.Tables("Cliente")
            DataGridView1.Columns("idPrestamos").HeaderText = "ID"
            DataGridView1.Columns("nombreCl").HeaderText = "Nombre"
            DataGridView1.Columns("LibroUso").HeaderText = "Libro"
            DataGridView1.Columns("fechaPrestamo").HeaderText = "Fecha de Prestamo"
            DataGridView1.Columns("fechaDevol").HeaderText = "Fecha de Devolución"
            DataGridView1.Columns("deterioro").HeaderText = "Deterioro"
            DataGridView1.Columns("morosidad").HeaderText = "Dias de Morosidad"
            DataGridView1.Columns("precio").HeaderText = "Precio"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub
    Public Sub MostrarLibros()
        conex.Open()
        Dim mostrarLibrosDisponibles As String = "Select Title from Books where estadoLibro = 'Libre'"
        Dim llenar As New SqlCommand(mostrarLibrosDisponibles, conex)
        Dim reader As SqlDataReader = llenar.ExecuteReader()
        While reader.Read()
            ComboLibros.Items.Add(reader("Title").ToString())
        End While
        reader.Close()
        conex.Close()
    End Sub

    Private Sub BtnAccion_Click(sender As Object, e As EventArgs) Handles BtnAccion.Click
        'Agregar Cliente
        If OpcionAgregar.Checked = True And TextName.Text <> "" And TxtPrestamo.Text <> "" And ComboLibros.Text <> "" Then
            'calculo de valores
            'valor max id
            conex.Open()
            Dim nuevoValor As Integer
            Dim command As New SqlCommand("SELECT ISNULL(MAX(idPrestamos), 0) + 1 AS NuevoValor FROM Cliente", conex)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                nuevoValor = reader.GetInt32(0)
            End If
            reader.Close()
            conex.Close()
            'fecha de prestamo
            Dim fechaPrestamo As DateTime = DateTime.Now
            Dim dias As Double
            Double.TryParse(TxtPrestamo.Text, dias)
            fechaPrestamo = DateAdd("d", dias, fechaPrestamo)
            'precio
            Dim precio As Double
            precio = dias * 0.5
            'Procedimiento almacenado para agregar cliente el libro seleccionado del combo
            Dim procDelete As New SqlCommand()
            conex.Open()
            procDelete.Connection = conex
            procDelete.CommandType = CommandType.StoredProcedure
            procDelete.CommandText = "AddClientes1"
            procDelete.Parameters.AddWithValue("@idPrestamos", nuevoValor)
            procDelete.Parameters.AddWithValue("@nombreCl", TextName.Text)
            procDelete.Parameters.AddWithValue("@LibroUSO", ComboLibros.Text)
            procDelete.Parameters.AddWithValue("@fechaPrestamo", DateTime.Now)
            procDelete.Parameters.AddWithValue("@fechaDevol", fechaPrestamo)
            procDelete.Parameters.AddWithValue("@precio", precio)
            procDelete.Parameters.AddWithValue("@deterioro", "Normal")
            procDelete.Parameters.AddWithValue("@morosidad", 0)
            procDelete.Parameters.AddWithValue("@Estado", "Uso")
            'Ejecutar procedimiento
            procDelete.ExecuteNonQuery()
            MessageBox.Show("Cliente Registrado", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conex.Close()
            ComboLibros.Items.Clear()
            TextName.Text = ""
            TxtPrestamo.Text = ""
            MostrarClientes()
            MostrarLibros()

            ErrorName.Visible = False
            ErrorPrestamo.Visible = False
            ErrorLibro.Visible = False
        Else
            If OpcionAgregar.Checked = False And OpcionImprimir.Checked = False Then

            End If
            If TextName.Text = "" And OpcionAgregar.Checked = True Then
                ErrorName.Visible = True
            End If
            If TxtPrestamo.Text = "" And OpcionAgregar.Checked = True Then
                ErrorPrestamo.Visible = True
            End If
            If ComboLibros.Text = "" And OpcionAgregar.Checked = True Then
                ErrorLibro.Visible = True
            End If
        End If
        'Modificar Registro
        If OpcionImprimir.Checked = True And TextName.Text <> "" And ComboLibros.Text <> "" Then
            '---------------------------
            If EstadoNormal.Checked = True Or EstadoDañado.Checked = True Then
                If CheckSi.Checked = True Or CheckNo.Checked = True Then
                    If CheckSi.Checked = True And TextMorosidad.Text = "" Then
                        MessageBox.Show("Revise el campo de Días de Morosidad, iingrese valor mayores a 0 o desmarque la casilla de Si en Atraso de entrega.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        'errores
                        Exit Sub
                    End If
                    'calculo de valores
                    conex.Open()
                    Dim cmd As New SqlCommand("SELECT DATEDIFF(day, fechaPrestamo, fechaDevol) AS Diferencia FROM Cliente WHERE nombreCl='" & TextName.Text & "' AND LibroUso='" & ComboLibros.Text & "'", conex)
                    Dim dias As Integer = cmd.ExecuteScalar()
                    conex.Close()
                    'precio
                    Dim estado As Double
                    Dim DeterioroLibro As String = ""
                    If EstadoNormal.Checked = True Then
                        estado = 0.0
                        DeterioroLibro = EstadoNormal.Text
                    Else
                        If EstadoDañado.Checked = True Then
                            estado = 20.0
                            DeterioroLibro = EstadoDañado.Text
                        End If
                    End If
                    Dim diasMorosidad As Integer
                    Integer.TryParse(TextMorosidad.Text, diasMorosidad)
                    Dim precio As Double
                    precio = (dias * 0.5) + (diasMorosidad * 0.75) + estado
                    'Procedimiento almacenado para agregar cliente el libro seleccionado del combo
                    conex.Open()
                    Dim procDelete As New SqlCommand()
                    procDelete.Connection = conex
                    procDelete.CommandType = CommandType.StoredProcedure
                    procDelete.CommandText = "ActualizarClientes"
                    procDelete.Parameters.AddWithValue("@nombreCl", TextName.Text)
                    procDelete.Parameters.AddWithValue("@LibroUSO", ComboLibros.Text)
                    procDelete.Parameters.AddWithValue("@precio", precio)
                    procDelete.Parameters.AddWithValue("@deterioro", DeterioroLibro)
                    procDelete.Parameters.AddWithValue("@morosidad", diasMorosidad)
                    'Ejecutar procedimiento
                    procDelete.ExecuteNonQuery()
                    MessageBox.Show("Registro de Cliente Modificado", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conex.Close()
                    LimpiarCampos()
                    'dias de atraso
                    LabelAtraso.Visible = True
                    CheckSi.Checked = False
                    CheckNo.Checked = False
                    EstadoNormal.Checked = False
                    EstadoDañado.Checked = False
                    'errores
                    ErrorPrestamo.Visible = False
                    ErrorLibro.Visible = False
                    ErrorName.Visible = False
                    ErrorMorosidad.Visible = False
                    '---------------------------
                Else
                    MessageBox.Show("Revise que se encuentre seleccionada minimo una opcion de Atraso de la entrega", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'errores

                End If
            Else
                'errores
                MessageBox.Show("Revise que se encuentre seleccionada minimo una opcion de Estado del Libro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Public Sub LimpiarCampos()
        TextName.Text = ""
        TextMorosidad.Text = ""
        TxtPrestamo.Text = ""
        'dias de atraso
        LabelAtraso.Visible = True
        CheckSi.Checked = False
        CheckNo.Checked = False
        'estado del libro
        EstadoNormal.Checked = False
        EstadoDañado.Checked = False
        'errores
        ErrorPrestamo.Visible = False
        ErrorLibro.Visible = False
        ErrorName.Visible = False
        ErrorMorosidad.Visible = False
    End Sub
    Public Sub NoVisible()
        labelLibros.Visible = False
        ComboLibros.Visible = False
        'dias de atraso
        LabelAtraso.Visible = False
        CheckSi.Visible = False
        CheckNo.Visible = False
        'morosidad
        LabelMorosidad.Visible = False
        TextMorosidad.Visible = False
        'estado del libro
        LabelEstadoLibro.Visible = False
        EstadoNormal.Enabled = False
        EstadoNormal.Visible = False
        EstadoDañado.Enabled = False
        EstadoDañado.Visible = False
        'dias de prestamo
        LabelDiasPrestamos.Visible = False
        TxtPrestamo.Visible = False
        'btns
        BtnAccion.Visible = False
        PagarTodo.Visible = False
        'errores
        ErrorPrestamo.Visible = False
        ErrorLibro.Visible = False
        ErrorName.Visible = False
        ErrorMorosidad.Visible = False
        'Resultados 
        LabelDeudaPendiente.Visible = False
        LabelPrecioPagarLibro.Visible = False
    End Sub
    Private Sub OpcionAgregar_click(sender As Object, e As EventArgs) Handles OpcionAgregar.Click
        LimpiarCampos()
        ComboLibros.Items.Clear()
        MostrarLibros()
        OpcionImprimir.Checked = False
        If OpcionAgregar.Checked = False And OpcionImprimir.Checked = False Then
            NoVisible()
        Else
            If OpcionAgregar.Checked = True And OpcionImprimir.Checked = False Then
                NoVisible()
                labelLibros.Visible = True
                ComboLibros.Visible = True
                'dias de prestamo
                LabelDiasPrestamos.Visible = True
                TxtPrestamo.Visible = True
                'btns
                BtnAccion.Visible = True
                BtnAccion.BackColor = Color.Green
                BtnAccion.Text = " Agregar "
            End If
        End If
    End Sub

    Private Sub OpcionImprimir_Click(sender As Object, e As EventArgs) Handles OpcionImprimir.Click
        LimpiarCampos()
        OpcionAgregar.Checked = False
        If OpcionAgregar.Checked = False And OpcionImprimir.Checked = False Then
            NoVisible()
        Else
            If OpcionImprimir.Checked = True And OpcionAgregar.Checked = False Then
                NoVisible()
                labelLibros.Visible = True
                ComboLibros.Items.Clear()
                ComboLibros.Visible = True
                'dias de atraso
                LabelAtraso.Visible = True
                CheckSi.Enabled = True
                CheckSi.Visible = True
                CheckNo.Enabled = True
                CheckNo.Visible = True
                'estado del libro
                LabelEstadoLibro.Visible = True
                EstadoNormal.Visible = True
                EstadoNormal.Enabled = True
                EstadoDañado.Visible = True
                EstadoDañado.Enabled = True
                'btns
                BtnAccion.Text = "Modificar"
                BtnAccion.BackColor = Color.Orange
                BtnAccion.Visible = False
                PagarTodo.Visible = False
                PagarTodo.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub CheckSi_Click(sender As Object, e As EventArgs) Handles CheckSi.Click
        If CheckNo.Checked = False And CheckSi.Checked = False Then
            'morosidad
            LabelMorosidad.Visible = False
            TextMorosidad.Visible = False
        Else
            CheckNo.Checked = False
            'morosidad
            LabelMorosidad.Visible = True
            TextMorosidad.Visible = True
        End If
    End Sub

    Private Sub CheckNo_Click(sender As Object, e As EventArgs) Handles CheckNo.Click
        If CheckNo.Checked = False And CheckSi.Checked = False Then
            'morosidad
            LabelMorosidad.Visible = False
            TextMorosidad.Visible = False
        Else
            CheckSi.Checked = False
            'morosidad
            LabelMorosidad.Visible = False
            TextMorosidad.Visible = False
        End If
    End Sub

    Private Sub EstadoNormal_Click(sender As Object, e As EventArgs) Handles EstadoNormal.Click
        EstadoDañado.Checked = False
    End Sub

    Private Sub EstadoDañado_Click(sender As Object, e As EventArgs) Handles EstadoDañado.Click
        EstadoNormal.Checked = False
    End Sub
    'filtro de Cliente
    Public Sub MostrarLibrosDelCliente()
        conex.Open()
        Dim cmd As New SqlCommand("SELECT LibroUso FROM Cliente WHERE nombreCl LIKE @myValue", conex)
        cmd.Parameters.AddWithValue("@myValue", "%" & TextName.Text & "%")
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ComboLibros.DataSource = dt
            ComboLibros.DisplayMember = "LibroUso"
        Else
            ComboLibros.DataSource = Nothing
            ComboLibros.Items.Clear()
        End If
        conex.Close()
    End Sub
    Private Sub TextName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Enter) And Not e.KeyChar = ChrW(Keys.Back) And Not e.KeyChar = " " And Not e.KeyChar = "/" Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextMorosidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextMorosidad.KeyPress, TxtPrestamo.KeyPress
        If Char.IsLetter(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Enter) And Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextName_TextChanged(sender As Object, e As EventArgs) Handles TextName.TextChanged

        Dim i As Integer
        For i = 1 To Len(TextName.Text)
            If Not IsNumeric(Mid(TextName.Text, i, 1)) Then
                If Not Mid(TextName.Text, i, 1) Like "[A-Ñ-Z0-9 a-ñ-z]" Then
                    Dim Borrar As String = TextName.Text.Remove(TextName.Text.Length - 1)
                    TextName.Text = Borrar
                    TextName.SelectionStart = TextName.Text.Length
                    Exit Sub
                End If
            Else
                Dim Borrar As String = TextName.Text.Remove(TextName.Text.Length - 1)
                TextName.Text = Borrar
                TextName.SelectionStart = TextName.Text.Length
                Exit Sub
            End If
        Next i
        If TextName.Text = “” Or IsNumeric(TextName.Text) Or TextName.Text.Length > 50 Or TextName.Text = "" Then
            If TextName.Text = “” Or TextName.Text = "" Then
                ComboLibros.DataSource = Nothing
                ComboLibros.Items.Clear()
                MostrarClientes()
                PagarTodo.Visible = False
                ErrorName.Visible = True
            End If
            If TextName.Text.Length > 50 Or IsNumeric(TextName.Text) Then
                Dim Borrar As String = TextName.Text.Remove(TextName.Text.Length - 1)
                TextName.Text = Borrar
                TextName.SelectionStart = TextName.Text.Length
            End If
        Else
            ErrorName.Visible = False
            If OpcionImprimir.Checked = True Then
                '-------------------------
                DataGridView1.ClearSelection()
                conex.Open()

                Dim cmd As New SqlCommand("SELECT idPrestamos,nombreCl,LibroUso,fechaPrestamo,fechaDevol,deterioro,morosidad,precio FROM Cliente WHERE UPPER(nombreCl) LIKE UPPER(@myValue)", conex)
                cmd.Parameters.AddWithValue("@myValue", "%" & TextName.Text & "%")
                Dim tabla As New SqlDataAdapter(cmd)

                Dim dss As New DataSet
                tabla.Fill(dss, "Cliente")
                Me.DataGridView1.DataSource = dss.Tables("Cliente")
                conex.Close()
                MostrarLibrosDelCliente()
                Dim suma As Double
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells("nombreCl").Value IsNot Nothing AndAlso row.Cells("nombreCl").Value.ToString().ToLower() = TextName.Text Or row.Cells("nombreCl").Value.ToString() = TextName.Text Then
                        PagarTodo.Visible = True
                        'btnAccion
                        BtnAccion.Visible = False
                        row.Selected = True
                        suma += Convert.ToDouble(row.Cells("precio").Value)
                        PagarTodo.Text = "Pagar Todo"
                        'Resultados 
                        LabelDeudaPendiente.Visible = True
                        LabelDeudaPendiente.Text = "Deuda Total : "
                        LabelPrecioPagarLibro.Visible = True
                        LabelPrecioPagarLibro.Text = suma.ToString("C")
                    Else
                        PagarTodo.Visible = False
                        'Resultados 
                        LabelDeudaPendiente.Visible = False
                        LabelPrecioPagarLibro.Visible = False
                    End If
                Next
                '-----------------------
            End If
        End If
    End Sub

    Private Sub ComboLibros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboLibros.SelectedIndexChanged
        If OpcionImprimir.Checked = True And TextName.Text <> "" And ComboLibros.Text <> "" Then
            '-------------------------
            Dim encontrado As Boolean = False
            DataGridView1.Sort(DataGridView1.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
            DataGridView1.ClearSelection()
            Dim suma As Double
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("nombreCl").Value IsNot Nothing AndAlso row.Cells("LibroUso").Value IsNot Nothing Then
                    If row.Cells("nombreCl").Value.ToString().ToLower() = TextName.Text Or row.Cells("nombreCl").Value.ToString() = TextName.Text Then
                        If row.Cells("LibroUso").Value.ToString().ToLower() = ComboLibros.Text Or row.Cells("LibroUso").Value.ToString() = ComboLibros.Text Then
                            encontrado = True
                            row.Selected = True
                            suma += Convert.ToDouble(row.Cells("precio").Value)
                            'mostrar solo el buscado)
                            'btns
                            BtnAccion.Visible = True

                            PagarTodo.Text = "Pagar"

                            'Resultados 
                            LabelDeudaPendiente.Visible = True
                            LabelDeudaPendiente.Text = "Deuda: "
                            LabelPrecioPagarLibro.Visible = True
                            LabelPrecioPagarLibro.Text = suma.ToString("C")
                        End If
                    End If
                End If
            Next
            If Not encontrado Then
                'Resultados 
                LabelDeudaPendiente.Visible = False
                LabelPrecioPagarLibro.Visible = False
                BtnAccion.Visible = False
                DataGridView1.ClearSelection()
            End If
            '-----------------------
        End If
    End Sub
    Private Sub PagarTodo_Click(sender As Object, e As EventArgs) Handles PagarTodo.Click
        If PagarTodo.Text = "Pagar" And OpcionImprimir.Checked = True And TextName.Text <> "" And ComboLibros.Text <> "" Then
            'Procedimiento almacenado para agregar cliente el libro seleccionado del combo
            conex.Open()
            Dim procDelete As New SqlCommand()
            procDelete.Connection = conex
            procDelete.CommandType = CommandType.StoredProcedure
            procDelete.CommandText = "EliminarLibroCliente"
            procDelete.Parameters.AddWithValue("@nombreCl", TextName.Text)
            procDelete.Parameters.AddWithValue("@Titlle", ComboLibros.Text)
            procDelete.Parameters.AddWithValue("@estadoLibro", "Libre")
            'Ejecutar procedimiento
            procDelete.ExecuteNonQuery()
            MessageBox.Show("Prestamo Pagado", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conex.Close()
            LimpiarCampos()
        End If
        If PagarTodo.Text = "Pagar Todo" And TextName.Text <> "" Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("nombreCl").Value IsNot Nothing AndAlso row.Cells("nombreCl").Value.ToString().ToLower() = TextName.Text Or row.Cells("nombreCl").Value.ToString() = TextName.Text Then
                    Dim cad1 As String = row.Cells("nombreCl").Value.ToString()
                    Dim cad2 As String = row.Cells("LibroUso").Value.ToString()
                    'Procedimiento almacenado para agregar cliente el libro seleccionado del combo
                    conex.Open()
                    Dim procDelete As New SqlCommand()
                    procDelete.Connection = conex
                    procDelete.CommandType = CommandType.StoredProcedure
                    procDelete.CommandText = "EliminarLibroCliente"
                    procDelete.Parameters.AddWithValue("@nombreCl", cad1)
                    procDelete.Parameters.AddWithValue("@Titlle", cad2)
                    procDelete.Parameters.AddWithValue("@estadoLibro", "Libre")
                    'Ejecutar procedimiento
                    procDelete.ExecuteNonQuery()
                    conex.Close()
                End If
            Next
            LimpiarCampos()
            MessageBox.Show("Prestamo Pagado", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TextMorosidad_TextChanged(sender As Object, e As EventArgs) Handles TextMorosidad.TextChanged
        Dim i As Integer
        For i = 1 To Len(TextMorosidad.Text)
            If Not IsNumeric(Mid(TextMorosidad.Text, i, 1)) Then
                Dim Borrar As String = TextMorosidad.Text.Remove(TextMorosidad.Text.Length - 1)
                TextMorosidad.Text = Borrar
                TextMorosidad.SelectionStart = TextMorosidad.Text.Length
                Exit Sub
            End If
        Next i
        Dim valor As Double
        Double.TryParse(TextMorosidad.Text, valor)
        If TextMorosidad.Text = “” Or Not valor > 0 Or valor >= ValorMaxEnterosSQL Or TextMorosidad.Text.Length > 10 Or TextMorosidad.Text = Nothing Then
            If TextMorosidad.Text = “” Then
                ErrorMorosidad.Visible = True
            End If
            If valor >= ValorMaxEnterosSQL Or TextMorosidad.Text.Length > 9 Then
                Dim Borrar As String = TextMorosidad.Text.Remove(TextMorosidad.Text.Length - 1)
                TextMorosidad.Text = Borrar
                TextMorosidad.SelectionStart = TextMorosidad.Text.Length
            End If
            If TextMorosidad.Text = Nothing Or Not valor > 0 Then
                TextMorosidad.Text = ""
            End If
        Else
            ErrorMorosidad.Visible = False
        End If
    End Sub

    Private Sub TxtPrestamo_TextChanged(sender As Object, e As EventArgs) Handles TxtPrestamo.TextChanged

        Dim i As Integer
        For i = 1 To Len(TxtPrestamo.Text)
            If Not IsNumeric(Mid(TxtPrestamo.Text, i, 1)) Then
                Dim Borrar As String = TxtPrestamo.Text.Remove(TxtPrestamo.Text.Length - 1)
                TxtPrestamo.Text = Borrar
                TxtPrestamo.SelectionStart = TxtPrestamo.Text.Length
                Exit Sub
            End If
        Next i
        Dim valor As Double
        Double.TryParse(TxtPrestamo.Text, valor)
        If TxtPrestamo.Text = “” Or Not valor > 0 Or valor > 1000000 Or valor >= ValorMaxEnterosSQL Or TxtPrestamo.Text.Length > 9 Or TxtPrestamo.Text = Nothing Then
            If TxtPrestamo.Text = “” Then
                ErrorPrestamo.Visible = True
            End If
            If valor >= ValorMaxEnterosSQL Or TxtPrestamo.Text.Length > 10 Or valor > 1000000 Then
                Dim Borrar As String = TxtPrestamo.Text.Remove(TxtPrestamo.Text.Length - 1)
                TxtPrestamo.Text = Borrar
                TxtPrestamo.SelectionStart = TxtPrestamo.Text.Length
            End If
            If TxtPrestamo.Text = Nothing Or Not valor > 0 Then
                TxtPrestamo.Text = ""
            End If
        Else
            ErrorPrestamo.Visible = False
        End If
    End Sub

    Private Sub OpcionAgregar_CheckedChanged(sender As Object, e As EventArgs) Handles OpcionAgregar.CheckedChanged

    End Sub

    Private Sub OpcionImprimir_CheckedChanged(sender As Object, e As EventArgs) Handles OpcionImprimir.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class