Public Class MainForm
    Private teachers As New List(Of Teacher)
    Private schoolClasses As New List(Of SchoolClass)

    Private groupSchoolClass As Dictionary(Of Teacher, IEnumerable(Of SchoolClass))

    Private Sub LoadTeachers()
        Me.teachers.Add(New Teacher("Rob"))
        Me.teachers.Add(New Teacher("Adam"))
        Me.teachers.Add(New Teacher("Arron"))
        Me.teachers.Add(New Teacher("Alex"))
    End Sub

    Private Sub LoadSchoolClasses()
        Me.schoolClasses.Add(New SchoolClass("Rob", "Mathematics"))
        Me.schoolClasses.Add(New SchoolClass("Rob", "Computing"))
        Me.schoolClasses.Add(New SchoolClass("Adam", "Biology"))
        Me.schoolClasses.Add(New SchoolClass("Adam", "English"))
        Me.schoolClasses.Add(New SchoolClass("Arron", "Economics"))
        Me.schoolClasses.Add(New SchoolClass("Arron", "History"))
        Me.schoolClasses.Add(New SchoolClass("Alex", "History"))
        Me.schoolClasses.Add(New SchoolClass("Alex", "English"))
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.teachersDataGridView.AutoGenerateColumns = True
        Me.schoolClassesDataGridView.AutoGenerateColumns = True

        Me.LoadTeachers()
        Me.LoadSchoolClasses()

        Dim matchingSchoolClasses = From teacher In Me.teachers _
                                    Group Join schoolClass In Me.schoolClasses On teacher.Name Equals schoolClass.TeacherName _
                                    Into teacherSchoolClasses = Group _
                                    Select teacher, teacherSchoolClasses

        Me.groupSchoolClass = matchingSchoolClasses.ToDictionary(Function(x) x.teacher, Function(y) y.teacherSchoolClasses)

        Me.teachersBindingSource.DataSource = Me.groupSchoolClass.Keys
    End Sub

    Private Sub teachersBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teachersBindingSource.CurrentChanged
        Me.schoolClassesBindingSource.DataSource = Me.groupSchoolClass(CType(Me.teachersBindingSource.Current, Teacher))
    End Sub
End Class
