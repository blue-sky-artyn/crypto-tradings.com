using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Menu_user3 : System.Web.UI.Page
{
    string date1;
    string id_customer;
    int statuse_factore3;
    string date_facrore3_end;
    string date_facrore3_start;
    string price_summande;
    string price_kolcash_factore3;
    string price_avali;
    string vam;
    string sodf3;
    string price_summande1;
    protected SqlConnection Connection;
    protected SqlCommand command;
    protected SqlDataReader dataReader;

    protected SqlConnection Connection1;
    protected SqlCommand command1;
    protected SqlDataReader dataReader1;

    protected void GridView1DataBound(object sender, GridViewRowEventArgs e)
    {
        Label Label1;

        int a;

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label1 = (Label)e.Row.FindControl("label1");
            a = e.Row.RowIndex + (GridView1.PageIndex * 10);
            Label1.Text = a.ToString();
        }
    }

    protected void GridView2DataBound(object sender, GridViewRowEventArgs e)
    {
        Label Label2;

        int a;

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label2 = (Label)e.Row.FindControl("label2");
            a = e.Row.RowIndex + (GridView2.PageIndex * 10);
            Label2.Text = a.ToString();
        }
    }


    protected void GridView3DataBound(object sender, GridViewRowEventArgs e)
    {
        Label Label3;

        int a;

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label3 = (Label)e.Row.FindControl("label3");
            a = e.Row.RowIndex + (GridView3.PageIndex * 10);
            Label3.Text = a.ToString();
        }
    }


    protected void GridView4DataBound(object sender, GridViewRowEventArgs e)
    {
        Label Label4;

        int a;

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label4 = (Label)e.Row.FindControl("label4");
            a = e.Row.RowIndex + (GridView4.PageIndex * 10);
            Label4.Text = a.ToString();
        }
    }

    protected void GridView5DataBound(object sender, GridViewRowEventArgs e)
    {
        Label Label51;

        int a;

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label51 = (Label)e.Row.FindControl("label5");
            a = e.Row.RowIndex + (GridView5.PageIndex * 10);
            Label51.Text = a.ToString();
        }
    }


    protected void GridView6DataBound(object sender, GridViewRowEventArgs e)
    {
        Label Label6;

        int a;

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label6 = (Label)e.Row.FindControl("label5");
            a = e.Row.RowIndex + (GridView6.PageIndex * 10);
              Label6.Text = a.ToString();
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
       // id_customer ="15";
        statuse_factore3 = 0;
        price_kolcash_factore3 = "0";

        //************چک شود لاگین شده باشد


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






        //*******************************
        DateTime localDate1 = DateTime.Now;
        string referal_code;
        referal_code = "";
        string s1;
        string s2;
        string s3;
        string s4;
        string s5;
        string s6;


        string s11;
        string s22;
        string s33;
        string s44;
        string s55;
        string s66;




        s1 = "";
        s2 = "";
        s3 = "";
        s4 = "";
        s5 = "";
        s6 = "";

        s11 = "";
        s22 = "";
        s33 = "";
        s44 = "";
        s55 = "";
        s66 = "";



        date1 = localDate1.ToString("yyyy/MM/dd");
        Label1.Text = date1;
        //Session["id_customer"] = 15;
        Session["date1"] = date1;
        id_customer = Convert.ToString(Session["id_customer"]);
        ///search  old f1

        int statuse_old;
        statuse_old = 0;
    //    using (DataSetTableAdapters.FactoreTableAdapter ins11 = new DataSetTableAdapters.FactoreTableAdapter())
    //    {
    //        DataSet.FactoreDataTable ne11 = ins11.search_oldf1(date1,Convert.ToInt32(id_customer));
     //       foreach (DataSet.FactoreRow row3 in ne11)
      ///      {
                statuse_old = 1;
        //      }
        //    }
        //    if(statuse_old == 1)
        //    {
        //        Literal7.Text = "<p>Previous plans</p>";

        //    }
        /// 



        /// مشخص کردن برداشت و واریز

        Connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
        command = new SqlCommand();
        command.Connection = Connection;
        Connection.Open();


        command.CommandText = "sum_varizcustomer";
        command.CommandType = System.Data.CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id_customer", Convert.ToInt32(id_customer));
        dataReader = command.ExecuteReader();
        if (dataReader.Read())
        {
            Label3_deposit.Text = Convert.ToString(dataReader["AveragePrice1"].ToString());

        }


        Connection.Close();


        /// 
        Connection1 = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CryptoConnectionString"].ConnectionString);
        command1 = new SqlCommand();
        command1.Connection = Connection1;
        Connection1.Open();


        command1.CommandText = "sum_darkhast";
        command1.CommandType = System.Data.CommandType.StoredProcedure;
        command1.Parameters.AddWithValue("@id_customer", Convert.ToInt32(id_customer));
        dataReader1 = command1.ExecuteReader();
        if (dataReader1.Read())
        {
            label_withdrawal.Text = Convert.ToString(dataReader1["AveragePrice1"].ToString());

        }


        Connection1.Close();





        //*********










        //**********************مشخصات مشتری جهت پر کردن رفرال
        using (DataSetTableAdapters.CustomerTableAdapter ins11 = new DataSetTableAdapters.CustomerTableAdapter())
        {
            DataSet.CustomerDataTable ne11 = ins11.search_idcustomer(Convert.ToInt32(id_customer));
            foreach (DataSet.CustomerRow row3 in ne11)
            {
                referal_code = row3.referal_code;
            }
        }

        //*************جستجو در جدول رفرال
        using (DataSetTableAdapters.select_referal1TableAdapter ins11 = new DataSetTableAdapters.select_referal1TableAdapter())
        {
            DataSet.select_referal1DataTable ne11 = ins11.Search_referal_sadh1(referal_code);
            foreach (DataSet.select_referal1Row row3 in ne11)
            {
               s11 = "Level1 = ";
               s1 += row3.Referal_customer;
               s1 += "-";
            }
        }

        using (DataSetTableAdapters.select_referal1TableAdapter ins11 = new DataSetTableAdapters.select_referal1TableAdapter())
        {
            DataSet.select_referal1DataTable ne11 = ins11.Search_referal_sadh2(referal_code);
            foreach (DataSet.select_referal1Row row3 in ne11)
            {
                s22 = "Level2 = ";
                s2 += row3.Referal_customer;
                s2 += "-";
            }
        }


        using (DataSetTableAdapters.select_referal1TableAdapter ins11 = new DataSetTableAdapters.select_referal1TableAdapter())
        {
            DataSet.select_referal1DataTable ne11 = ins11.Search_referal_sadh3(referal_code);
            foreach (DataSet.select_referal1Row row3 in ne11)
            {
                s33 = "Level3 = ";
                s3 += row3.Referal_customer;
                s3 += "-";
            }
        }



        using (DataSetTableAdapters.select_referal1TableAdapter ins11 = new DataSetTableAdapters.select_referal1TableAdapter())
        {
            DataSet.select_referal1DataTable ne11 = ins11.Search_referal_sadh4(referal_code);
            foreach (DataSet.select_referal1Row row3 in ne11)
            {
                s44 = "Level4 = ";
                s4 += row3.Referal_customer;
                s4 += "-";
            }
        }



        using (DataSetTableAdapters.select_referal1TableAdapter ins11 = new DataSetTableAdapters.select_referal1TableAdapter())
        {
            DataSet.select_referal1DataTable ne11 = ins11.Search_referal_sadh5(referal_code);
            foreach (DataSet.select_referal1Row row3 in ne11)
            {
                s55 = "Level5 = ";
                s5 += row3.Referal_customer;
                s5 += "-";
            }
        }





        using (DataSetTableAdapters.select_referal1TableAdapter ins11 = new DataSetTableAdapters.select_referal1TableAdapter())
        {
            DataSet.select_referal1DataTable ne11 = ins11.Search_referal_sadh6(referal_code);
            foreach (DataSet.select_referal1Row row3 in ne11)
            {
                s66 = "Level6 = ";
                s6 += row3.Referal_customer;
                s6 += "-";
            }
        }
        
        Literal1.Text = s11 + s1;
        Literal2.Text = s22 + s2;
        Literal3.Text = s33 + s3;
        Literal4.Text = s44 + s4;
        Literal5.Text = s55+ s5;
        Literal6.Text = s66 + s6;
        //*******************************
        //*****************************************
        int id_cash11;
        id_cash11 = 0;
        string name_plan;
        name_plan = "";
        string price_start1;
        price_start1 = "";
        //ایا مشتری در این پلن سرمایه گزاری کرده است

        using (DataSetTableAdapters.Factore3TableAdapter ins16 = new DataSetTableAdapters.Factore3TableAdapter())
        {
            DataSet.Factore3DataTable ne16 = ins16.search_factore3_idcustomer(Convert.ToInt32(id_customer));
            foreach (DataSet.Factore3Row row6 in ne16)
            {
                statuse_factore3 = 1;
                date_facrore3_end = row6.Date_bargasht;
                price_summande = row6.Price_sumdate;
                price_avali = row6.Price_Start;
                vam = row6.Price_vam;
                date_facrore3_start = row6.Date_Start;
                sodf3 = row6.Darsad_sod;
                id_cash11 = row6.Id_cash;
                name_plan = row6.Desk_factore1;
                price_start1 = row6.Price_Start;

/////////**************************************


        if (statuse_factore3 == 1)
        {


            decimal darsad_plan3;

             darsad_plan3 = 0;

                    ////////details        plan3

                    int Balance1;
                    int Balance2;
                    int Balance3;
                    int Balance4;
                    int Balance5;

                    Balance1 = 0;
                    Balance2 = 0;
                    Balance3 = 0;
                    Balance4 = 0;
                    Balance5 = 0;

                    Decimal Variable1;
                    Decimal Variable2;
                    Decimal Variable3;
                    Decimal Variable4 ;
                    Variable1 = 0;
                    Variable2 = 0;
                    Variable3 = 0;
                    Variable4 = 0;
                    //*************search Balance1 and Variable1

                    using (DataSetTableAdapters.PlanTableAdapter ins11 = new DataSetTableAdapters.PlanTableAdapter())
                    {
                        DataSet.PlanDataTable ne11 = ins11.select_plan1(3);
                        foreach (DataSet.PlanRow row3 in ne11)
                        {
                            Balance1 = row3.Statuse;
                           Variable1 = Convert.ToDecimal(row3.Valet_plan);
                         //   Variable1 = 0.001;

                        }

                    }
                    Balance2 = Balance1 + 40000;
                    Balance3 = Balance2 + 40000;
                    Balance4 = Balance3 + 40000;
                    Balance5 = Balance4 + 40000;

                    Variable2 = Variable1 + Variable1;
                    Variable3 = Variable1 + Variable1 + Variable1;
                    Variable4 = Variable1 + Variable1 + Variable1 + Variable1;

                  //  Label4.Text = Convert.ToString(Variable1);

                    //*******************


                    decimal darsad;
            string date_end1;
            string s;
                    decimal ss;
            int tol;
            s = Convert.ToString(Convert.ToDateTime(date1) - Convert.ToDateTime(date_facrore3_end));
            s = s.Replace(':', '0');
            ss = Convert.ToDecimal(s);
         //   Label1.Text = Convert.ToString(ss);
            tol = Convert.ToInt32(ss);
            DateTime localDate3 = Convert.ToDateTime(date_facrore3_end);

            using (DataSetTableAdapters.Cash_factore3TableAdapter ins11 = new DataSetTableAdapters.Cash_factore3TableAdapter())
            {
                DataSet.Cash_factore3DataTable ne11 = ins11.Search_cashfactore3date(date1);
                foreach (DataSet.Cash_factore3Row row3 in ne11)
                {
                    price_kolcash_factore3 = row3.Price_kol;

                }

            }
                    //**************send plan 3

                    using (DataSetTableAdapters.Sub_plansTableAdapter ins11 = new DataSetTableAdapters.Sub_plansTableAdapter())
                    {
                        DataSet.Sub_plansDataTable ne11 = ins11.Search_subplanid(Convert.ToInt32(9));
                        foreach (DataSet.Sub_plansRow row1 in ne11)
                        {

                            darsad_plan3 = Convert.ToDecimal(row1.Darsad);



                        }

                    }




                    //************




                    //************اضافه کردن به صندوق ان فرد تا روز جاری             
                    if ((Convert.ToInt32(price_kolcash_factore3) < Balance1))
            {
                price_summande1 = price_summande;
                while (tol > 0)
                {
                    darsad =(Convert.ToDecimal(price_start1) * darsad_plan3);
                    price_summande1 = Convert.ToString(Convert.ToDecimal(price_summande1) +darsad);

                     localDate3 = Convert.ToDateTime(localDate3).AddDays(1);
                     date_end1 = localDate3.ToString("yyyy/MM/dd");

                 
                   
                    //**********ذخیره در فاکتور 3
                    using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                    {

                        ins1.Insert(9, Convert.ToInt32(id_customer), date_facrore3_start,  price_avali, vam, price_summande1 , date_end1, sodf3,
                           "", "", 0,"", 0, 0, "", Convert.ToString(localDate3), name_plan, id_cash11);
                        //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                    }


                    //*************

                    tol = tol - 1;
                }

            }


            //****************صندوق بالای 40000*************

            if ((Convert.ToInt32(price_kolcash_factore3) > Balance1))
                if ((Convert.ToInt32(price_kolcash_factore3) < Balance2))
            {
                price_summande1 = price_summande;
                while (tol > 0)
                {
                    darsad =Convert.ToDecimal(   (Convert.ToDecimal(price_start1) * (Convert.ToDecimal( darsad_plan3)+Variable1)));
                    price_summande1 = Convert.ToString(Convert.ToDecimal(price_summande1) + darsad);

                    localDate3 = Convert.ToDateTime(localDate3).AddDays(1);
                    date_end1 = localDate3.ToString("yyyy/MM/dd");

             

                    //**********ذخیره در فاکتور 3
                    using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                    {

                        ins1.Insert(9, Convert.ToInt32(id_customer), date_facrore3_start, price_avali, vam, price_summande1, date_end1, sodf3,
                           "", "", 0, "", 0, 0, "", Convert.ToString(localDate3), "", 0);
                        //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                    }


                    //*************

                    tol = tol - 1;
                }

            }
            //*********************

            ////بیشتر ازط 80000
            if ((Convert.ToInt32(price_kolcash_factore3) > Balance1))
                if ((Convert.ToInt32(price_kolcash_factore3) > Balance2))
                    if ((Convert.ToInt32(price_kolcash_factore3) < Balance3))
                    {
                    price_summande1 = price_summande;
                    while (tol > 0)
                    {
                        darsad = (Convert.ToDecimal(price_start1) * (darsad_plan3 + Variable2));
                        price_summande1 = Convert.ToString(Convert.ToDecimal(price_summande1) + darsad);

                        localDate3 = Convert.ToDateTime(localDate3).AddDays(1);
                        date_end1 = localDate3.ToString("yyyy/MM/dd");

                   

                        //**********ذخیره در فاکتور 3
                        using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                        {

                            ins1.Insert(9, Convert.ToInt32(id_customer), date_facrore3_start, price_avali, vam, price_summande1, date_end1, sodf3,
                               "", "", 0, "", 0, 0, "", Convert.ToString(localDate3), "", 0);
                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                        }


                        //*************

                        tol = tol - 1;
                    }

                }

            ////********
            //بیشتر از 120000
            //*********************

       
            if ((Convert.ToInt32(price_kolcash_factore3) > Balance1))
                if ((Convert.ToInt32(price_kolcash_factore3) > Balance2))
                    if ((Convert.ToInt32(price_kolcash_factore3) > Balance3))
                        if ((Convert.ToInt32(price_kolcash_factore3) < Balance4))
                        {
                        price_summande1 = price_summande;
                        while (tol > 0)
                        {
                            darsad = (Convert.ToDecimal(price_start1) * (darsad_plan3 + Variable3));
                           price_summande1 = Convert.ToString(Convert.ToDecimal(price_summande1) + darsad);

                            localDate3 = Convert.ToDateTime(localDate3).AddDays(1);
                            date_end1 = localDate3.ToString("yyyy/MM/dd");

                        

                            //**********ذخیره در فاکتور 3
                            using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                            {

                                ins1.Insert(9, Convert.ToInt32(id_customer), date_facrore3_start, price_avali, vam, price_summande1, date_end1, sodf3,
                                   "", "", 0, "", 0, 0, "", Convert.ToString(localDate3), "", 0);
                                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                            }


                            //*************

                            tol = tol - 1;
                        }

                    }

            ////********


            //**************************







        }







//***********************************************************************************              

            }

        }


        //اگه دو بار ثبت نام کرده بود در این پلن




        using (DataSetTableAdapters.Factore3TableAdapter ins16 = new DataSetTableAdapters.Factore3TableAdapter())
        {
            DataSet.Factore3DataTable ne16 = ins16.search_factore3_idcustomer22(Convert.ToInt32(id_customer), id_cash11);
            foreach (DataSet.Factore3Row row6 in ne16)
            {
                statuse_factore3 = 1;
                date_facrore3_end = row6.Date_bargasht;
                price_summande = row6.Price_sumdate;
                price_avali = row6.Price_Start;
                vam = row6.Price_vam;
                date_facrore3_start = row6.Date_Start;
                sodf3 = row6.Darsad_sod;
                id_cash11 = row6.Id_cash;
                name_plan = row6.Desk_factore1;
                price_start1 = row6.Price_Start;
            }

                /////////**************************************


                if (statuse_factore3 == 1)
                {


                    ////////details        plan3

                    int Balance1;
                    int Balance2;
                    int Balance3;
                    int Balance4;
                    int Balance5;

                    Balance1 = 0;
                    Balance2 = 0;
                    Balance3 = 0;
                    Balance4 = 0;
                    Balance5 = 0;

                    Decimal Variable1;
                    Decimal Variable2;
                    Decimal Variable3;
                    Decimal Variable4;
                    Variable1 = 0;
                    Variable2 = 0;
                    Variable3 = 0;
                    Variable4 = 0;
                    //*************search Balance1 and Variable1

                    using (DataSetTableAdapters.PlanTableAdapter ins11 = new DataSetTableAdapters.PlanTableAdapter())
                    {
                        DataSet.PlanDataTable ne11 = ins11.select_plan1(3);
                        foreach (DataSet.PlanRow row3 in ne11)
                        {
                            Balance1 = row3.Statuse;
                            Variable1 = Convert.ToDecimal(row3.Valet_plan);
                            //   Variable1 = 0.001;

                        }

                    }
                    Balance2 = Balance1 + 40000;
                    Balance3 = Balance2 + 40000;
                    Balance4 = Balance3 + 40000;
                    Balance5 = Balance4 + 40000;

                    Variable2 = Variable1 + Variable1;
                    Variable3 = Variable1 + Variable1 + Variable1;
                    Variable4 = Variable1 + Variable1 + Variable1 + Variable1;

                 //   Label4.Text = Convert.ToString(Variable2);

                    //*******************




                    decimal darsad_plan3;
                    darsad_plan3 = 0;
                    decimal darsad;
                    string date_end1;
                    string s;
                    decimal ss;
                    int tol;
                    s = Convert.ToString(Convert.ToDateTime(date1) - Convert.ToDateTime(date_facrore3_end));
                    s = s.Replace(':', '0');
                    ss = Convert.ToDecimal(s);
                    //   Label1.Text = Convert.ToString(ss);
                    tol = Convert.ToInt32(ss);
                    DateTime localDate3 = Convert.ToDateTime(date_facrore3_end);

                    using (DataSetTableAdapters.Cash_factore3TableAdapter ins11 = new DataSetTableAdapters.Cash_factore3TableAdapter())
                    {
                        DataSet.Cash_factore3DataTable ne11 = ins11.Search_cashfactore3date(date1);
                        foreach (DataSet.Cash_factore3Row row3 in ne11)
                        {
                            price_kolcash_factore3 = row3.Price_kol;

                        }

                    }



                    //**************send plan 3

                    using (DataSetTableAdapters.Sub_plansTableAdapter ins11 = new DataSetTableAdapters.Sub_plansTableAdapter())
                    {
                        DataSet.Sub_plansDataTable ne11 = ins11.Search_subplanid(Convert.ToInt32(9));
                        foreach (DataSet.Sub_plansRow row1 in ne11)
                        {

                            darsad_plan3 = Convert.ToDecimal(row1.Darsad);



                        }

                    }




                    //************

                    //************اضافه کردن به صندوق ان فرد تا روز جاری             
                    if ((Convert.ToInt32(price_kolcash_factore3) < Balance1))
                    {
                        price_summande1 = price_summande;
                        while (tol > 0)
                        {
                            darsad = Convert.ToDecimal (Convert.ToDecimal(price_start1) * darsad_plan3);
                            price_summande1 = Convert.ToString(Convert.ToDecimal(price_summande1) + darsad);

                            localDate3 = Convert.ToDateTime(localDate3).AddDays(1);
                            date_end1 = localDate3.ToString("yyyy/MM/dd");



                            //**********ذخیره در فاکتور 3
                            using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                            {

                                ins1.Insert(9, Convert.ToInt32(id_customer), date_facrore3_start, price_avali, vam, price_summande1, date_end1, sodf3,
                                   "", "", 0, "", 0, 0, "", Convert.ToString(localDate3), name_plan, id_cash11);
                                //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                            }


                            //*************

                            tol = tol - 1;
                        }

                    }


                    //****************صندوق بالای 40000*************

                    if ((Convert.ToInt32(price_kolcash_factore3) > Balance1))
                        if ((Convert.ToInt32(price_kolcash_factore3) < Balance2))
                        {
                            price_summande1 = price_summande;
                            while (tol > 0)
                            {
                                darsad = (Convert.ToDecimal(price_start1) * (darsad_plan3 + Variable1));
                                price_summande1 = Convert.ToString(Convert.ToDecimal(price_summande1) + darsad);

                                localDate3 = Convert.ToDateTime(localDate3).AddDays(1);
                                date_end1 = localDate3.ToString("yyyy/MM/dd");



                                //**********ذخیره در فاکتور 3
                                using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                                {

                                    ins1.Insert(9, Convert.ToInt32(id_customer), date_facrore3_start, price_avali, vam, price_summande1, date_end1, sodf3,
                                       "", "", 0, "", 0, 0, "", Convert.ToString(localDate3), "", 0);
                                    //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                                }


                                //*************

                                tol = tol - 1;
                            }

                        }
                    //*********************

                    ////بیشتر ازط 80000
                    if ((Convert.ToInt32(price_kolcash_factore3) > Balance1))
                        if ((Convert.ToInt32(price_kolcash_factore3) > Balance2))
                            if ((Convert.ToInt32(price_kolcash_factore3) < Balance3))
                            {
                                price_summande1 = price_summande;
                                while (tol > 0)
                                {
                                    darsad = (Convert.ToDecimal(price_start1) * (darsad_plan3 + Variable2));
                                    price_summande1 = Convert.ToString(Convert.ToDecimal(price_summande1) + darsad);

                                    localDate3 = Convert.ToDateTime(localDate3).AddDays(1);
                                    date_end1 = localDate3.ToString("yyyy/MM/dd");



                                    //**********ذخیره در فاکتور 3
                                    using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                                    {

                                        ins1.Insert(9, Convert.ToInt32(id_customer), date_facrore3_start, price_avali, vam, price_summande1, date_end1, sodf3,
                                           "", "", 0, "", 0, 0, "", Convert.ToString(localDate3), "", 0);
                                        //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                                    }


                                    //*************

                                    tol = tol - 1;
                                }

                            }

                    ////********
                    //بیشتر از 120000
                    //*********************


                    if ((Convert.ToInt32(price_kolcash_factore3) > Balance1))
                        if ((Convert.ToInt32(price_kolcash_factore3) > Balance2))
                            if ((Convert.ToInt32(price_kolcash_factore3) > Balance3))
                                if ((Convert.ToInt32(price_kolcash_factore3) < Balance4))
                                {
                                    price_summande1 = price_summande;
                                    while (tol > 0)
                                    {
                                        darsad = (Convert.ToDecimal(price_start1) * (darsad_plan3 + Variable3));
                                        price_summande1 = Convert.ToString(Convert.ToDecimal(price_summande1) + darsad);

                                        localDate3 = Convert.ToDateTime(localDate3).AddDays(1);
                                        date_end1 = localDate3.ToString("yyyy/MM/dd");



                                        //**********ذخیره در فاکتور 3
                                        using (DataSetTableAdapters.Factore3TableAdapter ins1 = new DataSetTableAdapters.Factore3TableAdapter())
                                        {

                                            ins1.Insert(9, Convert.ToInt32(id_customer), date_facrore3_start, price_avali, vam, price_summande1, date_end1, sodf3,
                                               "", "", 0, "", 0, 0, "", Convert.ToString(localDate3), "", 0);
                                            //   Response.Redirect("~/Admin/Insert_mp3.aspx");
                                        }


                                        //*************

                                        tol = tol - 1;
                                    }

                                }
                }
           
        }
                
      
       
     





        //**********************


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id;
        id = GridView1.SelectedRow.Cells[1].Text;

        Response.Redirect("Rep_user.aspx?id="+id+"&&F=1");
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id;
        id = GridView2.SelectedRow.Cells[1].Text;

        Response.Redirect("Rep_user.aspx?id=" + id + "&&F=2");
    }

    protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id;
     


        id = GridView4.SelectedRow.Cells[1].Text;
        
        Response.Redirect("Rep_user.aspx?id=" + id + "&&F=4");
    }

    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id;
        double total;
        total = Convert.ToDouble(GridView3.SelectedRow.Cells[3].Text);
        total = total * 2;
      //  if (total >= Convert.ToDouble(GridView3.SelectedRow.Cells[4].Text))
      //  {

       //     return;
     //   }
        id = GridView3.SelectedRow.Cells[1].Text;

        Response.Redirect("Rep_user.aspx?id=" + id + "&&F=3");
    }

    protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id;
        id = GridView5.SelectedRow.Cells[1].Text;

        Response.Redirect("Rep_user.aspx?id=" + id + "&&F=5");
    }

    protected void GridView6_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id;
        id = GridView6.SelectedRow.Cells[1].Text;

        Response.Redirect("Rep_user.aspx?id=" + id + "&&F=6");
    }
}