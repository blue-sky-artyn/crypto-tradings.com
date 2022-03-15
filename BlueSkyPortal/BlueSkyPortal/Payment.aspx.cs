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
<<<<<<< HEAD

    string darsadsod_moaref;
    int planasli;
    int id_subplans1;
    protected SqlConnection Connection;
    protected SqlCommand command;
    protected SqlDataReader dataReader;

=======
    string darsadsod_moaref;
    int planasli;
    protected SqlConnection Connection;
    protected SqlCommand command;
    protected SqlDataReader dataReader;
    
>>>>>>> fce48b032b58934f57024836247af066407eecaf


    public string Decrypt(string cipherText)
    {
        string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWZZZ";
        cipherText = cipherText.Replace(" ", "+");
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;
    }






    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Cookies["Logincustomer"] == null)
        {
<<<<<<< HEAD
            Response.Redirect("~/login-f.aspx");
=======
            Response.Redirect("~/Default.aspx");
>>>>>>> fce48b032b58934f57024836247af066407eecaf
        }




        //ثبت جدول
        if (Request.QueryString["id"] != "")
        {
            string id_plan1 = Request.QueryString["id"];
            id_plan = Decrypt(id_plan1);
            string s1;
            s1 = "";
            DateTime localDate = DateTime.Now;
            string date1;
            date1 = Convert.ToString(localDate);
<<<<<<< HEAD

            date1 = localDate.ToString("yyyy/MM/dd");


            // date1 = date1.Remove(10, 9);
            if (Convert.ToString(Session["id_customer"]) == "")
            {
                Response.Redirect("~/login-f.aspx");
            }
            else

                id_customer = Convert.ToString(Session["id_customer"]);
            //  id_customer = "1";
=======
            date1 = date1.Remove(10, 9);


            id_customer = Convert.ToString(Session["id_customer"]);
          //  id_customer = "1";
>>>>>>> fce48b032b58934f57024836247af066407eecaf
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


            //جستجو معرف
            using (DataSetTableAdapters.CustomerTableAdapter ins15 = new DataSetTableAdapters.CustomerTableAdapter())
            {
                DataSet.CustomerDataTable ne15 = ins15.Search_referalcustomer(code_moaref);
                foreach (DataSet.CustomerRow row3 in ne15)
                {
                    id_customer_moaref = Convert.ToString(row3.Id_customer);
                    valet_moaref = row3.Valet__custemer;
                }

            }







<<<<<<< HEAD
            //      using (DataSetTableAdapters.Sub_plansTableAdapter ins1 = new DataSetTableAdapters.Sub_plansTableAdapter())
            //      {
            //          DataSet.Sub_plansDataTable ne1 = ins1.search_plan_id(Convert.ToInt32(id_plan));
            //         foreach (DataSet.Sub_plansRow row3 in ne1)
            //         {

            //           Txt_nameplan.Text = row3.Name_plan;
            //           Txt_valetcompani.Text = row3.Adress_valet;
            //          Txt_date.Text = date1;
            //          darsadsod_moaref = row3.Moaref_darsad;
            //          planasli =  row3.Id_paln;
            //         id_subplans1 = row3.Id_subplan;
            //    }

            // }








            using (DataSetTableAdapters.Sub_plansTableAdapter ins11 = new DataSetTableAdapters.Sub_plansTableAdapter())
            {
                DataSet.Sub_plansDataTable ne11 = ins11.Search_subplanid(Convert.ToInt32(id_plan));
                foreach (DataSet.Sub_plansRow row1 in ne11)
                {


                    Txt_nameplan.Text = row1.Name_plan;
                    Txt_valetcompani.Text = row1.Adress_valet;
                    Txt_date.Text = date1;
                    darsadsod_moaref = row1.Moaref_darsad;
                    planasli = row1.Id_paln;
                    id_subplans1 = row1.Id_subplan;

=======
            using (DataSetTableAdapters.Sub_plansTableAdapter ins1 = new DataSetTableAdapters.Sub_plansTableAdapter())
            {
                DataSet.Sub_plansDataTable ne1 = ins1.search_plan_id(Convert.ToInt32(id_plan));
                foreach (DataSet.Sub_plansRow row3 in ne1)
                {

                    Txt_nameplan.Text = row3.Name_plan;
                    Txt_valetcompani.Text = row3.Adress_valet;
                    Txt_date.Text = date1;
                    darsadsod_moaref = row3.Moaref_darsad;
                    planasli =  row3.Id_paln;
>>>>>>> fce48b032b58934f57024836247af066407eecaf

                }

            }
<<<<<<< HEAD




=======
>>>>>>> fce48b032b58934f57024836247af066407eecaf
        }






<<<<<<< HEAD
        //تولیدqr
        string code = Txt_valetcompani.Text;
=======
                    //تولیدqr
                    string code = Txt_valetcompani.Text;
>>>>>>> fce48b032b58934f57024836247af066407eecaf
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
<<<<<<< HEAD

            plBarCode.Controls.Add(imgBarCode);

        }
=======
            
            plBarCode.Controls.Add(imgBarCode);
       
    }
