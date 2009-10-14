Imports System.IO
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO.Ports
Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Security.Cryptography


Public Class frmABMElementos

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



        Me.txtDescripcion.Text = ""
        Me.TxtFiltro.Text = ""
        Me.txtNombre.Text = ""


      


    End Sub

    Private Sub CargarCombo(ByRef tablaCombo As Data.DataTable, ByRef cmbEstado As ComboBox, ByVal id As String, ByVal nombre As String)

        ' Ver  como carga tablaCombo cuando llame la funcion

        Me.cmbEstado.DataSource = tablaCombo
        Me.cmbEstado.ValueMember = id
        Me.cmbEstado.DisplayMember = nombre

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
        'Me.cmbEstado.Enabled = True
        Me.txtNombre.ReadOnly = False
        Me.txtDescripcion.ReadOnly = False
        'se cambia el color de los txt
        Me.txtNombre.BackColor = Color.White
        Me.txtDescripcion.BackColor = Color.White
  
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click



        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim sql As String

        If Me.lblAccion.Text = "Nuevo Elemento" Then

            If validarDatos() = True Then
                conexion.ConnectionString = conString
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                sql = "Insert Into Elementos ( "
                sql &= "Nombre, Descripcion, idEstado)"
                sql &= "Values ('" & Me.txtNombre.Text & "', '"
                sql &= Me.txtDescripcion.Text & "', '"
                sql &= Me.cmbEstado.SelectedValue & "')"
              
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
                Me.cmbEstado.Enabled = True


            End If
        End If

        If Me.lblAccion.Text = "Modificar Elemento" Then

            sql = ""

            If validarDatos() = True Then
                conexion.ConnectionString = conString
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text

                sql = " Update Elementos set "
                sql &= " Nombre = '" & Me.txtNombre.Text & "',"
                sql &= " Descripcion = '" & Me.txtDescripcion.Text & "',"
                sql &= " idEstado = " & Integer.Parse(Me.cmbEstado.SelectedValue) & ""
                sql &= " Where idElementos = " & Integer.Parse(Me.txtCodigo.Text) & ""
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
            Me.cargarGrilla()
            GbListado.Enabled = True

        End If

  


    End Sub

    Private Sub DesactivarTxt()
        'se dehabilitan los campos de texto
        Me.cmbEstado.Enabled = False
        Me.txtNombre.ReadOnly = True
        Me.txtDescripcion.ReadOnly = True
        'se cambia el color de los txt
        Me.txtNombre.BackColor = Color.LightYellow
        Me.txtDescripcion.BackColor = Color.LightYellow

    End Sub
    Private Function validarDatos() As Boolean

        If Me.txtNombre.Text = "" Then
            MessageBox.Show("No se ingreso el nombre.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtNombre.Focus()
            Return False
        End If

        If Me.txtDescripcion.Text = "" Then
            MessageBox.Show("No se ingreso la descripcion del elemento.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtDescripcion.Focus()
            Return False
        End If
       
        If Me.cmbEstado.Text = "" Then
            MessageBox.Show("No se ingreso el Estado del Elemento.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmbEstado.Focus()
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
        cmd.CommandText = "select E.idElementos as NroElemento, E.Nombre, E.Descripcion, Es.Nombre as Estado  from Elementos E, Estados Es where E.idEstado = Es.id"

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

        Me.CboBusqueda.Items.Add("idElemento")
        Me.CboBusqueda.Items.Add("Nombre")
        Me.CboBusqueda.Text = "idElemento"

        Dim tablaCombo As New Data.DataTable
        ' cargo el datatable con loa estados
        tablaCombo = cargarTablaCombo("Estados")
        'funcion generica para cargar combos
        'se le pasa el datatable recien cargado, el combobox, la columna id y lo que se muestra
        CargarCombo(tablaCombo, Me.cmbEstado, "id", "Nombre")
        
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

        sSql = "select idElementos as idElemento, Nombre, Descripcion, idEstado  from Elementos  "

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

        If (Me.CboBusqueda.Text = "idElemento") Then

            If IsNumeric(TxtFiltro.Text) Then
                FiltrarPor("idElementos", TxtFiltro.Text, "Numero")
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


        Contenido = GrillaListado.CurrentRow.Cells("NroElemento").Value.ToString()
      
        'Me.txtCodigo.Text = Contenido

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim sSql As String
        conexion.ConnectionString = conString

        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        sSql = "select *  from Elementos where idElementos = " + Contenido

        cmd.CommandText = sSql
        tabla.Load(cmd.ExecuteReader())

        If tabla.Rows.Count > 0 Then
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.txtCodigo.Text = tabla.Rows(0)("idElementos").ToString

            Me.cmbEstado.SelectedValue = tabla.Rows(0)("idEstado").ToString
            Me.txtNombre.Text = tabla.Rows(0)("Nombre").ToString
            Me.txtDescripcion.Text = tabla.Rows(0)("Descripcion").ToString
    
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
            sql = "Delete Elementos  Where idElementos = " & Integer.Parse(Me.txtCodigo.Text) & ""

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
        Me.cmbEstado.Enabled = True

    End Sub


    'Private Sub BtnCancelarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarBusqueda.Click


    '    Me.cargarGrilla()

    'End Sub


End Class


