<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="plans.aspx.cs" Inherits="admin_plans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
            <div class="content">
                
                <div class="page-header">
                    <div class="icon">
                        <span class="ico-layout-7"></span>
                    </div>
                    <h1>Plans<small>METRO STYLE ADMIN PANEL</small></h1>
                </div>

                <div class="row-fluid">
                    <div class="span12">
                        <div class="block">
                            <div class="head blue">
                                <div class="icon"><i class="ico-layout-9"></i></div>
                                <h2>Plans</h2>
                                <ul class="buttons">
                                    <li><a href="#" onClick="source('table_sort'); return false;"><div class="icon"><span class="ico-info"></span></div></a></li>
                                </ul>
                            </div>                
                                <div class="data-fluid">
                                    <table class="table dtable lcnp" cellpadding="0" cellspacing="0" width="100%">
                                        <thead>
                                            <tr>
                                                <th><input type="checkbox" class="checkall"/></th>
                                                <th width="20%">Name</th>
                                                <th>Product</th>
                                                <th width="20%">Status</th>
                                                <th width="20%">Date</th>
                                                <th width="80" class="TAC">Actions</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                          
                                         
                                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                          
                                            
                                        </tbody>
                                    </table>                    
                                </div> 
                        </div>            

                    </div>
                </div>  
            </div>
            
       
</asp:Content>

