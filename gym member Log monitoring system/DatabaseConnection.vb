Imports System.Data.SqlClient
Imports System.Configuration
Module DatabaseConnection
    Public conn As New SqlConnection("Data Source=DESKTOP-SMPJJC8;Initial Catalog=GymManagement;Integrated Security=True")
    Public Function GenerateUID(characterNo As Int16) As String
        Dim rn = Guid.NewGuid().ToString().Replace("-", "").Substring(0, characterNo)
        Return rn
    End Function
End Module
