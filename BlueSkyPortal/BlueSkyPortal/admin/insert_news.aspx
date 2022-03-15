<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="insert_news.aspx.cs" Inherits="admin_insert_email" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="content">
                
                <div class="page-header">
                    <div class="icon">
                        <span class="ico-pen-2"></span>
                    </div>
                    <h1>Insert news <small>METRO STYLE ADMIN PANEL</small></h1>
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
                                
                                <div class="row-form">
                                    <div class="span3">Title:</div>
                                    <div class="span9"><asp:TextBox ID="txt_titr" runat="server"></asp:TextBox></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Details:</div>
                                    <div class="span9"><asp:TextBox ID="txt_text" runat="server" TextMode="MultiLine"></asp:TextBox></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Picture:</div>

                                      <asp:FileUpload ID="FileUpload1" runat="server" CssClass="btn btn-mini" />
    <br />


                                 
                                </div>
                               
                                                        
                            </div>
                        </div>

                        <div class="btn-group">
                                               <asp:Button ID="Button1" runat="server" CssClass="btn btn-mini" Text="Save" OnClick="Button1_Click" />
                                        </div>
                        <hr />

                        <br />

                        <br />
                        <div class="row-form">
                                    <div class="span3">News:</div>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_news" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="ID_news" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID_news" />
                                <asp:BoundField DataField="Titr_new" HeaderText="Title" SortExpression="Titr_new" />
                                <asp:BoundField DataField="Matn_news" HeaderText="Details" SortExpression="Matn_news" />
                                <asp:CommandField ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>

                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CryptoConnectionString %>" SelectCommand="Select_news11" SelectCommandType="StoredProcedure"></asp:SqlDataSource>


                        <br />
                       </div>
                       <div class="row-form">
                                    

                         <div class="span3">Please enter news ID:</div>
                                    <div class="span9"><asp:TextBox ID="Txt_delete" runat="server" Width="227px" ></asp:TextBox></div>
               </div>
                                                <div class="btn-group">

                        <asp:Button ID="Button2" runat="server" Text="Delete" CssClass="btn btn-mini" Width="236px" OnClick="Button2_Click" />
</div>




                    </div>

                

                </div>                
                     
            </div>

</asp:Content>

