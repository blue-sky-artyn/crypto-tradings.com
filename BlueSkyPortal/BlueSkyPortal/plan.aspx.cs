using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public partial class admin_service : System.Web.UI.Page
{
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

    public string encrypt(string encryptString)
    {
        string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWZZZ";
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



    public string insert_factore(string id_cusroemr ,int id_subplan,int price)
    {

        DateTime localDate = DateTime.Now;
        string date;
        int roz_seporde;
        string  darsad_subplan;
        string  darsad_moaref;
        string min_subplan;
        string max_subplan;
        string vam;

        Double darsad;
        Double darsad_roz;
        Double sum;
        int i;
        int tedad_roz;
     

        //مشخصات پلن

        using (DataSetTableAdapters.Sub_plansTableAdapter ins11 = new DataSetTableAdapters.Sub_plansTableAdapter())
        {
            DataSet.Sub_plansDataTable ne11 = ins11.Search_subplanid(id_subplan);
            foreach (DataSet.Sub_plansRow row1 in ne11)
            {
                roz_seporde = row1.Period ;
                darsad_subplan = row1.Darsad;
                darsad_moaref = row1.Moaref_darsad;
                min_subplan = row1.Min_price;
                max_subplan = row1.Max_price;
                vam = row1.Debit;

               



            }

        }

        //***************
        // مشخصات مشتری

        //***************

        //ذخیره فاکتور

        //***********
        //واریز به حساب معرف

        //************
        return "1";
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != "")
        {
            string id_plan1 = Request.QueryString["id"];
            string id_plan = id_plan1;
            string s1;
            s1 = "";
            using (DataSetTableAdapters.Sub_plansTableAdapter ins1 = new DataSetTableAdapters.Sub_plansTableAdapter())
            {
                DataSet.Sub_plansDataTable ne1 = ins1.search_plan_id(Convert.ToInt32(id_plan));
                foreach (DataSet.Sub_plansRow row3 in ne1)
                {
                    s1 += "<div class='col-md-4 col-sm-6 col-xs-12'>";
                    s1 +="<div class='grid1'>";
                  //  s1 += "<span>%"+row3.Min_price+ "/<small>Minimum amount</small></span>";
                    s1 += " <div class='price-tit text-center'>";
                    s1 += "<h2>"+row3.Name_plan+"</h2>";
                    s1 += " <p>"+row3.Desc_subplan+"</p>";
                    s1 += "</div>";
                    s1 += "<div class='para'>";
                    s1 += "<p>Minimum amount:" + row3.Min_price+"</p>";
                    s1 += "<p>Maximum amount:"+row3.Max_price+"</p>";
                    s1 += "<p>Day:"+row3.Period+"</p>";
                    s1 += "<p>Percent:"+row3.Darsad+"</p>";
                    s1 += "<p>debt:" + row3.Debit + "</p>";
                    s1 += "</div>";
                    s1 += "<div class='sign text-center pricing-table-sign-up'>";
                    s1 += "<a href ='Payment.aspx?id=" + encrypt(id_plan1) + " 'class='btn btn-light btn-radius btn-brd grd1 effect-1'>BUY</a>";

             




                    s1 += "</div>";
                    s1 += "</div>";
                    s1 += "</div>";


                }
                Literal1.Text = s1;


                ///end jadval classs
            }

        }

    }


   







}