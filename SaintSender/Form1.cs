using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;

namespace SaintSender
{
    public partial class SaintSenderForm : Form
    {
        GmailAPIHandler gmmailAPIhandler = new GmailAPIHandler();
        private const string userId = "me";
        //const int LEFT_PANEL_NORMAL_SIZE = 500;
        //const int LEFT_PANEL_MINIMIZED_SIZE = 30;
        //const int RIGHT_PANEL_NORMAL_SIZE = 980;
        //const int RIGHT_PANEL_STRECHED_SIZE = 1450;
        //bool labelsMinimized = false;

        public SaintSenderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, Google.Apis.Gmail.v1.Data.Label> labels = gmmailAPIhandler.GetLabels(userId);
            foreach (KeyValuePair<string, Google.Apis.Gmail.v1.Data.Label> label in labels)
            {
                ListViewItem labelItem = new ListViewItem();
                if (label.Key != "CATEGORY_PERSONAL" &&
                    label.Key != "CATEGORY_SOCIAL" &&
                    label.Key != "CATEGORY_UPDATES" &&
                    label.Key != "CATEGORY_FORUMS" &&
                    label.Key != "CATEGORY_PROMOTIONS" &&
                    label.Key != "CHAT")
                {
                    labelItem.Text = label.Value.Name;
                    LabelsListView.Items.Add(labelItem);

                }
            }
        }

        private void getLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MessagesStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            //if (labelsMinimized == false)
            //{
            //    //labelsMinimized = true;
            //    //LeftPanel.Width = LEFT_PANEL_MINIMIZED_SIZE;
            //    //RightPanel.Width = RIGHT_PANEL_STRECHED_SIZE;
            //    //MailsPanel.Width = MAILS_LIST_WIDTH_STRECHED_SIZE;
            //}
            //else
            //{
            //    //labelsMinimized = false;
            //    //LeftPanel.Width = LEFT_PANEL_NORMAL_SIZE;
            //    //RightPanel.Width = RIGHT_PANEL_NORMAL_SIZE;
            //    //MailsPanel.Width = MAILS_LIST_PANEL_WIDTH_NORMAL_SIZE;
            //}
        }

        private void LabelsListView_Click(object sender, EventArgs e)
        {
            var selectedLabelId = LabelsListView.SelectedItems[0].Text;
            MessagesListView.Items.Clear();

            string Id = "";
            string From = "";
            string Subject = "";
            string Date = "";
            string Snippet = "";
            string Body = "";
            string HTMLBody = "";
            IList<Google.Apis.Gmail.v1.Data.Message> testMails = gmmailAPIhandler.ListMessages(selectedLabelId);

            IDictionary<string, GMail> extractedMails = GMail.CreateGmailMessage(testMails, gmmailAPIhandler);
            foreach (KeyValuePair<string, GMail> mail in extractedMails)
            {
                ListViewItem messageItem = new ListViewItem();

                From = mail.Value.From;
                Subject = mail.Value.Subject;
                Date = mail.Value.Date;
                Snippet = mail.Value.Snippet;
                Body = mail.Value.Body;
                HTMLBody = mail.Value.HTMLBody;

                messageItem.Name = Id;
                messageItem.Text = From;
                messageItem.ToolTipText = Snippet;
                messageItem.Tag = Body;

                messageItem.SubItems.Add(Subject);
                messageItem.SubItems.Add(Snippet);
                messageItem.SubItems.Add(Date);

                MessagesListView.Columns.Add("Message", -2, HorizontalAlignment.Left);
                MessagesListView.Columns.Add("Date", -2, HorizontalAlignment.Right);

                MessagesListView.Items.Add(Id + From + Subject + Date + Snippet + "\n");
            }
        }
    }
}
