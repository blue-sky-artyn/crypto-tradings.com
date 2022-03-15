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
                        <h4>Trade your curencies</h4>
                        <h2>Crypto Tradings</h2>
                        <p id="ownerWordHtml" runat="server" class="lead"></p>

                        <p id="coDetHtml" runat="server">Company is located in Canada and this compny support and invest in reaserching project and also in expanding its work in of designing EVC(Electrical vehicle charging) project. We also invest in digital currency markert ,plus, investing money in mass production of skyscraper. We are open for every golden oppurtunities to invest.</p>

                        
                    </div><!-- end messagebox -->
                </div><!-- end col -->
				
				<div class="col-md-6">
                    <div class="post-media wow fadeIn">
                        <img src="images/cer2.jpeg" alt="Crypto Trading company" class="img-responsive img-rounded">
                    </div><!-- end media -->
                </div><!-- end col -->
            </div><!-- end row -->

            <hr class="invis"> 
            <div class="row">
				<div class="col-md-12">
                    <div class="post-media wow fadeIn">
                        <img src="images/cer1.jpeg" alt="Crypto Trading company" class="img-responsive img-rounded">
                    </div>
                </div>
            </div>
            <hr class="invis"> 
        </div><!-- end container -->
    </div><!-- end section -->

</asp:Content>

