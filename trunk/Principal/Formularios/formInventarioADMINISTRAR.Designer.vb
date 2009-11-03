<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInventarioADMINISTRAR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GBFiltroBusqueda = New System.Windows.Forms.GroupBox
        Me.TxtFiltro = New System.Windows.Forms.TextBox
        Me.CboBusqueda = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.GbListado = New System.Windows.Forms.GroupBox
        Me.GrillaListado = New System.Windows.Forms.DataGridView
        Me.FrameDatos = New System.Windows.Forms.GroupBox
        Me.cboRama = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.lblAccion = New System.Windows.Forms.Label
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.grillaElementoInventario = New System.Windows.Forms.DataGridView
        Me.iCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.iElemento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.iEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.iCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNombreElemento = New System.Windows.Forms.TextBox
        Me.txtEstadoElemento = New System.Windows.Forms.TextBox
        Me.GrillaElementos = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Elementos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Button1 = New System.Windows.Forms.Button
        Me.GBFiltroBusqueda.SuspendLayout()
        Me.GbListado.SuspendLayout()
        CType(Me.GrillaListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrameDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grillaElementoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.Principal.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(512, 531)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 34)
        Me.btnCancelar.TabIndex = 52
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GBFiltroBusqueda
        '
        Me.GBFiltroBusqueda.Controls.Add(Me.TxtFiltro)
        Me.GBFiltroBusqueda.Controls.Add(Me.CboBusqueda)
        Me.GBFiltroBusqueda.Controls.Add(Me.Label1)
        Me.GBFiltroBusqueda.Controls.Add(Me.btnBuscar)
        Me.GBFiltroBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltroBusqueda.Location = New System.Drawing.Point(367, 39)
        Me.GBFiltroBusqueda.Name = "GBFiltroBusqueda"
        Me.GBFiltroBusqueda.Size = New System.Drawing.Size(441, 43)
        Me.GBFiltroBusqueda.TabIndex = 43
        Me.GBFiltroBusqueda.TabStop = False
        Me.GBFiltroBusqueda.Text = "Filtro de Busqueda"
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(212, 14)
        Me.TxtFiltro.MaxLength = 10
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(146, 20)
        Me.TxtFiltro.TabIndex = 13
        '
        'CboBusqueda
        '
        Me.CboBusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.CboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Location = New System.Drawing.Point(89, 14)
        Me.CboBusqueda.Name = "CboBusqueda"
        Me.CboBusqueda.Size = New System.Drawing.Size(110, 21)
        Me.CboBusqueda.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar Por:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Principal.My.Resources.Resources.magnifier
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(363, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 22)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GbListado
        '
        Me.GbListado.Controls.Add(Me.GrillaListado)
        Me.GbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbListado.Location = New System.Drawing.Point(11, 39)
        Me.GbListado.Name = "GbListado"
        Me.GbListado.Size = New System.Drawing.Size(350, 140)
        Me.GbListado.TabIndex = 51
        Me.GbListado.TabStop = False
        Me.GbListado.Text = "Datos Busqueda"
        '
        'GrillaListado
        '
        Me.GrillaListado.AllowUserToAddRows = False
        Me.GrillaListado.AllowUserToDeleteRows = False
        Me.GrillaListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GrillaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaListado.Location = New System.Drawing.Point(11, 19)
        Me.GrillaListado.MultiSelect = False
        Me.GrillaListado.Name = "GrillaListado"
        Me.GrillaListado.ReadOnly = True
        Me.GrillaListado.RowHeadersWidth = 20
        Me.GrillaListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GrillaListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaListado.Size = New System.Drawing.Size(330, 113)
        Me.GrillaListado.TabIndex = 12
        '
        'FrameDatos
        '
        Me.FrameDatos.Controls.Add(Me.cboRama)
        Me.FrameDatos.Controls.Add(Me.Label2)
        Me.FrameDatos.Controls.Add(Me.txtdescripcion)
        Me.FrameDatos.Controls.Add(Me.Label3)
        Me.FrameDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameDatos.Location = New System.Drawing.Point(367, 88)
        Me.FrameDatos.Name = "FrameDatos"
        Me.FrameDatos.Size = New System.Drawing.Size(441, 91)
        Me.FrameDatos.TabIndex = 45
        Me.FrameDatos.TabStop = False
        Me.FrameDatos.Text = "Datos"
        '
        'cboRama
        '
        Me.cboRama.BackColor = System.Drawing.SystemColors.Info
        Me.cboRama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRama.Enabled = False
        Me.cboRama.FormattingEnabled = True
        Me.cboRama.Location = New System.Drawing.Point(272, 32)
        Me.cboRama.Name = "cboRama"
        Me.cboRama.Size = New System.Drawing.Size(166, 21)
        Me.cboRama.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Rama:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.SystemColors.Info
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(11, 32)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ReadOnly = True
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(203, 51)
        Me.txtdescripcion.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripcion:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Principal.My.Resources.Resources.door_open
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(651, 531)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 34)
        Me.btnSalir.TabIndex = 50
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccion.Location = New System.Drawing.Point(136, 5)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(308, 31)
        Me.lblAccion.TabIndex = 44
        Me.lblAccion.Text = "Gestión de Inventarios"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Principal.My.Resources.Resources.add
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(65, 531)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(116, 34)
        Me.btnNuevo.TabIndex = 46
        Me.btnNuevo.Text = "Nuevo "
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.Principal.My.Resources.Resources.page_edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(359, 531)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(121, 34)
        Me.btnModificar.TabIndex = 48
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
        Me.btnGuardar.Location = New System.Drawing.Point(213, 531)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 34)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(817, 22)
        Me.StatusStrip1.TabIndex = 53
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.Info
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(587, 13)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(531, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombreElemento)
        Me.GroupBox1.Controls.Add(Me.txtEstadoElemento)
        Me.GroupBox1.Controls.Add(Me.GrillaElementos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 340)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementos"
        '
        'btnQuitar
        '
        Me.btnQuitar.Enabled = False
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Image = Global.Principal.My.Resources.Resources.delete
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar.Location = New System.Drawing.Point(178, 270)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(123, 25)
        Me.btnQuitar.TabIndex = 53
        Me.btnQuitar.Text = "Quitar Elemento"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Codigo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.Location = New System.Drawing.Point(78, 188)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigo.TabIndex = 51
        '
        'grillaElementoInventario
        '
        Me.grillaElementoInventario.AllowUserToAddRows = False
        Me.grillaElementoInventario.AllowUserToDeleteRows = False
        Me.grillaElementoInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grillaElementoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grillaElementoInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iCodigo, Me.iElemento, Me.iEstado, Me.iCantidad})
        Me.grillaElementoInventario.Location = New System.Drawing.Point(10, 19)
        Me.grillaElementoInventario.MultiSelect = False
        Me.grillaElementoInventario.Name = "grillaElementoInventario"
        Me.grillaElementoInventario.ReadOnly = True
        Me.grillaElementoInventario.RowHeadersWidth = 20
        Me.grillaElementoInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grillaElementoInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaElementoInventario.Size = New System.Drawing.Size(284, 141)
        Me.grillaElementoInventario.TabIndex = 48
        '
        'iCodigo
        '
        Me.iCodigo.HeaderText = "Codigo"
        Me.iCodigo.Name = "iCodigo"
        Me.iCodigo.ReadOnly = True
        Me.iCodigo.Visible = False
        Me.iCodigo.Width = 69
        '
        'iElemento
        '
        Me.iElemento.HeaderText = "Elemento"
        Me.iElemento.Name = "iElemento"
        Me.iElemento.ReadOnly = True
        Me.iElemento.Width = 82
        '
        'iEstado
        '
        Me.iEstado.HeaderText = "Estado"
        Me.iEstado.Name = "iEstado"
        Me.iEstado.ReadOnly = True
        Me.iEstado.Width = 69
        '
        'iCantidad
        '
        Me.iCantidad.HeaderText = "Cantidad"
        Me.iCantidad.Name = "iCantidad"
        Me.iCantidad.ReadOnly = True
        Me.iCantidad.Width = 80
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.Principal.My.Resources.Resources.add
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(78, 292)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(141, 25)
        Me.btnAgregar.TabIndex = 47
        Me.btnAgregar.Text = "Agregar Elemento"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(78, 266)
        Me.txtCantidad.MaxLength = 10
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(94, 20)
        Me.txtCantidad.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Elemento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Estado:"
        '
        'txtNombreElemento
        '
        Me.txtNombreElemento.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombreElemento.Location = New System.Drawing.Point(78, 214)
        Me.txtNombreElemento.MaxLength = 10
        Me.txtNombreElemento.Name = "txtNombreElemento"
        Me.txtNombreElemento.ReadOnly = True
        Me.txtNombreElemento.Size = New System.Drawing.Size(175, 20)
        Me.txtNombreElemento.TabIndex = 14
        '
        'txtEstadoElemento
        '
        Me.txtEstadoElemento.BackColor = System.Drawing.SystemColors.Info
        Me.txtEstadoElemento.Location = New System.Drawing.Point(78, 240)
        Me.txtEstadoElemento.MaxLength = 10
        Me.txtEstadoElemento.Name = "txtEstadoElemento"
        Me.txtEstadoElemento.ReadOnly = True
        Me.txtEstadoElemento.Size = New System.Drawing.Size(175, 20)
        Me.txtEstadoElemento.TabIndex = 34
        '
        'GrillaElementos
        '
        Me.GrillaElementos.AllowUserToAddRows = False
        Me.GrillaElementos.AllowUserToDeleteRows = False
        Me.GrillaElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GrillaElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaElementos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Elementos, Me.Estado, Me.Column1})
        Me.GrillaElementos.Location = New System.Drawing.Point(9, 19)
        Me.GrillaElementos.MultiSelect = False
        Me.GrillaElementos.Name = "GrillaElementos"
        Me.GrillaElementos.ReadOnly = True
        Me.GrillaElementos.RowHeadersWidth = 20
        Me.GrillaElementos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GrillaElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaElementos.Size = New System.Drawing.Size(264, 160)
        Me.GrillaElementos.TabIndex = 13
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo Elemento"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        Me.Codigo.Width = 125
        '
        'Elementos
        '
        Me.Elementos.DataPropertyName = "Elementos"
        Me.Elementos.HeaderText = "Elemento"
        Me.Elementos.Name = "Elementos"
        Me.Elementos.ReadOnly = True
        Me.Elementos.Width = 82
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 69
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 78
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnQuitar)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.grillaElementoInventario)
        Me.GroupBox2.Location = New System.Drawing.Point(484, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 314)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elementos del Inventario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Codigo:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(81, 166)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(57, 20)
        Me.TextBox1.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Cantidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Elemento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Estado:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Location = New System.Drawing.Point(81, 192)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(175, 20)
        Me.TextBox3.TabIndex = 53
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox4.Location = New System.Drawing.Point(81, 218)
        Me.TextBox4.MaxLength = 10
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(175, 20)
        Me.TextBox4.TabIndex = 55
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(279, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(199, 120)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro de Busqueda Elementos"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(14, 62)
        Me.TextBox5.MaxLength = 10
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(146, 20)
        Me.TextBox5.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(110, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Buscar Por:"
        '
        'Button2
        '
        Me.Button2.Image = Global.Principal.My.Resources.Resources.magnifier
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(14, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 22)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(81, 245)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(89, 20)
        Me.NumericUpDown1.TabIndex = 62
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Principal.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(10, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 25)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Actualizar Elemento"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formInventarioADMINISTRAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(817, 602)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GBFiltroBusqueda)
        Me.Controls.Add(Me.GbListado)
        Me.Controls.Add(Me.FrameDatos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formInventarioADMINISTRAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTION DE INVESTRIO"
        Me.GBFiltroBusqueda.ResumeLayout(False)
        Me.GBFiltroBusqueda.PerformLayout()
        Me.GbListado.ResumeLayout(False)
        CType(Me.GrillaListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrameDatos.ResumeLayout(False)
        Me.FrameDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grillaElementoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GBFiltroBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents CboBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GbListado As System.Windows.Forms.GroupBox
    Friend WithEvents GrillaListado As System.Windows.Forms.DataGridView
    Friend WithEvents FrameDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEstadoElemento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombreElemento As System.Windows.Forms.TextBox
    Friend WithEvents GrillaElementos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents grillaElementoInventario As System.Windows.Forms.DataGridView
    Friend WithEvents cboRama As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Elementos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iElemento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
