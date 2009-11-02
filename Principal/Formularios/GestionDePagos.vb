Imports System.Data.SqlClient
Public Class GestionDePagos
    Dim IdBenef As Long

    Private Sub GsetionDePagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Inicio()
    End Sub

    Private Sub Inicio()
        IdBenef = 0

        Me.btnGrabar.Enabled = False

        Dim conn As New SqlConnection
        Dim sSql As String
        conn.ConnectionString = conString

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        GrillaBeneficiarios.AutoGenerateColumns = False
        GrillaCuotas.AutoGenerateColumns = False

        sSql = " Select * from beneficiarios "

        cmd.CommandText = sSql
        Dim tb As New DataTable

        conn.Open()
        tb.Load(cmd.ExecuteReader)
        conn.Close()

        Me.GrillaBeneficiarios.DataSource = tb

        Call LlenarCuotas()

    End Sub
    Private Sub GrillaBeneficiarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaBeneficiarios.CellContentClick

    End Sub

    Private Sub GrillaBeneficiarios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaBeneficiarios.CellDoubleClick


        Call LlenarCuotas()

    End Sub

    Private Sub LlenarCuotas()

        If Me.GrillaBeneficiarios.Rows.Count <= 1 Then
            Exit Sub
        End If




        IdBenef = Long.Parse(GrillaBeneficiarios.CurrentRow.Cells("IdBeneficiario").Value.ToString())

        Dim conn As New SqlConnection
        conn.ConnectionString = conString

        Dim sSql As String
        Dim tb As New DataTable

        sSql = "Select * from Cuotas where saldo > 0 and idBeneficiario = " & IdBenef


        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sSql
        cmd.Connection = conn
        conn.Open()
        tb.Load(cmd.ExecuteReader)
        conn.Close()

        GrillaCuotas.DataSource = tb


        Me.btnGrabar.Enabled = True
        If Integer.Parse(Me.GrillaCuotas.Rows.Count.ToString) < 1 Then
            Me.btnGrabar.Enabled = False
        End If

    End Sub

    Private Sub GrillaCuotas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaCuotas.CellContentClick



    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        If IdBenef = 0 Then
            Exit Sub
        End If


        Dim con As New SqlConnection
        con.ConnectionString = conString
        Dim sSql As String

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        Dim nIdCuota As Integer
        Dim nImporte As Double
        nImporte = 0

        'For index As Integer = 0 To Int32.Parse(Me.GrillaCuotas.Rows.Count.ToString)
        '    If Me.GrillaCuotas.Rows(index).Cells("Pago").Value Then
        '        nImporte = nImporte + Double.Parse(Me.GrillaCuotas.Rows(index).Cells("Saldo").Value.ToString)
        '    End If
        'Next

        'If nImporte <= 0 Then
        '    MessageBox.Show("Debe seleccionar alguna cuota", "Atencion", MessageBoxButtons.OK)
        '    Exit Sub
        'End If
        'For index As Integer = 0 To Int32.Parse(Me.GrillaCuotas.Rows.Count.ToString)

        'If Me.GrillaCuotas.Rows(index).Cells("Pago").Value Then
        nIdCuota = Integer.Parse(Me.GrillaCuotas.CurrentRow.Cells("idCuotas").Value.ToString)
        sSql = "Update Cuotas set saldo = 0 where idCuotas = " & nIdCuota
        nImporte = nImporte + Double.Parse(Me.GrillaCuotas.CurrentRow.Cells("Saldo").Value.ToString)
        con.Open()
        cmd.CommandText = sSql
        cmd.ExecuteNonQuery()
        con.Close()
        'End If
        'Next


        sSql = " Insert into Pagos (idCuota,idBeneficiario,FechaPagoReal,Monto) "
        sSql = sSql & " values ( " & nIdCuota & " , " & IdBenef & ", '" & DtFechaPago.Value & "' , " & nImporte & " )"

        cmd.CommandText = sSql
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("El pago se registro con exito", "Pago", MessageBoxButtons.OK)

        Call Inicio()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub GrillaCuotas_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaCuotas.CellContentDoubleClick



    End Sub

    Private Sub GrillaBeneficiarios_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles GrillaBeneficiarios.RowsAdded

    End Sub

    Private Sub BtnResCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResCta.Click

        If (IdBenef = 0) Then
            MessageBox.Show("Debe elegir un Beneficiario", "Atencion", MessageBoxButtons.OK)
            Exit Sub
        End If
        Dim frm As New ResumenCta
        frm.nIdBenef = IdBenef
        frm.ShowDialog()
    End Sub
End Class