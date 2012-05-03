<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscardValuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValueCounter = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ValueLastSavedFile = New System.Windows.Forms.Label()
        Me.LabelLastSavedFile = New System.Windows.Forms.Label()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.ValueGoodOrBad = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ValueLastCategorySelected = New System.Windows.Forms.Label()
        Me.ValueLastDuration = New System.Windows.Forms.Label()
        Me.LabelLastDuration = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PL7 = New System.Windows.Forms.Label()
        Me.PL6 = New System.Windows.Forms.Label()
        Me.PL5 = New System.Windows.Forms.Label()
        Me.PL4 = New System.Windows.Forms.Label()
        Me.PL3 = New System.Windows.Forms.Label()
        Me.PL2 = New System.Windows.Forms.Label()
        Me.PL1 = New System.Windows.Forms.Label()
        Me.ValueOpenVideoLabel = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(81, 35)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(147, 23)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Play Video"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "0:0.000"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem2, Me.VideoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(960, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem, Me.DiscardValuesToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SaveAsToolStripMenuItem.Text = "&Save Values to File"
        '
        'DiscardValuesToolStripMenuItem
        '
        Me.DiscardValuesToolStripMenuItem.Name = "DiscardValuesToolStripMenuItem"
        Me.DiscardValuesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DiscardValuesToolStripMenuItem.Text = "&Discard Values"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem2.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem1.Text = "&About..."
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.VideoToolStripMenuItem.Text = "&Video"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ValueCounter
        '
        Me.ValueCounter.AutoSize = True
        Me.ValueCounter.Location = New System.Drawing.Point(49, 78)
        Me.ValueCounter.Name = "ValueCounter"
        Me.ValueCounter.Size = New System.Drawing.Size(13, 13)
        Me.ValueCounter.TabIndex = 3
        Me.ValueCounter.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ValueLastSavedFile)
        Me.GroupBox1.Controls.Add(Me.LabelLastSavedFile)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 89)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'ValueLastSavedFile
        '
        Me.ValueLastSavedFile.AutoEllipsis = True
        Me.ValueLastSavedFile.AutoSize = True
        Me.ValueLastSavedFile.Location = New System.Drawing.Point(11, 48)
        Me.ValueLastSavedFile.Name = "ValueLastSavedFile"
        Me.ValueLastSavedFile.Size = New System.Drawing.Size(16, 13)
        Me.ValueLastSavedFile.TabIndex = 8
        Me.ValueLastSavedFile.Text = " --"
        '
        'LabelLastSavedFile
        '
        Me.LabelLastSavedFile.AutoSize = True
        Me.LabelLastSavedFile.Location = New System.Drawing.Point(9, 25)
        Me.LabelLastSavedFile.Name = "LabelLastSavedFile"
        Me.LabelLastSavedFile.Size = New System.Drawing.Size(83, 13)
        Me.LabelLastSavedFile.TabIndex = 6
        Me.LabelLastSavedFile.Text = "Last Saved File:"
        '
        'LabelCounter
        '
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Location = New System.Drawing.Point(11, 78)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(38, 13)
        Me.LabelCounter.TabIndex = 7
        Me.LabelCounter.Text = "Count:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.ValueGoodOrBad)
        Me.GroupBox2.Controls.Add(Me.LabelCounter)
        Me.GroupBox2.Controls.Add(Me.ValueCounter)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.ValueLastCategorySelected)
        Me.GroupBox2.Controls.Add(Me.ValueLastDuration)
        Me.GroupBox2.Controls.Add(Me.LabelLastDuration)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 103)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categorize"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(14, 19)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton5.TabIndex = 19
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "None"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'ValueGoodOrBad
        '
        Me.ValueGoodOrBad.AutoSize = True
        Me.ValueGoodOrBad.Location = New System.Drawing.Point(78, 56)
        Me.ValueGoodOrBad.Name = "ValueGoodOrBad"
        Me.ValueGoodOrBad.Size = New System.Drawing.Size(33, 13)
        Me.ValueGoodOrBad.TabIndex = 17
        Me.ValueGoodOrBad.Text = "Good"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(224, 77)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Delete This"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(249, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton4.TabIndex = 15
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Guard"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(198, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton3.TabIndex = 14
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Lift"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(139, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Sniff"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(79, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Lick"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ValueLastCategorySelected
        '
        Me.ValueLastCategorySelected.AutoSize = True
        Me.ValueLastCategorySelected.Location = New System.Drawing.Point(164, 78)
        Me.ValueLastCategorySelected.Name = "ValueLastCategorySelected"
        Me.ValueLastCategorySelected.Size = New System.Drawing.Size(13, 13)
        Me.ValueLastCategorySelected.TabIndex = 11
        Me.ValueLastCategorySelected.Text = "--"
        '
        'ValueLastDuration
        '
        Me.ValueLastDuration.AutoSize = True
        Me.ValueLastDuration.Location = New System.Drawing.Point(88, 78)
        Me.ValueLastDuration.Name = "ValueLastDuration"
        Me.ValueLastDuration.Size = New System.Drawing.Size(43, 13)
        Me.ValueLastDuration.TabIndex = 7
        Me.ValueLastDuration.Text = "0:0.000"
        '
        'LabelLastDuration
        '
        Me.LabelLastDuration.AutoSize = True
        Me.LabelLastDuration.Location = New System.Drawing.Point(13, 56)
        Me.LabelLastDuration.Name = "LabelLastDuration"
        Me.LabelLastDuration.Size = New System.Drawing.Size(60, 13)
        Me.LabelLastDuration.TabIndex = 6
        Me.LabelLastDuration.Text = "Last Value:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(0, 56)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(310, 47)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StartButton)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(310, 64)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "StopWatch"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PL7)
        Me.GroupBox5.Controls.Add(Me.PL6)
        Me.GroupBox5.Controls.Add(Me.PL5)
        Me.GroupBox5.Controls.Add(Me.PL4)
        Me.GroupBox5.Controls.Add(Me.PL3)
        Me.GroupBox5.Controls.Add(Me.PL2)
        Me.GroupBox5.Controls.Add(Me.PL1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(310, 178)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Playlist"
        '
        'PL7
        '
        Me.PL7.AutoSize = True
        Me.PL7.Location = New System.Drawing.Point(6, 158)
        Me.PL7.Name = "PL7"
        Me.PL7.Size = New System.Drawing.Size(26, 13)
        Me.PL7.TabIndex = 6
        Me.PL7.Text = "PL7"
        '
        'PL6
        '
        Me.PL6.AutoSize = True
        Me.PL6.Location = New System.Drawing.Point(6, 137)
        Me.PL6.Name = "PL6"
        Me.PL6.Size = New System.Drawing.Size(26, 13)
        Me.PL6.TabIndex = 5
        Me.PL6.Text = "PL6"
        '
        'PL5
        '
        Me.PL5.AutoSize = True
        Me.PL5.Location = New System.Drawing.Point(6, 115)
        Me.PL5.Name = "PL5"
        Me.PL5.Size = New System.Drawing.Size(26, 13)
        Me.PL5.TabIndex = 4
        Me.PL5.Text = "PL5"
        '
        'PL4
        '
        Me.PL4.AutoSize = True
        Me.PL4.Location = New System.Drawing.Point(6, 93)
        Me.PL4.Name = "PL4"
        Me.PL4.Size = New System.Drawing.Size(26, 13)
        Me.PL4.TabIndex = 3
        Me.PL4.Text = "PL4"
        '
        'PL3
        '
        Me.PL3.AutoSize = True
        Me.PL3.Location = New System.Drawing.Point(6, 71)
        Me.PL3.Name = "PL3"
        Me.PL3.Size = New System.Drawing.Size(26, 13)
        Me.PL3.TabIndex = 2
        Me.PL3.Text = "PL3"
        '
        'PL2
        '
        Me.PL2.AutoSize = True
        Me.PL2.Location = New System.Drawing.Point(6, 49)
        Me.PL2.Name = "PL2"
        Me.PL2.Size = New System.Drawing.Size(26, 13)
        Me.PL2.TabIndex = 1
        Me.PL2.Text = "PL2"
        '
        'PL1
        '
        Me.PL1.AutoSize = True
        Me.PL1.Location = New System.Drawing.Point(6, 26)
        Me.PL1.Name = "PL1"
        Me.PL1.Size = New System.Drawing.Size(26, 13)
        Me.PL1.TabIndex = 0
        Me.PL1.Text = "PL1"
        '
        'ValueOpenVideoLabel
        '
        Me.ValueOpenVideoLabel.AutoSize = True
        Me.ValueOpenVideoLabel.Location = New System.Drawing.Point(592, 50)
        Me.ValueOpenVideoLabel.Name = "ValueOpenVideoLabel"
        Me.ValueOpenVideoLabel.Size = New System.Drawing.Size(183, 13)
        Me.ValueOpenVideoLabel.TabIndex = 13
        Me.ValueOpenVideoLabel.Text = "Open a Video to Start (Video > Open)"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(353, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(595, 500)
        Me.AxWindowsMediaPlayer1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 524)
        Me.Controls.Add(Me.ValueOpenVideoLabel)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Mouse Counter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValueCounter As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelLastSavedFile As System.Windows.Forms.Label
    Friend WithEvents LabelCounter As System.Windows.Forms.Label
    Friend WithEvents ValueLastSavedFile As System.Windows.Forms.Label
    Friend WithEvents DiscardValuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ValueLastDuration As System.Windows.Forms.Label
    Friend WithEvents LabelLastDuration As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ValueLastCategorySelected As System.Windows.Forms.Label
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ValueGoodOrBad As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PL7 As System.Windows.Forms.Label
    Friend WithEvents PL6 As System.Windows.Forms.Label
    Friend WithEvents PL5 As System.Windows.Forms.Label
    Friend WithEvents PL4 As System.Windows.Forms.Label
    Friend WithEvents PL3 As System.Windows.Forms.Label
    Friend WithEvents PL2 As System.Windows.Forms.Label
    Friend WithEvents PL1 As System.Windows.Forms.Label
    Friend WithEvents ValueOpenVideoLabel As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer

End Class
