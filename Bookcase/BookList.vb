Public Class BookList
    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DI As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(My.Settings.ListBook)
        Dim files() As System.IO.FileInfo = DI.GetFiles
        Dim file As System.IO.FileInfo
        Dim li As ListViewItem
        For Each file In files
            li = ListView1.Items.Add(file.Name)

            li.Tag = file.FullName
        Next

    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick

    End Sub
End Class