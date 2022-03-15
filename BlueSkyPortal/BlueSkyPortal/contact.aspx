<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="admin_contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .google-map {
            width: 100%;
            height: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>Contact<%--<span class="m_1">You can reach us...</span>--%></h1>
        </div>
    </div>

    <div id="support" class="section wb">
        <div class="container">
            <div class="section-title text-center">
                <h3 id="coNameHtml" runat="server">Crypto Tradings</h3>
                <p id="managerSpeachHtml" runat="server" class="lead">
                    Digital money
for a digital age
<br />
<small>Global, fast, and secure</small>
                </p>
            </div>
            <!-- end title -->
            <div class="row">
                <div class="col-md-12">
                    <div class="contact_form">
                        <div id="message"></div>
                        <div class="row">
                            <fieldset class="row-fluid">
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="text" name="first_name" id="first_name" runat="server" class="form-control" placeholder="First Name">
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="text" name="last_name" id="last_name" runat="server" class="form-control" placeholder="Last Name">
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="text" name="email" id="email_addressSend" runat="server" class="form-control" placeholder="Your Email">
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="text" name="phone" id="phone" runat="server" class="form-control" placeholder="Your Phone">
                                </div>

                                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                    <textarea class="form-control" name="comments" id="comments" runat="server" rows="6" placeholder="Enter your text"></textarea>
                                </div>
                                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                                    <p id="lblErrorHtml" runat="server" style="color: red;"></p>
                                    <asp:Button ID="btnEmail" runat="server" class="btn btn-light btn-radius btn-brd grd1 btn-block" Text="SEND US" OnClick="btnEmail_Click" />
                                </div>
                            </fieldset>
                        </div>
                    </div>
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>

    <!-- end section -->

    <div class="map-main-box">
        <div class="container">
            <div class="row">
                <div class="col-md-12 text-center">
                    <div class="map-btn"><i class="fa fa-map-pin" aria-hidden="true"></i></div>
                </div>
            </div>
        </div>
    </div>
    <div class="map-box">
        <div id="custom-places" class="small-map">            
            
        </div>

    </div>

</asp:Content>

