<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="service.aspx.cs" Inherits="admin_service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .service-image {
            width: 100%;
            border-radius: 5px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="headerPicHtml" runat="server" class="bg-service all-title-box">
        <div class="container text-center">
            <h1>Service<%--<span class="m_1">Please read all available service which we offer you</span>--%></h1>
        </div>
    </div>

    <div id="pricing-box" class="section wb">
        <div id="serviceHtml" clientidmode="Static" runat="server" class="container">
            <div class="col-md-4 col-sm-6 col-xs-12">
                <div class="grid1">
                    <span>$15/<small>month</small></span>
                    <div class="price-tit text-center">
                        <img src="images/service/3.jpg" alt="" />
                        <h2>BASIC PLAN</h2>
                        <p>Lorem Ipsum dolroin gravida nibh vel velit auctor aliquet.</p>
                    </div>
                    <div class="para">
                        <p>1 Domain</p>
                        <p>10 GB Disk Space</p>
                        <p>50 GB Bandwidth</p>
                        <p>Free Domain</p>
                    </div>
                    <div class="sign text-center pricing-table-sign-up">
                        <a href="#" class="btn btn-light btn-radius btn-brd grd1 effect-1">BUY</a>
                    </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-6 col-xs-12">
                <div class="grid2">
                    <span>$25/<small>month</small></span>
                    <div class="price-tit text-center">
                        <h2>PREMIUM PLAN</h2>
                        <p>Lorem Ipsum dolroin gravida nibh vel velit auctor aliquet.</p>
                    </div>
                    <div class="para">
                        <p>5 Domains</p>
                        <p>50 GB Disk Space</p>
                        <p>250 GB Bandwidth</p>
                        <p>2 Free Domains</p>
                    </div>
                    <div class="sign text-center pricing-table-sign-up">
                        <a href="#" class="btn btn-light btn-radius btn-brd grd1 effect-1">BUY</a>
                    </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-6 col-xs-12">
                <div class="grid3">
                    <span>$35/<small>month</small></span>
                    <div class="price-tit text-center">
                        <h2>ULTIMATE PLAN</h2>
                        <p>Lorem Ipsum dolroin gravida nibh vel velit auctor aliquet.</p>
                    </div>
                    <div class="para">
                        <p>10 Domains</p>
                        <p>250 GB Disk Space</p>
                        <p>500 GB Bandwidth</p>
                        <p>3 Free Domains</p>
                    </div>
                    <div class="sign text-center pricing-table-sign-up">
                        <a href="#" class="btn btn-light btn-radius btn-brd grd1 effect-1">BUY</a>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
    <!-- end section -->


    <%--    <div class="section lb">
        <div class="container">
            <div class="section-title text-center">
                <h3>Ready to get started?</h3>
				<div class="dmoain-pricing">
					<div class="table-responsive-sm">
						<table>
							<thead>
								<tr class="domain-head">
									<th scope="col">
										Domain Name
									</th>
									<th scope="col">
										Registration Pricing
									</th>
									<th scope="col">
										Renewal Pricing
									</th>
									<th scope="col">
										Transfer Pricing
									</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td data-label="DOMAIN NAME">.com</td>
									<td data-label="registration pricing">15.00 / yr</td>
									<td data-label="renewal pricing">$30 / yr</td>
									<td data-label="transfer-price">$45.00</td>
								</tr>
								<tr>
									<td data-label="DOMAIN NAME">.net</td>
									<td data-label="registration pricing">15.00 / yr</td>
									<td data-label="renewal pricing">$20 / yr</td>
									<td data-label="transfer-price">$45.00</td>
								</tr>
								<tr>
									<td data-label="DOMAIN NAME">.org</td>
									<td data-label="registration pricing">15.00 / yr</td>
									<td data-label="renewal pricing">$19 / yr</td>
									<td data-label="transfer-price">$45.00</td>
								</tr>
								<tr>
									<td data-label="DOMAIN NAME">.in</td>
									<td data-label="registration pricing">15.00 / yr</td>
									<td data-label="renewal pricing">$18 / yr</td>
									<td data-label="transfer-price">$45.00</td>
								</tr>
								<tr>
									<td data-label="DOMAIN NAME">.biz</td>
									<td data-label="registration pricing">15.00 / yr</td>
									<td data-label="renewal pricing">$17 / yr</td>
									<td data-label="transfer-price">$45.00</td>
								</tr>
								<tr>
									<td data-label="Acount">.info</td>
									<td data-label="registration pricing">15.00 / yr</td>
									<td data-label="renewal pricing">$16 / yr</td>
									<td data-label="transfer-price">$45.00</td>
								</tr>
								<tr>
									<td data-label="DOMAIN NAME">.co.uk</td>
									<td data-label="registration pricing">15.00 / yr</td>
									<td data-label="renewal pricing">$15 / yr</td>
									<td data-label="transfer-price">$45.00</td>
								</tr>
								<tr>
									<td data-label="DOMAIN NAME">.name</td>
									<td data-label="registration pricing">15.00 / yr</td>
									<td data-label="renewal pricing">$14 / yr</td>
									<td data-label="transfer-price">$45.00</td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
            </div><!-- end title -->
        </div><!-- end container -->
    </div><!-- end section -->--%>
</asp:Content>

