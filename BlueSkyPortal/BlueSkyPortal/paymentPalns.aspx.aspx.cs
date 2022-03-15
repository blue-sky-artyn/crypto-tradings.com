using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Security.Cryptography;



public partial class paymentPalns_aspx : System.Web.UI.Page
{
    string id_subpaln;
    
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Cookies["Login_customer"] == null)
            Response.Redirect("~/login.aspx");
//جستجو زیر پلن
        if (Request.QueryString["id"] != "")
        {
            id_subpaln = Request.QueryString["id"];
            id_subpaln = Decrypt(id_subpaln);

            using (DataSetTableAdapters.Sub_plansTableAdapter ins = new DataSetTableAdapters.Sub_plansTableAdapter())
            {
                DataSet.Sub_plansDataTable ne = ins.Search_subplanid(Convert.ToInt32(id_subpaln));
                foreach (DataSet.Sub_plansRow row1 in ne)
                {
                  
                }
            }

        }
//****************************



        }







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



    protected void Button1_Click(object sender, EventArgs e)
    {
        //جستجو در سایت جهت تایید تراکنش


        //*****************************
        //**************اگه تراکنش تایید بود

        //*****************************************



    }
}