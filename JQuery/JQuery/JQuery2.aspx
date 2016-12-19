<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JQuery2.aspx.cs" Inherits="JQuery.JQuery2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script>
        var sat = "Life is good";
        var sun = "Stay home today";
        var now = new Date().getDay();
        $(document).ready(function () {
            // jQuery methods go here...
            $("#Monday").click(function () {                
                //Reading from text file
                $.get("Horoscope/Monday.txt", function(h, status){$("#horoscope").html(h);
                $("#horoscope").html(h);
                });
            
            });
            $("#Saturday").click(function () {
                $("#horoscope").html(sat)
            });
            $("#Sunday").click(function () {
                $("#horoscope").html(sun) 
            });           
            $.get("Horoscope/" + now + ".txt", function (h, status) {
                $("#dailyHoroscope").html(h);
            });
        });
    </script>
</head>
<body>    
    <div id="Saturday">Saturday </div>
    <div id="Sunday">Sunday</div>
    <div id="Monday">Monday </div>
    <hr />
    <div id="horoscope"></div>
    <hr />        
    <div>Today's horoscope:<div id="dailyHoroscope"></div></div>   
</body>
</html>
