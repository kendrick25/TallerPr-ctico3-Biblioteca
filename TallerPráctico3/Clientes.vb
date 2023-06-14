Imports System.Data.SqlClient
Public Class Clientes
    'conexion kendrick
    Private conex As New SqlConnection("Data Source=DESKTOP-GQPJ6BS;Initial Catalog=Biblioteca;Integrated Security=True")
    'Conexion dilan
    'Dim conex As New SqlConnection("Data Source=DESKTOP-8ELH4DT;Initial Catalog=Biblioteca;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        MostrarClientes()
    End Sub
    Public Sub MostrarClientes()
        Dim consulta As String = "select Title, estadoLibro from Books where estadoLibro = 'Libre'"
        Dim ejecutar As New SqlCommand(consulta, conex)
        Try
            Dim tabla As New SqlDataAdapter(ejecutar)
            Dim dss As New DataSet
            tabla.Fill(dss, "Books")

            Me.DataGridView1.DataSource = dss.Tables("Cliente")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub
End Class