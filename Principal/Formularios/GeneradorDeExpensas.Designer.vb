<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneradorDeExpensas
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtImporte = New System.Windows.Forms.TextBox
        Me.TxtMes = New System.Windows.Forms.NumericUpDown
        Me.TxtAnio = New System.Windows.Forms.NumericUpDown
        Me.DtFechaVto = New System.Windows.Forms.DateTimePicker
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        CType(Me.TxtMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mes..:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Año..:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Importe..:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FechaVencimiento..:"
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(150, 69)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(80, 20)
        Me.TxtImporte.TabIndex = 6
        '
        'TxtMes
        '
        Me.TxtMes.Location = New System.Drawing.Point(150, 19)
        Me.TxtMes.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.TxtMes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtMes.Name = "TxtMes"
        Me.TxtMes.Size = New System.Drawing.Size(62, 20)
        Me.TxtMes.TabIndex = 7
        Me.TxtMes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TxtAnio
        '
        Me.TxtAnio.Location = New System.Drawing.Point(150, 45)
        Me.TxtAnio.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.TxtAnio.Minimum = New Decimal(New Integer() {1990, 0, 0, 0})
        Me.TxtAnio.Name = "TxtAnio"
        Me.TxtAnio.Size = New System.Drawing.Size(62, 20)
        Me.TxtAnio.TabIndex = 8
        Me.TxtAnio.Value = New Decimal(New Integer() {1990, 0, 0, 0})
        '
        'DtFechaVto
        '
        Me.DtFechaVto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaVto.Location = New System.Drawing.Point(151, 97)
        Me.DtFechaVto.Name = "DtFechaVto"
        Me.DtFechaVto.Size = New System.Drawing.Size(90, 20)
        Me.DtFechaVto.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Principal.My.Resources.Resources.door_open
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(316, 76)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(117, 42)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Image = Global.Principal.My.Resources.Resources.disk
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGenerar.Location = New System.Drawing.Point(316, 12)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(117, 42)
        Me.btnGenerar.TabIndex = 30
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(44, 141)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(434, 20)
        Me.ProgressBar1.TabIndex = 32
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 179)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(536, 22)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GeneradorDeExpensas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(536, 201)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.DtFechaVto)
        Me.Controls.Add(Me.TxtAnio)
        Me.Controls.Add(Me.TxtMes)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GeneradorDeExpensas"
        Me.Text = "GeneradorDeExpensas"
        CType(Me.TxtMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents TxtMes As System.Windows.Forms.NumericUpDown
    Friend WithEvents TxtAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents DtFechaVto As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
