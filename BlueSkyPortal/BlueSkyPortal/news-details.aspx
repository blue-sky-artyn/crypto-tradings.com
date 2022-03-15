<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="news-details.aspx.cs" Inherits="news_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div id="overviews" class="section wb">
        <div class="container">
            
        
            <div class="row">
                <div class="col-md-6">
                    <div id="newsDetHtml" runat="server" class="message-box">
                        
                        <h2>       <asp:Literal ID="Literal1" runat="server"></asp:Literal></h2>
                        <p class="lead">              <asp:Literal ID="Literal2" runat="server"></asp:Literal>              </p>
                  
                    </div><!-- end messagebox -->
                </div><!-- end col -->
				
				<div class="col-md-6">
                    <div id="newsImgHtml" runat="server" class="post-media wow fadeIn">
                        <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                      
                    </div><!-- end media -->
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->

</asp:Content>

