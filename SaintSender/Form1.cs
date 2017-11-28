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

namespace SaintSender
{
    public partial class Form1 : Form
    {
        GmailAPIHandler gmmailAPIhandler = new GmailAPIHandler();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList<Google.Apis.Gmail.v1.Data.Label> testLabels = gmmailAPIhandler.GetGmailLabels();
            foreach (var label in testLabels)
            {
                LabelsListView.Items.Add(label.Name);
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IList<Google.Apis.Gmail.v1.Data.Message> testMails = gmmailAPIhandler.ListMessages();
            //IList<Google.Apis.Gmail.v1.Data.MessagePartHeader> headers = new List<Google.Apis.Gmail.v1.Data.MessagePartHeader>();
            List<string> headerNames = new List<string>();

            foreach (var message in testMails)
            {
                string messageID = message.Id;
                Google.Apis.Gmail.v1.Data.Message currentMessage = gmmailAPIhandler.GetMessage("me", messageID);
                string from = currentMessage.Payload.Headers[0].Value;
            }
        }
    }
}
