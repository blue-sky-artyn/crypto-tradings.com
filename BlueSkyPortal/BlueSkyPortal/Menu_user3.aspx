<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Menu_user3.aspx.cs" Inherits="Menu_user3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>User Report<span class="m_1"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span></h1>


        
        </div>
    </div>






    <div id="testimonial-box" class="section wb">
        <div id="faqHtml" runat="server" class="container">
            <div class="row">
                <div class="col-md-12 col-sm-6 col-xs-12">

                    <asp:Label ID="Label4" runat="server" Text="Total withdrawal"></asp:Label>
                         <asp:Label ID="label_withdrawal" runat="server" Text=" "></asp:Label>

                      <asp:Label ID="Label2" runat="server" Text="Total deposit "></asp:Label>
            <asp:Label ID="Label3_deposit" runat="server" Text=" "></asp:Label>



                    <div class="table-responsive">





                     <span>Plan 1 report</span>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="Id_factore" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <Columns>

                                <asp:TemplateField HeaderText="row">
                          <ItemTemplate>
                              <asp:Label ID="Label1" runat="server" Text="<%# (GridView1.PageIndex * GridView1.PageSize) + (GridView1.Rows.Count + 1)  %>"></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>


                                <asp:BoundField DataField="Id_factore" HeaderText="Rf_id" InsertVisible="False" ReadOnly="True" SortExpression="Id_factore" />
                                <asp:BoundField DataField="Date_Start" HeaderText="start Date" SortExpression="Date_Start" />
                                <asp:BoundField DataField="Price_Start" HeaderText="Investment" SortExpression="Price_Start" />
                                <asp:BoundField DataField="Price_vam" HeaderText="Loan" SortExpression="Price_vam" />
                                <asp:BoundField DataField="Price_sumdate" HeaderText="Investment totall" SortExpression="Price_sumdate" />
                                <asp:BoundField DataField="Date_bargasht" HeaderText="Due date" SortExpression="Date_bargasht" />
                                <asp:BoundField DataField="Desk_factore1" HeaderText="Plan" SortExpression="Desk_factore1" />
                                <asp:BoundField DataField="Desk_factore" HeaderText="Completion Date" SortExpression="Desk_factore" />
                                <asp:CommandField ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>

                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="SELECT Date_Start, Price_Start, Price_vam, Price_sumdate, Date_bargasht, Desk_factore, Id_factore, Desk_factore1 FROM Factore WHERE (Id_customer = @Id_customer) AND (Date_bargasht = @Date_bargasht) AND (Statuse = 0)">
                            <SelectParameters>
                                <asp:SessionParameter DefaultValue="15" Name="Id_customer" SessionField="id_customer" Type="Int32" />
                                <asp:ControlParameter ControlID="Label1" Name="Date_bargasht" PropertyName="Text" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>
<div>
    <asp:Literal ID="Literal7" runat="server"></asp:Literal>
    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" OnSelectedIndexChanged="GridView5_SelectedIndexChanged">
        <Columns>

            
                                <asp:TemplateField HeaderText="row">
                          <ItemTemplate>
                              <asp:Label ID="Label51" runat="server" Text="<%# (GridView5.PageIndex * GridView5.PageSize) + (GridView5.Rows.Count + 1)  %>"></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>


            <asp:BoundField DataField="id_cash" HeaderText="Rf_id" SortExpression="id_cash" />
            <asp:BoundField DataField="Date_Start" HeaderText="start Date" SortExpression="Date_Start" />
            <asp:BoundField DataField="Price_Start" HeaderText="Investment" SortExpression="Price_Start" />
            <asp:BoundField DataField="Price_vam" HeaderText="Loan" SortExpression="Price_vam" />
            <asp:BoundField DataField="Desk_factore1" HeaderText="Plan" SortExpression="Desk_factore1" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="search_oldfactore1" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="Label1" Name="date" PropertyName="Text" Type="String" />
            <asp:SessionParameter Name="id_customer" SessionField="id_customer" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>

