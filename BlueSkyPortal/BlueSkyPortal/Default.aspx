<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<script src="https://kit.fontawesome.com/67273cf17e.js" crossorigin="anonymous"></script>--%>

    <style>
        .slider-bg {background-size: cover;}
        .fa-angle-left:before {color: whitesmoke;}
        .fa-angle-right:before {color: whitesmoke;}
        .fa-quote-left:before {color: #00346b;}
        .companies-details {width: 80%;margin: 25px auto;}
        .slider-para {
            max-height: 185px;
            overflow: hidden;
        }
        .news-details {
            text-align: justify;
            /*min-height: 265px;*/
            height: 265px;
            overflow: hidden;
            clear: both;
        }
        .readme-font {
            font-weight: bold;
        }
        .service-icon {
            font-size: 50px;
            color: #f0aa31;
            text-shadow: #b5b1b159 2px 2px 0px;
        }
        .context {
            height: 85px;
            overflow: hidden;
        }
        .widget-title {
            overflow: hidden;
        }
        .space{
            margin-top: 30px;
        }
        .stylish-header-1 {
                letter-spacing: 4px;
                font-size: 50px;
        }
        .stylish-title {
                letter-spacing: -4px;
                font-size:40px;
        }
        .stylish-title small {
            display: block;
            margin-top: 0.7rem;
            letter-spacing: 0;
            font-size: 10px;
            padding: 0 15px;
        }
        .investment-items {

        }
        .investment-items li {
            list-style: none;
    line-height: 32px;
    letter-spacing: 1px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
	<div id="bootstrap-touch-slider" class="carousel bs-slider fade  control-round indicators-line" data-ride="carousel" data-pause="hover" data-interval="false" >
		<!-- Indicators -->
		<ol id="sliderBullertsHtml" runat="server" class="carousel-indicators">
			<li data-target="#bootstrap-touch-slider" data-slide-to="0" class="active"></li>
			<li data-target="#bootstrap-touch-slider" data-slide-to="1"></li>
			<li data-target="#bootstrap-touch-slider" data-slide-to="2"></li>
		</ol>
		<div id="sliderContentHtml" runat="server" class="carousel-inner" role="listbox">
			<div class="item active">
				<div id="home" class="slider-bg first-section" style="background-image:url('images/1.jpg');">
					<div class="container">
						<div class="row">
							<div class="col-md-12 col-sm-12 text-center">
								<div class="big-tagline">
									<%--<img src="images/logos/logo-hosting.png" alt="image">--%>
									<h2 data-animation="animated zoomInRight">Rapid <strong>Increase </strong> In Number of electrical charging cars</h2>
									<p class="lead" data-animation="animated fadeInLeft">US EV charging network grows from 5,070 to 50,990 charging sites in 6 years .</p>
									 <a data-scroll href="#pricing" class="btn btn-light btn-radius btn-brd effect-1 slide-btn" data-animation="animated fadeInLeft">Read More</a>
									
									<%--<a data-scroll href="#overviews" class="btn btn-light btn-radius btn-brd effect-1 slide-btn" data-animation="animated fadeInRight">All Features</a>--%>
								</div>
							</div>
						</div><!-- end row -->            
					</div><!-- end container -->
				</div><!-- end section -->
			</div>
			<div class="item">
				<div id="home" class="slider-bg first-section" style="background-image:url('images/2.jpg');">
					<div class="container">
						<div class="row">
							<div class="col-md-12 col-sm-12 text-center">
								<div class="big-tagline">

									<h2 data-animation="animated zoomInRight">electric <strong>car charging</strong> station plans</h2>
									<p class="lead" data-animation="animated fadeInLeft">developed an interesting idea for preventing the charging stations </p>
									 <a data-scroll href="#pricing" class="btn btn-light btn-radius btn-brd effect-1 slide-btn" data-animation="animated fadeInLeft">Read More</a>
								</div>
							</div>
						</div><!-- end row -->            
					</div><!-- end container -->
				</div><!-- end section -->
			</div>
			<div class="item">
				<div id="home" class="slider-bg first-section" style="background-image:url('images/3.jpg');">
					<div class="container">
						<div class="row">
							<div class="col-md-12 col-sm-12 text-center">
								<div class="big-tagline">
									<h2 data-animation="animated zoomInRight">Home  <strong>Charging Stations</strong> for Electric Vehicles</h2>
									<p class="lead" data-animation="animated fadeInLeft">We’ve noticed an increase in queries about Electric Vehicle home charging stations</p>
									 <a data-scroll href="#pricing" class="btn btn-light btn-radius btn-brd effect-1 slide-btn" data-animation="animated fadeInLeft">Read More</a>
								</div>
							</div>
						</div><!-- end row -->            
					</div><!-- end container -->
				</div><!-- end section -->
			</div>
			<!-- Left Control -->
			<a class="left carousel-control" href="#bootstrap-touch-slider" role="button" data-slide="prev">
				<span class="fa fa-angle-left" aria-hidden="true"></span>
				<span class="sr-only">Previous</span>
			</a>

			<!-- Right Control -->
			<a class="right carousel-control" href="#bootstrap-touch-slider" role="button" data-slide="next">
				<span class="fa fa-angle-right" aria-hidden="true"></span>
				<span class="sr-only">Next</span>
			</a>
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

    <div id="pricing" class="section lb">
        <div class="container">
            <div class="section-title text-center">
                <h3>Investment plans</h3>
                <p class="lead">Get the red carpet treatment <strong>just $39 per month!</strong> It is estimated that 3.5 million established by personal blogs.<br> From each other, we share paid WordPress themes WP Service...</p>
            </div><!-- end title -->

            <div class="row">
                <div class="col-md-6 col-md-offset-3">
                    <div class="message-box">
                        <ul class="nav nav-pills nav-stacked" id="myTabs">
                            <li class="active"><a href="#tab1" data-toggle="pill">Monthly Subscription</a></li>
                            <li><a href="#tab2" data-toggle="pill">Yearly Subscription</a></li>
                        </ul>
                    </div>
                </div><!-- end col -->
            </div>

            <hr class="invis">

            <div class="row">
                <div class="col-md-12">
                    <div class="tab-content">
                        <div class="tab-pane active fade in" id="tab1">
                            <div class="row text-center">
                                <div class="col-md-4">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 1</h2>
                                            <h3>10%/10 Days</h3>
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>This is a perfect choice for small businesses and startups.</p>
                                        </div>
                                        <div class="pricing-table-features">
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>50$</strong> Min Deposit</p>
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>600$</strong> Max Deposit</p>
                                            <p><i class="fa fa-sun-o" aria-hidden="true"></i> <strong>10Days</strong> Plan Terms</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>10%</strong> Total Profit</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>1%</strong> Daily Profit</p>
                                        </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="#contact" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              
                                <div class="col-md-4">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 2</h2>
                                            <h3>10%/10 Days</h3>
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>This is a perfect choice for small businesses and startups.</p>
                                        </div>
                                        <div class="pricing-table-features">
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>50$</strong> Min Deposit</p>
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>600$</strong> Max Deposit</p>
                                            <p><i class="fa fa-sun-o" aria-hidden="true"></i> <strong>10Days</strong> Plan Terms</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>10%</strong> Total Profit</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>1%</strong> Daily Profit</p>
                                        </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="#contact" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              
                                <div class="col-md-4">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 3</h2>
                                            <h3>10%/10 Days</h3>
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>This is a perfect choice for small businesses and startups.</p>
                                        </div>
                                        <div class="pricing-table-features">
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>50$</strong> Min Deposit</p>
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>600$</strong> Max Deposit</p>
                                            <p><i class="fa fa-sun-o" aria-hidden="true"></i> <strong>10Days</strong> Plan Terms</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>10%</strong> Total Profit</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>1%</strong> Daily Profit</p>
                                        </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="#contact" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              

                            </div><!-- end row -->
                        </div><!-- end pane -->

                        <div class="tab-pane fade" id="tab2">
                            <div class="row text-center">
                                <div class="col-md-4">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 4</h2>
                                            <h3>10%/10 Days</h3>
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>This is a perfect choice for small businesses and startups.</p>
                                        </div>
                                        <div class="pricing-table-features">
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>50$</strong> Min Deposit</p>
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>600$</strong> Max Deposit</p>
                                            <p><i class="fa fa-sun-o" aria-hidden="true"></i> <strong>10Days</strong> Plan Terms</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>10%</strong> Total Profit</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>1%</strong> Daily Profit</p>
                                        </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="#contact" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              
                              <div class="col-md-4">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 5</h2>
                                            <h3>10%/10 Days</h3>
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>This is a perfect choice for small businesses and startups.</p>
                                        </div>
                                        <div class="pricing-table-features">
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>50$</strong> Min Deposit</p>
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>600$</strong> Max Deposit</p>
                                            <p><i class="fa fa-sun-o" aria-hidden="true"></i> <strong>10Days</strong> Plan Terms</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>10%</strong> Total Profit</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>1%</strong> Daily Profit</p>
                                        </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="#contact" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              
                                <div class="col-md-4">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 6</h2>
                                            <h3>10%/10 Days</h3>
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>This is a perfect choice for small businesses and startups.</p>
                                        </div>
                                        <div class="pricing-table-features">
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>50$</strong> Min Deposit</p>
                                            <p><i class="fa fa-usd" aria-hidden="true"></i> <strong>600$</strong> Max Deposit</p>
                                            <p><i class="fa fa-sun-o" aria-hidden="true"></i> <strong>10Days</strong> Plan Terms</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>10%</strong> Total Profit</p>
                                            <p><i class="fa fa-percent" aria-hidden="true"></i> <strong>1%</strong> Daily Profit</p>
                                        </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="#contact" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              

                            </div><!-- end row -->
                        </div><!-- end pane -->
                    </div><!-- end content -->
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end container -->
    </div>



    <div id="overviews" class="section wb">
        <div class="container">
            <div class="section-title row text-center">
                <div id="aboutCoHtml" runat="server" class="col-md-8 col-md-offset-2">
                    <h3>General Trading holding</h3>
                    <p class="lead">Lorem Ipsum dolroin gravida nibh vel velit auctor aliquet. Aenean sollicitudin, lorem quis bibendum auctor, nisi elit consequat ipsum, nec sagittis sem!</p>
                </div>
            </div><!-- end title -->
        
            <div class="row">
                <div class="col-md-6">
                    <div class="message-box">
                                                <h4>2017 BEST WEB HOSTING COMPANY</h4>
                        <h2>Awards Winner Support Center</h2>
                        <p class="lead">Quisque eget nisl id nulla sagittis auctor quis id. Aliquam quis vehicula enim, non aliquam risus. Sed a tellus quis mi rhoncus dignissim.</p>

                        <p> Integer rutrum ligula eu dignissim laoreet. Pellentesque venenatis nibh sed tellus faucibus bibendum. Sed fermentum est vitae rhoncus molestie. Cum sociis natoque penatibus et magnis montes, nascetur ridiculus mus. Sed vitae rutrum neque. </p>

                        <a href="#services" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Learn More</a>
                    </div><!-- end messagebox -->
                </div><!-- end col -->
				
				<div class="col-md-6">
                    <div class="post-media wow fadeIn">
                        <img src="images/c1.jpg" alt="" class="img-responsive img-rounded">
                        <a href="https://www.youtube.com/watch?v=3SAxXUIre28" data-rel="prettyPhoto[gal]" class="playbutton"><i class="flaticon-play-button"></i></a>
                    </div><!-- end media -->
                </div><!-- end col -->
            </div><!-- end row -->

            <hr class="invis"> 

            
          

            <hr class="hr3"> 

        
        </div><!-- end container -->
    </div><!-- end section -->


    <div id="testimonials" class="parallax section db parallax-off" style="background-image: url(images/section5.jpg);background-position-y: 50px;">
        <div class="container">
            <div class="section-title text-center">
                <h3>News</h3>
                <p class="lead">review some News from our BLOG</p>
            </div><!-- end title -->

            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <div class="testi-carousel owl-carousel owl-theme">
                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-info-circle"></i> Sed ut perspiciatis unde1</h3>
                                <p class="lead">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit</p>
                            </div>
                            <%--<div class="testi-meta">
                                <img src="uploads/testi_01.png" alt="" class="img-responsive alignleft">
                                <h4>James Fernando <small>- Manager of Racer</small></h4>
                            </div>--%>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Sed ut perspiciatis unde2</h3>
                                <p class="lead">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit</p>
                            </div>
                            <%--<div class="testi-meta">
                                <img src="uploads/testi_02.png" alt="" class="img-responsive alignleft">
                                <h4>Jacques Philips <small>- Designer</small></h4>
                            </div>--%>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Sed ut perspiciatis unde3</h3>
                                <p class="lead">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit</p>
                            </div>
                            <%--<div class="testi-meta">
                                <img src="uploads/testi_03.png" alt="" class="img-responsive alignleft">
                                <h4>Venanda Mercy <small>- Newyork City</small></h4>
                            </div>--%>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->
                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Sed ut perspiciatis unde</h3>
                                <p class="lead">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit</p>
                            </div>
                            <%--<div class="testi-meta">
                                <img src="uploads/testi_01.png" alt="" class="img-responsive alignleft">
                                <h4>James Fernando <small>- Manager of Racer</small></h4>
                            </div>--%>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Sed ut perspiciatis unde</h3>
                                <p class="lead">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit</p>
                            </div>
                            <%--<div class="testi-meta">
                                <img src="uploads/testi_02.png" alt="" class="img-responsive alignleft">
                                <h4>Jacques Philips <small>- Designer</small></h4>
                            </div>--%>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Sed ut perspiciatis unde</h3>
                                <p class="lead">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit</p>
                            </div>
                            <%--<div class="testi-meta">
                                <img src="uploads/testi_03.png" alt="" class="img-responsive alignleft">
                                <h4>Venanda Mercy <small>- Newyork City</small></h4>
                            </div>--%>
                            <!-- end testi-meta -->
                        </div><!-- end testimonial -->
                    </div><!-- end carousel -->
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->

    
    <div class="parallax section db parallax-off" style="background-image:url('images/section5.jpg');">
        <div class="container">
            <div class="row logos">
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/uploads/logo_01.png" alt="bondelectric company" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/uploads/logo_02.png" alt="bondelectric company" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/uploads/logo_03.png" alt="bondelectric company" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/uploads/logo_04.png" alt="bondelectric company" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/uploads/logo_05.png" alt="bondelectric company" class="img-repsonsive"></a>
                </div>
                <div class="col-md-2 col-sm-2 col-xs-6 wow fadeInUp">
                    <a href="#"><img src="images/uploads/logo_06.png" alt="bondelectric company" class="img-repsonsive"></a>
                </div>
            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->

    <%--<section class="section nopad cac text-center">
        <a href="#"><h3>Cooperating companies</h3></a>
        <p class="companies-details">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?</p>
    </section>--%>

</asp:Content>
