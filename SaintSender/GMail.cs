using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class GMail
    {
        private string id, from, subject, date, snippet, body;

        public string Id { get => id; set => id = value; }
        public string From { get => from; set => from = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Date { get => date; set => date = value; }
        public string Snippet { get => snippet; set => snippet = value; }
        public string Body { get => body; set => body = value; }
        public string HTMLBody { get => HTMLBody; set => HTMLBody = value; }

        public GMail() {}

        public GMail(string id, string from, string subject, string date, string snippet, string body, string htmlbody)
        {
            this.Id = id;
            this.From = from;
            this.Subject = subject;
            this.Date = date;
            this.Snippet = snippet;
            this.Body = body;
            this.HTMLBody = body;
        }
    }
}
