<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="admin_news" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>Recent News<%--<span class="m_1">Lorem Ipsum dolroin gravida nibh vel velit.</span>--%></h1>
        </div>
    </div>

    <div id="overviews" class="section wb">
        <div class="container">
            <div class="section-title row text-center">
                <div class="col-md-12">
                    <h3>NEWS</h3>
                    <p class="lead">Be updated and read latest news</p>
                </div>
                <div class="col-md-12">
                    <div class="list-domain">
                        <ul id="newsGrpHtml" runat="server">
                        </ul>
                    </div>
                </div>
            </div>
            <!-- end title -->
        </div>
        <!-- end container -->
    </div>
    <!-- end section -->


    <!-- news -->

    <div id="hosting" class="section wb" style="background: rgb(248, 248, 248)">
        <div id="newsDetHtml" runat="server" class="container">
            <div class="row dev-list text-center">
                <div class="col-lg-4 col-md-4 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s">
                    <div class="widget clearfix">
                        <img src="images/uploads/hosting_01.jpg" alt="" class="img-responsive">
                        <div class="widget-title">
                            <h3>Shared Hosting</h3>
                            <small>Starting from $40/month</small>
                        </div>
                        <!-- end title -->
                        <p>Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, true dont miss this one!</p>

                        <hr>

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Order Now</a>

                    </div>
                    <!--widget -->
                </div>
                <!-- end col -->

                <div class="col-lg-4 col-md-4 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.4s">
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

                <div class="col-lg-4 col-md-4 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.6s">
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