>>>>>>> fce48b032b58934f57024836247af066407eecaf





<<<<<<< HEAD
    }
=======
}
>>>>>>> fce48b032b58934f57024836247af066407eecaf





    protected void btnGenerate_Click(object sender, EventArgs e)
    {
<<<<<<< HEAD

        string code = "jbkjjhhjh";
=======
        
        string code ="jbkjjhhjh";
>>>>>>> fce48b032b58934f57024836247af066407eecaf
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
<<<<<<< HEAD
            plBarCode.Controls.Add(imgBarCode);
=======
           plBarCode.Controls.Add(imgBarCode);
>>>>>>> fce48b032b58934f57024836247af066407eecaf
        }
    }




<<<<<<< HEAD

=======
    
>>>>>>> fce48b032b58934f57024836247af066407eecaf







    protected void btnEmail_Click(object sender, EventArgs e)
    {
<<<<<<< HEAD
        string d9;
        DateTime localDate9 = DateTime.Now;
        d9 = localDate9.ToString("yyyy/MM/dd");
=======

>>>>>>> fce48b032b58934f57024836247af066407eecaf

        //ارسال ایمیل
        string body;
        string sub;
        body = "";
        sub = "";
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

<<<<<<< HEAD
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





        if (Txt_Price1.Value == "")
        {
            Label1.Text = "Price that invalid";
            //  Response.Write("<script>alert('login successful');</script>");
            return;

        }

        ///////////search  hasj in api
        try
        {
            string transfer;
        transfer = Txt_tefrence.Text;
        int price_malett;
        price_malett = Convert.ToInt32(Txt_Price1.Value);
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
        if(Txt_valetcompani.Text != t[0].result.to)
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


        Double vam1;


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

            if ((Convert.ToInt32(Txt_Price1.Value  )) < (Convert.ToInt32(min_subplan)))
            {
                Label1.Text = "Amount less than the allowable limit";
              //  Response.Write("<script>alert('login successful');</script>");
                return;
            }



            //************
            //مبلغ بیشتر از حد پلن نباشه

            if ((Convert.ToInt32(Txt_Price1.Value)) > (Convert.ToInt32(max_subplan)))
            {

                Label1.Text = "Amount more than allowed";
               // Response.Write("<script>alert('login successful');</script>");
                return;
            }






            //**************************
            //***************
            // مشخصات مشتری

            //***************
            //جستجو در سایت جهت تایید تراکنش


            //**********************
            DateTime localDate1 = DateTime.Now;
            DateTime localDate2 = DateTime.Now;
            string date1;
            string date_end;
            int Max_cash;
            Max_cash = 0;
            //*************cash*ذخیره کش
            using (DataSetTableAdapters.CashTableAdapter ins1 = new DataSetTableAdapters.CashTableAdapter())
            {

                ins1.Insert(Convert.ToInt32(id_customer), Txt_Price1.Value, "0", Convert.ToString(localDate1), Txt_valetcompani.Text,Txt_tefrence.Text, 0, id_plan, d9);
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }

            //*******************Max cash

            Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
            command = new SqlCommand();
            command.Connection = Connection;
            Connection.Open();


            command.CommandText = "Max_factore";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Max_cash = Convert.ToInt32(dataReader["Code_cash"].ToString());

            }


            Connection.Close();


            //******************محاسبه سود معرف
            Double sum_moaref;
            Double sum_moaref_sadh2;
            Double sum_moaref_sadh3;
            Double darsad1;
            sum_moaref = Convert.ToInt32(Txt_Price1.Value) * (0.035);
            sum_moaref_sadh2 = Convert.ToInt32(Txt_Price1.Value) * (0.02);
            sum_moaref_sadh3 = Convert.ToInt32(Txt_Price1.Value) * (0.005);

            //************************




            //*************************
            //ذخیره فاکتور
            //*****************

            localDate2 = localDate2.AddDays(roz_seporde);
            date_end = localDate2.ToString("yyyy/MM/dd");

            vam1 = Convert.ToInt32(Txt_Price1.Value)*(Convert.ToInt32(vam));
            vam1 = vam1 / 100;
            vam = Convert.ToString(vam1);

            darsad_roz = ((Convert.ToInt32(Txt_Price1.Value) * (darsad_subplan / 100)) / roz_seporde);
            for (i = 1; i <= roz_seporde; i++)
            {
                sum = (Convert.ToInt32(Txt_Price1.Value) + (darsad_roz * (i)));
               
                date1 = localDate1.ToString("yyyy/MM/dd");




                //ذخیره فاکتور
                using (DataSetTableAdapters.FactoreTableAdapter ins1 = new DataSetTableAdapters.FactoreTableAdapter())
                {

                    ins1.Insert(id_subplans1, Convert.ToInt32(id_customer), Txt_date.Text, Txt_Price1.Value, vam, Convert.ToString(sum), date1, Convert.ToString(darsad_subplan),
                        Txt_valetcustomer.Text, valet_moaref, Convert.ToInt32(id_customer_moaref), Convert.ToString(sum_moaref), 0, 0, "", date_end, Txt_nameplan.Text, Max_cash);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }

                localDate1 = localDate1.AddDays(1);


            }

=======


>>>>>>> fce48b032b58934f57024836247af066407eecaf







<<<<<<< HEAD






            //***********
            //واریز به حساب معرف

            int id_referal1;
            string sadh1;
            string sadh2;
            string sadh3;
            string sadh4;
            string sadh5;
            string sadh6;
            sadh1 = "0";
            sadh2 = "0";
            sadh3 = "0";
            sadh4 = "0";
            sadh5 = "0";
            sadh6 = "0";
            DateTime localDate21 = DateTime.Now;
            string date_sabt_moaref;
            date_sabt_moaref = Convert.ToString(localDate21);
            id_referal1 = 0;

            //جستجوی معرفان

            using (DataSetTableAdapters.select_referal1TableAdapter ins19 = new DataSetTableAdapters.select_referal1TableAdapter())
            {
                DataSet.select_referal1DataTable ne19 = ins19.search_referal_idcustomer(id_customer);
                foreach (DataSet.select_referal1Row row9 in ne19)
                {
                    sadh1 = row9.Referal1;
                    sadh2 = row9.referal2;
                    sadh3 = row9.referal3;
                    sadh4 = row9.referal4;
                    sadh5 = row9.referal5;
                    sadh6 = row9.referal6;
                    id_referal1 = row9.ID_referal;
                   
                    //************
                }
            }
            //******************بروز رسانی جدول رفرال جهت تغییر وضعیت1
            using (DataSetTableAdapters.select_referal1TableAdapter ins5 = new DataSetTableAdapters.select_referal1TableAdapter())
            {

                ins5.Update_referl21(id_referal1);
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }

            //***************************************
            //ذخیره سطح1
            //ذخیره 

            if (sadh1 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh1);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref), date_sabt_moaref,row9.Id_customer,1,id_subplans1,0,Max_cash,0,0,0,"","");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }

            //************
            //ذخیره سطح2



            if (sadh2 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh2);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh2), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }





