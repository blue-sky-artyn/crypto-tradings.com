<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Rep_user.aspx.cs" Inherits="Rep_user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>Investor request</h1>
        </div>
    </div>







    <div id="testimonial-box" class="section wb">
        <div id="faqHtml" runat="server" class="container">
            <div class="row">
                <div class="col-md-12 col-sm-6 col-xs-12" style="padding: 5%;">
                    <p>Investment
                        <strong><asp:Label ID="mojodi" runat="server" Text="stock"></asp:Label></strong>, Start date of investment is

     <strong><asp:Label ID="date1" runat="server" Text="stock"></asp:Label></strong>
                         , the loan amount is 
                        <strong><asp:Label ID="vam" runat="server" Text="stock"></asp:Label></strong>
                        , and now you can send a request to withdraw,
     <strong><asp:Label ID="ghabelbardasht" runat="server" Text="stock"></asp:Label></strong>
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                    .</p>
    
    </div>

      


    



      
                         <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                             <asp:Label ID="Label1_errore" runat="server" ForeColor="Red"></asp:Label>

    <asp:Button ID="Button1" runat="server" Text="Withdrawal request" OnClick="Button1_Click" CssClass="btn btn-light btn-radius btn-brd grd1 btn-block"/>

    <asp:Button ID="Button2" runat="server" Text="Apply for a loan" OnClick="Button2_Click" CssClass="btn btn-light btn-radius btn-brd grd1 btn-block"/>
</div>

                </div>
            </div>
        </div>



</asp:Content>







