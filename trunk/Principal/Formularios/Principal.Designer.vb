<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMElementosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMRamasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMActividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMObjetivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMEstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMTipoDoocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABMProgresionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionDeDirigentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionDeBeneficiariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionDeInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GeneradorDeExpensasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.PersonasToolStripMenuItem, Me.SalirToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMElementosToolStripMenuItem, Me.ABMEquiposToolStripMenuItem, Me.ABMRamasToolStripMenuItem, Me.ABMProgramasToolStripMenuItem, Me.ABMActividadesToolStripMenuItem, Me.ABMObjetivosToolStripMenuItem, Me.ABMEstadosToolStripMenuItem, Me.ABMTipoDoocToolStripMenuItem, Me.ABMProgresionesToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(55, 20)
        Me.FileMenu.Text = "&Archivo"
        '
        'ABMElementosToolStripMenuItem
        '
        Me.ABMElementosToolStripMenuItem.Name = "ABMElementosToolStripMenuItem"
        Me.ABMElementosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMElementosToolStripMenuItem.Text = "Gestion de Elementos"
        '
        'ABMEquiposToolStripMenuItem
        '
        Me.ABMEquiposToolStripMenuItem.Name = "ABMEquiposToolStripMenuItem"
        Me.ABMEquiposToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMEquiposToolStripMenuItem.Text = "Gestion de Equipos"
        '
        'ABMRamasToolStripMenuItem
        '
        Me.ABMRamasToolStripMenuItem.Name = "ABMRamasToolStripMenuItem"
        Me.ABMRamasToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMRamasToolStripMenuItem.Text = "Gestion de Ramas"
        '
        'ABMProgramasToolStripMenuItem
        '
        Me.ABMProgramasToolStripMenuItem.Name = "ABMProgramasToolStripMenuItem"
        Me.ABMProgramasToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMProgramasToolStripMenuItem.Text = "Gestion de Programas"
        Me.ABMProgramasToolStripMenuItem.Visible = False
        '
        'ABMActividadesToolStripMenuItem
        '
        Me.ABMActividadesToolStripMenuItem.Name = "ABMActividadesToolStripMenuItem"
        Me.ABMActividadesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMActividadesToolStripMenuItem.Text = "Gestion de Actividades"
        '
        'ABMObjetivosToolStripMenuItem
        '
        Me.ABMObjetivosToolStripMenuItem.Name = "ABMObjetivosToolStripMenuItem"
        Me.ABMObjetivosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMObjetivosToolStripMenuItem.Text = "Gestion de Objetivos"
        '
        'ABMEstadosToolStripMenuItem
        '
        Me.ABMEstadosToolStripMenuItem.Name = "ABMEstadosToolStripMenuItem"
        Me.ABMEstadosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMEstadosToolStripMenuItem.Text = "Gestion de Estados"
        '
        'ABMTipoDoocToolStripMenuItem
        '
        Me.ABMTipoDoocToolStripMenuItem.Name = "ABMTipoDoocToolStripMenuItem"
        Me.ABMTipoDoocToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMTipoDoocToolStripMenuItem.Text = "Gestion de Tipo Documento"
        '
        'ABMProgresionesToolStripMenuItem
        '
        Me.ABMProgresionesToolStripMenuItem.Name = "ABMProgresionesToolStripMenuItem"
        Me.ABMProgresionesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMProgresionesToolStripMenuItem.Text = "Gestion de Progresiones"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeDirigentesToolStripMenuItem, Me.GestionDeBeneficiariosToolStripMenuItem})
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'GestionDeDirigentesToolStripMenuItem
        '
        Me.GestionDeDirigentesToolStripMenuItem.Name = "GestionDeDirigentesToolStripMenuItem"
        Me.GestionDeDirigentesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.GestionDeDirigentesToolStripMenuItem.Text = "Gestion de Dirigentes"
        '
        'GestionDeBeneficiariosToolStripMenuItem
        '
        Me.GestionDeBeneficiariosToolStripMenuItem.Name = "GestionDeBeneficiariosToolStripMenuItem"
        Me.GestionDeBeneficiariosToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.GestionDeBeneficiariosToolStripMenuItem.Text = "Gestion de Beneficiarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDePagosToolStripMenuItem, Me.GeneradorDeExpensasToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.SalirToolStripMenuItem.Text = "Pagos"
        '
        'GestionDePagosToolStripMenuItem
        '
        Me.GestionDePagosToolStripMenuItem.Name = "GestionDePagosToolStripMenuItem"
        Me.GestionDePagosToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.GestionDePagosToolStripMenuItem.Text = "Gestion de Pagos"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeInventarioToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'GestionDeInventarioToolStripMenuItem
        '
        Me.GestionDeInventarioToolStripMenuItem.Name = "GestionDeInventarioToolStripMenuItem"
        Me.GestionDeInventarioToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.GestionDeInventarioToolStripMenuItem.Text = "Gestion de Inventario"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 553)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(750, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'GeneradorDeExpensasToolStripMenuItem
        '
        Me.GeneradorDeExpensasToolStripMenuItem.Name = "GeneradorDeExpensasToolStripMenuItem"
        Me.GeneradorDeExpensasToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.GeneradorDeExpensasToolStripMenuItem.Text = "Generador De Expensas"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 575)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ABMElementosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMEquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMRamasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMProgramasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMActividadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMObjetivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMEstadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMTipoDoocToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMProgresionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeDirigentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeBeneficiariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDePagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneradorDeExpensasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
