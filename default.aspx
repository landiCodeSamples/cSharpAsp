<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LandiLab4Se426._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content> 

 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!--{Page Content}...................................................................-->
<section id="defPageWrapper">
    <div class="row">
        <div class="col-md-12">
            <div class="page-header">
                <div class="row">
                    <div class="col-md-12">
                        <h3>SE426 Web Services</h3>
                        <p>
                            David Landi<br/>
                            NEIT 2014<br/>
                            Instructor: Bruce Ganek<br/>
                            Lab Assignments
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div id="slideShow" class="carousel carouselSize center-block">
                <ol class="carousel-indicators">
                    <li data-target="#slideShow" data-slide-to = "1"></li>
                    <li data-target="#slideShow" data-slide-to = "2"></li>
                    <li data-target="#slideShow" data-slide-to = "3"></li>
                    <li data-target="#slideShow" data-slide-to = "4"></li>
                    <li data-target="#slideShow" data-slide-to = "5"></li>
                </ol>
                <center>
                    <div class="carousel-inner">
                        <div class="item active">
                            <img src="../img/lab2Img.png" alt="" class="img-responsive carouselSize ">
                        </div>
                        <div class="item">
                            <img src="../img/lab2Img.png" alt="" class="img-responsive carouselSize">
                        </div>
                        <div class="item">
                            <img src="../img/lab4Img.png" alt="" class="img-responsive carouselSize">
                        </div>
                        <div class="item">
                            <img src="../img/lab4a.png" alt="" class="img-responsive carouselSize">
                        </div>
                        <div class="item">
                            <img src="../img/lab4Img.png" alt="" class="img-responsive carouselSize">
                        </div>
                    </div>
                </center>
                <a class="carousel-control left" href="#slideShow" data-slide="prev">
                <span class="icon-prev"></span></a>
                <a class="carousel-control right" href="#slideShow" data-slide="next"> 
                <span class="icon-next"></span></a>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="infoSection center-block">
                <h3>Course Description</h3>
                <p>
                    Students will learn how to design and build web services using the .NET framework.<br/> 
                    The course covers an introduction to web services as well as topics such as XPath, <br/>
                    Web Services Description Language (WSDL), JSON and Windows Communication Foundation
                </p>
                <hr/>
                <h3>Course Outcomes</h3>
                <p>
                    Create and parse XML documents to store data and easily retrieve data.<br/>
                    Understand what a web service is and the basic components of a web service.<br/>
                    Create a basic web service.<br/>
                    Use various techniques to access web services.<br/>
                    Create a web service using Windows Communication Foundation (WCF)<br/>
                    Explain and document their code and projects.<br/>
                </p>
                <hr/>
                <h3>Purpose for this webapp</h3>
                <p>
                    I started to present my labs this way early in the Assocaites degree program because<br/>
                    I wanted to get the most out of every class that I could. The goal I set for myself<br/>
                    when deciding to make a career change, was to land a job as a software engineer without<br/>
                    needing to intern or finish my bacholers degree first so I figured that having code samples<br/>
                    was something that would help me accomplish this.  I strongly believe that the effort I put<br/>
                    into doing this was the key reason why I was able to successfully fufilling my goal. 
                </p>
            </div>
        </div>
    </div>
</section>

<!--{End Page Content}...............................................................--> 

<!--{Modal Popups}...................................................................-->
<div class="modal-body">
    <div class="row">
        <div class="col-md-12">
            <div class="center-block">
                <p>
                </p>  
            </div>
        </div>
    </div>
</div>
<!--{End Modal Popups}...............................................................-->
</asp:Content>

