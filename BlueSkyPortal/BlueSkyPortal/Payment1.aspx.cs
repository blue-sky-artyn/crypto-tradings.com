using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QRCoder;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Mail;


public partial class admin_service : System.Web.UI.Page
{
    string code_moaref;
    string id_customer;
    string id_customer_moaref;
    string valet_moaref;
    string id_plan;
    string vam;
    string darsadsod_moaref;
    int planasli;
    protected SqlConnection Connection;
    protected SqlCommand command;
    protected SqlDataReader dataReader;
    


   





    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Cookies["Logincustomer"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }




        //ثبت جدول
     


            id_customer = Convert.ToString(Session["id_customer"]);
          //  id_customer = "1";
            //  جستجو مشتری



            //*******************************

            using (DataSetTableAdapters.CustomerTableAdapter ins11 = new DataSetTableAdapters.CustomerTableAdapter())
            {
                DataSet.CustomerDataTable ne11 = ins11.search_idcustomer(Convert.ToInt32(id_customer));
                foreach (DataSet.CustomerRow row3 in ne11)
                {
                    Txt_valetcustomer.Text = row3.Valet__custemer;
                    code_moaref = row3.code_moaref;

                }

            }



        //**************جستجو ولت
        string valet_Lottery;
        valet_Lottery = "";
        using (DataSetTableAdapters.email_registerTableAdapter pass19 = new DataSetTableAdapters.email_registerTableAdapter())
        {
            DataSet.email_registerDataTable mess19 = pass19.select_email1   ();
            foreach (DataSet.email_registerRow date219 in mess19)
            {
                valet_Lottery = date219.Desk_emilregister1;
                Txt_Price.Text = "10";

            }
        }






        DateTime localDate = DateTime.Now;
        string date1;
        date1 = Convert.ToString(localDate);
        date1 = date1.Remove(10, 9);


        Txt_nameplan.Text = "Lottery";
                    Txt_valetcompani.Text = valet_Lottery;
                    Txt_date.Text = date1;
       
                  
                 

              






