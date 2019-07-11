Imports System.Data.OleDb
Module Query
    Public Class DBControl
        ' Create DB Connection
        Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShortDist_drivers.accdb")

        ' Prepare DB Command
        Private DBCmd As OleDbCommand

        ' DB Data
        Public DBDA As OleDbDataAdapter
        Public DBDT As DataTable

        ' Query Parameters
        Public Params As New List(Of OleDbParameter)

        ' Query Statistics
        Public RecordCount As Integer
        Public Exception As String

        ' Execute Query
        Public Sub ExecQuery(Query As String)
            ' Reset Query Statistics
            RecordCount = 0
            Exception = ""

            Try
                ' Open a connection
                DBCon.Open()

                ' Create DB Command
                DBCmd = New OleDbCommand(Query, DBCon)

                ' Load Params into DB Command
                Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

                ' Clear Params list
                Params.Clear()

                ' Execute command & fill datatable
                DBDT = New DataTable
                DBDA = New OleDbDataAdapter(DBCmd)
                RecordCount = DBDA.Fill(DBDT)

            Catch ex As Exception
                Exception = ex.Message
                MsgBox(Exception)
            End Try

            ' Close DB connection
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Sub
    End Class
End Module
