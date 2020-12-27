using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_information_details : System.Web.UI.Page
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

        tblInformationPicCollection infPicTbl = new tblInformationPicCollection();
        infPicTbl.ReadList(Criteria.NewCriteria(tblInformationPic.Columns.infId, CriteriaOperators.Equal, Convert.ToInt32(itemGet)));

        tblInformationDetailCollection infTbl = new tblInformationDetailCollection();
        infTbl.ReadList(Criteria.NewCriteria(tblInformationDetail.Columns.id, CriteriaOperators.Equal, Convert.ToInt32(itemGet)));

        newsDetHtml.InnerHtml = "<h4>" + infTbl[0].infDetailInsertDate + "</h4>" +
                                "<h2>" + infTbl[0].infDetailTitle + "</h2>" +
                                "<p>" + infTbl[0].infDetailDescription + "</p>";

        if (infTbl[0].frontFile.Length > 0)
            newsImgHtml.InnerHtml = "<img src='images/info/" + infTbl[0].frontFile + "' alt='bondelectric " + infTbl[0].frontFile + "' class='img-responsive img-rounded'>";
        else
            newsImgHtml.InnerHtml = "<img src='images/info/default.jpg' alt='Bond Electric' class='img-responsive img-rounded'>";

    }
}