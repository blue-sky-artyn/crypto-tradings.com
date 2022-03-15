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
              

               
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
             
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end section -->





</asp:Content>

