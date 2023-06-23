namespace audio_dataset_screener
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpFileList = new System.Windows.Forms.GroupBox();
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.ctMenuProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvFileList = new DoubleBufferedListView();
            this.ctMenuAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.chPlaying = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVPRSimilarity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFileCounter = new System.Windows.Forms.Label();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.numericSleepTimeForAutoPlay = new System.Windows.Forms.NumericUpDown();
            this.comboPlaySpeed = new System.Windows.Forms.ComboBox();
            this.btnSortFolder5 = new System.Windows.Forms.Button();
            this.chkListAuto = new System.Windows.Forms.CheckBox();
            this.btnSortFolder4 = new System.Windows.Forms.Button();
            this.btnSortFolder3 = new System.Windows.Forms.Button();
            this.btnSortFolder2 = new System.Windows.Forms.Button();
            this.btnSortFolder1 = new System.Windows.Forms.Button();
            this.numericStep = new System.Windows.Forms.NumericUpDown();
            this.txtboxSortFolder5 = new System.Windows.Forms.TextBox();
            this.txtboxSortFolder4 = new System.Windows.Forms.TextBox();
            this.txtboxSortFolder3 = new System.Windows.Forms.TextBox();
            this.txtboxSortFolder2 = new System.Windows.Forms.TextBox();
            this.txtboxSortFolder1 = new System.Windows.Forms.TextBox();
            this.labelSortFolder5 = new System.Windows.Forms.Label();
            this.labelSortFolder4 = new System.Windows.Forms.Label();
            this.labelSortFolder3 = new System.Windows.Forms.Label();
            this.labelSortFolder2 = new System.Windows.Forms.Label();
            this.labelSortFolder1 = new System.Windows.Forms.Label();
            this.labelSleepTimeForAutoPlay = new System.Windows.Forms.Label();
            this.labelPlaySpeed = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.grpPlaycontrol = new System.Windows.Forms.GroupBox();
            this.labelPlayprogressString = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelShortcut1 = new System.Windows.Forms.Label();
            this.tckbarVolume = new System.Windows.Forms.TrackBar();
            this.tckbarPlayprogress = new System.Windows.Forms.TrackBar();
            this.btnRew = new System.Windows.Forms.Button();
            this.btnFF = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnToFolder5 = new System.Windows.Forms.Button();
            this.btnToFolder4 = new System.Windows.Forms.Button();
            this.btnToFolder3 = new System.Windows.Forms.Button();
            this.btnToFolder2 = new System.Windows.Forms.Button();
            this.btnToFolder1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelShortcut2 = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnApplyAllActions = new System.Windows.Forms.Button();
            this.comboReplaceDes = new System.Windows.Forms.ComboBox();
            this.comboReplaceOri = new System.Windows.Forms.ComboBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnCancelAllActions = new System.Windows.Forms.Button();
            this.btnApplySelectedActions = new System.Windows.Forms.Button();
            this.btnCancelSelectedActions = new System.Windows.Forms.Button();
            this.labelReplace = new System.Windows.Forms.Label();
            this.timerSleep = new System.Windows.Forms.Timer(this.components);
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.grpFileList.SuspendLayout();
            this.ctMenuProject.SuspendLayout();
            this.ctMenuAdd.SuspendLayout();
            this.grpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSleepTimeForAutoPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStep)).BeginInit();
            this.grpPlaycontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckbarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckbarPlayprogress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFileList
            // 
            this.grpFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFileList.Controls.Add(this.processBar);
            this.grpFileList.Controls.Add(this.btnClearList);
            this.grpFileList.Controls.Add(this.btnDeleteSelected);
            this.grpFileList.Controls.Add(this.btnRemoveSelected);
            this.grpFileList.Controls.Add(this.btnProject);
            this.grpFileList.Controls.Add(this.btnAdd);
            this.grpFileList.Controls.Add(this.lvFileList);
            this.grpFileList.Location = new System.Drawing.Point(12, 12);
            this.grpFileList.Name = "grpFileList";
            this.grpFileList.Size = new System.Drawing.Size(664, 662);
            this.grpFileList.TabIndex = 0;
            this.grpFileList.TabStop = false;
            this.grpFileList.Text = "文件列表";
            // 
            // processBar
            // 
            this.processBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processBar.Location = new System.Drawing.Point(411, 633);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(247, 18);
            this.processBar.Step = 1;
            this.processBar.TabIndex = 0;
            this.processBar.Visible = false;
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearList.Location = new System.Drawing.Point(330, 631);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.TabStop = false;
            this.btnClearList.Text = "清空列表";
            this.tip.SetToolTip(this.btnClearList, "清空当前文件列表（不影响本地文件）");
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteSelected.Location = new System.Drawing.Point(249, 631);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSelected.TabIndex = 1;
            this.btnDeleteSelected.TabStop = false;
            this.btnDeleteSelected.Text = "删除所选";
            this.tip.SetToolTip(this.btnDeleteSelected, "从列表中删除选中项（包括本地文件）");
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(168, 631);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSelected.TabIndex = 1;
            this.btnRemoveSelected.TabStop = false;
            this.btnRemoveSelected.Text = "移除所选";
            this.tip.SetToolTip(this.btnRemoveSelected, "从列表中移除选中项（不包括本地文件）");
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnProject
            // 
            this.btnProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProject.ContextMenuStrip = this.ctMenuProject;
            this.btnProject.Location = new System.Drawing.Point(87, 631);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(75, 23);
            this.btnProject.TabIndex = 1;
            this.btnProject.TabStop = false;
            this.btnProject.Text = "工程文件";
            this.tip.SetToolTip(this.btnProject, "将当前会话状态保存为工程文件，或从工程文件恢复会话");
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // ctMenuProject
            // 
            this.ctMenuProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenProject,
            this.toolStripMenuItemSaveProject});
            this.ctMenuProject.Name = "ctMenuAdd";
            this.ctMenuProject.Size = new System.Drawing.Size(138, 48);
            // 
            // toolStripMenuItemOpenProject
            // 
            this.toolStripMenuItemOpenProject.Name = "toolStripMenuItemOpenProject";
            this.toolStripMenuItemOpenProject.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemOpenProject.Text = "打开工程 ...";
            this.toolStripMenuItemOpenProject.Click += new System.EventHandler(this.toolStripMenuItemOpenProject_Click);
            // 
            // toolStripMenuItemSaveProject
            // 
            this.toolStripMenuItemSaveProject.Name = "toolStripMenuItemSaveProject";
            this.toolStripMenuItemSaveProject.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemSaveProject.Text = "保存工程 ...";
            this.toolStripMenuItemSaveProject.Click += new System.EventHandler(this.toolStripMenuItemSaveProject_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.ContextMenuStrip = this.ctMenuAdd;
            this.btnAdd.Location = new System.Drawing.Point(6, 631);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "添加项目";
            this.tip.SetToolTip(this.btnAdd, "向文件列表中添加音频文件");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ctMenuAdd
            // 
            this.ctMenuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddFile,
            this.toolStripMenuItemAddFolder});
            this.ctMenuAdd.Name = "ctMenuAdd";
            this.ctMenuAdd.Size = new System.Drawing.Size(114, 48);
            // 
            // toolStripMenuItemAddFile
            // 
            this.toolStripMenuItemAddFile.Name = "toolStripMenuItemAddFile";
            this.toolStripMenuItemAddFile.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItemAddFile.Text = "文件 ...";
            this.toolStripMenuItemAddFile.Click += new System.EventHandler(this.toolStripMenuItemAddFile_Click);
            // 
            // toolStripMenuItemAddFolder
            // 
            this.toolStripMenuItemAddFolder.Name = "toolStripMenuItemAddFolder";
            this.toolStripMenuItemAddFolder.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItemAddFolder.Text = "目录 ...";
            this.toolStripMenuItemAddFolder.Click += new System.EventHandler(this.toolStripMenuItemAddFolder_Click);
            // 
            // lvFileList
            // 
            this.lvFileList.AllowDrop = true;
            this.lvFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPlaying,
            this.chAction,
            this.chName,
            this.chDuration,
            this.chPath,
            this.chVPRSimilarity});
            this.lvFileList.FullRowSelect = true;
            this.lvFileList.GridLines = true;
            this.lvFileList.HideSelection = false;
            this.lvFileList.Location = new System.Drawing.Point(6, 18);
            this.lvFileList.Name = "lvFileList";
            this.lvFileList.Size = new System.Drawing.Size(652, 607);
            this.lvFileList.TabIndex = 0;
            this.lvFileList.TabStop = false;
            this.lvFileList.UseCompatibleStateImageBehavior = false;
            this.lvFileList.View = System.Windows.Forms.View.Details;
            this.lvFileList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvFileList_ColumnClick);
            this.lvFileList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFileList_MouseDoubleClick);
            // 
            // chPlaying
            // 
            this.chPlaying.Text = " ";
            this.chPlaying.Width = 30;
            // 
            // chAction
            // 
            this.chAction.Text = "动作";
            this.chAction.Width = 40;
            // 
            // chName
            // 
            this.chName.Text = "文件名";
            this.chName.Width = 123;
            // 
            // chDuration
            // 
            this.chDuration.Text = "时长";
            this.chDuration.Width = 75;
            // 
            // chPath
            // 
            this.chPath.Text = "文件路径";
            this.chPath.Width = 268;
            // 
            // chVPRSimilarity
            // 
            this.chVPRSimilarity.Text = "声纹识别相似度";
            this.chVPRSimilarity.Width = 107;
            // 
            // labelFileCounter
            // 
            this.labelFileCounter.Location = new System.Drawing.Point(184, 115);
            this.labelFileCounter.Name = "labelFileCounter";
            this.labelFileCounter.Size = new System.Drawing.Size(77, 19);
            this.labelFileCounter.TabIndex = 2;
            this.labelFileCounter.Text = "0/0";
            this.labelFileCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpConfig
            // 
            this.grpConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConfig.Controls.Add(this.numericSleepTimeForAutoPlay);
            this.grpConfig.Controls.Add(this.comboPlaySpeed);
            this.grpConfig.Controls.Add(this.btnSortFolder5);
            this.grpConfig.Controls.Add(this.chkListAuto);
            this.grpConfig.Controls.Add(this.btnSortFolder4);
            this.grpConfig.Controls.Add(this.btnSortFolder3);
            this.grpConfig.Controls.Add(this.btnSortFolder2);
            this.grpConfig.Controls.Add(this.btnSortFolder1);
            this.grpConfig.Controls.Add(this.numericStep);
            this.grpConfig.Controls.Add(this.txtboxSortFolder5);
            this.grpConfig.Controls.Add(this.txtboxSortFolder4);
            this.grpConfig.Controls.Add(this.txtboxSortFolder3);
            this.grpConfig.Controls.Add(this.txtboxSortFolder2);
            this.grpConfig.Controls.Add(this.txtboxSortFolder1);
            this.grpConfig.Controls.Add(this.labelSortFolder5);
            this.grpConfig.Controls.Add(this.labelSortFolder4);
            this.grpConfig.Controls.Add(this.labelSortFolder3);
            this.grpConfig.Controls.Add(this.labelSortFolder2);
            this.grpConfig.Controls.Add(this.labelSortFolder1);
            this.grpConfig.Controls.Add(this.labelSleepTimeForAutoPlay);
            this.grpConfig.Controls.Add(this.labelPlaySpeed);
            this.grpConfig.Controls.Add(this.labelStep);
            this.grpConfig.Location = new System.Drawing.Point(690, 12);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(315, 235);
            this.grpConfig.TabIndex = 1;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "设置";
            // 
            // numericSleepTimeForAutoPlay
            // 
            this.numericSleepTimeForAutoPlay.Location = new System.Drawing.Point(229, 202);
            this.numericSleepTimeForAutoPlay.Name = "numericSleepTimeForAutoPlay";
            this.numericSleepTimeForAutoPlay.Size = new System.Drawing.Size(50, 21);
            this.numericSleepTimeForAutoPlay.TabIndex = 7;
            this.numericSleepTimeForAutoPlay.TabStop = false;
            this.numericSleepTimeForAutoPlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tip.SetToolTip(this.numericSleepTimeForAutoPlay, "自动切换下条音频前等待的时间");
            // 
            // comboPlaySpeed
            // 
            this.comboPlaySpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlaySpeed.FormattingEnabled = true;
            this.comboPlaySpeed.Items.AddRange(new object[] {
            "0.50",
            "0.75",
            "1.00",
            "1.25",
            "1.50",
            "2.00",
            "2.50"});
            this.comboPlaySpeed.Location = new System.Drawing.Point(229, 173);
            this.comboPlaySpeed.Name = "comboPlaySpeed";
            this.comboPlaySpeed.Size = new System.Drawing.Size(50, 20);
            this.comboPlaySpeed.TabIndex = 11;
            this.tip.SetToolTip(this.comboPlaySpeed, "部分格式（如FLAC）不支持倍速播放");
            this.comboPlaySpeed.SelectedIndexChanged += new System.EventHandler(this.comboPlaySpeed_SelectedIndexChanged);
            // 
            // btnSortFolder5
            // 
            this.btnSortFolder5.Location = new System.Drawing.Point(258, 139);
            this.btnSortFolder5.Name = "btnSortFolder5";
            this.btnSortFolder5.Size = new System.Drawing.Size(41, 22);
            this.btnSortFolder5.TabIndex = 10;
            this.btnSortFolder5.TabStop = false;
            this.btnSortFolder5.Text = "...";
            this.tip.SetToolTip(this.btnSortFolder5, "浏览");
            this.btnSortFolder5.UseVisualStyleBackColor = true;
            this.btnSortFolder5.Click += new System.EventHandler(this.btnSortFolder5_Click);
            // 
            // chkListAuto
            // 
            this.chkListAuto.AutoSize = true;
            this.chkListAuto.Checked = true;
            this.chkListAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkListAuto.Location = new System.Drawing.Point(22, 205);
            this.chkListAuto.Name = "chkListAuto";
            this.chkListAuto.Size = new System.Drawing.Size(96, 16);
            this.chkListAuto.TabIndex = 6;
            this.chkListAuto.TabStop = false;
            this.chkListAuto.Text = "列表自动播放";
            this.chkListAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tip.SetToolTip(this.chkListAuto, "当前音频播放完毕后自动切换至下一条");
            this.chkListAuto.UseVisualStyleBackColor = true;
            this.chkListAuto.CheckedChanged += new System.EventHandler(this.chkListAuto_CheckedChanged);
            // 
            // btnSortFolder4
            // 
            this.btnSortFolder4.Location = new System.Drawing.Point(258, 110);
            this.btnSortFolder4.Name = "btnSortFolder4";
            this.btnSortFolder4.Size = new System.Drawing.Size(41, 22);
            this.btnSortFolder4.TabIndex = 10;
            this.btnSortFolder4.TabStop = false;
            this.btnSortFolder4.Text = "...";
            this.tip.SetToolTip(this.btnSortFolder4, "浏览");
            this.btnSortFolder4.UseVisualStyleBackColor = true;
            this.btnSortFolder4.Click += new System.EventHandler(this.btnSortFolder4_Click);
            // 
            // btnSortFolder3
            // 
            this.btnSortFolder3.Location = new System.Drawing.Point(258, 81);
            this.btnSortFolder3.Name = "btnSortFolder3";
            this.btnSortFolder3.Size = new System.Drawing.Size(41, 22);
            this.btnSortFolder3.TabIndex = 10;
            this.btnSortFolder3.TabStop = false;
            this.btnSortFolder3.Text = "...";
            this.tip.SetToolTip(this.btnSortFolder3, "浏览");
            this.btnSortFolder3.UseVisualStyleBackColor = true;
            this.btnSortFolder3.Click += new System.EventHandler(this.btnSortFolder3_Click);
            // 
            // btnSortFolder2
            // 
            this.btnSortFolder2.Location = new System.Drawing.Point(258, 52);
            this.btnSortFolder2.Name = "btnSortFolder2";
            this.btnSortFolder2.Size = new System.Drawing.Size(41, 22);
            this.btnSortFolder2.TabIndex = 10;
            this.btnSortFolder2.TabStop = false;
            this.btnSortFolder2.Text = "...";
            this.tip.SetToolTip(this.btnSortFolder2, "浏览");
            this.btnSortFolder2.UseVisualStyleBackColor = true;
            this.btnSortFolder2.Click += new System.EventHandler(this.btnSortFolder2_Click);
            // 
            // btnSortFolder1
            // 
            this.btnSortFolder1.Location = new System.Drawing.Point(258, 23);
            this.btnSortFolder1.Name = "btnSortFolder1";
            this.btnSortFolder1.Size = new System.Drawing.Size(41, 22);
            this.btnSortFolder1.TabIndex = 10;
            this.btnSortFolder1.TabStop = false;
            this.btnSortFolder1.Text = "...";
            this.tip.SetToolTip(this.btnSortFolder1, "浏览");
            this.btnSortFolder1.UseVisualStyleBackColor = true;
            this.btnSortFolder1.Click += new System.EventHandler(this.btnSortFolder1_Click);
            // 
            // numericStep
            // 
            this.numericStep.Location = new System.Drawing.Point(83, 173);
            this.numericStep.Name = "numericStep";
            this.numericStep.Size = new System.Drawing.Size(50, 21);
            this.numericStep.TabIndex = 7;
            this.numericStep.TabStop = false;
            this.numericStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tip.SetToolTip(this.numericStep, "每次快进/快退的时间长度");
            this.numericStep.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtboxSortFolder5
            // 
            this.txtboxSortFolder5.Location = new System.Drawing.Point(83, 140);
            this.txtboxSortFolder5.Name = "txtboxSortFolder5";
            this.txtboxSortFolder5.Size = new System.Drawing.Size(169, 21);
            this.txtboxSortFolder5.TabIndex = 1;
            this.txtboxSortFolder5.TabStop = false;
            // 
            // txtboxSortFolder4
            // 
            this.txtboxSortFolder4.Location = new System.Drawing.Point(83, 111);
            this.txtboxSortFolder4.Name = "txtboxSortFolder4";
            this.txtboxSortFolder4.Size = new System.Drawing.Size(169, 21);
            this.txtboxSortFolder4.TabIndex = 1;
            this.txtboxSortFolder4.TabStop = false;
            // 
            // txtboxSortFolder3
            // 
            this.txtboxSortFolder3.Location = new System.Drawing.Point(83, 82);
            this.txtboxSortFolder3.Name = "txtboxSortFolder3";
            this.txtboxSortFolder3.Size = new System.Drawing.Size(169, 21);
            this.txtboxSortFolder3.TabIndex = 1;
            this.txtboxSortFolder3.TabStop = false;
            // 
            // txtboxSortFolder2
            // 
            this.txtboxSortFolder2.Location = new System.Drawing.Point(83, 53);
            this.txtboxSortFolder2.Name = "txtboxSortFolder2";
            this.txtboxSortFolder2.Size = new System.Drawing.Size(169, 21);
            this.txtboxSortFolder2.TabIndex = 1;
            this.txtboxSortFolder2.TabStop = false;
            // 
            // txtboxSortFolder1
            // 
            this.txtboxSortFolder1.Location = new System.Drawing.Point(83, 24);
            this.txtboxSortFolder1.Name = "txtboxSortFolder1";
            this.txtboxSortFolder1.Size = new System.Drawing.Size(169, 21);
            this.txtboxSortFolder1.TabIndex = 1;
            this.txtboxSortFolder1.TabStop = false;
            // 
            // labelSortFolder5
            // 
            this.labelSortFolder5.AutoSize = true;
            this.labelSortFolder5.Location = new System.Drawing.Point(18, 144);
            this.labelSortFolder5.Name = "labelSortFolder5";
            this.labelSortFolder5.Size = new System.Drawing.Size(59, 12);
            this.labelSortFolder5.TabIndex = 0;
            this.labelSortFolder5.Text = "分类目录5";
            // 
            // labelSortFolder4
            // 
            this.labelSortFolder4.AutoSize = true;
            this.labelSortFolder4.Location = new System.Drawing.Point(18, 115);
            this.labelSortFolder4.Name = "labelSortFolder4";
            this.labelSortFolder4.Size = new System.Drawing.Size(59, 12);
            this.labelSortFolder4.TabIndex = 0;
            this.labelSortFolder4.Text = "分类目录4";
            // 
            // labelSortFolder3
            // 
            this.labelSortFolder3.AutoSize = true;
            this.labelSortFolder3.Location = new System.Drawing.Point(18, 86);
            this.labelSortFolder3.Name = "labelSortFolder3";
            this.labelSortFolder3.Size = new System.Drawing.Size(59, 12);
            this.labelSortFolder3.TabIndex = 0;
            this.labelSortFolder3.Text = "分类目录3";
            // 
            // labelSortFolder2
            // 
            this.labelSortFolder2.AutoSize = true;
            this.labelSortFolder2.Location = new System.Drawing.Point(18, 57);
            this.labelSortFolder2.Name = "labelSortFolder2";
            this.labelSortFolder2.Size = new System.Drawing.Size(59, 12);
            this.labelSortFolder2.TabIndex = 0;
            this.labelSortFolder2.Text = "分类目录2";
            // 
            // labelSortFolder1
            // 
            this.labelSortFolder1.AutoSize = true;
            this.labelSortFolder1.Location = new System.Drawing.Point(18, 28);
            this.labelSortFolder1.Name = "labelSortFolder1";
            this.labelSortFolder1.Size = new System.Drawing.Size(59, 12);
            this.labelSortFolder1.TabIndex = 0;
            this.labelSortFolder1.Text = "分类目录1";
            // 
            // labelSleepTimeForAutoPlay
            // 
            this.labelSleepTimeForAutoPlay.AutoSize = true;
            this.labelSleepTimeForAutoPlay.Location = new System.Drawing.Point(129, 206);
            this.labelSleepTimeForAutoPlay.Name = "labelSleepTimeForAutoPlay";
            this.labelSleepTimeForAutoPlay.Size = new System.Drawing.Size(173, 12);
            this.labelSleepTimeForAutoPlay.TabIndex = 9;
            this.labelSleepTimeForAutoPlay.Text = "切换下条前等待            秒";
            this.tip.SetToolTip(this.labelSleepTimeForAutoPlay, "自动切换下条音频前等待的时间");
            // 
            // labelPlaySpeed
            // 
            this.labelPlaySpeed.AutoSize = true;
            this.labelPlaySpeed.Location = new System.Drawing.Point(165, 177);
            this.labelPlaySpeed.Name = "labelPlaySpeed";
            this.labelPlaySpeed.Size = new System.Drawing.Size(137, 12);
            this.labelPlaySpeed.TabIndex = 9;
            this.labelPlaySpeed.Text = "播放速度            倍";
            this.tip.SetToolTip(this.labelPlaySpeed, "部分格式（如FLAC）不支持倍速播放");
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(19, 177);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(137, 12);
            this.labelStep.TabIndex = 9;
            this.labelStep.Text = "进退步长            秒";
            this.tip.SetToolTip(this.labelStep, "每次快进/快退的时间长度");
            // 
            // grpPlaycontrol
            // 
            this.grpPlaycontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPlaycontrol.Controls.Add(this.labelPlayprogressString);
            this.grpPlaycontrol.Controls.Add(this.labelVolume);
            this.grpPlaycontrol.Controls.Add(this.labelShortcut1);
            this.grpPlaycontrol.Controls.Add(this.tckbarVolume);
            this.grpPlaycontrol.Controls.Add(this.tckbarPlayprogress);
            this.grpPlaycontrol.Controls.Add(this.labelFileCounter);
            this.grpPlaycontrol.Controls.Add(this.btnRew);
            this.grpPlaycontrol.Controls.Add(this.btnFF);
            this.grpPlaycontrol.Controls.Add(this.btnPlayPause);
            this.grpPlaycontrol.Controls.Add(this.btnNext);
            this.grpPlaycontrol.Controls.Add(this.btnPrevious);
            this.grpPlaycontrol.Controls.Add(this.wmp);
            this.grpPlaycontrol.Enabled = false;
            this.grpPlaycontrol.Location = new System.Drawing.Point(690, 253);
            this.grpPlaycontrol.Name = "grpPlaycontrol";
            this.grpPlaycontrol.Size = new System.Drawing.Size(315, 223);
            this.grpPlaycontrol.TabIndex = 2;
            this.grpPlaycontrol.TabStop = false;
            this.grpPlaycontrol.Text = "播放控制";
            // 
            // labelPlayprogressString
            // 
            this.labelPlayprogressString.AutoSize = true;
            this.labelPlayprogressString.Location = new System.Drawing.Point(216, 89);
            this.labelPlayprogressString.Name = "labelPlayprogressString";
            this.labelPlayprogressString.Size = new System.Drawing.Size(83, 12);
            this.labelPlayprogressString.TabIndex = 2;
            this.labelPlayprogressString.Text = "00:00 / 00:00";
            this.labelPlayprogressString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(270, 174);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(29, 12);
            this.labelVolume.TabIndex = 8;
            this.labelVolume.Text = "音量";
            // 
            // labelShortcut1
            // 
            this.labelShortcut1.AutoSize = true;
            this.labelShortcut1.Location = new System.Drawing.Point(17, 199);
            this.labelShortcut1.Name = "labelShortcut1";
            this.labelShortcut1.Size = new System.Drawing.Size(281, 12);
            this.labelShortcut1.TabIndex = 3;
            this.labelShortcut1.Text = "W/S：上一条/下一条 A/D：快退/快进 F：播放/暂停";
            // 
            // tckbarVolume
            // 
            this.tckbarVolume.AutoSize = false;
            this.tckbarVolume.Location = new System.Drawing.Point(270, 103);
            this.tckbarVolume.Maximum = 100;
            this.tckbarVolume.Name = "tckbarVolume";
            this.tckbarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tckbarVolume.Size = new System.Drawing.Size(38, 75);
            this.tckbarVolume.TabIndex = 4;
            this.tckbarVolume.TabStop = false;
            this.tckbarVolume.TickFrequency = 20;
            this.tip.SetToolTip(this.tckbarVolume, "音量：100");
            this.tckbarVolume.Value = 100;
            this.tckbarVolume.ValueChanged += new System.EventHandler(this.tckbarVolume_ValueChanged);
            // 
            // tckbarPlayprogress
            // 
            this.tckbarPlayprogress.AutoSize = false;
            this.tckbarPlayprogress.Location = new System.Drawing.Point(6, 65);
            this.tckbarPlayprogress.Maximum = 100;
            this.tckbarPlayprogress.Name = "tckbarPlayprogress";
            this.tckbarPlayprogress.Size = new System.Drawing.Size(302, 27);
            this.tckbarPlayprogress.TabIndex = 3;
            this.tckbarPlayprogress.TabStop = false;
            this.tckbarPlayprogress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckbarPlayprogress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tckbarPlayprogress_MouseDown);
            this.tckbarPlayprogress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tckbarPlayprogress_MouseUp);
            // 
            // btnRew
            // 
            this.btnRew.Location = new System.Drawing.Point(13, 140);
            this.btnRew.Name = "btnRew";
            this.btnRew.Size = new System.Drawing.Size(77, 23);
            this.btnRew.TabIndex = 1;
            this.btnRew.TabStop = false;
            this.btnRew.Text = "◀◀";
            this.btnRew.UseVisualStyleBackColor = true;
            this.btnRew.Click += new System.EventHandler(this.btnRew_Click);
            // 
            // btnFF
            // 
            this.btnFF.Location = new System.Drawing.Point(184, 140);
            this.btnFF.Name = "btnFF";
            this.btnFF.Size = new System.Drawing.Size(77, 23);
            this.btnFF.TabIndex = 1;
            this.btnFF.TabStop = false;
            this.btnFF.Text = "▶▶";
            this.btnFF.UseVisualStyleBackColor = true;
            this.btnFF.Click += new System.EventHandler(this.btnFF_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(99, 140);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(77, 23);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.TabStop = false;
            this.btnPlayPause.Text = "▶║";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(99, 166);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "▼";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(99, 113);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(77, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "▲";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(12, 20);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(290, 40);
            this.wmp.TabIndex = 0;
            this.wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmp_PlayStateChange);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "删";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnToFolder5
            // 
            this.btnToFolder5.Location = new System.Drawing.Point(212, 20);
            this.btnToFolder5.Name = "btnToFolder5";
            this.btnToFolder5.Size = new System.Drawing.Size(44, 23);
            this.btnToFolder5.TabIndex = 2;
            this.btnToFolder5.TabStop = false;
            this.btnToFolder5.Text = "5";
            this.btnToFolder5.UseVisualStyleBackColor = true;
            this.btnToFolder5.Click += new System.EventHandler(this.btnToFolder5_Click);
            // 
            // btnToFolder4
            // 
            this.btnToFolder4.Location = new System.Drawing.Point(162, 20);
            this.btnToFolder4.Name = "btnToFolder4";
            this.btnToFolder4.Size = new System.Drawing.Size(44, 23);
            this.btnToFolder4.TabIndex = 2;
            this.btnToFolder4.TabStop = false;
            this.btnToFolder4.Text = "4";
            this.btnToFolder4.UseVisualStyleBackColor = true;
            this.btnToFolder4.Click += new System.EventHandler(this.btnToFolder4_Click);
            // 
            // btnToFolder3
            // 
            this.btnToFolder3.Location = new System.Drawing.Point(114, 20);
            this.btnToFolder3.Name = "btnToFolder3";
            this.btnToFolder3.Size = new System.Drawing.Size(44, 23);
            this.btnToFolder3.TabIndex = 2;
            this.btnToFolder3.TabStop = false;
            this.btnToFolder3.Text = "3";
            this.btnToFolder3.UseVisualStyleBackColor = true;
            this.btnToFolder3.Click += new System.EventHandler(this.btnToFolder3_Click);
            // 
            // btnToFolder2
            // 
            this.btnToFolder2.Location = new System.Drawing.Point(64, 20);
            this.btnToFolder2.Name = "btnToFolder2";
            this.btnToFolder2.Size = new System.Drawing.Size(44, 23);
            this.btnToFolder2.TabIndex = 2;
            this.btnToFolder2.TabStop = false;
            this.btnToFolder2.Text = "2";
            this.btnToFolder2.UseVisualStyleBackColor = true;
            this.btnToFolder2.Click += new System.EventHandler(this.btnToFolder2_Click);
            // 
            // btnToFolder1
            // 
            this.btnToFolder1.Location = new System.Drawing.Point(16, 20);
            this.btnToFolder1.Name = "btnToFolder1";
            this.btnToFolder1.Size = new System.Drawing.Size(44, 23);
            this.btnToFolder1.TabIndex = 2;
            this.btnToFolder1.TabStop = false;
            this.btnToFolder1.Text = "1";
            this.btnToFolder1.UseVisualStyleBackColor = true;
            this.btnToFolder1.Click += new System.EventHandler(this.btnToFolder1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "音频文件（*.wav;*.flac;*.mp3;*.aac;*.m4a;*.wma）|*.wav;*.flac;*.mp3;*.aac;*.m4a;*.wma;|" +
    "所有文件|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "添加文件";
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // labelAbout
            // 
            this.labelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAbout.AutoSize = true;
            this.labelAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAbout.Font = new System.Drawing.Font("Times New Roman", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.Location = new System.Drawing.Point(727, 658);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(240, 17);
            this.labelAbout.TabIndex = 4;
            this.labelAbout.Text = "Audio Dataset Screener 1.3.1 by 2DIPW";
            this.labelAbout.Click += new System.EventHandler(this.labelAbout_Click);
            // 
            // labelShortcut2
            // 
            this.labelShortcut2.AutoSize = true;
            this.labelShortcut2.Location = new System.Drawing.Point(21, 148);
            this.labelShortcut2.Name = "labelShortcut2";
            this.labelShortcut2.Size = new System.Drawing.Size(275, 12);
            this.labelShortcut2.TabIndex = 3;
            this.labelShortcut2.Text = "1/2/3/4/5：标记分类 Del：标记删除 R：取消标记";
            // 
            // grpAction
            // 
            this.grpAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAction.Controls.Add(this.btnApplyAllActions);
            this.grpAction.Controls.Add(this.comboReplaceDes);
            this.grpAction.Controls.Add(this.comboReplaceOri);
            this.grpAction.Controls.Add(this.btnReplace);
            this.grpAction.Controls.Add(this.btnCancelAllActions);
            this.grpAction.Controls.Add(this.btnApplySelectedActions);
            this.grpAction.Controls.Add(this.btnCancelSelectedActions);
            this.grpAction.Controls.Add(this.btnToFolder2);
            this.grpAction.Controls.Add(this.labelShortcut2);
            this.grpAction.Controls.Add(this.btnToFolder1);
            this.grpAction.Controls.Add(this.btnToFolder3);
            this.grpAction.Controls.Add(this.btnToFolder4);
            this.grpAction.Controls.Add(this.btnToFolder5);
            this.grpAction.Controls.Add(this.btnDelete);
            this.grpAction.Controls.Add(this.labelReplace);
            this.grpAction.Enabled = false;
            this.grpAction.Location = new System.Drawing.Point(690, 482);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(315, 171);
            this.grpAction.TabIndex = 6;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "分类筛选动作标记";
            // 
            // btnApplyAllActions
            // 
            this.btnApplyAllActions.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApplyAllActions.Location = new System.Drawing.Point(16, 107);
            this.btnApplyAllActions.Name = "btnApplyAllActions";
            this.btnApplyAllActions.Size = new System.Drawing.Size(288, 36);
            this.btnApplyAllActions.TabIndex = 4;
            this.btnApplyAllActions.Text = "全部执行";
            this.btnApplyAllActions.UseVisualStyleBackColor = true;
            this.btnApplyAllActions.Click += new System.EventHandler(this.btnApplyAllActions_Click);
            // 
            // comboReplaceDes
            // 
            this.comboReplaceDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReplaceDes.FormattingEnabled = true;
            this.comboReplaceDes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "删"});
            this.comboReplaceDes.Location = new System.Drawing.Point(156, 80);
            this.comboReplaceDes.Name = "comboReplaceDes";
            this.comboReplaceDes.Size = new System.Drawing.Size(50, 20);
            this.comboReplaceDes.TabIndex = 11;
            // 
            // comboReplaceOri
            // 
            this.comboReplaceOri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReplaceOri.FormattingEnabled = true;
            this.comboReplaceOri.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "删"});
            this.comboReplaceOri.Location = new System.Drawing.Point(58, 80);
            this.comboReplaceOri.Name = "comboReplaceOri";
            this.comboReplaceOri.Size = new System.Drawing.Size(50, 20);
            this.comboReplaceOri.TabIndex = 11;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(212, 78);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(92, 23);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "替换";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnCancelAllActions
            // 
            this.btnCancelAllActions.Location = new System.Drawing.Point(212, 49);
            this.btnCancelAllActions.Name = "btnCancelAllActions";
            this.btnCancelAllActions.Size = new System.Drawing.Size(92, 23);
            this.btnCancelAllActions.TabIndex = 4;
            this.btnCancelAllActions.Text = "全部取消";
            this.btnCancelAllActions.UseVisualStyleBackColor = true;
            this.btnCancelAllActions.Click += new System.EventHandler(this.btnCancelAllActions_Click);
            // 
            // btnApplySelectedActions
            // 
            this.btnApplySelectedActions.Location = new System.Drawing.Point(114, 49);
            this.btnApplySelectedActions.Name = "btnApplySelectedActions";
            this.btnApplySelectedActions.Size = new System.Drawing.Size(92, 23);
            this.btnApplySelectedActions.TabIndex = 4;
            this.btnApplySelectedActions.Text = "执行所选";
            this.btnApplySelectedActions.UseVisualStyleBackColor = true;
            this.btnApplySelectedActions.Click += new System.EventHandler(this.btnApplySelectedActions_Click);
            // 
            // btnCancelSelectedActions
            // 
            this.btnCancelSelectedActions.Location = new System.Drawing.Point(16, 49);
            this.btnCancelSelectedActions.Name = "btnCancelSelectedActions";
            this.btnCancelSelectedActions.Size = new System.Drawing.Size(92, 23);
            this.btnCancelSelectedActions.TabIndex = 4;
            this.btnCancelSelectedActions.Text = "取消所选";
            this.btnCancelSelectedActions.UseVisualStyleBackColor = true;
            this.btnCancelSelectedActions.Click += new System.EventHandler(this.btnCancelSelectedActions_Click);
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(17, 84);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(137, 12);
            this.labelReplace.TabIndex = 9;
            this.labelReplace.Text = "将所有          替换为";
            // 
            // timerSleep
            // 
            this.timerSleep.Tick += new System.EventHandler(this.timerSleep_Tick);
            // 
            // tip
            // 
            this.tip.AutoPopDelay = 5000;
            this.tip.InitialDelay = 500;
            this.tip.ReshowDelay = 100;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 686);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.grpPlaycontrol);
            this.Controls.Add(this.grpConfig);
            this.Controls.Add(this.grpFileList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1029, 725);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Dataset Screener";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.grpFileList.ResumeLayout(false);
            this.ctMenuProject.ResumeLayout(false);
            this.ctMenuAdd.ResumeLayout(false);
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSleepTimeForAutoPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStep)).EndInit();
            this.grpPlaycontrol.ResumeLayout(false);
            this.grpPlaycontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckbarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckbarPlayprogress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFileList;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.GroupBox grpPlaycontrol;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnAdd;
        private DoubleBufferedListView lvFileList;
        private System.Windows.Forms.Label labelSortFolder4;
        private System.Windows.Forms.Label labelSortFolder3;
        private System.Windows.Forms.Label labelSortFolder2;
        private System.Windows.Forms.Label labelSortFolder1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToFolder4;
        private System.Windows.Forms.Button btnToFolder3;
        private System.Windows.Forms.Button btnToFolder2;
        private System.Windows.Forms.Button btnToFolder1;
        private System.Windows.Forms.Button btnRew;
        private System.Windows.Forms.Button btnFF;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtboxSortFolder4;
        private System.Windows.Forms.TextBox txtboxSortFolder3;
        private System.Windows.Forms.TextBox txtboxSortFolder2;
        private System.Windows.Forms.TextBox txtboxSortFolder1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelFileCounter;
        private System.Windows.Forms.TextBox txtboxSortFolder5;
        private System.Windows.Forms.Label labelSortFolder5;
        private System.Windows.Forms.Button btnToFolder5;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDuration;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.ColumnHeader chPlaying;
        private System.Windows.Forms.CheckBox chkListAuto;
        private System.Windows.Forms.TrackBar tckbarVolume;
        private System.Windows.Forms.TrackBar tckbarPlayprogress;
        private System.Windows.Forms.NumericUpDown numericStep;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Button btnSortFolder5;
        private System.Windows.Forms.Button btnSortFolder4;
        private System.Windows.Forms.Button btnSortFolder3;
        private System.Windows.Forms.Button btnSortFolder2;
        private System.Windows.Forms.Button btnSortFolder1;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Label labelShortcut1;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelShortcut2;
        private System.Windows.Forms.ColumnHeader chAction;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Button btnApplyAllActions;
        private System.Windows.Forms.Button btnCancelSelectedActions;
        private System.Windows.Forms.Button btnCancelAllActions;
        private System.Windows.Forms.Button btnApplySelectedActions;
        private System.Windows.Forms.Label labelPlaySpeed;
        private System.Windows.Forms.ComboBox comboPlaySpeed;
        private System.Windows.Forms.NumericUpDown numericSleepTimeForAutoPlay;
        private System.Windows.Forms.Label labelSleepTimeForAutoPlay;
        private System.Windows.Forms.Timer timerSleep;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.ProgressBar processBar;
        private System.Windows.Forms.Label labelPlayprogressString;
        private System.Windows.Forms.ColumnHeader chVPRSimilarity;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.ComboBox comboReplaceDes;
        private System.Windows.Forms.ComboBox comboReplaceOri;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.ContextMenuStrip ctMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddFolder;
        private System.Windows.Forms.ContextMenuStrip ctMenuProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveProject;
    }
}

