<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staff.aspx.cs" Inherits="Air_Flight_Search.staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
            font-size: xx-large;
            color: #000099;
        }
        .auto-style3{
            background-color:powderblue;
        }
        .auto-style4 {
            color: #000000;
            font-size: large;
        }
        .auto-style4:link {color:#ff0000;}
.auto-style4:visited {color:#0000ff;}
.auto-style4:hover {background:#66ff66;}
        .auto-style5 {
            font-size: medium;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .myButton {
	-moz-box-shadow: 3px 4px 0px 0px #1564ad;
	-webkit-box-shadow: 3px 4px 0px 0px #1564ad;
	box-shadow: 3px 4px 0px 0px #1564ad;
	background:-webkit-gradient(linear, left top, left bottom, color-stop(0.05, #79bbff), color-stop(1, #378de5));
	background:-moz-linear-gradient(top, #79bbff 5%, #378de5 100%);
	background:-webkit-linear-gradient(top, #79bbff 5%, #378de5 100%);
	background:-o-linear-gradient(top, #79bbff 5%, #378de5 100%);
	background:-ms-linear-gradient(top, #79bbff 5%, #378de5 100%);
	background:linear-gradient(to bottom, #79bbff 5%, #378de5 100%);
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#79bbff', endColorstr='#378de5',GradientType=0);
	background-color:#79bbff;
	-moz-border-radius:5px;
	-webkit-border-radius:5px;
	border-radius:5px;
	border:1px solid #337bc4;
	display:inline-block;
	cursor:pointer;
	color:#ffffff;
	font-family:Arial;
	font-size:17px;
	font-weight:bold;
	text-decoration:none;
	text-shadow:0px 1px 0px #528ecc;
}
.myButton:hover {
	background:-webkit-gradient(linear, left top, left bottom, color-stop(0.05, #378de5), color-stop(1, #79bbff));
	background:-moz-linear-gradient(top, #378de5 5%, #79bbff 100%);
	background:-webkit-linear-gradient(top, #378de5 5%, #79bbff 100%);
	background:-o-linear-gradient(top, #378de5 5%, #79bbff 100%);
	background:-ms-linear-gradient(top, #378de5 5%, #79bbff 100%);
	background:linear-gradient(to bottom, #378de5 5%, #79bbff 100%);
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#378de5', endColorstr='#79bbff',GradientType=0);
	background-color:#378de5;
}
.myButton:active {
	position:relative;
	top:1px;
}

.myHome {
	-moz-box-shadow: 3px 4px 0px 0px #8a2a21;
	-webkit-box-shadow: 3px 4px 0px 0px #8a2a21;
	box-shadow: 3px 4px 0px 0px #8a2a21;
	background:-webkit-gradient(linear, left top, left bottom, color-stop(0.05, #c62d1f), color-stop(1, #f24437));
	background:-moz-linear-gradient(top, #c62d1f 5%, #f24437 100%);
	background:-webkit-linear-gradient(top, #c62d1f 5%, #f24437 100%);
	background:-o-linear-gradient(top, #c62d1f 5%, #f24437 100%);
	background:-ms-linear-gradient(top, #c62d1f 5%, #f24437 100%);
	background:linear-gradient(to bottom, #c62d1f 5%, #f24437 100%);
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#c62d1f', endColorstr='#f24437',GradientType=0);
	background-color:#c62d1f;
	-moz-border-radius:18px;
	-webkit-border-radius:18px;
	border-radius:18px;
	border:1px solid #d02718;
	display:inline-block;
	cursor:pointer;
	color:#ffffff;
	font-family:Arial;
	font-size:17px;
	text-decoration:none;
	text-shadow:0px 1px 0px #810e05;
}
.myHome:hover {
	background:-webkit-gradient(linear, left top, left bottom, color-stop(0.05, #f24437), color-stop(1, #c62d1f));
	background:-moz-linear-gradient(top, #f24437 5%, #c62d1f 100%);
	background:-webkit-linear-gradient(top, #f24437 5%, #c62d1f 100%);
	background:-o-linear-gradient(top, #f24437 5%, #c62d1f 100%);
	background:-ms-linear-gradient(top, #f24437 5%, #c62d1f 100%);
	background:linear-gradient(to bottom, #f24437 5%, #c62d1f 100%);
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#f24437', endColorstr='#c62d1f',GradientType=0);
	background-color:#f24437;
}
.myHome:active {
	position:relative;
	top:1px;
}
    </style>
</head>
<body class="auto-style3">
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        <strong>Staff menu</strong></div>
        <p class="auto-style1">
            <em>
            <asp:Label ID="Label1" runat="server" Text="Welcome, " CssClass="auto-style6"></asp:Label>
            </em>
        </p>
        <p class="auto-style1">
                     <em>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageUrl="~/Resources/flight-smalltabletRetina.jpg" OnClick="ImageButton1_Click" Width="300px" />
            <asp:ImageButton ID="ImageButton2" Height="300" Width="300" runat="server" ImageUrl="~/Resources/bed_balcony_table_chairs_view_hotel_room_39688_3840x2400.jpg" OnClick="ImageButton2_Click" />
            <asp:ImageButton ID="ImageButton3"  Height="300" Width="300" runat="server" ImageUrl="~/Resources/Blue-Sky-Sea-Beach-Hd-Desktop-Wallpaper.jpg" OnClick="ImageButton3_Click" />
            <asp:ImageButton ID="ImageButton4"  Height="300" Width="300" runat="server" ImageUrl="~/Resources/background_travel001.png" OnClick="ImageButton4_Click" />
            <asp:ImageButton ID="ImageButton5"  Height="300" Width="300" runat="server" ImageUrl="~/Resources/miniature-red-car-over-bulgaria-map-11376110.jpg" OnClick="ImageButton5_Click" />
            </em>
            </p>
        <p class="auto-style1">
            <strong>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AirFlight.aspx" CssClass="auto-style4">Air Flight</asp:HyperLink>
            </strong><span class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;
            </strong></span><strong>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Hotel.aspx" CssClass="auto-style4">Hotel</asp:HyperLink>
            </strong><span class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;
            </strong></span><strong>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Cruise.aspx" CssClass="auto-style4">Cruise Tour</asp:HyperLink>
            </strong><span class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;
            </strong></span><strong>
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Attraction.aspx" CssClass="auto-style4">Attraction</asp:HyperLink>
            </strong><span class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;
            </strong></span><strong>
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Transport.aspx" CssClass="auto-style4">Transportation</asp:HyperLink>
            </strong><span class="auto-style4"><strong>&nbsp;&nbsp;&nbsp;
            </strong></span><strong>
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Booking.aspx" CssClass="auto-style4">Booking</asp:HyperLink>
            </strong>
        </p>
        <p class="auto-style1">
            <asp:Button class="myHome" ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />
        </p>
        <p class="auto-style1">
            &nbsp;</p>
    </form>
</body>
</html>
