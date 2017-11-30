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
            this.LabelsListView = new System.Windows.Forms.ListView();
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MessagesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageViewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LabelsEmailsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.TopMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelsEmailsSplitContainer)).BeginInit();
            this.LabelsEmailsSplitContainer.Panel1.SuspendLayout();
            this.LabelsEmailsSplitContainer.Panel2.SuspendLayout();
            this.LabelsEmailsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelsListView
            // 
            this.LabelsListView.BackColor = System.Drawing.Color.Honeydew;
            this.LabelsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelsListView.Location = new System.Drawing.Point(0, 0);
            this.LabelsListView.Name = "LabelsListView";
            this.LabelsListView.Size = new System.Drawing.Size(136, 825);
            this.LabelsListView.TabIndex = 4;
            this.LabelsListView.UseCompatibleStateImageBehavior = false;
            this.LabelsListView.View = System.Windows.Forms.View.Tile;
            // 
            // MessagesListView
            // 
            this.MessagesListView.BackColor = System.Drawing.Color.Honeydew;
            this.MessagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesListView.Location = new System.Drawing.Point(0, 0);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(268, 825);
            this.MessagesListView.TabIndex = 5;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.Tile;
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessagesStripMenuItem,
            this.getLabelsToolStripMenuItem});
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
            // getLabelsToolStripMenuItem
            // 
            this.getLabelsToolStripMenuItem.Name = "getLabelsToolStripMenuItem";
            this.getLabelsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.getLabelsToolStripMenuItem.Text = "GetLabels";
            this.getLabelsToolStripMenuItem.Click += new System.EventHandler(this.getLabelsToolStripMenuItem_Click);
            // 
            // MessageViewRichTextBox
            // 
            this.MessageViewRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageViewRichTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.MessageViewRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageViewRichTextBox.Location = new System.Drawing.Point(446, 89);
            this.MessageViewRichTextBox.Name = "MessageViewRichTextBox";
            this.MessageViewRichTextBox.Size = new System.Drawing.Size(941, 555);
            this.MessageViewRichTextBox.TabIndex = 7;
            this.MessageViewRichTextBox.Text = "";
            this.MessageViewRichTextBox.WordWrap = false;
            // 
            // LabelsEmailsSplitContainer
            // 
            this.LabelsEmailsSplitContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelsEmailsSplitContainer.Location = new System.Drawing.Point(0, 28);
            this.LabelsEmailsSplitContainer.Name = "LabelsEmailsSplitContainer";
            // 
            // LabelsEmailsSplitContainer.Panel1
            // 
            this.LabelsEmailsSplitContainer.Panel1.Controls.Add(this.LabelsListView);
            // 
            // LabelsEmailsSplitContainer.Panel2
            // 
            this.LabelsEmailsSplitContainer.Panel2.Controls.Add(this.MessagesListView);
            this.LabelsEmailsSplitContainer.Size = new System.Drawing.Size(408, 825);
            this.LabelsEmailsSplitContainer.SplitterDistance = 136;
            this.LabelsEmailsSplitContainer.TabIndex = 8;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Location = new System.Drawing.Point(1187, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(35, 30);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.Text = "<<";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaintSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.LabelsEmailsSplitContainer);
            this.Controls.Add(this.MessageViewRichTextBox);
            this.Controls.Add(this.TopMenuStrip);
            this.Name = "SaintSenderForm";
            this.Text = "SaintSender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.LabelsEmailsSplitContainer.Panel1.ResumeLayout(false);
            this.LabelsEmailsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LabelsEmailsSplitContainer)).EndInit();
            this.LabelsEmailsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LabelsListView;
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MessagesStripMenuItem;
        private System.Windows.Forms.RichTextBox MessageViewRichTextBox;
        private System.Windows.Forms.SplitContainer LabelsEmailsSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem getLabelsToolStripMenuItem;
        private System.Windows.Forms.Button MinimizeButton;
    }
}

