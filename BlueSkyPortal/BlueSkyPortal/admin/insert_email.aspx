<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="insert_email.aspx.cs" Inherits="admin_insert_email" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="content">
                
                <div class="page-header">
                    <div class="icon">
                        <span class="ico-pen-2"></span>
                    </div>
                    <h1>Insert Email <small>METRO STYLE ADMIN PANEL</small></h1>
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
                                    <div class="span3">Subject:</div>
                                    <div class="span9"><asp:TextBox ID="txt_subregister" runat="server"></asp:TextBox></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Body:</div>
                                    <div class="span9"><asp:TextBox ID="txt_bodyregister" runat="server"></asp:TextBox></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Sub Email payment:</div>
                                    <div class="span9"><asp:TextBox ID="txt_subprice" runat="server"></asp:TextBox></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Body email payment:</div>
                                    <div class="span9"><asp:TextBox ID="txt_bodyprice" runat="server"></asp:TextBox></div>
                                </div>                    
                                <div class="row-form">
                                    <div class="span3">Wallet Lottery:</div>
                                    <div class="span9"><asp:TextBox ID="txt_Lottery" runat="server"></asp:TextBox></div>
                                </div>
                                                        
                            </div>
                        </div>

                        <div class="btn-group">
                                               <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
                                        </div>




                    </div>

                

                </div>                
                     
            </div>

</asp:Content>

