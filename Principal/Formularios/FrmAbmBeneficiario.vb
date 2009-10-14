Imports System.IO
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO.Ports
Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class FrmAbmBeneficiario



    Public _tabla As String

    Private Function ValidaMail(ByVal sMail As String) As Boolean
        Dim emailparts() As String
        Dim user As String
        Dim provider As String
        emailparts = sMail.Split("@".ToCharArray, 2)
        If emailparts.Length = 2 Then
            user = emailparts(0)
            provider = emailparts(1)
        Else
            user = String.Empty
            provider = String.Empty
        End If

    End Function
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Me.FrameDatos.Enabled = True


        Me.lblAccion.Text = "Nuevo " + _tabla
        ' se desabilita el codigo y el boton buscar
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.BackColor = Color.LightYellow
        Me.txtCodigo.Text = "Generado Automatico"
        Me.btnBuscar.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnGuardar.Enabled = True
        GbListado.Enabled = False

        Me.ActivarTxt()

        Me.cboEquipo.Enabled = False



        Me.txtNroDoc.Text = ""
        Me.txtApellido.Text = ""
        Me.txtNombre.Text = ""
        Me.txtCalle.Text = ""
        Me.txtNro.Text = ""
        Me.txtBarrio.Text = ""
        Me.txtEmail.Text = ""
        Me.txtTelefono.Text = ""
        Me.dtFechaNac.Value = dtFechaNac.MaxDate


    End Sub

    Private Sub CargarCombo(ByRef tablaCombo As Data.DataTable, ByRef cboTipoDoc As ComboBox, ByVal id As String, ByVal nombre As String)

        'Me.cboTipoDoc.Items.Clear()
        Me.cboTipoDoc.DataSource = tablaCombo
        Me.cboTipoDoc.ValueMember = id
        Me.cboTipoDoc.DisplayMember = nombre

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
        Me.cboTipoDoc.Enabled = True
        Me.txtNroDoc.ReadOnly = False
        Me.txtNombre.ReadOnly = False
        Me.txtApellido.ReadOnly = False
        Me.dtFechaNac.Enabled = True
        Me.txtCalle.ReadOnly = False
        Me.txtNro.ReadOnly = False
        Me.txtBarrio.ReadOnly = False
        Me.txtTelefono.ReadOnly = False
        Me.txtEmail.ReadOnly = False
        Me.cboEquipo.Enabled = True
        'se cambia el color de los txt
        Me.txtNroDoc.BackColor = Color.White
        Me.txtNombre.BackColor = Color.White
        Me.txtApellido.BackColor = Color.White
        Me.txtCalle.BackColor = Color.White
        Me.txtNro.BackColor = Color.White
        Me.txtBarrio.BackColor = Color.White
        Me.txtTelefono.BackColor = Color.White
        Me.txtEmail.BackColor = Color.White
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click



    Dim conexion As New Data.SqlClient.SqlConnection
    Dim cmd As New Data.SqlClient.SqlCommand
    Dim sql As String

        If Me.lblAccion.Text = "Nuevo Beneficiario" Or Me.lblAccion.Text = "Nuevo Dirigente" Then

            If validarDatos() = True Then
                conexion.ConnectionString = conString
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text
                sql = ""
                If (_tabla = "Beneficiario") Then
                    sql = " Insert Into Beneficiarios ( "
                End If
                If (_tabla = "Dirigente") Then
                    sql = " Insert Into Dirigentes ( "
                End If


                sql &= "codTipoDoc, NroDoc, Apellido, Nombre, Calle, Numero, Barrio, Email, Telefono,FechaNac,IdEquipo)"
                sql &= "Values (" & Me.cboTipoDoc.SelectedValue & ","
                sql &= Me.txtNroDoc.Text & ","
                sql &= "'" & Me.txtApellido.Text & "' ,"
                sql &= "'" & Me.txtNombre.Text & "',"
                sql &= "'" & Me.txtCalle.Text & "',"

                If (Me.txtNro.Text.Trim <> "") Then
                    sql &= Me.txtNro.Text & ","
                Else
                    sql &= "null,"
                End If

                sql &= "'" & Me.txtBarrio.Text & "',"

                If (Me.txtEmail.Text.Trim <> "") Then
                    sql &= "'" & Me.txtEmail.Text & "',"
                Else
                    sql &= "null,"
                End If

                If (Me.txtTelefono.Text.Trim <> "") Then
                    sql &= "'" & Me.txtTelefono.Text & "',"
                Else
                    sql &= "null,"
                End If

                sql &= "'" & Me.dtFechaNac.Value.ToString() & "',"
                sql &= " " & Integer.Parse(Me.cboEquipo.SelectedValue) & ")"

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
                Me.btnBuscar.Enabled = True
                Me.lblAccion.Text = "Gestión de " + _tabla + "s"
                Me.FrameDatos.Enabled = False
                Me.cargarGrilla()
                GbListado.Enabled = True


            End If
        End If

        If Me.lblAccion.Text = "Modificar Beneficiario" Or Me.lblAccion.Text = "Modificar Dirigente" Then

            If validarDatos() = True Then
                conexion.ConnectionString = conString
                conexion.Open()
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text

                sql = ""

                If (_tabla = "Beneficiario") Then
                    sql = " Update Beneficiarios set "
                End If
                If (_tabla = "Dirigente") Then
                    sql = " Update Dirigentes set "
                End If

                sql &= " codTipoDoc = " & Me.cboTipoDoc.SelectedValue & ","
                sql &= " NroDoc = " + Me.txtNroDoc.Text & ","
                sql &= " Apellido = '" & Me.txtApellido.Text & "' ,"
                sql &= " Nombre = '" & Me.txtNombre.Text & "',"
                sql &= " Calle = '" & Me.txtCalle.Text & "',"

                If (Me.txtNro.Text.Trim <> "") Then
                    sql &= " Numero = " + Me.txtNro.Text & ","
                End If

                sql &= " Barrio = '" & Me.txtBarrio.Text & "',"

                If (Me.txtEmail.Text.Trim <> "") Then
                    sql &= " Email = '" & Me.txtEmail.Text & "',"
                End If

                If (Me.txtTelefono.Text.Trim <> "") Then
                    sql &= " Telefono = '" & Me.txtTelefono.Text & "',"
                End If

                sql &= " FechaNac = '" & Me.dtFechaNac.Value & "',"
                sql &= " IdEquipo = " & Integer.Parse(Me.cboEquipo.SelectedValue) & ""
                If (_tabla = "Beneficiario") Then
                    sql &= " Where idBeneficiario = " & Integer.Parse(Me.txtCodigo.Text) & ""
                End If
                If (_tabla = "Dirigente") Then
                    sql &= " Where idDirigente = " & Integer.Parse(Me.txtCodigo.Text) & ""
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
                Me.btnBuscar.Enabled = True
                Me.lblAccion.Text = "Gestión de " + _tabla + "s"
                Me.FrameDatos.Enabled = False
                Me.cargarGrilla()
                GbListado.Enabled = True

            End If
        End If



    End Sub

    Private Sub DesactivarTxt()
        'se habilitan los campos de texto
        Me.cboTipoDoc.Enabled = False
        Me.txtNroDoc.ReadOnly = True
        Me.txtNombre.ReadOnly = True
        Me.txtApellido.ReadOnly = True
        Me.dtFechaNac.Enabled = False
        Me.txtCalle.ReadOnly = True
        Me.txtNro.ReadOnly = True
        Me.txtBarrio.ReadOnly = True
        Me.txtTelefono.ReadOnly = True
        Me.txtEmail.ReadOnly = True
        Me.cboEquipo.Enabled = False
        'se cambia el color de los txt
        Me.txtNroDoc.BackColor = Color.LightYellow
        Me.txtNombre.BackColor = Color.LightYellow
        Me.txtApellido.BackColor = Color.LightYellow
        Me.txtCalle.BackColor = Color.LightYellow
        Me.txtNro.BackColor = Color.LightYellow
        Me.txtBarrio.BackColor = Color.LightYellow
        Me.txtTelefono.BackColor = Color.LightYellow
        Me.txtEmail.BackColor = Color.LightYellow
    End Sub

    Private Function validarDatos() As Boolean


        If Me.cboTipoDoc.Text = "" Then
            MessageBox.Show("No se ingreso el Tipo de Documento.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cboTipoDoc.Focus()
            Return False
        End If


        If Me.txtNroDoc.Text = "" Then
            MessageBox.Show("No se ingreso el Numero de Documento.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtNroDoc.Focus()
            Return False
        End If

        If Not IsNumeric(Me.txtNroDoc.Text) Then
            MessageBox.Show("El Numero de Documento debe ser de tipo numerico.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtNroDoc.Focus()
            Return False
        End If

        If Me.txtNombre.Text = "" Then
            MessageBox.Show("No se ingreso el nombre.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtNombre.Focus()
            Return False
        End If
        If Me.txtApellido.Text = "" Then
            MessageBox.Show("No se ingreso el Apellido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtApellido.Focus()
            Return False
        End If
        If Me.txtCalle.Text = "" Then
            MessageBox.Show("No se ingreso la Calle.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtCalle.Focus()
            Return False
        End If
        If Me.txtNro.Text.Trim <> "" Then
            If Not IsNumeric(Me.txtNro.Text) Then
                MessageBox.Show("El Numero de la calle debe ser de tipo numerico.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtNro.Focus()
                Return False
            End If
        End If

        If Me.txtBarrio.Text = "" Then
            MessageBox.Show("No se ingreso el barrio.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtBarrio.Focus()
            Return False
        End If
        'If Me.txtEmail.Text = "" Then
        '    MessageBox.Show("No se ingreso el Email del Beneficiario.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Me.txtEmail.Focus()
        '    Return False
        'End If
        'If Me.txtTelefono.Text = "" Then
        '    MessageBox.Show("No se ingreso el Telefono del Beneficiario.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Me.txtTelefono.Focus()
        '    Return False
        'End If

        If Me.cboEquipo.Text = "" Then
            MessageBox.Show("No se ingreso el Equipo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cboEquipo.Focus()
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
        If (_tabla = "Beneficiario") Then
            cmd.CommandText = "select idBeneficiario as NroBeneficiario,Apellido, nombre, Calle, numero, Barrio, Email, Telefono  from Beneficiarios "
        End If
        If (_tabla = "Dirigente") Then
            cmd.CommandText = "select idDirigente as NroDirigente,Apellido, nombre, Calle, numero, Barrio, Email, Telefono  from Dirigentes "
        End If


        tabla.Load(cmd.ExecuteReader())

        Me.GrillaListado.DataSource = tabla

        Me.btnModificar.Enabled = False
        Me.btnEliminar.Enabled = False

        If tabla.Rows.Count > 0 Then
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If


    End Sub
    Private Sub formPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FrameDatos.Enabled = False
        Me.cargarGrilla()
        Me.lblAccion.Text = "Gestión de " + _tabla + "s"
        If (_tabla = "Beneficiario") Then
            Me.CboBusqueda.Items.Add("NroBeneficiario")
            Me.CboBusqueda.Items.Add("Apellido")
            Me.CboBusqueda.Text = "NroBeneficiario"
        End If

        If (_tabla = "Dirigente") Then
            Me.CboBusqueda.Items.Add("NroDirigente")
            Me.CboBusqueda.Items.Add("Apellido")
            Me.CboBusqueda.Text = "NroDirigente"
        End If

        Dim tablaCombo As New Data.DataTable
        ' cargo el datatable de tipo doc
        tablaCombo = cargarTablaCombo("TipoDoc")
        'funcion generica para cargar combos
        'se le pasa el datatable recien cargado, el combobox, la columna id y lo que se muestra
        CargarCombo(tablaCombo, Me.cboTipoDoc, "Id", "nombre")
        dtFechaNac.MaxDate = DateTime.Now.AddYears(-4)

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

        sSql = ""
        If (_tabla = "Beneficiario") Then
            sSql = "select idBeneficiario as NroBeneficiario,Apellido, nombre, Calle, numero, Barrio, Email, Telefono  from Beneficiarios  "
        End If

        If (_tabla = "Dirigente") Then
            sSql = "select idDirigente as NroDirigente,Apellido, nombre, Calle, numero, Barrio, Email, Telefono  from Dirigentes  "
        End If

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

        If (Me.CboBusqueda.Text = "Apellido") Then
            FiltrarPor("Apellido", TxtFiltro.Text, "Texto")
        End If

        If (Me.CboBusqueda.Text = "NroBeneficiario") Then

            If IsNumeric(TxtFiltro.Text) Then
                FiltrarPor("idBeneficiario", TxtFiltro.Text, "Numero")
            Else
                MessageBox.Show("El dato debe ser numerico.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If

        If (Me.CboBusqueda.Text = "NroDirigente") Then

            If IsNumeric(TxtFiltro.Text) Then
                FiltrarPor("idDirigente", TxtFiltro.Text, "Numero")
            Else
                MessageBox.Show("El dato debe ser numerico.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If



    End Sub


    Private Sub GrillaListado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaListado.CellContentClick

    End Sub

    Private Sub CboBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqueda.SelectedIndexChanged

    End Sub

    Private Sub validarFechaNac()
        Dim tablaCombo As New Data.DataTable

        ' cargo el datatable de tipo doc
        Dim nEdad As Integer
        Dim sSql As String

        nEdad = DateDiff(DateInterval.Year, Me.dtFechaNac.Value, DateTime.Now)


        'sSql = " Select E.IdEquipo,E.Nombre, R.nombre as nombrerama  from Equipos E, Ramas R "
        sSql = " Select E.IdEquipo,E.Nombre+' ('+ R.nombre +')' as nombre from Equipos E, Ramas R "
        sSql = sSql + " where E.Idrama=R.Idrama "
        sSql = sSql + " And R.EdadMin <= " + nEdad.ToString
        sSql = sSql + " And R.EdadMax >= " + nEdad.ToString

        tablaCombo = cargarTablaComboConConsulta(sSql)
        'Me.cboEquipo.Items.Clear()
        Me.cboEquipo.DataSource = tablaCombo
        Me.cboEquipo.ValueMember = "IdEquipo"
        Me.cboEquipo.DisplayMember = "Nombre"
        Me.cboEquipo.Enabled = True


    End Sub
    Private Sub dtFechaNac_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtFechaNac.LostFocus


        validarFechaNac()


    End Sub

    Private Sub dtFechaNac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaNac.ValueChanged

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
        Me.btnEliminar.Enabled = False
        Me.btnModificar.Enabled = False
        GbListado.Enabled = False

        Me.ActivarTxt()

    End Sub

    Private Sub GrillaListado_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrillaListado.SelectionChanged

        Dim Contenido As String

        Contenido = ""


        If GrillaListado.Rows.Count > 0 Then
            If (_tabla = "Beneficiario") Then
                Contenido = GrillaListado.CurrentRow.Cells("NroBeneficiario").Value.ToString()
            End If
            If (_tabla = "Dirigente") Then
                Contenido = GrillaListado.CurrentRow.Cells("NroDirigente").Value.ToString()
            End If


            'Me.txtCodigo.Text = Contenido

            Dim conexion As New Data.SqlClient.SqlConnection
            Dim cmd As New Data.SqlClient.SqlCommand
            Dim tabla As New Data.DataTable
            Dim sSql As String
            conexion.ConnectionString = conString

            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            sSql = ""
            If (_tabla = "Beneficiario") Then
                sSql = "select *  from Beneficiarios where IdBeneficiario = " + Contenido
            End If

            If (_tabla = "Dirigente") Then
                sSql = "select *  from Dirigentes  where IdDirigente = " + Contenido
            End If


            cmd.CommandText = sSql
            tabla.Load(cmd.ExecuteReader())
            If tabla.Rows.Count > 0 Then
                Me.btnModificar.Enabled = True
                Me.btnEliminar.Enabled = True
                If (_tabla = "Beneficiario") Then
                    Me.txtCodigo.Text = tabla.Rows(0)("idBeneficiario").ToString
                End If
                If (_tabla = "Dirigente") Then
                    Me.txtCodigo.Text = tabla.Rows(0)("idDirigente").ToString
                End If

                Me.cboTipoDoc.SelectedValue = tabla.Rows(0)("codTipoDoc").ToString
                Me.txtNroDoc.Text = tabla.Rows(0)("NroDoc").ToString
                Me.txtApellido.Text = tabla.Rows(0)("Apellido").ToString
                Me.txtNombre.Text = tabla.Rows(0)("Nombre").ToString
                Me.txtCalle.Text = tabla.Rows(0)("Calle").ToString
                Me.txtNro.Text = tabla.Rows(0)("Numero").ToString
                Me.txtBarrio.Text = tabla.Rows(0)("Barrio").ToString
                Me.txtEmail.Text = tabla.Rows(0)("Email").ToString
                Me.txtTelefono.Text = tabla.Rows(0)("Telefono").ToString
                If tabla.Rows(0)("FechaNac").ToString <> "" Then
                    Me.dtFechaNac.Value = tabla.Rows(0)("FechaNac").ToString
                    validarFechaNac()
                End If
                If tabla.Rows(0)("idEquipo").ToString <> "" Then
                    Me.cboEquipo.SelectedValue = tabla.Rows(0)("idEquipo").ToString
                End If
            Else
                Me.btnModificar.Enabled = False
                Me.btnEliminar.Enabled = False
            End If
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
            sql = ""

            If (_tabla = "Beneficiario") Then
                sql = " Delete Beneficiarios  Where idBeneficiario = " & Integer.Parse(Me.txtCodigo.Text) & ""
            End If

            If (_tabla = "Dirigente") Then
                sql = " Delete Dirigentes  Where idDirigente = " & Integer.Parse(Me.txtCodigo.Text) & ""
            End If


            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("El " + _tabla + " se Elimino con Existo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DesactivarTxt()
            Me.btnNuevo.Enabled = True
            Me.btnModificar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btnBuscar.Enabled = True
            Me.lblAccion.Text = "Gestión de " + _tabla + "s"
            Me.FrameDatos.Enabled = False
            Me.cargarGrilla()
        End If

    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click

        Me.DesactivarTxt()
        Me.btnNuevo.Enabled = True
        Me.btnModificar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnBuscar.Enabled = True
        Me.lblAccion.Text = "Gestión de " + _tabla + "s"
        Me.FrameDatos.Enabled = False
        Me.cargarGrilla()
        GbListado.Enabled = True

    End Sub


    Private Sub BtnCancelarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarBusqueda.Click


        Me.cargarGrilla()

    End Sub
End Class

