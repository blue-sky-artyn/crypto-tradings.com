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
                <h3 id="coNameHtml" runat="server">BOND ELECTRIC contact mananger!</h3>
                <p id="managerSpeachHtml" runat="server" class="lead">
                    Let us give you more details about the special offer website you want us. Please fill out the form below.
                    <br>
                    We have million of website owners who happy to work with us!
                </p>
            </div>
            <!-- end title -->
            <div class="section-title text-center">
                <div id="contactDetailsHtml" runat="server" class="row">
                    <div class="col-md-4 col-sm-6 col-xs-12">
                        <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s" style="visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;">
                            <i class="fa fa-user global-radius effect-1 alignleft" aria-hidden="true"></i>
                            <h3>Manager:</h3>
                            <p>416-123-1234</p>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6 col-xs-12">
                        <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s" style="visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;">
                            <i class="fa fa-info global-radius effect-1 alignleft"></i>
                            <h3>Tel:</h3>
                            <p>416-123-1234</p>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6 col-xs-12">
                        <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s" style="visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;">
                            <i class="fa fa-hashtag global-radius effect-1 alignleft"></i>
                            <h3>Tel:</h3>
                            <p>416-123-1234</p>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6 col-xs-12">
                        <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s" style="visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;">
                            <i class="fa fa-fire global-radius effect-1 alignleft"></i>
                            <h3>Tel:</h3>
                            <p>416-123-1234</p>
                        </div>
                    </div>
                </div>
                <hr />
                <div id="userDetHtml" runat="server" class="row">
                    <div class="col-md-4 col-sm-6 col-xs-12">
                        <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s" style="visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;">
                            <i class="fa fa-user global-radius effect-1 alignleft" aria-hidden="true"></i>
                            <h3>Manager:</h3>
                            <p>416-123-1234</p>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6 col-xs-12">
                        <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s" style="visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;">
                            <i class="fa fa-info global-radius effect-1 alignleft"></i>
                            <h3>Tel:</h3>
                            <p>416-123-1234</p>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6 col-xs-12">
                        <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s" style="visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;">
                            <i class="fa fa-hashtag global-radius effect-1 alignleft"></i>
                            <h3>Tel:</h3>
                            <p>416-123-1234</p>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6 col-xs-12">
                        <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s" style="visibility: visible; animation-duration: 1s; animation-delay: 0.2s; animation-name: fadeIn;">
                            <i class="fa fa-fire global-radius effect-1 alignleft"></i>
                            <h3>Tel:</h3>
                            <p>416-123-1234</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="contact_form">
                        <div id="message"></div>
                        <form id="contactform" class="row" action="send-email.aspx" method="get">
                            <fieldset class="row-fluid">
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="text" name="first_name" id="first_name" class="form-control" placeholder="First Name">
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="text" name="last_name" id="last_name" class="form-control" placeholder="Last Name">
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="text" name="email" id="email_addressSend" class="form-control" placeholder="Your Email">
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="text" name="phone" id="phone" class="form-control" placeholder="Your Phone">
                                </div>

                                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                    <textarea class="form-control" name="comments" id="comments" rows="6" placeholder="Enter your text"></textarea>
                                </div>
                                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                                    <p id="lblErrorHtml" runat="server" style="color: red;"></p>
                                    <asp:Button ID="btnEmail" runat="server" class="btn btn-light btn-radius btn-brd grd1 btn-block" Text="SEND US" OnClick="btnEmail_Click" />
                                </div>
                            </fieldset>
                        </form>
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
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2876.572890733638!2d-79.42675288449536!3d43.86468057911472!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x882b2b076f38addd%3A0x748d1a6f52ac4da1!2s114%20Hillsview%20Dr%2C%20Richmond%20Hill%2C%20ON%20L4C%201T2!5e0!3m2!1sen!2sca!4v1604289507020!5m2!1sen!2sca" style="width: 100%;height: 400px;" frameborder="0" style="border:0;" allowfullscreen="" aria-hidden="false" tabindex="0" ></iframe>
        </div>

    </div>

</asp:Content>

