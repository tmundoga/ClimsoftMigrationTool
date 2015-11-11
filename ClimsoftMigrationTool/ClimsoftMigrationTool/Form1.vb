Public Class Form1
    Public Property dbConnectionV3 As New MySql.Data.MySqlClient.MySqlConnection
    Public Property dbConnectionV4 As New MySql.Data.MySqlClient.MySqlConnection

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Dim connectionString As String
        Try
            ' TODO: Sanitise inputs from text boxes
            connectionString = "server={0};database={1};port={2};uid={3};pwd={4}"

            dbConnectionV3.ConnectionString = String.Format(connectionString,
                txtV3Server.Text, cboV3Database.Text, CInt(txtV3Port.Text),
                txtV3Username.Text, txtV3Password.Text)
            dbConnectionV4.ConnectionString = String.Format(connectionString,
                txtV4Server.Text, cboV4Database.Text, CInt(txtV4Port.Text),
                txtV4Username.Text, txtV4Password.Text)
            dbConnectionV3.Open()
            dbConnectionV4.Open()
            copyStationData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub copyStationData()
        Dim command As New MySql.Data.MySqlClient.MySqlCommand
        Dim dataAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        Dim stationId As String

        Try
            'sql = "SELECT stationId FROM station"
            sql = "SELECT recorded_from FROM observation GROUP BY recorded_from;"
            dataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, dbConnectionV3)
            dataAdapter.Fill(ds, "station")

            ' Create connection for UPDATE to v4 database
            command.Connection = dbConnectionV4

            For Each row In ds.Tables("station").Rows
                stationId = row.Item("recorded_from")
                If stationId <> "" Then
                    sql = "SELECT * FROM observation WHERE recorded_from='" & stationId & "';"
                    dataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, dbConnectionV3)
                    dataAdapter.Fill(ds, "observationsForCurrentStation")
                    MsgBox(ds.Tables("observationsForCurrentStation").Rows.Count)
                    'command.CommandText = "UPDATE ..."
                    'command.ExecuteNonQuery()

                    ' Clear current observation values from dataset
                    ds.Tables("observationsForCurrentStation").Clear()
                Else
                    ' TODO: Add any failures to log file
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
