Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text

Public Class Main

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog = New System.Windows.Forms.OpenFileDialog

        If (OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            FileNameLabel.Text = OpenFileDialog.FileName()

            DisplayAll()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        OutputTextBox.Text = ""
        FileNameLabel.Text = ""
    End Sub

    Private Sub DisplayAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayAllToolStripMenuItem.Click
        DisplayAll()
    End Sub

    Private Sub DisplayUniqueIPsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayUniqueIPsToolStripMenuItem.Click
        DisplayUniqueIPs()
    End Sub

    Private Function GetFileStreamReader() As StreamReader
        Return New StreamReader(FileNameLabel.Text)
    End Function

    Private Sub DisplayAll()
        Dim FileStreamReader As StreamReader = GetFileStreamReader()
        OutputTextBox.Text = FileStreamReader.ReadToEnd
    End Sub

    Private Sub DisplayUniqueIPs()
        Dim FileStreamReader As StreamReader = GetFileStreamReader()

        Dim Ips As SortedSet(Of String) = New SortedSet(Of String)()

        Dim RegExp = New Regex("^((?:\d+)(?:\.\d+){3}) ")
        Do While FileStreamReader.Peek() <> -1
            Dim TextLine As String = FileStreamReader.ReadLine()

            If RegExp.IsMatch(TextLine) Then
                Dim IpMatch As Match = RegExp.Match(TextLine)
                Dim Ip As String = IpMatch.Value

                Ips.Add(Ip)
            End If
        Loop

        Dim IpsStringBuilder As StringBuilder = New StringBuilder

        For Each Ip As String In Ips
            IpsStringBuilder.AppendLine(Ip)
        Next

        OutputTextBox.Text = IpsStringBuilder.ToString
    End Sub
End Class
