using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_service : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
        string serviceStr = string.Empty;
        tblServiceGroupCollection serviceGrpTbl = new tblServiceGroupCollection();
        tblServicePicCollection servicePicTbl = new tblServicePicCollection();
        tblServicesCollection serviceTbl = new tblServicesCollection();

        int itemGet = 0;
        if (Request.QueryString["itemId"] != null)
        {
            itemGet = int.Parse(Request.QueryString["itemId"]);
            serviceTbl.ReadList(Criteria.NewCriteria(tblServices.Columns.idServiceGroup,CriteriaOperators.Equal,itemGet));
        }
        else
            serviceTbl.ReadList();
        


        for (int i = 0; i < serviceTbl.Count; i++)
        {
            serviceGrpTbl.ReadList(Criteria.NewCriteria(tblServiceGroup.Columns.id, CriteriaOperators.Equal, serviceTbl[i].idServiceGroup));
            servicePicTbl.ReadList(Criteria.NewCriteria(tblServicePic.Columns.idService, CriteriaOperators.Equal, serviceTbl[i].id));

            serviceStr += "<div class='col-md-4 col-sm-6 col-xs-12'>" +
                        "<div class='grid1'><span>" + serviceGrpTbl[0].ServiceGroupTitle + "</span>" +
                        "<div class='price-tit text-center'>" +
                        "<img src='images/service/"+ servicePicTbl[0].picName+ "' alt='bondelectric " + servicePicTbl[0].picName + "' class='service-image' />" +
                        "<h2>" + serviceTbl[i].ServiceTitle + "</h2><p>" + serviceGrpTbl[0].ServiceGroupDetail + "</p></div>" +
                        "<div class='para'><p>" + serviceTbl[i].ServiceDetail + "</p></div></div></div>";
        }

        serviceStr += "<div class='clear'> </div>";

        serviceHtml.InnerHtml = serviceStr;

        #region header top picture
        tblLogsCollection picTopTbl = new tblLogsCollection();
        picTopTbl.ReadList();
        if (picTopTbl.Count > 0)
            headerPicHtml.Attributes["style"] = "background: url(" + picTopTbl[0].logDetail + ")no-repeat;background-size: cover;background-position: center;";
        #endregion

    }
}