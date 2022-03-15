<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="faq.aspx.cs" Inherits="faq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>FAQ<%--<span class="m_1">Freaquent qustions which have been asked before</span>--%></h1>
        </div>
    </div>

    <div id="testimonial-box" class="section wb">
        <div id="faqHtml" runat="server" class="container">
            <div class="row">
               
               
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
               




            </div>
        </div>
    </div>
    <!-- end section -->

</asp:Content>

