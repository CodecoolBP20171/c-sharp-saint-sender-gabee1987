namespace SaintSender
{
    partial class SaintSenderForm
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
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MessagesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlPlainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageViewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LabelsListView = new System.Windows.Forms.ListView();
            this.LabelsPanel = new System.Windows.Forms.Panel();
            this.MailsPanel = new System.Windows.Forms.Panel();
            this.TopMenuStrip.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.LabelsPanel.SuspendLayout();
            this.MailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessagesListView
            // 
            this.MessagesListView.BackColor = System.Drawing.Color.LightSlateGray;
            this.MessagesListView.BackgroundImageTiled = true;
            this.MessagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesListView.Location = new System.Drawing.Point(0, 0);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(343, 819);
            this.MessagesListView.TabIndex = 5;
            this.MessagesListView.TileSize = new System.Drawing.Size(240, 50);
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.Tile;
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessagesStripMenuItem,
            this.GetLabelsToolStripMenuItem,
            this.htmlPlainTextToolStripMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopMenuStrip.Size = new System.Drawing.Size(1482, 28);
            this.TopMenuStrip.TabIndex = 6;
            this.TopMenuStrip.Text = "menuStrip1";
            // 
            // MessagesStripMenuItem
            // 
            this.MessagesStripMenuItem.Name = "MessagesStripMenuItem";
            this.MessagesStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.MessagesStripMenuItem.Text = "GetMessages";
            this.MessagesStripMenuItem.Click += new System.EventHandler(this.MessagesStripMenuItem_Click);
            // 
            // GetLabelsToolStripMenuItem
            // 
            this.GetLabelsToolStripMenuItem.Name = "GetLabelsToolStripMenuItem";
            this.GetLabelsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.GetLabelsToolStripMenuItem.Text = "GetLabels";
            this.GetLabelsToolStripMenuItem.Click += new System.EventHandler(this.getLabelsToolStripMenuItem_Click);
            // 
            // htmlPlainTextToolStripMenuItem
            // 
            this.htmlPlainTextToolStripMenuItem.Name = "htmlPlainTextToolStripMenuItem";
            this.htmlPlainTextToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.htmlPlainTextToolStripMenuItem.Text = "Html/Plain Text";
            // 
            // MessageViewRichTextBox
            // 
            this.MessageViewRichTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.MessageViewRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageViewRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageViewRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.MessageViewRichTextBox.Name = "MessageViewRichTextBox";
            this.MessageViewRichTextBox.Size = new System.Drawing.Size(989, 819);
            this.MessageViewRichTextBox.TabIndex = 7;
            this.MessageViewRichTextBox.Text = "";
            this.MessageViewRichTextBox.WordWrap = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Location = new System.Drawing.Point(0, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(41, 30);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.Text = "<<";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightPanel.Controls.Add(this.MessageViewRichTextBox);
            this.RightPanel.Location = new System.Drawing.Point(490, 31);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(991, 821);
            this.RightPanel.TabIndex = 10;
            // 
            // LabelsListView
            // 
            this.LabelsListView.BackColor = System.Drawing.Color.SlateGray;
            this.LabelsListView.BackgroundImageTiled = true;
            this.LabelsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelsListView.Location = new System.Drawing.Point(0, 0);
            this.LabelsListView.Name = "LabelsListView";
            this.LabelsListView.Size = new System.Drawing.Size(146, 819);
            this.LabelsListView.TabIndex = 4;
            this.LabelsListView.UseCompatibleStateImageBehavior = false;
            this.LabelsListView.View = System.Windows.Forms.View.Tile;
            // 
            // LabelsPanel
            // 
            this.LabelsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelsPanel.Controls.Add(this.LabelsListView);
            this.LabelsPanel.Location = new System.Drawing.Point(0, 31);
            this.LabelsPanel.Name = "LabelsPanel";
            this.LabelsPanel.Size = new System.Drawing.Size(148, 821);
            this.LabelsPanel.TabIndex = 11;
            // 
            // MailsPanel
            // 
            this.MailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MailsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MailsPanel.Controls.Add(this.MessagesListView);
            this.MailsPanel.Location = new System.Drawing.Point(147, 31);
            this.MailsPanel.Name = "MailsPanel";
            this.MailsPanel.Size = new System.Drawing.Size(345, 821);
            this.MailsPanel.TabIndex = 12;
            // 
            // SaintSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.MailsPanel);
            this.Controls.Add(this.LabelsPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.TopMenuStrip);
            this.Name = "SaintSenderForm";
            this.Text = "SaintSender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.LabelsPanel.ResumeLayout(false);
            this.MailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MessagesStripMenuItem;
        private System.Windows.Forms.RichTextBox MessageViewRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem GetLabelsToolStripMenuItem;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.ListView LabelsListView;
        private System.Windows.Forms.Panel LabelsPanel;
        private System.Windows.Forms.Panel MailsPanel;
        private System.Windows.Forms.ToolStripMenuItem htmlPlainTextToolStripMenuItem;
    }
}

