<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .gallery-row {
            clear: both;
            padding: 15px 0px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>Gallery<%--<span class="m_1">Freaquent qustions which have been asked before</span>--%></h1>
        </div>
    </div>
    <div id="hosting" class="section wb" style="background: rgb(248, 248, 248)">
        <div class="container">
            <div id="headerGalleryHtml" runat="server" class="section-title text-center">
                <h3>Hosting Packages</h3>
                <p class="lead">All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, true generator<br>
                    on the Internet. It uses a dictionary of over..</p>
            </div>
            <!-- end title -->

            <div id="gallertItemsHtml" runat="server" class="row dev-list text-center">
                <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s">
                    <div class="widget clearfix">
                        <img src="uploads/hosting_01.jpg" alt="" class="img-responsive">
                        <div class="widget-title">
                            <h3>Shared Hosting</h3>
                            <small>Starting from $40/month</small>
                        </div>
                        <!-- end title -->
                        <p>Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, true dont miss this one!</p>

                        <hr>

                        <div class="footer-social">
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Free Page Builder"><i class="flaticon-coding"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="WordPress Support"><i class="flaticon-wordpress-logo"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="1 Domain Free"><i class="flaticon-world-wide-web"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="50MB Bandwdith"><i class="flaticon-cloud-computing-1"></i></a>
                        </div>

                        <hr>

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Order Now</a>

                    </div>
                    <!--widget -->
                </div>
                <!-- end col -->

                <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.4s">
                    <div class="widget clearfix">
                        <img src="uploads/hosting_02.jpg" alt="" class="img-responsive">
                        <div class="widget-title">
                            <h3>Reseller Hosting</h3>
                            <small>Starting from $80/month</small>
                        </div>
                        <!-- end title -->
                        <p>Internet lorem Ipsum generators on the tend to repeat predefined chunks as necessary, finally its release!</p>

                        <hr>

                        <div class="footer-social">
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Free Page Builder"><i class="flaticon-coding"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="WordPress Support"><i class="flaticon-wordpress-logo"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="1 Domain Free"><i class="flaticon-world-wide-web"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="150MB Bandwdith"><i class="flaticon-cloud-computing-1"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Money Back Guarentee"><i class="flaticon-money"></i></a>
                        </div>
                        <hr>

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Order Now</a>

                    </div>
                    <!--widget -->
                </div>
                <!-- end col -->

                <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.6s">
                    <div class="widget clearfix">
                        <img src="uploads/hosting_03.jpg" alt="" class="img-responsive">
                        <div class="widget-title">
                            <h3>Dedicated Server</h3>
                            <small>Starting from $120/month</small>
                        </div>
                        <!-- end title -->
                        <p>Predefined internet lorem Ipsum generators on the tend to repeat chunks as necessary, true and more..</p>

                        <hr>

                        <div class="footer-social">
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Free Page Builder"><i class="flaticon-coding"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="WordPress Support"><i class="flaticon-wordpress-logo"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="1 Domain Free"><i class="flaticon-world-wide-web"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Unlimited Bandwdith"><i class="flaticon-cloud-computing-1"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Money Back Guarentee"><i class="flaticon-money"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="24/7 Support"><i class="flaticon-lifesaver-security-sportive-tool"></i></a>
                        </div>
                        <hr>

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Order Now</a>

                    </div>
                    <!--widget -->
                </div>
                <!-- end col -->


                <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.6s">
                    <div class="widget clearfix">
                        <img src="uploads/hosting_03.jpg" alt="" class="img-responsive">
                        <div class="widget-title">
                            <h3>Dedicated Server</h3>
                            <small>Starting from $120/month</small>
                        </div>
                        <!-- end title -->
                        <p>Predefined internet lorem Ipsum generators on the tend to repeat chunks as necessary, true and more..</p>

                        <hr>

                        <div class="footer-social">
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Free Page Builder"><i class="flaticon-coding"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="WordPress Support"><i class="flaticon-wordpress-logo"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="1 Domain Free"><i class="flaticon-world-wide-web"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Unlimited Bandwdith"><i class="flaticon-cloud-computing-1"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="Money Back Guarentee"><i class="flaticon-money"></i></a>
                            <a href="#" class="btn global-radius" data-toggle="tooltip" data-placement="top" title="24/7 Support"><i class="flaticon-lifesaver-security-sportive-tool"></i></a>
                        </div>
                        <hr>

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Order Now</a>

                    </div>
                    <!--widget -->
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end section -->

</asp:Content>

