using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class GMail
    {
        private string id, from, subject, date, snippet, body, htmlBody;

        public string Id { get => id; set => id = value; }
        public string From { get => from; set => from = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Date { get => date; set => date = value; }
        public string Snippet { get => snippet; set => snippet = value; }
        public string Body { get => body; set => body = value; }
        public string HTMLBody { get => htmlBody; set => htmlBody = value; }

        public GMail() {}

        public GMail(string id, string from, string subject, string date, string snippet, string body, string htmlBody)
        {
            this.Id = id;
            this.From = from;
            this.Subject = subject;
            this.Date = date;
            this.Snippet = snippet;
            this.Body = body;
            this.HTMLBody = htmlBody;
        }

        public static IDictionary<string, GMail> CreateGmailMessage(IList<Google.Apis.Gmail.v1.Data.Message> inputEmails, GmailAPIHandler gmmailAPIhandler)
        {
            IDictionary<string, GMail> extractedMails = new Dictionary<string, GMail>();
            foreach (var message in inputEmails)
            {
                string messageID = message.Id;
                extractedMails[messageID] = new GMail();
                Google.Apis.Gmail.v1.Data.Message currentMessage = gmmailAPIhandler.GetMessage("me", messageID);
                foreach (var header in currentMessage.Payload.Headers)
                {
                    if (header.Name == "From") { extractedMails[messageID].From = header.Value; }
                    if (header.Name == "Subject") { extractedMails[messageID].Subject = header.Value; }
                    if (header.Name == "Date") { extractedMails[messageID].Date = header.Value.Remove(header.Value.Length - 14); }
                    if (header.Name == "Snippet") { extractedMails[messageID].Snippet = header.Value; }

                    if (extractedMails[messageID].Date != "No date information" && extractedMails[messageID].From != "No send information")
                    {
                        if (currentMessage.Payload.Parts == null && currentMessage.Payload.Body != null)
                        {
                            extractedMails[messageID].Body = DecodeBase64(currentMessage.Payload.Body.Data);
                        }
                        else
                        {
                            extractedMails[messageID].Body = DecodeBase64(GetMessageBody(currentMessage.Payload.Parts, ""));
                            extractedMails[messageID].HTMLBody = DecodeBase64(GetMessageHTMLBody(currentMessage.Payload.Parts, ""));
                        }
                    }
                }
            }
            return extractedMails;
        }

        private static string GetMessageBody(IList<Google.Apis.Gmail.v1.Data.MessagePart> inputParts, string emptyString)
        {
            string body = emptyString;
            if (inputParts == null)
            {
                body = "No data";
                return body;
            }
            else
            {
                foreach (var part in inputParts)
                {
                    if (part.Parts == null)
                    {
                        if (part.MimeType == "text/plain")
                        {
                            if (part.Body != null && part.Body.Data != null)
                            {
                                body = part.Body.Data;
                            }
                        }
                    }
                    else
                    {
                        return GetMessageBody(part.Parts, body);
                    }
                }
                return body;
            }
        }

        private static string GetMessageHTMLBody(IList<Google.Apis.Gmail.v1.Data.MessagePart> inputParts, string emptyString)
        {
            string body = emptyString;
            if (inputParts == null)
            {
                body = "No data";
                return body;
            }
            else
            {
                foreach (var part in inputParts)
                {
                    if (part.Parts == null)
                    {
                        if (part.MimeType == "text/html")
                        {
                            if (part.Body != null && part.Body.Data != null)
                            {
                                body = part.Body.Data;
                            }
                        }
                    }
                    else
                    {
                        return GetMessageBody(part.Parts, body);
                    }
                }
                return body;
            }
        }

        private static string DecodeBase64(string input)
        {
            //var base64 = Convert.FromBase64String(input.Replace("-", "+"));
            //var str = Encoding.UTF8.GetString(base64);
            //return str;
            try
            {
                string s = input;
                s = s.Replace('-', '+'); // 62nd char of encoding
                s = s.Replace('_', '/'); // 63rd char of encoding
                switch (s.Length % 4) // Pad with trailing '='s
                {
                    case 0: break; // No pad chars in this case
                    case 2: s += "=="; break; // Two pad chars
                    case 3: s += "="; break; // One pad char
                    default:
                        throw new System.Exception(
                 "Illegal base64url string!");
                }
                byte[] bArray = Convert.FromBase64String(s); // Standard base64 decoder
                string decodedOutPut = Encoding.UTF8.GetString(bArray);
                return decodedOutPut;
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne);
                return input;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe);
                return input;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return input;
            }
        }
    }
}
