Imports System.Data.Odbc
Module ModConnection
    Public con As New OdbcConnection
    Public constring As String
    Public Sub connect_me()
        If con.State = System.Data.ConnectionState.Open Then con.Close()
        constring = "driver=MySQL ODBC 9.2 Unicode Driver;localhost;port=3306;uid='root';pwd='pwd1412';database=possystem"
        con.ConnectionString = constring
        con.Open()
    End Sub
End Module