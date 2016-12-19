<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JQuery1.aspx.cs" Inherits="JQuery.JQuery_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#hideStuff").click(function () {
                $("p").hide();
            });
            $("#showStuff").click(function () {
                $("p").show();
            });
             $("#Show").click(function () {
                 $("#missingLink").show(3000).slideup(2000).slidedown(2000);
             });
        });




    </script>
</head>



<body>
   
    <div>
        <h2>This is a heading</h2>
        <p>This is a paragraph.</p>
        <p>This is another paragraph.</p>
        <button id="hideStuff">Hide</button>  
        <button id="showStuff">Show</button>  
        <hr />
    </div>    
    <div>
        1.	Write a jQuery function that displays a hidden link when a paragraph is clicked.  The paragraph should have an id of “show” and the link an id of ”hiddenLink”.  Use the show() function.
        <hr />
    </div>
    <div>
        2.	Change show() to fadein(3000);
        <hr />
    </div>
    <div>
        3.	Change the methods with show(3000).slideup(2000).slidedown(2000) (this is method chaining)
        <hr />
    </div>
    <div>
        <p id="Show">Secret Stuff</p>
    </div>
    <div>
        <a id="missingLink" style="display:none" href="https://www.reddit.com/">Reddit</a>
    </div>







</body>

</html>