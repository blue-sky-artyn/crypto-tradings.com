<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage_admin.master" AutoEventWireup="true" CodeFile="Login_admin.aspx.cs" Inherits="Admin_Login_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
<asp:TextBox ID="Txt_user" runat="server"></asp:TextBox> <br />
<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
<asp:TextBox ID="Txt_pass" runat="server" TextMode="Password"></asp:TextBox> <br />

<asp:Button ID="Button1" runat="server" Text="Enter" Height="28px" Width="88px" OnClick="Button1_Click" ></asp:Button>





</asp:Content>

