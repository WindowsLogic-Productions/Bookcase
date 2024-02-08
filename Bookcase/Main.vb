Imports System.IO
Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Classics") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Classics")
        End If

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Contemporary Classics") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Contemporary Classics")
        End If

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Modern Classics") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Modern Classics")
        End If

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Buy") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Buy")
        End If

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Loan") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Loan")
        End If

        If My.Settings.Library = Application.StartupPath.ToString & "\Classics" Then
            Dim counter As Integer = Directory.GetFiles(My.Settings.Library, "*.bcd", SearchOption.AllDirectories).Length
            Me.Text = "Book Case" & " - " & counter.ToString() & " Books / Library: Classics"
        ElseIf Application.StartupPath.ToString & "\Contemporary Classics" Then
            Dim counter As Integer = Directory.GetFiles(My.Settings.Library, "*.bcd", SearchOption.AllDirectories).Length
            Me.Text = "Book Case" & " - " & counter.ToString() & " Books / Library: Contemporary Classics"
        End If
    End Sub

    Private Sub BooksToBuyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksToBuyToolStripMenuItem.Click
        Dim buycounter As Integer = Directory.GetFiles(Application.StartupPath.ToString & "\Buy", "*.bcd", SearchOption.AllDirectories).Length
        BookList.Text = "Books to Buy" & " - " & buycounter.ToString()
        For Each i As String In Directory.GetFiles(Application.StartupPath.ToString & "\Buy")
            My.Settings.ListBook = Application.StartupPath.ToString & "\Buy"
        Next
        Dim folderinfo As New IO.DirectoryInfo(My.Settings.ListBook)
        Dim arrFilesinfolder() As IO.FileInfo
        Dim fileinfolder As IO.FileInfo

        arrFilesinfolder = folderinfo.GetFiles("*.bcd")
        For Each fileinfolder In arrFilesinfolder
            BookList.ListView1.Items.Add(fileinfolder.Name)
        Next
        BookList.ShowDialog()

    End Sub

    Private Sub ListBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListBooksToolStripMenuItem.Click
        Dim libcounter As Integer = Directory.GetFiles(My.Settings.Library, "*.bcd", SearchOption.AllDirectories).Length
        BookList.Text = "Books in library" & " - " & libcounter.ToString()
        For Each i As String In Directory.GetFiles(My.Settings.Library)
            My.Settings.ListBook = My.Settings.Library
        Next
        Dim folderinfo As New IO.DirectoryInfo(My.Settings.Library)
        Dim arrFilesinfolder() As IO.FileInfo
        Dim fileinfolder As IO.FileInfo

        arrFilesinfolder = folderinfo.GetFiles("*.bcd")
        For Each fileinfolder In arrFilesinfolder
            BookList.ListView1.Items.Add(fileinfolder.Name)
        Next
        BookList.ShowDialog()

    End Sub
End Class
