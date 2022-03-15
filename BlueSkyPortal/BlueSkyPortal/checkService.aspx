c<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkService.aspx.cs" Inherits="checkService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>


        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script>
        //function getCookie(cname) {
        //    var name = cname + "=";
        //    var ca = document.cookie.split(';');
        //    for (var i = 0; i < ca.length; i++) {
        //        var c = ca[i];
        //        while (c.charAt(0) == ' ') {
        //            c = c.substring(1);
        //        }
        //        if (c.indexOf(name) == 0) {
        //            return c.substring(name.length, c.length);
        //        }
        //    }
        //    return "";
        //}




        const options = { method: 'GET' };
        fetch('https://api.trongrid.io/v1/transactions/35946e727001fd49779cd4a8f3378a3e9a38b64be87b8d4f153a17594d044f45/events', options)
            .then(response => console.log( response))
            .catch(err => console.error(err));


        //var statusCookie = getCookie('status');
        ////alert(statusCookie);
        //window.location.replace('iframe.aspx?status=' + statusCookie );


        //http://localhost:62679/checkService.aspx?refNum=35946e727001fd49779cd4a8f3378a3e9a38b64be87b8d4f153a17594d044f45
    </script>
</body>
</html>
