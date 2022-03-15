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
									<h2 data-animation="animated zoomInRight">Rapid <strong>Increase </strong> In Number of digital Currencies</h2>
									<p class="lead" data-animation="animated fadeInLeft">Digital money is not tangible like a dollar bill or a coin. It is accounted for and transferred using computers. The most successful and widely-used form of digital money is the cryptocurrency Bitcoin.</p>
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

									<h2 data-animation="animated zoomInRight">investment on <strong>digital currencies </strong> on Crypto tradings</h2>
									<p class="lead" data-animation="animated fadeInLeft">Digital money has been conceived of since very early in the age of the internet. Several digital cash companies were founded in the early 1990s, the earliest and best-known of these being DigiCash.</p>
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
									<h2 data-animation="animated zoomInRight">Safe and secure investment on  <strong>Crypto tradings </strong> for Digital currencies</h2>
									<p class="lead" data-animation="animated fadeInLeft">Cryptocurrencies are digital assets people use as investments and for purchases online. You exchange real currency, like dollars, to purchase “coins” or “tokens” of a given cryptocurrency.</p>
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
	
  


    
    <div id="Certificate" class="parallax section db parallax-off" style="background-image: url(images/section5.jpg);background-position-y: 50px;">
        <div class="container">
            <div class="section-title text-center">
                <h3>Crypto Trading Co.</h3>
                <p class="lead">More than happy to have you here.</p>
            </div><!-- end title -->

            <div class="row">
                <div class="col-md-12 col-sm-12">

                        <div class="col-md-6 clearfix">
                            <div class="desc">
                                <img src="images/cer1.jpeg" alt="crypto trading certificate" style="width: 100%;" />
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="col-md-6 clearfix">
                            <div class="desc">
                                <img src="images/cer2.jpeg" alt="crypto trading certificate" style="width: 100%;"/>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end container -->
    </div><!-- end section -->


    <div class="section cl">
		<div class="container">
			<div class="row text-left stat-wrap">
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <p>Totall Bank investment</p>
                </div>
				<div class="col-md-4 col-sm-4 col-xs-12">
					<span data-scroll="" class="global-radius icon_wrap effect-1 alignleft"><i class="fa fa-university" aria-hidden="true"></i></span>
					<p id="totallInvHtml" runat="server" class="stat_count1">0</p>
					<h3>USD</h3>
				</div><!-- end col -->
                <div class="col-md-4 col-sm-4 col-xs-12"></div>
			</div><!-- end row -->
		</div><!-- end container -->
	</div>





    <div id="pricing" class="section lb">
        <div class="container">
            <div class="section-title text-center">
                <h3>Investment plans</h3>
                <p class="lead">choose the right investment plan on <strong>Crypto tradings </strong> Make a double-benefit easily on digital currencies.<br />
                    Base currency for investment is <strong>USDT trc20</strong>
                </p>
            </div><!-- end title -->

            <hr class="invis">

            <div class="row">
                <div class="col-md-12">
                    <div class="tab-content">
                        <div class="tab-pane active fade in">
                            <div class="row text-center">
                                <div class="col-md-3">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 1</h2>
                                            
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>
                                                 <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                            </p>

                                        </div>
                                        <div class="pricing-table-features">
                                            <p>
                                                 <asp:Literal ID="Literal2" runat="server"></asp:Literal>

                                            </p>
                                        </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="plan.aspx?id=1" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              
                                <div class="col-md-3">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 2</h2>
                                           
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>
                                                <asp:Literal ID="Literal3" runat="server"></asp:Literal>

                                            </p>
                                        </div>
                                        <div class="pricing-table-features">
                                           <p>
                                                <asp:Literal ID="Literal4" runat="server"></asp:Literal>

                                           </p>
                                        </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="plan.aspx?id=2" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              
                                <div class="col-md-3">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 3</h2>
                                           
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p> <asp:Literal ID="Literal5" runat="server"></asp:Literal></p>
                                        </div>
                                        <div class="pricing-table-features">
                                          <p>
                                               <asp:Literal ID="Literal6" runat="server"></asp:Literal>

                                          </p>     </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="plan.aspx?id=3" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
                                        </div>
                                    </div>
                                </div>
                              
                                <div class="col-md-3">
                                    <div class="pricing-table pricing-table-highlighted">
                                        <div class="pricing-table-header grd1">
                                            <h2>Plan 4</h2>
                                         
                                        </div>
                                        <div class="pricing-table-space"></div>
                                        <div class="pricing-table-text">
                                            <p>
                                                 <asp:Literal ID="Literal7" runat="server"></asp:Literal>

                                            </p>
                                        </div>
                                        <div class="pricing-table-features">
                                           <p>
                                                <asp:Literal ID="Literal8" runat="server"></asp:Literal>

                                           </p>  </div>
                                        <div class="pricing-table-sign-up">
                                            <a href="plan.aspx?id=4" data-scroll="" class="btn btn-light btn-radius btn-brd grd1 effect-1">Investment</a>
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










    <div id="testimonials" class="parallax section db parallax-off" style="background-image: url(images/section5.jpg);background-position-y: 50px;">
        <div class="container">
            <div class="section-title text-center">
                <h3>News</h3>
                <p class="lead">review some recent News about crypto currencies</p>
            </div><!-- end title -->

            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <div id="rssNewsHtml" runat="server" class="testi-carousel owl-carousel owl-theme">

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

    
    <div class="section wb">
        <div class="container">
            <div class="section-title row text-center">
                <div class="col-md-8 col-md-offset-2">
                    <h3>Try your chance</h3>
                    <%--<p class="lead">Lorem Ipsum dolroin gravida nibh vel velit auctor aliquet. Aenean sollicitudin, lorem quis bibendum auctor, nisi elit consequat ipsum, nec sagittis sem!</p>--%>
                </div>
            </div><!-- end title -->
        
            <div class="row">
                <div class="col-md-12">
                    <div class="message-box">
                                                <h4>Make a big reward by trying your chance</h4>
                        <h2>Watch the movie and<br /> win 1 million$ </h2>
                           <asp:Literal ID="Literal9" runat="server"></asp:Literal>
                        <asp:Literal ID="Literal10" runat="server"></asp:Literal>
                            <style>
                                .gamble {
                                    text-align: center;
                                    margin: 5rem 0;
                                }

                                    .gamble ul {
                                        list-style: none;
                                    }

                                        .gamble ul li {
                                            display: inline-block;
                                            width: 5%;
                                            margin: 0 1.5rem;
                                            border: 1px solid;
                                            border-width: thick;
                                            overflow: hidden;
                                        }

                                    .gamble p {
                                        width: 100%;
                                        padding: 10px;
                                        font-size: 20px;
                                        font-weight: bold;
                                        text-align: center;
                                        position: relative;
                                        top: 0px;
                                        border: none;
                                        
                                        margin-bottom: 0;
                                    }
                                .jackpot-btn {
                                    margin: 0 auto;
                                    display: block;
                                    width: 20%;
                                }
                                video {
                                    width: 100%;
                                    height: auto;
                                }

                            </style>
                        <div class="gamble">
                            <ul>
                                <li><p id="txt1" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt2" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt3" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt4" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt5" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt6" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt7" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt8" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt9" runat="server" class="jackpot-input" jackpot="1">0</p></li>
                                <li><p id="txt10" runat="server" class="jackpot-input" jackpot="1">0</p></li>                                
                            </ul>
                        </div>


                        <a onclick="playVid()" data-toggle="modal" data-target="#myModal" href="javascript:void" data-scroll="" class="jackpot-btn btn btn-light btn-radius btn-brd grd1 effect-1">Jackpot</a>
                    </div><!-- end messagebox -->
                </div><!-- end col -->
            </div><!-- end row -->

            <hr class="invis"> 

            
          

            <hr class="hr3"> 

        
        </div><!-- end container -->
    </div><!-- end section -->

    <div id="review" class="parallax section db parallax-off" style="background-image:url('uploads/parallax_04.jpg');">
        <div class="container">
            <div class="section-title text-center">
                <h3>Customers review</h3>
                <p class="lead">We thanks for all our awesome customers! There are hundreds of our happy customers! <br>Let's see what others say about Crypto Trading Co.!</p>
            </div><!-- end title -->

            <div class="row">
                <div class="col-md-12 col-sm-12">
                    <div class="testi-carousel owl-carousel owl-theme">
                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Wonderful Support!</h3>
                                <p class="lead">Awsome service and they deposit my money excat in time. I am totally satified with the service I have recieved.</p>
                            </div>
                            <div class="testi-meta">
                                <img src="images/head1.png" alt="" class="img-responsive alignleft">
                                <h4>Sandra Fernando <small>- Customer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Various Services!</h3>
                                <p class="lead">Customer support was fufilling and I applied for another service after explanation. both plans I have are very good and I could make double my money in no time.</p>
                            </div>
                            <div class="testi-meta">
                                <img src="images/head2.png" alt="" class="img-responsive alignleft">
                                <h4>Jacques Philips <small>- Customer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Great & Talented Team!</h3>
                                <p class="lead">Something intersting about your website and your company is about the expertised staff, they lead customer kindly and hey go over details as much as customer needs.</p>
                            </div>
                            <div class="testi-meta">
                                <img src="images/head3.png" alt="" class="img-responsive alignleft">
                                <h4>Alexander Mercy <small>- Customer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->
                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> A good investment!</h3>
                                <p class="lead">They have good plans to make a amazing porfit. I just need to invest my money in somewhere that is trustworhty. They did. Thanks</p>
                            </div>
                            <div class="testi-meta">
                                <img src="images/head4.png" alt="" class="img-responsive alignleft">
                                <h4>Nina Smith <small>- Customer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> An easy way to make money!</h3>
                                <p class="lead">I have tried a couple of plans with other companies and unfortunetly some of them they did not respond in expected manner. They are very good in rapid and efficient response.</p>
                            </div>
                            <div class="testi-meta">
                                <img src="images/head5.png" alt="" class="img-responsive alignleft">
                                <h4>Martin Jacoub <small>- Customer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class="testimonial clearfix">
                            <div class="desc">
                                <h3><i class="fa fa-quote-left"></i> Seasoned advisers</h3>
                                <p class="lead">I took the consultant advise and I am really glad that I did. My money has became three times bigger. Thanks eveyone amazing job</p>
                            </div>
                            <div class="testi-meta">
                                <img src="images/head6.png" alt="" class="img-responsive alignleft">
                                <h4>Venanda Mercy <small>- Customer</small></h4>
                            </div>
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

    <!-- The video page -->
