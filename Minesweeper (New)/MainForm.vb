Option Strict On
Option Infer Off

Public Class MainForm
    Private game As Minesweeper
    Private difficultyMenuItems() As ToolStripMenuItem

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        difficultyMenuItems = {beginnerToolStripMenuItem, intermediateToolStripMenuItem, expertToolStripMenuItem, suicideToolStripMenuItem, customToolStripMenuItem}
    End Sub

    Private Sub newButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newGameButton.Click
        game.newGame()
    End Sub

    Private Sub instawinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instawinButton.Click
        ' Get data from picturebox
        Dim picBoxData() As String = CStr(minefieldPictureBox.Tag).Split(CChar(","))

        ' Translate to local variables
        Dim fieldWidth As Integer = CInt(picBoxData(0))
        Dim fieldHeight As Integer = CInt(picBoxData(1))
        Dim fieldMines As Integer = CInt(picBoxData(2))

        For X As Integer = 0 To fieldWidth - 1
            For Y As Integer = 0 To fieldHeight - 1
                'game.mineField(X, Y).isOpen = True
            Next
        Next

        'game.DrawMineField(fieldWidth, fieldHeight)
    End Sub

    Private Sub newGameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles newGameToolStripMenuItem.Click
        game.newGame()
    End Sub


    Private Sub marksToolStripMenuItem_CheckedChanged(sender As Object, e As System.EventArgs) Handles marksToolStripMenuItem.CheckedChanged
        ' Check that the object is initialized (this event is triggered on form load before the menu item is fully initialized)
        If Not IsNothing(game) Then
            ' Update boolean value in game object
            game.useQuestionMarks = DirectCast(sender, ToolStripMenuItem).Checked
        End If
    End Sub

    ' The click event is used so that the checked state of menu items can be programmatically changed without
    ' triggering the same event over again. The click event is still called when the keyboard is used to make a selection.
    Private Sub expertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles beginnerToolStripMenuItem.Click, intermediateToolStripMenuItem.Click, expertToolStripMenuItem.Click, suicideToolStripMenuItem.Click, customToolStripMenuItem.Click
        Dim menuItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        For i As Integer = 0 To difficultyMenuItems.Count - 1
            If menuItem.Name <> difficultyMenuItems(i).Name Then
                ' If the name doesn't match the checked item, uncheck it.
                difficultyMenuItems(i).Checked = False
            Else
                ' Otherwise it is the current difficulty so use it's index to set our difficulty level
                game.setDifficulty(menuItem.Text)
            End If
        Next

        ' Ensure that if the same item is selected, it stays checked.
        menuItem.Checked = True

        If menuItem.Name = "customToolStripMenuItem" Then
            game.setDifficulty(Minesweeper.Difficulty.Custom)

            ' Get the dimensions and mines from the user.
            game.setCustomAttributes(
                CInt(InputBox("Please enter desired width.", "Custom Size", "10")),
                CInt(InputBox("Please enter desired height.", "Custom Size", "10")),
                CInt(InputBox("Please enter desired number of mines.", "Custom Size", "10"))
            )

        End If

        game.newGame()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        game = New Minesweeper(Me, minefieldPictureBox, newGameButton)
        game.setDifficulty(Minesweeper.Difficulty.Beginner)

        ' Each Windows OS has different border sizing and stupidly form size includes those borders.
        ' The Minesweeper class needs the differences so it can resize the form properly to fit
        ' the PictureBox on different difficulty levels.
        game.borderWidth = Me.Width - minefieldPictureBox.Width
        game.borderHeight = Me.Height - minefieldPictureBox.Height
        game.newGame()
    End Sub
End Class
