Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
System.Diagnostics.Process.Start("mailto:" & LinkLabel1.Text)
    End Sub
End Class
