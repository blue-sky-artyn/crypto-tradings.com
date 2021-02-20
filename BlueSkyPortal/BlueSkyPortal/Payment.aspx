<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="admin_service" %>

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
                    <h3>General Trading holding</h3>
                    <p class="lead">Lorem Ipsum dolroin gravida nibh vel velit auctor aliquet. Aenean sollicitudin, lorem quis bibendum auctor, nisi elit consequat ipsum, nec sagittis sem!</p>
                </div>
            </div><!-- end title -->
        
            <div class="row">
                <div class="col-md-8">
                    <div class="row">
                <div class="col-md-12">
                    <div class="contact_form">
                        <div id="message"></div>
                        <div class="row" >
                            <fieldset class="row-fluid">
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="planName">Plan Name:</label>
                                    <asp:TextBox name="Txt_nameplan" ID="Txt_nameplan"  runat="server" class="form-control input-elements" Enabled="False"  ></asp:TextBox>
                                  
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="Price">Investment Amount:</label>
                                    <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_Price" class="form-control input-elements"></asp:TextBox>
                                
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="DateReg">Date:</label>
                                       <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_date" class="form-control input-elements" Enabled="False"></asp:TextBox>
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <label for="ourWallet">Company Wallet Address:</label>
                                      <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_valetcompani" class="form-control input-elements" Enabled="False"></asp:TextBox>
                                </div>

                                <div class="description-input col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                    <label for="yourWallet">Customer Wallet Address:</label>
      <asp:TextBox runat="server"  type="text" name="Txt_valetcustomer" id="Txt_valetcustomer" class="form-control input-elements"></asp:TextBox>                                    <small id="wal1" class="form-text text-muted">We'll never share your email with anyone else.</small>
                                </div>
                                <div class="description-input col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                    <label for="refNo">Refrence Number:</label>
                                         <asp:TextBox runat="server"  type="text" name="Txt_Price" id="Txt_tefrence" class="form-control input-elements"></asp:TextBox>
                                    <small id="ref1" class="form-text text-muted">We'll never share your email with anyone else.</small>
                                </div>
                                


                                
                                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                                    <p id="lblErrorHtml" runat="server" style="color: red;"></p>
                                    <asp:Button ID="btnEmail" runat="server" class="btn btn-light btn-radius btn-brd grd1 btn-block" Text="REGISTER" OnClick="btnEmail_Click" />
                                  
                                </div>


              <center>
                            <asp:PlaceHolder ID="plBarCode" runat="server"  />

            </center>



                           
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

            
          

            <hr class="hr3"> 

        
        </div><!-- end container -->
    </div><!-- end section -->


</asp:Content>

