Public Class FormMain

    ''' <summary>
    ''' フォルダ選択
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonSelectListFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectListFolder.Click
        Try
            Dim Path As String = TextBoxListFolder.Text
            Dim Dialog As New FolderBrowserDialog
            Dialog.Description = "フォルダを指定してください"
            Dialog.RootFolder = Environment.SpecialFolder.Desktop
            If System.IO.Directory.Exists(Path) Then
                Dialog.SelectedPath = Path
            End If
            If Dialog.ShowDialog(Me) = DialogResult.OK Then
                TextBoxListFolder.Text = Dialog.SelectedPath
                SaveLastFolder()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' フォルダ選択
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonSelectSourceFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectSourceFolder.Click
        Try
            Dim Path As String = TextBoxSourceFolder.Text
            Dim Dialog As New FolderBrowserDialog
            Dialog.Description = "フォルダを指定してください"
            Dialog.RootFolder = Environment.SpecialFolder.Desktop
            If System.IO.Directory.Exists(Path) Then
                Dialog.SelectedPath = Path
            End If
            If Dialog.ShowDialog(Me) = DialogResult.OK Then
                TextBoxSourceFolder.Text = Dialog.SelectedPath
                SaveLastFolder()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' フォルダ選択
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonSelectTargetFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectTargetFolder.Click
        Try
            Dim Path As String = TextBoxTargetFolder.Text
            Dim Dialog As New FolderBrowserDialog
            Dialog.Description = "フォルダを指定してください"
            Dialog.RootFolder = Environment.SpecialFolder.Desktop
            If System.IO.Directory.Exists(Path) Then
                Dialog.SelectedPath = Path
            End If
            If Dialog.ShowDialog(Me) = DialogResult.OK Then
                TextBoxTargetFolder.Text = Dialog.SelectedPath
                SaveLastFolder()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' ファイルリスト生成
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonListupListFolder_Click(sender As Object, e As EventArgs) Handles ButtonListupListFolder.Click
        Try
            Dim Path As String = TextBoxListFolder.Text
            If System.IO.Directory.Exists(Path) = False Then
                Throw New Exception("リスト生成元フォルダがありません")
            End If
            '取込
            DataGridViewFileList.Rows.Clear()
            Dim Count As Integer = 1
            Dim DirectoryInfo As New System.IO.DirectoryInfo(Path)
            For Each File As System.IO.FileInfo In DirectoryInfo.GetFiles("*", System.IO.SearchOption.TopDirectoryOnly)
                Dim FileNameWithoutExtension As String = File.Name.Substring(0, File.Name.Length - File.Extension.Length)
                Dim NewRow As Integer = DataGridViewFileList.Rows.Add()
                DataGridViewFileList.Rows(NewRow).Cells("ColumnNum").Value = Count
                DataGridViewFileList.Rows(NewRow).Cells("ColumnFileName").Value = FileNameWithoutExtension
                DataGridViewFileList.Rows(NewRow).Cells("ColumnListFolderPath").Value = File.FullName
                Count = Count + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' ファイル移動元検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonListupSourceFolder_Click(sender As Object, e As EventArgs) Handles ButtonListupSourceFolder.Click
        Try
            Dim Path As String = TextBoxSourceFolder.Text
            If System.IO.Directory.Exists(Path) = False Then
                Throw New Exception("取込元フォルダがありません")
            End If
            '取込
            Dim DirectoryInfo As New System.IO.DirectoryInfo(Path)
            For Each File As System.IO.FileInfo In DirectoryInfo.GetFiles("*", System.IO.SearchOption.TopDirectoryOnly)
                For Each Row As DataGridViewRow In DataGridViewFileList.Rows
                    Dim FileNameWithoutExtension As String = File.Name.Substring(0, File.Name.Length - File.Extension.Length)
                    If Row.Cells("ColumnFileName").Value = FileNameWithoutExtension Then
                        Row.Cells("ColumnSourceFolderPath").Value = File.FullName
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' ファイル移動
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonMoveFiles_Click(sender As Object, e As EventArgs) Handles ButtonMoveFiles.Click
        Try
            Dim Path As String = TextBoxTargetFolder.Text
            If System.IO.Directory.Exists(Path) = False Then
                Throw New Exception("移動先フォルダがありません")
            End If
            '取込
            For Each Row As DataGridViewRow In DataGridViewFileList.Rows
                Dim FromPath As String = Row.Cells("ColumnSourceFolderPath").Value
                Dim NewPath As String = Row.Cells("ColumnSourceFolderPath").Value
                If NewPath = "" Then
                    Continue For
                End If
                Dim FileInfo As New System.IO.FileInfo(NewPath)
                NewPath = System.IO.Path.Combine(Path, FileInfo.Name)
                '移動
                System.IO.File.Move(FromPath, NewPath)
                'ログ
                Row.Cells("ColumnTargetFolderPath").Value = NewPath
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' プログラムロード
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'コマンドライン引数を取得
            Dim CommandLines As String() = System.Environment.GetCommandLineArgs()
            Dim First As Boolean = True
            Dim Exist As Boolean = False
            For Each Command As String In CommandLines
                If First Then
                    First = False
                    Continue For
                End If
                If Command = "" Then
                    Continue For
                End If
                If System.IO.Directory.Exists(Command) Then
                    TextBoxListFolder.Text = Command
                    TextBoxSourceFolder.Text = Command
                    TextBoxTargetFolder.Text = Command
                    Exist = True
                End If
            Next
            If Exist = False Then
                Dim Setting As New SettingManager(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "setting.xml"))
                Setting.InitializeSetting()
                Setting.LoadFromFile()
                TextBoxListFolder.Text = Setting.Value.LastListupFolder
                TextBoxSourceFolder.Text = Setting.Value.LastSourceFolder
                TextBoxTargetFolder.Text = Setting.Value.LastTargetFolder
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SaveLastFolder()
        Dim Setting As New SettingManager(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "setting.xml"))
        Setting.InitializeSetting()
        Setting.LoadFromFile()
        If System.IO.Directory.Exists(TextBoxListFolder.Text) Then
            Setting.Value.LastListupFolder = TextBoxListFolder.Text
        End If
        If System.IO.Directory.Exists(TextBoxSourceFolder.Text) Then
            Setting.Value.LastListupFolder = TextBoxSourceFolder.Text
        End If
        If System.IO.Directory.Exists(TextBoxTargetFolder.Text) Then
            Setting.Value.LastListupFolder = TextBoxTargetFolder.Text
        End If
        Setting.SaveToFile()
    End Sub
End Class
