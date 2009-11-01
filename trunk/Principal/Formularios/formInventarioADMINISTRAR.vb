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
        Me.txtdescripcion.ReadOnly = False
        Me.txtdescripcion.BackColor = Color.White
        Me.cboRama.Enabled = True
        Me.cboRama.BackColor = Color.White
        Me.txtCantidad.ReadOnly = False
        Me.txtCantidad.BackColor = Color.White


    End Sub
End Class