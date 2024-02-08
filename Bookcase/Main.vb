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
            BookList.ListView1.Items.Add(Path.GetFileName(i))
            My.Settings.ListBook = Application.StartupPath.ToString & "\Buy"
        Next

        BookList.ShowDialog()
    End Sub
End Class
