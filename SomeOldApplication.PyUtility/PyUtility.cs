using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;

namespace SomeOldApplication.PyUtility
{
    public class PyUtility
    {
        public void WriteToLog(string message)
        {
            string path = @"c:\ddd\logs.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(message);
                }
            }
        }

        public void SendMail(string to, string from, string subject, string body, IList<Attachment> attachments, string serverName)
        {
            Console.WriteLine("sending email");

            var tos = SetEmailAddresses(to);

            using (var client = new SmtpClient(serverName))
            {
                Email
                    .From(from)
                    .To(tos)
                    .Body(body)
                    .Subject(subject)
                    .Attach(attachments)
                    .UsingClient(client)
                    .Send();
                //WriteToLog("Email sent.");
            }
        }

        public void SendMail(string to, string from, string subject, string body, Attachment attachment, string serverName)
        {
            Console.WriteLine("sending email");

            var tos = SetEmailAddresses(to);

            using (var client = new SmtpClient(serverName))
            {
                Email
                    .From(from)
                    .To(tos)
                    .Body(body)
                    .Subject(subject)
                    .Attach(attachment)
                    .UsingClient(client)
                    .Send();
                //WriteToLog("Email sent.");
            }
        }

        private static List<MailAddress> SetEmailAddresses(string to)
        {
            char[] splitChar = to.Contains(';') ? new[] { ';' } : (to.Contains(',') ? new[] { ',' } : null);
            var tos = to.Split(splitChar).Select(x => new MailAddress(x.Trim())).ToList();
            return tos;
        }

        public void SendMail(string to, string cc, string from, string subject, string body, Attachment attachment, string serverName)
        {
            Console.WriteLine("sending email");

            var tos = SetEmailAddresses(to);
            var ccs = SetEmailAddresses(cc);

            using (var client = new SmtpClient(serverName))
            {
                Email
                    .From(from)
                    .To(tos)
                    .CC(ccs)
                    .Body(body)
                    .Subject(subject)
                    .Attach(attachment)
                    .UsingClient(client)
                    .Send();
                //WriteToLog("Email sent.");
            }
        }

        public void SendMail(string to, string from, string subject, string body, string serverName)
        {
            Console.WriteLine("sending email");

            var tos = SetEmailAddresses(to);

            using (var client = new SmtpClient(serverName))
            {
                Email
                    .From(from)
                    .To(tos)
                    .Body(body)
                    .Subject(subject)
                    .UsingClient(client)
                    .Send();
            }
        }

        public void SendMail(string to, string cc, string from, string subject, string body,
            IList<Attachment> attachments, string serverName)
        {
            Console.WriteLine("sending email");

            var tos = SetEmailAddresses(to);
            var ccs = SetEmailAddresses(cc);

            using (var client = new SmtpClient(serverName))
            {
                Email
                    .From(from)
                    .To(tos)
                    .CC(ccs)
                    .Body(body)
                    .Subject(subject)
                    .Attach(attachments)
                    .UsingClient(client)
                    .Send();
                //WriteToLog("Email sent.");
            }
        }
    }
}
