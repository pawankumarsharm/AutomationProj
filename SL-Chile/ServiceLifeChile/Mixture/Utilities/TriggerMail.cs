using ServiceLife_Chile.mixture_acids_validation.excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLife_Chile.mixture_acids_validation.Utilities
{
    class TriggerMail
    {
        public static string currentdate = DateTime.Now.ToString();
        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\mixture_acids_validation");
        public static string _destpath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\mixture_acids_validation\\Logs");
        private static string password = ConfigurationManager.AppSettings.Get("password");
        private static string fromEmail = ConfigurationManager.AppSettings.Get("fromEmail");
        private static string receivers = ConfigurationManager.AppSettings.Get("receivers");
        public static void SendMail()
        {

            SmtpClient mail = new SmtpClient();
            mail.UseDefaultCredentials = false;
            mail.Credentials = new System.Net.NetworkCredential(fromEmail, password);
            mail.Host = "smtp.office365.com";
            mail.Port = 25;
            mail.EnableSsl = true;
            MailMessage message = new MailMessage(fromEmail, receivers);
            // message.CC.Add(receivers1);

            //message.Headers[Date];
            message.Subject = "SLS V2 Test Automation Report run on " + currentdate + " on your local time.";
            string htmlString = @"<html>
                      <body>
                      <p>Dear SLS Users,</p>
                      <p>You are receiving this automatic email as you have run the SLS Automation Script for US or Canada Region.  </p>
                      <p>Please find the attached Test Run Result and the Test Run Log File.<p>
                      <p>Thanks & Regards,<br>-NathCorpAutomationTeam</br></p>
                      </body>
                      </html>
                     ";
            message.Body = htmlString;
            message.IsBodyHtml = true;
            //mail.Body = htmlString;
            //message.IsBodyHtml = true;
            string region = MixtureResultWriteExcel.SelectRegion();
            if (region == "United States")
            {
                string _testReport = path + "\\TestResults" + "\\ServiceLifeResult_US(Mixture)" + ".xlsx";
                string _log = _destpath + "\\ServiceLifeMixture" + ".log";
                message.Attachments.Add(new Attachment(_testReport));
                message.Attachments.Add(new Attachment(_log));
            }
            else
            {
                string _testReport = path + "\\TestResults" + "\\ServiceLifeResult_Canada(Mixture)" + ".xlsx";
                string _log = _destpath + "\\ServiceLifeMixture" + ".log";
                message.Attachments.Add(new Attachment(_testReport));
                message.Attachments.Add(new Attachment(_log));
            }
            mail.Send(message);

        }
    }
}
