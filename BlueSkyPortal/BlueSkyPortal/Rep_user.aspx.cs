using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rep_user : System.Web.UI.Page
{

    string id_customer;
    string id;
    string factore;
    string price_start;
    int sub_plan;
    int i22;
    int id_cash1;
    string statuse_vam;
    string price_vam;
    int statuse_moaref;
    
    
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Logincustomer"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }

        if (Request.QueryString["id"] != "")
        {
           id = Request.QueryString["id"];
           factore= Request.QueryString["F"];
        }

        if(factore == "3")
        {
            Button2.Visible = false;
        }

        if (factore == "4")
        {
            Button2.Visible = false;
        }

        if (factore == "5")
        {
            Button2.Visible = false;
        }

        if (factore == "6")
        {
            Button2.Visible = false;
        }

        id_customer = Convert.ToString(Session["id_customer"]);
        string s2;
        s2 = "";

        string s3;
        s3 = "";

        id_cash1 = 0;
        statuse_vam = "";
        price_vam = "0";
        i22 = 0;

        if (factore == "1")
        {

            using (DataSetTableAdapters.FactoreTableAdapter ins11 = new DataSetTableAdapters.FactoreTableAdapter())
            {
                DataSet.FactoreDataTable ne11 = ins11.Search_factore1_id(Convert.ToInt32(id));
                foreach (DataSet.FactoreRow row3 in ne11)
                {
                    mojodi.Text = row3.Price_sumdate;
                    date1.Text = Convert.ToString(row3.Desk_factore);
                    id_cash1 = row3.Id_cash;
                    statuse_vam = row3.Statuse1;
                    statuse_moaref = row3.Statuse_moaref;
                    //vam nagerefte
                    if (row3.Statuse1 == "")
                    {
                        vam.Text = row3.Price_vam;
                        ghabelbardasht.Text =row3.Price_sumdate;
                        price_vam = row3.Price_vam;


                    }
                    else

                    {
                        vam.Text = "0";
                        price_vam = "0";
                        ghabelbardasht.Text = Convert.ToString(Convert.ToDouble(row3.Price_sumdate) - Convert.ToDouble(row3.Price_vam));

                    }
                }

            }


        }

        if (factore == "2")
        {
            using (DataSetTableAdapters.Factore2TableAdapter ins11 = new DataSetTableAdapters.Factore2TableAdapter())
            {
                DataSet.Factore2DataTable ne11 = ins11.Search_factore2_id(Convert.ToInt32(id));
                foreach (DataSet.Factore2Row row3 in ne11)
                {
                    mojodi.Text = row3.Price_sumdate;
                    date1.Text = Convert.ToString(row3.Desk_factore);
                    id_cash1 = row3.Id_cash;
                    statuse_vam = row3.Statuse1;
                    statuse_moaref = row3.Statuse_moaref;
                    //vam nagerefte
                    if (row3.Statuse1 == "")
                    {
                        vam.Text = row3.Price_vam;
                        ghabelbardasht.Text = row3.Price_sumdate;
                        price_start = row3.Price_Start;
                        price_vam = row3.Price_vam;


                    }
                    else

                    {
                        vam.Text = "0";
                        ghabelbardasht.Text = Convert.ToString(Convert.ToDouble(row3.Price_sumdate) - Convert.ToDouble(row3.Price_vam));
                        price_start = row3.Price_Start;
                        price_vam = "0";
                    }
                }

            }

        }


        if (factore == "3")
        {
            using (DataSetTableAdapters.Factore3TableAdapter ins11 = new DataSetTableAdapters.Factore3TableAdapter())
            {
                DataSet.Factore3DataTable ne11 = ins11.Search_factore3_id(Convert.ToInt32(id));
                foreach (DataSet.Factore3Row row3 in ne11)
                {
                    mojodi.Text = row3.Price_sumdate;
                    date1.Text = Convert.ToString(row3.Desk_factore);
                    price_start = row3.Price_Start;
                    statuse_moaref = row3.Statuse_moaref;
                    //vam nagerefte
                    if (row3.Statuse_moaref == 0)
                    {
                        vam.Text = row3.Price_vam;
                        ghabelbardasht.Text = row3.Price_sumdate;


                    }
                    else

                    {
                        vam.Text = "0";
                        ghabelbardasht.Text = Convert.ToString(Convert.ToDouble(row3.Price_sumdate) - Convert.ToDouble(row3.Price_vam));

                    }
                }

            }

            ///cash total f3
            using (DataSetTableAdapters.Cash_factore3TableAdapter ins11 = new DataSetTableAdapters.Cash_factore3TableAdapter())
            {
                DataSet.Cash_factore3DataTable ne11 = ins11.select_cashf3_new();
                foreach (DataSet.Cash_factore3Row row3 in ne11)
                {
                    s2 += "<p>";
                    s2 += "Total fund balance="+row3.Price_kol+"$";

                }
            }


            Literal1.Text = s2;
                    /// 






                }


        if (factore == "4")
        {


            using (DataSetTableAdapters.Factore4TableAdapter ins11 = new DataSetTableAdapters.Factore4TableAdapter())
            {
                DataSet.Factore4DataTable ne11 = ins11.Search_factore4_id(Convert.ToInt32(id));
                foreach (DataSet.Factore4Row row3 in ne11)
                {
                    mojodi.Text = row3.Price_sumdate;
                    date1.Visible = false;
                    sub_plan = row3.Id_subpelan;
                    statuse_moaref = row3.Statuse_moaref;
                    //     date1.Text = Convert.ToString(row3.Desk_factore);
                    //vam nagerefte
                    if (row3.Statuse_moaref == 0)
                    {
                        vam.Text = row3.Price_vam;
                        ghabelbardasht.Text = row3.Price_sumdate;


                    }
                    else

                    {
                        vam.Text = "0";
                        ghabelbardasht.Text = Convert.ToString(Convert.ToDouble(row3.Price_sumdate) - Convert.ToDouble(row3.Price_vam));
                        sub_plan = row3.Id_subpelan;
                    }
                }

            }

            //******search count referal
            using (DataSetTableAdapters.referalplan4TableAdapter ins15 = new DataSetTableAdapters.referalplan4TableAdapter())
            {
                DataSet.referalplan4DataTable ne15 = ins15.search_referalp4_idcustomer(Convert.ToInt32(id_customer));
                foreach (DataSet.referalplan4Row row5 in ne15)
                {
                    i22 += 1;
                  
                }
            }
            if (i22 > 0 )
            {

                s3 += "<p>";
                s3 += "Members introduced=" +i22 ;
            }
            //****************************

            Literal2.Text = s3;












                }

        /////////////old fac1
        int id_fac1;
        id_fac1 = 0;
        if (factore == "5")
        {
            using (DataSetTableAdapters.FactoreTableAdapter ins15 = new DataSetTableAdapters.FactoreTableAdapter())
            {
                DataSet.FactoreDataTable ne15 = ins15.search_cashf1(Convert.ToInt32(id));
                foreach (DataSet.FactoreRow row5 in ne15)
                {
                    id_fac1 = row5.Id_factore;

                }
            }

            using (DataSetTableAdapters.FactoreTableAdapter ins11 = new DataSetTableAdapters.FactoreTableAdapter())
            {
                DataSet.FactoreDataTable ne11 = ins11.Search_factore1_id(id_fac1);
                foreach (DataSet.FactoreRow row3 in ne11)
                {
                    mojodi.Text = row3.Price_sumdate;
                    date1.Text = Convert.ToString(row3.Desk_factore);
                    id_cash1 = row3.Id_cash;
                    statuse_vam = row3.Statuse1;
                    statuse_moaref = row3.Statuse_moaref;
                    //vam nagerefte
                    if (row3.Statuse1 == "")
                    {
                        vam.Text = row3.Price_vam;
                        ghabelbardasht.Text = row3.Price_sumdate;
                        price_vam = row3.Price_vam;


                    }
                    else

                    {
                        vam.Text = "0";
                        price_vam = "0";
                        ghabelbardasht.Text = Convert.ToString(Convert.ToDouble(row3.Price_sumdate) - Convert.ToDouble(row3.Price_vam));

                    }
                }

            }

        }
        //***************************
        if (factore == "6")
        {
            using (DataSetTableAdapters.Factore2TableAdapter ins15 = new DataSetTableAdapters.Factore2TableAdapter())
            {
                DataSet.Factore2DataTable ne15 = ins15.search_cashf2(Convert.ToInt32(id));
                foreach (DataSet.Factore2Row row5 in ne15)
                {
                    id_fac1 = row5.Id_factore;

                }
            }

            using (DataSetTableAdapters.Factore2TableAdapter ins11 = new DataSetTableAdapters.Factore2TableAdapter())
            {
                DataSet.Factore2DataTable ne11 = ins11.Search_factore2_id(id_fac1);
                foreach (DataSet.Factore2Row row3 in ne11)
                {
                    mojodi.Text = row3.Price_sumdate;
                    date1.Text = Convert.ToString(row3.Desk_factore);
                    id_cash1 = row3.Id_cash;
                    statuse_vam = row3.Statuse1;
                    statuse_moaref = row3.Statuse_moaref;
                    //vam nagerefte
                    if (row3.Statuse1 == "")
                    {
                        vam.Text = row3.Price_vam;
                        ghabelbardasht.Text = row3.Price_sumdate;
                        price_vam = row3.Price_vam;


                    }
                    else

                    {
                        vam.Text = "0";
                        price_vam = "0";
                        ghabelbardasht.Text = Convert.ToString(Convert.ToDouble(row3.Price_sumdate) - Convert.ToDouble(row3.Price_vam));

                    }
                }

            }

        }




        //*************************************************
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string date11;
        DateTime localDate1 = DateTime.Now;
        date11 = localDate1.ToString("yyyy/MM/dd");
        string valet_customer;
        valet_customer = "";

        string email_customer1;
        email_customer1 = "";


    
        ///search valet customer

        using (DataSetTableAdapters.CustomerTableAdapter ins11 = new DataSetTableAdapters.CustomerTableAdapter())
        {
            DataSet.CustomerDataTable ne11 = ins11.search_idcustomer(Convert.ToInt32(id_customer));
            foreach (DataSet.CustomerRow row3 in ne11)
            {
                valet_customer = row3.Valet__custemer;
                email_customer1 = row3.Email_custemer;

            }

        }






        /// 









        if (factore == "1")
        {
            if(statuse_moaref >0)
            {

                Label1_errore.Text = "The application has already been registered";
                return;

            }




            if(date1.Text == date11)

            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(ghabelbardasht.Text,valet_customer,Convert.ToInt32(id_customer), "0",factore,"plan1",date11,0,"" );
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


                using (DataSetTableAdapters.FactoreTableAdapter ins1 = new DataSetTableAdapters.FactoreTableAdapter())
                {

                    ins1.Update_statusemoareff1(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


            }
            else
            {


                Label1_errore.Text = "The permitted date has not been reached";
                return;
            }





        }


        if (factore == "2")
        {

            if (statuse_moaref > 0)
            {

                Label1_errore.Text = "The application has already been registered";
                return;

            }


            if (date1.Text == date11)

            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(ghabelbardasht.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan2", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


                using (DataSetTableAdapters.Factore2TableAdapter ins1 = new DataSetTableAdapters.Factore2TableAdapter())
                {

                    ins1.Update_statusemoareff2(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }

            }

            else
            {


                Label1_errore.Text = "The permitted date has not been reached";
                return;
            }




        }



        if (factore == "3")
        {
            int price1;
            price1 = Convert.ToInt32(price_start);
            price1 = price1 * 2;

            if (statuse_moaref > 0)
            {

                Label1_errore.Text = "The application has already been registered";
                return;

            }




            //مبلغ براشت دو برابر شده باشد
            if (price1 < (Convert.ToDouble(ghabelbardasht.Text)))

            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(ghabelbardasht.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan3", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }

                using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                {

                    ins1.Update_statusemoareff3(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


            }

            else
            {

                Label1_errore.Text = "The allowable amount has not been reached";
                return;
            }




        }


        if (factore == "4")
        {
            Button2.Visible = false;

            if (statuse_moaref > 0)
            {

                Label1_errore.Text = "The application has already been registered";
                return;

            }




            //جستجو معرفان تا عدد 6 برسد
            if ( i22 < 6 )

            {
                Label1_errore.Text = "The allowable amount has not been reached";
                return;

            }
            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(Convert.ToString(Convert.ToInt32( ghabelbardasht.Text)*2), valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan4", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }

                using (DataSetTableAdapters.Factore4TableAdapter ins1 = new DataSetTableAdapters.Factore4TableAdapter())
                {

                    ins1.Update_statusemoareff4(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


            }




        }

        if (factore == "5")
        {
            if (statuse_moaref > 0)
            {

                Label1_errore.Text = "The application has already been registered";
                return;

            }




            if   (Convert.ToDateTime(date1.Text) <= Convert.ToDateTime(date11))

            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(ghabelbardasht.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan1", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


                using (DataSetTableAdapters.FactoreTableAdapter ins1 = new DataSetTableAdapters.FactoreTableAdapter())
                {

                    ins1.Update_statusemoareff1(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


            }
            else
            {


                Label1_errore.Text = "The permitted date has not been reached";
                return;
            }





        }


      





    

     if (factore == "6")
        {
            if (statuse_moaref > 0)
            {

                Label1_errore.Text = "The application has already been registered";
                return;

            }




            if   (Convert.ToDateTime(date1.Text) <= Convert.ToDateTime(date11))

            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(ghabelbardasht.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan1", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


                using (DataSetTableAdapters.Factore2TableAdapter ins1 = new DataSetTableAdapters.Factore2TableAdapter())
                {

                    ins1.Update_statusemoareff2(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


            }
            else
            {


                Label1_errore.Text = "The permitted date has not been reached";
                return;
            }





        }


        Response.Redirect("user-profile.aspx");





    }





    protected void Button2_Click(object sender, EventArgs e)
    {


    //    if (Convert.ToInt32(vam) == 0)
    //    {
    //        return;

    //    }


        string date11;
        DateTime localDate1 = DateTime.Now;
        date11 = localDate1.ToString("yyyy/MM/dd");
        string valet_customer;
        valet_customer = "";


        ///search valet customer

        using (DataSetTableAdapters.CustomerTableAdapter ins11 = new DataSetTableAdapters.CustomerTableAdapter())
        {
            DataSet.CustomerDataTable ne11 = ins11.search_idcustomer(Convert.ToInt32(id_customer));
            foreach (DataSet.CustomerRow row3 in ne11)
            {
                valet_customer = row3.Valet__custemer;

            }

        }






        /// 














        if (factore == "1")
        {


            if (Convert.ToDouble(price_vam) > 0)

            {

           if(statuse_vam =="1")
                {
                    Label1_errore.Text = "Previously registered";
                    return;

                }



                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(vam.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan1", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


                //stause factore1 = 1

                using (DataSetTableAdapters.FactoreTableAdapter update1 = new DataSetTableAdapters.FactoreTableAdapter())
                {

                    update1.Updatevam_statusef1(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }








            }
            else
            {
               
                    Label1_errore.Text = "The loan application will not be registered";
                    return;

            }

//////////delete vam in fadtore




        }


        if (factore == "2")
        {
            if (Convert.ToDouble(price_vam) > 0)

            {

                if (statuse_vam == "1")
                {
                    Label1_errore.Text = "Previously registered";
                    return;

                }


                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(vam.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan2", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }

                using (DataSetTableAdapters.Factore2TableAdapter update1 = new DataSetTableAdapters.Factore2TableAdapter())
                {

                    update1.Update_vamstatusef2(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }








            }

            else
            {
                Label1_errore.Text = "The loan application will not be registered";
                return;

            }


        }



        if (factore == "3")
        {
            //مبلغ بداشت دو برابر شده باشد
            if (Convert.ToDouble(vam.Text) > 0)

            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(vam.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan3", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }




            }




        }


        if (factore == "4")
        {

            //جستجو معرفان تا عدد 6 برسد
            if (Convert.ToDouble(vam.Text) > 0)
            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(vam.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan4", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }




            }




        }


        if (factore == "5")
        {
            if (statuse_moaref > 0)
            {

                Label1_errore.Text = "The application has already been registered";
                return;

            }




            if (date1.Text == date11)

            {
                //save darkhast
                using (DataSetTableAdapters.darkhastTableAdapter ins1 = new DataSetTableAdapters.darkhastTableAdapter())
                {

                    ins1.Insert(ghabelbardasht.Text, valet_customer, Convert.ToInt32(id_customer), "0", factore, "plan1", date11, 0, "");
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


                using (DataSetTableAdapters.FactoreTableAdapter ins1 = new DataSetTableAdapters.FactoreTableAdapter())
                {

                    ins1.Update_statusemoareff1(id_cash1);
                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                }


            }
            else
            {


                Label1_errore.Text = "The permitted date has not been reached";
                return;
            }

        }


            Response.Redirect("Default.aspx");







    }
}