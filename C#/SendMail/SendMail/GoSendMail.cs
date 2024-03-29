﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;

namespace SendMail
{
    class GoSendMail
    {
        public void Send(string smtpServer, string from, string password,
        string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                {
                    mail.Attachments.Add(new Attachment(attachFile));
                }

                //MessageBox.Show("good");
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 587; //google
                //client.Port = 465; //mail
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw new Exception("Mail.Send: " + e.Message);
            }
            MessageBox.Show(smtpServer + "; " + from + "; " + password + "; " + mailto + "; " + caption + "; " + message + "; " + attachFile);
        }
    }
}