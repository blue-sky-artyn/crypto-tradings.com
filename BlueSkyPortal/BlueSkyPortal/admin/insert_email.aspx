<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="insert_email.aspx.cs" Inherits="admin_insert_email" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="Label1" runat="server" Text="sub_emailregister"></asp:Label>
    <asp:TextBox ID="txt_subregister" runat="server"></asp:TextBox>

    <br />

     <asp:Label ID="Label2" runat="server" Text="body_emailregister"></asp:Label>
    <asp:TextBox ID="txt_bodyregister" runat="server"></asp:TextBox>

    <br />



 <asp:Label ID="Label3" runat="server" Text="sub_emailpayment"></asp:Label>
    <asp:TextBox ID="txt_subprice" runat="server"></asp:TextBox>

    <br />



 <asp:Label ID="Label4" runat="server" Text="body_emailpayment"></asp:Label>
    <asp:TextBox ID="txt_bodyprice" runat="server"></asp:TextBox>

    <br />


    <asp:Label ID="Label5" runat="server" Text="valetLottery"></asp:Label>
    <asp:TextBox ID="txt_Lottery" runat="server"></asp:TextBox>

    <br />
    <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />












</asp:Content>

