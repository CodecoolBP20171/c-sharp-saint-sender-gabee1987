using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Net.Mail;

namespace SaintSender
{
    class GmailAPIHandler
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json
        static string[] Scopes = { GmailService.Scope.GmailReadonly };
        static string ApplicationName = "SaintSender";
        GmailService service = CreateGMailAPIService();
        private const string userId = "me";


        private static UserCredential CreateCredentials()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            return credential;
        }


        private static GmailService CreateGMailAPIService()
        {
            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = CreateCredentials(),
                ApplicationName = ApplicationName,
            });
            return service;
        }


        //public IList<Google.Apis.Gmail.v1.Data.Label> GetGmailLabels()
        //{
        //    // Define parameters of request.
        //    UsersResource.LabelsResource.ListRequest request = service.Users.Labels.List(userId);

        //    // List labels.
        //    IList<Label> labels = request.Execute().Labels;
        //    return labels;
        //}


        /// <summary>
        /// List the labels in the user's mailbox.
        /// </summary>
        /// <param name="service">Gmail API service instance.</param>
        /// <param name="userId">User's email address. The special value "me"
        /// can be used to indicate the authenticated user.</param>
        public Dictionary<string, Label> GetLabels(String userId)
        {
            Dictionary<string, Label> result = new Dictionary<string, Label>();
            try
            {
                ListLabelsResponse response = service.Users.Labels.List(userId).Execute();
                foreach (Label label in response.Labels)
                {
                    string labelId = label.Id;
                    result[labelId] = new Label();
                    result[labelId].Name = label.Name;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            return result;
        }


        /// <summary>
        /// List all Messages of the user's mailbox matching the query.
        /// </summary>
        /// <param name="service">Gmail API service instance.</param>
        /// <param name="userId">User's email address. The special value "me"
        /// can be used to indicate the authenticated user.</param>
        /// <param name="query">String used to filter Messages returned.</param>
        /// 
        public List<Message> ListMessages(string labelId)
        {
            List<Message> result = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List(userId);
            //request.Q = query;
            request.LabelIds = labelId;

            do
            {
                try
                {
                    ListMessagesResponse response = request.Execute();
                    result.AddRange(response.Messages);
                    request.PageToken = response.NextPageToken;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            } while (!String.IsNullOrEmpty(request.PageToken));

            return result;
        }


        /// <summary>
        /// Retrieve a Message by ID.
        /// </summary>
        /// <param name="service">Gmail API service instance.</param>
        /// <param name="userId">User's email address. The special value "me"
        /// can be used to indicate the authenticated user.</param>
        /// <param name="messageId">ID of Message to retrieve.</param>
        public Message GetMessage(String userId, String messageId)
        {
            try
            {
                return service.Users.Messages.Get(userId, messageId).Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

            return null;
        }


        // ...

        /// <summary>
        /// Get a Thread with given ID.
        /// </summary>
        /// <param name="service">Gmail API service instance.</param>
        /// <param name="userId">User's email address. The special value "me"
        /// can be used to indicate the authenticated user.</param>
        /// <param name="threadId">ID of Thread to retrieve.</param>
        public Google.Apis.Gmail.v1.Data.Thread GetThread(String userId, String threadId, string query)
        {
            try
            {
                return service.Users.Threads.Get(userId, threadId).Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

            return null;
        }
    }
}
