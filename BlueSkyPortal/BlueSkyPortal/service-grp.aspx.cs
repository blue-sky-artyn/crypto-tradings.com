using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_service_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["itemNo"] != null)
        {
            itemGet = int.Parse(Request.QueryString["itemNo"]);
        }
        else
            Response.Redirect("default.aspx");

        string servicesString = string.Empty;
        tblServicesCollection servicesTbl = new tblServicesCollection();
        servicesTbl.ReadList(Criteria.NewCriteria(tblServices.Columns.idServiceGroup, CriteriaOperators.Equal, itemGet));

        tblServiceGroupCollection serviceGrpTbl = new tblServiceGroupCollection();
        serviceGrpTbl.ReadList(Criteria.NewCriteria(tblServiceGroup.Columns.id, CriteriaOperators.Equal, itemGet));

        tblServicePicCollection servicePicTbl = new tblServicePicCollection();

        for (int i = 0; i < servicesTbl.Count; i++)
        {
            servicePicTbl.ReadList(Criteria.NewCriteria(tblServicePic.Columns.idService, CriteriaOperators.Equal, servicesTbl[i].id));

            servicesString += "<div class='col-md-3'><div class='message-box'>" +
                                "<h4>" + serviceGrpTbl[0].ServiceGroupTitle + "</h4>" +
                                "<img src='images/service/"+servicePicTbl[0].picName+ "' alt='bondelectric " + servicePicTbl[0].picName + "' />" +
                                "<h2>" + servicesTbl[i].ServiceTitle + "</h2>" +
                                "<p>" + servicesTbl[i].ServiceDetail + "</p></div></div>";
        }
        servicesHtml.InnerHtml = servicesString;

        #region header top picture
        tblLogsCollection picTopTbl = new tblLogsCollection();
        picTopTbl.ReadList();
        //if (picTopTbl.Count > 0)
            //headerPicHtml.Attributes["style"] = "background: url(" + picTopTbl[0].logDetail + ")no-repeat;background-size: cover;background-position: center;";
        #endregion

    }
}