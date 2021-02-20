using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Changepass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int i1;
        i1 = 0;
        string username = string.Empty;
        string pass = string.Empty;
        string name_customer = string.Empty;
        pass = txt_old.Value;
        //  pass = Decrypt(pass);
        if (txt_new1.Value == txt_new2.Value)
        {
            using (DataSetTableAdapters.CustomerTableAdapter pass15 = new DataSetTableAdapters.CustomerTableAdapter())
            {
                DataSet.CustomerDataTable mess5 = pass15.Search_pass_customer(txtEmail.Value, pass);
                foreach (DataSet.CustomerRow date25 in mess5)
                {
                    i1 = 1;


                }
            }
            if(i1==1)
            {

                using (DataSetTableAdapters.CustomerTableAdapter ins52 = new DataSetTableAdapters.CustomerTableAdapter())
                {

                    ins52.update_pass_customer(txtEmail.Value, txt_new1.Value);
                }

            }
        }
    }
}