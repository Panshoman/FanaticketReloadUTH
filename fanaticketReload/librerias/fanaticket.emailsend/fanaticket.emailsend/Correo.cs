using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace fanaticket.emailsend
{
    public class sendEmail
    {
        public static string Error; //guarda el mensaje de erro
        public void emailing(string mail, string asunto, string contenido)
        {
            try
            {
                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress(mail));
                email.From = new MailAddress("incidenciasyeventos@gmail.com");
                //email.Subject = "Asunto ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
                email.Subject = asunto;
                email.Body = contenido;
                email.IsBodyHtml = true;
                email.Priority = MailPriority.Normal;

                // Create the credentials to login to the gmail account associated with my custom domain
                string sendEmailsFrom = "incidenciasyeventos@gmail.com";
                string sendEmailsFromPassword = "Eventos2017";
                NetworkCredential cred = new NetworkCredential(sendEmailsFrom, sendEmailsFromPassword);

                SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
                mailClient.EnableSsl = true;
                mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                mailClient.UseDefaultCredentials = false;
                mailClient.Timeout = 20000;
                mailClient.Credentials = cred;
                mailClient.Send(email);
            }
            catch (Exception)
            {

                Error = "No se puedo enviar su solicitud";
            }
        } 
    }
}
