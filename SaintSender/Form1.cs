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

        public SaintSenderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }

        private void getLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IList<Google.Apis.Gmail.v1.Data.Label> testLabels = gmmailAPIhandler.GetGmailLabels();
            foreach (var label in testLabels)
            {
                LabelsListView.Items.Add(label.Name);
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

        

        

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
