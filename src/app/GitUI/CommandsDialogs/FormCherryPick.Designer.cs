namespace GitUI.CommandsDialogs;

partial class FormCherryPick
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
        if (disposing && (components is not null))
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
        btnPick = new Button();
        btnAbort = new Button();
        btnChooseRevision = new Button();
        lblParents = new Label();
        lvParentsList = new UserControls.NativeListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        cbxAddReference = new CheckBox();
        cbxAutoCommit = new CheckBox();
        lblBranchInfo = new Label();
        commitSummaryUserControl1 = new UserControls.CommitSummaryUserControl();
        tlPnlMain = new TableLayoutPanel();
        chooseRevPanel = new FlowLayoutPanel();
        lblAnotherRev = new Label();
        localChangesGB = new GroupBox();
        flpnlLocalOptions = new FlowLayoutPanel();
        rbDontChange = new RadioButton();
        rbMerge = new RadioButton();
        rbStash = new RadioButton();
        rbReset = new RadioButton();
        chkSetLocalChangesActionAsDefault = new CheckBox();
        MainPanel.SuspendLayout();
        ControlsPanel.SuspendLayout();
        tlPnlMain.SuspendLayout();
        chooseRevPanel.SuspendLayout();
        localChangesGB.SuspendLayout();
        flpnlLocalOptions.SuspendLayout();
        SuspendLayout();
        // 
        // MainPanel
        // 
        MainPanel.AutoSize = true;
        MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        MainPanel.Controls.Add(tlPnlMain);
        MainPanel.Size = new Size(614, 372);
        MainPanel.TabIndex = 0;
        // 
        // ControlsPanel
        // 
        ControlsPanel.Controls.Add(btnAbort);
        ControlsPanel.Controls.Add(btnPick);
        ControlsPanel.Location = new Point(0, 372);
        ControlsPanel.Size = new Size(614, 41);
        ControlsPanel.TabIndex = 1;
        // 
        // btnPick
        // 
        btnPick.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnPick.Location = new Point(411, 8);
        btnPick.Name = "btnPick";
        btnPick.Size = new Size(109, 25);
        btnPick.TabIndex = 0;
        btnPick.Text = "&Cherry pick";
        btnPick.UseVisualStyleBackColor = true;
        btnPick.Click += btnPick_Click;
        // 
        // btnAbort
        // 
        btnAbort.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnAbort.Location = new Point(526, 8);
        btnAbort.Name = "btnAbort";
        btnAbort.Size = new Size(75, 25);
        btnAbort.TabIndex = 1;
        btnAbort.Text = "A&bort";
        btnAbort.UseVisualStyleBackColor = true;
        btnAbort.Click += btnAbort_Click;
        // 
        // btnChooseRevision
        // 
        btnChooseRevision.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnChooseRevision.Image = Properties.Images.SelectRevision;
        btnChooseRevision.Location = new Point(556, 3);
        btnChooseRevision.Name = "btnChooseRevision";
        btnChooseRevision.Size = new Size(25, 24);
        btnChooseRevision.TabIndex = 5;
        btnChooseRevision.UseVisualStyleBackColor = true;
        btnChooseRevision.Click += btnChooseRevision_Click;
        // 
        // lblParents
        // 
        lblParents.AutoSize = true;
        lblParents.Dock = DockStyle.Fill;
        lblParents.Location = new Point(3, 217);
        lblParents.Name = "lblParents";
        lblParents.Size = new Size(584, 15);
        lblParents.TabIndex = 6;
        lblParents.Text = "This commit is a merge, select &parent:";
        // 
        // lvParentsList
        // 
        lvParentsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
        lvParentsList.Dock = DockStyle.Fill;
        lvParentsList.FullRowSelect = true;
        lvParentsList.Location = new Point(6, 238);
        lvParentsList.Margin = new Padding(6);
        lvParentsList.MultiSelect = false;
        lvParentsList.Name = "lvParentsList";
        lvParentsList.Size = new Size(578, 54);
        lvParentsList.TabIndex = 7;
        lvParentsList.UseCompatibleStateImageBehavior = false;
        lvParentsList.View = View.Details;
        lvParentsList.Resize += lvParentsList_Resize;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "No.";
        columnHeader1.Width = 43;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Message";
        columnHeader2.Width = 291;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Author";
        columnHeader3.Width = 120;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "Date";
        columnHeader4.Width = 80;
        // 
        // cbxAddReference
        // 
        cbxAddReference.AutoSize = true;
        cbxAddReference.Dock = DockStyle.Fill;
        cbxAddReference.Location = new Point(3, 326);
        cbxAddReference.Name = "cbxAddReference";
        cbxAddReference.Size = new Size(584, 19);
        cbxAddReference.TabIndex = 9;
        cbxAddReference.Text = "A&dd commit reference to commit message";
        cbxAddReference.UseVisualStyleBackColor = true;
        // 
        // localChangesGB
        // 
        localChangesGB.Controls.Add(flpnlLocalOptions);
        localChangesGB.Dock = DockStyle.Fill;
        localChangesGB.Location = new Point(3, 351);
        localChangesGB.Name = "localChangesGB";
        localChangesGB.Size = new Size(584, 58);
        localChangesGB.TabIndex = 10;
        localChangesGB.TabStop = false;
        localChangesGB.Text = "Local changes";
        // 
        // flpnlLocalOptions
        // 
        flpnlLocalOptions.AutoSize = true;
        flpnlLocalOptions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpnlLocalOptions.Controls.Add(rbDontChange);
        flpnlLocalOptions.Controls.Add(rbMerge);
        flpnlLocalOptions.Controls.Add(rbStash);
        flpnlLocalOptions.Controls.Add(rbReset);
        flpnlLocalOptions.Controls.Add(chkSetLocalChangesActionAsDefault);
        flpnlLocalOptions.Dock = DockStyle.Fill;
        flpnlLocalOptions.Location = new Point(3, 19);
        flpnlLocalOptions.Name = "flpnlLocalOptions";
        flpnlLocalOptions.Padding = new Padding(9, 4, 9, 4);
        flpnlLocalOptions.Size = new Size(578, 36);
        flpnlLocalOptions.TabIndex = 0;
        flpnlLocalOptions.WrapContents = false;
        // 
        // rbDontChange
        // 
        rbDontChange.AutoSize = true;
        rbDontChange.Checked = true;
        rbDontChange.Location = new Point(11, 6);
        rbDontChange.Margin = new Padding(2);
        rbDontChange.Name = "rbDontChange";
        rbDontChange.Size = new Size(96, 21);
        rbDontChange.TabIndex = 0;
        rbDontChange.TabStop = true;
        rbDontChange.Text = "Do&n\'t change";
        rbDontChange.UseVisualStyleBackColor = true;
        // 
        // rbMerge
        // 
        rbMerge.AutoSize = true;
        rbMerge.Location = new Point(111, 6);
        rbMerge.Margin = new Padding(2);
        rbMerge.Name = "rbMerge";
        rbMerge.Size = new Size(59, 21);
        rbMerge.TabIndex = 1;
        rbMerge.TabStop = true;
        rbMerge.Text = "&Merge";
        rbMerge.UseVisualStyleBackColor = true;
        // 
        // rbStash
        // 
        rbStash.AutoSize = true;
        rbStash.Location = new Point(174, 6);
        rbStash.Margin = new Padding(2);
        rbStash.Name = "rbStash";
        rbStash.Size = new Size(53, 21);
        rbStash.TabIndex = 2;
        rbStash.TabStop = true;
        rbStash.Text = "S&tash";
        rbStash.UseVisualStyleBackColor = true;
        // 
        // rbReset
        // 
        rbReset.AutoSize = true;
        rbReset.Location = new Point(231, 6);
        rbReset.Margin = new Padding(2);
        rbReset.Name = "rbReset";
        rbReset.Size = new Size(53, 21);
        rbReset.TabIndex = 3;
        rbReset.TabStop = true;
        rbReset.Text = "&Reset";
        rbReset.UseVisualStyleBackColor = true;
        rbReset.CheckedChanged += rbReset_CheckedChanged;
        // 
        // chkSetLocalChangesActionAsDefault
        // 
        chkSetLocalChangesActionAsDefault.AutoSize = true;
        chkSetLocalChangesActionAsDefault.Location = new Point(289, 7);
        chkSetLocalChangesActionAsDefault.Name = "chkSetLocalChangesActionAsDefault";
        chkSetLocalChangesActionAsDefault.Size = new Size(96, 19);
        chkSetLocalChangesActionAsDefault.TabIndex = 4;
        chkSetLocalChangesActionAsDefault.Text = "Set as &default";
        chkSetLocalChangesActionAsDefault.UseVisualStyleBackColor = true;
        // 
        // cbxAutoCommit
        // 
        cbxAutoCommit.AutoSize = true;
        cbxAutoCommit.Dock = DockStyle.Fill;
        cbxAutoCommit.Location = new Point(3, 301);
        cbxAutoCommit.Name = "cbxAutoCommit";
        cbxAutoCommit.Size = new Size(584, 19);
        cbxAutoCommit.TabIndex = 8;
        cbxAutoCommit.Text = "&Automatically create a commit";
        cbxAutoCommit.UseVisualStyleBackColor = true;
        // 
        // lblBranchInfo
        // 
        lblBranchInfo.AutoSize = true;
        lblBranchInfo.Dock = DockStyle.Fill;
        lblBranchInfo.Location = new Point(3, 0);
        lblBranchInfo.Name = "lblBranchInfo";
        lblBranchInfo.Size = new Size(584, 15);
        lblBranchInfo.TabIndex = 1;
        lblBranchInfo.Text = "Cherry pick this commit:";
        // 
        // commitSummaryUserControl1
        // 
        commitSummaryUserControl1.AutoSize = true;
        commitSummaryUserControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        commitSummaryUserControl1.Dock = DockStyle.Fill;
        commitSummaryUserControl1.Location = new Point(16, 18);
        commitSummaryUserControl1.Margin = new Padding(16, 3, 3, 3);
        commitSummaryUserControl1.MinimumSize = new Size(440, 160);
        commitSummaryUserControl1.Name = "commitSummaryUserControl1";
        commitSummaryUserControl1.Revision = null;
        commitSummaryUserControl1.Size = new Size(571, 160);
        commitSummaryUserControl1.TabIndex = 2;
        commitSummaryUserControl1.TabStop = false;
        // 
        // tlPnlMain
        // 
        tlPnlMain.AutoSize = true;
        tlPnlMain.ColumnCount = 1;
        tlPnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlPnlMain.Controls.Add(lblBranchInfo, 0, 0);
        tlPnlMain.Controls.Add(commitSummaryUserControl1, 0, 1);
        tlPnlMain.Controls.Add(chooseRevPanel, 0, 2);
        tlPnlMain.Controls.Add(lblParents, 0, 3);
        tlPnlMain.Controls.Add(lvParentsList, 0, 4);
        tlPnlMain.Controls.Add(cbxAutoCommit, 0, 5);
        tlPnlMain.Controls.Add(cbxAddReference, 0, 6);
        tlPnlMain.Controls.Add(localChangesGB, 0, 7);
        tlPnlMain.Dock = DockStyle.Fill;
        tlPnlMain.Location = new Point(12, 12);
        tlPnlMain.Margin = new Padding(0);
        tlPnlMain.Name = "tlPnlMain";
        tlPnlMain.RowCount = 8;
        tlPnlMain.RowStyles.Add(new RowStyle());
        tlPnlMain.RowStyles.Add(new RowStyle());
        tlPnlMain.RowStyles.Add(new RowStyle());
        tlPnlMain.RowStyles.Add(new RowStyle());
        tlPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlPnlMain.RowStyles.Add(new RowStyle());
        tlPnlMain.RowStyles.Add(new RowStyle());
        tlPnlMain.RowStyles.Add(new RowStyle());
        tlPnlMain.Size = new Size(590, 412);
        tlPnlMain.TabIndex = 0;
        // 
        // chooseRevPanel
        // 
        chooseRevPanel.AutoSize = true;
        chooseRevPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        chooseRevPanel.Controls.Add(btnChooseRevision);
        chooseRevPanel.Controls.Add(lblAnotherRev);
        chooseRevPanel.Dock = DockStyle.Fill;
        chooseRevPanel.FlowDirection = FlowDirection.RightToLeft;
        chooseRevPanel.Location = new Point(3, 184);
        chooseRevPanel.Name = "chooseRevPanel";
        chooseRevPanel.Size = new Size(584, 30);
        chooseRevPanel.TabIndex = 3;
        // 
        // lblAnotherRev
        // 
        lblAnotherRev.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblAnotherRev.AutoSize = true;
        lblAnotherRev.Location = new Point(412, 0);
        lblAnotherRev.Name = "lblAnotherRev";
        lblAnotherRev.Size = new Size(138, 30);
        lblAnotherRev.TabIndex = 4;
        lblAnotherRev.Text = "C&hoose another revision:";
        lblAnotherRev.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FormCherryPick
        // 
        AcceptButton = btnPick;
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSize = true;
        CancelButton = btnAbort;
        ClientSize = new Size(614, 413);
        HelpButton = true;
        ManualSectionAnchorName = "cherry-pick-commit";
        ManualSectionSubfolder = "modify_history";
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new Size(630, 370);
        Name = "FormCherryPick";
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cherry pick commit";
        FormClosing += Form_Closing;
        Load += Form_Load;
        Shown += Form_Shown;
        MainPanel.ResumeLayout(false);
        MainPanel.PerformLayout();
        ControlsPanel.ResumeLayout(false);
        tlPnlMain.ResumeLayout(false);
        tlPnlMain.PerformLayout();
        chooseRevPanel.ResumeLayout(false);
        chooseRevPanel.PerformLayout();
        localChangesGB.ResumeLayout(false);
        localChangesGB.PerformLayout();
        flpnlLocalOptions.ResumeLayout(false);
        flpnlLocalOptions.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblBranchInfo;
    private Label lblAnotherRev;
    private Button btnPick;
    private Button btnAbort;
    private CheckBox cbxAutoCommit;
    private Label lblParents;
    private UserControls.NativeListView lvParentsList;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private CheckBox cbxAddReference;
    private GitUI.UserControls.CommitSummaryUserControl commitSummaryUserControl1;
    private Button btnChooseRevision;
    private TableLayoutPanel tlPnlMain;
    private FlowLayoutPanel chooseRevPanel;
    private GroupBox localChangesGB;
    private FlowLayoutPanel flpnlLocalOptions;
    private RadioButton rbDontChange;
    private RadioButton rbMerge;
    private RadioButton rbStash;
    private RadioButton rbReset;
    private CheckBox chkSetLocalChangesActionAsDefault;
}
