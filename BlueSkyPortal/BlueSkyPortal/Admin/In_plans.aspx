<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage_admin.master" AutoEventWireup="true" CodeFile="In_plans.aspx.cs" Inherits="Admin_In_plans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="1">plan1</asp:ListItem>
        <asp:ListItem Value="2">Plan2</asp:ListItem>
        <asp:ListItem Value="1">Plan3</asp:ListItem>
        <asp:ListItem Value="4">Plan4</asp:ListItem>
    </asp:DropDownList>
<br />

    <asp:Label ID="Label1" runat="server" Text="نام پلن"></asp:Label>
    <asp:TextBox ID="Txt_nameplan" runat="server"></asp:TextBox>

    <br />

 <asp:Label ID="Label2" runat="server" Text="حداقل واریزی"></asp:Label>
    <asp:TextBox ID="Txt_min" runat="server"></asp:TextBox>

    <br />

 <asp:Label ID="Label3" runat="server" Text="حداکثر واریزی"></asp:Label>
    <asp:TextBox ID="Txt_max" runat="server"></asp:TextBox>

    <br />
     <asp:Label ID="Label4" runat="server" Text="طول دوره"></asp:Label>
    <asp:TextBox ID="Txt_period" runat="server"></asp:TextBox>

    <br />
     <asp:Label ID="Label5" runat="server" Text="در صد سود"></asp:Label>
    <asp:TextBox ID="Txt_dasad" runat="server"></asp:TextBox>

    <br />
     <asp:Label ID="Label6" runat="server" Text="میزان وام"></asp:Label>
    <asp:TextBox ID="Txt_vam" runat="server"></asp:TextBox>

    <br />
     <asp:Label ID="Label7" runat="server" Text="سود معرف این پلن"></asp:Label>
    <asp:TextBox ID="Txt_moaref" runat="server"></asp:TextBox>

    <br />
     <asp:Label ID="Label8" runat="server" Text="زمان برداشت سود"></asp:Label>
    <asp:TextBox ID="Txt_remove" runat="server"></asp:TextBox>

    <br />
      <asp:Label ID="Label9" runat="server" Text="آدرس ولت"></asp:Label>
    <asp:TextBox ID="Txt_valet" runat="server"></asp:TextBox>

    <br />
      <asp:Label ID="Label10" runat="server" Text="توضیحات پلن"></asp:Label>
    <asp:TextBox ID="Txt_descplan" runat="server"></asp:TextBox>

    <br />
    <asp:Button ID="Button1" runat="server" Text="ذخیره" OnClick="Button1_Click" Width="73px" />




  <!-- غیر فعال کردم پلن ها -->

    <p>----------------------------------------------</p>


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_subplan" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id_subplan" HeaderText="شماره" InsertVisible="False" ReadOnly="True" SortExpression="Id_subplan" />
            <asp:BoundField DataField="Sub_plan" HeaderText="نام پلن" SortExpression="Sub_plan" />
            <asp:BoundField DataField="Name_plan" HeaderText="پلن اصلی" SortExpression="Name_plan" />
            <asp:BoundField DataField="Min_price" HeaderText="حداقل واریزی" SortExpression="Min_price" />
            <asp:BoundField DataField="Max_price" HeaderText="حداکثر واریزی" SortExpression="Max_price" />
            <asp:BoundField DataField="Period" HeaderText="طول دوره" SortExpression="Period" />
            <asp:BoundField DataField="Darsad" HeaderText="در صد سود" SortExpression="Darsad" />
            <asp:BoundField DataField="Adress_valet" HeaderText="ادرس ولت" SortExpression="Adress_valet" />
            <asp:BoundField DataField="Statuse_subplan" HeaderText="وضعیت/فعال=1/غیرفعال=0" SortExpression="Statuse_subplan" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>




    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="SELECT [Id_subplan], [Sub_plan], [Name_plan], [Min_price], [Max_price], [Period], [Darsad], [Adress_valet], [Statuse_subplan] FROM [Sub_plans]"></asp:SqlDataSource>

    <br />
    <br />




</asp:Content>

