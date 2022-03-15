using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD
using System.Net;
using System.Net.Mail;

public partial class dashboard_login : System.Web.UI.Page
{
    string id_customer;
    protected void Page_Load(object sender, EventArgs e)
    {
        string email = Txt_email.Value;
        string s;
        s = "";

        string name_plan;
        name_plan = "";

        string price_start;
        price_start = "";

        string date_start;
        date_start = "";


        if (Request.Cookies["Logincustomer"] == null)
        {
            Response.Redirect("~/login-f.aspx");
        }
        //ثبت جدول

        // date1 = date1.Remove(10, 9);
        if (Convert.ToString(Session["id_customer"]) == "")
        {
            Response.Redirect("~/login-f.aspx");
        }
        else
        {
            id_customer = Convert.ToString(Session["id_customer"]);

        }

        //customer moshakhasat
        if (!IsPostBack)
        {

            using (DataSetTableAdapters.CustomerTableAdapter ins11 = new DataSetTableAdapters.CustomerTableAdapter())
            {
                DataSet.CustomerDataTable ne11 = ins11.search_idcustomer(Convert.ToInt32(id_customer));
                foreach (DataSet.CustomerRow row3 in ne11)
                {
                    Literal1_name.Text = row3.Name_customer;
                    Literal2_referal.Text = row3.referal_code;
                    Literal3_email.Text = row3.Email_custemer;
                    Literal1_referl1.Text = row3.referal_code;
                    txtFamily.Text = row3.Name_customer;
                    txtAddr.Text = row3.Valet__custemer;
                    Txt_email.Value = row3.Email_custemer;

                }

            }



           



            //*************************************












        }





=======

public partial class dashboard_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string email = txtEmail.Value;
>>>>>>> fce48b032b58934f57024836247af066407eecaf
    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
<<<<<<< HEAD
        if(txtAddr.Text != "")
        {
            //*************cash*ذخیره کش
            using (DataSetTableAdapters.CustomerTableAdapter ins1 = new DataSetTableAdapters.CustomerTableAdapter())
            {

                ins1.Update_cusomer_referal(txtAddr.Text, Txt_email.Value,Convert.ToInt32(id_customer));
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }
            //////////send   email

            #region Sending Email

            string smtpText = "relay-hosting.secureserver.net";
            int portNumber = 25;

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

                message.To.Add(Txt_email.Value);
             //   message.To.Add("i8net2000@yahoo.com");

                //string toAddress = "";
                //foreach (var item in toAddress.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))                //Read from a string with ; as delimiter and split them and put them i an array



                message.From = new MailAddress(userName);
                message.Subject = "Change Wallet";
                message.IsBodyHtml = true;
                message.Body = "Your Wallet address has changed-Wallet:"+ txtAddr.Text;

                smtp.Send(message);

                //ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
                //Response.Redirect("contact.aspx.aspx");
               // lblErrorHtml.InnerText = "Email has been sent ";
            }
            catch (Exception ex)
            {

             //   lblErrorHtml.InnerText = "Email has not been sent because " + ex.Message;
            }

            #endregion



            //*********************************

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["id_customer"] = "";
        Session["email_customer"] = "";
        Session["name_customer"] = "";

        Response.Cookies["Logincustomer"].Expires = DateTime.Now.AddDays(-1);
        Response.Redirect("~/Default.aspx");
        //  Response.Cookies.Clear();


=======
>>>>>>> fce48b032b58934f57024836247af066407eecaf

    }
}