Imports System.Windows.Forms
Public Class Principal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del primario.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IniciarVariablesGlobales()

    End Sub

    Private Sub ABMEstadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMEstadosToolStripMenuItem.Click
        Dim formABMGenerico As New ABMGenerico("Estados", "Gestion de Estados")
        formABMGenerico.ShowDialog()

    End Sub

    Private Sub ABMActividadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMActividadesToolStripMenuItem.Click
        Dim formABMGenerico As New ABMGenerico("Actividades", "Gestion de Actividades")
        formABMGenerico.ShowDialog()

    End Sub

    Private Sub ABMObjetivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMObjetivosToolStripMenuItem.Click
        Dim formABMGenerico As New ABMGenerico("Objetivos", "Gestion de Objetivos")
        formABMGenerico.ShowDialog()

    End Sub

    Private Sub ABMTipoDoocToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMTipoDoocToolStripMenuItem.Click
        Dim formABMGenerico As New ABMGenerico("TipoDoc", "Gestion de TipoDoc")
        formABMGenerico.ShowDialog()

    End Sub

    Private Sub ABMProgresionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMProgresionesToolStripMenuItem.Click
        Dim formABMGenerico As New ABMGenerico("Progresiones", "Gestion de Progresiones")
        formABMGenerico.ShowDialog()

    End Sub

    Private Sub GestionDeDirigentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeDirigentesToolStripMenuItem.Click
        Dim frm As FrmAbmBeneficiario
        frm = New FrmAbmBeneficiario

        frm._tabla = "Dirigente"
        frm.ShowDialog()
    End Sub

    Private Sub GestionDeBeneficiariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeBeneficiariosToolStripMenuItem.Click
        Dim frm As FrmAbmBeneficiario
        frm = New FrmAbmBeneficiario

        frm._tabla = "Beneficiario"
        frm.ShowDialog()
    End Sub

   

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub GestionDeInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeInventarioToolStripMenuItem.Click
        Dim frmInventario As formInventarioADMINISTRAR
        frmInventario = New formInventarioADMINISTRAR

        frmInventario.ShowDialog()

    End Sub

    Private Sub ABMElementosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMElementosToolStripMenuItem.Click
        Dim frm As frmABMElementos
        frm = New frmABMElementos

        frm._tabla = "Elemento"
        frm.ShowDialog()
    End Sub

    Private Sub ABMEquiposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMEquiposToolStripMenuItem.Click
        Dim frm As frmABMEquipos
        frm = New frmABMEquipos

        frm._tabla = "Equipo"
        frm.ShowDialog()
    End Sub

    Private Sub ABMRamasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMRamasToolStripMenuItem.Click
        Dim frm As frmABMRama
        frm = New frmABMRama

        frm._tabla = "Rama"
        frm.ShowDialog()
    End Sub

    Private Sub GestionDePagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDePagosToolStripMenuItem.Click
        Dim frm As GestionDePagos
        frm = New GestionDePagos

        frm.ShowDialog()
    End Sub

    Private Sub GeneradorDeExpensasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneradorDeExpensasToolStripMenuItem.Click
        Dim frm As GeneradorDeExpensas
        frm = New GeneradorDeExpensas

        frm.ShowDialog()
    End Sub
End Class
