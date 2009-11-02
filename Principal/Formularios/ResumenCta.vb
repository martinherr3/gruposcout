Imports System.Data.SqlClient

Public Class ResumenCta
    Public nIdBenef As Long
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ResumenCta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Grilla.AutoGenerateColumns = False

        Dim con As New SqlConnection
        con.ConnectionString = conString

        Dim sSql As String
        Dim dt As New DataTable

        sSql = "Select * from Pagos where idBeneficiario = " & nIdBenef
        sSql = sSql & " Order by FechaPagoReal "

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con

        cmd.CommandText = sSql
        con.Open()
        dt.Load(cmd.ExecuteReader)
        con.Close()

        Me.Grilla.DataSource = dt


    End Sub
End Class