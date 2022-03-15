<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Changepass.aspx.cs" Inherits="Changepass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>Change User Password</h1>
        </div>
    </div>





    <div id="support" class="section wb">
        <div class="container">
            <div class="section-title text-center">
                <h3 id="coNameHtml" runat="server">Crypto Tradings</h3>
                <p id="managerSpeachHtml" runat="server" class="lead">
                    User change password
                </p>
            </div>
            <!-- end title -->
            <div class="row">
                <div class="col-md-12">
                    <div class="contact_form">
                        <div id="message"></div>
                        <div class="row">
                            <fieldset class="row-fluid">
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="email" name="name" value="" id="txtEmail" runat="server" class="input-value form-control" placeholder="Email" autocompletetype="None"
                                        pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$" />
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="password" name="name" value="" id="txt_old" runat="server" class="input-value form-control" placeholder="Old password" autocompletetype="None"
                                        pattern=".{1,}" title="Eight or more characters" />
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="password" name="name" value="" id="txt_new1" runat="server" class="input-value form-control" placeholder="New password"
                                        pattern=".{1,}" title="Eight or more characters" />
                                </div>
                                <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                    <input type="password" name="name" value="" id="txt_new2" runat="server" class="input-value form-control" placeholder="Repeat password"
                                        pattern=".{1,}" title="Eight or more characters" />
                                </div>
                                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                                    <p id="lblErrorHtml" runat="server" style="color: red;"></p>
                                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" class="btn btn-light btn-radius btn-brd grd1 btn-block" />
                                </div>
                            </fieldset>
                        </div>
                    </div>
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>

</asp:Content>

