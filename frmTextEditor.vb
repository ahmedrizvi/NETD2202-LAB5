Option Strict On
Imports System.IO ' Takes advantage of system input and output operations.
Public Class frmTextEditor
#Region "Event Handlers"
    ' Clears the textbox of all input when new is clicked/shortcutted.
    Private Sub NewClick(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        txtInput.Text = String.Empty
    End Sub
    ' Allows the user to open an existing text file.
    Private Sub OpenClick(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim inputStream As StreamReader ' Reads data into the memory.

        If openDialog.ShowDialog() = DialogResult.OK Then ' User clicked OK
            inputStream = New StreamReader(openDialog.FileName) ' Read the file into memory and assign to inputStream.
            txtInput.Text = inputStream.ReadToEnd() ' Displays the entire text file's contents onto the text editor.
            inputStream.Close() ' Close the stream.
        End If
    End Sub
#End Region
End Class
