$(document).ready(function () {
    //set global vars for googlemap
    var dest_latitude;
    var dest_longitude;
    $("#btnGetUserInfo").click(function (event) {
        //create url for starting cordinates
        var server = "https://maps.googleapis.com/maps/api/geocode/json?";
        var api_key = "&key=AIzaSyDy5UGJU8Npp5eBXNEo6IMC9OvAqfw7X78";
        var tempStr = form1.txtStreetAddress.value;
        var address = tempStr.replace(" ", "+");
        var city = "+" + form1.txtCity.value;
        var state = "+" + form1.txtState.value;
        var method = "address=";
        var url = server + method + address + city + state + api_key;
        console.log('url query 1:' + url);
        
        //create url for destination cordinates
        var tempDestStr = form1.txtDestStreetAddress.value;
        var cityDest = "+" + form1.txtDestCity.value;
        var stateDest = "+" + form1.txtDestState.value;
        var addressDest = tempDestStr.replace(" ", "+");
        var urlDest = server + method + addressDest + cityDest + stateDest + api_key;
        console.log('url query 2:' + urlDest);

        //get json from first url string 
        $.getJSON(url)
        .done(function (data) {               
            var start_latitude = parseFloat(data.results[0].geometry.location.lat);
            var start_longitude = parseFloat(data.results[0].geometry.location.lng);
            sessionStorage.startLat = parseFloat(data.results[0].geometry.location.lat);
            sessionStorage.startLng = parseFloat(data.results[0].geometry.location.lng);
            console.log(data.results[0].geometry.location.lat);
            console.log(data.results[0].geometry.location.lng);
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            console.log('error:' + textStatus);
        });

        //get json from second url string       
        $.getJSON(urlDest)
        .done(function (destData) {
            dest_latitude = parseFloat(destData.results[0].geometry.location.lat);
            dest_longitude = parseFloat(destData.results[0].geometry.location.lng);
            sessionStorage.destLat = parseFloat(destData.results[0].geometry.location.lat);
            sessionStorage.destLng = parseFloat(destData.results[0].geometry.location.lng);
            configMap();
            getStreetView();
            console.log(dest_latitude);
            console.log(destData.results[0].geometry.location.lng);
            
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            console.log('error:' + textStatus);
        });
        /*
            generate street view
            This function creates the url needed for the api call and then 
            appends the generated image to the street div within the html. 
            The function gets called within the main document ready event. 
        */
        function getStreetView() {
            var api_key = "&key=AIzaSyDy5UGJU8Npp5eBXNEo6IMC9OvAqfw7X78";
            var params = 'location=' + dest_latitude + ',' + dest_longitude;
            var urlStr = 'https://maps.googleapis.com/maps/api/streetview?size=530x300&'+ params + api_key;
            $('<img style="-webkit-user-select: none;"' + 'src="' + urlStr + '">').appendTo('#street');
        }

        //generate google map with pin point 
        function configMap() {
            /*
                Create new map obj that include latitude and longitude.
                Sets the display type to hybrid which is a aerial view
                in combiation with terrain view 

            */
            var settings = {
                zoom: 15,
                //strings for lat and lng must be converted to float data type 
                center: new google.maps.LatLng(dest_latitude, dest_longitude),
                mapTypeId: google.maps.MapTypeId.HYBRID
            };
            /*
             This Section will define where the map should be displayed and set
             pin drop marker location on map
            */
            var googleMap = document.getElementById('googleMap');

            var map = new google.maps.Map(googleMap, settings);
            google.maps.event.addListenerOnce(map, 'idle', function () {
                google.maps.event.trigger(map, 'resize');
                map.setCenter(marker.getPosition());
            });
            /*
             In this section the drop pin on the map pramas are set to the users
             lng and lat. 
            */
            var markerCoords = new google.maps.LatLng(dest_latitude, dest_longitude);
            var marker = new google.maps.Marker({
                position: markerCoords,
                map: map,
                title: "address"
            });
            var markerContent = tempDestStr + " " + cityDest + " " + stateDest;
            var infoWindow = new google.maps.InfoWindow({
                content: markerContent
            });
            /*
              The Map is generated on page load 
            */
            google.maps.event.addListener(marker, 'click', function () {
                infoWindow.open(map, marker);
            });
            getDirections();
        }
    
    });

    $("#loadExampleData").click(function (event) {
        var startStreet = 'One New England Tech Boulevard'
        var startCity = 'East Greenwich';
        var startState = 'RI';
        var destStreet = '456 Main Street';
        var destCity = 'Wakefield';
        var destState = 'RI';

        form1.txtStreetAddress.value = startStreet.toString();
        form1.txtCity.value = startCity.toString();
        form1.txtState.value = startState.toString();
        form1.txtDestStreetAddress.value = destStreet.toString();
        form1.txtDestCity.value = destCity.toString();
        form1.txtDestState.value = destState.toString();

    });    
});
//Gets json data from googlemaps directions api
/*
    Sets the values for the url. Gets json data obj and then loops through
    the data selecting the set key value pairs. 
*/
function getDirections() {
    var server = "https://maps.googleapis.com/maps/api/directions/json?";
    var api_key = "&key=AIzaSyDy5UGJU8Npp5eBXNEo6IMC9OvAqfw7X78";
    var origin = "origin=" + sessionStorage.startLat + "," + sessionStorage.startLng;
    var destination = "&destination=" + sessionStorage.destLat + "," + sessionStorage.destLng;
    var url = server + origin + destination + api_key;
    console.log('url query directions:' + url);

    $.getJSON(url)
    .done(function (data) {
        $("<li>" + "Start:  " + data.routes[0].legs[0].start_address + "</li>").appendTo('#directions');
        $("<li>" + "End:  " + data.routes[0].legs[0].end_address + "</li>").appendTo('#directions');
        $("<li>" + "Distance:  " + data.routes[0].legs[0].distance.text + "</li>").appendTo('#directions');
        $("<li>" + "ETA:  " + data.routes[0].legs[0].duration.text + "</li>").appendTo('#directions');

        for (var i = 0; i < data.routes[0].legs[0].steps.length; i++) {
            $("<li>" + data.routes[0].legs[0].steps[i].html_instructions + "</li><hr/>").appendTo('#turnByTurn');
        }
    })
    .fail(function (jqXHR, textStatus, errorThrown) {
        console.log('error:' + textStatus);
    });

}