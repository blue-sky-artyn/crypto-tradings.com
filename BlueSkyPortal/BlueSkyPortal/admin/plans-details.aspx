<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="~/admin/plans-details.aspx.cs" Inherits="admin_palns" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
            <div class="content">
                
                <div class="page-header">
                    <div class="icon">
                        <span class="ico-ok"></span>
                    </div>
                    <h1>Plans<small>Edit your Plans</small></h1>
                </div>
                
                <div class="row-fluid">

                    <div class="span12">                

                        <div class="block">
                            <div class="head">                                
                                <h2>The Plan</h2>
                                <ul class="buttons">             
                                    <li><a href="#" onClick="source('form_validation'); return false;"><div class="icon"><span class="ico-info"></span></div></a></li>
                                </ul>                                
                            </div>                                               
                            <div id="validate">
                            <div class="data-fluid">

                                <div class="row-form">
                                    <div class="span2">Plan Name:</div>
                                    <div class="span10">
                                      <asp:TextBox ID="txt_nameplan" runat="server"></asp:TextBox>
                                      
                                        <span class="bottom">Required, max size = 8</span>
                                    </div>
                                </div>
                                <div class="row-form">
                                    <div class="span2">Max payment:</div>
                                    <div class="span4">
                                         <asp:TextBox ID="txt_max" runat="server"></asp:TextBox> 
                                        <span class="bottom"></span>
                                    </div>
                                
                                    <div class="span2">Min Payment:</div>
                                    <div class="span4">
   <asp:TextBox ID="txt_min" runat="server"></asp:TextBox>
                                        <span class="bottom">Required, digits</span>
                                    </div>
                                </div>
                                <div class="row-form">

                                </div> 
                                
                                <div class="row-form">
                                    <div class="span2"> period</div>
                                    <div class="span4">
                                          <asp:TextBox ID="txt_period" runat="server"></asp:TextBox>
                                        <span class="bottom"></span>
                                    </div>
                                
                                    <div class="span2">Interest rates</div>
                                    <div class="span4">
                                         <asp:TextBox ID="txt_sent" runat="server"></asp:TextBox>
                                        <span class="bottom">Required, digits</span>
                                    </div>
                                </div>




                                <div class="row-form">
                                    <div class="span2">Wallet Name:</div>
                                    <div class="span10">
                                         <asp:TextBox ID="txt_walet" runat="server"></asp:TextBox>
                                        <span class="bottom"></span>
                                    </div>
                                </div>

                                <div class="row-form">
                                    <div class="span2">Details:</div>
                                    <div class="span10">
                                        <asp:TextBox ID="txt_Details" runat="server"></asp:TextBox>
                                        <span class="bottom"></span>
                                    </div>
                                </div>

                                <div class="row-form">
                                    <div class="span2">Loan amount:</div>
                                    <div class="span5">
                                         <asp:TextBox ID="txt_vam" runat="server"></asp:TextBox>
                                        <span class="bottom">Required, integer, min value = 18, max = 120</span>
                                    </div>                        
                                    <div class="span2 TAR">Plan status:</div>
                                    <div class="span3">

                                        <nobr>


                                       <asp:DropDownList ID="DropDownList1" runat="server">
                                           <asp:ListItem Value="0">active</asp:ListItem>
                                           <asp:ListItem Value="1">Inactive</asp:ListItem>
                                        </asp:DropDownList>

                                         </nobr>
                                        <span class="bottom">Required</span>
                                    </div>                        
                                </div>
                                <div class="row-form">
                                    <div class="span2">Percent Reagent:</div>
                                    <div class="span10">
                                         <asp:TextBox ID="txt_moaref" runat="server"></asp:TextBox>
                                        <span class="bottom"></span>
                                    </div>
                                </div>
                                                                 
                                <div class="toolbar bottom tar">
                                    <div class="btn-group">
                                        <button class="btn btn-info" type="button">Back</button>

                                        <asp:Button ID="Button1" class="btn" runat="server" Text="Update" OnClick="Button1_Click" />
                                   
                                    </div>
                                </div>

                            </div>                
                            </div>
                        </div>
                    </div>

                </div>                 
                

            </div>
            
</asp:Content>

