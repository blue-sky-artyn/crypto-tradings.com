<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Payment1.aspx.cs" Inherits="admin_service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .service-image {
            width: 100%;
            border-radius: 5px;
        }
        .input-elements {
            cursor: auto !important;
        }
        .description-input {
            margin-bottom: 30px;
        }
        .input-with-description {
            margin-bottom: 0px !important;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>Paymnet<%--<span class="m_1">Please read all available service which we offer you</span>--%></h1>
        </div>
    </div>


			    <div id="overviews" class="section wb">
        <div class="container">





            <div class="section-title row text-center">
                <div class="col-md-8 col-md-offset-2">
<<<<<<< HEAD
                    <h3>Crypto Trading holding</h3>
                    <p class="lead">Trusted wallet by Crypto Tradings,</p>
=======
                    <h3>General Trading holding</h3>
                    <p class="lead">Lorem Ipsum dolroin gravida nibh vel velit auctor aliquet. Aenean sollicitudin, lorem quis bibendum auctor, nisi elit consequat ipsum, nec sagittis sem!</p>
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                </div>
            </div><!-- end title -->
        
            <div class="row">
<<<<<<< HEAD
                <div class="col-md-12">
=======
                <div class="col-md-8">
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                    <div class="row">
                <div class="col-md-12">
                    <div class="contact_form">
                        <div id="message"></div>
                        <div class="row" >
                            <fieldset class="row-fluid">
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="planName">Plan Name:</label>
<<<<<<< HEAD
                                    <asp:TextBox name="Txt_nameplan" ID="Txt_nameplan"  runat="server" class="form-control input-elements" Enabled="False" 
                                        style=" margin-bottom: 30px !important;
                                            border: 1px solid #ebebeb !important;
                                            box-sizing: border-box !important;
                                            color: #bcbcbc !important;
                                            font-size: 16px !important;
                                            outline: 0 none !important;
                                            padding: 10px 25px !important;
                                            height: 34px !important;
                                            resize: none !important;
                                            box-shadow: none !important;
                                            width: 100% !important;"></asp:TextBox>
=======
                                    <asp:TextBox name="Txt_nameplan" ID="Txt_nameplan"  runat="server" class="form-control input-elements" Enabled="False"  ></asp:TextBox>
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                                  
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="Price">Investment Amount:</label>
<<<<<<< HEAD
                                    <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_Price" class="form-control input-elements" Enabled="False"
                                        style=" margin-bottom: 30px !important;
                                            border: 1px solid #ebebeb !important;
                                            box-sizing: border-box !important;
                                            color: #bcbcbc !important;
                                            font-size: 16px !important;
                                            outline: 0 none !important;
                                            padding: 10px 25px !important;
                                            height: 34px !important;
                                            resize: none !important;
                                            box-shadow: none !important;
                                            width: 100% !important;"></asp:TextBox>
=======
                                    <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_Price" class="form-control input-elements" Enabled="False"></asp:TextBox>
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                                
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="DateReg">Date:</label>
<<<<<<< HEAD
                                       <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_date" class="form-control input-elements" Enabled="False"
                                           style=" margin-bottom: 30px !important;
                                            border: 1px solid #ebebeb !important;
                                            box-sizing: border-box !important;
                                            color: #bcbcbc !important;
                                            font-size: 16px !important;
                                            outline: 0 none !important;
                                            padding: 10px 25px !important;
                                            height: 34px !important;
                                            resize: none !important;
                                            box-shadow: none !important;
                                            width: 100% !important;"></asp:TextBox>
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="ourWallet">Company Wallet Address:</label>
                                      <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_valetcompani" class="form-control input-elements" Enabled="False"
                                          style=" margin-bottom: 30px !important;
                                            border: 1px solid #ebebeb !important;
                                            box-sizing: border-box !important;
                                            color: #bcbcbc !important;
                                            font-size: 16px !important;
                                            outline: 0 none !important;
                                            padding: 10px 25px !important;
                                            height: 34px !important;
                                            resize: none !important;
                                            box-shadow: none !important;
                                            width: 100% !important;"></asp:TextBox>
=======
                                       <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_date" class="form-control input-elements" Enabled="False"></asp:TextBox>
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="ourWallet">Company Wallet Address:</label>
                                      <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_valetcompani" class="form-control input-elements" Enabled="False"></asp:TextBox>
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                                </div>

                                <div class="description-input col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                    <label for="yourWallet">Customer Wallet Address:</label>
<<<<<<< HEAD
      <asp:TextBox runat="server"  type="text" name="Txt_valetcustomer" id="Txt_valetcustomer" class="form-control input-elements"></asp:TextBox>    
                                    <small id="wal1" class="form-text text-muted">We'll never share your information with anyone else.</small>
=======
      <asp:TextBox runat="server"  type="text" name="Txt_valetcustomer" id="Txt_valetcustomer" class="form-control input-elements"></asp:TextBox>                                    <small id="wal1" class="form-text text-muted">We'll never share your email with anyone else.</small>
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                                </div>
                                <div class="description-input col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                    <label for="refNo">Refrence Number:</label>
                                         <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_tefrence" class="form-control input-elements"></asp:TextBox>
<<<<<<< HEAD
                                    <small id="ref1" class="form-text text-muted">We'll never share your information with anyone else.</small>
=======
                                    <small id="ref1" class="form-text text-muted">We'll never share your email with anyone else.</small>
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                                </div>
                                


                                
                                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
<<<<<<< HEAD
                                     <asp:Label ID="Label1" runat="server" Text="" style="color: red;"></asp:Label>
=======
>>>>>>> fce48b032b58934f57024836247af066407eecaf
                                    <p id="lblErrorHtml" runat="server" style="color: red;"></p>
                                    <asp:Button ID="btnEmail" runat="server" class="btn btn-light btn-radius btn-brd grd1 btn-block" Text="REGISTER" OnClick="btnEmail_Click" />
                                  
                                </div>


<<<<<<< HEAD
              <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center" style="padding: 10px 0;">
                            <asp:PlaceHolder ID="plBarCode" runat="server" />

            </div>
=======
              <center>
                            <asp:PlaceHolder ID="plBarCode" runat="server"  />

            </center>
>>>>>>> fce48b032b58934f57024836247af066407eecaf



                           
                            </fieldset>
                        </div>
                    </div>
                </div>
                <!-- end col -->
            </div>
            
                </div><!-- end col -->
				
				<div class="col-md-4">
                    <div class="post-media wow fadeIn">
                        <img src="images/qr.jpg" alt="" class="img-responsive img-rounded">
                    </div><!-- end media -->
                </div><!-- end col -->
            </div><!-- end row -->

            <hr class="invis"> 

            
          

<<<<<<< HEAD
=======
            <hr class="hr3"> 
>>>>>>> fce48b032b58934f57024836247af066407eecaf

        
        </div><!-- end container -->
    </div><!-- end section -->


</asp:Content>

