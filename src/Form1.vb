Imports MySql.Data.MySqlClient

Public Class Form1
    Dim aleatorio As New Random()
    Dim connectionString As String = "server=localhost;user=root;database=sorveteria_projeto;port=3306;password=;"

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBoxMin.Text = "1"
        TextBoxMax.Text = "50"
        ComboBoxHistorial.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    ' --- BOTÓN SORTEAR ---
    Private Sub ButtonSorteo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSorteo.Click
        If Not ComprobarDatos() Then Exit Sub

        Dim min As Integer = CInt(TextBoxMin.Text)
        Dim max As Integer = CInt(TextBoxMax.Text)
        Dim numeroSorteado As Integer = aleatorio.Next(min, max + 1)

        LabelResultado.Text = numeroSorteado.ToString()
        ComboBoxHistorial.Items.Insert(0, numeroSorteado)
        ComboBoxHistorial.SelectedIndex = 0
    End Sub

    ' --- BOTÓN "SIGUIENTE >" ---
    Private Sub ButtonSiguiente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSiguiente.Click
        If ComboBoxHistorial.Items.Count = 0 Then
            MessageBox.Show("El historial está vacío. Primero pulsa 'Sortear'.", "Atención")
            Return
        End If

        Dim idSeleccionado As Integer
        If Integer.TryParse(ComboBoxHistorial.SelectedItem.ToString(), idSeleccionado) Then
            AbrirFicha(idSeleccionado)
        Else
            MessageBox.Show("No se pudo leer el número del historial.", "Error")
        End If
    End Sub

    Private Sub AbrirFicha(ByVal id As Integer)
        Dim dtResultado As New DataTable()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT P.id_producto, P.nombre_producto, P.precio, P.stock, C.nombre_categoria " &
                                     "FROM Productos P INNER JOIN Categorias C ON P.id_categoria = C.id_categoria " &
                                     "WHERE P.id_producto = @id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dtResultado)
            End Using

            If dtResultado.Rows.Count > 0 Then
                ' IMPORTANT: Pass the DataTable to the constructor
                Dim ficha As New Form2(dtResultado)
                ficha.Text = "Resultado ID: " & id
                ficha.ShowDialog()
            Else
                MessageBox.Show("El ID " & id & " no existe en la base de datos.", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error BBDD: " & ex.Message)
        End Try
    End Sub

    ' --- VALIDACIONES ---
    Private Function ComprobarDatos() As Boolean
        Dim n1, n2 As Integer
        If Not Integer.TryParse(TextBoxMin.Text, n1) OrElse Not Integer.TryParse(TextBoxMax.Text, n2) Then
            MessageBox.Show("Entradas inválidas")
            Return False
        End If
        If n1 < 0 OrElse n2 < 0 Then
            MessageBox.Show("No se admiten números negativos")
            Return False
        End If
        If n1 >= n2 Then
            MessageBox.Show("Mínimo debe ser menor al Máximo")
            Return False
        End If
        Return True
    End Function

    Private Sub ReiniciarSorteo() Handles TextBoxMin.TextChanged, TextBoxMax.TextChanged
        ComboBoxHistorial.Items.Clear()
        LabelResultado.Text = "-"
    End Sub
End Class