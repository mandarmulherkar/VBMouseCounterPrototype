Public Class Form1

    Dim startTime As DateTime
    Dim span As TimeSpan
    Dim timeTrack(0 To 255) As TimeSpan

    Dim categoryTrack(0 To 255) As Int16
    Dim sCategoryTrack(0 To 255) As String

    Dim sCategoryVideoTimeStop(0 To 255) As String
    Dim sCategoryVideoTimeStart(0 To 255) As String
    Dim sCurrentPlayingVideo As String '(0 To 255) As String

    Dim counter As Integer
    Dim iteration As Integer
    Dim CheckBoxCheckedFlag As Boolean
    Dim ValuesSavedToFileFlag As Boolean

    Dim saveFileDialog1 As New SaveFileDialog()
    Dim myStream As IO.Stream
    Dim openFileDialog1 As New OpenFileDialog()
    Dim bVideoPlayingFlag As Boolean
    Dim bPlayingVideoFirstTime As Boolean
    Dim bVideoOpened As Boolean

    Private Sub CleanUpVideo()

        If (AxWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsPlaying)) Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()

        End If

    End Sub

    Private Sub WriteToFile()
        Dim j As Integer
        Dim writeToFile As String
        Dim sDefaultFileName As String

        saveFileDialog1.Filter = "Excel (csv) Spreadsheet|*.csv"
        saveFileDialog1.Title = "You have unsaved values, would you like to save them?"
        saveFileDialog1.ShowDialog()
        ValueLastSavedFile.Text = saveFileDialog1.FileName()

        sDefaultFileName = DateTime.Now.Month() _
                   & DateTime.Now.Day() _
                   & DateTime.Now.Year() _
                   & "_" _
                   & DateTime.Now.Hour() _
                   & DateTime.Now.Minute()

        If saveFileDialog1.FileName() <> "" Then

            'My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName(), "Iteration " & iteration & vbCrLf, True)
            ValueLastSavedFile.Text = saveFileDialog1.FileName()
            iteration += 1

            ' Add a more decent file open and close logic    
            While (j < counter)
                writeToFile = timeTrack(j).Seconds.ToString & "." & timeTrack(j).Milliseconds.ToString & "," & sCategoryTrack(j) & vbCrLf
                ValueLastDuration.Text = writeToFile
                My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName(), writeToFile, True)
                j += 1
            End While

            ValuesSavedToFileFlag = True
            CleanUpVideo()

        End If

        If saveFileDialog1.FileName().Equals("") Then
            ValuesSavedToFileFlag = True
            CleanUpVideo()
        End If

        ' Resetting the counter back to zero, sorry for the variable name.    
        counter = 0

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        span = DateTime.Now.Subtract(startTime)
        StopWatch.Text = span.Minutes.ToString & ":" & span.Seconds.ToString & "." & span.Milliseconds
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click

        MouseAction.Text = "None"
        ValueOpenVideoLabel.Text = ""

        If (bVideoOpened = False) Then
            ValueOpenVideoLabel.Text = "Please Open a Video First"

        ElseIf bPlayingVideoFirstTime = True Then

            bPlayingVideoFirstTime = False
            bVideoPlayingFlag = True
            ValueOpenVideoLabel.Text = ""
            StartButton.Text = "Start Timer"
            'Double play crashes the plugin

            StartButton.Enabled = False
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            StartButton.Enabled = True

        ElseIf bVideoPlayingFlag = False Then
            If (AxWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsPlaying)) Then
                StartButton.Text = "Play Video"
            ElseIf (AxWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsPaused) Or AxWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsStopped)) Then
                StartButton.Text = "Start Timer"
            End If

            If (AxWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsPlaying)) Then
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
            ElseIf (AxWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsPaused)) Then
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If

            bVideoPlayingFlag = True
        ElseIf (Timer1.Enabled) Then

            If (AxWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsPlaying)) Then
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
            ElseIf (AxWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsPaused)) Then
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If

            StartButton.Text = "Play Video"
            bVideoPlayingFlag = False

            Timer1.Stop()
            timeTrack(counter) = span
            ValueLastCategorySelected.Text = "None"
            ValueGoodOrBad.Text = "Good"
            ValueLastDuration.Text = timeTrack(counter).Minutes.ToString & ":" & timeTrack(counter).Seconds.ToString & ":" & timeTrack(counter).Milliseconds.ToString
            counter += 1
            ValueCounter.Text = counter
            sCategoryVideoTimeStop(counter) = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            VideoStop.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString

        ElseIf (Timer1.Enabled.Equals(False)) Then

            sCategoryVideoTimeStart(counter) = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            VideoStart.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString

            startTime = DateTime.Now()
            StartButton.Text = "Stop"
            Timer1.Start()
            ValueLastSavedFile.Text = saveFileDialog1.FileName()
            If ValuesSavedToFileFlag.Equals(True) Then
                ValuesSavedToFileFlag = False
            End If
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click


    End Sub

    Public Shadows Sub FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        'Make sure the video stops else an exception will be generated during program shut down
        CleanUpVideo()

        If ValuesSavedToFileFlag.Equals(False) Then
            WriteToFile()
        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
    End Sub

    Private Sub DiscardValuesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscardValuesToolStripMenuItem.Click
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'None
        categoryTrack(counter) = 0
        sCategoryTrack(counter) = "None"
        ValueLastCategorySelected.Text = "None"
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBoxCheckedFlag.Equals(False)) Then
            If CheckBox1.Checked.Equals(True) Then
                If counter > 0 Then
                    counter = counter - 1
                    ValueCounter.Text = counter
                    ValueGoodOrBad.Text = "Deleted"
                    CheckBoxCheckedFlag = True
                    CheckBox1.Checked = False
                ElseIf counter <= 0 Then
                    ValueCounter.Text = "N/A"
                End If
            End If
        End If

        If (CheckBoxCheckedFlag.Equals(True)) Then
            CheckBoxCheckedFlag = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CheckBoxCheckedFlag = False
        ValuesSavedToFileFlag = True
        AxWindowsMediaPlayer1.AllowDrop = True
        bVideoPlayingFlag = False
        bVideoOpened = False

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click


    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        'Flinch
        categoryTrack(counter) = 5
        sCategoryTrack(counter) = "Flinch"
        ValueLastCategorySelected.Text = "Flinch"
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem1.Click
        openFileDialog1.InitialDirectory = "C:\"
        openFileDialog1.Filter = "All files (*.*)|*.*"
        'openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = False

        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Get only the File Name
            sCurrentPlayingVideo = openFileDialog1.FileName()
            AxWindowsMediaPlayer1.URL = sCurrentPlayingVideo
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            ValueOpenVideoLabel.Text = "Video Loaded, Click 'Play Video'"
            bVideoOpened = True
            bPlayingVideoFirstTime = True
        End If
    End Sub

    Private Sub DiscardValuesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DiscardValuesToolStripMenuItem1.Click

        ValuesSavedToFileFlag = True
        ValueLastDuration.Text = "0:0:0.0"
        ValueCounter.Text = "0"
        counter = 0

    End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        If ValuesSavedToFileFlag.Equals(False) Then
            WriteToFile()
        End If

        Me.Close()
    End Sub

    Private Sub SaveAsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem1.Click
        If ValuesSavedToFileFlag.Equals(True) Then
            ValueLastSavedFile.Text = saveFileDialog1.FileName() & ", No new values! "
        End If

        If ValuesSavedToFileFlag.Equals(False) Then
            WriteToFile()
        End If
    End Sub

    Private Sub Lick_Click(sender As System.Object, e As System.EventArgs) Handles Lick.Click
        'Lick
        categoryTrack(counter) = 1
        sCategoryTrack(counter) = "Lick"
        ValueLastCategorySelected.Text = "Lick"

        NumberOfTimes.Text = ""
        MouseAction.Text = "Lick"

    End Sub

    Private Sub Sniff_Click(sender As System.Object, e As System.EventArgs) Handles Sniff.Click
        'Sniff
        categoryTrack(counter) = 2
        sCategoryTrack(counter) = "Sniff"
        ValueLastCategorySelected.Text = "Sniff"

        NumberOfTimes.Text = ""
        MouseAction.Text = "Sniff"

    End Sub

    Private Sub Lift_Click(sender As System.Object, e As System.EventArgs) Handles Lift.Click
        'Lift
        categoryTrack(counter) = 3
        sCategoryTrack(counter) = "Lift"
        ValueLastCategorySelected.Text = "Lift"

        NumberOfTimes.Text = ""
        MouseAction.Text = "Lift"

    End Sub

    Private Sub Guard_Click(sender As System.Object, e As System.EventArgs) Handles Guard.Click
        'Guard
        categoryTrack(counter) = 4
        sCategoryTrack(counter) = "Guard"
        ValueLastCategorySelected.Text = "Guard"

        NumberOfTimes.Text = ""
        MouseAction.Text = "Guard"

    End Sub

    Private Sub Flinches_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Flinches.SelectedIndexChanged
        'Flinch
        categoryTrack(counter) = 5
        sCategoryTrack(counter) = "Flinch"
        ValueLastCategorySelected.Text = "Flinche(s)"

        NumberOfTimes.Text = Flinches.SelectedIndex
        MouseAction.Text = "Flinche(s)"

    End Sub

    Private Sub Wipes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Wipes.SelectedIndexChanged
        'Wipe
        categoryTrack(counter) = 6
        sCategoryTrack(counter) = "Wipe"
        ValueLastCategorySelected.Text = "Wipe(s)"

        NumberOfTimes.Text = Wipes.SelectedIndex
        MouseAction.Text = "Wipe(s)"

    End Sub

    Private Sub Scratch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Scratch.SelectedIndexChanged
        'Scratch
        categoryTrack(counter) = 7
        sCategoryTrack(counter) = "Scratch"
        ValueLastCategorySelected.Text = "Scratch(es)"

        NumberOfTimes.Text = Scratch.SelectedIndex
        MouseAction.Text = "Scratch(es)"

    End Sub
End Class





