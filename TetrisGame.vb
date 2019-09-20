Option Strict On
Imports MyGames.Tetris
Imports MyGames.Tetris.TetrisBlock

Partial Class TetrisGame
    Private GameBoard As TetrisBoard
    Private FallingBlock As TetrisBlock
    Private PreviewBoard As TetrisBoard
    Private PreviewBlock As TetrisBlock

    Private Score As Double
    Private Level As Integer
    Private Speed As Integer
    Private Lines As Integer

    Private RandomNumbers As New Random
    Private Status As GameStatus = GameStatus.Stopped

    Private Enum GameStatus
        Running
        Paused
        Stopped
    End Enum

#Region "Event Handlers"
    Private Sub TetrisGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreviewBoard = New TetrisBoard(PreviewBox)
        With PreviewBoard
            .Rows = 4
            .Columns = 4
            .CellSize = New Size(20, 20)
            .Style = BorderStyle.FixedSingle
            .SetupBoard()
        End With
        PreviewBlock = New TetrisBlock(PreviewBoard)
        PreviewBlock.CenterCell = PreviewBoard.Cells(2, 2)
        PreviewBlock.Shape = GetRandomShape()

        GameBoard = New TetrisBoard(GameBox)
        With GameBoard
            .Rows = 20
            .Columns = 10
            .CellSize = New Size(20, 20)
            .Style = BorderStyle.FixedSingle
            .SetupBoard()
        End With
        FallingBlock = New TetrisBlock(GameBoard)

        HelpLabel.Text = HelpLabel.Text.Replace("|", vbCrLf)
        StylesLabel.Text = StylesLabel.Text.Replace("|", vbCrLf)
        ShowMessage(String.Format("{0}W E L C O M E{0}{0}T O{0}{0}T E T R I S{0}{0}{0}{0}Click here to start new game", vbCrLf))

    End Sub

    Private Sub TetrisGame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Down, Keys.Up
                If Status = GameStatus.Running Then
                    With FallingBlock
                        Select Case e.KeyCode
                            Case Keys.Left
                                If .CanMove(MoveDirection.Left) Then .Move(MoveDirection.Left)
                            Case Keys.Right
                                If .CanMove(MoveDirection.Right) Then .Move(MoveDirection.Right)
                            Case Keys.Down
                                If .CanMove(MoveDirection.Down) Then .Move(MoveDirection.Down)
                            Case Keys.Up
                                If .CanRotate Then .Rotate()
                        End Select
                    End With
                End If
            Case Keys.P
                If Status <> GameStatus.Stopped Then TogglePauseGame()
            Case Keys.N
                If Status = GameStatus.Stopped Then
                    StartNewGame()
                ElseIf DialogResult.Yes = MessageBox.Show("Abort current game?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    StartNewGame()
                End If
            Case Keys.B
                GameBoard.Style = BorderStyle.FixedSingle
                PreviewBoard.Style = BorderStyle.FixedSingle
                GameBoard.Color = Color.Empty
                PreviewBoard.Color = Color.Empty
            Case Keys.M
                GameBoard.Style = BorderStyle.None
                PreviewBoard.Style = BorderStyle.None
                GameBoard.Color = Color.Empty
                PreviewBoard.Color = Color.Empty
            Case Keys.F
                GameBoard.Style = BorderStyle.None
                PreviewBoard.Style = BorderStyle.None
                GameBoard.Color = Color.Orange
                PreviewBoard.Color = Color.Orange
            Case Keys.S
                GameBoard.Style = BorderStyle.None
                PreviewBoard.Style = BorderStyle.None
                GameBoard.Color = Color.SkyBlue
                PreviewBoard.Color = Color.SkyBlue
            Case Keys.W
                GameBoard.Style = BorderStyle.None
                PreviewBoard.Style = BorderStyle.None
                GameBoard.Color = Color.Blue
                PreviewBoard.Color = Color.Blue
            Case Keys.C
                GameBoard.Style = BorderStyle.None
                PreviewBoard.Style = BorderStyle.None
                GameBoard.Color = Color.Chocolate
                PreviewBoard.Color = Color.Chocolate
        End Select
    End Sub

    Private Sub MessageLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageLabel.Click
        Select Case Status
            Case GameStatus.Stopped
                StartNewGame()
            Case GameStatus.Paused
                TogglePauseGame()
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If FallingBlock.CanMove(MoveDirection.Down) Then
            FallingBlock.Move(MoveDirection.Down)
        Else
            '' Fix block to base
            For Each cell As TetrisCell In FallingBlock.Cells
                cell.IsEmpty = False
            Next

            '' Remove completed rows
            Dim checkRows = From cell In FallingBlock.Cells _
                            Order By cell.Row _
                            Select cell.Row Distinct
            Dim rowsRemoved As Integer = 0
            For Each row In checkRows
                If GameBoard.IsRowComplete(row) Then
                    GameBoard.RemoveRow(row)
                    rowsRemoved += 1
                End If
            Next

            '' Update Statistics
            Score += Math.Pow(rowsRemoved, 2) * 100
            Lines += rowsRemoved
            Speed = 1 + Lines \ 10
            If Speed Mod 10 = 0 Then Level += 1 : Speed = 1
            Timer1.Interval = (10 - Speed) * 100
            UpdateStatistics()

            '' Make the next block fall
            DropNextFallingBlock()

            '' Check if game has ended
            If Not FallingBlock.CanMove(FallingBlock.CenterCell) Then EndGame()
        End If
    End Sub
#End Region

#Region "Private Methods"
    Private Function GetRandomShape() As TetrisBlock.Shapes
        Dim number As Integer = RandomNumbers.Next(Shapes.I1, Shapes.Z4 + 1) 'first to last
        Return CType(number, TetrisBlock.Shapes)
    End Function

    Private Sub DropNextFallingBlock()
        FallingBlock.CenterCell = GameBoard.Cells(2, GameBoard.Columns \ 2)
        FallingBlock.Shape = PreviewBlock.Shape
        PreviewBlock.Shape = GetRandomShape()
        PreviewBlock.RefreshBackGround()
        PreviewBlock.Refresh()
    End Sub

    Private Sub StartNewGame()
        Score = 0
        Lines = 0
        Speed = 1
        Level = 1
        Timer1.Interval = 1000
        UpdateStatistics()

        GameBoard.SetupBoard()
        'PreviewBlock.Shape = GetRandomShape()
        DropNextFallingBlock()
        MessageLabel.Visible = False
        Timer1.Enabled = True
        Status = GameStatus.Running
    End Sub

    Private Sub EndGame()
        Timer1.Enabled = False
        Status = GameStatus.Stopped
        ShowMessage(String.Format("{0}{0}GAME OVER{0}{0}{0}{0}Click here to start new game", vbCrLf))
    End Sub

    Private Sub UpdateStatistics()
        ScoreLabel.Text = Score.ToString("000")
        LinesLabel.Text = Lines.ToString
        LevelLabel.Text = Level.ToString
        SpeedLabel.Text = Speed.ToString
    End Sub

    Private Sub TogglePauseGame()
        If Status = GameStatus.Paused Then
            Status = GameStatus.Running
            MessageLabel.Visible = False
            Timer1.Enabled = True
        Else
            Status = GameStatus.Paused
            ShowMessage(String.Format("{0}{0}GAME PAUSED{0}{0}{0}{0}Click here to resume.", vbCrLf))
        End If
    End Sub

    Private Sub ShowMessage(ByVal message As String)
        MessageLabel.Text = message
        MessageLabel.Visible = True
        Timer1.Enabled = False
    End Sub
#End Region

End Class
