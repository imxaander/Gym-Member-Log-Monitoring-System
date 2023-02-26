Imports System.Data.SqlClient
Imports System.Configuration
Module DatabaseConnection
    Public connectionString = "Data Source=DESKTOP-S2D5K4B\MSSQLSERVER01;Initial Catalog=GymManagement;Integrated Security=True"
    'Public connectionString = "Data Source=DESKTOP-3UNDGG8;Initial Catalog=GymManagement;Integrated Security=True"

    Public conn As New SqlConnection(connectionString)
    Public Function GenerateUID(characterNo As Int16) As String
        Dim rn = Guid.NewGuid().ToString().Replace("-", "").Substring(0, characterNo)
        Return rn
    End Function

    Public Function ConfirmDialog()
        Dim dialogBox As New confirm()
        If confirm.ShowDialog() = DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