                    //تولیدqr
                    string code = Txt_valetcompani.Text;
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
        System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
        imgBarCode.Height = 150;
        imgBarCode.Width = 150;
        using (Bitmap bitMap = qrCode.GetGraphic(20))
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
            }
            
            plBarCode.Controls.Add(imgBarCode);
       
    }





}





    protected void btnGenerate_Click(object sender, EventArgs e)
    {
        
        string code ="jbkjjhhjh";
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
        System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
        imgBarCode.Height = 50;
        imgBarCode.Width = 50;
        using (Bitmap bitMap = qrCode.GetGraphic(20))
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
            }
           plBarCode.Controls.Add(imgBarCode);
        }
    }












    protected void btnEmail_Click(object sender, EventArgs e)
    {


        //ارسال ایمیل
        string body;
        string sub;
        body = "";
        sub = "";

        //////////searhccash
        if (Txt_tefrence.Text == "")
        {
            Label1.Text = "Fill the hash";
            //  Response.Write("<script>alert('login successful');</script>");
            return;

        }
        int statusehash;
        statusehash = 0;
        ////////////////////////////////////

        using (DataSetTableAdapters.CashTableAdapter ins11 = new DataSetTableAdapters.CashTableAdapter())
        {
            DataSet.CashDataTable ne11 = ins11.search_hashcash1(Txt_tefrence.Text);
            foreach (DataSet.CashRow row1 in ne11)
            {
                statusehash = 1;
            }
        }

        if (statusehash == 1)
        {
            Label1.Text = "Hash that invalid-444";
            //  Response.Write("<script>alert('login successful');</script>");
            return;

        }

        ///////////search  hasj in api
        try
        {
            string transfer;
            transfer = Txt_tefrence.Text;
            int price_malett;
            price_malett = Convert.ToInt32(Txt_Price.Text);
            price_malett = price_malett * 1000000;


            string url;
            url = "https://api.trongrid.io/event/transaction/" + transfer;

            string result = ApiHelper.ExecuteWebApiRequest(new WebApiRequestModel
            {
                RequestUri = url,
                RequestMethod = "get"
            });


            var t = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TransferResult>>(result);
            ////////////wallet  compani 
            if (Txt_valetcompani.Text != t[0].result.to)
            {
            //    Label1.Text = "Hash that invalid";
                //  Response.Write("<script>alert('login successful');</script>");
            //    return;

            }

            if (Convert.ToString(price_malett) != t[0].result.value.ToString())
            {
                Label1.Text = "Price that invalid";
                //  Response.Write("<script>alert('login successful');</script>");
                return;

            }

            //   Label1.Text = t[0].caller_contract_address;
            ///    Label2.Text = t[0].result.from;
            //   Label3.Text = t[0].result.to;
            //   Label4.Text = t[0].result.value.ToString();

        }
        catch (Exception ex)
        {
            Label1.Text = "Hash that invalid";
            return;
        }



        //*********************************************













        using (DataSetTableAdapters.email_registerTableAdapter pass12 = new DataSetTableAdapters.email_registerTableAdapter())
        {
            DataSet.email_registerDataTable mess12 = pass12.Search_email1();
            foreach (DataSet.email_registerRow date212 in mess12)
            {
                body = date212.Body1;
                sub = date212.Subject1;

            }
        }

        //*********


        ///حذف      شانس

        DateTime localDate = DateTime.Now;
        string date1;
        date1 = Convert.ToString(localDate);
        date1 = date1.Remove(10, 9);

        using (DataSetTableAdapters.shansTableAdapter ins1 = new DataSetTableAdapters.shansTableAdapter())
        {

            ins1.Delete_shansemail_date((Convert.ToString(Session["email_customer"])), date1);
            //   Response.Redirect("~/Default.aspx");
        }

        //ذخیره در صندوق
        string date12;
        DateTime localDate11 = DateTime.Now;
        date12 = localDate11.ToString("yyyy/MM/dd");

        using (DataSetTableAdapters.lotteryTableAdapter ins11 = new DataSetTableAdapters.lotteryTableAdapter())
        {

            ins11.Insert_lottory(Txt_Price.Text,Convert.ToInt32(id_customer), date12, Txt_valetcompani.Text, 0, "");

        }


        using (DataSetTableAdapters.CashTableAdapter ins1 = new DataSetTableAdapters.CashTableAdapter())
        {

            ins1.Insert(Convert.ToInt32(id_customer), Txt_Price.Text, "0", date12 , Txt_valetcompani.Text, Txt_tefrence.Text, 0, "20", date12);
            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
        }


        Response.Redirect("~/Default.aspx");
        //**************************

        /*


 //  جستجو پلن 1 باشد
         if (planasli == 1)
         {


             //   DateTime localDate = DateTime.Now;
             //   string date;
             int roz_seporde;
             roz_seporde = 0;
             Double darsad_subplan;
             darsad_subplan = 0;
             string darsad_moaref;
             string min_subplan;
             min_subplan = "";
             string max_subplan;
             max_subplan = "";


             Double darsad;
             Double darsad_roz;
             Double sum;

             int i;
             int tedad_roz;


             //مشخصات پلن

             using (DataSetTableAdapters.Sub_plansTableAdapter ins11 = new DataSetTableAdapters.Sub_plansTableAdapter())
             {
                 DataSet.Sub_plansDataTable ne11 = ins11.Search_subplanid(Convert.ToInt32(id_plan));
                 foreach (DataSet.Sub_plansRow row1 in ne11)
                 {
                     roz_seporde = row1.Period;
                     darsad_subplan = Convert.ToDouble(row1.Darsad);
                     darsad_moaref = row1.Moaref_darsad;
                     min_subplan = row1.Min_price;
                     max_subplan = row1.Max_price;
                     vam = row1.Debit;





                 }

             }
             //اعتبار سنجی ها


             //مبلغ کمتر از حد پلن نباشه

             if ((Convert.ToInt32(Txt_Price.Text)) < (Convert.ToInt32(min_subplan)))
             {



             }



             //************
             //مبلغ بیشتر از حد پلن نباشه

             if ((Convert.ToInt32(Txt_Price.Text)) > (Convert.ToInt32(max_subplan)))
             {



             }






             //**************************
             //***************
             // مشخصات مشتری

             //***************
             //جستجو در سایت جهت تایید تراکنش


             //**********************
             DateTime localDate1 = DateTime.Now;
             string date1;
             int Max_cash;
             Max_cash = 0;
             //*************cash*ذخیره کش
             using (DataSetTableAdapters.CashTableAdapter ins1 = new DataSetTableAdapters.CashTableAdapter())
             {

                 ins1.Insert(Convert.ToInt32(id_customer), Txt_Price.Text, "0", Convert.ToString(localDate1), Txt_valetcompani.Text, "", 0, "", "");
                 //   Response.Redirect("~/Admin/Insert_mp3.aspx");
             }

             //*******************Max cash

             Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
             command = new SqlCommand();
             command.Connection = Connection;
             Connection.Open();

             command.CommandText = "Max_factore";
             command.CommandType = System.Data.CommandType.StoredProcedure;
             if (dataReader.Read())
             {
                 Max_cash = Convert.ToInt32(dataReader["Code_cash"].ToString());

             }





             //******************محاسبه سود معرف
             Double sum_moaref;
             sum_moaref = Convert.ToInt32(Txt_Price.Text) * (Convert.ToInt32(darsadsod_moaref) / 100);


             //************************




             //*************************
             //ذخیره فاکتور
             //*****************
             darsad_roz = ((Convert.ToInt32(Txt_Price.Text) * (darsad_subplan / 100)) / roz_seporde);
             for (i = 0; i <= roz_seporde; i++)
             {
                 sum = (Convert.ToInt32(Txt_Price.Text) + (darsad_roz * i));
                 localDate1 = localDate1.AddDays(1);
                 date1 = localDate1.ToString("yyyy/MM/dd");

                 //ذخیره فاکتور
                 using (DataSetTableAdapters.FactoreTableAdapter ins1 = new DataSetTableAdapters.FactoreTableAdapter())
                 {

                     ins1.Insert(Convert.ToInt32(id_plan), Convert.ToInt32(id_customer), Txt_date.Text, Txt_Price.Text, vam, Convert.ToString(sum), date1, Convert.ToString(darsad_subplan),
                         Txt_valetcustomer.Text, valet_moaref, Convert.ToInt32(id_customer_moaref), Convert.ToString(sum_moaref), 0, 0, "", "", "", Max_cash);
                     //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                 }




             }














             //***********
             //واریز به حساب معرف

             //************
         }

 //**************انتهای پلن1
         //****************

  if (planasli == 2 )
         {

             if (planasli == 1)
             {


                 //   DateTime localDate = DateTime.Now;
                 //   string date;
                 int roz_seporde;
                 roz_seporde = 0;
                 Double darsad_subplan;
                 darsad_subplan = 0;
                 string darsad_moaref;
                 string min_subplan;
                 min_subplan = "";
                 string max_subplan;
                 max_subplan = "";


                 Double darsad;
                 Double darsad_roz;
                 Double sum;

                 int i;
                 int tedad_roz;


                 //مشخصات پلن

                 using (DataSetTableAdapters.Sub_plansTableAdapter ins11 = new DataSetTableAdapters.Sub_plansTableAdapter())
                 {
                     DataSet.Sub_plansDataTable ne11 = ins11.Search_subplanid(Convert.ToInt32(id_plan));
                     foreach (DataSet.Sub_plansRow row1 in ne11)
                     {
                         roz_seporde = row1.Period;
                         darsad_subplan = Convert.ToDouble(row1.Darsad);
                         darsad_moaref = row1.Moaref_darsad;
                         min_subplan = row1.Min_price;
                         max_subplan = row1.Max_price;
                         vam = row1.Debit;





                     }

                 }
                 //اعتبار سنجی ها


                 //مبلغ کمتر از حد پلن نباشه

                 if ((Convert.ToInt32(Txt_Price.Text)) < (Convert.ToInt32(min_subplan)))
                 {



                 }



                 //************
                 //مبلغ بیشتر از حد پلن نباشه

                 if ((Convert.ToInt32(Txt_Price.Text)) > (Convert.ToInt32(max_subplan)))
                 {



                 }






                 //**************************
                 //***************
                 // مشخصات مشتری

                 //***************
                 //جستجو در سایت جهت تایید تراکنش


                 //**********************
                 DateTime localDate1 = DateTime.Now;
                 string date1;
                 int Max_cash;
                 Max_cash = 0;
                 //*************cash*ذخیره کش
                 using (DataSetTableAdapters.CashTableAdapter ins1 = new DataSetTableAdapters.CashTableAdapter())
                 {

                     ins1.Insert(Convert.ToInt32(id_customer), Txt_Price.Text, "0", Convert.ToString(localDate1), Txt_valetcompani.Text, "", 0, "", "");
                     //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                 }

                 //*******************Max cash

                 Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
                 command = new SqlCommand();
                 command.Connection = Connection;
                 Connection.Open();

                 command.CommandText = "Max_factore";
                 command.CommandType = System.Data.CommandType.StoredProcedure;
                 if (dataReader.Read())
                 {
                     Max_cash = Convert.ToInt32(dataReader["Code_cash"].ToString());

                 }





                 //******************محاسبه سود معرف
                 Double sum_moaref;
                 sum_moaref = Convert.ToInt32(Txt_Price.Text) * (Convert.ToInt32(darsadsod_moaref) / 100);


                 //************************




                 //*************************
                 //ذخیره فاکتور
                 //*****************
                 darsad_roz = ((Convert.ToInt32(Txt_Price.Text) * (darsad_subplan / 100)) / roz_seporde);
                 for (i = 0; i <= roz_seporde; i++)
                 {
                     sum = (Convert.ToInt32(Txt_Price.Text) + (darsad_roz * i));
                     localDate1 = localDate1.AddDays(1);
                     date1 = localDate1.ToString("yyyy/MM/dd");

                     //ذخیره فاکتور
                     using (DataSetTableAdapters.FactoreTableAdapter ins1 = new DataSetTableAdapters.FactoreTableAdapter())
                     {

                         ins1.Insert(Convert.ToInt32(id_plan), Convert.ToInt32(id_customer), Txt_date.Text, Txt_Price.Text, vam, Convert.ToString(sum), date1, Convert.ToString(darsad_subplan),
                             Txt_valetcustomer.Text, valet_moaref, Convert.ToInt32(id_customer_moaref), Convert.ToString(sum_moaref), 0, 0, "", "", "", Max_cash);
                         //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                     }




                 }














                 //***********
                 //واریز به حساب معرف

                 //************
             }







         }

  //********انتهای پلن2

         if(planasli == 3)

         {







         }

         //انتهای پلن3
         if (planasli == 4)

         {



         }

         //انتهای پلن4

     */
        #region Sending Email

        sub = "";
        body = "";
        // string path = Server.MapPath("doc\\");


        using (DataSetTableAdapters.email_registerTableAdapter ins11 = new DataSetTableAdapters.email_registerTableAdapter())
        {
            DataSet.email_registerDataTable ne11 = ins11.select_email1();
            foreach (DataSet.email_registerRow row3 in ne11)
            {
                sub = row3.Subject1;
                body = row3.Body1;


            }

        }










        string smtpText = "relay-hosting.secureserver.net";
        int portNumber = 25;

        string userName = "crypto.tradings.official@gmail.com";
        string password = "Crypto2020";
        // string path = Server.MapPath("doc\\");


        try
        {

            SmtpClient smtp = new SmtpClient(smtpText, portNumber);

            smtp.EnableSsl = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential(userName, password);
            MailMessage message = new MailMessage();

            message.To.Add(Convert.ToString(Session["email_customer"]));


            //string toAddress = "";
            //foreach (var item in toAddress.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))                //Read from a string with ; as delimiter and split them and put them i an array



            message.From = new MailAddress(userName);
            message.Subject = sub;//first_name.Value + " " + last_name.Value + " (" + phone.Value + ")";
            message.IsBodyHtml = true;
            message.Body = body;//comments.Value;

            smtp.Send(message);

            //   ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Email has been sent');", true);
            //Response.Redirect("contact.aspx.aspx");
            lblErrorHtml.InnerText = "Email has been sent ";
        }
        catch (Exception ex)
        {

            lblErrorHtml.InnerText = "Email has not been sent because " + ex.Message;
        }

        #endregion

        Response.Redirect("Default.aspx");


    }
}