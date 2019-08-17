' Developer: Chilka Patel
' Date: August 16, 2019
' Description: This program  will be creating a Windows Forms application that will need to be able to open, close, 
'              edit, save, save As, And create New files (.txt).
'             -The application will alsobe able to copy, cut, and paste text.    
'             -The solution will also allow the user to Exit the program.  

Option Strict On

Imports System.IO

Public Class MainForm

    ' declaring variable
    Dim newForm As New TextForm
    Dim savePath As String

    ''' <summary>
    ''' Opening particular file and will display status in status bar after file Opens
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If ofdOpenFileDialog.ShowDialog = DialogResult.OK Then

            newForm.MdiParent = Me

            Try
                Dim stream As New StreamReader(ofdOpenFileDialog.FileName)
                newForm.tbTextArea.Text = stream.ReadToEnd
                stream.Close()

                newForm.Show()
                lblStatusLabel.Text = "Opened File:" + ofdOpenFileDialog.FileName

            Catch ex As Exception
                Throw New ApplicationException(ex.ToString)
            End Try

        End If
    End Sub

    ''' <summary>
    ''' Closing particular file and will display status in status bar after file closes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click

        If (Me.MdiChildren.Length > 0) Then
            Dim activeSubform As TextForm = DirectCast(Me.ActiveMdiChild, TextForm)

            activeSubform.Close()
            lblStatusLabel.Text = "Closed File"

        End If

    End Sub

    ''' <summary>
    ''' To save particular file as .txt extension
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        If savePath = "" Then
            sfdSaveFileDialog.Filter = "TXT Files (*.txt*)|*.txt"

            If sfdSaveFileDialog.ShowDialog() = DialogResult.OK Then

                My.Computer.FileSystem.WriteAllText(sfdSaveFileDialog.FileName, TextForm.tbTextArea.Text, False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText(savePath, TextForm.tbTextArea.Text, False)
        End If

    End Sub

    ''' <summary>
    ''' To open child forms/files
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextForm.MdiParent = Me
        TextForm.Show()

    End Sub

    ''' <summary>
    ''' To save an existing file with different name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

        sfdSaveFileDialog.Filter = "TXT Files (*.txt*)|*.txt"

        If sfdSaveFileDialog.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfdSaveFileDialog.FileName, TextForm.tbTextArea.Text, False)
        End If

    End Sub

    ''' <summary>
    ''' Cut specific text from file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click

        My.Computer.Clipboard.SetText(TextForm.tbTextArea.SelectedText)
        TextForm.tbTextArea.SelectedText = ""

    End Sub

    ''' <summary>
    ''' Copy specific text from file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

        If TextForm.tbTextArea.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(TextForm.tbTextArea.SelectedText)
        End If

    End Sub


    ''' <summary>
    ''' Paste the cut/Copied text in specific location
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click

        TextForm.tbTextArea.Paste(My.Computer.Clipboard.GetText())

    End Sub

    ''' <summary>
    ''' To view file in cascade view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    ''' <summary>
    ''' To view file in Vertical view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    ''' <summary>
    ''' To view file in Horizontal view
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

End Class
