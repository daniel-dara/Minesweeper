<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.instawinButton = New System.Windows.Forms.Button()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.marksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.customToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.suicideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bestTimesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.howToPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.expertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.minesLabel = New System.Windows.Forms.Label()
        Me.intermediateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mineTextLabel = New System.Windows.Forms.Label()
        Me.timeTextLabel = New System.Windows.Forms.Label()
        Me.gamePanel = New System.Windows.Forms.Panel()
        Me.newGameButton = New System.Windows.Forms.Button()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.beginnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.newGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.minefieldPictureBox = New System.Windows.Forms.PictureBox()
        Me.gameMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.gamePanel.SuspendLayout()
        CType(Me.minefieldPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gameMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'instawinButton
        '
        Me.instawinButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.instawinButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.instawinButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instawinButton.ForeColor = System.Drawing.Color.White
        Me.instawinButton.Location = New System.Drawing.Point(174, 3)
        Me.instawinButton.Margin = New System.Windows.Forms.Padding(0)
        Me.instawinButton.Name = "instawinButton"
        Me.instawinButton.Size = New System.Drawing.Size(60, 18)
        Me.instawinButton.TabIndex = 22
        Me.instawinButton.Text = "Insta-Win"
        Me.instawinButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.instawinButton.UseVisualStyleBackColor = True
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'marksToolStripMenuItem
        '
        Me.marksToolStripMenuItem.Checked = True
        Me.marksToolStripMenuItem.CheckOnClick = True
        Me.marksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.marksToolStripMenuItem.Name = "marksToolStripMenuItem"
        Me.marksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.marksToolStripMenuItem.Text = "Marks (?)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'customToolStripMenuItem
        '
        Me.customToolStripMenuItem.CheckOnClick = True
        Me.customToolStripMenuItem.Name = "customToolStripMenuItem"
        Me.customToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.customToolStripMenuItem.Text = "Custom..."
        '
        'suicideToolStripMenuItem
        '
        Me.suicideToolStripMenuItem.Name = "suicideToolStripMenuItem"
        Me.suicideToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.suicideToolStripMenuItem.Text = "Suicide"
        '
        'bestTimesToolStripMenuItem
        '
        Me.bestTimesToolStripMenuItem.Name = "bestTimesToolStripMenuItem"
        Me.bestTimesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.bestTimesToolStripMenuItem.Text = "Best Times..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'howToPlayToolStripMenuItem
        '
        Me.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem"
        Me.howToPlayToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.howToPlayToolStripMenuItem.Text = "How to Play"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(135, 6)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.aboutToolStripMenuItem.Text = "About"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem, Me.ToolStripSeparator5, Me.howToPlayToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.helpToolStripMenuItem.Text = "Help"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'expertToolStripMenuItem
        '
        Me.expertToolStripMenuItem.CheckOnClick = True
        Me.expertToolStripMenuItem.Name = "expertToolStripMenuItem"
        Me.expertToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.expertToolStripMenuItem.Tag = "30,19,99"
        Me.expertToolStripMenuItem.Text = "Expert"
        '
        'minesLabel
        '
        Me.minesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.minesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.minesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minesLabel.ForeColor = System.Drawing.Color.White
        Me.minesLabel.Location = New System.Drawing.Point(21, 25)
        Me.minesLabel.Name = "minesLabel"
        Me.minesLabel.Size = New System.Drawing.Size(50, 26)
        Me.minesLabel.TabIndex = 4
        Me.minesLabel.Text = "0"
        Me.minesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'intermediateToolStripMenuItem
        '
        Me.intermediateToolStripMenuItem.CheckOnClick = True
        Me.intermediateToolStripMenuItem.Name = "intermediateToolStripMenuItem"
        Me.intermediateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.intermediateToolStripMenuItem.Tag = "16,16,40"
        Me.intermediateToolStripMenuItem.Text = "Intermediate"
        '
        'mineTextLabel
        '
        Me.mineTextLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.mineTextLabel.AutoSize = True
        Me.mineTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mineTextLabel.ForeColor = System.Drawing.Color.White
        Me.mineTextLabel.Location = New System.Drawing.Point(24, 5)
        Me.mineTextLabel.Name = "mineTextLabel"
        Me.mineTextLabel.Size = New System.Drawing.Size(45, 17)
        Me.mineTextLabel.TabIndex = 3
        Me.mineTextLabel.Text = "Mines"
        '
        'timeTextLabel
        '
        Me.timeTextLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.timeTextLabel.AutoSize = True
        Me.timeTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeTextLabel.ForeColor = System.Drawing.Color.White
        Me.timeTextLabel.Location = New System.Drawing.Point(155, 5)
        Me.timeTextLabel.Name = "timeTextLabel"
        Me.timeTextLabel.Size = New System.Drawing.Size(39, 17)
        Me.timeTextLabel.TabIndex = 2
        Me.timeTextLabel.Text = "Time"
        '
        'gamePanel
        '
        Me.gamePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gamePanel.BackColor = System.Drawing.Color.Gray
        Me.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gamePanel.Controls.Add(Me.minesLabel)
        Me.gamePanel.Controls.Add(Me.mineTextLabel)
        Me.gamePanel.Controls.Add(Me.timeTextLabel)
        Me.gamePanel.Controls.Add(Me.newGameButton)
        Me.gamePanel.Controls.Add(Me.timeLabel)
        Me.gamePanel.Location = New System.Drawing.Point(10, 29)
        Me.gamePanel.Name = "gamePanel"
        Me.gamePanel.Size = New System.Drawing.Size(224, 61)
        Me.gamePanel.TabIndex = 21
        '
        'newGameButton
        '
        Me.newGameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.newGameButton.BackColor = System.Drawing.Color.Black
        Me.newGameButton.FlatAppearance.BorderSize = 2
        Me.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newGameButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newGameButton.ForeColor = System.Drawing.Color.White
        Me.newGameButton.Location = New System.Drawing.Point(85, 3)
        Me.newGameButton.Name = "newGameButton"
        Me.newGameButton.Size = New System.Drawing.Size(50, 50)
        Me.newGameButton.TabIndex = 1
        Me.newGameButton.Text = "=)"
        Me.newGameButton.UseVisualStyleBackColor = False
        '
        'timeLabel
        '
        Me.timeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.ForeColor = System.Drawing.Color.White
        Me.timeLabel.Location = New System.Drawing.Point(149, 25)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(50, 26)
        Me.timeLabel.TabIndex = 13
        Me.timeLabel.Text = "0"
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 1000
        '
        'beginnerToolStripMenuItem
        '
        Me.beginnerToolStripMenuItem.Checked = True
        Me.beginnerToolStripMenuItem.CheckOnClick = True
        Me.beginnerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem"
        Me.beginnerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.beginnerToolStripMenuItem.Tag = "9,9,10"
        Me.beginnerToolStripMenuItem.Text = "Beginner"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'newGameToolStripMenuItem
        '
        Me.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem"
        Me.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.newGameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.newGameToolStripMenuItem.Text = "New Game"
        '
        'gameToolStripMenuItem
        '
        Me.gameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newGameToolStripMenuItem, Me.ToolStripSeparator1, Me.beginnerToolStripMenuItem, Me.intermediateToolStripMenuItem, Me.expertToolStripMenuItem, Me.suicideToolStripMenuItem, Me.customToolStripMenuItem, Me.ToolStripSeparator2, Me.marksToolStripMenuItem, Me.ToolStripSeparator3, Me.bestTimesToolStripMenuItem, Me.ToolStripSeparator4, Me.exitToolStripMenuItem})
        Me.gameToolStripMenuItem.Name = "gameToolStripMenuItem"
        Me.gameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.gameToolStripMenuItem.Text = "Game"
        '
        'minefieldPictureBox
        '
        Me.minefieldPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minefieldPictureBox.BackColor = System.Drawing.Color.Silver
        Me.minefieldPictureBox.Location = New System.Drawing.Point(8, 96)
        Me.minefieldPictureBox.Name = "minefieldPictureBox"
        Me.minefieldPictureBox.Size = New System.Drawing.Size(227, 149)
        Me.minefieldPictureBox.TabIndex = 19
        Me.minefieldPictureBox.TabStop = False
        '
        'gameMenuStrip
        '
        Me.gameMenuStrip.BackColor = System.Drawing.Color.Silver
        Me.gameMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gameToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.gameMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.gameMenuStrip.Name = "gameMenuStrip"
        Me.gameMenuStrip.Size = New System.Drawing.Size(243, 24)
        Me.gameMenuStrip.TabIndex = 20
        Me.gameMenuStrip.Text = "MenuStrip1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(243, 252)
        Me.Controls.Add(Me.instawinButton)
        Me.Controls.Add(Me.gamePanel)
        Me.Controls.Add(Me.minefieldPictureBox)
        Me.Controls.Add(Me.gameMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "Minesweeper"
        Me.gamePanel.ResumeLayout(False)
        Me.gamePanel.PerformLayout()
        CType(Me.minefieldPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gameMenuStrip.ResumeLayout(False)
        Me.gameMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents instawinButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents marksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents customToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents suicideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bestTimesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents howToPlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents expertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minesLabel As System.Windows.Forms.Label
    Friend WithEvents intermediateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mineTextLabel As System.Windows.Forms.Label
    Friend WithEvents timeTextLabel As System.Windows.Forms.Label
    Friend WithEvents gamePanel As System.Windows.Forms.Panel
    Friend WithEvents newGameButton As System.Windows.Forms.Button
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents gameTimer As System.Windows.Forms.Timer
    Friend WithEvents beginnerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents newGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minefieldPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents gameMenuStrip As System.Windows.Forms.MenuStrip

End Class
