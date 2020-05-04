<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.DataGridViewFileList = New System.Windows.Forms.DataGridView()
        Me.ColumnNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnListFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSourceFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTargetFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonListupListFolder = New System.Windows.Forms.Button()
        Me.ButtonSelectListFolder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxListFolder = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonMoveFiles = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSourceFolder = New System.Windows.Forms.TextBox()
        Me.ButtonSelectSourceFolder = New System.Windows.Forms.Button()
        Me.ButtonListupSourceFolder = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxTargetFolder = New System.Windows.Forms.TextBox()
        Me.ButtonSelectTargetFolder = New System.Windows.Forms.Button()
        CType(Me.DataGridViewFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewFileList
        '
        Me.DataGridViewFileList.AllowUserToAddRows = False
        Me.DataGridViewFileList.AllowUserToResizeRows = False
        Me.DataGridViewFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFileList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNum, Me.ColumnFileName, Me.ColumnListFolderPath, Me.ColumnSourceFolderPath, Me.ColumnTargetFolderPath})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DataGridViewFileList, 2)
        Me.DataGridViewFileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFileList.Location = New System.Drawing.Point(3, 278)
        Me.DataGridViewFileList.MultiSelect = False
        Me.DataGridViewFileList.Name = "DataGridViewFileList"
        Me.DataGridViewFileList.ReadOnly = True
        Me.DataGridViewFileList.RowHeadersVisible = False
        Me.DataGridViewFileList.RowTemplate.Height = 21
        Me.DataGridViewFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewFileList.Size = New System.Drawing.Size(588, 325)
        Me.DataGridViewFileList.TabIndex = 11
        '
        'ColumnNum
        '
        Me.ColumnNum.HeaderText = "#"
        Me.ColumnNum.Name = "ColumnNum"
        Me.ColumnNum.ReadOnly = True
        Me.ColumnNum.Width = 30
        '
        'ColumnFileName
        '
        Me.ColumnFileName.HeaderText = "Name"
        Me.ColumnFileName.Name = "ColumnFileName"
        Me.ColumnFileName.ReadOnly = True
        '
        'ColumnListFolderPath
        '
        Me.ColumnListFolderPath.HeaderText = "ListFolderPath"
        Me.ColumnListFolderPath.Name = "ColumnListFolderPath"
        Me.ColumnListFolderPath.ReadOnly = True
        Me.ColumnListFolderPath.Width = 150
        '
        'ColumnSourceFolderPath
        '
        Me.ColumnSourceFolderPath.HeaderText = "SourceFolderPath"
        Me.ColumnSourceFolderPath.Name = "ColumnSourceFolderPath"
        Me.ColumnSourceFolderPath.ReadOnly = True
        Me.ColumnSourceFolderPath.Width = 150
        '
        'ColumnTargetFolderPath
        '
        Me.ColumnTargetFolderPath.HeaderText = "TargetFolderPath"
        Me.ColumnTargetFolderPath.Name = "ColumnTargetFolderPath"
        Me.ColumnTargetFolderPath.ReadOnly = True
        Me.ColumnTargetFolderPath.Width = 150
        '
        'ButtonListupListFolder
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonListupListFolder, 2)
        Me.ButtonListupListFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonListupListFolder.Location = New System.Drawing.Point(3, 48)
        Me.ButtonListupListFolder.Name = "ButtonListupListFolder"
        Me.ButtonListupListFolder.Size = New System.Drawing.Size(588, 34)
        Me.ButtonListupListFolder.TabIndex = 2
        Me.ButtonListupListFolder.Text = "ファイルリスト取込"
        Me.ButtonListupListFolder.UseVisualStyleBackColor = True
        '
        'ButtonSelectListFolder
        '
        Me.ButtonSelectListFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSelectListFolder.Location = New System.Drawing.Point(497, 3)
        Me.ButtonSelectListFolder.Name = "ButtonSelectListFolder"
        Me.TableLayoutPanel1.SetRowSpan(Me.ButtonSelectListFolder, 2)
        Me.ButtonSelectListFolder.Size = New System.Drawing.Size(94, 39)
        Me.ButtonSelectListFolder.TabIndex = 1
        Me.ButtonSelectListFolder.Text = "フォルダ選択"
        Me.ButtonSelectListFolder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(588, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "対象ファイル名リスト"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "リスト取込元フォルダ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxListFolder
        '
        Me.TextBoxListFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxListFolder.Location = New System.Drawing.Point(3, 23)
        Me.TextBoxListFolder.Name = "TextBoxListFolder"
        Me.TextBoxListFolder.Size = New System.Drawing.Size(488, 19)
        Me.TextBoxListFolder.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonMoveFiles, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewFileList, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxListFolder, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonListupListFolder, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSelectListFolder, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxSourceFolder, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSelectSourceFolder, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonListupSourceFolder, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxTargetFolder, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSelectTargetFolder, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(594, 606)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'ButtonMoveFiles
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonMoveFiles, 2)
        Me.ButtonMoveFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonMoveFiles.Location = New System.Drawing.Point(3, 218)
        Me.ButtonMoveFiles.Name = "ButtonMoveFiles"
        Me.ButtonMoveFiles.Size = New System.Drawing.Size(588, 34)
        Me.ButtonMoveFiles.TabIndex = 8
        Me.ButtonMoveFiles.Text = "ファイル移動"
        Me.ButtonMoveFiles.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(488, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ファイル移動元フォルダ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSourceFolder
        '
        Me.TextBoxSourceFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSourceFolder.Location = New System.Drawing.Point(3, 108)
        Me.TextBoxSourceFolder.Name = "TextBoxSourceFolder"
        Me.TextBoxSourceFolder.Size = New System.Drawing.Size(488, 19)
        Me.TextBoxSourceFolder.TabIndex = 3
        '
        'ButtonSelectSourceFolder
        '
        Me.ButtonSelectSourceFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSelectSourceFolder.Location = New System.Drawing.Point(497, 88)
        Me.ButtonSelectSourceFolder.Name = "ButtonSelectSourceFolder"
        Me.TableLayoutPanel1.SetRowSpan(Me.ButtonSelectSourceFolder, 2)
        Me.ButtonSelectSourceFolder.Size = New System.Drawing.Size(94, 39)
        Me.ButtonSelectSourceFolder.TabIndex = 4
        Me.ButtonSelectSourceFolder.Text = "フォルダ選択"
        Me.ButtonSelectSourceFolder.UseVisualStyleBackColor = True
        '
        'ButtonListupSourceFolder
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonListupSourceFolder, 2)
        Me.ButtonListupSourceFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonListupSourceFolder.Location = New System.Drawing.Point(3, 133)
        Me.ButtonListupSourceFolder.Name = "ButtonListupSourceFolder"
        Me.ButtonListupSourceFolder.Size = New System.Drawing.Size(588, 34)
        Me.ButtonListupSourceFolder.TabIndex = 5
        Me.ButtonListupSourceFolder.Text = "移動元ファイル合成"
        Me.ButtonListupSourceFolder.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(488, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ファイル移動先フォルダ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxTargetFolder
        '
        Me.TextBoxTargetFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxTargetFolder.Location = New System.Drawing.Point(3, 193)
        Me.TextBoxTargetFolder.Name = "TextBoxTargetFolder"
        Me.TextBoxTargetFolder.Size = New System.Drawing.Size(488, 19)
        Me.TextBoxTargetFolder.TabIndex = 6
        '
        'ButtonSelectTargetFolder
        '
        Me.ButtonSelectTargetFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSelectTargetFolder.Location = New System.Drawing.Point(497, 173)
        Me.ButtonSelectTargetFolder.Name = "ButtonSelectTargetFolder"
        Me.TableLayoutPanel1.SetRowSpan(Me.ButtonSelectTargetFolder, 2)
        Me.ButtonSelectTargetFolder.Size = New System.Drawing.Size(94, 39)
        Me.ButtonSelectTargetFolder.TabIndex = 7
        Me.ButtonSelectTargetFolder.Text = "フォルダ選択"
        Me.ButtonSelectTargetFolder.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 606)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormMain"
        Me.Text = "PairFileMover"
        CType(Me.DataGridViewFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewFileList As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ButtonMoveFiles As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxListFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonListupListFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonSelectListFolder As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSourceFolder As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSelectSourceFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonListupSourceFolder As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTargetFolder As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSelectTargetFolder As System.Windows.Forms.Button
    Friend WithEvents ColumnNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnListFolderPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnSourceFolderPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTargetFolderPath As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
