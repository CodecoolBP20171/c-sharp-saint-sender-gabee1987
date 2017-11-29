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
            IList<Google.Apis.Gmail.v1.Data.Message> testMails = gmmailAPIhandler.ListMessages();
            IList<Google.Apis.Gmail.v1.Data.MessagePartHeader> headers = new List<Google.Apis.Gmail.v1.Data.MessagePartHeader>();
            Dictionary<string, string> messageFROM = new Dictionary<string, string>();
            Dictionary<string, string> messageSUBJECT = new Dictionary<string, string>();
            Dictionary<string, string> messageDATE = new Dictionary<string, string>();

            IDictionary<string, GMail> extractedMails = CreateGmailMessage(testMails);
            foreach (KeyValuePair<string, GMail> mail in myDic)
            {

            }



            //foreach (var message in testMails)
            //{
            //    string messageID = message.Id;
            //    Google.Apis.Gmail.v1.Data.Message currentMessage = gmmailAPIhandler.GetMessage("me", messageID);
            //    foreach (var header in currentMessage.Payload.Headers)
            //    {
            //        if (header.Name == "From") { messageFROM.Add(header.Name, header.Value); }
            //        if (header.Name == "Subject") { messageFROM.Add(header.Name, header.Value); }
            //        if (header.Name == "Date") { messageFROM.Add(header.Name, header.Value); }
            //    }
            //    foreach (var item in currentMessage.Payload.Parts)
            //    {
            //        if (item.  == "Date") { messageFROM.Add(header.Name, header.Value); }
            //    }
            //}
        }

        private IDictionary<string, GMail> CreateGmailMessage(IList<Google.Apis.Gmail.v1.Data.Message> testMails)
        {
            IDictionary<string, GMail> extractedMails = new Dictionary<string, GMail>();
            foreach (var message in testMails)
            {
                string messageID = message.Id;
                Google.Apis.Gmail.v1.Data.Message currentMessage = gmmailAPIhandler.GetMessage("me", messageID);
                extractedMails[messageID] = new GMail();
                foreach (var header in currentMessage.Payload.Headers)
                {
                    if (header.Name == "From") { extractedMails[messageID].From = header.Value; }
                    if (header.Name == "Subject") { extractedMails[messageID].Subject = header.Value; }
                    if (header.Name == "Date") { extractedMails[messageID].Date = header.Value; }
                    if (header.Name == "Snippet") { extractedMails[messageID].Snippet = header.Value; }
                    if (header.Name == "Body") { extractedMails[messageID].Body = header.Value; }
                }
            }
            return extractedMails;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList<Google.Apis.Gmail.v1.Data.Message> testMails = gmmailAPIhandler.ListMessages();
            List<string> messageIDS = new List<string>();
            string path = @"D:\Codecool\.NET\message_ids.txt";
            foreach (var message in testMails)
            {
                string messageID = message.Id;
                Google.Apis.Gmail.v1.Data.Message currentMessage = gmmailAPIhandler.GetMessage("me", messageID);
                messageIDS.Add(messageID);
            }
            TextWriter textwriter = new StreamWriter(path);
            foreach (var id in messageIDS)
            {
                textwriter.WriteLine(id);
            }
            textwriter.Close();
        }
    }
}
