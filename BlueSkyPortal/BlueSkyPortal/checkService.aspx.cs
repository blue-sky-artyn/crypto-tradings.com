using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Xml.Linq;





public partial class checkService : System.Web.UI.Page
{

    // to convert ascii code to int
    //int tt = Convert.ToInt32(pass_byte[0].ToString());
    //string a = ((char)tt).ToString();

    protected void Page_Load(object sender, EventArgs e)
    {
        string Url = "https://api.trongrid.io/event/transaction/";

        #region refrence number
        string refrenceNumberStr = "";

        if (Request.QueryString["refNum"] != null)
        {
            refrenceNumberStr = Request.QueryString["refNum"];
        }
        else
            Response.Redirect("404.aspx");

        #endregion


        #region read HTML data 1


        //HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
        //myRequest.Method = "GET";
        //WebResponse myResponse = myRequest.GetResponse();
        //StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
        //string result = sr.ReadToEnd();
        //sr.Close();
        //myResponse.Close();

        #endregion


        #region read HTML data 2


        //// We'll use WebClient class for reading HTML of web page
        //WebClient MyWebClient = new WebClient();
        //Byte[] PageHTMLBytes;
        //PageHTMLBytes = MyWebClient.DownloadData(Url);


        //UTF8Encoding oUTF8 = new UTF8Encoding();
        //string txtPageHTML = oUTF8.GetString(PageHTMLBytes);

        #endregion
 

        #region read HTML data 3

        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = new HtmlDocument();
        doc = web.Load("https://tronscan.org/#/transaction/" + refrenceNumberStr);






        





        string contents = doc.DocumentNode.OuterHtml;
        string text = doc.DocumentNode.InnerText;



        int errorIndex = contents.IndexOf("Sorry, the transaction could not be found.");
        if (true)
        {

        }
        //<main 
        //Sorry, the transaction could not be found.

        #endregion

        string script = "const options = { method: 'GET' };" +
        "fetch('https://api.trongrid.io/v1/transactions/" + refrenceNumberStr + "/events', options)" +
        ".then(response => document.cookie = 'status=' + response.status)" +
        ".catch(err => console.error(err));" +
        "var statusCookie = getCookie('status');" +
        "window.location.replace('iframe.aspx?staus=' + statusCookie );";

        script += "function getCookie(cname) {var name = cname + '=';"+
            "var ca = document.cookie.split(';');"+
            "for (var i = 0; i < ca.length; i++) {var c = ca[i];"+
                "while (c.charAt(0) == ' ') {c = c.substring(1);}"+
                "if (c.indexOf(name) == 0) {return c.substring(name.length, c.length);}}"+
            "return '';}";
        //ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", script, true);



    } 
}