=======
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
>>>>>>> fce48b032b58934f57024836247af066407eecaf





<<<<<<< HEAD
            //************
            //ذخیره سطح3

            if (sadh3 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh3);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }




            //************
            //ذخیره سطح4
            if (sadh4 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh4);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }



            //************
            //ذخیره سطح5
            if (sadh5 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh5);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }



            //************
            //ذخیره سطح6

            if (sadh6 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh6);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }


            //************
        }
        //**************انتهای پلن1
        //****************

        if (planasli == 2 )
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

            if ((Convert.ToInt32(Txt_Price1.Value)) < (Convert.ToInt32(min_subplan)))
            {
                Label1.Text = "Amount less than the allowable limit";
                //  Response.Write("<script>alert('login successful');</script>");
                return;
            }



            //************
            //مبلغ بیشتر از حد پلن نباشه

            if ((Convert.ToInt32(Txt_Price1.Value)) > (Convert.ToInt32(max_subplan)))
            {

                Label1.Text = "Amount more than allowed";
                // Response.Write("<script>alert('login successful');</script>");
                return;
            }






            //**************************
            //***************
            // مشخصات مشتری

            //***************
            //جستجو در سایت جهت تایید تراکنش


            //**********************
            DateTime localDate1 = DateTime.Now;
            DateTime localDate2 = DateTime.Now;
            string date1;
            date1 = localDate2.ToString("yyyy/MM/dd");
            string date_end;
            int Max_cash;
            Max_cash = 0;
            //*************cash*ذخیره کش
            using (DataSetTableAdapters.CashTableAdapter ins1 = new DataSetTableAdapters.CashTableAdapter())
            {

                ins1.Insert(Convert.ToInt32(id_customer), Txt_Price1.Value, "0", Convert.ToString(localDate1), Txt_valetcompani.Text, Txt_tefrence.Text, 0, id_plan, d9);
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }

            //*******************Max cash

            Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
            command = new SqlCommand();
            command.Connection = Connection;
            Connection.Open();


            command.CommandText = "Max_factore";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Max_cash = Convert.ToInt32(dataReader["Code_cash"].ToString());

            }



            Connection.Close();

            //******************محاسبه سود معرف
            Double sum_moaref;
            Double sum_moaref_sadh2;
            Double sum_moaref_sadh3;
            sum_moaref = Convert.ToInt32(Txt_Price1.Value) * (0.035);
            sum_moaref_sadh2 = Convert.ToInt32(Txt_Price1.Value) * (0.02);
            sum_moaref_sadh3 = Convert.ToInt32(Txt_Price1.Value) * (0.005);

            //************************




            //*************************
            //ذخیره فاکتور
            //*****************

            localDate2 = localDate2.AddDays(roz_seporde);
            date_end = localDate2.ToString("yyyy/MM/dd");
            vam1 = Convert.ToInt32(Txt_Price1.Value) * (Convert.ToInt32(vam));
            vam1 = vam1 / 100;
            vam = Convert.ToString(vam1);
            //  darsad_roz = ((Convert.ToInt32(Txt_Price.Text) * (darsad_subplan / 100)) / roz_seporde);
            for (i = 1; i <= roz_seporde; i++)
            {
                sum = (Convert.ToInt32(Txt_Price1.Value) );
              
                date1 = localDate1.ToString("yyyy/MM/dd");




                //ذخیره فاکتور
                using (DataSetTableAdapters.Factore2TableAdapter ins1 = new DataSetTableAdapters.Factore2TableAdapter())
                {

                    ins1.Insert(id_subplans1, Convert.ToInt32(id_customer), Txt_date.Text, Txt_Price1.Value, vam, Convert.ToString(sum), date1, Convert.ToString(darsad_subplan),
                        Txt_valetcustomer.Text, valet_moaref, Convert.ToInt32(id_customer_moaref), Convert.ToString(sum_moaref), 0, 0, "", date_end, Txt_nameplan.Text, Max_cash);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }
                localDate1 = localDate1.AddDays(1);



            }









