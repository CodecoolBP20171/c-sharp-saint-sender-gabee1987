using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class SaintSenderPlus : Form
    {
        GmailAPIHandler gmmailAPIhandler = new GmailAPIHandler();
        private const string userId = "me";

        public SaintSenderPlus()
        {
            InitializeComponent();
        }

        private void SaintSenderPlus_Load(object sender, EventArgs e)
        {
            List<Google.Apis.Gmail.v1.Data.Label> labelList = new List<Google.Apis.Gmail.v1.Data.Label>();
            Dictionary<string, Google.Apis.Gmail.v1.Data.Label> labels = gmmailAPIhandler.GetLabels(userId);
            foreach (KeyValuePair<string, Google.Apis.Gmail.v1.Data.Label> label in labels)
            {
                //ListViewItem labelItem = new ListViewItem();
                if (label.Key != "CATEGORY_PERSONAL" &&
                    label.Key != "CATEGORY_SOCIAL" &&
                    label.Key != "CATEGORY_UPDATES" &&
                    label.Key != "CATEGORY_FORUMS" &&
                    label.Key != "CATEGORY_PROMOTIONS" &&
                    label.Key != "CHAT" &&
                    label.Key != "IMPORTANT")
                {
                    //labelItem.Text = label.Value.Name;
                    //LabelsListView.Items.Add(labelItem);
                    labelList.Add(label.Value);
                }
            }
            LabelsListView.SetObjects(labelList);

            BodyHeaderRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            MessageViewRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void LabelsListView_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            MessagesListView.ClearObjects();
            string selectedLabelId = LabelsListView.SelectedItem.Text;
            IList<Google.Apis.Gmail.v1.Data.Message> currentLabelMessages = gmmailAPIhandler.ListMessages(selectedLabelId);
            IDictionary<string, GMail> extractedMails = GMail.CreateGmailMessage(currentLabelMessages, gmmailAPIhandler);
            List<GMail> mailList = new List<GMail>();
            foreach (KeyValuePair<string, GMail> mail in extractedMails)
            {
                mailList.Add(mail.Value);
            }
            MessagesListView.SetObjects(mailList);
        }

        private void DetailsViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MessagesListView.View = View.Details;
        }

        private void TileViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MessagesListView.View = View.Tile;
        }

        private void MessagesListView_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            MessageViewRichTextBox.Clear();
            GMail selectedMail = (GMail)MessagesListView.SelectedObject;
            MessageViewRichTextBox.Text = selectedMail.Body;
            BodyHeaderRichTextBox.Text = "\n" + selectedMail.From + "   -   " + selectedMail.Subject + "   -   " + selectedMail.Date;
            BodyWebBrowser.DocumentText = selectedMail.HTMLBody;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TextMatchFilter filter = TextMatchFilter.Contains(MessagesListView, SearchTextBox.Text);
            MessagesListView.ModelFilter = filter;
            MessagesListView.DefaultRenderer = new HighlightTextRenderer(filter);


        }

        private void htmlPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BodyWebBrowser.Visible == false)
            {
                BodyWebBrowser.Visible = true;
            }
            else
            {
                BodyWebBrowser.Visible = false;
            }
        }

        //private void LabelsListView_Click(object sender, EventArgs e)
        //{
        //    var selectedLabelId = LabelsListView.SelectedItems[0].Text;
        //    MessagesListView.Items.Clear();

        //    string Id = "";
        //    string From = "";
        //    string Subject = "";
        //    string Date = "";
        //    string Snippet = "";
        //    string Body = "";
        //    string HTMLBody = "";
        //    IList<Google.Apis.Gmail.v1.Data.Message> testMails = gmmailAPIhandler.ListMessages(selectedLabelId);

        //    IDictionary<string, GMail> extractedMails = GMail.CreateGmailMessage(testMails, gmmailAPIhandler);
        //    foreach (KeyValuePair<string, GMail> mail in extractedMails)
        //    {
        //        ListViewItem messageItem = new ListViewItem();

        //        From = mail.Value.From;
        //        Subject = mail.Value.Subject;
        //        Date = mail.Value.Date;
        //        Snippet = mail.Value.Snippet;
        //        Body = mail.Value.Body;
        //        HTMLBody = mail.Value.HTMLBody;

        //        messageItem.Name = Id;
        //        messageItem.Text = From;
        //        messageItem.ToolTipText = Snippet;
        //        messageItem.Tag = Body;

        //        messageItem.SubItems.Add(Subject);
        //        messageItem.SubItems.Add(Snippet);
        //        messageItem.SubItems.Add(Date);

        //        MessagesListView.Columns.Add("Message", -2, HorizontalAlignment.Left);
        //        MessagesListView.Columns.Add("Date", -2, HorizontalAlignment.Right);

        //        MessagesListView.Items.Add(Id + From + Subject + Date + Snippet + "\n");
        //    }
        //}
    }
}
