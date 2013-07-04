Class MainWindow 

    Private Sub ListVhostsButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles listVhostsButton.Click
        Dim Vhosts As IEnumerable(Of Apache2Vhost) = Apache2VhostsDirectory.GetInstance.GetVhosts
        If Vhosts IsNot Nothing Then
            vhostsListView.DataContext = From Vhost In Vhosts
                                         Order By Vhost.BaseName
                                         Select Vhost
        End If
    End Sub
End Class
