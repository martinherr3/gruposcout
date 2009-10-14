<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMEquipos
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
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
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtCantInt = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblAccion = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GBFiltroBusqueda.SuspendLayout()
        Me.GbListado.SuspendLayout()
        CType(Me.GrillaListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrameDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 621)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(836, 22)
        Me.StatusStrip1.TabIndex = 43
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GBFiltroBusqueda
        '
        Me.GBFiltroBusqueda.Controls.Add(Me.TxtFiltro)
        Me.GBFiltroBusqueda.Controls.Add(Me.CboBusqueda)
        Me.GBFiltroBusqueda.Controls.Add(Me.Label1)
        Me.GBFiltroBusqueda.Controls.Add(Me.btnBuscar)
        Me.GBFiltroBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFiltroBusqueda.Location = New System.Drawing.Point(47, 249)
        Me.GBFiltroBusqueda.Name = "GBFiltroBusqueda"
        Me.GBFiltroBusqueda.Size = New System.Drawing.Size(747, 82)
        Me.GBFiltroBusqueda.TabIndex = 33
        Me.GBFiltroBusqueda.TabStop = False
        Me.GBFiltroBusqueda.Text = "Filtro de Busqueda"
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(249, 14)
        Me.TxtFiltro.MaxLength = 10
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(177, 20)
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
        Me.btnBuscar.Location = New System.Drawing.Point(326, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 32)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GbListado
        '
        Me.GbListado.Controls.Add(Me.GrillaListado)
        Me.GbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbListado.Location = New System.Drawing.Point(36, 36)
        Me.GbListado.Name = "GbListado"
        Me.GbListado.Size = New System.Drawing.Size(763, 207)
        Me.GbListado.TabIndex = 41
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
        Me.GrillaListado.Size = New System.Drawing.Size(733, 168)
        Me.GrillaListado.TabIndex = 12
        '
        'FrameDatos
        '
        Me.FrameDatos.Controls.Add(Me.cboRama)
        Me.FrameDatos.Controls.Add(Me.Label2)
        Me.FrameDatos.Controls.Add(Me.txtCodigo)
        Me.FrameDatos.Controls.Add(Me.txtCantInt)
        Me.FrameDatos.Controls.Add(Me.txtNombre)
        Me.FrameDatos.Controls.Add(Me.Label7)
        Me.FrameDatos.Controls.Add(Me.Label6)
        Me.FrameDatos.Controls.Add(Me.Label3)
        Me.FrameDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameDatos.Location = New System.Drawing.Point(47, 335)
        Me.FrameDatos.Name = "FrameDatos"
        Me.FrameDatos.Size = New System.Drawing.Size(752, 202)
        Me.FrameDatos.TabIndex = 35
        Me.FrameDatos.TabStop = False
        Me.FrameDatos.Text = "Datos"
        '
        'cboRama
        '
        Me.cboRama.FormattingEnabled = True
        Me.cboRama.Location = New System.Drawing.Point(120, 100)
        Me.cboRama.Name = "cboRama"
        Me.cboRama.Size = New System.Drawing.Size(121, 21)
        Me.cboRama.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Rama:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(120, 13)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 11
        Me.txtCodigo.Visible = False
        '
        'txtCantInt
        '
        Me.txtCantInt.BackColor = System.Drawing.SystemColors.Info
        Me.txtCantInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantInt.Location = New System.Drawing.Point(120, 65)
        Me.txtCantInt.Multiline = True
        Me.txtCantInt.Name = "txtCantInt"
        Me.txtCantInt.ReadOnly = True
        Me.txtCantInt.Size = New System.Drawing.Size(229, 20)
        Me.txtCantInt.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(120, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(249, 20)
        Me.txtNombre.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nro Integrantes:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Código:"
        Me.Label3.Visible = False
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccion.Location = New System.Drawing.Point(256, 2)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(268, 31)
        Me.lblAccion.TabIndex = 34
        Me.lblAccion.Text = "Gestión de Equipos"
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.Principal.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(558, 543)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 42)
        Me.btnCancelar.TabIndex = 42
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Principal.My.Resources.Resources.door_open
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(686, 543)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 42)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Principal.My.Resources.Resources.delete
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(426, 543)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(117, 42)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Principal.My.Resources.Resources.add
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(45, 543)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(116, 42)
        Me.btnNuevo.TabIndex = 36
        Me.btnNuevo.Text = "Nuevo "
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.Principal.My.Resources.Resources.page_edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(290, 543)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(121, 42)
        Me.btnModificar.TabIndex = 38
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
        Me.btnGuardar.Location = New System.Drawing.Point(167, 543)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 42)
        Me.btnGuardar.TabIndex = 37
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmABMEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(836, 643)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GBFiltroBusqueda)
        Me.Controls.Add(Me.GbListado)
        Me.Controls.Add(Me.FrameDatos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmABMEquipos"
        Me.Text = "frmABMEquipo"
        Me.GBFiltroBusqueda.ResumeLayout(False)
        Me.GBFiltroBusqueda.PerformLayout()
        Me.GbListado.ResumeLayout(False)
        CType(Me.GrillaListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrameDatos.ResumeLayout(False)
        Me.FrameDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GBFiltroBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents CboBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GbListado As System.Windows.Forms.GroupBox
    Friend WithEvents GrillaListado As System.Windows.Forms.DataGridView
    Friend WithEvents FrameDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cboRama As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtCantInt As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
