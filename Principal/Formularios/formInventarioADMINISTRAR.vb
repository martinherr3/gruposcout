Public Class formInventarioADMINISTRAR

    Private Sub formInventarioADMINISTRAR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tabla As New Data.DataTable
        Dim sql As String

        txtFecha.Text = DateTime.Now.ToShortDateString()
        CboBusqueda.Items.Add("Fecha")
        CboBusqueda.Items.Add("Rama")

        sql = "select idRama, Nombre From Ramas"
        tabla = cargarTablaComboConConsulta(sql)
        CargarCombo(tabla, Me.cboRama, "idRama", "Nombre")



    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Function cargarTablaComboConConsulta(ByVal sSql As String) As Data.DataTable
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaCombo As New Data.DataTable

        conexion.ConnectionString = conString
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sSql

        tablaCombo.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tablaCombo

    End Function

    Private Sub CargarCombo(ByRef tablaCombo As Data.DataTable, ByRef combo As ComboBox, ByVal id As String, ByVal nombre As String)

        'Me.cboTipoDoc.Items.Clear()
        combo.DataSource = tablaCombo
        combo.ValueMember = id
        combo.DisplayMember = nombre

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim tabla As New Data.DataTable
        Dim sql As String
        
        sql = " select Elementos.idElementos as Codigo , Elementos.Nombre as Elementos , Estados.Nombre as Estado  From Elementos, Estados Where Elementos.idEstado = Estados.id"
        tabla = cargarTablaComboConConsulta(sql)
        If tabla.Rows.Count > 0 Then
            Me.GrillaElementos.DataSource = tabla
            Me.btnModificar.Enabled = False
            Me.btnNuevo.Enabled = False
            Me.btnGuardar.Enabled = True
            Me.txtdescripcion.ReadOnly = False
            Me.txtdescripcion.BackColor = Color.White
            Me.cboRama.Enabled = True
            Me.cboRama.BackColor = Color.White
            Me.txtCantidad.ReadOnly = False
            Me.txtCantidad.BackColor = Color.White
            Me.btnAgregar.Enabled = True
            Me.btnQuitar.Enabled = True
            Me.txtCantidad.Focus()
        Else
            Me.btnModificar.Enabled = True
            Me.btnNuevo.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.txtdescripcion.ReadOnly = True
            Me.txtdescripcion.BackColor = Color.LightYellow
            Me.cboRama.Enabled = False
            Me.cboRama.BackColor = Color.LightYellow
            Me.txtCantidad.ReadOnly = True
            Me.txtCantidad.BackColor = Color.LightYellow
            Me.btnAgregar.Enabled = False
            Me.btnQuitar.Enabled = False
            Me.txtCantidad.Text = ""
            MessageBox.Show("No hay Elementos Registrados. Por favor dirigirse a la Gestion de Elementos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnSalir.Focus()

        End If


    End Sub

    Private Sub GrillaElementos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrillaElementos.SelectionChanged
        Me.txtNombreElemento.Text = Me.GrillaElementos.SelectedCells(2).Value
        Me.txtEstadoElemento.Text = Me.GrillaElementos.SelectedCells(3).Value
        Me.txtCodigo.Text = Me.GrillaElementos.SelectedCells(1).Value
        'Me.txtCantidad.Text = Me.GrillaElementos.SelectedCells(3).Value
        Me.txtCantidad.Text = ""
        Me.txtCantidad.Focus()


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim fila As DataGridViewRow
        Dim encontrovalor As Integer = 0

        grillaElementoInventario.Rows.Add(New Object() {Me.txtCodigo.Text, Me.txtNombreElemento.Text, Me.txtEstadoElemento.Text, Me.txtCantidad.Text})
        Me.GrillaElementos.Rows.Remove(Me.GrillaElementos.SelectedRows(0))


        'If Me.txtCantidad.Text.ToString() <> "" Then
        '    If Me.txtCantidad.Text <> 0 Then
        '        If grillaElementoInventario.Rows.Count > 0 Then
        '            For Each fila In grillaElementoInventario.Rows
        '                If fila.Cells("iCodigo").Value = Me.txtCodigo.Text Then
        '                    fila.Cells("iCantidad").Value = Me.txtCantidad.Text
        '                    encontrovalor = 1
        '                End If
        '            Next
        '            If encontrovalor = 0 Then
        '                grillaElementoInventario.Rows.Add(New Object() {Me.txtCodigo.Text, Me.txtNombreElemento.Text, Me.txtEstadoElemento.Text, Me.txtCantidad.Text})
        '            End If

        '        Else
        '            grillaElementoInventario.Rows.Add(New Object() {Me.txtCodigo.Text, Me.txtNombreElemento.Text, Me.txtEstadoElemento.Text, Me.txtCantidad.Text})
        '        End If
        '    Else
        '        MessageBox.Show("No se acepta el valor cero.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Me.txtCantidad.Focus()
        '    End If

        'Else
        '    MessageBox.Show("No se Ingreso la Cantidad del Elemento.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Me.txtCantidad.Focus()

        'End If
    End Sub


    Private Sub btnAgregarElemento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim codigo As String
        Dim elemento As String
        Dim estado As String
        Dim cantidad As String
        codigo = Me.GrillaElementos.SelectedCells(1).ToString()
        elemento = Me.GrillaElementos.SelectedCells(2).ToString()

        Me.grillaElementoInventario.Rows.Add(New Object() {codigo, elemento, estado, cantidad})
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If Me.grillaElementoInventario.Rows.Count > 0 Then
            Me.grillaElementoInventario.Rows.Remove(Me.grillaElementoInventario.SelectedRows(0))

            Me.GrillaElementos.Rows.Add(New Object() {Me.txtCodigo.Text, Me.txtNombreElemento.Text, Me.txtEstadoElemento.Text})
        Else
            MessageBox.Show("No hay elemento a Quitar de la Grilla.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtCantidad.Focus()
        End If
    End Sub

    Private Sub grillaElementoInventario_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grillaElementoInventario.SelectionChanged
        If Me.grillaElementoInventario.Rows.Count > 0 Then
            Me.txtNombreElemento.Text = Me.grillaElementoInventario.SelectedCells(1).Value
            Me.txtEstadoElemento.Text = Me.grillaElementoInventario.SelectedCells(2).Value
            Me.txtCodigo.Text = Me.grillaElementoInventario.SelectedCells(0).Value
            Me.txtCantidad.Text = Me.grillaElementoInventario.SelectedCells(3).Value
            'Me.txtCantidad.Text = ""
            Me.txtCantidad.Focus()
        Else
            Me.txtNombreElemento.Text = Me.GrillaElementos.SelectedCells(2).Value
            Me.txtEstadoElemento.Text = Me.GrillaElementos.SelectedCells(3).Value
            Me.txtCodigo.Text = Me.GrillaElementos.SelectedCells(1).Value
            'Me.txtCantidad.Text = Me.GrillaElementos.SelectedCells(3).Value
            Me.txtCantidad.Text = ""
            Me.txtCantidad.Focus()
        End If
    End Sub
End Class