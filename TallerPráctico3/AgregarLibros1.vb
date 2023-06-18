Imports System.Data.SqlClient

Public Class AgregarLibros1

    'Función que muestra la tabla de libros con las columnas de interés en la pantalla que se carga
    'Se puede modificar la instrucción y seleccionar nombre del libro con el estado o lo que te apetezca
    'Acá puse monstrar toda la tabla
    'Además actualiza cuando se hacen cambios en la tabla

    'conexion kendrick
    Public conex As New SqlConnection("Data Source=DESKTOP-GQPJ6BS;Initial Catalog=Biblioteca;Integrated Security=True")

    'Conexion dilan
    'Public conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=Biblioteca;Integrated Security=True")


    Public Sub MostrarLibros()
        Dim consulta As String = "Select * From Books"
        Dim ejecutar As New SqlCommand(consulta, conex)

        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Books")

            Me.Data.DataSource = dss.Tables("Books")
            Data.Columns("IdLibro").HeaderText = "ID"

            Data.Columns("Title").HeaderText = "Título del Libro"
            Data.Columns("estadoLibro").HeaderText = "Estado del Libro"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conex.Close()
        End Try

    End Sub

    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ocultar()
        MostrarLibros()
        procesar.Enabled = False

    End Sub


    'Procesar es para seleccionar que tipo de libro se va a introducir ... Nuevo autor o con autor existente.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles procesar.Click
        If opcionExiste.Checked = True And opcionNuevo.Checked = True Or
            opcionExiste.Checked = False And opcionNuevo.Checked = False Then
            MessageBox.Show("Selecciona una opción", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error)
            opcionExiste.Checked = False
            opcionNuevo.Checked = False
            procesar.Enabled = False
        ElseIf opcionExiste.Checked = True Then

            'Muestra los componentes para introducir los datos de nuevo libro con autor existente
            MostrarExiste()
            GroupBox1.Enabled = False

            'de deshabilita la caja de seleccion para no poder echar para atras 

            'Esta parte para abajo llena el combobox con los autores que existen en la base de datos

            Dim mostrarAutores As String = "select Name from Authors"
            Dim llenar As New SqlCommand(mostrarAutores, conex)

            conex.Open()

            Dim reader As SqlDataReader = llenar.ExecuteReader()

            While reader.Read()
                autoresExisCombo.Items.Add(reader("Name").ToString())
            End While

            reader.Close()

            conex.Close()


        ElseIf opcionNuevo.Checked = True Then

            'Muestra los componentes para poder introducir un nuevo libro
            MostrarNuevo()
            GroupBox1.Enabled = False

            'de deshabilita la caja de seleccion para no poder echar para atras 

        End If
    End Sub

    'Funcion para ocultar los componentes de nuevo libro cuando se carga el form
    Public Sub Ocultar()
        inputLibro.Visible = False
        inputNombre.Visible = False
        autoresExisCombo.Visible = False
        autorExistenteLb.Visible = False
        tituloLibroLb.Visible = False
        nombreAutorNew.Visible = False
        inputCountry.Visible = False
        residenciaAutorLb.Visible = False
    End Sub

    'Funcion para monstrar componentes para nuevo libro y autor
    Public Sub MostrarNuevo()
        inputLibro.Visible = True
        inputNombre.Visible = True
        autoresExisCombo.Visible = False
        autorExistenteLb.Visible = False
        tituloLibroLb.Visible = True
        nombreAutorNew.Visible = True
        inputCountry.Visible = True
        residenciaAutorLb.Visible = True
    End Sub


    'Funcion para mostrar componentes para nuevo libro con autor existente
    Public Sub MostrarExiste()
        inputCountry.Visible = False
        residenciaAutorLb.Visible = False
        inputLibro.Visible = True
        inputNombre.Visible = False
        autoresExisCombo.Visible = True
        autorExistenteLb.Visible = True
        tituloLibroLb.Visible = True
        nombreAutorNew.Visible = False
    End Sub


    'KeyPress para controlar ACSII para input a tabla
    Private Sub InputNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputNombre.KeyPress
        Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 " ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub


    'KeyPress para controlar ACSII para input a tabla
    Private Sub InputLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputLibro.KeyPress
        Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 " ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub


    'Habilitar boton de procesar con una seleccion de checkbox
    Private Sub OpcionExiste_CheckedChanged(sender As Object, e As EventArgs) Handles opcionExiste.CheckedChanged
        If opcionExiste.Checked = False Then
            procesar.Enabled = False
        Else
            procesar.Enabled = True
        End If
    End Sub


    'Habilitar boton de procesar con una seleccion de checkbox
    Private Sub OpcionNuevo_CheckedChanged(sender As Object, e As EventArgs) Handles opcionNuevo.CheckedChanged
        If opcionNuevo.Checked = False Then
            procesar.Enabled = False
        Else
            procesar.Enabled = True
        End If
    End Sub


    'Boton de agrega datos a las tablas y hace los cambios
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles agregar.Click
        If opcionExiste.Checked = True Then
            If autoresExisCombo.SelectedItem = Nothing Then
                MessageBox.Show("AUTOR INCORRECTO", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If inputLibro.Text = Nothing Then
                    MessageBox.Show("INTRODUCE NOMBRE DEL LIBRO", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    'Procedimiento para agregar libro con procedimiento almacenado
                    Try
                        conex.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try

                    Dim procAdd As New SqlCommand()
                    procAdd.Connection = conex

                    procAdd.CommandType = CommandType.StoredProcedure

                    procAdd.CommandText = "AddLibro"

                    'Parámetros que necesita el procedimiento

                    procAdd.Parameters.AddWithValue("@Name", autoresExisCombo.SelectedItem)
                    procAdd.Parameters.AddWithValue("@Title", inputLibro.Text)
                    procAdd.Parameters.AddWithValue("@estadoLibro", "Libre")

                    'Ejecucion del procedimiento

                    Dim answer1 As Integer

                    answer1 = MsgBox("¿DESEAS AGREGAR DEFINIVAMENTE ESTE LIBRO? ", vbYesNo)

                    If answer1 = vbYes Then

                        procAdd.ExecuteNonQuery()

                        MessageBox.Show("NUEVO LIBRO AGREGADO", "COMPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        MostrarLibros()

                        GroupBox2.Enabled = False

                        registradoClear()

                    Else

                    End If

                    conex.Close()

                    'Cierra conexion y actualiza tablas

                End If
            End If

        ElseIf opcionNuevo.Checked = True Then

            If inputNombre.Text = Nothing Then
                MessageBox.Show("COLOCA UN NOMBRE AL AUTOR", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                If inputCountry.Text = Nothing Then
                    MessageBox.Show("COLOCA PAÍS DEL AUTOR", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    If inputLibro.Text = Nothing Then
                        MessageBox.Show("COLOCA UN NOMBRE AL LIBRO", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else

                        'Procedimiento para agregar libro con nuevo autor
                        Try
                            conex.Open()
                        Catch ex As Exception
                            MsgBox(ex.Message.ToString)
                        End Try

                        Dim procAddNew As New SqlCommand()
                        procAddNew.Connection = conex

                        procAddNew.CommandType = CommandType.StoredProcedure

                        procAddNew.CommandText = "AddLibroNewAutor"

                        procAddNew.Parameters.AddWithValue("@Name", inputNombre.Text)

                        procAddNew.Parameters.AddWithValue("@Country", inputCountry.Text)

                        procAddNew.Parameters.AddWithValue("@Title", inputLibro.Text)

                        'Ejecuta procedimiento

                        Dim answer2 As Integer

                        answer2 = MsgBox("¿DESEAS AGREGAR ESTE AUTOR CON SU LIBRO? ", vbYesNo)

                        If answer2 = vbYes Then
                            procAddNew.ExecuteNonQuery()

                            MessageBox.Show("NUEVO LIBRO Y AUTOR AGREGADOS", "COMPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            GroupBox2.Enabled = False

                            MostrarLibros()

                            registradoClear()
                        Else

                        End If

                        conex.Close()

                        'Cierra conexion y actualiza tablas
                    End If

                End If

            End If

        End If
    End Sub

    Private Sub FinalizarForm_Click(sender As Object, e As EventArgs) Handles FinalizarForm.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el Modo de Agregar Libros?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            'borrar Pagina actual
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            Me.Close()
        End If
    End Sub

    Private Sub inputCountry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputCountry.KeyPress
        Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 " ' Agrega los caracteres permitidos aquí
        If Not allowedChars.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub


    Public Sub registradoClear()
        autoresExisCombo.SelectedIndex = -1
        inputNombre.Clear()
        inputCountry.Clear()
        inputLibro.Clear()
        opcionExiste.Checked = False
        opcionNuevo.Checked = False
        GroupBox2.Enabled = True
        GroupBox1.Enabled = True
    End Sub

End Class
