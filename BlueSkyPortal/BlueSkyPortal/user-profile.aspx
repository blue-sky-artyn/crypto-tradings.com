<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user-profile.aspx.cs" Inherits="dashboard_login" EnableEventValidation="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>

    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <%--<link rel="stylesheet/less" type="text/css" href="css/style.less" />--%>
    <script src="//cdnjs.cloudflare.com/ajax/libs/less.js/3.9.0/less.min.js"></script>
    <link rel="stylesheet" href="css/style.css" />
<<<<<<< HEAD
    <link rel="stylesheet" href="css/responsive1.css" />
=======
    <link rel="stylesheet" href="css/responsive.css" />
>>>>>>> fce48b032b58934f57024836247af066407eecaf
    <style>
        @font-face {
            font-family: 'Source Sans Pro';
            font-style: normal;
            font-weight: 200;
            src: local('Source Sans Pro ExtraLight'), local('SourceSansPro-ExtraLight'), url(https://fonts.gstatic.com/s/sourcesanspro/v13/6xKydSBYKcSV-LCoeQqfX1RYOo3i94_wlxdr.ttf) format('truetype');
        }

        @font-face {
            font-family: 'Source Sans Pro';
            font-style: normal;
            font-weight: 300;
            src: local('Source Sans Pro Light'), local('SourceSansPro-Light'), url(https://fonts.gstatic.com/s/sourcesanspro/v13/6xKydSBYKcSV-LCoeQqfX1RYOo3ik4zwlxdr.ttf) format('truetype');
        }

        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
            font-weight: 300;
        }

        html {
            min-height: 100%;
        }

        body {
            font-family: 'Source Sans Pro', sans-serif;
            color: white;
            font-weight: 300;
            min-height: 100vh;
        }

            body ::-webkit-input-placeholder {
                /* WebKit browsers */
                font-family: 'Source Sans Pro', sans-serif;
                color: white;
                font-weight: 300;
            }

            body :-moz-placeholder {
                /* Mozilla Firefox 4 to 18 */
                font-family: 'Source Sans Pro', sans-serif;
                color: white;
                opacity: 1;
                font-weight: 300;
            }

            body ::-moz-placeholder {
                /* Mozilla Firefox 19+ */
                font-family: 'Source Sans Pro', sans-serif;
                color: white;
                opacity: 1;
                font-weight: 300;
            }

            body :-ms-input-placeholder {
                /* Internet Explorer 10+ */
                font-family: 'Source Sans Pro', sans-serif;
                color: white;
                font-weight: 300;
            }

        .wrapper {
            background: #50a3a2;
            /*background: linear-gradient(to bottom right, #50a3a2 0%, #53e3a6 100%);*/
            background: linear-gradient(141deg, #050505 0%, #124c54 51%, #06648a 75%);
            transition: background 0.25s ease;
            -webkit-transition: background 0.25s ease;
            -moz-transition: background 0.25s ease;
            -ms-transition: background 0.25s ease;
            position: relative;
            top: 50%;
            left: 0;
            width: 100%;
            /*height: 400px;*/
            min-height: 100vh;
            /*margin-top: -200px;*/
            overflow: hidden;
        }

            .wrapper.form-success .container h1 {
                -webkit-transform: translateY(85px);
                transform: translateY(85px);
            }

        .container {
            position: relative;
            z-index: 2;
            /*max-width: 60%;*/
            /*margin: 0 25%;*/
            padding: 80px 10px;
            height: 100%;
            text-align: center;
        }

            .container h1 {
                font-size: 30px;
                transition-duration: 1s;
                transition-timing-function: ease-in-put;
                font-weight: bold;
                margin: 15px 0;
            }

        form {
            padding: 20px 0;
            position: relative;
            z-index: 2;
        }

            form .input-value {
                -webkit-appearance: none;
                -moz-appearance: none;
                appearance: none;
                outline: 0;
                border: 1px solid rgba(255, 255, 255, 0.4);
                background-color: rgba(255, 255, 255, 0.2);
                border-radius: 3px;
                padding: 10px 15px;
                display: block;
                text-align: center;
                font-size: 18px;
                color: white;
                transition-duration: 0.25s;
                font-weight: 300;
            }

                form .input-value:hover {
                    background-color: rgba(255, 255, 255, 0.4);
                }

                form .input-value:focus {
                    background-color: white;
                    width: 300px;
                    color: black;
                }

        .btnEnter {
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            outline: 0;
            background-color: white;
            border: 0;
            padding: 10px 15px;
            color: #53e3a6;
            border-radius: 3px;
<<<<<<< HEAD
            width: 12%;
            cursor: pointer;
            font-size: 15px;
=======
            width: 250px;
            cursor: pointer;
            font-size: 18px;
>>>>>>> fce48b032b58934f57024836247af066407eecaf
            transition-duration: 0.25s;
        }

            .btnEnter:hover {
                background-color: #f5f7f9;
            }

        .bg-bubbles {
            position: absolute;
            top: 0;
            left: 0;
            width: 97%;
            height: 100%;
            z-index: 1;
        }

            .bg-bubbles li {
                position: absolute;
                list-style: none;
                display: block;
                width: 40px;
                height: 40px;
                background-color: rgba(255, 255, 255, 0.15);
                bottom: -160px;
                -webkit-animation: square 25s infinite;
                animation: square 25s infinite;
                transition-timing-function: linear;
            }

                .bg-bubbles li:nth-child(1) {
                    left: 10%;
                }

                .bg-bubbles li:nth-child(2) {
                    left: 20%;
                    width: 80px;
                    height: 80px;
                    -webkit-animation-delay: 2s;
                    animation-delay: 2s;
                    -webkit-animation-duration: 17s;
                    animation-duration: 17s;
                }

                .bg-bubbles li:nth-child(3) {
                    left: 25%;
                    -webkit-animation-delay: 4s;
                    animation-delay: 4s;
                }

                .bg-bubbles li:nth-child(4) {
                    left: 40%;
                    width: 60px;
                    height: 60px;
                    -webkit-animation-duration: 22s;
                    animation-duration: 22s;
                    background-color: rgba(255, 255, 255, 0.25);
                }

                .bg-bubbles li:nth-child(5) {
                    left: 70%;
                }

                .bg-bubbles li:nth-child(6) {
                    left: 80%;
                    width: 120px;
                    height: 120px;
                    -webkit-animation-delay: 3s;
                    animation-delay: 3s;
                    background-color: rgba(255, 255, 255, 0.2);
                }

                .bg-bubbles li:nth-child(7) {
                    left: 32%;
                    width: 160px;
                    height: 160px;
                    -webkit-animation-delay: 7s;
                    animation-delay: 7s;
                }

                .bg-bubbles li:nth-child(8) {
                    left: 55%;
                    width: 20px;
                    height: 20px;
                    -webkit-animation-delay: 15s;
                    animation-delay: 15s;
                    -webkit-animation-duration: 40s;
                    animation-duration: 40s;
                }

                .bg-bubbles li:nth-child(9) {
                    left: 25%;
                    width: 10px;
                    height: 10px;
                    -webkit-animation-delay: 2s;
                    animation-delay: 2s;
                    -webkit-animation-duration: 40s;
                    animation-duration: 40s;
                    background-color: rgba(255, 255, 255, 0.3);
                }

                .bg-bubbles li:nth-child(10) {
                    left: 90%;
                    width: 160px;
                    height: 160px;
                    -webkit-animation-delay: 11s;
                    animation-delay: 11s;
                }
        /* plans */
        .card-body {
            color: black;
        }
        /* membership card */
        .card-row, .bottom input {
            width: 100%;
        }

        .card-contant {
            margin: 0 80%;
        }

        .title-card, .desc-card {
            color: black;
        }

        .avatar img {
            width: 100%;
        }

        .avatar {
            overflow: hidden;
            width: 85%;
<<<<<<< HEAD
=======
            border-radius: 50%;
>>>>>>> fce48b032b58934f57024836247af066407eecaf
            margin: 15px 8%;
            max-height: 250px;
        }

        .desc-card p {
            font-size: 14px;
        }

        .info {
            text-align: center;
            position: relative;
            top: -30px;
            background: white;
        }
        /* e-transfer */
        .consent {
            float: left;
        }

        .consent-input {
            width: 30%;
            margin: 0 5px;
        }

        .e-transfer-text {
            font-size: 12px;
            padding: 0 5%;
        }

        .e-transfer-detail {
            font-weight: bold;
            font-size: 20px;
        }

        .lbl-error {
            color: red;
            font-weight: bold;
            letter-spacing: 1px;
            border: 1px solid;
            margin-top: 5px;
            width: 58%;
            background: #ffffff96;
        }

        /* General Farsi */
        .farsi-title {
            font-family: tahoma;
            direction: rtl
        }

        .farsi-text {
            font-family: tahoma;
            direction: rtl
        }

        .farsi-btn {
            font-family: tahoma;
        }

        .fa-style {
            text-align: right;
        }

        .en-style {
            text-align: left;
        }

        @-webkit-keyframes square {
            0% {
                -webkit-transform: translateY(0);
                transform: translateY(0);
            }

            100% {
                -webkit-transform: translateY(-700px) rotate(600deg);
                transform: translateY(-700px) rotate(600deg);
            }
        }

        @keyframes square {
            0% {
                -webkit-transform: translateY(0);
                transform: translateY(0);
            }

            100% {
                -webkit-transform: translateY(-700px) rotate(600deg);
                transform: translateY(-700px) rotate(600deg);
            }
        }
    </style>

</head>
<body>
    <form id="form1" runat="server" style="min-height: 100vh; padding: 0; margin: 0;">
        <div class="wrapper">
            <div class="container">
                <h1>User Profile:</h1>

<<<<<<< HEAD
                <div class="form">
                    <div class="en-style  row">
                        <div class="col-lg-12">
                            
                            <div class="row">
                                
                                    <div class="form-group col-md-12">


                                  

                                 
                                </div>

                            </div>
                            
                            <div class="row">
                                <div class="col-lg-9">
                                         <div class="form-row">
                                <div class="form-group col-md-4">
                                    <label for="txtName">Full Name</label>
                                    <asp:TextBox ID="txtFamily" runat="server" class="input-value form-control" placeholder="Family" AutoCompleteType="None"></asp:TextBox>
                                </div>
                            </div>


                            <div class="form-row">
                                <div class="col-md-4">
                                    <label class="sr-only" for="txtEmail">Email</label>
                                    <div class="input-group mb-2">
                                        <div class="input-group-prepend">
                                            <div class="input-group-text">@</div>
                                        </div>

                                        

 <input type="email" name="name" value="" id="Txt_email" runat="server" class="input-value form-control" placeholder="Email" autocompletetype="None"
                                                    pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$" />

                                        </div>
  
                                           
                                </div>
                            </div>
                           
                            <div class="form-group">
                                <label for="txtAddr">wallet </label>
                                <asp:TextBox ID="txtAddr" runat="server" class="input-value form-control" placeholder="Please enter wallet address" AutoCompleteType="None"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <div class="form-check">
                                    <p id="txtError" runat="server" class="error-msg mfp-s-error" visible="false" nbforecolor="#FF3300">Please enter required Values...</p>
                                </div>
                            </div>
                                </div>

                                <div class="col-lg-3">
                                      <div class="form-row">
                            
                             
                                <div class="col-lg-12 col-sm-12">
=======











                <div class="form">
                    <div class="en-style  row">
                        <div class="col-lg-12">

                            <div class="form-row">
                                <div class="form-group col-md-4">


                                    <h2>Your Plan</h2>

                                    <div id="planHtml" runat="server" class="card-deck">
                                        <div id="1" title="Plan 1" class="card">
                                            <div class="card-body">
                                                <h5 class="card-title">Card title</h5>
                                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                                            </div>
                                            <div class="card-footer">
                                                <small class="text-muted">Last updated 3 mins ago</small>
                                            </div>
                                        </div>
                                   
                                    </div>
                                </div>


                                <div class="form-group col-md-5">
                                </div>
                                <div class="col-lg-3 col-sm-6">
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                                    <h2>Membership card</h2>
                                    <div class="card hovercard">
                                        <div class="cardheader">
                                        </div>
                                        <div class="avatar">
<<<<<<< HEAD
                                            <img id="userPicHtml" runat="server" alt="Ticc member" src="~/images/logos/logo.png" />
                                        </div>
                                        <div class="info">
                                            <div class="title">
                                                <h3 id="memberIdHtml" runat="server" class="title-card">
                                                    Referal Code: <asp:Literal ID="Literal1_referl1" runat="server"></asp:Literal>
                                                </h3>
                                            </div>
                                            <div class="desc-card">
                                                <p id="userNameHtml" runat="server">
                                                    <asp:Literal ID="Literal1_name" runat="server"></asp:Literal>
                                                </p>
                                                <p id="userPlanHtml" runat="server">
                                                    <asp:Literal ID="Literal2_referal" runat="server"></asp:Literal>
                                                </p>
                                                <p id="userEmailHtml" runat="server">
                                                    <asp:Literal ID="Literal3_email" runat="server"></asp:Literal>
                                                </p>
=======
                                            <img id="userPicHtml" runat="server" alt="Ticc member" src="~/images/avatar.png" />
                                        </div>
                                        <div class="info">
                                            <div class="title">
                                                <h3 id="memberIdHtml" runat="server" class="title-card">CT-1234</h3>
                                            </div>
                                            <div class="desc-card">
                                                <p id="userNameHtml" runat="server">Farhad Taheri</p>
                                                <p id="userPlanHtml" runat="server">Member of Golden Plan</p>
                                                <p id="userEmailHtml" runat="server">Email:admin1@admin.com</p>
>>>>>>> fce48b032b58934f57024836247af066407eecaf

                                            </div>

                                        </div>
                                        <div class="bottom">
<<<<<<< HEAD
                                            
=======
                                            <asp:FileUpload ID="fuGallery" runat="server" CssClass="btnEnter" ToolTip="profile picture uploud" />
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                                            <p id="lblError" runat="server"></p>

                                        </div>
                                    </div>

                                </div>



                            </div>
<<<<<<< HEAD
                                </div>
                                
                            </div>



                          <div class="row" style="margin-top: 1.5rem;">
                        <div class="col-lg-12">
                            <div class="fa-style form-group">
                                <asp:Button ID="Button1" runat="server" CssClass="btnEnter" ClientIDMode="Static" Text="Logout"  style="padding: 0 0;" OnClick="Button1_Click"/>
                                <input type="button" name="name" class="btnEnter" value="Report" onclick="window.location.href = '/Menu_user3.aspx'" style="padding: 0 0;"/>
                                <input type="button" name="name" class="btnEnter" value="Reurn" onclick="window.location.href = '/default.aspx'" style="padding: 0 0;"/>
                                <input type="button" name="name" class="btnEnter" value="Change Password" onclick="window.location.href = '/Changepass.aspx'" style="padding: 0 0;"/>
                                <asp:Button ID="btnEnter" runat="server" CssClass="btnEnter" ClientIDMode="Static" Text="Update Wallet&Email " OnClick="btnEnter_Click" style="padding: 0 0;"/>
                                
                            </div>
                        
                        </div>
                          </div>
                       
=======
                            <div class="form-row">
                                <div class="form-group col-md-2">
                                    <label class="mr-sm-2" for="ddlSex">Title</label>
                                    <asp:DropDownList ID="ddlSex" runat="server" CssClass="custom-select mr-sm-2">
                                        <asp:ListItem Text="Optional..." Value="Optional..." Selected="True" />
                                        <asp:ListItem Text="Male" Value="Male" />
                                        <asp:ListItem Text="Female" Value="Female" />
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group col-md-4">
                                    <label for="txtName">Name</label>
                                    <asp:TextBox ID="txtName" runat="server" class="input-value form-control" placeholder="Name" AutoCompleteType="None"></asp:TextBox>
                                </div>
                                <div class="form-group col-md-4">
                                    <label for="txtFamily">Family</label>
                                    <asp:TextBox ID="txtFamily" runat="server" class="input-value form-control" placeholder="Family" AutoCompleteType="None"></asp:TextBox>

                                </div>
                            </div>


                            <div class="form-row">
                                <div class="col-md-4">
                                    <label class="sr-only" for="txtEmail">Email</label>
                                    <div class="input-group mb-2">
                                        <div class="input-group-prepend">
                                            <div class="input-group-text">@</div>
                                        </div>
                                        <input type="email" name="name" value="" ID="txtEmail" runat="server" class="input-value form-control" placeholder="Email" AutoCompleteType="None"
                                            pattern="^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$" required />
                                        <%--<asp:TextBox ID="txtEmail" runat="server" class="input-value form-control" placeholder="Email" AutoCompleteType="None"></asp:TextBox>--%>

                                    </div>
                                </div>
                                <div class="form-group col-md-2">
                                    <label class="sr-only" for="txtTel">Tel</label>
                                    <div class="input-group mb-2">
                                        <div class="input-group-prepend">
                                            <div class="input-group-text">T</div>
                                        </div>
                                        <asp:TextBox ID="txtTel" runat="server" class="input-value form-control" placeholder="4161111111" AutoCompleteType="None"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                            <div class="form-group col-md-12">


                                <p>The date of registration is <span id="userStartDateHtml" runat="server" class="e-transfer-detail">2020/01/05 </span> and your membership will expire in <span id="userEndDateHtml" runat="server" class="e-transfer-detail">2020/01/05 </span>.</p>


                            </div>
                            <div class="form-group col-md-4">
                                <label for="txtPass1">Password</label>
                                <asp:TextBox ID="txtPass1" runat="server" class="input-value form-control" placeholder="Enter Password" AutoCompleteType="None" TextMode="Password"></asp:TextBox>
                                <asp:TextBox ID="txtPass2" runat="server" class="input-value form-control" placeholder="Renter Password" AutoCompleteType="None" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtAddr">Address</label>
                                <asp:TextBox ID="txtAddr" runat="server" class="input-value form-control" placeholder="1234 Main St" AutoCompleteType="None"></asp:TextBox>
                            </div>

                            <%--<div class="form-group">
                                    <label for="txtDetails">Details</label>
                                    <asp:TextBox ID="txtDetails" runat="server" class="input-value form-control" placeholder="Enter any extera details" TextMode="MultiLine" AutoCompleteType="None"></asp:TextBox>
                                </div>--%>


                            <div class="form-group">
                                <div class="form-check">
                                    <p id="txtError" runat="server" class="error-msg mfp-s-error" visible="false" nbforecolor="#FF3300">Please enter required Values...</p>
                                </div>
                            </div>
                            <div class="fa-style form-group">
                                <input type="button" name="name" class="btnEnter" value="Reurn" onclick="window.location.href = '/default.aspx'" />
                                <asp:Button ID="btnEnter" runat="server" CssClass="btnEnter" ClientIDMode="Static" Text="Update" OnClick="btnEnter_Click" />
                                
                            </div>
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                        </div>
                    </div>
                </div>
            </div>


            <ul class="bg-bubbles">
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
            </ul>
        </div>
    </form>
    <script>
        $("#login-button").click(function (event) {
            event.preventDefault();

            $('form').fadeOut(500);
            $('.wrapper').addClass('form-success');
        });
    </script>

    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.bundle.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/waypoints.min.js"></script>
    <script src="js/jquery.counterup.min.js"></script>
    <script src="js/waypoints.min.js"></script>
    <script src="js/jquery.counterup.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/swiper.min.js"></script>
    <script src="js/jquery.magnific-popup.min.js"></script>
    <script src="js/jquery.easing.min.js"></script>
    <script src="js/theme.js"></script>
</body>
</html>
