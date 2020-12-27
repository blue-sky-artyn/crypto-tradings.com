using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class gallery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string headerStr = string.Empty;string headerDetStr = string.Empty;string galleryItemsStr = string.Empty;int counter = 0;
        #region Reading post values

        tblGalleryGroupCollection galleryGrpTbl = new tblGalleryGroupCollection();
        tblGalleryPicturesCollection galleryTbl = new tblGalleryPicturesCollection();
       
        int itemGet = 0;
        if (Request.QueryString["itemId"] != null)
        {
            itemGet = int.Parse(Request.QueryString["itemId"]);
            galleryGrpTbl.ReadList(Criteria.NewCriteria(tblGalleryGroup.Columns.id, CriteriaOperators.Equal, itemGet));
            galleryTbl.ReadList(Criteria.NewCriteria(tblGalleryPictures.Columns.idGroup, CriteriaOperators.Equal, itemGet));
            headerStr = galleryGrpTbl[0].GalleryGroupTitle;
            headerDetStr = galleryGrpTbl[0].GalleryGroupDetail;
        }
        else
        {
            Response.Redirect("default.aspx");
        }

        #endregion

        #region filling header text

        headerGalleryHtml.InnerHtml = "<h3>" + headerStr + "</h3><p class='lead'>" + headerDetStr + "</p>";

        #endregion

        #region items filling

        galleryItemsStr += "<div class='gallery-row'>";
        for (int i = 0; i < galleryTbl.Count; i++)
        {
            if (counter == 4)
            {
                galleryItemsStr += "</div><div class='gallery-row'>";
                counter = 0;
            }
            galleryItemsStr += "<div class='col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn' data-wow-duration='1s' data-wow-delay='0.2s'>"+
                                "<div class='widget clearfix'><img src='"+galleryTbl[i].GalleryPicAddr + galleryTbl[i].GalleryPicName + "' alt='bondelectric '"+ galleryTbl[i].GalleryPicName + "' class='img-responsive'>" +
                                "<div class='widget-title'><h3>"+ galleryTbl[i].GalleryPicTitle + "</h3></div><p>"+ galleryTbl[i].GalleryPicDetail + "</p>" +
                                "<hr></div></div>";

            counter++;
        }

        gallertItemsHtml.InnerHtml = galleryItemsStr;

        #endregion

        #region header top picture
        tblLogsCollection picTopTbl = new tblLogsCollection();
        picTopTbl.ReadList();
        if (picTopTbl.Count > 0)
            headerPicHtml.Attributes["style"] = "background: url(" + picTopTbl[0].logDetail + ")no-repeat;background-size: cover;background-position: center;";
        #endregion

    }
}