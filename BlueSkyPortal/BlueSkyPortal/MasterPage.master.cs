using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Security.Cryptography;





public partial class MasterPage : System.Web.UI.MasterPage
{
    protected SqlConnection Connection;
    protected SqlCommand command;
    protected SqlDataReader dataReader;
    string random1;
    
    protected void Page_Load(object sender, EventArgs e)
    {

       




        if (Request.Cookies["Logincustomer"] == null)
        { }
        else
        {
            Label1.Text = Convert.ToString(Session["name_customer"]);

        }

    }


    protected void GenerateOTP(object sender, EventArgs e)
    {
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
        int length = 8 ;
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
    }



    public string Decrypt(string cipherText)
    {
        string EncryptionKey = "0123456789AAAABBGHIJKLMNOPQRSTUVWZZZ";
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


    public string encrypt(string encryptString)
    {
        string EncryptionKey = "0123456789AAAABBGHIJKLMNOPQRSTUVWZZZ";
        byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                encryptString = Convert.ToBase64String(ms.ToArray());
            }
        }
        return encryptString;
    }


    protected void Button1_OnClick(object Source, EventArgs e)
    {

 
        string pass;
        pass = "";
        int statuse_email;
        statuse_email = 0;
        int max_code;
        //************اعتبار نجی

        if (Txt_email.Text =="")
        {


        }




        //************


        //*************دو تا ایمیل مشابه نباشد


        using (DataSetTableAdapters.CustomerTableAdapter pass1 = new DataSetTableAdapters.CustomerTableAdapter())
        {
            DataSet.CustomerDataTable mess1 = pass1.Select_emailcustomer(Txt_email.Text);
            foreach (DataSet.CustomerRow date21 in mess1)
            {

                statuse_email = 1;



            }

            if (statuse_email == 1)

            {
                Response.Redirect("Default.aspx");

            }
        }

                //********************
                //**************decode pass
           
                pass = Txt_pass.Text;
             //   pass = encrypt(pass);

           DateTime localDate = DateTime.Now;
        //***************search referal coe

        //*******************Max idcustomer
        max_code = 0;
        Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
        command = new SqlCommand();
        command.Connection = Connection;
        Connection.Open();

        command.CommandText = "Max_codecustomer";
        command.CommandType = System.Data.CommandType.StoredProcedure;
        dataReader = command.ExecuteReader();
        if (dataReader.Read())
        {
            max_code = Convert.ToInt32(dataReader["Id_customer"].ToString());

        }
        max_code =max_code + 1;
        string referal;
        referal = "crp"+ Convert.ToString(max_code);
        //**************

        //***********************
        using (DataSetTableAdapters.CustomerTableAdapter ins1 = new DataSetTableAdapters.CustomerTableAdapter())
        {

          ins1.Insert(Txt_Name.Text,"", Txt_email.Text, "",  Convert.ToString(localDate), pass, Txt_valet.Text, "", "", "", referal, "",0);
         //   Response.Redirect("~/Admin/Insert_mp3.aspx");
        }

        string body;
        string sub;
        body = "";
        sub = "";
        //ارسال ایمیل
        using (DataSetTableAdapters.email_registerTableAdapter pass12 = new DataSetTableAdapters.email_registerTableAdapter())
        {
            DataSet.email_registerDataTable mess12 = pass12.Search_email1();
            foreach (DataSet.email_registerRow date212 in mess12)
            {
                body = date212.Body;
                sub = date212.Subject;

            }
        }
                //*************************


            }






    protected void BtnSubmit_OnClick(object Source, EventArgs e)
    {

    
        if (txtUsername1.Text != "")
            if (txtPass1.Text != "")
            {
                //  i = 0;
                string username = string.Empty;
                string pass= string.Empty;
                string name_customer = string.Empty;
                pass = txtPass1.Text;
              //  pass = Decrypt(pass);
                using (DataSetTableAdapters.CustomerTableAdapter pass15 = new DataSetTableAdapters.CustomerTableAdapter())
                {
                    DataSet.CustomerDataTable mess5 = pass15.Search_pass_customer(txtUsername1.Text, pass);
                    foreach (DataSet.CustomerRow date25 in mess5)
                    {
                       
                        // i = 1;
                        username = txtUsername1.Text;
                        name_customer = date25.Name_customer;                       
                        HttpCookie mycookie = new HttpCookie("Logincustomer");
                        mycookie.Values.Add("usernamecustomer", username);
                        mycookie.Values.Add("namecustomer", name_customer);
                        Response.Cookies.Add(mycookie);
                        Session["id_customer"] = date25.Id_customer;
                        Session["email_customer"] = date25.Email_custemer;
                        Session["name_customer"] = date25.Name_customer;
                        Response.Redirect("Default.aspx");

                    }
                }









            }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        Response.Redirect("Default.aspx");
    }
}
