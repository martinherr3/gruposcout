

Imports System.IO
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO.Ports
Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Security.Cryptography


Public Class frmABMEquipos

    Public _tabla As String

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Me.FrameDatos.Enabled = True


        Me.lblAccion.Text = "Nuevo " + _tabla
        ' se deshabilita el codigo y el boton buscar
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.BackColor = Color.LightYellow
        Me.txtCodigo.Text = ""
        Me.btnBuscar.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        GbListado.Enabled = False

        Me.CboBusqueda.Enabled = False

        Me.ActivarTxt()



        Me.txtCantInt.Text = ""
        Me.TxtFiltro.Text = ""
        Me.txtNombre.Text = ""





    End Sub

    Private Sub CargarCombo(ByRef tablaCombo As Data.DataTable, ByRef cmbEstado As ComboBox, ByVal id As String, ByVal nombre As String)

        ' Ver  como carga tablaCombo cuando llame la funcion

        Me.cboRama.DataSource = tablaCombo
        Me.cboRama.ValueMember = id
        Me.cboRama.DisplayMember = nombre

    End Sub

    Private Function cargarTablaCombo(ByVal nombretabla As String) As Data.DataTable
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaCombo As New Data.DataTable

        conexion.ConnectionString = conString
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from " & nombretabla

        tablaCombo.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tablaCombo

    End Function

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

    Private Sub ActivarTxt()
        'se habilitan los campos de texto
        Me.cboRama.Enabled = True
        Me.txtNombre.ReadOnly = False
        Me.txtCantInt.ReadOnly = False

        'se cambia el color de los txt
        Me.txtNombre.BackColor = Color.White
        Me.txtCantInt.BackColor = Color.White

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click



        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim sql As String

        If Me.lblAccion.Text = "Nuevo Equipo" Then

            If validarDatos() = True Then
                conexion.ConnectionString = conString
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                sql = "Insert Into Equipos ( "
                sql &= "Nombre, CantidadIntegrantes, idRama)"
                sql &= "Values ('" & Me.txtNombre.Text & "', "
                sql &= Integer.Parse(Me.txtCantInt.Text) & ", '"
                sql &= Me.cboRama.SelectedValue & "')"

                '      sql &= "" & Me.dtFechaNac.Value & ")"

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                conexion.Close()
                MessageBox.Show("El " + _tabla + " se Registro con Existo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DesactivarTxt()
                Me.btnNuevo.Enabled = True
                Me.btnModificar.Enabled = True
                Me.btnEliminar.Enabled = True
                Me.btnGuardar.Enabled = False
                Me.btnCancelar.Enabled = False
                Me.btnBuscar.Enabled = True
                Me.btnCancelar.Enabled = False
                Me.lblAccion.Text = "Gestión de " + _tabla + "s"
                Me.FrameDatos.Enabled = False
                Me.cargarGrilla()
                GbListado.Enabled = True
                Me.cboRama.Enabled = True


            End If
        End If

        If Me.lblAccion.Text = "Modificar Equipo" Then

            sql = ""

            If validarDatos() = True Then
                conexion.ConnectionString = conString
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text

                sql = " Update Equipos set "
                sql &= " Nombre = '" & Me.txtNombre.Text & "',"
                sql &= " CantidadIntegrantes = '" & Integer.Parse(Me.txtCantInt.Text) & "',"
                sql &= " idRama = " & Integer.Parse(Me.cboRama.SelectedValue) & ""
                sql &= " Where idEquipo = " & Integer.Parse(Me.txtCodigo.Text) & ""
            End If


            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("El " + _tabla + " se Modifico con Existo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DesactivarTxt()
            Me.btnNuevo.Enabled = True
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btnCancelar.Enabled = False
            Me.btnBuscar.Enabled = True
            Me.lblAccion.Text = "Gestión de " + _tabla + "s"
            Me.FrameDatos.Enabled = False
            Me.CboBusqueda.Enabled = True
            Me.cargarGrilla()
            GbListado.Enabled = True

        End If




    End Sub

    Private Sub DesactivarTxt()
        'se dehabilitan los campos de texto
        Me.cboRama.Enabled = False
        Me.txtNombre.ReadOnly = True
        Me.txtCantInt.ReadOnly = True
        'se cambia el color de los txt
        Me.txtNombre.BackColor = Color.LightYellow
        Me.txtCantInt.BackColor = Color.LightYellow

    End Sub
    Private Function validarDatos() As Boolean

        If Me.txtNombre.Text = "" Then
            MessageBox.Show("No se ingreso el nombre.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtNombre.Focus()
            Return False
        End If

        If Me.txtCantInt.Text = "" Then
            MessageBox.Show("No se ingreso la Cantidad de Integrantes.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtCantInt.Focus()
            Return False
        End If

        If Me.cboRama.Text = "" Then
            MessageBox.Show("No se ingreso la Rama a la que pertenece el Equipo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cboRama.Focus()
            Return False
        End If

        Return True
    End Function

    Public Sub cargarGrilla()

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = conString
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        '  cmd.CommandText = "select idElementos as idElemento, Nombre, Descripcion, idEstado  from Elementos "
        cmd.CommandText = "select E.idEquipo as NroEquipo, E.Nombre, E.CantidadIntegrantes as CantIntegrantes, R.Nombre as Rama  from Equipos E, Ramas R where E.idRama = R.idRama"

        tabla.Load(cmd.ExecuteReader())

        Me.GrillaListado.DataSource = tabla

        Me.btnModificar.Enabled = False
        Me.btnEliminar.Enabled = False

        If tabla.Rows.Count > 0 Then
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If


    End Sub

    Private Sub frmElementos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FrameDatos.Enabled = False
        Me.cargarGrilla()

        Me.CboBusqueda.Items.Add("NroEquipo")
        Me.CboBusqueda.Items.Add("Nombre")
        'Me.CboBusqueda.Items.Add("Rama")
        Me.CboBusqueda.Text = "NroEquipo"

        Dim tablaCombo As New Data.DataTable
        ' cargo el datatable con loa estados
        tablaCombo = cargarTablaCombo("Ramas")
        'funcion generica para cargar combos
        'se le pasa el datatable recien cargado, el combobox, la columna id y lo que se muestra
        CargarCombo(tablaCombo, Me.cboRama, "idRama", "Nombre")

    End Sub

    Public Sub FiltrarPor(ByVal sCampo As String, ByVal sDato As String, ByVal sTipoDato As String)

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim sSql As String
        conexion.ConnectionString = conString

        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        sSql = "select idEquipo as NroEquipo, Nombre, CantidadIntegrantes, idRama  from Equipos "

        If (sTipoDato = "Texto") Then
            sSql = sSql + " where " + sCampo + " like '" + sDato.ToString + "%'"
        End If

        If (sTipoDato = "Numero") Then
            sSql = sSql + " where " + sCampo + " = " + sDato.ToString
        End If

        cmd.CommandText = sSql
        tabla.Load(cmd.ExecuteReader())

        Me.GrillaListado.DataSource = tabla

        Me.btnModificar.Enabled = False
        Me.btnEliminar.Enabled = False

        If tabla.Rows.Count > 0 Then
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If (Me.CboBusqueda.Text = "Nombre") Then
            FiltrarPor("Nombre", TxtFiltro.Text, "Texto")
        End If

        If (Me.CboBusqueda.Text = "NroEquipo") Then

            If IsNumeric(TxtFiltro.Text) Then
                FiltrarPor("idEquipo", TxtFiltro.Text, "Numero")
            Else
                MessageBox.Show("El dato debe ser numerico.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If

    End Sub
    Private Sub GrillaListado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaListado.CellContentClick

    End Sub

    Private Sub CboBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqueda.SelectedIndexChanged

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.FrameDatos.Enabled = True

        Me.lblAccion.Text = "Modificar " + _tabla
        ' se desabilita el codigo y el boton buscar
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.BackColor = Color.LightYellow
        Me.btnBuscar.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEliminar.Enabled = False
        Me.btnModificar.Enabled = False
        GbListado.Enabled = False

        Me.ActivarTxt()

    End Sub

    Private Sub GrillaListado_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrillaListado.SelectionChanged

        Dim Contenido As String

        Contenido = ""


        Contenido = GrillaListado.CurrentRow.Cells("NroEquipo").Value.ToString()

        'Me.txtCodigo.Text = Contenido

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim sSql As String
        conexion.ConnectionString = conString

        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        sSql = "select *  from Equipos where idEquipo = " + Contenido

        cmd.CommandText = sSql
        tabla.Load(cmd.ExecuteReader())

        If tabla.Rows.Count > 0 Then
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.txtCodigo.Text = tabla.Rows(0)("idEquipo").ToString

            Me.cboRama.SelectedValue = tabla.Rows(0)("idRama").ToString
            Me.txtNombre.Text = tabla.Rows(0)("Nombre").ToString
            Me.txtCantInt.Text = tabla.Rows(0)("CantidadIntegrantes").ToString

        Else
            Me.btnModificar.Enabled = False
            Me.btnEliminar.Enabled = False
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim sql As String


        If MessageBox.Show("Esta seguro de eliminar el " + _tabla + "?", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            conexion.ConnectionString = conString
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sql = "Delete Equipos  Where idEquipo = " & Integer.Parse(Me.txtCodigo.Text) & ""

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("El " + _tabla + " se Elimino con Exito.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DesactivarTxt()
            Me.btnNuevo.Enabled = True
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btnCancelar.Enabled = False
            Me.btnBuscar.Enabled = True
            Me.lblAccion.Text = "Gestión de " + _tabla + "s"
            Me.FrameDatos.Enabled = False
            Me.cargarGrilla()
        End If

    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.DesactivarTxt()
        Me.btnNuevo.Enabled = True
        Me.btnModificar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnBuscar.Enabled = True
        Me.lblAccion.Text = "Gestión de " + _tabla + "s"
        Me.FrameDatos.Enabled = False
        Me.cargarGrilla()
        GbListado.Enabled = True
        Me.cboRama.Enabled = True

    End Sub


    'Private Sub BtnCancelarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarBusqueda.Click


    '    Me.cargarGrilla()

    'End Sub






End Class