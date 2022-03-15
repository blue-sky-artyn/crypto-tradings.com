<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Changpass_admin.aspx.cs" Inherits="admin_Changpass_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <div class="content">
                
                <div class="page-header">
                    <div class="icon">
                        <span class="ico-pen-2"></span>
                    </div>
                    <h1>Change Password <small>METRO STYLE ADMIN PANEL</small></h1>
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
                                    <div class="span3">Old Password:</div>
                                    <div class="span9"><input type="password" name="name" value="" ID="txt_old" runat="server" class="input-value form-control" placeholder="password" AutoCompleteType="None"
  pattern=".{1,}" title="Eight or more characters"/></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">New Password:</div>
                                    <div class="span9"><input type="password" name="name" value="" ID="txt_new1" runat="server" class="input-value form-control" placeholder="password"
  pattern=".{1,}" title="Eight or more characters"/></div>
                                </div>
                                <div class="row-form">
                                    <div class="span3">Repeat New Password:</div>
                                    <div class="span9"> <input type="password" name="name" value="" ID="txt_new2" runat="server" class="input-value form-control" placeholder="password"
  pattern=".{1,}" title="Eight or more characters"/></div>
                                </div>

                            </div>
                        </div>

                        <div class="btn-group">
                                               <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                                        </div>
                    </div>
                </div>                
                     
            </div>
            
</asp:Content>

