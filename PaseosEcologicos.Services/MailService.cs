using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace Reval.Services
{
    public class MailService: IMailService
    {
        private string token;
        private bool mailSent;
        private SmtpClient client;

// Servidor de correo dohaweb001 puede variar.
        public MailService()
        {
            var mailServer = ConfigurationSettings.AppSettings.Get("MailServer");
            client = new SmtpClient(mailServer, 25);
        }

        public bool Send(string _to, string _from, string _subject, string _body)
        {
            
            MailAddress to = new MailAddress(_to);
            MailAddress from = new MailAddress(_from);

            MailMessage message = new MailMessage(from, to);

            message.SubjectEncoding = Encoding.UTF8;
            message.BodyEncoding = Encoding.UTF8;

            message.Subject = _subject;
            message.Body = _body;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            token = String.Format("Email to : {0}", _to);
            client.Send(message);

            return mailSent;
        }

        void SendCompletedCallback(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
                mailSent = false;
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
                mailSent = false;
            }
            else
            {
                Console.WriteLine("Message sent.");
                mailSent = true; 
            }
        }

        public void Over() {
            client.Dispose();
        }

    }
}
