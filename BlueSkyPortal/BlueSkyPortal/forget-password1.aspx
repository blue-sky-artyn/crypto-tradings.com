<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forget-password1.aspx.cs" Inherits="admin_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />    
    <!--[if gt IE 8]>
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />        
    <![endif]-->                
    <title>Forget Password - Aries Premium Admin Template</title>
    <link rel="icon" type="image/ico" href="favicon.ico"/>
    
    <link href="css/stylesheets.css" rel="stylesheet" type="text/css" />
    <!--[if lt IE 10]>
        <link href="css/ie.css" rel="stylesheet" type="text/css" />
    <![endif]-->           
    <!--[if lte IE 7]>
        <script type='text/javascript' src='js/plugins/other/lte-ie7.js'></script>
    <![endif]-->    
    <script type='text/javascript' src='js/plugins/jquery/jquery-1.9.1.min.js'></script>
    <script type='text/javascript' src='js/plugins/jquery/jquery-ui-1.10.1.custom.min.js'></script>
    <script type='text/javascript' src='js/plugins/jquery/jquery-migrate-1.1.1.min.js'></script>
    <script type='text/javascript' src='js/plugins/jquery/globalize.js'></script>
    <script type='text/javascript' src='js/plugins/other/excanvas.js'></script>
    
    <script type='text/javascript' src='js/plugins/other/jquery.mousewheel.min.js'></script>
        
    <script type='text/javascript' src='js/plugins/bootstrap/bootstrap.min.js'></script>
    
    <script type='text/javascript' src="js/plugins/uniform/jquery.uniform.min.js"></script>
    
    <script type='text/javascript' src='js/plugins/shbrush/XRegExp.js'></script>
    <script type='text/javascript' src='js/plugins/shbrush/shCore.js'></script>
    <script type='text/javascript' src='js/plugins/shbrush/shBrushXml.js'></script>
    <script type='text/javascript' src='js/plugins/shbrush/shBrushJScript.js'></script>
    <script type='text/javascript' src='js/plugins/shbrush/shBrushCss.js'></script>    
    
    <script type='text/javascript' src='js/plugins.js'></script>
    <script type='text/javascript' src='js/charts.js'></script>
    <script type='text/javascript' src='js/actions.js'></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="loader"><img src="img/loader.gif"/></div>
       
    <div class="login">

        <div class="page-header">
            <div class="icon">
                <span class="ico-arrow-right"></span>
            </div>
            <h1>Forget Password <small>METRO STYLE ADMIN PANEL</small></h1>
        </div>        
        
        <div class="row-fluid">
            <div class="row-form">
                <div class="span12">

                    <input type="email" name="name" value="" ID="txtEmail" runat="server" class="input-value form-control" placeholder="Email" AutoCompleteType="None"
                                            pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$"  />

                    <br />

                     <p id="lblErrorHtml" runat="server" style="color: red;"></p>
              
<<<<<<< HEAD
=======
                                   
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                    
                                    
                </div>
            </div>
    
            
            <div class="row-form">
                <div class="span12">
<<<<<<< HEAD
                    <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Submit" OnClick="Button1_Click1" />

                    <%--<button >Send request<span class="icon-arrow-next icon-white"></span></button>--%>
=======

                    <button class="btn">Send request<span class="icon-arrow-next icon-white"></span></button>
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                </div>                
            </div>
        </div>
    </div>
    </form>
</body>
</html>
