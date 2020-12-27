using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Net.Mail;


public partial class send_email : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        #region items to get

        string first_name = "";string last_name = "";string email = "";string phone = ""; string comments = "";
        if (Request.QueryString["first_name"] != null)
        {
            first_name = Request.QueryString["first_name"];
            last_name = Request.QueryString["last_name"];
            email = Request.QueryString["email"];
            phone = Request.QueryString["phone"];
            comments = Request.QueryString["comments"];
        }
        else
            Response.Redirect("contact.aspx");


        #endregion


        #region Sending Email

        string smtpText = "smtp.gmail.com";
        int portNumber = 587;
        string userName = "bondelectric.noreply@gmail.com";
        string password = "Admin@123456";
        string path = Server.MapPath("doc\\");


        try
        {

            SmtpClient smtp = new SmtpClient(smtpText, portNumber);

            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential(userName, password);
            MailMessage message = new MailMessage();
            message.To.Add("info@bondelectric.ca");
            

            message.From = new MailAddress(userName);
            message.Subject = first_name + " " + last_name + " (" + phone + ")";
            message.Body = comments;

            smtp.Send(message);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
            Response.Redirect("contact.aspx?err=Email has been sent ");
        }
        catch (Exception ex)
        {
            Response.Redirect("contact.aspx?err=Email has not been sent because " + ex.Message);
        }

        #endregion

    }
}