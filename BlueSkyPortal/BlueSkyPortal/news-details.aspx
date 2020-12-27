<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="news-details.aspx.cs" Inherits="news_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div id="overviews" class="section wb">
        <div class="container">
            
        
            <div class="row">
                <div class="col-md-6">
                    <div id="newsDetHtml" runat="server" class="message-box">
                        <h4>2017 BEST WEB HOSTING COMPANY</h4>
                        <h2>Awards Winner Support Center</h2>
                        <p class="lead">Quisque eget nisl id nulla sagittis auctor quis id. Aliquam quis vehicula enim, non aliquam risus. Sed a tellus quis mi rhoncus dignissim.</p>
                        <p> Integer rutrum ligula eu dignissim laoreet. Pellentesque venenatis nibh sed tellus faucibus bibendum. Sed fermentum est vitae rhoncus molestie. Cum sociis natoque penatibus et magnis montes, nascetur ridiculus mus. Sed vitae rutrum neque. </p>
                    </div><!-- end messagebox -->
                </div><!-- end col -->
				
				<div class="col-md-6">
                    <div id="newsImgHtml" runat="server" class="post-media wow fadeIn">
                        <img src="images/uploads/about_02.jpg" alt="bondelectric company" class="img-responsive img-rounded">
                    </div><!-- end media -->
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->

</asp:Content>

