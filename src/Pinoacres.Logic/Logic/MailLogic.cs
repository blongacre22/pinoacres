using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore;

using Pinoacres.BusinessObjects;

using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace Pinoacres.Logic
{
    public class MailLogic
    {
        private MailboxAddress fromMailboxAddress = new MailboxAddress("Pinoacres Email", PinoacresConstants.EmailFromAddress);

        public void SendEmail(MimeMessage emailMessage)
        {
            using (var client = new SmtpClient())
            {
                client.LocalDomain = PinoacresConstants.SMTPServerUrl;
                client.Connect(PinoacresConstants.SMTPServerUrl, 587, false);
                client.Authenticate(new System.Net.NetworkCredential() { UserName = PinoacresConstants.EmailFromAddress, Password = PinoacresConstants.EmailFromPassword });
                client.Send(emailMessage);
                client.Disconnect(true);
            }
        }

        public MimeMessage CreateEmailMessage(string toEmailAddress = "", string toDisplayName = "", string fromEmailAddress = "", string fromDisplayName = "", string subject = "", string body = "")
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(fromDisplayName, fromEmailAddress));
            emailMessage.To.Add(new MailboxAddress(toDisplayName, toEmailAddress));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = body };

            return emailMessage;
        }

        public MimeMessage CreateMLBEmailMessage(string toEmail = "", string subject = "", string body = "")
        {
            return CreateEmailMessage(toEmail, string.Empty, PinoacresConstants.EmailFromAddress, "MLB Extra Bases Pinger (Pinoacres)", subject, body);
        }

        public MimeMessage CreateMLBTicketsAvailableEmail(string toEmail, List<MLBExtraBasesTicketData> ticketDataList)
        {
            string subject = "Tickets Available - MLB Extra Bases Pinger (Pinoacres)";
            string body = "Tickets are availble for the current season being checked.  Get to a computer and order some now!";

            return CreateMLBEmailMessage(toEmail, subject, body);
        }

        public MimeMessage CreateMLBStartupEmail(string toEmail)
        {
            string subject = "Service Started - MLB Extra Bases Pinger (Pinoacres)";
            string body = "The MLB Extra Bases Pinger has been started on the Pinoacres server.  Email Generation Time: " + DateTime.Now;

            return CreateMLBEmailMessage(toEmail, subject, body);
        }
    }
}