=======

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
>>>>>>> fce48b032b58934f57024836247af066407eecaf





<<<<<<< HEAD
            //***********
            //واریز به حساب معرف
            int id_referal1;
            string sadh1;
            string sadh2;
            string sadh3;
            string sadh4;
            string sadh5;
            string sadh6;
            sadh1 = "0";
            sadh2 = "0";
            sadh3 = "0";
            sadh4 = "0";
            sadh5 = "0";
            sadh6 = "0";
            DateTime localDate21 = DateTime.Now;
            string date_sabt_moaref;
            date_sabt_moaref = Convert.ToString(localDate21);
            id_referal1 = 0;

            //جستجوی معرفان

            using (DataSetTableAdapters.select_referal1TableAdapter ins19 = new DataSetTableAdapters.select_referal1TableAdapter())
            {
                DataSet.select_referal1DataTable ne19 = ins19.search_referal_idcustomer(id_customer);
                foreach (DataSet.select_referal1Row row9 in ne19)
                {
                    sadh1 = row9.Referal1;
                    sadh2 = row9.referal2;
                    sadh3 = row9.referal3;
                    sadh4 = row9.referal4;
                    sadh5 = row9.referal5;
                    sadh6 = row9.referal6;
                    id_referal1 = row9.ID_referal;

                    //************
                }
            }
            //******************بروز رسانی جدول رفرال جهت تغییر وضعیت1
            using (DataSetTableAdapters.select_referal1TableAdapter ins5 = new DataSetTableAdapters.select_referal1TableAdapter())
            {

                ins5.Update_referl21(id_referal1);
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }

            //***************************************
            //ذخیره سطح1
            //ذخیره 

            if (sadh1 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh1);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }

            //************
            //ذخیره سطح2



            if (sadh2 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh2);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh2), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }




