<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="etc.aspx.cs" Inherits="admin_service" %>

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


      
    <div id="hosting" class="section wb" style="background: rgb(248, 248, 248)">
        <div class="container">
            <div class="section-title text-center">
                <h3>Investment plans</h3>
                <p id="serviceTitleHtml" runat="server" class="lead">Read more about groups of <br /> <strong>Investment plans
  </strong> can we offer you.</p>
            </div><!-- end title -->

            <div class="row dev-list text-center">
                <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s">
                    <div class="widget clearfix">
                        <div class="widget-title">
                            <h3 class="stylish-header-1">BRONZ</h3>
                            <h2 class="stylish-title">10%<small>10 DAY</small></h2>
                        </div>
                        <!-- end title -->
                        <ul class="investment-items">
                            <li>Min Deposit: 50 $</li>
                            <li>Max Deposit: 600 $</li>
                            <li>Plan Terms: 10 Days</li>
                            <li>Total Profit: 10%</li>
                            <li>Daily Profit: 1%</li>
                        </ul>

                        <hr> 

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Investment</a>

                    </div><!--widget -->
                </div><!-- end col -->

                <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s">
                    <div class="widget clearfix">
                        <div class="widget-title">
                            <h3 class="stylish-header-1">Silver</h3>
                            <h2 class="stylish-title">40%<small>30 DAY</small></h2>
                        </div>
                        <!-- end title -->
                        <ul class="investment-items">
                            <li>Min Deposit: 50 $</li>
                            <li>Max Deposit: 600 $</li>
                            <li>Plan Terms: 10 Days</li>
                            <li>Total Profit: 10%</li>
                            <li>Daily Profit: 1%</li>
                        </ul>

                        <hr> 

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Investment</a>

                    </div><!--widget -->
                </div><!-- end col -->

                <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s">
                    <div class="widget clearfix">
                        <div class="widget-title">
                            <h3 class="stylish-header-1">Gold</h3>
                            <h2 class="stylish-title">100%<small>60 DAY</small></h2>
                        </div>
                        <!-- end title -->
                        <ul class="investment-items">
                            <li>Min Deposit: 50 $</li>
                            <li>Max Deposit: 600 $</li>
                            <li>Plan Terms: 10 Days</li>
                            <li>Total Profit: 10%</li>
                            <li>Daily Profit: 1%</li>
                        </ul>

                        <hr> 

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Investment</a>

                    </div><!--widget -->
                </div><!-- end col -->

                <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12 wow fadeIn" data-wow-duration="1s" data-wow-delay="0.2s">
                    <div class="widget clearfix">
                        <div class="widget-title">
                            <h3 class="stylish-header-1">Diamond</h3>
                            <h2 class="stylish-title">240%<small>120 DAY</small></h2>
                        </div>
                        <!-- end title -->
                        <ul class="investment-items">
                            <li>Min Deposit: 50 $</li>
                            <li>Max Deposit: 600 $</li>
                            <li>Plan Terms: 10 Days</li>
                            <li>Total Profit: 10%</li>
                            <li>Daily Profit: 1%</li>
                        </ul>

                        <hr> 

                        <a href="#pricing" data-scroll class="btn btn-light grd1 effect-1 btn-radius btn-brd">Investment</a>

                    </div><!--widget -->
                </div><!-- end col -->
             
            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->


        <div class="section lb">
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
    </div><!-- end section -->
</asp:Content>

