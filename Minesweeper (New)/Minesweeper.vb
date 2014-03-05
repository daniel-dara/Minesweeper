Imports System.Drawing.Drawing2D

Public Class Minesweeper
    Public Enum Difficulty
        Beginner
        Intermediate
        Expert
        Suicide
        Custom
    End Enum

    Public useQuestionMarks As Boolean
    Public borderWidth As Integer
    Public borderHeight As Integer

    ' Values for a custom game
    Private customWidth As Integer
    Private customHeight As Integer
    Private customMines As Integer

    Private diff As Difficulty
    Private prevPoint As Point
    Private isLeftMouseButtonDown As Boolean
    Private isFirstClick As Boolean
    Private minefield As Tile(,)
    Private fieldWidth As Integer
    Private fieldHeight As Integer
    Private fieldMines As Integer

    ' Pointers to form objects
    Private mainForm As Form
    Private minefieldPictureBox As PictureBox
    Private newGameButton As Button

    Private Const win7SideBorder = 8
    Private Const win7TopBorder As Integer = 30
    Private Const tileSize As Integer = 25
    Private rand As Random

    ' Offsets are for looping through all surrounding tiles efficiently
    Private xOffsets() As Integer = {-1, 0, 1, -1, 1, -1, 0, 1}
    Private yOffsets() As Integer = {-1, -1, -1, 0, 0, 1, 1, 1}

    ' Structure to represent each tile on the board
    Private Structure Tile
        Public isOpen As Boolean           ' Has been opened
        Public isDepressed As Boolean      ' Has been clicked and held, not opened yet...
        Public isMine As Boolean
        Public mark As Integer
        Public surroundingMines As Integer

        Public Sub New(ByVal _isClicked As Boolean, ByVal _isDown As Boolean, ByVal _isMine As Boolean, ByVal _mark As Integer, ByVal _surroundingMines As Integer)
            isOpen = _isClicked
            isDepressed = _isDown
            isMine = _isMine
            mark = _mark
            surroundingMines = _surroundingMines
        End Sub
    End Structure

    ' Constructor
    Public Sub New(ByRef _mainForm As Form, ByRef _minefieldPictureBox As PictureBox, ByRef _newGameButton As Button)
        ' Set internal reference variables
        mainForm = _mainForm
        minefieldPictureBox = _minefieldPictureBox
        newGameButton = _newGameButton

        ' Initialize random number generator
        rand = New Random
    End Sub

    ' Set attributes for a custom game (difficulty CUSTOM must also be set for the values to be used)
    Public Sub setCustomAttributes(ByVal width As Integer, ByVal height As Integer, ByVal mines As Integer)
        customWidth = width
        customHeight = height
        customMines = mines
    End Sub

    Public Sub setDifficulty(ByVal _difficulty As Difficulty)
        diff = _difficulty
    End Sub

    Public Sub setDifficulty(ByVal _difficulty As String)
        ' Turn string into a value of enum Difficulty
        [Enum].TryParse(_difficulty, diff)
    End Sub

    Public Sub newGame()
        ' Reset variables and objects
        isFirstClick = True
        isLeftMouseButtonDown = False
        newGameButton.Text = "=)"

        ' Calculate suicide attributes (must be dynamically calculated to support multi-monitors)
        Dim suicideHeight As Integer = (Screen.GetWorkingArea(mainForm.Location).Height - borderHeight) \ tileSize
        Dim suicideWidth As Integer = (Screen.GetWorkingArea(mainForm.Location).Width - borderWidth) \ tileSize
        Dim suicideMines As Integer = 10 '(suicideHeight * suicideWidth) \ 8

        ' Create attribute arrays
        Dim difficultyWidths() As Integer = {9, 16, 24, suicideWidth, customWidth}
        Dim difficultyHeights() As Integer = {9, 16, 24, suicideHeight, customHeight}
        Dim difficultyMines() As Integer = {10, 40, 99, suicideMines, customMines}

        ' Set attributes for the new game
        fieldWidth = difficultyWidths(diff)
        fieldHeight = difficultyHeights(diff)
        fieldMines = difficultyMines(diff)

        ' Initialize image
        Dim imageWidth = fieldWidth * tileSize + 2
        Dim imageHeight = fieldHeight * tileSize + 2
        minefieldPictureBox.Image = New Bitmap(imageWidth, imageHeight)
        minefieldPictureBox.Tag = fieldWidth & "," & fieldHeight & "," & fieldMines

        ' Resize the form
        mainForm.Size = New Size(imageWidth + borderWidth, imageHeight + borderHeight)

        ' Suicide should auto-center since it will nearly fill the screen.
        If diff = Difficulty.Suicide Then
            mainForm.Location = New Point(Screen.GetBounds(mainForm.Location).X + (Screen.GetWorkingArea(mainForm.Location).Width - mainForm.Width) \ 2,
                                          Screen.GetBounds(mainForm.Location).Y + (Screen.GetWorkingArea(mainForm.Location).Height - mainForm.Height) \ 2)
        End If

        ' Initialize and draw the minefield
        minefield = New Tile(fieldWidth, fieldHeight) {}
        drawMineField()

        ' Add Mouse Handlers
        AddHandler minefieldPictureBox.MouseDown, AddressOf fieldPictureBox_MouseDown
        AddHandler minefieldPictureBox.MouseUp, AddressOf fieldPictureBox_MouseUp
        AddHandler minefieldPictureBox.MouseMove, AddressOf fieldPictureBox_MouseMove
    End Sub

    Public Sub CreateMineField(ByVal clickX As Integer, ByVal clickY As Integer)
        ' Get data from picturebox
        Dim picBoxData() As String = CStr(minefieldPictureBox.Tag).Split(CChar(","))

        ' Translate to local variables
        Dim fieldWidth As Integer = CInt(picBoxData(0))
        Dim fieldHeight As Integer = CInt(picBoxData(1))
        Dim fieldMines As Integer = CInt(picBoxData(2))

        Dim i As Integer
        Dim p As Point

        ' Populate Mines
        While (i < fieldMines)
            p.X = rand.Next(0, fieldWidth)
            p.Y = rand.Next(0, fieldHeight)

            ' Make sure space isn't already a mine or the click point
            If minefield(p.X, p.Y).isMine = False And (p.X <> clickX Or p.Y <> clickY) Then
                i += 1
                minefield(p.X, p.Y).isMine = True
            End If
        End While

        ' Calculate tile sums
        For x As Integer = 0 To fieldWidth - 1
            For y As Integer = 0 To fieldHeight - 1
                minefield(x, y).surroundingMines = sumSurroundingSpaces(x, y)
            Next
        Next
    End Sub

    Private Sub drawMineField()
        Dim b As New Bitmap(minefieldPictureBox.Image)
        Dim g As Graphics = Graphics.FromImage(b)

        ' Draw tiles
        For x As Integer = 0 To fieldWidth - 1
            For y As Integer = 0 To fieldHeight - 1
                g.DrawImage(createTileGraphic(minefield(x, y)), New Point(x * tileSize + 1, y * tileSize + 1))
            Next
        Next

        g.Dispose()

        minefieldPictureBox.Image = b
    End Sub

    Private Function createTileGraphic(ByVal Tile As Tile) As Bitmap

        ' Create brushes and other drawing tools
        Static tileBrush As LinearGradientBrush = New LinearGradientBrush(New Point(0, 0), New Point(25, 25), Color.FromArgb(60, 60, 60), Color.Black)
        Static mineBrush As LinearGradientBrush = New LinearGradientBrush(New Point(5, 5), New Point(19, 19), Color.Red, Color.DarkRed)
        Static mineOutlineBrush As LinearGradientBrush = New LinearGradientBrush(New Point(4, 4), New Point(20, 20), Color.Yellow, Color.DarkGoldenrod)
        Static mineOutlinePen As Pen = New Pen(mineOutlineBrush)
        Static backgroundBrush As SolidBrush = New SolidBrush(Color.FromArgb(90, 90, 90))

        Static b As Bitmap = New Bitmap(25, 25)
        Static g As Graphics = Graphics.FromImage(b)

        Static textColors() As Color = {Color.White, Color.Lime, Color.Red, Color.Cyan, Color.Gold, Color.Fuchsia, Color.Black, Color.DarkGray}

        If Tile.isOpen Or Tile.isDepressed Then

            ' Background of clicked square
            g.FillRectangle(backgroundBrush, New Rectangle(1, 1, 23, 23))

            If Tile.isOpen Then
                If Tile.isMine Then
                    If Tile.surroundingMines = -1 Then g.FillRectangle(Brushes.Red, New Rectangle(1, 1, 23, 23))
                    g.FillEllipse(mineBrush, 5, 5, 14, 14)
                    g.DrawEllipse(mineOutlinePen, 5, 5, 14, 14)
                    g.DrawEllipse(mineOutlinePen, 4, 4, 16, 16)
                Else
                    If Tile.surroundingMines > 0 Then g.DrawString(Tile.surroundingMines.ToString, New Font("Tahoma", 14, FontStyle.Bold), New SolidBrush(textColors(Tile.surroundingMines - 1)), 3, 1)
                End If
            End If
        Else
            ' Fill foreground of unclicked space
            g.FillRectangle(tileBrush, New Rectangle(1, 1, 23, 23))

            ' Draw marking
            Select Case Tile.mark
                Case 1
                    g.DrawString("X", New Font("Tahoma", 14, FontStyle.Bold), Brushes.Red, 3, 1)
                Case 2
                    g.DrawString("?", New Font("Tahoma", 14, FontStyle.Bold), Brushes.White, 4, 1)
            End Select
        End If

        'g.Dispose()

        Return b
    End Function

    Private Sub drawTileGraphic(ByVal x As Integer, ByVal y As Integer)
        Dim b As Bitmap = New Bitmap(minefieldPictureBox.Image)
        Dim g As Graphics = Graphics.FromImage(b)

        g.DrawImage(createTileGraphic(minefield(x, y)), New Point(x * tileSize + 1, y * tileSize + 1))

        minefieldPictureBox.Image = b
        g.Dispose()
    End Sub

    Private Sub clickTile(ByVal x As Integer, ByVal y As Integer, ByVal button As System.Windows.Forms.MouseButtons)

        If button = MouseButtons.Left Then

            If checkBounds(New Point(x, y)) Then

                If isFirstClick And button = MouseButtons.Left And minefield(x, y).mark = 0 Then
                    CreateMineField(x, y)
                    isFirstClick = False
                End If

                Dim spacesOpened As Integer
                Dim isMine As Boolean

                ' Open the tile
                isMine = openTile(x, y, spacesOpened)

                ' Draw the tile (doesn't hurt even if we need to draw the whole field)
                drawTileGraphic(x, y)

                ' Check for end of game
                If isMine Then

                    ' Remove mouse handlers
                    RemoveHandler minefieldPictureBox.MouseDown, AddressOf fieldPictureBox_MouseDown
                    RemoveHandler minefieldPictureBox.MouseUp, AddressOf fieldPictureBox_MouseUp
                    RemoveHandler minefieldPictureBox.MouseMove, AddressOf fieldPictureBox_MouseMove

                    ' Draw the tile
                    drawTileGraphic(x, y)

                    ' Change smiley to lose state
                    newGameButton.Text = "XO"

                ElseIf spacesOpened > 1 Then

                    ' Redraw entire field if we drew more than one tile
                    drawMineField()
                End If
            End If
        ElseIf button = MouseButtons.Right Then 'And mineField(x, y).isOpen = False Then *Handled by draw function

            ' Increment the tiles mark
            minefield(x, y).mark = (minefield(x, y).mark + 1) Mod If(useQuestionMarks, 2, 3)

            ' Redraw tile
            drawTileGraphic(x, y)
        End If
    End Sub

    Private Function openTile(ByVal x As Integer, ByVal y As Integer, ByRef spacesOpened As Integer) As Boolean
        ' Return if out of range
        'If x < 0 Or x >= fieldWidth Or y < 0 Or y >= fieldHeight Then Return False

        ' Return if already clicked or marked
        'If minefield(x, y).isOpen Or minefield(x, y).mark <> 0 Then Return False

        ' Set as clicked and end recursion if not empty
        minefield(x, y).isOpen = True

        ' Increment spaces opened
        spacesOpened += 1

        ' Return if it is a mine
        If minefield(x, y).isMine Then Return True

        ' Return if there is at least one mine around us
        If minefield(x, y).surroundingMines > 0 Then Return False

        ' Recurse through all possible surrounding squares
        For i As Integer = 0 To 7
            ' Return if out of range
            If Not (x + xOffsets(i) < 0 Or x + xOffsets(i) >= fieldWidth Or y + yOffsets(i) < 0 Or y + yOffsets(i) >= fieldHeight) Then
                If Not (minefield(x + xOffsets(i), y + yOffsets(i)).isOpen Or minefield(x + xOffsets(i), y + yOffsets(i)).mark <> 0) Then
                    openTile(x + xOffsets(i), y + yOffsets(i), spacesOpened)
                End If
            End If
        Next

        Return False
    End Function

    Private Function sumSurroundingSpaces(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim newX As Integer
        Dim newY As Integer
        Dim sum As Integer

        ' Iterate through each surrounding square
        For i As Integer = 0 To 7
            newX = x + xOffsets(i)
            newY = y + yOffsets(i)

            ' Check range for boundries, then if it is a mine, increment sum
            If 0 <= newX And newX <= fieldWidth And 0 <= newY And newY <= fieldHeight Then If minefield(newX, newY).isMine Then sum += 1
        Next

        Return sum
    End Function

    Private Function checkBounds(ByVal p As Point) As Boolean
        Return (p.X > 0 And p.X < fieldWidth And p.Y > 0 And p.Y < fieldHeight)
    End Function

    Private Sub fieldPictureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ' Set boolean indicator for drag effect
            isLeftMouseButtonDown = True

            ' Use previous point as a temp variable
            prevPoint = New Point(e.X \ tileSize, e.Y \ tileSize)

            ' Check if the tile has a mark or is open
            If minefield(prevPoint.X, prevPoint.Y).isOpen = False And minefield(prevPoint.X, prevPoint.Y).mark = 0 Then
                ' Change smiley face
                newGameButton.Text = "=O"

                ' Set isDepressed value
                minefield(prevPoint.X, prevPoint.Y).isDepressed = True

                ' Redraw tile
                drawTileGraphic(prevPoint.X, prevPoint.Y)
            End If
        End If
    End Sub

    Private Sub fieldPictureBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Calculate current point
        Dim curPoint As New Point(e.X \ tileSize, e.Y \ tileSize)

        If e.Button = MouseButtons.Left Then
            isLeftMouseButtonDown = False

            ' Pre-emptively set smiley to safe state
            newGameButton.Text = "=)"
        End If

        clickTile(curPoint.X, curPoint.Y, e.Button)
    End Sub

    Private Sub fieldPictureBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' If the mouse is being dragged
        If isLeftMouseButtonDown Then

            ' Calculate tile in mine field
            Dim curPoint As New Point(e.X \ tileSize, e.Y \ tileSize)

            ' If we moved to a different tile
            If prevPoint <> curPoint Then

                ' Change the state of the previous tile (doesn't matter if it was depressed to begin with or not)
                minefield(prevPoint.X, prevPoint.Y).isDepressed = False

                ' Redraw previous tile
                drawTileGraphic(prevPoint.X, prevPoint.Y)

                ' Check that the current point is in the bounds of the mine field
                If checkBounds(curPoint) Then

                    ' Check that the current tile hasn't been opened yet and doesn't have a mark
                    If minefield(curPoint.X, curPoint.Y).isOpen = False And minefield(curPoint.X, curPoint.Y).mark = 0 Then
                        ' Change smiley face
                        newGameButton.Text = "=O"

                        ' Update the tile to reflect the depressed state
                        minefield(curPoint.X, curPoint.Y).isDepressed = True

                        ' Redraw tile
                        drawTileGraphic(curPoint.X, curPoint.Y)
                    Else
                        ' Change smiley face to safe state
                        newGameButton.Text = "=)"
                    End If

                    ' Set previous point
                    prevPoint = curPoint
                Else
                    ' Change smiley face to safe state
                    newGameButton.Text = "=)"
                End If
            End If
        End If
    End Sub
End Class
