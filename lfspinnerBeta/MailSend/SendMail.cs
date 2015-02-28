using lfspinnerBeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using lfspinnerBeta.I_SendMail;

namespace lfspinnerBeta.MailSend
{

    public class SendMail : ISendMail
    {
        private MailMessage mail = new MailMessage();
        private SmtpClient smtp = new SmtpClient();

        public SendMail(Mail _model)
        {
            
            mail.To.Add(_model.To);
            mail.From = new MailAddress(_model.From);
            mail.Subject = _model.Subject;
            string Body = _model.Body;
            mail.Body = Body;
            mail.IsBodyHtml = true;
        
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential
            ("bednarz.sebastian1@gmail.com", "go604CES");
            
        }
        public void setHost(string host)
        {
            smtp.Host = host;
        }
        public void setPort(int port)
        {
            smtp.Port = port;
           
        }
        public bool Send()
        {
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return true;
        }
        
    }
}