=======
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
>>>>>>> fce48b032b58934f57024836247af066407eecaf






<<<<<<< HEAD
            //************
            //ذخیره سطح3

            if (sadh3 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh3);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }




            //************
            //ذخیره سطح4
            if (sadh4 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh4);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }



            //************
            //ذخیره سطح5
            if (sadh5 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh5);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }



            //************
            //ذخیره سطح6

            if (sadh6 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh6);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }

            //************








        }

        //********انتهای پلن2

        if (planasli == 3)

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

            if ((Convert.ToInt32(Txt_Price1.Value)) < (Convert.ToInt32(min_subplan)))
            {
                Label1.Text = "Amount less than the allowable limit";
                //  Response.Write("<script>alert('login successful');</script>");
                return;
            }



            //************
            //مبلغ بیشتر از حد پلن نباشه

            if ((Convert.ToInt32(Txt_Price1.Value)) > (Convert.ToInt32(max_subplan)))
            {

                Label1.Text = "Amount more than allowed";
                // Response.Write("<script>alert('login successful');</script>");
                return;
            }






            //**************************
            //***************
            // مشخصات مشتری

            //***************
            //جستجو در سایت جهت تایید تراکنش


            //**********************
            DateTime localDate1 = DateTime.Now;
            DateTime localDate2 = DateTime.Now;
            string date1;
            date1 = localDate2.ToString("yyyy/MM/dd");
            string date_end;
            int Max_cash;
            Max_cash = 0;
            //*************cash*ذخیره کش
            using (DataSetTableAdapters.CashTableAdapter ins1 = new DataSetTableAdapters.CashTableAdapter())
            {

                ins1.Insert(Convert.ToInt32(id_customer), Txt_Price1.Value, "0", Convert.ToString(localDate1), Txt_valetcompani.Text, Txt_tefrence.Text, 0, id_plan, d9);
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }

            //*******************Max cash

            Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
            command = new SqlCommand();
            command.Connection = Connection;
            Connection.Open();


            command.CommandText = "Max_factore";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Max_cash = Convert.ToInt32(dataReader["Code_cash"].ToString());

            }

            Connection.Close();



            //******************محاسبه سود معرف
            Double sum_moaref;
            Double sum_moaref_sadh2;
            Double sum_moaref_sadh3;
            sum_moaref = Convert.ToInt32(Txt_Price1.Value) * (0.035);
            sum_moaref_sadh2 = Convert.ToInt32(Txt_Price1.Value) * (0.02);
            sum_moaref_sadh3 = Convert.ToInt32(Txt_Price1.Value) * (0.005);

            //************************




            //*************************
            //ذخیره فاکتور
            //*****************

            localDate2 = localDate2.AddDays(roz_seporde);
            date_end = localDate2.ToString("yyyy/MM/dd");
            vam1 = Convert.ToInt32(Txt_Price1.Value) * (Convert.ToInt32(vam));
            vam1 = vam1 / 100;
            vam = Convert.ToString(vam1);
            //  darsad_roz = ((Convert.ToInt32(Txt_Price.Text) * (darsad_subplan / 100)) / roz_seporde);
            //   for (i = 1; i <= roz_seporde; i++)
            //    {
            sum = (Convert.ToInt32(Txt_Price1.Value));
              
                date1 = localDate1.ToString("yyyy/MM/dd");




                //ذخیره فاکتور
                using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                {

                    ins1.Insert(id_subplans1, Convert.ToInt32(id_customer), Txt_date.Text, Txt_Price1.Value, vam, Convert.ToString(sum), date1, Convert.ToString(darsad_subplan),
                        Txt_valetcustomer.Text, valet_moaref, Convert.ToInt32(id_customer_moaref), Convert.ToString(sum_moaref), 0, 0, "", date_end, Txt_nameplan.Text, Max_cash);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }

            localDate1 = localDate1.AddDays(1);


            //    }



            //**********ذخیره در صندوق فاکتور3
            int price_sandogh;
            price_sandogh = 0;
            Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
            command = new SqlCommand();
            command.Connection = Connection;
            Connection.Open();


            command.CommandText = "Max_cashfactore3";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                price_sandogh = Convert.ToInt32(dataReader["Price_kol"].ToString());

            }

            Connection.Close();



            //**********************

            price_sandogh = price_sandogh + Convert.ToInt32(Txt_Price1.Value);


            //ذخیره فاکتور
            using (DataSetTableAdapters.Cash_factore3TableAdapter ins1 = new DataSetTableAdapters.Cash_factore3TableAdapter())
            {

                ins1.Insert(Convert.ToString(price_sandogh), date1, "", 0, "");
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }







            //***********
            //واریز به حساب معرف
            int id_referal1;
            string sadh1;
            string sadh2;
            string sadh3;
            string sadh4;
            string sadh5;
            string sadh6;
            sadh1 = "0";
            sadh2 = "0";
            sadh3 = "0";
            sadh4 = "0";
            sadh5 = "0";
            sadh6 = "0";
            DateTime localDate21 = DateTime.Now;
            string date_sabt_moaref;
            date_sabt_moaref = Convert.ToString(localDate21);
            id_referal1 = 0;

            //جستجوی معرفان

            using (DataSetTableAdapters.select_referal1TableAdapter ins19 = new DataSetTableAdapters.select_referal1TableAdapter())
            {
                DataSet.select_referal1DataTable ne19 = ins19.search_referal_idcustomer(id_customer);
                foreach (DataSet.select_referal1Row row9 in ne19)
                {
                    sadh1 = row9.Referal1;
                    sadh2 = row9.referal2;
                    sadh3 = row9.referal3;
                    sadh4 = row9.referal4;
                    sadh5 = row9.referal5;
                    sadh6 = row9.referal6;
                    id_referal1 = row9.ID_referal;

                    //************
                }
            }
            //******************بروز رسانی جدول رفرال جهت تغییر وضعیت1
            using (DataSetTableAdapters.select_referal1TableAdapter ins5 = new DataSetTableAdapters.select_referal1TableAdapter())
            {

                ins5.Update_referl21(id_referal1);
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }

            //***************************************
            //ذخیره سطح1
            //ذخیره 

            if (sadh1 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh1);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }

            //************
            //ذخیره سطح2



            if (sadh2 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh2);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh2), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }










            //************
            //ذخیره سطح3

            if (sadh3 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh3);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }




            //************
            //ذخیره سطح4
            if (sadh4 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh4);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }



            //************
            //ذخیره سطح5
            if (sadh5 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh5);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }



            //************
            //ذخیره سطح6

            if (sadh6 != "")
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins9 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable ne9 = ins9.Search_referalcustomer(sadh6);
                    foreach (DataSet.CustomerRow row9 in ne9)
                    {

                        using (DataSetTableAdapters.CashreferalTableAdapter ins1 = new DataSetTableAdapters.CashreferalTableAdapter())
                        {

                            ins1.Insert(Convert.ToString(sum_moaref_sadh3), date_sabt_moaref, row9.Id_customer, 1, id_subplans1, 0, Max_cash, 0, 0, 0, "", "");
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }

                    }
                }



            }

            //************












        }

        //انتهای پلن3
        if (planasli == 4)

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
            if ((Convert.ToInt32(Txt_Price1.Value)) < (Convert.ToInt32(min_subplan)))
            {
                Label1.Text = "Amount less than the allowable limit";
                //  Response.Write("<script>alert('login successful');</script>");
                return;
            }



            //************
            //مبلغ بیشتر از حد پلن نباشه

            if ((Convert.ToInt32(Txt_Price1.Value)) > (Convert.ToInt32(max_subplan)))
            {

                Label1.Text = "Amount more than allowed";
                // Response.Write("<script>alert('login successful');</script>");
                return;
            }




            //**************************
            //***************
            // مشخصات مشتری

            //***************
            //جستجو در سایت جهت تایید تراکنش


            //**********************
            DateTime localDate1 = DateTime.Now;
            DateTime localDate2 = DateTime.Now;
            
            string date1;
            date1 = localDate2.ToString("yyyy/MM/dd");
            string date_end;
            int Max_cash;
            Max_cash = 0;
            //*************cash*ذخیره کش
            using (DataSetTableAdapters.CashTableAdapter ins1 = new DataSetTableAdapters.CashTableAdapter())
            {

                ins1.Insert(Convert.ToInt32(id_customer), Txt_Price1.Value, "0", Convert.ToString(localDate1), Txt_valetcompani.Text, Txt_tefrence.Text, 0, id_plan, d9);
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }

            //*******************Max cash

            Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
            command = new SqlCommand();
            command.Connection = Connection;
            Connection.Open();


            command.CommandText = "Max_factore";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Max_cash = Convert.ToInt32(dataReader["Code_cash"].ToString());

            }



            Connection.Close();

            //******************محاسبه سود معرف
            Double sum_moaref;
            Double sum_moaref_sadh2;
            Double sum_moaref_sadh3;
            sum_moaref = Convert.ToInt32(Txt_Price1.Value) * (0.035);
            sum_moaref_sadh2 = Convert.ToInt32(Txt_Price1.Value) * (0.02);
            sum_moaref_sadh3 = Convert.ToInt32(Txt_Price1.Value) * (0.005);

            //************************




            //*************************
            //ذخیره فاکتور
            //*****************

            localDate2 = localDate2.AddDays(roz_seporde);
            date_end = localDate2.ToString("yyyy/MM/dd");
            vam1 = Convert.ToInt32(Txt_Price1.Value) * (Convert.ToInt32(vam));
            vam1 = vam1 / 100;
            vam = Convert.ToString(vam1);
            //  darsad_roz = ((Convert.ToInt32(Txt_Price.Text) * (darsad_subplan / 100)) / roz_seporde);
            //   for (i = 1; i <= roz_seporde; i++)
            {
                sum = (Convert.ToInt32(Txt_Price1.Value));
              
                date1 = localDate1.ToString("yyyy/MM/dd");




                //ذخیره فاکتور
                using (DataSetTableAdapters.Factore4TableAdapter ins1 = new DataSetTableAdapters.Factore4TableAdapter())
                {

                    ins1.Insert(id_subplans1, Convert.ToInt32(id_customer), Txt_date.Text, Txt_Price1.Value, vam, Convert.ToString(sum), date1, Convert.ToString(darsad_subplan),
                        Txt_valetcustomer.Text, valet_moaref, Convert.ToInt32(id_customer_moaref), Convert.ToString(sum_moaref), 0, 0, "", date_end, Txt_nameplan.Text, Max_cash);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }

                localDate1 = localDate1.AddDays(1);


            }

            ///////////////////save for referal4


            using (DataSetTableAdapters.referalplan4TableAdapter ins5 = new DataSetTableAdapters.referalplan4TableAdapter())
            {

                ins5.Update_referal4_subplan(Convert.ToInt32(id_customer), id_subplans1);
                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
            }





            //////////////*******
















            //***********




        }

        //انتهای پلن4






        #region Sending Email

        string smtpText = "relay-hosting.secureserver.net";
        int portNumber = 25;

        string userName = "crypto.tradings.official@gmail.com";
        string password = "Crypto2020";

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










