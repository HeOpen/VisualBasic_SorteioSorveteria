Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO

Public Class Form2
    ' Class-level variable to store the data passed from Form1
    Private _datosOriginales As DataTable
    Dim connectionString As String = "server=localhost;user=root;database=sorveteria_projeto;port=3306;password=;"

    ' SINGLE CONSTRUCTOR: Correctly assigned
    Public Sub New(ByVal datos As DataTable)
        InitializeComponent()
        _datosOriginales = datos

        ' Initialize UI
        If _datosOriginales IsNot Nothing Then
            ActualizarPantalla(_datosOriginales)
        End If
    End Sub

    ' --- LÓGICA DE PANTALLA ---
    Private Sub ActualizarPantalla(ByVal dt As DataTable)
        CargarGrafico(dt)
        DataGridView1.DataSource = dt
        ConfigurarGrid()
    End Sub

    Private Sub ConfigurarGrid()
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CargarGrafico(ByVal dt As DataTable)
        If Chart1 Is Nothing Then Return
        Chart1.Series.Clear()

        Dim serie As New Series("Stock")
        serie.ChartType = SeriesChartType.Column

        ' Restore Label Logic for clarity
        serie.IsValueShownAsLabel = True

        For Each fila As DataRow In dt.Rows
            Dim nombre As String = fila("nombre_producto").ToString()
            Dim stock As Integer = If(IsDBNull(fila("stock")), 0, Convert.ToInt32(fila("stock")))
            serie.Points.AddXY(nombre, stock)
        Next
        Chart1.Series.Add(serie)
    End Sub

    ' --- RESTORED: SELECCIONAR TODA LA BASE DE DATOS ---
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dtTodos As New DataTable()
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                ' Query to fetch all products regardless of the raffle
                Dim query As String = "SELECT P.id_producto, P.nombre_producto, P.precio, P.stock, C.nombre_categoria " &
                                     "FROM Productos P INNER JOIN Categorias C ON P.id_categoria = C.id_categoria"

                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(dtTodos)
            End Using

            ' Update the screen with the complete database info
            ActualizarPantalla(dtTodos)
        Catch ex As Exception
            MessageBox.Show("Error al cargar todos los datos: " & ex.Message)
        End Try
    End Sub

    ' --- RESTORED: CAMBIO DE ESTILO DE GRÁFICOS ---
    Private Sub GraficosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraficosToolStripMenuItem.Click
        Try
            ' Toggle Palette
            If Chart1.Palette = ChartColorPalette.BrightPastel Then
                Chart1.Palette = ChartColorPalette.Fire
            Else
                Chart1.Palette = ChartColorPalette.BrightPastel
            End If

            ' Toggle 3D View
            If Chart1.ChartAreas.Count > 0 Then
                Chart1.ChartAreas(0).Area3DStyle.Enable3D = Not Chart1.ChartAreas(0).Area3DStyle.Enable3D
            End If
        Catch ex As Exception
            ' Silent fail if chart area is not initialized
        End Try
    End Sub

    ' --- PRUEBAS AUTOMATIZADAS ---
    Private Sub EjecutarPruebasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EjecutarPruebasToolStripMenuItem.Click
        ' We verify the current data in the Grid to run tests on what is visible
        Dim dtActual As DataTable = TryCast(DataGridView1.DataSource, DataTable)

        If dtActual IsNot Nothing Then
            ModTests.EjecutarSuitePruebas(dtActual)
        Else
            MessageBox.Show("No hay datos para analizar.")
        End If
    End Sub

    ' --- EXPORTACIÓN Y CIERRE ---
    Private Sub ExportarTXTToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExportarTXTToolStripMenuItem.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Archivo de texto|*.txt"
            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(saveDialog.FileName)
                    writer.WriteLine("REPORTE - " & DateTime.Now.ToString())
                    writer.WriteLine("PRODUCTO | STOCK")
                    writer.WriteLine("-------------------------")
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If Not row.IsNewRow Then
                            writer.WriteLine(row.Cells("nombre_producto").Value.ToString() & " | " & row.Cells("stock").Value.ToString())
                        End If
                    Next
                End Using
                MessageBox.Show("Guardado exitosamente.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ' Restore view to only the raffle winner
        If _datosOriginales IsNot Nothing Then ActualizarPantalla(_datosOriginales)
    End Sub
End Class