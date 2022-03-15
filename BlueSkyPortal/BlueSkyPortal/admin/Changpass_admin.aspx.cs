using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Changpass_admin : System.Web.UI.Page
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
          

                using (DataSetTableAdapters.AdminTableAdapter ins52 = new DataSetTableAdapters.AdminTableAdapter())
                {

                    ins52.Update_passadmin(txt_old.Value, txt_new1.Value);
                }

            
        }
        Response.Redirect("default.aspx");













    }
}