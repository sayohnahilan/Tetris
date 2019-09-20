<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TetrisGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.HelpLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LinesLabel = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SpeedLabel = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ScoreLabel = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.LevelLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GameBox = New System.Windows.Forms.PictureBox
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.PreviewBox = New System.Windows.Forms.PictureBox
        Me.StylesLabel = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HelpLabel
        '
        Me.HelpLabel.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpLabel.Location = New System.Drawing.Point(220, 241)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(200, 65)
        Me.HelpLabel.TabIndex = 28
        Me.HelpLabel.Text = "Left   Move Left|Right  Move Right|Down   Move Down|Up     Rotate Block|N      Ne" & _
            "w Game|P      Pause Game|B      Classic Brick Style|M      Molten Metal Style|"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Keys:"
        '
        'LinesLabel
        '
        Me.LinesLabel.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinesLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.LinesLabel.Location = New System.Drawing.Point(342, 144)
        Me.LinesLabel.Name = "LinesLabel"
        Me.LinesLabel.Size = New System.Drawing.Size(54, 16)
        Me.LinesLabel.TabIndex = 25
        Me.LinesLabel.Text = "0"
        Me.LinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Lines"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpeedLabel
        '
        Me.SpeedLabel.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.SpeedLabel.Location = New System.Drawing.Point(277, 144)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(54, 16)
        Me.SpeedLabel.TabIndex = 23
        Me.SpeedLabel.Text = "1"
        Me.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(277, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Speed"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.Color.Red
        Me.ScoreLabel.Location = New System.Drawing.Point(305, 29)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(104, 26)
        Me.ScoreLabel.TabIndex = 21
        Me.ScoreLabel.Text = "000"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Your Score"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LevelLabel
        '
        Me.LevelLabel.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.LevelLabel.Location = New System.Drawing.Point(220, 144)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(54, 16)
        Me.LevelLabel.TabIndex = 19
        Me.LevelLabel.Text = "1"
        Me.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Level"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameBox
        '
        Me.GameBox.BackColor = System.Drawing.Color.DimGray
        Me.GameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GameBox.Location = New System.Drawing.Point(12, 13)
        Me.GameBox.Name = "GameBox"
        Me.GameBox.Size = New System.Drawing.Size(200, 400)
        Me.GameBox.TabIndex = 31
        Me.GameBox.TabStop = False
        '
        'MessageLabel
        '
        Me.MessageLabel.BackColor = System.Drawing.Color.Black
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.Color.Yellow
        Me.MessageLabel.Location = New System.Drawing.Point(39, 100)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(139, 197)
        Me.MessageLabel.TabIndex = 32
        Me.MessageLabel.Text = "WELCOME TO TETRIS"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PreviewBox
        '
        Me.PreviewBox.BackColor = System.Drawing.Color.Transparent
        Me.PreviewBox.Location = New System.Drawing.Point(223, 39)
        Me.PreviewBox.Name = "PreviewBox"
        Me.PreviewBox.Size = New System.Drawing.Size(80, 80)
        Me.PreviewBox.TabIndex = 33
        Me.PreviewBox.TabStop = False
        '
        'StylesLabel
        '
        Me.StylesLabel.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StylesLabel.Location = New System.Drawing.Point(220, 341)
        Me.StylesLabel.Name = "StylesLabel"
        Me.StylesLabel.Size = New System.Drawing.Size(200, 68)
        Me.StylesLabel.TabIndex = 35
        Me.StylesLabel.Text = "B      Classic Bricks|M      Molten Metal|F      Fire|S      Sky|W      Water|C  " & _
            "    Chocolate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(220, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Style:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(220, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Next"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TetrisGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 430)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StylesLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PreviewBox)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.GameBox)
        Me.Controls.Add(Me.HelpLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinesLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SpeedLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TetrisGame"
        Me.Text = "TetrisGame"
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviewBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinesLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SpeedLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LevelLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GameBox As System.Windows.Forms.PictureBox
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents PreviewBox As System.Windows.Forms.PictureBox
    Friend WithEvents StylesLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
