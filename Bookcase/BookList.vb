Public Class BookList
    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        EditBook.ShowDialog()
    End Sub

    Private Sub BookList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ListView1.Items.Clear()
    End Sub
End Class