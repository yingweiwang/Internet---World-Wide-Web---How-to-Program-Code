<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WebTime.aspx.vb" Inherits="WebTime" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A Simple Web Form Example</title>
    <style type="text/css">
        .timeStyle
        {
            font-size: xx-large;
            color: #FFFF00;
            background-color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" title="A Simple Web Form Example">
    <div title="A Simple Web Form Example">
    
        <h2>
            Current time on the Web server:</h2>
        <p>
            <asp:Label ID="timeLabel" runat="server" CssClass="timeStyle"></asp:Label>
        </p>
        <h2>
            &nbsp;</h2>
    
    </div>
    </form>
</body>
</html>
