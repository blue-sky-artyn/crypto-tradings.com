using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

using System.Net;
using System.Net.Mail;


public partial class admin_contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string contactDetStr = string.Empty;
        tblCompanyCollection CompanyTbl = new tblCompanyCollection();
        CompanyTbl.ReadList();

        tblStaffCollection staffTbl = new tblStaffCollection();
        staffTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, 2));


        #region conatct details

        managerSpeachHtml.InnerText = CompanyTbl[0].CoOwnerWord;
        coNameHtml.InnerText = CompanyTbl[0].CoName + " Contact details";
        
        if (CompanyTbl[0].CoOwner.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                            "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                            "<h3>Manager:</h3><p>" + CompanyTbl[0].CoOwner + "</p></div></div>";

        if (CompanyTbl[0].Tel.Trim().Length == 10)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Tel:</h3><a href='tel:" + CompanyTbl[0].Tel + "'>+1 (" + CompanyTbl[0].Tel.Substring(0,3) + ") " + CompanyTbl[0].Tel.Substring(3, CompanyTbl[0].Tel.Length - 3) + "</a></div></div>";
        else
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Tel:</h3><a href='tel:" + CompanyTbl[0].Tel + "'>+1 " + CompanyTbl[0].Tel + "</a></div></div>";
        

        if (CompanyTbl[0].Phone.Trim().Length == 10)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Phone:</h3><a href='tel:" + CompanyTbl[0].Phone + "'>+1 (" + CompanyTbl[0].Phone.Substring(0, 3) + ") "+ CompanyTbl[0].Phone.Substring(3, CompanyTbl[0].Phone.Length-3) + "</a></div></div>";
        else
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Phone:</h3><a href='tel:" + CompanyTbl[0].Phone + "'>+1 " + CompanyTbl[0].Phone + "</a></div></div>";

        if (CompanyTbl[0].Email.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Email:</h3><a href='email:" + CompanyTbl[0].Email + "'>" + CompanyTbl[0].Email + "</a></div></div>";

        if (CompanyTbl[0].Facebook.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Facebook:</h3><a href='" + CompanyTbl[0].Facebook + "'>" + CompanyTbl[0].Facebook + "</a></div></div>";

        if (CompanyTbl[0].Twitter.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Twitter:</h3><a href='" + CompanyTbl[0].Twitter + "'>" + CompanyTbl[0].Twitter + "</a></div></div>";

        if (CompanyTbl[0].Instagram.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Instagram:</h3><a href='" + CompanyTbl[0].Instagram + "'>" + CompanyTbl[0].Instagram + "</a></div></div>";

        if (CompanyTbl[0].Telegram.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Google+:</h3><a href='" + CompanyTbl[0].Telegram + "'>" + CompanyTbl[0].Telegram + "</a></div></div>";

        if (CompanyTbl[0].Linkedin.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>LinkedIn:</h3><a href='" + CompanyTbl[0].Linkedin + "'>" + CompanyTbl[0].Linkedin + "</a></div></div>";

        if (CompanyTbl[0].youtube.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>YouTube:</h3><a href='" + CompanyTbl[0].youtube + ">" + CompanyTbl[0].youtube + "</a></div></div>";

        if (CompanyTbl[0].website.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Website:</h3><a href='" + CompanyTbl[0].website + "'>" + CompanyTbl[0].website + "</a></div></div>";

        contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Address:</h3><p>" + CompanyTbl[0].CoAddr + "</p></div></div>";

        contactDetailsHtml.InnerHtml = contactDetStr;
        #endregion


        #region Staff details
        contactDetStr = "";
        
        if (staffTbl[0].StaffName.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                            "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                            "<h3>Member of company:</h3><p>" + staffTbl[0].StaffName + " " + staffTbl[0].StaffFamily + "</p></div></div>";
        
        if (staffTbl[0].SatffTel.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Tel:</h3><a href='tel:"+ staffTbl[0].SatffTel + "'> +1 (" + staffTbl[0].SatffTel.Substring(0,3) +") "+ staffTbl[0].SatffTel.Substring(3, staffTbl[0].SatffTel.Length-3) + "</a></div></div>";

        if (staffTbl[0].StaffMobile.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Phone:</h3><a href='tel:"+ staffTbl[0].StaffMobile+"'> +1 (" + staffTbl[0].StaffMobile.Substring(0,3) + ") " + staffTbl[0].StaffMobile.Substring(3, staffTbl[0].StaffMobile.Length - 3)  + " </a></div></div>";

        if (staffTbl[0].StaffEmail.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Email:</h3><a href='email:" + staffTbl[0].StaffEmail + "'>" + staffTbl[0].StaffEmail + "</a></div></div>";

        if (staffTbl[0].StaffJobPosition.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Facebook:</h3><a href='" + staffTbl[0].StaffJobPosition + "'>" + staffTbl[0].StaffJobPosition + "</a></div></div>";

        if (staffTbl[0].StaffPicName.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Twitter:</h3><a href='" + staffTbl[0].StaffPicName + "'>" + staffTbl[0].StaffPicName + "</a></div></div>";

        if (staffTbl[0].StaffCertificate.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Instagram:</h3><a href='" + staffTbl[0].StaffCertificate + "'>" + staffTbl[0].StaffCertificate + "</a></div></div>";

        if (staffTbl[0].StaffPicAddr.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>LinkedIn:</h3><a href='" + staffTbl[0].StaffPicAddr + "'>" + staffTbl[0].StaffPicAddr + "</a></div></div>";

        if (staffTbl[0].StaffUsername.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>YouTube:</h3><a href='" + staffTbl[0].StaffUsername + ">" + staffTbl[0].StaffUsername + "</a></div></div>";
        
        if (staffTbl[0].StaffWords.Trim().Length > 0)
            contactDetStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='icon-wrapper wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s' style='visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;'>" +
                        "<h3>Word of member:</h3><p>" + staffTbl[0].StaffWords + "</p></div></div>";

        userDetHtml.InnerHtml = contactDetStr;
        #endregion

        #region header top picture
        tblLogsCollection picTopTbl = new tblLogsCollection();
        picTopTbl.ReadList();
        if (picTopTbl.Count > 0)
            headerPicHtml.Attributes["style"] = "background: url(" + picTopTbl[0].logDetail + ")no-repeat;background-size: cover;background-position: center;";
        #endregion

    }

    protected void btnEmail_Click(object sender, EventArgs e)
    {

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
            message.To.Add("i8net2000@yahoo.com");


            //string toAddress = "";
            //foreach (var item in toAddress.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))                //Read from a string with ; as delimiter and split them and put them i an array



            message.From = new MailAddress(userName);
            message.Subject = "sbj tst";//first_name.Value + " " + last_name.Value + " (" + phone.Value + ")";
            message.Body = "testttttttttttt";//comments.Value;

            smtp.Send(message);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
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
        lblErrorHtml.InnerText = "test";
        lblErrorHtml.InnerText = "test";
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
}