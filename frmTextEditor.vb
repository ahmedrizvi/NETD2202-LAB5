' Name: Ahmed Rizvi
' Date: 31-07-2020
' Description: This program performs as a text editor, with the ability to open and save .txt files.
Option Strict On
Imports System.IO ' Takes advantage of system input and output operations.
Public Class frmTextEditor
#Region "Constants and Variables"
    Dim outputStream As StreamWriter
    Dim inputStream As StreamReader
#End Region
#Region "Event Handlers"
    ' Clears the textbox of all input when new is clicked/shortcutted.
    Private Sub NewClick(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        txtInput.Text = String.Empty
    End Sub
    ' Allows the user to open an existing text file, when open is clicked.
    Private Sub OpenClick(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        If openDialog.ShowDialog() = DialogResult.OK Then ' User clicked OK
            inputStream = New StreamReader(openDialog.FileName) ' Read the file into memory and assign to inputStream.
            txtInput.Text = inputStream.ReadToEnd() ' Displays the entire text file's contents onto the text editor.
            inputStream.Close() ' Close the stream.
        End If
    End Sub
    ' Saves the string in the textbox to the file.
    Private Sub SaveClick(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim currentFilePath As String

    End Sub
    ' When Save As is clicked, prompts the user for the location to save the file.
    Private Sub SaveAsClick(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        Dim outputStream As StreamWriter

        If saveDialog.ShowDialog() = DialogResult.OK Then ' User pressed the OK button.
            outputStream = New StreamWriter(saveDialog.FileName) ' Save the user's desired file location.
            outputStream.Write(txtInput.Text) ' Use the string text inside the textbox to write into the file.
            outputStream.Close() ' Close the stream.
        End If
    End Sub
    ' Pops up the About form when the menu button is clicked.
    Private Sub AboutClick(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim aboutModal As New frmAbout

        aboutModal.ShowDialog() ' Brings out the modal window, not allowing the user to click behind the window.
    End Sub
    ' Closes the application
    Private Sub ExitClick(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Application.Exit()
    End Sub
#End Region
End Class
