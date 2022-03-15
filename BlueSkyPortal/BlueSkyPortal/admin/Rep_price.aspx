<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Rep_price.aspx.cs" Inherits="admin_Rep_price" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
            <div class="content">
                
                <div class="page-header">
                    <div class="icon">
                        <span class="ico-pen-2"></span>
                    </div>
                    <h1>Overview Report <small>METRO STYLE ADMIN PANEL</small></h1>
                </div>
                

                <div class="row-fluid">

                    <div class="span12">                

                        <div class="block">
                            <div class="head">                                
                                <ul class="buttons">             
                                    <li><a href="#" onClick="source('form_default'); return false;"><div class="icon"><span class="ico-info"></span></div></a></li>
                                </ul>                                  
                            </div>                                        
                            <div class="data-fluid">
                                <h4>Bank Report</h4>
                                <p><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
                                
                                

<div class="table-responsive">

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Price_variz" HeaderText="Price_variz" SortExpression="Price_variz" />
            <asp:BoundField DataField="Price_bardasht" HeaderText="Price_bardasht" SortExpression="Price_bardasht" />
            <asp:BoundField DataField="Date_cash" HeaderText="Date_cash" SortExpression="Date_cash" />
            <asp:BoundField DataField="Valet_variz" HeaderText="Valet_variz" SortExpression="Valet_variz" />
            <asp:BoundField DataField="statuse_cash" HeaderText="statuse_cash" SortExpression="statuse_cash" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="SELECT [Price_variz], [Price_bardasht], [Date_cash], [Valet_variz], [statuse_cash] FROM [Cash] WHERE ([Desc_cash1] = @Desc_cash1)">
        <SelectParameters>
         
            <asp:ControlParameter ControlID="Label1" Name="Desc_cash1" PropertyName="Text" />
         
        </SelectParameters>
    </asp:SqlDataSource>
    </div>








                            </div>



                              <div class="data-fluid">


                                  <h4> Withdrawal request report</h4>
<div class="table-responsive">

    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_darkhast" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id_darkhast" HeaderText="Id_darkhast" InsertVisible="False" ReadOnly="True" SortExpression="Id_darkhast" />
            <asp:BoundField DataField="Price_darkhast" HeaderText="Price_darkhast" SortExpression="Price_darkhast" />
            <asp:BoundField DataField="valet_darkhast" HeaderText="valet_darkhast" SortExpression="valet_darkhast" />
            <asp:BoundField DataField="vam" HeaderText="vam" SortExpression="vam" />
            <asp:BoundField DataField="sub_plan" HeaderText="sub_plan" SortExpression="sub_plan" />
            <asp:BoundField DataField="date_darkhast" HeaderText="date_darkhast" SortExpression="date_darkhast" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>





    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="SELECT [Id_darkhast], [Price_darkhast], [valet_darkhast], [vam], [sub_plan], [date_darkhast] FROM [darkhast] WHERE ([date_darkhast] = @date_darkhast)">
        <SelectParameters>
            <asp:ControlParameter ControlID="Label1" Name="date_darkhast" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>


    </div>


                                  </div>
                        </div>

                     



                    </div>

                

                </div>                
                     
            </div>
            







    

   
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("table").addClass("table");
            $("table").addClass("table-hover");

        });
    </script>




</asp:Content>

