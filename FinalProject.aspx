<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="FinalProject.aspx.cs" Inherits="LandiLab4Se426.FinalProject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container"><!--{main wrapper}-->
    <div id="userData">
        <div class="panel panel-primary pnlBG">
            <div class="panel-heading">
                <h3>Get Directions</h3>
            </div>
            <div class="panel-body">
                <div id="pnlUserInput">
                    <!--{Input for start location}-->
                    <h4 class="text-right">Starting Address</h4>
                    <div class="form-group">
                        <label for="txtStreetAddress">Street Address</label>
                        <input id="txtStreetAddress" class="form-control" type="text" required="true"/>
                    </div>
                    <div class="form-group">
                        <label for="txtCity">City</label>
                        <input id="txtCity" class="form-control" type="text" required="true"/>
                    </div>
                    <div class="form-group">
                        <label for="txtState">State</label>
                        <input id="txtState" class="form-control" type="text" required="true"/>
                    </div>
                    <!--{End input for start location}-->
                    <hr/>
                    <!--{Input for destination location}-->
                    <h4 class="text-right">Destination Address</h4>
                    <div class="form-group">
                        <label for="txtDestStreetAddress">Street Address</label>
                        <input id="txtDestStreetAddress" class="form-control" type="text" required="true"/>
                    </div>
                    <div class="form-group">
                        <label for="txtDestCity">City</label>
                        <input id="txtDestCity" class="form-control" type="text" required="true"/>
                    </div>
                    <div class="form-group">
                        <label for="txtDestState">State</label>
                        <input id="txtDestState" class="form-control" type="text" required="true"/>
                    </div>
                    <hr/>  
                    <div class="center-block text-center">
                        <h3>Google Geocoding API</h3>
                        <p class="text-justify">
                            All of the API calls used in this app need the longitude and latitude added 
                            to the url request. The solution I came up with was to have the user enter in 
                            a starting point address and a ending point address.  Then use jquery to get the
                            values and pass them into the url string needed for geocoding which returns the 
                            longitude and latitude for both the start address and end address. Please run 
                            this app in IE only.  If you wish to run it in chrome you will need to download
                            the plugin <a href="https://chrome.google.com/webstore/detail/allow-control-allow-origi/nlfbmbojpeacfghkpbjhddihlkkiljbi?hl=en">CORS</a>
                            from the chrome web store. 

                        </p>
                        <p>
                        <a href="#geoApi" role="button" data-toggle="modal" title="Source Code"><i class="fa fa-file-code-o fa-4x"></i></a>
                        </p>
                    </div>                
                    <div class="form-group">

                        <input id="btnGetUserInfo" class="btn-success" type="button" value="Get Directions";/>
                        <input id="loadExampleData" class="btn-success" type="button" value="Example Data";/>
                    </div>
                    <!--{End input for destination location}-->
                </div><!--{end pnlUserInput}-->
            </div><!--{end panel body}-->
        </div><!--{end panel}-->
    </div><!--{End userData}-->

    <div id="displayResults">
        <div class="panel panel-primary displayBG">
            <div class="panel-heading">
                <h3>Display Results</h3>
            </div>
            <div class="panel-body">
                <div id="results">
                    <div class="row"><!--{generate googlemap with pin point}-->
                        <div class="col-md-7">
                            <div id="googleMap">

                            </div>
                        </div>
                        <div class="col-md-5">
                            <h4>Google AJAX API framework</h4>
                            <p>
                                This is an example of using googles AJAX API Loader which provides a set of javascript 
                                functions that you pass parameteres to. This map is showing the destination 
                                location that was entered by the user. I have also added a marker to the map
                                that when clicked on will display the address for the targeted location. 

                            </p>
                            <p>
                                <a href="#ajaxApi" role="button" data-toggle="modal" title="Source Code"><i class="fa fa-file-code-o fa-4x"></i></a>
                            </p>

                        </div>
                    </div><!--{end generate googlemap with pin point}-->
                    <div class="row"><!--{generate googlemap streetview}-->
                        <div class="col-md-7">
                            <div id ="street">

                            </div>
                        </div>
                        <div class="col-md-5">
                            <h4>Google Street View Image API</h4>
                            <p>
                                For this example I am using googles Image view API to display thea street view of 
                                the destination that was determined by the users input.  The api itself is one of the
                                less complex ones that google offers.  To generate the image all you need to do is add 
                                the latitude and longitude, and the size you wish to display to the url request.
                            </p>
                            <p>
                                <a href="#streetApi" role="button" data-toggle="modal" title="Source Code"><i class="fa fa-file-code-o fa-4x"></i></a>
                            </p>
                        </div>
                    </div><!--{end generate googlemap streetview}-->
                    <div class="row"><!--{generate googlemap directions}-->
                        <div class="col-md-7">
                            <h3>Direction to your destination</h3>                           
                            <ul id="directions">

                            </ul>
                            <hr/>
                            <h3>Turn by Turn</h3>
                            <ul id="turnByTurn">

                            </ul>
                        </div>
                        <div class="col-md-5">
                            <h4>Google Directions API</h4>
                            <p>In this last example I am working with googles directions API inorder to display
                               turn by turn directions based on the users input of their starting location and ending 
                               location. The url requirments: lat + lng  and your api key. 
                            </p>
                            <p>
                                <a href="#directionsApi" role="button" data-toggle="modal" title="Source Code"><i class="fa fa-file-code-o fa-4x"></i></a>
                            </p>
                            <p class="getSpace">
                                <a href="https://developers.google.com/maps/documentation/webservices/" target="_blank" title="google api site"><img src="img/gIcon.png" alt="" class="img-responsive center-block" /></a>
                            </p>
                        </div>
                    </div><!--{end generate googlemap directions}-->
                </div><!--{end results}-->
            </div><!--{end panel body}-->
        </div><!--{end panel}-->
    </div><!--{End displayResults}-->
</div><!--{end main wrapper}-->
<!--{Page Modals}-->
<div id="geoApi" class="modal fade">
    <div class="modal-dialog modal-lg">
        <div class="modal-content text-justify help">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Source Code: GeoCoding API</h4>
            </div>
            <div class="modal-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="center-block">
                          <img src="img/geoapiCode.png" alt="" class="img-responsive center-block" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div id="ajaxApi" class="modal fade">
    <div class="modal-dialog modal-lg">
        <div class="modal-content text-justify help">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Source Code: Directions API</h4>
            </div>
            <div class="modal-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="center-block">
                          <img src="img/ajaxapiCode.png" alt="" class="img-responsive center-block" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div id="streetApi" class="modal fade">
    <div class="modal-dialog modal-lg">
        <div class="modal-content text-justify help">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Source Code: Street View Image API</h4>
            </div>
            <div class="modal-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="center-block">
                            <img src="img/streetapiCode.png" alt="" class="img-responsive center-block" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div id="directionsApi" class="modal fade">
    <div class="modal-dialog modal-lg">
        <div class="modal-content text-justify help">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Source Code: Directions API</h4>
            </div>
            <div class="modal-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="center-block">
                          <img src="img/dirapiCode.png" alt="" class="img-responsive center-block" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
