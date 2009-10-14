<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbmBeneficiario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAccion = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.FrameDatos = New System.Windows.Forms.GroupBox
        Me.cboEquipo = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBarrio = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNro = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtFechaNac = New System.Windows.Forms.DateTimePicker
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.GbListado = New System.Windows.Forms.GroupBox
        Me.GrillaListado = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnCancelarBusqueda = New System.Windows.Forms.Button
        Me.TxtFiltro = New System.Windows.Forms.TextBox
        Me.CboBusqueda = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.FrameDatos.SuspendLayout()
        Me.GbListado.SuspendLayout()
        CType(Me.GrillaListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccion.Location = New System.Drawing.Point(227, 3)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(332, 31)
        Me.lblAccion.TabIndex = 0
        Me.lblAccion.Text = "Gestión de Beneficiarios"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(752, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FrameDatos
        '
        Me.FrameDatos.Controls.Add(Me.cboEquipo)
        Me.FrameDatos.Controls.Add(Me.Label14)
        Me.FrameDatos.Controls.Add(Me.txtTelefono)
        Me.FrameDatos.Controls.Add(Me.Label13)
        Me.FrameDatos.Controls.Add(Me.txtEmail)
        Me.FrameDatos.Controls.Add(Me.Label12)
        Me.FrameDatos.Controls.Add(Me.txtBarrio)
        Me.FrameDatos.Controls.Add(Me.Label11)
        Me.FrameDatos.Controls.Add(Me.txtNro)
        Me.FrameDatos.Controls.Add(Me.Label10)
        Me.FrameDatos.Controls.Add(Me.txtCalle)
        Me.FrameDatos.Controls.Add(Me.Label9)
        Me.FrameDatos.Controls.Add(Me.dtFechaNac)
        Me.FrameDatos.Controls.Add(Me.txtApellido)
        Me.FrameDatos.Controls.Add(Me.txtNombre)
        Me.FrameDatos.Controls.Add(Me.txtNroDoc)
        Me.FrameDatos.Controls.Add(Me.cboTipoDoc)
        Me.FrameDatos.Controls.Add(Me.txtCodigo)
        Me.FrameDatos.Controls.Add(Me.Label8)
        Me.FrameDatos.Controls.Add(Me.Label7)
        Me.FrameDatos.Controls.Add(Me.Label6)
        Me.FrameDatos.Controls.Add(Me.Label5)
        Me.FrameDatos.Controls.Add(Me.Label4)
        Me.FrameDatos.Controls.Add(Me.Label3)
        Me.FrameDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameDatos.Location = New System.Drawing.Point(12, 342)
        Me.FrameDatos.Name = "FrameDatos"
        Me.FrameDatos.Size = New System.Drawing.Size(722, 185)
        Me.FrameDatos.TabIndex = 4
        Me.FrameDatos.TabStop = False
        Me.FrameDatos.Text = " Datos "
        '
        'cboEquipo
        '
        Me.cboEquipo.BackColor = System.Drawing.SystemColors.Window
        Me.cboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEquipo.Enabled = False
        Me.cboEquipo.FormattingEnabled = True
        Me.cboEquipo.Location = New System.Drawing.Point(438, 155)
        Me.cboEquipo.Name = "cboEquipo"
        Me.cboEquipo.Size = New System.Drawing.Size(241, 21)
        Me.cboEquipo.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(382, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Equipo:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.Info
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(438, 129)
        Me.txtTelefono.MaxLength = 49
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(154, 20)
        Me.txtTelefono.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(371, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Teléfono:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtEmail.Location = New System.Drawing.Point(438, 103)
        Me.txtEmail.MaxLength = 49
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(249, 20)
        Me.txtEmail.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(391, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Email:"
        '
        'txtBarrio
        '
        Me.txtBarrio.BackColor = System.Drawing.SystemColors.Info
        Me.txtBarrio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBarrio.Location = New System.Drawing.Point(438, 77)
        Me.txtBarrio.MaxLength = 49
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.ReadOnly = True
        Me.txtBarrio.Size = New System.Drawing.Size(249, 20)
        Me.txtBarrio.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(388, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Barrio:"
        '
        'txtNro
        '
        Me.txtNro.BackColor = System.Drawing.SystemColors.Info
        Me.txtNro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNro.Location = New System.Drawing.Point(438, 50)
        Me.txtNro.MaxLength = 4
        Me.txtNro.Name = "txtNro"
        Me.txtNro.ReadOnly = True
        Me.txtNro.Size = New System.Drawing.Size(79, 20)
        Me.txtNro.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(397, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Nro.:"
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Info
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Location = New System.Drawing.Point(438, 24)
        Me.txtCalle.MaxLength = 49
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(249, 20)
        Me.txtCalle.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(393, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Calle:"
        '
        'dtFechaNac
        '
        Me.dtFechaNac.Enabled = False
        Me.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNac.Location = New System.Drawing.Point(102, 155)
        Me.dtFechaNac.Name = "dtFechaNac"
        Me.dtFechaNac.Size = New System.Drawing.Size(154, 20)
        Me.dtFechaNac.TabIndex = 11
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.SystemColors.Info
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Location = New System.Drawing.Point(102, 129)
        Me.txtApellido.MaxLength = 49
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(249, 20)
        Me.txtApellido.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(102, 103)
        Me.txtNombre.MaxLength = 49
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(249, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtNroDoc
        '
        Me.txtNroDoc.BackColor = System.Drawing.SystemColors.Info
        Me.txtNroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDoc.Location = New System.Drawing.Point(102, 77)
        Me.txtNroDoc.MaxLength = 10
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.ReadOnly = True
        Me.txtNroDoc.Size = New System.Drawing.Size(154, 20)
        Me.txtNroDoc.TabIndex = 8
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDoc.Enabled = False
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Location = New System.Drawing.Point(102, 50)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(154, 21)
        Me.cboTipoDoc.TabIndex = 7
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(102, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(181, 20)
        Me.txtCodigo.TabIndex = 6
        Me.txtCodigo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Fecha Nac.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Apellido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nro. Doc.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipo Doc.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Código:"
        Me.Label3.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Principal.My.Resources.Resources.door_open
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(625, 533)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(109, 42)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir/Cancelar"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Principal.My.Resources.Resources.delete
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(472, 533)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(109, 42)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.Principal.My.Resources.Resources.page_edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(242, 533)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 42)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.Principal.My.Resources.Resources.disk
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(127, 533)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(109, 42)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Principal.My.Resources.Resources.add
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(12, 533)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(109, 42)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GbListado
        '
        Me.GbListado.Controls.Add(Me.GrillaListado)
        Me.GbListado.Controls.Add(Me.GroupBox4)
        Me.GbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbListado.Location = New System.Drawing.Point(13, 37)
        Me.GbListado.Name = "GbListado"
        Me.GbListado.Size = New System.Drawing.Size(722, 279)
        Me.GbListado.TabIndex = 11
        Me.GbListado.TabStop = False
        Me.GbListado.Text = "Filtros de Busqueda"
        '
        'GrillaListado
        '
        Me.GrillaListado.AllowUserToAddRows = False
        Me.GrillaListado.AllowUserToDeleteRows = False
        Me.GrillaListado.AllowUserToOrderColumns = True
        Me.GrillaListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.GrillaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaListado.Location = New System.Drawing.Point(11, 19)
        Me.GrillaListado.Name = "GrillaListado"
        Me.GrillaListado.ReadOnly = True
        Me.GrillaListado.RowHeadersWidth = 20
        Me.GrillaListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GrillaListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaListado.Size = New System.Drawing.Size(692, 176)
        Me.GrillaListado.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnCancelarBusqueda)
        Me.GroupBox4.Controls.Add(Me.TxtFiltro)
        Me.GroupBox4.Controls.Add(Me.CboBusqueda)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 201)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(697, 72)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'BtnCancelarBusqueda
        '
        Me.BtnCancelarBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarBusqueda.Image = Global.Principal.My.Resources.Resources.cancel
        Me.BtnCancelarBusqueda.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnCancelarBusqueda.Location = New System.Drawing.Point(582, 39)
        Me.BtnCancelarBusqueda.Name = "BtnCancelarBusqueda"
        Me.BtnCancelarBusqueda.Size = New System.Drawing.Size(90, 27)
        Me.BtnCancelarBusqueda.TabIndex = 14
        Me.BtnCancelarBusqueda.Text = "Cancelar"
        Me.BtnCancelarBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarBusqueda.UseVisualStyleBackColor = True
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(263, 16)
        Me.TxtFiltro.MaxLength = 10
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(409, 20)
        Me.TxtFiltro.TabIndex = 13
        '
        'CboBusqueda
        '
        Me.CboBusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.CboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Location = New System.Drawing.Point(89, 14)
        Me.CboBusqueda.Name = "CboBusqueda"
        Me.CboBusqueda.Size = New System.Drawing.Size(154, 21)
        Me.CboBusqueda.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar Por.:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Principal.My.Resources.Resources.magnifier
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnBuscar.Location = New System.Drawing.Point(472, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 27)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Principal.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(357, 533)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(109, 42)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmAbmBeneficiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(752, 602)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GbListado)
        Me.Controls.Add(Me.FrameDatos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAbmBeneficiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Beneficiarios"
        Me.FrameDatos.ResumeLayout(False)
        Me.FrameDatos.PerformLayout()
        Me.GbListado.ResumeLayout(False)
        CType(Me.GrillaListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FrameDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBarrio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNro As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents GbListado As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GrillaListado As System.Windows.Forms.DataGridView
    Friend WithEvents CboBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelarBusqueda As System.Windows.Forms.Button

End Class
