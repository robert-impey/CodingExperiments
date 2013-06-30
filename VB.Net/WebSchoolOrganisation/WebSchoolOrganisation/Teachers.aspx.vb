Public Class Teachers
    Inherits System.Web.UI.Page

    Private NewFullName As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Using SchoolOrganisationContext As New SchoolOrganisationEntities
            Dim teachers = From t In SchoolOrganisationContext.Teachers _
                           Order By t.Name _
                           Select t.Name

            teachersGridView.DataSource = teachers
            teachersGridView.DataBind()
        End Using
    End Sub

    Protected Sub AddNewTeacherButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddNewTeacherButton.Click
        NewFullName = FirstNameTextBox.Text & " " & LastNameTextBox.Text

        NewFullNameLabel.Text = NewFullName
    End Sub
End Class