=======

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

        string smtpText = "smtp.gmail.com";
        int portNumber = 587;
        string userName = "cryptotrading3535@gmail.com";
        string password = "trading3535";
        // string path = Server.MapPath("doc\\");


>>>>>>> fce48b032b58934f57024836247af066407eecaf
        try
        {

            SmtpClient smtp = new SmtpClient(smtpText, portNumber);

<<<<<<< HEAD
            smtp.EnableSsl = false;
=======
            smtp.EnableSsl = true;
>>>>>>> fce48b032b58934f57024836247af066407eecaf
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential(userName, password);
            MailMessage message = new MailMessage();

            message.To.Add(Convert.ToString(Session["email_customer"]));


            //string toAddress = "";
            //foreach (var item in toAddress.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))                //Read from a string with ; as delimiter and split them and put them i an array



            message.From = new MailAddress(userName);
<<<<<<< HEAD
            message.Subject = sub;//first_name.Value + " " + last_name.Value + " (" + phone.Value + ")";
            message.IsBodyHtml = true;
            message.Body = body;//comments.Value;
=======
            message.Subject = "payment";//first_name.Value + " " + last_name.Value + " (" + phone.Value + ")";
            message.Body = "testttttttttttt";//comments.Value;
>>>>>>> fce48b032b58934f57024836247af066407eecaf

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