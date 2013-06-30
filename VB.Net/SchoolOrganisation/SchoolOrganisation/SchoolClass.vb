
Class SchoolClass
    Public Sub New()

    End Sub

    Public Sub New(ByVal teacherName As String, ByVal subjectName As String)
        Me.TeacherName = teacherName
        Me.SubjectName = subjectName
    End Sub

    Public Property TeacherName As String
    Public Property SubjectName As String
End Class
