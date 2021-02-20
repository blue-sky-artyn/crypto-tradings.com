using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_plans : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Loginadmin"] == null)
        {
            Response.Redirect("login.aspx");
        }
        string s;
        s = "";
        using (DataSetTableAdapters.Sub_plansTableAdapter ins1 = new DataSetTableAdapters.Sub_plansTableAdapter())
        {
            DataSet.Sub_plansDataTable ne1 = ins1.search_subplan24();
            foreach (DataSet.Sub_plansRow row3 in ne1)
            {

                s+= "<tr>";
                s += "<td><input type='checkbox''name='order[]' value = '528' /></td>";
                s += "<td><a href ='#'> "+row3.Name_plan+" </a></td>";
                s += "<td> plan_id="+row3.Id_paln+"</td>";
                s += "<td><span class='label label-important'>New</span></td>";
                s += "<td>"+row3.Period+"</td>";
                s += "<td>";
                s += "<a href ='plans-details.aspx?id=" + row3.Id_subplan+"'class='button green'>";
                s += "<div class=''icon'><span class='ico-pencil'></span></div>";
                s += "</a>";
                s += "</td>";
                s += "</tr>";

            }
        }

        Literal1.Text = s;



        
                                                              
                                                
                                                     
                                                   
                                               
                                                       
                                                                                               
                                              
                                          








    }
}