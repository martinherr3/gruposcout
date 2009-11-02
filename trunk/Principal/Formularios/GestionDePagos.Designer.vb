<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionDePagos
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
        Me.GrillaBeneficiarios = New System.Windows.Forms.DataGridView
        Me.idBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrillaCuotas = New System.Windows.Forms.DataGridView
        Me.idCuotas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroCuota = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaVto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paga = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DtFechaPago = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.BtnResCta = New System.Windows.Forms.Button
        CType(Me.GrillaBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaBeneficiarios
        '
        Me.GrillaBeneficiarios.AllowUserToAddRows = False
        Me.GrillaBeneficiarios.AllowUserToDeleteRows = False
        Me.GrillaBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaBeneficiarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idBeneficiario, Me.Apellido, Me.Nombre, Me.NroDoc})
        Me.GrillaBeneficiarios.Location = New System.Drawing.Point(12, 12)
        Me.GrillaBeneficiarios.Name = "GrillaBeneficiarios"
        Me.GrillaBeneficiarios.ReadOnly = True
        Me.GrillaBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaBeneficiarios.Size = New System.Drawing.Size(511, 192)
        Me.GrillaBeneficiarios.TabIndex = 0
        '
        'idBeneficiario
        '
        Me.idBeneficiario.DataPropertyName = "idBeneficiario"
        Me.idBeneficiario.HeaderText = "NroBeneficiario"
        Me.idBeneficiario.Name = "idBeneficiario"
        Me.idBeneficiario.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'NroDoc
        '
        Me.NroDoc.DataPropertyName = "NroDoc"
        Me.NroDoc.HeaderText = "NroDocumento"
        Me.NroDoc.Name = "NroDoc"
        Me.NroDoc.ReadOnly = True
        '
        'GrillaCuotas
        '
        Me.GrillaCuotas.AllowUserToAddRows = False
        Me.GrillaCuotas.AllowUserToDeleteRows = False
        Me.GrillaCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuotas, Me.NroCuota, Me.FechaVto, Me.Saldo, Me.Paga})
        Me.GrillaCuotas.Location = New System.Drawing.Point(12, 215)
        Me.GrillaCuotas.Name = "GrillaCuotas"
        Me.GrillaCuotas.ReadOnly = True
        Me.GrillaCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaCuotas.Size = New System.Drawing.Size(341, 152)
        Me.GrillaCuotas.TabIndex = 1
        '
        'idCuotas
        '
        Me.idCuotas.DataPropertyName = "idCuotas"
        Me.idCuotas.HeaderText = "idCuotas"
        Me.idCuotas.Name = "idCuotas"
        Me.idCuotas.ReadOnly = True
        Me.idCuotas.Visible = False
        '
        'NroCuota
        '
        Me.NroCuota.DataPropertyName = "NroCuota"
        Me.NroCuota.HeaderText = "NroCuota"
        Me.NroCuota.Name = "NroCuota"
        Me.NroCuota.ReadOnly = True
        '
        'FechaVto
        '
        Me.FechaVto.DataPropertyName = "FechaVto"
        Me.FechaVto.HeaderText = "FechaVto"
        Me.FechaVto.Name = "FechaVto"
        Me.FechaVto.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "Saldo"
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Width = 80
        '
        'Paga
        '
        Me.Paga.HeaderText = "Paga"
        Me.Paga.Name = "Paga"
        Me.Paga.ReadOnly = True
        Me.Paga.Visible = False
        '
        'DtFechaPago
        '
        Me.DtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaPago.Location = New System.Drawing.Point(206, 373)
        Me.DtFechaPago.Name = "DtFechaPago"
        Me.DtFechaPago.Size = New System.Drawing.Size(146, 20)
        Me.DtFechaPago.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Fecha de Pago..:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Principal.My.Resources.Resources.door_open
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(406, 352)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(117, 42)
        Me.btnSalir.TabIndex = 33
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = Global.Principal.My.Resources.Resources.disk
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(406, 293)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(117, 42)
        Me.btnGrabar.TabIndex = 32
        Me.btnGrabar.Text = "Grabar Pago"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'BtnResCta
        '
        Me.BtnResCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResCta.Image = Global.Principal.My.Resources.Resources.disk
        Me.BtnResCta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnResCta.Location = New System.Drawing.Point(406, 215)
        Me.BtnResCta.Name = "BtnResCta"
        Me.BtnResCta.Size = New System.Drawing.Size(117, 42)
        Me.BtnResCta.TabIndex = 36
        Me.BtnResCta.Text = "Resumen de Cta"
        Me.BtnResCta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnResCta.UseVisualStyleBackColor = True
        '
        'GestionDePagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(667, 487)
        Me.Controls.Add(Me.BtnResCta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtFechaPago)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.GrillaCuotas)
        Me.Controls.Add(Me.GrillaBeneficiarios)
        Me.Name = "GestionDePagos"
        Me.Text = "GsetionDePagos"
        CType(Me.GrillaBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaBeneficiarios As System.Windows.Forms.DataGridView
    Friend WithEvents GrillaCuotas As System.Windows.Forms.DataGridView
    Friend WithEvents idBeneficiario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents idCuotas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroCuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paga As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DtFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnResCta As System.Windows.Forms.Button
End Class
