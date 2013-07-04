Imports System.IO

Public Class Apache2Vhost
    Private _fileName As String

    Public ReadOnly Property FileName As String
        Get
            Return _fileName
        End Get
    End Property

    Public ReadOnly Property BaseName As String
        Get
            Return Path.GetFileName(FileName)
        End Get
    End Property

    Public Sub New(ByRef fileName As String)
        _fileName = fileName
    End Sub
End Class