<div class="modal" id="myModal">
  <div class="modal-dialog">
    <div class="modal-content">

      <!-- Modal Header -->
      <div class="modal-header">
        <h4 class="modal-title">Header for video page</h4>
      </div>

      <!-- Modal body -->
      <div class="modal-body">
        <div class="col-6 col-s-9">
            <video id="myVideo">
                <source src="movies/lines2.mp4" type="video/mp4">
                <%--<source src="mov_bbb.ogg" type="video/ogg">--%>
                Your browser does not support HTML5 video.
            </video>
        </div>
      </div>

      <!-- Modal footer -->
      <div class="modal-footer">
          <%--<button id="jackpotClick" onclick="pauseVid()" type="button" class="btn btn-danger" data-dismiss="modal">Close</button>--%>


          <asp:Button ID="jackpotClick" ClientIDMode="Static" runat="server" Text="Close" OnClientClick="pauseVid()" class="btn btn-danger" OnClick="jackpotClick_Click1" />
      </div>
    </div>
  </div>
</div>

    <script>
        var vid = document.getElementById("myVideo");

        function playVid() {
            vid.src = "movies/lines2.mp4";
            vid.play();
        }

        function pauseVid() {
            vid.pause();
            vid.src = null;
        }
    </script>

    <script>
        function writeCookie(name, value, days) {
            var date, expires;
            if (days) {
                date = new Date();
                date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
                expires = "; expires=" + date.toGMTString();
            } else {
                expires = "";
            }
            document.cookie = name + "=" + value + expires + "; path=/";
        }

        var jackpot = document.getElementsByClassName("jackpot-input");

        document.getElementById("jackpotClick").addEventListener("click", setRanNum);

        function setRanNum() {



            //set the randome number
            var RanVal = 0;
            var number = "";
            for (var i = 0; i < jackpot.length; i++) {
                RanVal = Math.floor(Math.random() * 10)
                jackpot[i].innerHTML = RanVal;
                number += RanVal;
            }
            writeCookie("jackpotC", number, 1);

            //drag them down
            var pos = -35;
            var id2 = setInterval(
                function () {
                    frameDown();
                }, 5);

            function frameDown() {


                if (pos == 0) {
                    clearInterval(id2);
                } else {
                    pos++;
                    for (var i = 0; i < jackpot.length; i++) {
                        jackpot[i].style.top = pos + "px";
                    }
                }
            }
        }


    </script>
</asp:Content>