using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsMapWeb.ADT
{
    using System;
    using System.Web.UI.WebControls;
    using System.Net.Mail;

    public partial class MailManager
    {


        public static void SendMail(String content,String toMail)
        {
            SmtpClient smtpClient = new SmtpClient("sendgrid.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("soporte.formsmap@gmail.com", "1234");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mailMessage = new MailMessage("soporte.formsmap@gmail.com", toMail);
            mailMessage.Body = content;

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Console.Out.Write(ex);
            }
        }
    }
}