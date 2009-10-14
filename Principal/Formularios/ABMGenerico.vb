Public Class ABMGenerico
    Dim Tabla As String
    'Dim conString As String = "Data Source=JAVIER-20F4D40B;Initial Catalog=BDTPFinal;Integrated Security=True"
    Dim Accion As String



    Public Sub New(ByVal nombreTabla As String, ByVal accion As String)

        InitializeComponent()
        Me.Tabla = nombreTabla
        Me.Accion = accion
    End Sub

    Private Sub ABMGenerico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblAccion.Text = Me.Accion
        Me.cargarGrilla()
        Me.CboBusqueda.Items.Add("Id")
        Me.CboBusqueda.Items.Add("Nombre")
        Me.CboBusqueda.Text = "Id"
        If Me.GrillaListado.RowCount = 0 Then
            Me.GBFiltroBusqueda.Enabled = False
            Me.btnGuardar.Enabled = False
            Me.btnModificar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.btnNuevo.Focus()

        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub cargarGrilla()

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = conString
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select id as Codigo, Nombre  from " & Me.Tabla
        tabla.Load(cmd.ExecuteReader())

        Me.GrillaListado.DataSource = tabla

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
        sSql = "select id as Codigo, Nombre from " & Me.Tabla

        If (sTipoDato = "Texto") Then
            sSql = sSql + " where " + sCampo + " like '" + sDato.ToString + "%'"
        End If

        If (sTipoDato = "Numero") Then
            sSql = sSql + " where " + sCampo + " = " + sDato.ToString
        End If

        cmd.CommandText = sSql
        tabla.Load(cmd.ExecuteReader())

        Me.GrillaListado.DataSource = tabla
        conexion.Close()


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If (Me.CboBusqueda.Text = "Nombre") Then
            FiltrarPor("Nombre", TxtFiltro.Text, "Texto")
        End If

        If (Me.CboBusqueda.Text = "Id") Then

            If IsNumeric(TxtFiltro.Text) Then
                FiltrarPor("id", TxtFiltro.Text, "Numero")
            Else
                If Me.TxtFiltro.Text = "" Then
                    Me.FiltrarPor("Nombre", Me.TxtFiltro.Text, "Texto")
                Else
                    MessageBox.Show("El dato debe ser numerico.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.TxtFiltro.Focus()
                End If

            End If

        End If
    End Sub

    Private Sub GrillaListado_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrillaListado.SelectionChanged
        Dim Contenido As String

        If Me.GrillaListado.RowCount > 0 Then
            Contenido = GrillaListado.CurrentRow.Cells("Codigo").Value.ToString()


            'Me.txtCodigo.Text = Contenido

            Dim conexion As New Data.SqlClient.SqlConnection
            Dim cmd As New Data.SqlClient.SqlCommand
            Dim tabla As New Data.DataTable
            Dim sSql As String
            conexion.ConnectionString = conString

            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sSql = "select id as Codigo, Nombre, Descripcion from " & Me.Tabla
            sSql = sSql + " where id = " + Contenido


            cmd.CommandText = sSql
            tabla.Load(cmd.ExecuteReader())
            If tabla.Rows.Count > 0 Then

                Me.txtDescripcion.Text = tabla.Rows(0)("Descripcion").ToString
                Me.txtNombre.Text = tabla.Rows(0)("Nombre").ToString
                Me.lblCodigo.Text = tabla.Rows(0)("Codigo").ToString

            End If
            conexion.Close()
        End If
    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.GbListado.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.GBFiltroBusqueda.Enabled = False
        Me.txtNombre.Text = ""
        Me.txtDescripcion.Text = ""
        Me.lblCodigo.Text = "Generado Automaticamnte"
        Me.txtDescripcion.BackColor = Color.White
        Me.txtDescripcion.ReadOnly = False
        Me.txtNombre.BackColor = Color.White
        Me.txtNombre.ReadOnly = False
        Me.txtNombre.Focus()
        Me.lblAccion.Text = "Nuevo"

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim sql As String

        '' If Me.ValidarExistencia = True Then
        If Me.lblAccion.Text = "Nuevo" Then

            If validarDatos() = True Then
                conexion.ConnectionString = conString
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text

                sql = " Insert Into " & Me.Tabla & "( "
                sql &= "Nombre, Descripcion)"
                sql &= "Values ("
                sql &= "'" & Me.txtNombre.Text & "' ,"
                sql &= "'" & Me.txtDescripcion.Text & "')"

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                conexion.Close()
                MessageBox.Show("Los Datos se Registraron con Existo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cargarGrilla()
                Me.GbListado.Enabled = True
                Me.GBFiltroBusqueda.Enabled = True
                Me.btnGuardar.Enabled = False
                Me.btnModificar.Enabled = True
                Me.btnEliminar.Enabled = True
                Me.btnNuevo.Enabled = True
                Me.txtDescripcion.BackColor = Color.LightYellow
                Me.txtDescripcion.ReadOnly = True
                Me.txtNombre.BackColor = Color.LightYellow
                Me.txtNombre.ReadOnly = True
                Me.TxtFiltro.Focus()
                Me.lblAccion.Text = "Gestion de " & Me.Tabla


            End If
        End If

        If Me.lblAccion.Text = "Modificar " & Me.Tabla Then

            If validarDatos() = True Then
                conexion.ConnectionString = conString
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text

                sql = " Update " & Me.Tabla & " set "
                sql &= " Nombre = '" & Me.txtNombre.Text & "',"
                sql &= " Descripcion = '" & Me.txtDescripcion.Text & "'"
                sql &= " Where id = " & Integer.Parse(Me.lblCodigo.Text) & ""


                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                conexion.Close()
                MessageBox.Show("Se Modificaron con Existo los Datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cargarGrilla()
                Me.GbListado.Enabled = True
                Me.GBFiltroBusqueda.Enabled = True
                Me.btnGuardar.Enabled = False
                Me.btnModificar.Enabled = True
                Me.btnEliminar.Enabled = True
                Me.btnNuevo.Enabled = True
                Me.txtDescripcion.BackColor = Color.LightYellow
                Me.txtDescripcion.ReadOnly = True
                Me.txtNombre.BackColor = Color.LightYellow
                Me.txtNombre.ReadOnly = True
                Me.TxtFiltro.Focus()
                Me.lblAccion.Text = "Gestion " & Me.Tabla

            End If
        End If
        '    End If
    End Sub

    Private Function validarDatos() As Boolean
        If Me.txtNombre.Text = "" Then
            MessageBox.Show("No se ingreso el Nombre.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtNombre.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.GbListado.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.GBFiltroBusqueda.Enabled = False
        Me.txtDescripcion.BackColor = Color.White
        Me.txtDescripcion.ReadOnly = False
        Me.txtNombre.BackColor = Color.White
        Me.txtNombre.ReadOnly = False
        Me.txtNombre.Focus()
        Me.lblAccion.Text = "Modificar " & Me.Tabla
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim sql As String


        If MessageBox.Show("Esta seguro de eliminar este Registro?", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            conexion.ConnectionString = conString
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            sql = " Delete " & Me.Tabla
            sql &= " Where id = " & Integer.Parse(Me.lblCodigo.Text) & ""


            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("El Registro se Elimino con Existo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnNuevo.Enabled = True
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btnBuscar.Enabled = True
            Me.lblAccion.Text = "Gestión " & Me.Tabla
            ' Me.FrameDatos.Enabled = False
            Me.cargarGrilla()
        End If
    End Sub
    Private Function ValidarExistencia() As Boolean
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim sql As String

        conexion.ConnectionString = conString
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        If Me.lblAccion.Text = "Nuevo" Then
            sql = "select * from " & Me.Tabla & " where Nombre LIKE '" & Me.txtNombre.Text.ToString() & "'"
            cmd.CommandText = sql
            tabla.Load(cmd.ExecuteReader())
            If tabla.Rows.Count > 0 Then
                MessageBox.Show("El Nombre del Registro que intenta guardar ya se encuentra Almacenado en la Base de Datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        Else
            sql = "select * from " & Me.Tabla & " where Nombre LIKE '" & Me.txtNombre.Text.ToString() & "' AND id = " & Integer.Parse(Me.lblCodigo.Text.ToString())
            cmd.CommandText = sql
            tabla.Load(cmd.ExecuteReader())
            If tabla.Rows.Count = 0 Then
                MessageBox.Show("El Nombre del Registro que intenta guardar ya se encuentra Almacenado en la Base de Datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If
        
        Return True

    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.lblAccion.Text = "Gestion de " & Me.Tabla
        Me.cargarGrilla()
        If Me.GrillaListado.RowCount = 0 Then
            Me.GBFiltroBusqueda.Enabled = False
            Me.btnGuardar.Enabled = False
            Me.btnModificar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.btnNuevo.Focus()
        Else
            Me.GbListado.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.btnNuevo.Enabled = True
            Me.GBFiltroBusqueda.Enabled = True
            Me.txtDescripcion.BackColor = Color.LightYellow
            Me.txtDescripcion.ReadOnly = True
            Me.txtNombre.BackColor = Color.LightYellow
            Me.txtNombre.ReadOnly = True
            Me.TxtFiltro.Focus()



        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If IsNumeric(e.KeyChar) = True Then
            e.KeyChar = ""
        End If
    End Sub
End Class