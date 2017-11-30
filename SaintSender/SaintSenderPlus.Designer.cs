namespace SaintSender
{
    partial class SaintSenderPlus
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
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.htmlPlainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MailsPanel = new System.Windows.Forms.Panel();
            this.MessagesListView = new BrightIdeasSoftware.ObjectListView();
            this.FromColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SubjectColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SnippetColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LabelsPanel = new System.Windows.Forms.Panel();
            this.LabelsListView = new BrightIdeasSoftware.ObjectListView();
            this.LabelColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BodyWebBrowser = new System.Windows.Forms.WebBrowser();
            this.MessageViewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DetailsViewRadioButton = new System.Windows.Forms.RadioButton();
            this.TileViewRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BodyHeaderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TopMenuStrip.SuspendLayout();
            this.MailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesListView)).BeginInit();
            this.LabelsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelsListView)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htmlPlainTextToolStripMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.TopMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopMenuStrip.Size = new System.Drawing.Size(1584, 24);
            this.TopMenuStrip.TabIndex = 7;
            this.TopMenuStrip.Text = "menuStrip1";
            // 
            // htmlPlainTextToolStripMenuItem
            // 
            this.htmlPlainTextToolStripMenuItem.Name = "htmlPlainTextToolStripMenuItem";
            this.htmlPlainTextToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.htmlPlainTextToolStripMenuItem.Text = "Html/Plain Text";
            this.htmlPlainTextToolStripMenuItem.Click += new System.EventHandler(this.htmlPlainTextToolStripMenuItem_Click);
            // 
            // MailsPanel
            // 
            this.MailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MailsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MailsPanel.Controls.Add(this.MessagesListView);
            this.MailsPanel.Location = new System.Drawing.Point(111, 25);
            this.MailsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MailsPanel.Name = "MailsPanel";
            this.MailsPanel.Size = new System.Drawing.Size(333, 836);
            this.MailsPanel.TabIndex = 15;
            // 
            // MessagesListView
            // 
            this.MessagesListView.AllColumns.Add(this.FromColumn);
            this.MessagesListView.AllColumns.Add(this.SubjectColumn);
            this.MessagesListView.AllColumns.Add(this.DateColumn);
            this.MessagesListView.AllColumns.Add(this.SnippetColumn);
            this.MessagesListView.BackColor = System.Drawing.Color.LightBlue;
            this.MessagesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessagesListView.CellEditUseWholeCell = false;
            this.MessagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FromColumn,
            this.SubjectColumn,
            this.DateColumn,
            this.SnippetColumn});
            this.MessagesListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.MessagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesListView.FullRowSelect = true;
            this.MessagesListView.GridLines = true;
            this.MessagesListView.HeaderWordWrap = true;
            this.MessagesListView.Location = new System.Drawing.Point(0, 0);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.RowHeight = 50;
            this.MessagesListView.SelectedBackColor = System.Drawing.Color.SteelBlue;
            this.MessagesListView.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.MessagesListView.Size = new System.Drawing.Size(331, 834);
            this.MessagesListView.SpaceBetweenGroups = 5;
            this.MessagesListView.TabIndex = 0;
            this.MessagesListView.TileSize = new System.Drawing.Size(314, 50);
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.UseFilterIndicator = true;
            this.MessagesListView.UseFiltering = true;
            this.MessagesListView.View = System.Windows.Forms.View.Tile;
            this.MessagesListView.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.MessagesListView_CellClick);
            // 
            // FromColumn
            // 
            this.FromColumn.AspectName = "From";
            this.FromColumn.FillsFreeSpace = true;
            this.FromColumn.IsTileViewColumn = true;
            this.FromColumn.Text = "From";
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.AspectName = "Subject";
            this.SubjectColumn.FillsFreeSpace = true;
            this.SubjectColumn.IsTileViewColumn = true;
            this.SubjectColumn.Text = "Subject";
            // 
            // DateColumn
            // 
            this.DateColumn.AspectName = "Date";
            this.DateColumn.AspectToStringFormat = "“{0:d}”";
            this.DateColumn.IsTileViewColumn = true;
            this.DateColumn.Text = "Date";
            // 
            // SnippetColumn
            // 
            this.SnippetColumn.AspectName = "Snippet";
            this.SnippetColumn.IsTileViewColumn = true;
            this.SnippetColumn.Text = "Snippet";
            // 
            // LabelsPanel
            // 
            this.LabelsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelsPanel.Controls.Add(this.LabelsListView);
            this.LabelsPanel.Location = new System.Drawing.Point(0, 25);
            this.LabelsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LabelsPanel.Name = "LabelsPanel";
            this.LabelsPanel.Size = new System.Drawing.Size(112, 836);
            this.LabelsPanel.TabIndex = 14;
            // 
            // LabelsListView
            // 
            this.LabelsListView.AllColumns.Add(this.LabelColumn);
            this.LabelsListView.BackColor = System.Drawing.Color.LightBlue;
            this.LabelsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LabelsListView.CellEditUseWholeCell = false;
            this.LabelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LabelColumn});
            this.LabelsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelsListView.Font = new System.Drawing.Font("Raleway Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelsListView.FullRowSelect = true;
            this.LabelsListView.Location = new System.Drawing.Point(0, 0);
            this.LabelsListView.MultiSelect = false;
            this.LabelsListView.Name = "LabelsListView";
            this.LabelsListView.Scrollable = false;
            this.LabelsListView.SelectedBackColor = System.Drawing.Color.SteelBlue;
            this.LabelsListView.ShowGroups = false;
            this.LabelsListView.ShowHeaderInAllViews = false;
            this.LabelsListView.Size = new System.Drawing.Size(110, 834);
            this.LabelsListView.TabIndex = 0;
            this.LabelsListView.TileSize = new System.Drawing.Size(110, 35);
            this.LabelsListView.UseCompatibleStateImageBehavior = false;
            this.LabelsListView.View = System.Windows.Forms.View.Tile;
            this.LabelsListView.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.LabelsListView_CellClick);
            // 
            // LabelColumn
            // 
            this.LabelColumn.AspectName = "Name";
            this.LabelColumn.Text = "Labels";
            this.LabelColumn.Width = 150;
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightPanel.Controls.Add(this.BodyWebBrowser);
            this.RightPanel.Controls.Add(this.MessageViewRichTextBox);
            this.RightPanel.Location = new System.Drawing.Point(443, 82);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(1141, 779);
            this.RightPanel.TabIndex = 13;
            // 
            // BodyWebBrowser
            // 
            this.BodyWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.BodyWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.BodyWebBrowser.Name = "BodyWebBrowser";
            this.BodyWebBrowser.Size = new System.Drawing.Size(1139, 777);
            this.BodyWebBrowser.TabIndex = 8;
            this.BodyWebBrowser.Visible = false;
            // 
            // MessageViewRichTextBox
            // 
            this.MessageViewRichTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.MessageViewRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageViewRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageViewRichTextBox.Font = new System.Drawing.Font("Raleway Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageViewRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.MessageViewRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MessageViewRichTextBox.Name = "MessageViewRichTextBox";
            this.MessageViewRichTextBox.Size = new System.Drawing.Size(1139, 777);
            this.MessageViewRichTextBox.TabIndex = 7;
            this.MessageViewRichTextBox.Text = "";
            this.MessageViewRichTextBox.WordWrap = false;
            // 
            // DetailsViewRadioButton
            // 
            this.DetailsViewRadioButton.AutoSize = true;
            this.DetailsViewRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.DetailsViewRadioButton.Location = new System.Drawing.Point(125, 7);
            this.DetailsViewRadioButton.Name = "DetailsViewRadioButton";
            this.DetailsViewRadioButton.Size = new System.Drawing.Size(83, 17);
            this.DetailsViewRadioButton.TabIndex = 17;
            this.DetailsViewRadioButton.TabStop = true;
            this.DetailsViewRadioButton.Text = "Details View";
            this.DetailsViewRadioButton.UseVisualStyleBackColor = false;
            this.DetailsViewRadioButton.CheckedChanged += new System.EventHandler(this.DetailsViewRadioButton_CheckedChanged);
            // 
            // TileViewRadioButton
            // 
            this.TileViewRadioButton.AutoSize = true;
            this.TileViewRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.TileViewRadioButton.Location = new System.Drawing.Point(216, 7);
            this.TileViewRadioButton.Name = "TileViewRadioButton";
            this.TileViewRadioButton.Size = new System.Drawing.Size(68, 17);
            this.TileViewRadioButton.TabIndex = 18;
            this.TileViewRadioButton.TabStop = true;
            this.TileViewRadioButton.Text = "Tile View";
            this.TileViewRadioButton.UseVisualStyleBackColor = false;
            this.TileViewRadioButton.CheckedChanged += new System.EventHandler(this.TileViewRadioButton_CheckedChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(356, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(188, 20);
            this.SearchTextBox.TabIndex = 19;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Location = new System.Drawing.Point(306, 7);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 20;
            this.SearchLabel.Text = "Search:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BodyHeaderRichTextBox);
            this.panel1.Location = new System.Drawing.Point(443, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 58);
            this.panel1.TabIndex = 21;
            // 
            // BodyHeaderRichTextBox
            // 
            this.BodyHeaderRichTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.BodyHeaderRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BodyHeaderRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyHeaderRichTextBox.Font = new System.Drawing.Font("Raleway SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyHeaderRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.BodyHeaderRichTextBox.Margin = new System.Windows.Forms.Padding(20, 5, 3, 5);
            this.BodyHeaderRichTextBox.Name = "BodyHeaderRichTextBox";
            this.BodyHeaderRichTextBox.ReadOnly = true;
            this.BodyHeaderRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BodyHeaderRichTextBox.Size = new System.Drawing.Size(1139, 56);
            this.BodyHeaderRichTextBox.TabIndex = 0;
            this.BodyHeaderRichTextBox.Text = "";
            // 
            // SaintSenderPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.TileViewRadioButton);
            this.Controls.Add(this.DetailsViewRadioButton);
            this.Controls.Add(this.MailsPanel);
            this.Controls.Add(this.LabelsPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopMenuStrip);
            this.Name = "SaintSenderPlus";
            this.Text = "SaintSenderPlus";
            this.Load += new System.EventHandler(this.SaintSenderPlus_Load);
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.MailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MessagesListView)).EndInit();
            this.LabelsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LabelsListView)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem htmlPlainTextToolStripMenuItem;
        private System.Windows.Forms.Panel MailsPanel;
        private System.Windows.Forms.Panel LabelsPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.RichTextBox MessageViewRichTextBox;
        private BrightIdeasSoftware.ObjectListView LabelsListView;
        private BrightIdeasSoftware.ObjectListView MessagesListView;
        private BrightIdeasSoftware.OLVColumn LabelColumn;
        private BrightIdeasSoftware.OLVColumn FromColumn;
        private BrightIdeasSoftware.OLVColumn SubjectColumn;
        private BrightIdeasSoftware.OLVColumn DateColumn;
        private BrightIdeasSoftware.OLVColumn SnippetColumn;
        private System.Windows.Forms.RadioButton DetailsViewRadioButton;
        private System.Windows.Forms.RadioButton TileViewRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox BodyHeaderRichTextBox;
        private System.Windows.Forms.WebBrowser BodyWebBrowser;
    }
}