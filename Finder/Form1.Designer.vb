<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1_SearchFolder1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1_SearchFolder2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1_SearchFolder3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1_SearchKeyword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1_TargetIsFolder = New System.Windows.Forms.CheckBox()
        Me.CheckBox1_TargetIsExp = New System.Windows.Forms.CheckBox()
        Me.TextBox1_Exp = New System.Windows.Forms.TextBox()
        Me.CheckBox1_TargetIsGraphic = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1_ActionOpenFolder = New System.Windows.Forms.CheckBox()
        Me.CheckBox1_FirstNameFilePlay = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1_Search = New System.Windows.Forms.Button()
        Me.Button2_Quit = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1_SearchDir1 = New System.Windows.Forms.Button()
        Me.Button1_SearchDir2 = New System.Windows.Forms.Button()
        Me.Button1_SearchDir3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1_SelectedData = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1_Copy = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1_Go = New System.Windows.Forms.Button()
        Me.Button1_FolderRename = New System.Windows.Forms.Button()
        Me.TextBox1_Prefix = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'TextBox1_SearchFolder1
        '
        Me.TextBox1_SearchFolder1.Location = New System.Drawing.Point(32, 24)
        Me.TextBox1_SearchFolder1.Name = "TextBox1_SearchFolder1"
        Me.TextBox1_SearchFolder1.Size = New System.Drawing.Size(235, 19)
        Me.TextBox1_SearchFolder1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "検索するフォルダ①"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "検索するフォルダ②"
        '
        'TextBox1_SearchFolder2
        '
        Me.TextBox1_SearchFolder2.Location = New System.Drawing.Point(32, 63)
        Me.TextBox1_SearchFolder2.Name = "TextBox1_SearchFolder2"
        Me.TextBox1_SearchFolder2.Size = New System.Drawing.Size(234, 19)
        Me.TextBox1_SearchFolder2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "検索するフォルダ③"
        '
        'TextBox1_SearchFolder3
        '
        Me.TextBox1_SearchFolder3.Location = New System.Drawing.Point(35, 105)
        Me.TextBox1_SearchFolder3.Name = "TextBox1_SearchFolder3"
        Me.TextBox1_SearchFolder3.Size = New System.Drawing.Size(231, 19)
        Me.TextBox1_SearchFolder3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "検索キーワード"
        '
        'TextBox1_SearchKeyword
        '
        Me.TextBox1_SearchKeyword.Location = New System.Drawing.Point(36, 157)
        Me.TextBox1_SearchKeyword.Name = "TextBox1_SearchKeyword"
        Me.TextBox1_SearchKeyword.Size = New System.Drawing.Size(229, 19)
        Me.TextBox1_SearchKeyword.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "検索対象"
        '
        'CheckBox1_TargetIsFolder
        '
        Me.CheckBox1_TargetIsFolder.AutoSize = True
        Me.CheckBox1_TargetIsFolder.Location = New System.Drawing.Point(40, 206)
        Me.CheckBox1_TargetIsFolder.Name = "CheckBox1_TargetIsFolder"
        Me.CheckBox1_TargetIsFolder.Size = New System.Drawing.Size(59, 16)
        Me.CheckBox1_TargetIsFolder.TabIndex = 9
        Me.CheckBox1_TargetIsFolder.Text = "フォルダ"
        Me.CheckBox1_TargetIsFolder.UseVisualStyleBackColor = True
        '
        'CheckBox1_TargetIsExp
        '
        Me.CheckBox1_TargetIsExp.AutoSize = True
        Me.CheckBox1_TargetIsExp.Location = New System.Drawing.Point(35, 233)
        Me.CheckBox1_TargetIsExp.Name = "CheckBox1_TargetIsExp"
        Me.CheckBox1_TargetIsExp.Size = New System.Drawing.Size(128, 16)
        Me.CheckBox1_TargetIsExp.TabIndex = 10
        Me.CheckBox1_TargetIsExp.Text = "拡張子指定のファイル"
        Me.CheckBox1_TargetIsExp.UseVisualStyleBackColor = True
        '
        'TextBox1_Exp
        '
        Me.TextBox1_Exp.Location = New System.Drawing.Point(177, 230)
        Me.TextBox1_Exp.Name = "TextBox1_Exp"
        Me.TextBox1_Exp.Size = New System.Drawing.Size(195, 19)
        Me.TextBox1_Exp.TabIndex = 11
        '
        'CheckBox1_TargetIsGraphic
        '
        Me.CheckBox1_TargetIsGraphic.AutoSize = True
        Me.CheckBox1_TargetIsGraphic.Location = New System.Drawing.Point(37, 261)
        Me.CheckBox1_TargetIsGraphic.Name = "CheckBox1_TargetIsGraphic"
        Me.CheckBox1_TargetIsGraphic.Size = New System.Drawing.Size(149, 16)
        Me.CheckBox1_TargetIsGraphic.TabIndex = 12
        Me.CheckBox1_TargetIsGraphic.Text = "画像(JPG,GIF,PNG,BMP)"
        Me.CheckBox1_TargetIsGraphic.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "動作"
        '
        'CheckBox1_ActionOpenFolder
        '
        Me.CheckBox1_ActionOpenFolder.AutoSize = True
        Me.CheckBox1_ActionOpenFolder.Location = New System.Drawing.Point(34, 308)
        Me.CheckBox1_ActionOpenFolder.Name = "CheckBox1_ActionOpenFolder"
        Me.CheckBox1_ActionOpenFolder.Size = New System.Drawing.Size(86, 16)
        Me.CheckBox1_ActionOpenFolder.TabIndex = 14
        Me.CheckBox1_ActionOpenFolder.Text = "フォルダを開く"
        Me.CheckBox1_ActionOpenFolder.UseVisualStyleBackColor = True
        '
        'CheckBox1_FirstNameFilePlay
        '
        Me.CheckBox1_FirstNameFilePlay.AutoSize = True
        Me.CheckBox1_FirstNameFilePlay.Location = New System.Drawing.Point(33, 332)
        Me.CheckBox1_FirstNameFilePlay.Name = "CheckBox1_FirstNameFilePlay"
        Me.CheckBox1_FirstNameFilePlay.Size = New System.Drawing.Size(143, 16)
        Me.CheckBox1_FirstNameFilePlay.TabIndex = 15
        Me.CheckBox1_FirstNameFilePlay.Text = "一番若いファイル名を開く"
        Me.CheckBox1_FirstNameFilePlay.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "拡張子"
        '
        'Button1_Search
        '
        Me.Button1_Search.Location = New System.Drawing.Point(31, 371)
        Me.Button1_Search.Name = "Button1_Search"
        Me.Button1_Search.Size = New System.Drawing.Size(205, 64)
        Me.Button1_Search.TabIndex = 17
        Me.Button1_Search.Text = "Search"
        Me.Button1_Search.UseVisualStyleBackColor = True
        '
        'Button2_Quit
        '
        Me.Button2_Quit.Location = New System.Drawing.Point(242, 372)
        Me.Button2_Quit.Name = "Button2_Quit"
        Me.Button2_Quit.Size = New System.Drawing.Size(66, 62)
        Me.Button2_Quit.TabIndex = 18
        Me.Button2_Quit.Text = "Quit"
        Me.Button2_Quit.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(391, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(663, 364)
        Me.ListBox1.TabIndex = 19
        '
        'Button1_SearchDir1
        '
        Me.Button1_SearchDir1.Location = New System.Drawing.Point(273, 24)
        Me.Button1_SearchDir1.Name = "Button1_SearchDir1"
        Me.Button1_SearchDir1.Size = New System.Drawing.Size(25, 23)
        Me.Button1_SearchDir1.TabIndex = 20
        Me.Button1_SearchDir1.Text = "..."
        Me.Button1_SearchDir1.UseVisualStyleBackColor = True
        '
        'Button1_SearchDir2
        '
        Me.Button1_SearchDir2.Location = New System.Drawing.Point(272, 61)
        Me.Button1_SearchDir2.Name = "Button1_SearchDir2"
        Me.Button1_SearchDir2.Size = New System.Drawing.Size(25, 26)
        Me.Button1_SearchDir2.TabIndex = 21
        Me.Button1_SearchDir2.Text = "..."
        Me.Button1_SearchDir2.UseVisualStyleBackColor = True
        '
        'Button1_SearchDir3
        '
        Me.Button1_SearchDir3.Location = New System.Drawing.Point(271, 103)
        Me.Button1_SearchDir3.Name = "Button1_SearchDir3"
        Me.Button1_SearchDir3.Size = New System.Drawing.Size(26, 20)
        Me.Button1_SearchDir3.TabIndex = 22
        Me.Button1_SearchDir3.Text = "..."
        Me.Button1_SearchDir3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "(動作で開くファイルの指定も兼ねています）"
        '
        'TextBox1_SelectedData
        '
        Me.TextBox1_SelectedData.Location = New System.Drawing.Point(455, 426)
        Me.TextBox1_SelectedData.Name = "TextBox1_SelectedData"
        Me.TextBox1_SelectedData.Size = New System.Drawing.Size(599, 19)
        Me.TextBox1_SelectedData.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(459, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 12)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "選択したファイルorフォルダ名"
        '
        'Button1_Copy
        '
        Me.Button1_Copy.Location = New System.Drawing.Point(603, 404)
        Me.Button1_Copy.Name = "Button1_Copy"
        Me.Button1_Copy.Size = New System.Drawing.Size(69, 21)
        Me.Button1_Copy.TabIndex = 26
        Me.Button1_Copy.Text = "Copy"
        Me.Button1_Copy.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(393, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 12)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "クリックで選択、ダブルクリックで動作"
        '
        'Button1_Go
        '
        Me.Button1_Go.Enabled = False
        Me.Button1_Go.Location = New System.Drawing.Point(391, 384)
        Me.Button1_Go.Name = "Button1_Go"
        Me.Button1_Go.Size = New System.Drawing.Size(58, 62)
        Me.Button1_Go.TabIndex = 28
        Me.Button1_Go.Text = "動作"
        Me.Button1_Go.UseVisualStyleBackColor = True
        '
        'Button1_FolderRename
        '
        Me.Button1_FolderRename.Location = New System.Drawing.Point(879, 384)
        Me.Button1_FolderRename.Name = "Button1_FolderRename"
        Me.Button1_FolderRename.Size = New System.Drawing.Size(175, 22)
        Me.Button1_FolderRename.TabIndex = 29
        Me.Button1_FolderRename.Text = "REN"
        Me.Button1_FolderRename.UseVisualStyleBackColor = True
        '
        'TextBox1_Prefix
        '
        Me.TextBox1_Prefix.Location = New System.Drawing.Point(967, 405)
        Me.TextBox1_Prefix.Name = "TextBox1_Prefix"
        Me.TextBox1_Prefix.Size = New System.Drawing.Size(87, 19)
        Me.TextBox1_Prefix.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(877, 409)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 12)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "接頭(フォルダ名)"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(282, 157)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(89, 20)
        Me.ComboBox1.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox1_Prefix)
        Me.Controls.Add(Me.Button1_FolderRename)
        Me.Controls.Add(Me.Button1_Go)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1_Copy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1_SelectedData)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1_SearchDir3)
        Me.Controls.Add(Me.Button1_SearchDir2)
        Me.Controls.Add(Me.Button1_SearchDir1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2_Quit)
        Me.Controls.Add(Me.Button1_Search)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox1_FirstNameFilePlay)
        Me.Controls.Add(Me.CheckBox1_ActionOpenFolder)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox1_TargetIsGraphic)
        Me.Controls.Add(Me.TextBox1_Exp)
        Me.Controls.Add(Me.CheckBox1_TargetIsExp)
        Me.Controls.Add(Me.CheckBox1_TargetIsFolder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1_SearchKeyword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1_SearchFolder3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1_SearchFolder2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1_SearchFolder1)
        Me.Name = "Form1"
        Me.Text = "Finder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1_SearchFolder1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1_SearchFolder2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1_SearchFolder3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1_SearchKeyword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1_TargetIsFolder As CheckBox
    Friend WithEvents CheckBox1_TargetIsExp As CheckBox
    Friend WithEvents TextBox1_Exp As TextBox
    Friend WithEvents CheckBox1_TargetIsGraphic As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1_ActionOpenFolder As CheckBox
    Friend WithEvents CheckBox1_FirstNameFilePlay As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1_Search As Button
    Friend WithEvents Button2_Quit As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1_SearchDir1 As Button
    Friend WithEvents Button1_SearchDir2 As Button
    Friend WithEvents Button1_SearchDir3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1_SelectedData As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1_Copy As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1_Go As Button
    Friend WithEvents Button1_FolderRename As Button
    Friend WithEvents TextBox1_Prefix As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
