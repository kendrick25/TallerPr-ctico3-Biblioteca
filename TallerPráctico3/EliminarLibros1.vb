Imports System.Data.SqlClient
Public Class EliminarLibros1

    'conexion kendrick
    Public conex As New SqlConnection("Data Source=DESKTOP-GQPJ6BS;Initial Catalog=Biblioteca;Integrated Security=True")
    'Conexion dilan
    'Public conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=Biblioteca;Integrated Security=True")

    'Igual que en el form de agregar, se aplica la funcion mostrar tabla para ir actualizando
    Public Sub MostrarLibros()
        Dim consulta As String = "select Title, estadoLibro from Books where estadoLibro = 'Libre'"
        Dim ejecutar As New SqlCommand(consulta, conex)
        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Books")
            Me.Data2.DataSource = dss.Tables("Books")

            Data2.Columns("Title").HeaderText = "Título del Libro"
            Data2.Columns("estadoLibro").HeaderText = "Estado del Libro"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conex.Close()
        End Try

    End Sub


    'Mostrar los libros prestados o en uso cuando se carga la pantalla de borrar
    'Las separo para aclarar que no se pueden eliminar libros que estén prestados... almenos que se los hayan robado
    Public Sub MostrarPrestados()

        Dim consultaUso As String = "select Title, estadoLibro from Books where estadoLibro = 'Uso'"

        Dim ejecutar As New SqlCommand(consultaUso, conex)

        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Books")

            Me.data3.DataSource = dss.Tables("Books")
            data3.Columns("Title").HeaderText = "Título del Libro"
            data3.Columns("estadoLibro").HeaderText = "Estado del Libro"

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub


    'Funcion que me muestra en un combobox los autores que se quedaron registrados y sin libros en caso que se elimine
    'el libro de este autor. Sirve para tener la opcion de eliminarlos si no se quieren en los registros.
    Public Sub LibrosSinAutor()

        Dim mostrarSinAutores As String = "SELECT Name FROM Authors au LEFT JOIN BooksAuthors ba ON au.Id = ba.AuthorId WHERE ba.AuthorId IS NULL;"
        Dim llenar As New SqlCommand(mostrarSinAutores, conex)

        Try
            conex.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim reader2 As SqlDataReader = llenar.ExecuteReader()

        While reader2.Read()
            autoresSinLibro.Items.Add(reader2("Name").ToString())
        End While

        reader2.Close()

        conex.Close()

    End Sub


    'Cuando se cargue la pantalla de borrar un ejemplar, me muestra los libros que estén libres y con opciones
    'para eliminar
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboToDelete.DropDownStyle = ComboBoxStyle.DropDownList
        autoresSinLibro.DropDownStyle = ComboBoxStyle.DropDownList
        MostrarLibros()

        MostrarPrestados()

        LibrosSinAutor()

        'Me llena el combobox con los libros que se pueden eliminar, es decir los que tengan el estado de
        '"libre" y que se cargan tambien cuando inicia el form

        Dim mostrarToDelete As String = "Select Title from Books where estadoLibro = 'Libre'"
        Dim llenar As New SqlCommand(mostrarToDelete, conex)

        Try
            conex.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim reader As SqlDataReader = llenar.ExecuteReader()

        While reader.Read()
            comboToDelete.Items.Add(reader("Title").ToString())
        End While

        reader.Close()

        conex.Close()

    End Sub


    'Boton para eliminar el libro con una de las opciones seleccionadas...
    'Se podria controlar mejor por si se hace alguna trampa y no se selecciona nada... en vez de items..
    'con el indice seleccionado, pero trabaja igual si se ejecuta bien
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles borrarLibro.Click
        If comboToDelete.SelectedItem = Nothing Then
            MessageBox.Show("Selecciona una opción", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                conex.Open()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            Dim procDelete As New SqlCommand()
            'Procedimiento almacenado para eliminar el libro seleccionado del combo
            procDelete.Connection = conex

            procDelete.CommandType = CommandType.StoredProcedure

            procDelete.CommandText = "EliminarLibro"

            procDelete.Parameters.AddWithValue("@Title", comboToDelete.SelectedItem)

            'Ejecutar procedimiento

            Dim answer3 As Integer

            answer3 = MsgBox("¿DESEAS ELIMINAR DEFINIVAMENTE ESTE LIBRO? ", vbYesNo)

            If answer3 = vbYes Then

                procDelete.ExecuteNonQuery()

                MessageBox.Show("LIBRO ELIMINADO", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                MostrarLibros()
            Else

            End If

            conex.Close()

            'cerrar conexion y actualizar tabla
        End If
    End Sub


    'Boton para elimnar autores sin libros si se quiere... 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles deleteSinLibro.Click

        If autoresSinLibro.Items.Count < 1 Then
            MessageBox.Show("NO HAY AUTORES", "SIN ACCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If autoresSinLibro.SelectedItem = Nothing Then
                MessageBox.Show("SELECCION ERRÓNEA", "VERIFICA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                Try
                    conex.Open()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                Dim procDeleteAuto As New SqlCommand()
                'Procedimiento que me elimina los autores sin libro

                procDeleteAuto.Connection = conex

                procDeleteAuto.CommandType = CommandType.StoredProcedure

                procDeleteAuto.CommandText = "eliminarSinLibro"

                procDeleteAuto.Parameters.AddWithValue("@Name", autoresSinLibro.SelectedItem)


                Dim answer4 As Integer

                answer4 = MsgBox("¿DESEAS ELIMINAR ESTE AUTOR SIN LIBROS? ", vbYesNo)

                If answer4 = vbYes Then

                    procDeleteAuto.ExecuteNonQuery()

                    MessageBox.Show("AUTOR ELIMINADO", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LibrosSinAutor()
                Else

                End If

                conex.Close()

                'Cerrar conexion y actualizar combo
            End If

        End If

    End Sub

    Private Sub BtnFinalizarEliminar_Click(sender As Object, e As EventArgs) Handles BtnFinalizarEliminar.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el modo de Eliminar Libros?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then

        Else
            'borrar Pagina actual
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            Me.Close()
        End If
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