</div>





                    <div class="table-responsive">

                        <span>Plan 2 report</span>
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_factore" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                            <Columns>

                                <asp:TemplateField HeaderText="Row">
                          <ItemTemplate>
                              <asp:Label ID="Label2" runat="server" Text="<%# (GridView2.PageIndex * GridView2.PageSize) + (GridView2.Rows.Count + 1)  %>"></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>



                                <asp:BoundField DataField="Id_factore" HeaderText="Rf_id" InsertVisible="False" ReadOnly="True" SortExpression="Id_factore" />
                                <asp:BoundField DataField="Date_Start" HeaderText="start Date" SortExpression="Date_Start" />
                                <asp:BoundField DataField="Price_Start" HeaderText="Investment" SortExpression="Price_Start" />
                                <asp:BoundField DataField="Price_vam" HeaderText="Loan" SortExpression="Price_vam" />
                                <asp:BoundField DataField="Price_sumdate" HeaderText="Investment totall	" SortExpression="Price_sumdate" />
                                <asp:BoundField DataField="Date_bargasht" HeaderText="Due date" SortExpression="Date_bargasht" />
                                <asp:BoundField DataField="Desk_factore1" HeaderText="Plan" SortExpression="Desk_factore1" />
                                <asp:BoundField DataField="Desk_factore" HeaderText="Completion Date" SortExpression="Desk_factore" />
                                <asp:CommandField ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>

                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="SELECT Id_factore, Date_Start, Price_Start, Price_vam, Price_sumdate, Date_bargasht, Desk_factore, Desk_factore AS Expr1, Desk_factore1 FROM Factore2 WHERE (Id_customer = @Id_customer) AND (Date_bargasht = @Date_bargasht)">
                            <SelectParameters>
                                <asp:SessionParameter Name="Id_customer" SessionField="id_customer" Type="Int32" />
                                <asp:ControlParameter ControlID="Label1" Name="Date_bargasht" PropertyName="Text" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>
                    <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource6" OnSelectedIndexChanged="GridView6_SelectedIndexChanged">
                        <Columns>


                                <asp:TemplateField HeaderText="Row">
                          <ItemTemplate>
                              <asp:Label ID="Label6" runat="server" Text="<%# (GridView6.PageIndex * GridView6.PageSize) + (GridView6.Rows.Count + 1)  %>"></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>



                            <asp:BoundField DataField="id_cash" HeaderText="Rf_id" SortExpression="id_cash" />
                            <asp:BoundField DataField="Date_Start" HeaderText="start Date" SortExpression="Date_Start" />
                            <asp:BoundField DataField="Price_Start" HeaderText="Investment" SortExpression="Price_Start" />
                            <asp:BoundField DataField="Price_vam" HeaderText="Loan" SortExpression="Price_vam" />
                            <asp:BoundField DataField="Desk_factore1" HeaderText="Plan" SortExpression="Desk_factore1" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="search_oldfactore2" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="Label1" Name="date" PropertyName="Text" Type="String" />
                            <asp:SessionParameter Name="id_customer" SessionField="Id_customer" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <div class="table-responsive">
                        <span>Plan 4report</span>

                        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_factore" DataSourceID="SqlDataSource4" OnSelectedIndexChanged="GridView4_SelectedIndexChanged">
                            <Columns>

                                
                                <asp:TemplateField HeaderText="Row">
                          <ItemTemplate>
                              <asp:Label ID="Label4" runat="server" Text="<%# (GridView4.PageIndex * GridView4.PageSize) + (GridView4.Rows.Count + 1)  %>"></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>



                                <asp:BoundField DataField="Id_factore" HeaderText="Rf_id" InsertVisible="False" ReadOnly="True" SortExpression="Id_factore" />
                                <asp:BoundField DataField="Date_Start" HeaderText="Start Date" SortExpression="Date_Start" />
                                <asp:BoundField DataField="Price_Start" HeaderText="Investment" SortExpression="Price_Start" />
                                <asp:BoundField DataField="Price_vam" HeaderText="Loan" SortExpression="Price_vam" />
                                <asp:BoundField DataField="Desk_factore1" HeaderText="Plan" SortExpression="Desk_factore1" />
                                <asp:CommandField ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>



                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="SELECT [Id_factore], [Date_Start], [Price_Start], [Price_vam], [Desk_factore], [Desk_factore1] FROM [Factore4] WHERE ([Id_customer] = @Id_customer)">
                            <SelectParameters>
                                <asp:SessionParameter Name="Id_customer" SessionField="id_customer" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>

                    </div>

                    <div class="table-responsive">

                        <span>Plan 3 report</span>

                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_factore" DataSourceID="SqlDataSource3" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                            <Columns>

   
                                <asp:TemplateField HeaderText="Row">
                          <ItemTemplate>
                              <asp:Label ID="Label3" runat="server" Text="<%# (GridView3.PageIndex * GridView3.PageSize) + (GridView3.Rows.Count + 1)  %>"></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>



                                <asp:BoundField DataField="Id_factore" HeaderText="Rf_id" InsertVisible="False" ReadOnly="True" SortExpression="Id_factore" />
                                <asp:BoundField DataField="Date_Start" HeaderText="Start Date" SortExpression="Date_Start" />
                                <asp:BoundField DataField="Price_Start" HeaderText="Investment" SortExpression="Price_Start" />
                                <asp:BoundField DataField="Price_vam" HeaderText="Loan" SortExpression="Price_vam" />
                                <asp:BoundField DataField="Price_sumdate" HeaderText="Investment totall" SortExpression="Price_sumdate" />
                                <asp:BoundField DataField="Date_bargasht" HeaderText="Due date" SortExpression="Date_bargasht" />
                                <asp:BoundField DataField="Desk_factore1" HeaderText="Plan" SortExpression="Desk_factore1" />
                                <asp:CommandField ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>



                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="SELECT Id_factore, Date_Start, Price_Start, Price_vam, Price_sumdate, Date_bargasht, Desk_factore, Desk_factore1 FROM Factore3 WHERE (Date_bargasht = @Date_bargasht) AND (Id_customer = @Id_customer)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="Label1" Name="Date_bargasht" PropertyName="Text" Type="String" />
                                <asp:SessionParameter Name="Id_customer" SessionField="id_customer" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>


                    <div class="table-responsive">

                        <span>Rep  Referrals</span>

                        <p>
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                        </p>
                        <p>
                          <asp:Literal ID="Literal2" runat="server"></asp:Literal> 

                        </p>
                        <p>
                          <asp:Literal ID="Literal3" runat="server"></asp:Literal>  

                        </p>
                        <p>
                           <asp:Literal ID="Literal4" runat="server"></asp:Literal> 

                        </p>
                        <p>
                           
 <asp:Literal ID="Literal5" runat="server"></asp:Literal>
                        </p>
                        <p>
                          <asp:Literal ID="Literal6" runat="server"></asp:Literal> 

                        </p>

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

