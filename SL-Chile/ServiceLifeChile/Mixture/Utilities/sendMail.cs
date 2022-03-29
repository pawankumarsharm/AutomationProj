using ServiceLife_Chile.mixture_acids_validation.excel;
using ServiceLife_Chile.mixture_acids_validation.StepDefinations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLife_Chile.mixture_acids_validation.Utilities
{
    class sendMail
    {
        public static string currentdate = DateTime.Now.ToString();
        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\mixture_acids_validation");
        public static string _destpath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\mixture_acids_validation");
        private static string password = ConfigurationManager.AppSettings.Get("password");
        private static string fromEmail = ConfigurationManager.AppSettings.Get("fromEmail");
        private static string receivers = ConfigurationManager.AppSettings.Get("receivers");
        private static string receivers1 = ConfigurationManager.AppSettings.Get("receivers1");
        private static string receivers2 = ConfigurationManager.AppSettings.Get("receivers2");
        private static string receivers3 = ConfigurationManager.AppSettings.Get("receivers3");
        private static string receivers4 = ConfigurationManager.AppSettings.Get("receivers4");
        private static string receivers5 = ConfigurationManager.AppSettings.Get("receivers5");
        public static void SendReportinMail()
        {
            try
            {
                MailAddress addressFrom = new MailAddress(fromEmail, "NathcorpAutomationQA");
                MailAddress addressTo = new MailAddress(receivers);
                MailMessage message = new MailMessage(addressFrom, addressTo);
                //message.CC.Add(receivers1);
                //message.CC.Add(receivers2);
                //message.CC.Add(receivers3);
                //message.CC.Add(receivers4);
                //message.CC.Add(receivers5);
                //message.Headers[Date];
                message.Subject = "SLS V2 Test Automation Report run on " + currentdate + " on your local time.";
                string htmlString = @"<html>
                      <body>
                      <p>Dear SLS Users,</p>
                      <p>You are receiving this automatic email as you have run the SLS Automation Mixture Script for US or Canada Region.  </p>
                      <p>Please find the attached Test Run Result and the Test Run Log File.<p>
                      <p>Thanks & Regards,<br>-NathCorpAutomationTeam</br></p>
                      </body>
                      </html>
                     ";
                message.Body = htmlString;
                message.IsBodyHtml = true;
                string region = MixtureResultWriteExcel.SelectRegion();
                if (region == "United States")
                {
                    string _testReport = path + "\\TestResults" + "\\ServiceLifeResult_US(Mixture)" + ".xlsx";
                    string _log = _destpath + "\\Logs" + "\\Tc_RunLogsMixture" + ".log";
                    message.Attachments.Add(new Attachment(_testReport));
                    message.Attachments.Add(new Attachment(_log));
                }
                else
                {
                    string _testReport = path + "\\TestResults" + "\\ServiceLifeResult_Canada(Mixture)" + ".xlsx";
                    string _log = _destpath + "\\Logs" + "\\Tc_RunLogsMixture" + ".log";
                    message.Attachments.Add(new Attachment(_testReport));
                    message.Attachments.Add(new Attachment(_log));
                }
                //mail.Attachments.Add(new Attachment(""));
                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, password);
                smtp.EnableSsl = true;
                smtp.Send(message);


            }
            catch (Exception ex)
            {
                MixtureAcidValidationsSteps._logger.Error(ex);
            }
        }
    }
}
