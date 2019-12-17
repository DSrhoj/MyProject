namespace Subtitle_Maker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loadVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findnexttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplereplacetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotosubtitlenumbertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageSourceView = new System.Windows.Forms.TabPage();
            this.textBoxSourceView = new System.Windows.Forms.TextBox();
            this.tabPageListView = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLocationsSubtitleLocationValue = new System.Windows.Forms.Label();
            this.labelVideoLocationValue = new System.Windows.Forms.Label();
            this.labelLocationsSubtitleLocation = new System.Windows.Forms.Label();
            this.labelLocationsVideoLocation = new System.Windows.Forms.Label();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.buttonPlayerLoadVideo = new System.Windows.Forms.Button();
            this.buttonPlayerMoveCurrentTimeFor = new System.Windows.Forms.Button();
            this.radioButtonPlayerBackward = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayerForward = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxPlayer = new System.Windows.Forms.MaskedTextBox();
            this.buttonPlayer5sForwards = new System.Windows.Forms.Button();
            this.buttonPlayer1sForwards = new System.Windows.Forms.Button();
            this.buttonPlayer025sForward = new System.Windows.Forms.Button();
            this.buttonPlayer025sBackward = new System.Windows.Forms.Button();
            this.buttonPlayer1sBackward = new System.Windows.Forms.Button();
            this.buttonPlayer5sBackward = new System.Windows.Forms.Button();
            this.buttonPlayerPanel = new System.Windows.Forms.Button();
            this.buttonPlayerVolDown = new System.Windows.Forms.Button();
            this.buttonPlayerVolUp = new System.Windows.Forms.Button();
            this.buttonPlayerMute = new System.Windows.Forms.Button();
            this.buttonPlayerStop = new System.Windows.Forms.Button();
            this.buttonPlayerPause = new System.Windows.Forms.Button();
            this.buttonPlayerPlay = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonEditingUndoChanges = new System.Windows.Forms.Button();
            this.buttonEditingSaveChanges = new System.Windows.Forms.Button();
            this.buttonEditingUnbreak = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelEditingText = new System.Windows.Forms.Label();
            this.textBoxEditing = new System.Windows.Forms.TextBox();
            this.buttonEditingAutobr = new System.Windows.Forms.Button();
            this.buttonEditingNext = new System.Windows.Forms.Button();
            this.buttonEditingPrev = new System.Windows.Forms.Button();
            this.buttonEditingPickCurrentEndTime = new System.Windows.Forms.Button();
            this.buttonEditingPickCurrentStartTime = new System.Windows.Forms.Button();
            this.labelEditingDurationValue = new System.Windows.Forms.Label();
            this.maskedTextBoxEditingEndTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEditingStartTime = new System.Windows.Forms.MaskedTextBox();
            this.labelEditingEndTime = new System.Windows.Forms.Label();
            this.labelEditingDuration = new System.Windows.Forms.Label();
            this.labelEditingStartTime = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddOpenSRT = new System.Windows.Forms.Button();
            this.buttonAddAddSubtitle = new System.Windows.Forms.Button();
            this.labelAddText = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAddPickCurrentEndTime = new System.Windows.Forms.Button();
            this.buttonAddPickCurrentStartTime = new System.Windows.Forms.Button();
            this.labelAddDurationValue = new System.Windows.Forms.Label();
            this.maskedTextBoxAddEndTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAddStartTime = new System.Windows.Forms.MaskedTextBox();
            this.labelAddEndTime = new System.Windows.Forms.Label();
            this.labelAddDuration = new System.Windows.Forms.Label();
            this.labelAddStartTime = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPageSourceView.SuspendLayout();
            this.tabPageListView.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.openContainingFolderToolStripMenuItem,
            this.toolStripSeparator3,
            this.loadVideoToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // openContainingFolderToolStripMenuItem
            // 
            this.openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            this.openContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openContainingFolderToolStripMenuItem.Text = "Open containing folder";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // loadVideoToolStripMenuItem
            // 
            this.loadVideoToolStripMenuItem.Name = "loadVideoToolStripMenuItem";
            this.loadVideoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.loadVideoToolStripMenuItem.Text = "Load Video...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undotoolStripMenuItem,
            this.toolStripSeparator2,
            this.findtoolStripMenuItem,
            this.findnexttoolStripMenuItem,
            this.replacetoolStripMenuItem,
            this.multiplereplacetoolStripMenuItem,
            this.gotosubtitlenumbertoolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // undotoolStripMenuItem
            // 
            this.undotoolStripMenuItem.Name = "undotoolStripMenuItem";
            this.undotoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.undotoolStripMenuItem.Text = "Undo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // findtoolStripMenuItem
            // 
            this.findtoolStripMenuItem.Name = "findtoolStripMenuItem";
            this.findtoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.findtoolStripMenuItem.Text = "Find                                    Ctrl+F";
            // 
            // findnexttoolStripMenuItem
            // 
            this.findnexttoolStripMenuItem.Name = "findnexttoolStripMenuItem";
            this.findnexttoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.findnexttoolStripMenuItem.Text = "Find next                            F3";
            // 
            // replacetoolStripMenuItem
            // 
            this.replacetoolStripMenuItem.Name = "replacetoolStripMenuItem";
            this.replacetoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.replacetoolStripMenuItem.Text = "Replace                              Ctrl+R";
            // 
            // multiplereplacetoolStripMenuItem
            // 
            this.multiplereplacetoolStripMenuItem.Name = "multiplereplacetoolStripMenuItem";
            this.multiplereplacetoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.multiplereplacetoolStripMenuItem.Text = "Multiple replace...";
            // 
            // gotosubtitlenumbertoolStripMenuItem
            // 
            this.gotosubtitlenumbertoolStripMenuItem.Name = "gotosubtitlenumbertoolStripMenuItem";
            this.gotosubtitlenumbertoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.gotosubtitlenumbertoolStripMenuItem.Text = "Go to subtitle number     Ctrl+G";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabPageSourceView
            // 
            this.tabPageSourceView.Controls.Add(this.textBoxSourceView);
            this.tabPageSourceView.Location = new System.Drawing.Point(4, 22);
            this.tabPageSourceView.Name = "tabPageSourceView";
            this.tabPageSourceView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSourceView.Size = new System.Drawing.Size(1002, 656);
            this.tabPageSourceView.TabIndex = 1;
            this.tabPageSourceView.Text = "Source view";
            this.tabPageSourceView.UseVisualStyleBackColor = true;
            // 
            // textBoxSourceView
            // 
            this.textBoxSourceView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSourceView.Location = new System.Drawing.Point(6, 6);
            this.textBoxSourceView.Multiline = true;
            this.textBoxSourceView.Name = "textBoxSourceView";
            this.textBoxSourceView.Size = new System.Drawing.Size(990, 644);
            this.textBoxSourceView.TabIndex = 0;
            // 
            // tabPageListView
            // 
            this.tabPageListView.Controls.Add(this.groupBox2);
            this.tabPageListView.Controls.Add(this.groupBoxPlayer);
            this.tabPageListView.Controls.Add(this.groupBoxEdit);
            this.tabPageListView.Controls.Add(this.groupBoxAdd);
            this.tabPageListView.Controls.Add(this.dataGridView);
            this.tabPageListView.Location = new System.Drawing.Point(4, 22);
            this.tabPageListView.Name = "tabPageListView";
            this.tabPageListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListView.Size = new System.Drawing.Size(1002, 656);
            this.tabPageListView.TabIndex = 0;
            this.tabPageListView.Text = "List view";
            this.tabPageListView.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.labelLocationsSubtitleLocationValue);
            this.groupBox2.Controls.Add(this.labelVideoLocationValue);
            this.groupBox2.Controls.Add(this.labelLocationsSubtitleLocation);
            this.groupBox2.Controls.Add(this.labelLocationsVideoLocation);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 589);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loactions";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(449, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 21);
            this.button2.TabIndex = 90;
            this.button2.Text = "Open in folder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 21);
            this.button1.TabIndex = 89;
            this.button1.Text = "Open in folder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelLocationsSubtitleLocationValue
            // 
            this.labelLocationsSubtitleLocationValue.AutoSize = true;
            this.labelLocationsSubtitleLocationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationsSubtitleLocationValue.Location = new System.Drawing.Point(6, 33);
            this.labelLocationsSubtitleLocationValue.MaximumSize = new System.Drawing.Size(240, 0);
            this.labelLocationsSubtitleLocationValue.Name = "labelLocationsSubtitleLocationValue";
            this.labelLocationsSubtitleLocationValue.Size = new System.Drawing.Size(234, 26);
            this.labelLocationsSubtitleLocationValue.TabIndex = 88;
            this.labelLocationsSubtitleLocationValue.Text = "C:\\Users\\Duje Srhoj\\Desktop\\New folder\\New folder";
            // 
            // labelVideoLocationValue
            // 
            this.labelVideoLocationValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVideoLocationValue.AutoSize = true;
            this.labelVideoLocationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVideoLocationValue.Location = new System.Drawing.Point(277, 33);
            this.labelVideoLocationValue.MaximumSize = new System.Drawing.Size(218, 0);
            this.labelVideoLocationValue.Name = "labelVideoLocationValue";
            this.labelVideoLocationValue.Size = new System.Drawing.Size(97, 13);
            this.labelVideoLocationValue.TabIndex = 87;
            this.labelVideoLocationValue.Text = "Video is not loaded";
            // 
            // labelLocationsSubtitleLocation
            // 
            this.labelLocationsSubtitleLocation.AutoSize = true;
            this.labelLocationsSubtitleLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationsSubtitleLocation.Location = new System.Drawing.Point(6, 20);
            this.labelLocationsSubtitleLocation.Name = "labelLocationsSubtitleLocation";
            this.labelLocationsSubtitleLocation.Size = new System.Drawing.Size(103, 13);
            this.labelLocationsSubtitleLocation.TabIndex = 86;
            this.labelLocationsSubtitleLocation.Text = "Subtitle location:";
            // 
            // labelLocationsVideoLocation
            // 
            this.labelLocationsVideoLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLocationsVideoLocation.AutoSize = true;
            this.labelLocationsVideoLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationsVideoLocation.Location = new System.Drawing.Point(277, 20);
            this.labelLocationsVideoLocation.Name = "labelLocationsVideoLocation";
            this.labelLocationsVideoLocation.Size = new System.Drawing.Size(92, 13);
            this.labelLocationsVideoLocation.TabIndex = 85;
            this.labelLocationsVideoLocation.Text = "Video location:";
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlayer.BackColor = System.Drawing.Color.Wheat;
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerLoadVideo);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerMoveCurrentTimeFor);
            this.groupBoxPlayer.Controls.Add(this.radioButtonPlayerBackward);
            this.groupBoxPlayer.Controls.Add(this.radioButtonPlayerForward);
            this.groupBoxPlayer.Controls.Add(this.maskedTextBoxPlayer);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayer5sForwards);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayer1sForwards);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayer025sForward);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayer025sBackward);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayer1sBackward);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayer5sBackward);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerPanel);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerVolDown);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerVolUp);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerMute);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerStop);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerPause);
            this.groupBoxPlayer.Controls.Add(this.buttonPlayerPlay);
            this.groupBoxPlayer.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBoxPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlayer.Location = new System.Drawing.Point(563, 310);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(433, 340);
            this.groupBoxPlayer.TabIndex = 2;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Player";
            // 
            // buttonPlayerLoadVideo
            // 
            this.buttonPlayerLoadVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerLoadVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerLoadVideo.Location = new System.Drawing.Point(355, 277);
            this.buttonPlayerLoadVideo.Name = "buttonPlayerLoadVideo";
            this.buttonPlayerLoadVideo.Size = new System.Drawing.Size(57, 50);
            this.buttonPlayerLoadVideo.TabIndex = 18;
            this.buttonPlayerLoadVideo.Text = "Load video";
            this.buttonPlayerLoadVideo.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerMoveCurrentTimeFor
            // 
            this.buttonPlayerMoveCurrentTimeFor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerMoveCurrentTimeFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerMoveCurrentTimeFor.Location = new System.Drawing.Point(232, 303);
            this.buttonPlayerMoveCurrentTimeFor.Name = "buttonPlayerMoveCurrentTimeFor";
            this.buttonPlayerMoveCurrentTimeFor.Size = new System.Drawing.Size(117, 24);
            this.buttonPlayerMoveCurrentTimeFor.TabIndex = 17;
            this.buttonPlayerMoveCurrentTimeFor.Text = "Move current time for";
            this.buttonPlayerMoveCurrentTimeFor.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlayerBackward
            // 
            this.radioButtonPlayerBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonPlayerBackward.AutoSize = true;
            this.radioButtonPlayerBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPlayerBackward.Location = new System.Drawing.Point(153, 306);
            this.radioButtonPlayerBackward.Name = "radioButtonPlayerBackward";
            this.radioButtonPlayerBackward.Size = new System.Drawing.Size(73, 17);
            this.radioButtonPlayerBackward.TabIndex = 16;
            this.radioButtonPlayerBackward.TabStop = true;
            this.radioButtonPlayerBackward.Text = "Backward";
            this.radioButtonPlayerBackward.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlayerForward
            // 
            this.radioButtonPlayerForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonPlayerForward.AutoSize = true;
            this.radioButtonPlayerForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPlayerForward.Location = new System.Drawing.Point(84, 307);
            this.radioButtonPlayerForward.Name = "radioButtonPlayerForward";
            this.radioButtonPlayerForward.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPlayerForward.TabIndex = 15;
            this.radioButtonPlayerForward.TabStop = true;
            this.radioButtonPlayerForward.Text = "Forward";
            this.radioButtonPlayerForward.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPlayer
            // 
            this.maskedTextBoxPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPlayer.Location = new System.Drawing.Point(7, 305);
            this.maskedTextBoxPlayer.Mask = "00:00:00.000";
            this.maskedTextBoxPlayer.Name = "maskedTextBoxPlayer";
            this.maskedTextBoxPlayer.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBoxPlayer.TabIndex = 14;
            // 
            // buttonPlayer5sForwards
            // 
            this.buttonPlayer5sForwards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayer5sForwards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer5sForwards.Location = new System.Drawing.Point(297, 276);
            this.buttonPlayer5sForwards.Name = "buttonPlayer5sForwards";
            this.buttonPlayer5sForwards.Size = new System.Drawing.Size(52, 23);
            this.buttonPlayer5sForwards.TabIndex = 13;
            this.buttonPlayer5sForwards.Text = "5s >";
            this.buttonPlayer5sForwards.UseVisualStyleBackColor = true;
            // 
            // buttonPlayer1sForwards
            // 
            this.buttonPlayer1sForwards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayer1sForwards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer1sForwards.Location = new System.Drawing.Point(239, 276);
            this.buttonPlayer1sForwards.Name = "buttonPlayer1sForwards";
            this.buttonPlayer1sForwards.Size = new System.Drawing.Size(52, 23);
            this.buttonPlayer1sForwards.TabIndex = 12;
            this.buttonPlayer1sForwards.Text = "1s >";
            this.buttonPlayer1sForwards.UseVisualStyleBackColor = true;
            // 
            // buttonPlayer025sForward
            // 
            this.buttonPlayer025sForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayer025sForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer025sForward.Location = new System.Drawing.Point(181, 276);
            this.buttonPlayer025sForward.Name = "buttonPlayer025sForward";
            this.buttonPlayer025sForward.Size = new System.Drawing.Size(52, 23);
            this.buttonPlayer025sForward.TabIndex = 11;
            this.buttonPlayer025sForward.Text = "0.25s >";
            this.buttonPlayer025sForward.UseVisualStyleBackColor = true;
            // 
            // buttonPlayer025sBackward
            // 
            this.buttonPlayer025sBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayer025sBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer025sBackward.Location = new System.Drawing.Point(123, 276);
            this.buttonPlayer025sBackward.Name = "buttonPlayer025sBackward";
            this.buttonPlayer025sBackward.Size = new System.Drawing.Size(52, 23);
            this.buttonPlayer025sBackward.TabIndex = 10;
            this.buttonPlayer025sBackward.Text = "< 0.25s";
            this.buttonPlayer025sBackward.UseVisualStyleBackColor = true;
            // 
            // buttonPlayer1sBackward
            // 
            this.buttonPlayer1sBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayer1sBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer1sBackward.Location = new System.Drawing.Point(65, 276);
            this.buttonPlayer1sBackward.Name = "buttonPlayer1sBackward";
            this.buttonPlayer1sBackward.Size = new System.Drawing.Size(52, 23);
            this.buttonPlayer1sBackward.TabIndex = 9;
            this.buttonPlayer1sBackward.Text = "< 1s";
            this.buttonPlayer1sBackward.UseVisualStyleBackColor = true;
            // 
            // buttonPlayer5sBackward
            // 
            this.buttonPlayer5sBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayer5sBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer5sBackward.Location = new System.Drawing.Point(7, 276);
            this.buttonPlayer5sBackward.Name = "buttonPlayer5sBackward";
            this.buttonPlayer5sBackward.Size = new System.Drawing.Size(52, 23);
            this.buttonPlayer5sBackward.TabIndex = 8;
            this.buttonPlayer5sBackward.Text = "< 5s";
            this.buttonPlayer5sBackward.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerPanel
            // 
            this.buttonPlayerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerPanel.Location = new System.Drawing.Point(340, 247);
            this.buttonPlayerPanel.Name = "buttonPlayerPanel";
            this.buttonPlayerPanel.Size = new System.Drawing.Size(72, 24);
            this.buttonPlayerPanel.TabIndex = 7;
            this.buttonPlayerPanel.Text = "Hide panel";
            this.buttonPlayerPanel.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerVolDown
            // 
            this.buttonPlayerVolDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerVolDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerVolDown.Location = new System.Drawing.Point(284, 247);
            this.buttonPlayerVolDown.Name = "buttonPlayerVolDown";
            this.buttonPlayerVolDown.Size = new System.Drawing.Size(50, 24);
            this.buttonPlayerVolDown.TabIndex = 6;
            this.buttonPlayerVolDown.Text = "Vol -";
            this.buttonPlayerVolDown.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerVolUp
            // 
            this.buttonPlayerVolUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerVolUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerVolUp.Location = new System.Drawing.Point(228, 247);
            this.buttonPlayerVolUp.Name = "buttonPlayerVolUp";
            this.buttonPlayerVolUp.Size = new System.Drawing.Size(50, 24);
            this.buttonPlayerVolUp.TabIndex = 5;
            this.buttonPlayerVolUp.Text = "Vol +";
            this.buttonPlayerVolUp.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerMute
            // 
            this.buttonPlayerMute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerMute.Location = new System.Drawing.Point(175, 247);
            this.buttonPlayerMute.Name = "buttonPlayerMute";
            this.buttonPlayerMute.Size = new System.Drawing.Size(50, 24);
            this.buttonPlayerMute.TabIndex = 4;
            this.buttonPlayerMute.Text = "Mute";
            this.buttonPlayerMute.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerStop
            // 
            this.buttonPlayerStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerStop.Location = new System.Drawing.Point(119, 247);
            this.buttonPlayerStop.Name = "buttonPlayerStop";
            this.buttonPlayerStop.Size = new System.Drawing.Size(50, 24);
            this.buttonPlayerStop.TabIndex = 3;
            this.buttonPlayerStop.Text = "Stop";
            this.buttonPlayerStop.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerPause
            // 
            this.buttonPlayerPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerPause.Location = new System.Drawing.Point(63, 247);
            this.buttonPlayerPause.Name = "buttonPlayerPause";
            this.buttonPlayerPause.Size = new System.Drawing.Size(50, 24);
            this.buttonPlayerPause.TabIndex = 2;
            this.buttonPlayerPause.Text = "Pause";
            this.buttonPlayerPause.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerPlay
            // 
            this.buttonPlayerPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayerPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerPlay.Location = new System.Drawing.Point(7, 247);
            this.buttonPlayerPlay.Name = "buttonPlayerPlay";
            this.buttonPlayerPlay.Size = new System.Drawing.Size(50, 24);
            this.buttonPlayerPlay.TabIndex = 1;
            this.buttonPlayerPlay.Text = "Play";
            this.buttonPlayerPlay.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(7, 24);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(384, 216);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEdit.BackColor = System.Drawing.Color.MistyRose;
            this.groupBoxEdit.Controls.Add(this.buttonEditingUndoChanges);
            this.groupBoxEdit.Controls.Add(this.buttonEditingSaveChanges);
            this.groupBoxEdit.Controls.Add(this.buttonEditingUnbreak);
            this.groupBoxEdit.Controls.Add(this.label11);
            this.groupBoxEdit.Controls.Add(this.label12);
            this.groupBoxEdit.Controls.Add(this.labelEditingText);
            this.groupBoxEdit.Controls.Add(this.textBoxEditing);
            this.groupBoxEdit.Controls.Add(this.buttonEditingAutobr);
            this.groupBoxEdit.Controls.Add(this.buttonEditingNext);
            this.groupBoxEdit.Controls.Add(this.buttonEditingPrev);
            this.groupBoxEdit.Controls.Add(this.buttonEditingPickCurrentEndTime);
            this.groupBoxEdit.Controls.Add(this.buttonEditingPickCurrentStartTime);
            this.groupBoxEdit.Controls.Add(this.labelEditingDurationValue);
            this.groupBoxEdit.Controls.Add(this.maskedTextBoxEditingEndTime);
            this.groupBoxEdit.Controls.Add(this.maskedTextBoxEditingStartTime);
            this.groupBoxEdit.Controls.Add(this.labelEditingEndTime);
            this.groupBoxEdit.Controls.Add(this.labelEditingDuration);
            this.groupBoxEdit.Controls.Add(this.labelEditingStartTime);
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit.Location = new System.Drawing.Point(7, 175);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(989, 129);
            this.groupBoxEdit.TabIndex = 1;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // buttonEditingUndoChanges
            // 
            this.buttonEditingUndoChanges.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEditingUndoChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditingUndoChanges.Location = new System.Drawing.Point(840, 64);
            this.buttonEditingUndoChanges.Name = "buttonEditingUndoChanges";
            this.buttonEditingUndoChanges.Size = new System.Drawing.Size(143, 21);
            this.buttonEditingUndoChanges.TabIndex = 17;
            this.buttonEditingUndoChanges.Text = "Undo changes";
            this.buttonEditingUndoChanges.UseVisualStyleBackColor = true;
            // 
            // buttonEditingSaveChanges
            // 
            this.buttonEditingSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEditingSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditingSaveChanges.Location = new System.Drawing.Point(840, 89);
            this.buttonEditingSaveChanges.Name = "buttonEditingSaveChanges";
            this.buttonEditingSaveChanges.Size = new System.Drawing.Size(143, 21);
            this.buttonEditingSaveChanges.TabIndex = 18;
            this.buttonEditingSaveChanges.Text = "Save changes";
            this.buttonEditingSaveChanges.UseVisualStyleBackColor = true;
            // 
            // buttonEditingUnbreak
            // 
            this.buttonEditingUnbreak.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEditingUnbreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditingUnbreak.Location = new System.Drawing.Point(840, 40);
            this.buttonEditingUnbreak.Name = "buttonEditingUnbreak";
            this.buttonEditingUnbreak.Size = new System.Drawing.Size(143, 21);
            this.buttonEditingUnbreak.TabIndex = 16;
            this.buttonEditingUnbreak.Text = "Unbreak";
            this.buttonEditingUnbreak.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(771, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total lenght:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(257, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Single line lenght:";
            // 
            // labelEditingText
            // 
            this.labelEditingText.AutoSize = true;
            this.labelEditingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditingText.Location = new System.Drawing.Point(257, 24);
            this.labelEditingText.Name = "labelEditingText";
            this.labelEditingText.Size = new System.Drawing.Size(28, 13);
            this.labelEditingText.TabIndex = 13;
            this.labelEditingText.Text = "Text";
            // 
            // textBoxEditing
            // 
            this.textBoxEditing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditing.Location = new System.Drawing.Point(260, 40);
            this.textBoxEditing.Multiline = true;
            this.textBoxEditing.Name = "textBoxEditing";
            this.textBoxEditing.Size = new System.Drawing.Size(574, 70);
            this.textBoxEditing.TabIndex = 12;
            // 
            // buttonEditingAutobr
            // 
            this.buttonEditingAutobr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditingAutobr.Location = new System.Drawing.Point(162, 97);
            this.buttonEditingAutobr.Name = "buttonEditingAutobr";
            this.buttonEditingAutobr.Size = new System.Drawing.Size(67, 23);
            this.buttonEditingAutobr.TabIndex = 11;
            this.buttonEditingAutobr.Text = "Auto br";
            this.buttonEditingAutobr.UseVisualStyleBackColor = true;
            // 
            // buttonEditingNext
            // 
            this.buttonEditingNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditingNext.Location = new System.Drawing.Point(86, 97);
            this.buttonEditingNext.Name = "buttonEditingNext";
            this.buttonEditingNext.Size = new System.Drawing.Size(67, 23);
            this.buttonEditingNext.TabIndex = 10;
            this.buttonEditingNext.Text = "Next >";
            this.buttonEditingNext.UseVisualStyleBackColor = true;
            // 
            // buttonEditingPrev
            // 
            this.buttonEditingPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditingPrev.Location = new System.Drawing.Point(10, 97);
            this.buttonEditingPrev.Name = "buttonEditingPrev";
            this.buttonEditingPrev.Size = new System.Drawing.Size(67, 23);
            this.buttonEditingPrev.TabIndex = 9;
            this.buttonEditingPrev.Text = "< Prev";
            this.buttonEditingPrev.UseVisualStyleBackColor = true;
            // 
            // buttonEditingPickCurrentEndTime
            // 
            this.buttonEditingPickCurrentEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditingPickCurrentEndTime.Location = new System.Drawing.Point(162, 66);
            this.buttonEditingPickCurrentEndTime.Name = "buttonEditingPickCurrentEndTime";
            this.buttonEditingPickCurrentEndTime.Size = new System.Drawing.Size(75, 23);
            this.buttonEditingPickCurrentEndTime.TabIndex = 8;
            this.buttonEditingPickCurrentEndTime.Text = "Pick current";
            this.buttonEditingPickCurrentEndTime.UseVisualStyleBackColor = true;
            // 
            // buttonEditingPickCurrentStartTime
            // 
            this.buttonEditingPickCurrentStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditingPickCurrentStartTime.Location = new System.Drawing.Point(10, 67);
            this.buttonEditingPickCurrentStartTime.Name = "buttonEditingPickCurrentStartTime";
            this.buttonEditingPickCurrentStartTime.Size = new System.Drawing.Size(75, 23);
            this.buttonEditingPickCurrentStartTime.TabIndex = 7;
            this.buttonEditingPickCurrentStartTime.Text = "Pick current";
            this.buttonEditingPickCurrentStartTime.UseVisualStyleBackColor = true;
            // 
            // labelEditingDurationValue
            // 
            this.labelEditingDurationValue.AutoSize = true;
            this.labelEditingDurationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditingDurationValue.Location = new System.Drawing.Point(83, 43);
            this.labelEditingDurationValue.Name = "labelEditingDurationValue";
            this.labelEditingDurationValue.Size = new System.Drawing.Size(70, 13);
            this.labelEditingDurationValue.TabIndex = 6;
            this.labelEditingDurationValue.Text = "00:00:00.000";
            // 
            // maskedTextBoxEditingEndTime
            // 
            this.maskedTextBoxEditingEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxEditingEndTime.Location = new System.Drawing.Point(162, 40);
            this.maskedTextBoxEditingEndTime.Mask = "00:00:00.000";
            this.maskedTextBoxEditingEndTime.Name = "maskedTextBoxEditingEndTime";
            this.maskedTextBoxEditingEndTime.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBoxEditingEndTime.TabIndex = 5;
            // 
            // maskedTextBoxEditingStartTime
            // 
            this.maskedTextBoxEditingStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxEditingStartTime.Location = new System.Drawing.Point(10, 40);
            this.maskedTextBoxEditingStartTime.Mask = "00:00:00.000";
            this.maskedTextBoxEditingStartTime.Name = "maskedTextBoxEditingStartTime";
            this.maskedTextBoxEditingStartTime.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxEditingStartTime.TabIndex = 4;
            // 
            // labelEditingEndTime
            // 
            this.labelEditingEndTime.AutoSize = true;
            this.labelEditingEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditingEndTime.Location = new System.Drawing.Point(159, 24);
            this.labelEditingEndTime.Name = "labelEditingEndTime";
            this.labelEditingEndTime.Size = new System.Drawing.Size(48, 13);
            this.labelEditingEndTime.TabIndex = 2;
            this.labelEditingEndTime.Text = "End time";
            // 
            // labelEditingDuration
            // 
            this.labelEditingDuration.AutoSize = true;
            this.labelEditingDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditingDuration.Location = new System.Drawing.Point(83, 24);
            this.labelEditingDuration.Name = "labelEditingDuration";
            this.labelEditingDuration.Size = new System.Drawing.Size(47, 13);
            this.labelEditingDuration.TabIndex = 1;
            this.labelEditingDuration.Text = "Duration";
            // 
            // labelEditingStartTime
            // 
            this.labelEditingStartTime.AutoSize = true;
            this.labelEditingStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditingStartTime.Location = new System.Drawing.Point(7, 24);
            this.labelEditingStartTime.Name = "labelEditingStartTime";
            this.labelEditingStartTime.Size = new System.Drawing.Size(51, 13);
            this.labelEditingStartTime.TabIndex = 0;
            this.labelEditingStartTime.Text = "Start time";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxAdd.Controls.Add(this.buttonAddOpenSRT);
            this.groupBoxAdd.Controls.Add(this.buttonAddAddSubtitle);
            this.groupBoxAdd.Controls.Add(this.labelAddText);
            this.groupBoxAdd.Controls.Add(this.textBoxAdd);
            this.groupBoxAdd.Controls.Add(this.buttonAddPickCurrentEndTime);
            this.groupBoxAdd.Controls.Add(this.buttonAddPickCurrentStartTime);
            this.groupBoxAdd.Controls.Add(this.labelAddDurationValue);
            this.groupBoxAdd.Controls.Add(this.maskedTextBoxAddEndTime);
            this.groupBoxAdd.Controls.Add(this.maskedTextBoxAddStartTime);
            this.groupBoxAdd.Controls.Add(this.labelAddEndTime);
            this.groupBoxAdd.Controls.Add(this.labelAddDuration);
            this.groupBoxAdd.Controls.Add(this.labelAddStartTime);
            this.groupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdd.Location = new System.Drawing.Point(7, 310);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(550, 276);
            this.groupBoxAdd.TabIndex = 3;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add";
            // 
            // buttonAddOpenSRT
            // 
            this.buttonAddOpenSRT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOpenSRT.Location = new System.Drawing.Point(392, 218);
            this.buttonAddOpenSRT.Name = "buttonAddOpenSRT";
            this.buttonAddOpenSRT.Size = new System.Drawing.Size(146, 53);
            this.buttonAddOpenSRT.TabIndex = 84;
            this.buttonAddOpenSRT.Text = "Open (.srt)";
            this.buttonAddOpenSRT.UseVisualStyleBackColor = true;
            // 
            // buttonAddAddSubtitle
            // 
            this.buttonAddAddSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddAddSubtitle.Location = new System.Drawing.Point(10, 218);
            this.buttonAddAddSubtitle.Name = "buttonAddAddSubtitle";
            this.buttonAddAddSubtitle.Size = new System.Drawing.Size(146, 53);
            this.buttonAddAddSubtitle.TabIndex = 83;
            this.buttonAddAddSubtitle.Text = "Add subtitle";
            this.buttonAddAddSubtitle.UseVisualStyleBackColor = true;
            // 
            // labelAddText
            // 
            this.labelAddText.AutoSize = true;
            this.labelAddText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddText.Location = new System.Drawing.Point(7, 122);
            this.labelAddText.Name = "labelAddText";
            this.labelAddText.Size = new System.Drawing.Size(36, 18);
            this.labelAddText.TabIndex = 18;
            this.labelAddText.Text = "Text";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdd.Location = new System.Drawing.Point(10, 143);
            this.textBoxAdd.Multiline = true;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(528, 70);
            this.textBoxAdd.TabIndex = 17;
            // 
            // buttonAddPickCurrentEndTime
            // 
            this.buttonAddPickCurrentEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPickCurrentEndTime.Location = new System.Drawing.Point(222, 75);
            this.buttonAddPickCurrentEndTime.Name = "buttonAddPickCurrentEndTime";
            this.buttonAddPickCurrentEndTime.Size = new System.Drawing.Size(89, 44);
            this.buttonAddPickCurrentEndTime.TabIndex = 16;
            this.buttonAddPickCurrentEndTime.Text = "Pick current";
            this.buttonAddPickCurrentEndTime.UseVisualStyleBackColor = true;
            // 
            // buttonAddPickCurrentStartTime
            // 
            this.buttonAddPickCurrentStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPickCurrentStartTime.Location = new System.Drawing.Point(10, 75);
            this.buttonAddPickCurrentStartTime.Name = "buttonAddPickCurrentStartTime";
            this.buttonAddPickCurrentStartTime.Size = new System.Drawing.Size(89, 44);
            this.buttonAddPickCurrentStartTime.TabIndex = 15;
            this.buttonAddPickCurrentStartTime.Text = "Pick current";
            this.buttonAddPickCurrentStartTime.UseVisualStyleBackColor = true;
            // 
            // labelAddDurationValue
            // 
            this.labelAddDurationValue.AutoSize = true;
            this.labelAddDurationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddDurationValue.Location = new System.Drawing.Point(113, 48);
            this.labelAddDurationValue.Name = "labelAddDurationValue";
            this.labelAddDurationValue.Size = new System.Drawing.Size(92, 18);
            this.labelAddDurationValue.TabIndex = 14;
            this.labelAddDurationValue.Text = "00:00:00.000";
            // 
            // maskedTextBoxAddEndTime
            // 
            this.maskedTextBoxAddEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxAddEndTime.Location = new System.Drawing.Point(222, 45);
            this.maskedTextBoxAddEndTime.Mask = "00:00:00.000";
            this.maskedTextBoxAddEndTime.Name = "maskedTextBoxAddEndTime";
            this.maskedTextBoxAddEndTime.Size = new System.Drawing.Size(89, 24);
            this.maskedTextBoxAddEndTime.TabIndex = 13;
            // 
            // maskedTextBoxAddStartTime
            // 
            this.maskedTextBoxAddStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxAddStartTime.Location = new System.Drawing.Point(10, 45);
            this.maskedTextBoxAddStartTime.Mask = "00:00:00.000";
            this.maskedTextBoxAddStartTime.Name = "maskedTextBoxAddStartTime";
            this.maskedTextBoxAddStartTime.Size = new System.Drawing.Size(89, 24);
            this.maskedTextBoxAddStartTime.TabIndex = 12;
            // 
            // labelAddEndTime
            // 
            this.labelAddEndTime.AutoSize = true;
            this.labelAddEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddEndTime.Location = new System.Drawing.Point(219, 24);
            this.labelAddEndTime.Name = "labelAddEndTime";
            this.labelAddEndTime.Size = new System.Drawing.Size(66, 18);
            this.labelAddEndTime.TabIndex = 11;
            this.labelAddEndTime.Text = "End time";
            // 
            // labelAddDuration
            // 
            this.labelAddDuration.AutoSize = true;
            this.labelAddDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddDuration.Location = new System.Drawing.Point(113, 24);
            this.labelAddDuration.Name = "labelAddDuration";
            this.labelAddDuration.Size = new System.Drawing.Size(64, 18);
            this.labelAddDuration.TabIndex = 10;
            this.labelAddDuration.Text = "Duration";
            // 
            // labelAddStartTime
            // 
            this.labelAddStartTime.AutoSize = true;
            this.labelAddStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddStartTime.Location = new System.Drawing.Point(7, 24);
            this.labelAddStartTime.Name = "labelAddStartTime";
            this.labelAddStartTime.Size = new System.Drawing.Size(71, 18);
            this.labelAddStartTime.TabIndex = 9;
            this.labelAddStartTime.Text = "Start time";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView.Location = new System.Drawing.Point(7, 7);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(989, 161);
            this.dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Start time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "End time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Text";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageListView);
            this.tabControl.Controls.Add(this.tabPageSourceView);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1010, 682);
            this.tabControl.TabIndex = 2;
            this.tabControl.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 721);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1050, 760);
            this.Name = "Form1";
            this.Text = "Subtitle editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageSourceView.ResumeLayout(false);
            this.tabPageSourceView.PerformLayout();
            this.tabPageListView.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undotoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem findtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findnexttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplereplacetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotosubtitlenumbertoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageSourceView;
        private System.Windows.Forms.TabPage tabPageListView;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Button buttonPlayer5sForwards;
        private System.Windows.Forms.Button buttonPlayer1sForwards;
        private System.Windows.Forms.Button buttonPlayer025sForward;
        private System.Windows.Forms.Button buttonPlayer025sBackward;
        private System.Windows.Forms.Button buttonPlayer1sBackward;
        private System.Windows.Forms.Button buttonPlayer5sBackward;
        private System.Windows.Forms.Button buttonPlayerPanel;
        private System.Windows.Forms.Button buttonPlayerVolDown;
        private System.Windows.Forms.Button buttonPlayerVolUp;
        private System.Windows.Forms.Button buttonPlayerMute;
        private System.Windows.Forms.Button buttonPlayerStop;
        private System.Windows.Forms.Button buttonPlayerPause;
        private System.Windows.Forms.Button buttonPlayerPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonEditingUndoChanges;
        private System.Windows.Forms.Button buttonEditingSaveChanges;
        private System.Windows.Forms.Button buttonEditingUnbreak;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelEditingText;
        private System.Windows.Forms.TextBox textBoxEditing;
        private System.Windows.Forms.Button buttonEditingAutobr;
        private System.Windows.Forms.Button buttonEditingNext;
        private System.Windows.Forms.Button buttonEditingPrev;
        private System.Windows.Forms.Button buttonEditingPickCurrentEndTime;
        private System.Windows.Forms.Button buttonEditingPickCurrentStartTime;
        private System.Windows.Forms.Label labelEditingDurationValue;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEditingEndTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEditingStartTime;
        private System.Windows.Forms.Label labelEditingEndTime;
        private System.Windows.Forms.Label labelEditingDuration;
        private System.Windows.Forms.Label labelEditingStartTime;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonAddPickCurrentEndTime;
        private System.Windows.Forms.Button buttonAddPickCurrentStartTime;
        private System.Windows.Forms.Label labelAddDurationValue;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAddEndTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAddStartTime;
        private System.Windows.Forms.Label labelAddEndTime;
        private System.Windows.Forms.Label labelAddDuration;
        private System.Windows.Forms.Label labelAddStartTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPlayerLoadVideo;
        private System.Windows.Forms.Button buttonPlayerMoveCurrentTimeFor;
        private System.Windows.Forms.Button buttonAddOpenSRT;
        private System.Windows.Forms.Button buttonAddAddSubtitle;
        private System.Windows.Forms.Label labelAddText;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Label labelLocationsSubtitleLocation;
        private System.Windows.Forms.Label labelLocationsVideoLocation;
        private System.Windows.Forms.TextBox textBoxSourceView;
        private System.Windows.Forms.Label labelLocationsSubtitleLocationValue;
        private System.Windows.Forms.Label labelVideoLocationValue;
        private System.Windows.Forms.RadioButton radioButtonPlayerBackward;
        private System.Windows.Forms.RadioButton radioButtonPlayerForward;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loadVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

