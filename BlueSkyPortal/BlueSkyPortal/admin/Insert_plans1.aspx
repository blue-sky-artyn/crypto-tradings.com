<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Insert_plans1.aspx.cs" Inherits="admin_Insert_plans1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       
            <div class="content">
                
                <div class="page-header">
                    <div class="icon">
                        <span class="ico-pen-2"></span>
                    </div>
                    <h1>Insert Plans <small>METRO STYLE ADMIN PANEL</small></h1>
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
                                    <div class="span3">Plan Name:</div>
                                    <div class="span9"><asp:TextBox ID="txtn1" runat="server"></asp:TextBox></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Description:</div>
                                    <div class="span9"><asp:TextBox ID="txt_d1" runat="server"></asp:TextBox></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Name Plan2:</div>
                                    <div class="span9"><asp:TextBox ID="txtn2" runat="server"></asp:TextBox></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Description:</div>
                                    <div class="span9"><asp:TextBox ID="txtd2" runat="server"></asp:TextBox></div>
                                </div>                    
                                <div class="row-form">
                                    <div class="span3">Name Plan 3:</div>
                                    <div class="span9"><asp:TextBox ID="txtn3" runat="server"></asp:TextBox></div>
                                </div>

                                <div class="row-form">
                                    <div class="span3">Description:</div>
                                    <div class="span9"> <asp:TextBox ID="txtd3" runat="server"></asp:TextBox></div>
                                </div>

                                <div class="row-form">
                                    <div class="span3">Name Plan 4:</div>
                                    <div class="span9"><asp:TextBox ID="txtn4" runat="server"></asp:TextBox></div>
                                </div>


                                <div class="row-form">
                                    <div class="span3">description:</div>
                                    <div class="span9"><asp:TextBox ID="txtd4" runat="server"></asp:TextBox></div>
                                </div>

                            </div>
                        </div>

                        <div class="btn-group">
                                            <asp:Button ID="Button1" runat="server" Text="edit"  CssClass="btn btn-mini" OnClick="Button1_Click" />
                                        </div>




                    </div>

                

                </div>                
                     
            </div>
            






</asp:Content>

