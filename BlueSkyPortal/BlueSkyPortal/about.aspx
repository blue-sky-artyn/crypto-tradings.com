<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="admin_about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .portfolio-img {
            width: 100%;
        }
        .portfolio-para {
            padding:5px;
        }
        .icon-wrapper-portfolio {
            position: relative;
            cursor: pointer;
            display: block;
            z-index: 1;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
		<div class="container text-center">
			<h1>about<%--<span class="m_1">Some information and details about us.</span>--%></h1>
		</div>
	</div>

     <div id="overviews" class="section wb">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="message-box">
                        <h4>Manager and cofounder</h4>
                        <h2>Arash Farshid - Sam Nazemi</h2>
                        <p id="ownerWordHtml" runat="server" class="lead"></p>

                        <p id="coDetHtml" runat="server">Company word</p>

                        
                    </div><!-- end messagebox -->
                </div><!-- end col -->
				
				<div class="col-md-6">
                    <div class="post-media wow fadeIn">
                        <img src="images/top1.jpg" alt="bondelectric company" class="img-responsive img-rounded">
                    </div><!-- end media -->
                </div><!-- end col -->
            </div><!-- end row -->

            <hr class="invis"> 

            <div id="portfolioHtml" runat="server">   
            <div class="row"> 
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <div class="icon-wrapper-portfolio wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s">
                        <img class="portfolio-img" src="images/portfolio/4.jpg" alt="" />
                        <h3>Unlimited Bandwidth</h3>
                        <p class="portfolio-para">Our Landigoo responsive site template elements 100% compatible with all mobile devices and modern browsers! <small class="readmore"><a href="#">Read more</a></small></p>
                    </div><!-- end icon-wrapper -->
                </div><!-- end col -->

                <div class="col-md-4 col-sm-6 col-xs-12">
                    <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.6s">
                        <i class="flaticon-cloud-computing-1 global-radius effect-1 alignleft"></i>
                        <h3>Unlimited Traffic</h3>
                        <p>When you need anything about for Landigoo template, just drop an email or leave a feedback from TF!<small class="readmore"><a href="#">Read more</a></small></p>
                    </div><!-- end icon-wrapper -->
                </div><!-- end col -->

                <div class="col-md-4 col-sm-6 col-xs-12">
                    <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.4s">
                        <i class="flaticon-world-wide-web global-radius effect-1 alignleft"></i>
                        <h3>1 Domain Free</h3>
                        <p>We offer pixel perfect icons, graphic sources for high-resolution devices! Landigoo compatible retina display! <small class="readmore"><a href="#">Read more</a></small></p>
                    </div><!-- end icon-wrapper -->
                </div><!-- end col -->
            </div><!-- end row -->

            <hr class="hr3"> 

            <div class="row"> 
                <div class="col-md-4 col-sm-6 col-xs-12">
                    <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s">
                        <i class="flaticon-cup global-radius effect-1 alignleft"></i>
                        <h3>Awards Winner Support</h3>
                        <p>Our Landigoo responsive site template elements 100% compatible with all mobile devices and modern browsers! <small class="readmore"><a href="#">Read more</a></small></p>
                    </div><!-- end icon-wrapper -->
                </div><!-- end col -->

                <div class="col-md-4 col-sm-6 col-xs-12">
                    <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.4s">
                        <i class="flaticon-cer-file-format global-radius effect-1 alignleft"></i>
                        <h3>Free SSL Certifica</h3>
                        <p>We offer pixel perfect icons, graphic sources for high-resolution devices! Landigoo compatible retina display! <small class="readmore"><a href="#">Read more</a></small></p>
                    </div><!-- end icon-wrapper -->
                </div><!-- end col -->

                <div class="col-md-4 col-sm-6 col-xs-12">
                    <div class="icon-wrapper wow fadeIn" data-wow-duration="1s" data-wow-delay="0.6s">
                        <i class="flaticon-locked global-radius effect-1 alignleft"></i>
                        <h3>High Security</h3>
                        <p>When you need anything about for Landigoo template, just drop an email or leave a feedback from TF!<small class="readmore"><a href="#">Read more</a></small></p>
                    </div><!-- end icon-wrapper -->
                </div><!-- end col -->
            </div><!-- end row -->
            </div>
        </div><!-- end container -->
    </div><!-- end section -->

</asp:Content>

