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
            //LeftPanel.SendToBack();
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }

        private void getLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, Google.Apis.Gmail.v1.Data.Label> labels = gmmailAPIhandler.GetLabels(userId);
            foreach (KeyValuePair<string, Google.Apis.Gmail.v1.Data.Label> label in labels)
            {
                ListViewItem labelItem = new ListViewItem();
                if (label.Key != "CATEGORY_PERSONAL" &&
                    label.Key != "CATEGORY_SOCIAL" &&
                    label.Key != "CATEGORY_UPDATES" &&
                    label.Key != "CATEGORY_FORUMS" &&
                    label.Key != "CATEGORY_PROMOTIONS")
                {
                    labelItem.Text = label.Value.Name;
                    labelItem.Tag = label.Value.Id;
                    LabelsListView.Items.Add(labelItem);

                }
            }
        }

        private void MessagesStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = "";
            string From = "";
            string Subject = "";
            string Date = "";
            string Snippet = "";
            string Body = "";
            string HTMLBody = "";
            IList<Google.Apis.Gmail.v1.Data.Message> testMails = gmmailAPIhandler.ListMessages();

            IDictionary<string, GMail> extractedMails = GMail.CreateGmailMessage(testMails, gmmailAPIhandler);
            string testbody = "";
            foreach (KeyValuePair<string, GMail> mail in extractedMails)
            {
                From = mail.Value.From;
                Subject = mail.Value.Subject;
                Date = mail.Value.Date;
                Snippet = mail.Value.Snippet;
                Body = mail.Value.Body;
                HTMLBody = mail.Value.HTMLBody;
                MessagesListView.Items.Add(Id + From + Subject + Date + Snippet + "\n");
                testbody += Body + "\n";
            }
                MessageViewRichTextBox.Text = testbody;
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
    }
}
