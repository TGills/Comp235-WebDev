<%@ Page Language="VB" AutoEventWireup="false" CodeFile="JQueary Map.aspx.vb" Inherits="JQuery_JQueary_Map" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GoMap Demo</title>
 
<script type="text/javascript" src="http://maps.google.com/maps/api/js?key=AIzaSyAwKXz9qponlbTLNtiSSMw49mBpTyJWhdY&sensor=false"></script> 
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
<script type="text/javascript" src="js/jquery.gomap-1.3.3.min.js"></script> 
<style> 
/* Map */ 
#map { 
    width:700px; 
    height:400px; 
} 

</style> 

    <script>
        $(document).ready(function () {
            $("#map").goMap(
                {
                    latitude: 51.8,
                    longitude: -105.6,
                    zoom: 6
                });

            $.goMap.createMarker({
                latitude: 50.3196,
                longitude: -105.5349,
                id: 'Moose Jaw'
            })
               
        });
    </script>

</head>
<body>
  
    <div id="map">
    
    </div>
    <span class="coord">56.94x24.7</span>
    <span class="coord">60.94x30.7</span>
    
</body>
</html>
