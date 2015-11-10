Public Class Form1
    Public Property dbConnectionV3 As New MySql.Data.MySqlClient.MySqlConnection
    Public Property dbConnectionV4 As New MySql.Data.MySqlClient.MySqlConnection

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        dbConnectionV3.ConnectionString = "server=" & txtv3server.Text & ";" & "database=" &
            txtv3Database.Text & ";" & "port=" & txtv3Port.Text & ";" &
            "uid=" & txtv3Username.Text & ";" &
            "pwd=" & txtv3Password.Text & ";"
        dbConnectionV4.ConnectionString = "server=" & txtv4server.Text & ";" & "database=" &
            txtv4Database.Text & ";" & "port=" & txtv4Port.Text & ";" & "uid=" &
            txtv4Username.Text & ";" & "pwd=" & txtv4Password.Text & ";"
        Try
            dbConnectionV3.Open()
            dbConnectionV4.Open()
            MsgBox("Successfully connected to both databases")
            copyStationData()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub copyStationData()
        Dim dataAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        Dim stationId As String
        Dim totalrows As Integer

        Try
            sql = "Select stationId from station limit 50"
            'For Id = & "stationId=" & ";"
            'Next stationId
            dataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, dbConnectionV3)
            dataAdapter.Fill(ds, "station")

            totalrows = ds.Tables("station").Rows.Count

            For count = 0 To totalrows - 1 Step 1
                stationId = ds.Tables("station").Rows(count).Item("stationId")

                sql = "Select * from observationfinal where stationId=" & stationId & ";"
                dataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, dbConnectionV3)
                dataAdapter.Fill(ds, "observationsForStation")

                MsgBox(stationId)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class
