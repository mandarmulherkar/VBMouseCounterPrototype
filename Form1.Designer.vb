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
        Me.StopWatch = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscardValuesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.VideoStart = New System.Windows.Forms.Label()
        Me.VideoStop = New System.Windows.Forms.Label()
        Me.ValueLastSavedFile = New System.Windows.Forms.Label()
        Me.LabelLastSavedFile = New System.Windows.Forms.Label()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MouseAction = New System.Windows.Forms.Label()
        Me.NumberOfTimes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Scratch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Wipes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Flinches = New System.Windows.Forms.ComboBox()
        Me.Guard = New System.Windows.Forms.Button()
        Me.Lift = New System.Windows.Forms.Button()
        Me.Sniff = New System.Windows.Forms.Button()
        Me.Lick = New System.Windows.Forms.Button()
        Me.ValueGoodOrBad = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ValueLastCategorySelected = New System.Windows.Forms.Label()
        Me.ValueLastDuration = New System.Windows.Forms.Label()
        Me.LabelLastDuration = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ValueOpenVideoLabel = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DurationText = New System.Windows.Forms.Label()
        Me.NumberOfTimesText = New System.Windows.Forms.Label()
        Me.ActionText = New System.Windows.Forms.Label()
        Me.CounterText = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'StopWatch
        '
        Me.StopWatch.AutoSize = True
        Me.StopWatch.Location = New System.Drawing.Point(134, 16)
        Me.StopWatch.Name = "StopWatch"
        Me.StopWatch.Size = New System.Drawing.Size(43, 13)
        Me.StopWatch.TabIndex = 1
        Me.StopWatch.Text = "0:0.000"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(960, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1, Me.ExitToolStripMenuItem, Me.DiscardValuesToolStripMenuItem1, Me.ExitToolStripMenuItem2})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'DiscardValuesToolStripMenuItem1
        '
        Me.DiscardValuesToolStripMenuItem1.Name = "DiscardValuesToolStripMenuItem1"
        Me.DiscardValuesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DiscardValuesToolStripMenuItem1.Text = "Discard Values"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Save Values"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem2.Text = "Exit"
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
        Me.ValueCounter.Location = New System.Drawing.Point(676, 498)
        Me.ValueCounter.Name = "ValueCounter"
        Me.ValueCounter.Size = New System.Drawing.Size(13, 13)
        Me.ValueCounter.TabIndex = 3
        Me.ValueCounter.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CounterText)
        Me.GroupBox1.Controls.Add(Me.ActionText)
        Me.GroupBox1.Controls.Add(Me.NumberOfTimesText)
        Me.GroupBox1.Controls.Add(Me.DurationText)
        Me.GroupBox1.Controls.Add(Me.VideoStart)
        Me.GroupBox1.Controls.Add(Me.VideoStop)
        Me.GroupBox1.Controls.Add(Me.ValueLastSavedFile)
        Me.GroupBox1.Controls.Add(Me.LabelLastSavedFile)
        Me.GroupBox1.Location = New System.Drawing.Point(628, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'VideoStart
        '
        Me.VideoStart.AutoSize = True
        Me.VideoStart.Location = New System.Drawing.Point(48, 76)
        Me.VideoStart.Name = "VideoStart"
        Me.VideoStart.Size = New System.Drawing.Size(16, 13)
        Me.VideoStart.TabIndex = 10
        Me.VideoStart.Text = "t0"
        '
        'VideoStop
        '
        Me.VideoStop.AutoSize = True
        Me.VideoStop.Location = New System.Drawing.Point(87, 76)
        Me.VideoStop.Name = "VideoStop"
        Me.VideoStop.Size = New System.Drawing.Size(16, 13)
        Me.VideoStop.TabIndex = 9
        Me.VideoStop.Text = "t1"
        '
        'ValueLastSavedFile
        '
        Me.ValueLastSavedFile.AutoSize = True
        Me.ValueLastSavedFile.Location = New System.Drawing.Point(12, 47)
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
        Me.LabelCounter.Location = New System.Drawing.Point(638, 498)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(38, 13)
        Me.LabelCounter.TabIndex = 7
        Me.LabelCounter.Text = "Count:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MouseAction)
        Me.GroupBox2.Controls.Add(Me.NumberOfTimes)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.Scratch)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Wipes)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Flinches)
        Me.GroupBox2.Controls.Add(Me.Guard)
        Me.GroupBox2.Controls.Add(Me.Lift)
        Me.GroupBox2.Controls.Add(Me.Sniff)
        Me.GroupBox2.Controls.Add(Me.Lick)
        Me.GroupBox2.Location = New System.Drawing.Point(626, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 268)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categorize"
        '
        'MouseAction
        '
        Me.MouseAction.AutoSize = True
        Me.MouseAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MouseAction.Location = New System.Drawing.Point(123, 25)
        Me.MouseAction.Name = "MouseAction"
        Me.MouseAction.Size = New System.Drawing.Size(45, 16)
        Me.MouseAction.TabIndex = 39
        Me.MouseAction.Text = "None"
        '
        'NumberOfTimes
        '
        Me.NumberOfTimes.AutoSize = True
        Me.NumberOfTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfTimes.Location = New System.Drawing.Point(101, 24)
        Me.NumberOfTimes.Name = "NumberOfTimes"
        Me.NumberOfTimes.Size = New System.Drawing.Size(0, 16)
        Me.NumberOfTimes.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Scratch(es)"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MouseCounter.My.Resources.Resources.scratch
        Me.PictureBox3.Location = New System.Drawing.Point(163, 171)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 30)
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'Scratch
        '
        Me.Scratch.FormattingEnabled = True
        Me.Scratch.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Scratch.Location = New System.Drawing.Point(205, 180)
        Me.Scratch.Name = "Scratch"
        Me.Scratch.Size = New System.Drawing.Size(30, 21)
        Me.Scratch.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Wipe(s)"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MouseCounter.My.Resources.Resources.wipe
        Me.PictureBox2.Location = New System.Drawing.Point(163, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 30)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Wipes
        '
        Me.Wipes.FormattingEnabled = True
        Me.Wipes.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Wipes.Location = New System.Drawing.Point(205, 130)
        Me.Wipes.Name = "Wipes"
        Me.Wipes.Size = New System.Drawing.Size(30, 21)
        Me.Wipes.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Flinche(s)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MouseCounter.My.Resources.Resources.flinch
        Me.PictureBox1.Location = New System.Drawing.Point(163, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 44)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Flinches
        '
        Me.Flinches.FormattingEnabled = True
        Me.Flinches.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Flinches.Location = New System.Drawing.Point(205, 80)
        Me.Flinches.Name = "Flinches"
        Me.Flinches.Size = New System.Drawing.Size(30, 21)
        Me.Flinches.TabIndex = 25
        '
        'Guard
        '
        Me.Guard.BackgroundImage = Global.MouseCounter.My.Resources.Resources.guard
        Me.Guard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guard.Location = New System.Drawing.Point(26, 207)
        Me.Guard.Name = "Guard"
        Me.Guard.Size = New System.Drawing.Size(112, 44)
        Me.Guard.TabIndex = 23
        Me.Guard.Text = "Guard"
        Me.Guard.UseVisualStyleBackColor = True
        '
        'Lift
        '
        Me.Lift.BackgroundImage = Global.MouseCounter.My.Resources.Resources.lift
        Me.Lift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Lift.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lift.Location = New System.Drawing.Point(26, 157)
        Me.Lift.Name = "Lift"
        Me.Lift.Size = New System.Drawing.Size(112, 44)
        Me.Lift.TabIndex = 22
        Me.Lift.Text = "Lift"
        Me.Lift.UseVisualStyleBackColor = True
        '
        'Sniff
        '
        Me.Sniff.BackgroundImage = Global.MouseCounter.My.Resources.Resources.rose
        Me.Sniff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Sniff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sniff.Location = New System.Drawing.Point(26, 107)
        Me.Sniff.Name = "Sniff"
        Me.Sniff.Size = New System.Drawing.Size(112, 44)
        Me.Sniff.TabIndex = 21
        Me.Sniff.Text = "Sniff"
        Me.Sniff.UseVisualStyleBackColor = True
        '
        'Lick
        '
        Me.Lick.BackgroundImage = Global.MouseCounter.My.Resources.Resources.icecream
        Me.Lick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Lick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lick.Location = New System.Drawing.Point(26, 57)
        Me.Lick.Name = "Lick"
        Me.Lick.Size = New System.Drawing.Size(112, 44)
        Me.Lick.TabIndex = 20
        Me.Lick.Text = "Lick"
        Me.Lick.UseVisualStyleBackColor = True
        '
        'ValueGoodOrBad
        '
        Me.ValueGoodOrBad.AutoSize = True
        Me.ValueGoodOrBad.Location = New System.Drawing.Point(705, 476)
        Me.ValueGoodOrBad.Name = "ValueGoodOrBad"
        Me.ValueGoodOrBad.Size = New System.Drawing.Size(33, 13)
        Me.ValueGoodOrBad.TabIndex = 17
        Me.ValueGoodOrBad.Text = "Good"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(198, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Delete This"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ValueLastCategorySelected
        '
        Me.ValueLastCategorySelected.AutoSize = True
        Me.ValueLastCategorySelected.Location = New System.Drawing.Point(791, 498)
        Me.ValueLastCategorySelected.Name = "ValueLastCategorySelected"
        Me.ValueLastCategorySelected.Size = New System.Drawing.Size(13, 13)
        Me.ValueLastCategorySelected.TabIndex = 11
        Me.ValueLastCategorySelected.Text = "--"
        '
        'ValueLastDuration
        '
        Me.ValueLastDuration.AutoSize = True
        Me.ValueLastDuration.Location = New System.Drawing.Point(715, 498)
        Me.ValueLastDuration.Name = "ValueLastDuration"
        Me.ValueLastDuration.Size = New System.Drawing.Size(43, 13)
        Me.ValueLastDuration.TabIndex = 7
        Me.ValueLastDuration.Text = "0:0.000"
        '
        'LabelLastDuration
        '
        Me.LabelLastDuration.AutoSize = True
        Me.LabelLastDuration.Location = New System.Drawing.Point(640, 476)
        Me.LabelLastDuration.Name = "LabelLastDuration"
        Me.LabelLastDuration.Size = New System.Drawing.Size(60, 13)
        Me.LabelLastDuration.TabIndex = 6
        Me.LabelLastDuration.Text = "Last Value:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(627, 476)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(321, 47)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StartButton)
        Me.GroupBox3.Controls.Add(Me.StopWatch)
        Me.GroupBox3.Location = New System.Drawing.Point(626, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(322, 64)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "StopWatch"
        '
        'ValueOpenVideoLabel
        '
        Me.ValueOpenVideoLabel.AutoSize = True
        Me.ValueOpenVideoLabel.Location = New System.Drawing.Point(209, 226)
        Me.ValueOpenVideoLabel.Name = "ValueOpenVideoLabel"
        Me.ValueOpenVideoLabel.Size = New System.Drawing.Size(172, 13)
        Me.ValueOpenVideoLabel.TabIndex = 13
        Me.ValueOpenVideoLabel.Text = "Open a Video to Start (File > Open)"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 24)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(595, 500)
        Me.AxWindowsMediaPlayer1.TabIndex = 14
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(12, 493)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(607, 33)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'DurationText
        '
        Me.DurationText.AutoSize = True
        Me.DurationText.Location = New System.Drawing.Point(124, 76)
        Me.DurationText.Name = "DurationText"
        Me.DurationText.Size = New System.Drawing.Size(49, 13)
        Me.DurationText.TabIndex = 2
        Me.DurationText.Text = "total time"
        '
        'NumberOfTimesText
        '
        Me.NumberOfTimesText.AutoSize = True
        Me.NumberOfTimesText.Location = New System.Drawing.Point(200, 76)
        Me.NumberOfTimesText.Name = "NumberOfTimesText"
        Me.NumberOfTimesText.Size = New System.Drawing.Size(14, 13)
        Me.NumberOfTimesText.TabIndex = 11
        Me.NumberOfTimesText.Text = "#"
        '
        'ActionText
        '
        Me.ActionText.AutoSize = True
        Me.ActionText.Location = New System.Drawing.Point(220, 76)
        Me.ActionText.Name = "ActionText"
        Me.ActionText.Size = New System.Drawing.Size(36, 13)
        Me.ActionText.TabIndex = 12
        Me.ActionText.Text = "action"
        '
        'CounterText
        '
        Me.CounterText.AutoSize = True
        Me.CounterText.Location = New System.Drawing.Point(12, 76)
        Me.CounterText.Name = "CounterText"
        Me.CounterText.Size = New System.Drawing.Size(13, 13)
        Me.CounterText.TabIndex = 13
        Me.CounterText.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 535)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.ValueOpenVideoLabel)
        Me.Controls.Add(Me.ValueGoodOrBad)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ValueCounter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LabelLastDuration)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ValueLastDuration)
        Me.Controls.Add(Me.ValueLastCategorySelected)
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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StopWatch As System.Windows.Forms.Label
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
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ValueGoodOrBad As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValueOpenVideoLabel As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Guard As System.Windows.Forms.Button
    Friend WithEvents Lift As System.Windows.Forms.Button
    Friend WithEvents Sniff As System.Windows.Forms.Button
    Friend WithEvents Lick As System.Windows.Forms.Button
    Friend WithEvents Flinches As System.Windows.Forms.ComboBox
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiscardValuesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Wipes As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Scratch As System.Windows.Forms.ComboBox
    Friend WithEvents MouseAction As System.Windows.Forms.Label
    Friend WithEvents NumberOfTimes As System.Windows.Forms.Label
    Friend WithEvents VideoStop As System.Windows.Forms.Label
    Friend WithEvents VideoStart As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ActionText As System.Windows.Forms.Label
    Friend WithEvents NumberOfTimesText As System.Windows.Forms.Label
    Friend WithEvents DurationText As System.Windows.Forms.Label
    Friend WithEvents CounterText As System.Windows.Forms.Label

End Class
