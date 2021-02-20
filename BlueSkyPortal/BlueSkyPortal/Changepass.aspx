<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Changepass.aspx.cs" Inherits="Changepass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div style="margin-left:200px">
    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>

         <input type="email" name="name" value="" ID="txtEmail" runat="server" class="input-value form-control" placeholder="Email" AutoCompleteType="None"
                                            pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$"  />


    <br />
   
        <br />
       <input type="password" name="name" value="" ID="txt_old" runat="server" class="input-value form-control" placeholder="password" AutoCompleteType="None"
  pattern=".{1,}" title="Eight or more characters"/>


    <br />

    <asp:Label ID="Label3" runat="server" Text="newPassword"></asp:Label>
   <input type="password" name="name" value="" ID="txt_new1" runat="server" class="input-value form-control" placeholder="password"
  pattern=".{1,}" title="Eight or more characters"/>


    <br />

    <asp:Label ID="Label4" runat="server" Text="repeat"></asp:Label>
   <input type="password" name="name" value="" ID="txt_new2" runat="server" class="input-value form-control" placeholder="password"
  pattern=".{1,}" title="Eight or more characters"/>


    <br />
     <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    </div>



</asp:Content>

