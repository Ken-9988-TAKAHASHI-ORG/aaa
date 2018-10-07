Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'TextBox1_SearchFolder1.Text = "kk"
        'My.Settings.Reload()
        TextBox1_SearchFolder1.Text = My.Settings.SearchFolder1
        TextBox1_SearchFolder2.Text = My.Settings.SearchFolder2
        TextBox1_SearchFolder3.Text = My.Settings.SearchFolder3
        TextBox1_SearchKeyword.Text = My.Settings.Keyword
        TextBox1_Exp.Text = My.Settings.SearchExp
        CheckBox1_TargetIsFolder.Checked = My.Settings.TargetIsFolder
        CheckBox1_TargetIsExp.Checked = My.Settings.TargetIsExp
        CheckBox1_TargetIsGraphic.Checked = My.Settings.TargetIsGraphic
        CheckBox1_ActionOpenFolder.Checked = My.Settings.ActionOpenFolder
        CheckBox1_FirstNameFilePlay.Checked = My.Settings.ActionOpenFirstFile
        TextBox1_Prefix.Text = My.Settings.FolderPreFix
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.SearchFolder1 = TextBox1_SearchFolder1.Text
        My.Settings.SearchFolder2 = TextBox1_SearchFolder2.Text
        My.Settings.SearchFolder3 = TextBox1_SearchFolder3.Text
        My.Settings.SearchExp = TextBox1_Exp.Text
        My.Settings.Keyword = TextBox1_SearchKeyword.Text
        My.Settings.TargetIsFolder = CheckBox1_TargetIsFolder.Checked
        My.Settings.TargetIsExp = CheckBox1_TargetIsExp.Checked
        My.Settings.TargetIsGraphic = CheckBox1_TargetIsGraphic.Checked
        My.Settings.ActionOpenFolder = CheckBox1_ActionOpenFolder.Checked
        My.Settings.ActionOpenFirstFile = CheckBox1_FirstNameFilePlay.Checked
        My.Settings.FolderPreFix = TextBox1_Prefix.Text
        My.Settings.Save()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated



    End Sub

    Private Sub Button2_Quit_Click(sender As Object, e As EventArgs) Handles Button2_Quit.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Search_Click(sender As Object, e As EventArgs) Handles Button1_Search.Click
        Cursor.Current = Cursors.WaitCursor
        ListBox1.Items.Clear()
        If getDirectories(TextBox1_SearchFolder1.Text, TextBox1_SearchKeyword.Text) = False Then
            TextBox1_SearchFolder1.BackColor = Color.Red
        End If
        If getDirectories(TextBox1_SearchFolder2.Text, TextBox1_SearchKeyword.Text) = False Then
            TextBox1_SearchFolder2.BackColor = Color.Red
        End If
        If getDirectories(TextBox1_SearchFolder3.Text, TextBox1_SearchKeyword.Text) = False Then
            TextBox1_SearchFolder3.BackColor = Color.Red
        End If
        If ListBox1.Items.Count > 0 Then
            ListBox1.Enabled = True
            Button1_Go.Enabled = True
        Else
            ListBox1.Enabled = False
            Button1_Go.Enabled = False
        End If
        Cursor.Current = Cursors.Default
    End Sub
    ''' <summary>
    ''' 検索エンジン
    ''' </summary>
    ''' <param name="basefolder"></param>
    ''' <param name="keyword"></param>
    ''' <returns></returns>
    Private Function getDirectories(basefolder As String, keyword As String) As Boolean
        getDirectories = True
        If System.IO.Directory.Exists(basefolder) Then
        Else
            getDirectories = False
            Exit Function
        End If
        If CheckBox1_TargetIsFolder.Checked Then
            Dim subFolders As String() = System.IO.Directory.GetDirectories(basefolder, "*", System.IO.SearchOption.AllDirectories)
            For Each subfolder As String In subFolders
                If subfolder.Contains(keyword) Then
                    ListBox1.Items.Add(subfolder)
                End If
            Next
        Else
            Dim Expp As String '拡張子
            Dim GraphisExpp As String = "JPG GIF BMP PNG JPEG"
            Dim files As String() = System.IO.Directory.GetFiles(basefolder, "*", System.IO.SearchOption.AllDirectories)
            For Each file As String In files
                If file.Contains(keyword) Then
                    Expp = System.IO.Path.GetExtension(file).ToUpper
                    Expp = Expp.Substring(1)
                    If CheckBox1_TargetIsExp.Checked Then
                        If TextBox1_Exp.Text.ToUpper.Contains(Expp) Then
                            ListBox1.Items.Add(file)
                        End If
                    ElseIf CheckBox1_TargetIsGraphic.Checked Then
                        If GraphisExpp.Contains(Expp) Then
                            ListBox1.Items.Add(file)
                        End If
                    Else
                        ListBox1.Items.Add(file)
                    End If
                End If
            Next
        End If

    End Function
    ''' <summary>
    ''' ファイルを開く
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <returns></returns>
    Private Function getVerbAndOpen(filename As String) As Boolean
        getVerbAndOpen = True
        Dim target As String
        target = System.IO.Path.GetFileName(filename)
        Dim psi As New System.Diagnostics.ProcessStartInfo(target)
        Dim s As String = "open"
        For Each sx As String In psi.Verbs
            s = sx
            Exit For
        Next
        '開くファイルを指定する
        psi.FileName = filename
        '開くときに使用する動詞を"print"にする
        psi.Verb = s
        'ファイルを開く
        System.Diagnostics.Process.Start(psi)
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim x As String
        x = ListBox1.SelectedItem
        TextBox1_SelectedData.Text = x
    End Sub


    Private Sub CheckBox1_TargetIsFolder_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1_TargetIsFolder.CheckedChanged
        If CheckBox1_TargetIsFolder.Checked Then
            CheckBox1_TargetIsExp.Enabled = False
            TextBox1_Exp.Enabled = False
        Else
            CheckBox1_TargetIsExp.Enabled = True
            TextBox1_Exp.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_TargetIsExp_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1_TargetIsExp.CheckedChanged
        Dim bValue As Boolean = False
        If CheckBox1_TargetIsExp.Checked Then
            bValue = False
        Else
            bValue = True
        End If
        CheckBox1_TargetIsFolder.Enabled = bValue
    End Sub

    Private Sub Button1_Copy_Click(sender As Object, e As EventArgs) Handles Button1_Copy.Click
        Clipboard.SetText(TextBox1_SelectedData.Text)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        GoPro()
    End Sub

    Private Sub Button1_Go_Click(sender As Object, e As EventArgs) Handles Button1_Go.Click
        GoPro()
    End Sub

    Private Sub GoPro()
        Dim x As String
        x = ListBox1.SelectedItem
        TextBox1_SelectedData.Text = x
        If CheckBox1_ActionOpenFolder.Checked Then
            Dim comline As String
            comline = String.Format("/e,""{0}""", x)
            If My.Computer.FileSystem.FileExists(x) Then
                comline = String.Format("/e,/select,""{0}""", x)
            End If
            Debug.WriteLine(comline)
            System.Diagnostics.Process.Start("explorer.exe", comline)
        ElseIf CheckBox1_FirstNameFilePlay.Checked Then
            Dim hoge As String
            If My.Computer.FileSystem.DirectoryExists(x) Then
                hoge = x
            Else
                hoge = System.IO.Path.GetDirectoryName(x)
            End If

            Dim files As String() = System.IO.Directory.GetFiles(hoge, "*", System.IO.SearchOption.AllDirectories)
            Array.Sort(files)
            Dim bIsFirst As Boolean = True
            Dim Expp As String
            For Each file As String In files
                If CheckBox1_TargetIsGraphic.Checked Then
                    Expp = System.IO.Path.GetExtension(file).ToUpper
                    If System.Text.RegularExpressions.Regex.IsMatch(Expp, "JPG|PNG|GIF|BMP", System.Text.RegularExpressions.RegexOptions.ECMAScript) Then
                    Else
                        Continue For
                    End If
                End If
                getVerbAndOpen(file)
                Exit For
            Next
        Else

        End If
    End Sub

    Private Sub Button1_FolderRename_Click(sender As Object, e As EventArgs) Handles Button1_FolderRename.Click
        Dim x As String
        x = ListBox1.SelectedItem
        Dim ix As Integer
        ix = ListBox1.SelectedIndex
        Dim xPath As String
        If My.Computer.FileSystem.DirectoryExists(x) Then
            xPath = x
        Else
            xPath = System.IO.Path.GetDirectoryName(x)
        End If
        Dim TargetPath As String
        Dim NewPath As String
        Dim basePath As String
        TargetPath = System.IO.Path.GetFileName(xPath)
        basePath = System.IO.Path.GetDirectoryName(xPath)
        NewPath = TextBox1_Prefix.Text + TargetPath
        Dim FromPath As String
        Dim ToPath As String
        FromPath = basePath + "\" + TargetPath
        ToPath = basePath + "\" + NewPath
        If vbYes <> MsgBox("フォルダ名の変更をしますか？" & vbCrLf & FromPath & vbCrLf & "↓" & vbCrLf & ToPath, vbYesNoCancel) Then
            Exit Sub
        End If
        Try
            System.IO.Directory.Move(FromPath, ToPath)
            ListBox1.Items(ix) = ToPath
            ListBox1.Update()
            '            ListBox1.SelectedValue = ToPath
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_SearchDir1_Click(sender As Object, e As EventArgs) Handles Button1_SearchDir1.Click
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = TextBox1_SearchFolder1.Text
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            TextBox1_SearchFolder1.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button1_SearchDir2_Click(sender As Object, e As EventArgs) Handles Button1_SearchDir2.Click
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = TextBox1_SearchFolder2.Text
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            TextBox1_SearchFolder2.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button1_SearchDir3_Click(sender As Object, e As EventArgs) Handles Button1_SearchDir3.Click
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = TextBox1_SearchFolder3.Text
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            TextBox1_SearchFolder3.Text = fbd.SelectedPath
        End If
    End Sub
End Class
