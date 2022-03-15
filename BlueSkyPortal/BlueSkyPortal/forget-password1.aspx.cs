using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;



public partial class admin_login : System.Web.UI.Page
{
    string random1;

    protected void Page_Load(object sender, EventArgs e)
    {

    }



<<<<<<< HEAD

    protected void Button1_Click(object sender, EventArgs e)
    {
      
        int i1;
        i1 = 0;

        txtEmail.Value = "sfswfs";



        //ایمیل وجود داشته باشد
        using (DataSetTableAdapters.CustomerTableAdapter ins1 = new DataSetTableAdapters.CustomerTableAdapter())
        {
            DataSet.CustomerDataTable ne1 = ins1.search_email1_customer(txtEmail.Value);
            foreach (DataSet.CustomerRow row3 in ne1)
            {
                i1 = 1;
                //***********تولید پسورد
                string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
                string numbers = "1234567890";
                string ii;
                ii = "1";

                string characters = numbers;
                if (ii == "1")
                {
                    characters += alphabets + small_alphabets + numbers;
                }
                int length = 8;
                string otp = string.Empty;
                for (int i = 0; i < length; i++)
                {
                    string character = string.Empty;
                    do
                    {
                        int index = new Random().Next(0, characters.Length);
                        character = characters.ToCharArray()[index].ToString();
                    } while (otp.IndexOf(character) != -1);
                    otp += character;
                }
                random1 = otp;
                //**************
           
                //**********************
                //تغییر پسورد

                using (DataSetTableAdapters.CustomerTableAdapter ins5 = new DataSetTableAdapters.CustomerTableAdapter())
                {

                    ins5.update_pass_customer(txtEmail.Value, random1);
                  
                }


                //*******************آرسال ایمیل تغییر پسورد
                #region Sending Email

                string body;
                string sub;
                body = "";
                sub = "";
                string smtpText = "smtp.gmail.com";
                int portNumber = 587;
                string userName = "cryptotrading3535@gmail.com";
                string password = "trading3535";
                //ارسال ایمیل
                body = "";
                sub = "";







                try
                {

                    SmtpClient smtp = new SmtpClient(smtpText, portNumber);

                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;

                    smtp.Credentials = new NetworkCredential(userName, password);
                    MailMessage message = new MailMessage();

                    message.To.Add(txtEmail.Value);


                    //string toAddress = "";
                    //foreach (var item in toAddress.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))                //Read from a string with ; as delimiter and split them and put them i an array



                    message.From = new MailAddress(userName);
                    message.Subject = sub;//first_name.Value + " " + last_name.Value + " (" + phone.Value + ")";
                    message.Body = body;//comments.Value;

                    smtp.Send(message);

                    //   ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
                    //Response.Redirect("contact.aspx.aspx");
                    //   lblErrorHtml.InnerText = "Email has been sent ";
                }
                catch (Exception ex)
                {

                    //  lblErrorHtml.InnerText = "Email has not been sent because " + ex.Message;
                }






                //   send_email(random1, txtEmail.Value);
                //   Response.Redirect("~/Default.aspx");


                //************send email**********************


            }
        }


        if (i1 == 0)
        {
            Response.Redirect("~/Default.aspx");

=======
    public int send_email(string pass, string email)
    {
        /*
        //*******************آرسال ایمیل تغییر پسورد
        #region Sending Email

        string smtpText = "smtp.gmail.com";
        int portNumber = 587;
        string userName = "bondelectric.noreply@gmail.com";
        string password = "Admin@123456";
        // string path = Server.MapPath("doc\\");


        try
        {

            SmtpClient smtp = new SmtpClient(smtpText, portNumber);

            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential(userName, password);
            MailMessage message = new MailMessage();

            message.To.Add(email);


            //string toAddress = "";
            //foreach (var item in toAddress.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))                //Read from a string with ; as delimiter and split them and put them i an array



            message.From = new MailAddress(userName);
            message.Subject = "sbj tst";//first_name.Value + " " + last_name.Value + " (" + phone.Value + ")";
            message.Body = "testttttttttttt";//comments.Value;

            smtp.Send(message);

            //   ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
            //Response.Redirect("contact.aspx.aspx");
      //      lblErrorHtml.InnerText = "Email has been sent ";
        }
        catch (Exception ex)
        {

        //    lblErrorHtml.InnerText = "Email has not been sent because " + ex.Message;
>>>>>>> fce48b032b58934f57024836247af066407eecaf
        }



<<<<<<< HEAD









        #endregion




        //*********************************************             
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        int i1;
        i1 = 0;

      
=======
    
    */

        return 3;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      
        int i1;
        i1 = 0;


>>>>>>> fce48b032b58934f57024836247af066407eecaf



        //ایمیل وجود داشته باشد
        using (DataSetTableAdapters.CustomerTableAdapter ins1 = new DataSetTableAdapters.CustomerTableAdapter())
        {
            DataSet.CustomerDataTable ne1 = ins1.search_email1_customer(txtEmail.Value);
            foreach (DataSet.CustomerRow row3 in ne1)
            {
                i1 = 1;
                //***********تولید پسورد
                string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
                string numbers = "1234567890";
                string ii;
                ii = "1";

                string characters = numbers;
                if (ii == "1")
                {
                    characters += alphabets + small_alphabets + numbers;
                }
                int length = 8;
                string otp = string.Empty;
                for (int i = 0; i < length; i++)
                {
                    string character = string.Empty;
                    do
                    {
                        int index = new Random().Next(0, characters.Length);
                        character = characters.ToCharArray()[index].ToString();
                    } while (otp.IndexOf(character) != -1);
                    otp += character;
                }
                random1 = otp;
                //**************
<<<<<<< HEAD

=======
           
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                //**********************
                //تغییر پسورد

                using (DataSetTableAdapters.CustomerTableAdapter ins5 = new DataSetTableAdapters.CustomerTableAdapter())
                {

                    ins5.update_pass_customer(txtEmail.Value, random1);
<<<<<<< HEAD

                }


                //*******************آرسال ایمیل تغییر پسورد
                #region Sending Email

                string body;
                string sub;
                body = "";
                sub = "";
                string smtpText = "smtp.gmail.com";
                int portNumber = 587;
                string userName = "cryptotrading3535@gmail.com";
                string password = "trading3535";
                //ارسال ایمیل
                body = "";
                sub = "";







                try
                {

                    SmtpClient smtp = new SmtpClient(smtpText, portNumber);

                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;

                    smtp.Credentials = new NetworkCredential(userName, password);
                    MailMessage message = new MailMessage();

                    message.To.Add(txtEmail.Value);


                    //string toAddress = "";
                    //foreach (var item in toAddress.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))                //Read from a string with ; as delimiter and split them and put them i an array



                    message.From = new MailAddress(userName);
                    message.Subject = "Change password";//first_name.Value + " " + last_name.Value + " (" + phone.Value + ")";
                    message.Body = "new password ="+random1;//comments.Value;

                    smtp.Send(message);

                    //   ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
                    //Response.Redirect("contact.aspx.aspx");
                    //   lblErrorHtml.InnerText = "Email has been sent ";
                }
                catch (Exception ex)
                {

                    //  lblErrorHtml.InnerText = "Email has not been sent because " + ex.Message;
                }






                //   send_email(random1, txtEmail.Value);
                   Response.Redirect("~/Default.aspx");


                //************send email**********************
=======
                    Response.Redirect("~/Default.aspx");
                }


                //************send email**********************
             send_email(random1, txtEmail.Value);
>>>>>>> fce48b032b58934f57024836247af066407eecaf


            }
        }


        if (i1 == 0)
        {
<<<<<<< HEAD
            Response.Redirect("~/Default.aspx");
=======

>>>>>>> fce48b032b58934f57024836247af066407eecaf

        }












<<<<<<< HEAD
        #endregion

=======





        //*********************************************             
>>>>>>> fce48b032b58934f57024836247af066407eecaf
    }
}