Imports System.Data.SqlClient
Public Class GeneradorDeExpensas



    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        Dim conn As New SqlConnection()
        conn.ConnectionString = conString

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " Select * from Beneficiarios "
        cmd.Connection = conn
        conn.Open()
        Dim tb As New DataTable

        tb.Load(cmd.ExecuteReader)

        Dim sSql As String

        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = tb.Rows.Count

        Me.ProgressBar1.Value = Me.ProgressBar1.Minimum
        For index As Integer = 0 To (tb.Rows.Count - 1)

            sSql = " Insert into cuotas (NroCuota,idBeneficiario,FechaVto,Monto) "
            sSql = sSql & " values ( " & Me.TxtMes.Value.ToString & Me.TxtAnio.Value.ToString & "," & Int32.Parse(tb.Rows(index)("IdBeneficiario").ToString) & " ,'" & Me.DtFechaVto.Value.ToString & "'," & Double.Parse(Me.TxtImporte.Text.ToString) & " )"

            cmd.CommandText = sSql
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            Me.ProgressBar1.Value = index

        Next
        Me.ProgressBar1.Value = Me.ProgressBar1.Maximum
        conn.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub GeneradorDeExpensas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TxtImporte.Text = 0
        Me.TxtAnio.Value = DateTime.Now.Year.ToString
        Me.TxtMes.Value = DateTime.Now.Month.ToString

    End Sub
End Class