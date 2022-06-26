using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using ShopOnline.ViewModel;
using ShopOnline.Models;



namespace ShopOnline
{
    public partial class ContactForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_send_click(object sender, EventArgs e)
        {
            try
            {
             
                var from = "yourgmailadreess@gmail.com";
                var to = "yourgmailadreess@gmail.com";
                const string Password = "yourmailpassword";


                string mail_subject = text_subject.Text.ToString();

         
                string mail_message = "From: " + text_name.Text + "\n";
                mail_message += "Email: " + text_email.Text + "\n";
                mail_message += "Subject: " + text_subject.Text + "\n";
                mail_message += "Phone: " + text_phone.Text + "\n";
                mail_message += "Message: \n" + text_message.Text + "\n";



                var smtp = new SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, Password);
                    smtp.Timeout = 20000;
                }

                smtp.Send(from, to, mail_subject, mail_message);

                Confirm();

                confirm.Text = "Thanks for contacting us! We will be in touch with you shortly";

                text_subject.Text = "";
                text_name.Text = "";
                text_email.Text = "";
                text_phone.Text = "";
                text_message.Text = "";


            }

     
            catch (Exception)
            {
                confirm.Text = "<p> Oh no! <br> Something went wrong while sending your message ";
                confirm.ForeColor = Color.Red;
            }
        }

        private void Confirm()
        {
            string ToEmail = text_email.Text.Trim();
            string UserName = text_name.Text;
            string subject2 = text_subject.Text;

            MailMessage mailMessage = new MailMessage("yourgmailadreess@gmail.com", ToEmail);



            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("Dear " + UserName + ",<br/><br/>");
            sbEmailBody.Append("Thank you for reaching us!<br/>");
            sbEmailBody.Append("We received you message regarding: " + subject2 + "<br/>");
            sbEmailBody.Append("We will be back to you within 2 working days. It might take a little longer on evenings and weekends but we want" +
                " you to know that we are doing our best to get back to you as soon as possible");
            sbEmailBody.Append("<br/><br/><br/>");
            sbEmailBody.Append("Sincerely, <br/>");
            sbEmailBody.Append("<b>Rasca Rafael</b>");


        
            mailMessage.IsBodyHtml = true;

            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = "Re: Thank you for your email";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "yourgmailadreess@gmail.com",
                Password = "yourmailpassword"
            };


            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Shopping/Index");
        }
    }
}