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

        Dim counter As Integer = Directory.GetFiles(Application.StartupPath.ToString, "*.bcd", SearchOption.AllDirectories).Length
        Me.Text = "Book Case" & " - " & counter.ToString() & " Books"
    End Sub
End Class
