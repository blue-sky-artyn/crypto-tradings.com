<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Rep_priceplan.aspx.cs" Inherits="admin_Rep_priceplan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <div class="content">
                
                <div class="page-header">
                    <div class="icon">
                        <span class="ico-pen-2"></span>
                    </div>
                    <h1>Plan-orinted Report <small>METRO STYLE ADMIN PANEL</small></h1>
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

    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_cash" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id_cash" HeaderText="Id_cash" InsertVisible="False" ReadOnly="True" SortExpression="Id_cash" />
            <asp:BoundField DataField="Id_customer" HeaderText="Id_customer" SortExpression="Id_customer" />
            <asp:BoundField DataField="Price_variz" HeaderText="Price_variz" SortExpression="Price_variz" />
            <asp:BoundField DataField="Price_bardasht" HeaderText="Price_bardasht" SortExpression="Price_bardasht" />
            <asp:BoundField DataField="Date_cash" HeaderText="Date_cash" SortExpression="Date_cash" />
            <asp:BoundField DataField="Valet_variz" HeaderText="Valet_variz" SortExpression="Valet_variz" />
            <asp:BoundField DataField="Valet_bardash" HeaderText="Valet_bardash" SortExpression="Valet_bardash" />
            <asp:BoundField DataField="statuse_cash" HeaderText="statuse_cash" SortExpression="statuse_cash" />
            <asp:BoundField DataField="Desc_cash" HeaderText="Desc_cash" SortExpression="Desc_cash" />
            <asp:BoundField DataField="Desc_cash1" HeaderText="Desc_cash1" SortExpression="Desc_cash1" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\m1;Initial Catalog=Crypto;User ID=sa;Password=111" ProviderName="System.Data.SqlClient" SelectCommand="search_cash_plan1" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="Label1" Name="date" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    </div>








                            </div>



                              <div class="data-fluid">


                                  <h4> Withdrawal request report plan2</h4>




                                  <div class="table-responsive">

<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" DataKeyNames="Id_cash">
    <Columns>
        <asp:BoundField DataField="Id_cash" HeaderText="Id_cash" InsertVisible="False" ReadOnly="True" SortExpression="Id_cash" />
        <asp:BoundField DataField="Price_variz" HeaderText="Price_variz" SortExpression="Price_variz" />
        <asp:BoundField DataField="Date_cash" HeaderText="Date_cash" SortExpression="Date_cash" />
        <asp:BoundField DataField="Valet_variz" HeaderText="Valet_variz" SortExpression="Valet_variz" />
        <asp:BoundField DataField="Desc_cash" HeaderText="Desc_cash" SortExpression="Desc_cash" />
        <asp:BoundField DataField="Desc_cash1" HeaderText="Desc_cash1" SortExpression="Desc_cash1" />
    </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="search_cash_plan2" ProviderName="System.Data.SqlClient" SelectCommandType="StoredProcedure">
        <SelectParameters>
         
            <asp:ControlParameter ControlID="Label1" Name="date" PropertyName="Text" Type="String" />
         
        </SelectParameters>
    </asp:SqlDataSource>
    </div>








                                  </div>




                              <div class="data-fluid">


                                  <h4> Withdrawal request report plan3</h4>



                                  <div class="table-responsive">

<asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" DataKeyNames="Id_cash">
    <Columns>
        <asp:BoundField DataField="Id_cash" HeaderText="Id_cash" InsertVisible="False" ReadOnly="True" SortExpression="Id_cash" />
        <asp:BoundField DataField="Id_customer" HeaderText="Id_customer" SortExpression="Id_customer" />
        <asp:BoundField DataField="Price_variz" HeaderText="Price_variz" SortExpression="Price_variz" />
        <asp:BoundField DataField="Price_bardasht" HeaderText="Price_bardasht" SortExpression="Price_bardasht" />
        <asp:BoundField DataField="Date_cash" HeaderText="Date_cash" SortExpression="Date_cash" />
        <asp:BoundField DataField="Valet_variz" HeaderText="Valet_variz" SortExpression="Valet_variz" />
        <asp:BoundField DataField="Valet_bardash" HeaderText="Valet_bardash" SortExpression="Valet_bardash" />
        <asp:BoundField DataField="statuse_cash" HeaderText="statuse_cash" SortExpression="statuse_cash" />
        <asp:BoundField DataField="Desc_cash" HeaderText="Desc_cash" SortExpression="Desc_cash" />
        <asp:BoundField DataField="Desc_cash1" HeaderText="Desc_cash1" SortExpression="Desc_cash1" />
    </Columns>
    </asp:GridView>
                                      <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="Data Source=.\m1;Initial Catalog=Crypto;User ID=sa;Password=111" ProviderName="System.Data.SqlClient" SelectCommand="search_cash_plan3" SelectCommandType="StoredProcedure">
                                          <SelectParameters>
                                              <asp:ControlParameter ControlID="Label1" Name="date" PropertyName="Text" Type="String" />
                                          </SelectParameters>
                                      </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="search_cash_plan3" ProviderName="System.Data.SqlClient" SelectCommandType="StoredProcedure">
        <SelectParameters>
         
            <asp:ControlParameter ControlID="Label1" Name="date" PropertyName="Text" Type="String" />
         
        </SelectParameters>
    </asp:SqlDataSource>
    </div>









                                  </div>







 <div class="data-fluid">


                                  <h4> Withdrawal request report plan4</h4>





     <div class="table-responsive">

         <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_cash" DataSourceID="SqlDataSource4">
             <Columns>
                 <asp:BoundField DataField="Id_cash" HeaderText="Id_cash" InsertVisible="False" ReadOnly="True" SortExpression="Id_cash" />
                 <asp:BoundField DataField="Id_customer" HeaderText="Id_customer" SortExpression="Id_customer" />
                 <asp:BoundField DataField="Price_variz" HeaderText="Price_variz" SortExpression="Price_variz" />
                 <asp:BoundField DataField="Price_bardasht" HeaderText="Price_bardasht" SortExpression="Price_bardasht" />
                 <asp:BoundField DataField="Date_cash" HeaderText="Date_cash" SortExpression="Date_cash" />
                 <asp:BoundField DataField="Valet_variz" HeaderText="Valet_variz" SortExpression="Valet_variz" />
                 <asp:BoundField DataField="Valet_bardash" HeaderText="Valet_bardash" SortExpression="Valet_bardash" />
                 <asp:BoundField DataField="statuse_cash" HeaderText="statuse_cash" SortExpression="statuse_cash" />
                 <asp:BoundField DataField="Desc_cash" HeaderText="Desc_cash" SortExpression="Desc_cash" />
                 <asp:BoundField DataField="Desc_cash1" HeaderText="Desc_cash1" SortExpression="Desc_cash1" />
             </Columns>
         </asp:GridView>
         <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="Data Source=.\m1;Initial Catalog=Crypto;User ID=sa;Password=111" ProviderName="System.Data.SqlClient" SelectCommand="search_cash_plan4" SelectCommandType="StoredProcedure">
             <SelectParameters>
                 <asp:ControlParameter ControlID="Label1" Name="date" PropertyName="Text" Type="String" />
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

