using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Net.Mail;


public partial class admin_contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }




  

    protected void btnEmail_Click(object sender, EventArgs e)
    {

        #region Sending Email

<<<<<<< HEAD
        string smtpText = "relay-hosting.secureserver.net";
        int portNumber = 25;
=======
        string smtpText = "smtp.gmail.com";
        int portNumber = 587;
        string userName = "bondelectric.noreply@gmail.com";
        string password = "Admin@123456";
       // string path = Server.MapPath("doc\\");
>>>>>>> fce48b032b58934f57024836247af066407eecaf

        string userName = "crypto.tradings.official@gmail.com";
        string password = "Crypto2020";

        try
        {

            SmtpClient smtp = new SmtpClient(smtpText, portNumber);

            smtp.EnableSsl = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            
           

            smtp.Credentials = new NetworkCredential(userName, password);
            MailMessage message = new MailMessage();
          
<<<<<<< HEAD
            message.To.Add("crypto.tradings.noreply@gmail.com");
=======
>>>>>>> fce48b032b58934f57024836247af066407eecaf
            message.To.Add("i8net2000@yahoo.com");

            //string toAddress = "";
            //foreach (var item in toAddress.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))                //Read from a string with ; as delimiter and split them and put them i an array



            message.From = new MailAddress(userName);
            message.Subject = first_name.Value + " " + last_name.Value + " (" + email_addressSend.Value + ")";
            message.IsBodyHtml = true;
            message.Body = "Email from (Email address: " + email_addressSend.Value + " , Phone number: " + phone.Value + ")<br />" + comments.Value;

            smtp.Send(message);

<<<<<<< HEAD
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
=======
         //   ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
>>>>>>> fce48b032b58934f57024836247af066407eecaf
            //Response.Redirect("contact.aspx.aspx");
            lblErrorHtml.InnerText = "Email has been sent ";
        }
        catch (Exception ex)
        {

            lblErrorHtml.InnerText = "Email has not been sent because " + ex.Message;
        }

        #endregion

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
}