Public Class LINQFilesListerForm
    Private Sub DirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoryToolStripMenuItem.Click
        Dim listedFolderBrowserDialog As New FolderBrowserDialog

        With listedFolderBrowserDialog
            .RootFolder = Environment.SpecialFolder.Desktop
            .SelectedPath = Environment.SpecialFolder.Desktop
            .Description = "Select the directory to list"
            If .ShowDialog = DialogResult.OK Then
                Dim files = From file In My.Computer.FileSystem.GetFiles(.SelectedPath) _
                    Order By file _
                    Select file

                Dim filesInfo = From file In files _
                            Select My.Computer.FileSystem.GetFileInfo(file)

                Dim myInfo = From file In filesInfo _
                             Select file.Name, file.Length, file.IsReadOnly, file.Exists, file.Extension, file.CreationTimeUtc, file.LastAccessTimeUtc, file.LastWriteTimeUtc

                Me.filesDataGridView.DataSource = myInfo.ToList()
            End If
        End With
    End Sub
End Class
