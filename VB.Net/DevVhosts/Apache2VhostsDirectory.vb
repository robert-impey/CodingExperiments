Imports System.IO
Imports System.Configuration

Public Class Apache2VhostsDirectory
    Private Shared _instance As Apache2VhostsDirectory

    Public ReadOnly Property DirectoryName() As String
        Get
            Return ConfigurationManager.AppSettings("VhostDirectory")
        End Get
    End Property

    Private Sub New()

    End Sub

    Public Shared Function GetInstance() As Apache2VhostsDirectory
        If _instance Is Nothing Then
            _instance = New Apache2VhostsDirectory
        End If

        Return _instance
    End Function

    Public Function GetVhosts() As IEnumerable(Of Apache2Vhost)
        If Directory.Exists(_instance.DirectoryName) Then
            Return From f In Directory.GetFiles(_instance.DirectoryName)
                Where f.EndsWith(".conf")
                Select New Apache2Vhost(f)
        Else
            Return Nothing
        End If
    End Function
End Class
