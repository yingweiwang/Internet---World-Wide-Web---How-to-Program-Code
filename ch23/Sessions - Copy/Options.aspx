<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Options.aspx.vb" Inherits="Options" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sessions</title>
    <style type="text/css">
       .labelStyle
       {
          font-weight: bold;
          font-size: large;
       }
       .labelStyle
       {
          font-size: large;
          font-weight: bold;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:Label ID="promptLabel" runat="server" CssClass="labelStyle" 
          Text="Select a programming language:"></asp:Label>
       <br />
       <asp:RadioButtonList ID="languageList" runat="server">
          <asp:ListItem>Visual Basic</asp:ListItem>
          <asp:ListItem>Visual C#</asp:ListItem>
          <asp:ListItem>C</asp:ListItem>
          <asp:ListItem>C++</asp:ListItem>
          <asp:ListItem>Java</asp:ListItem>
       </asp:RadioButtonList>
       <br />
       <asp:Button ID="submitButton" runat="server" Text="Submit" />
       <asp:Label ID="responseLabel" runat="server" CssClass="labelStyle" 
          Text="Welcome to Sessions!" Visible="False"></asp:Label>
       <br />
       <asp:Label ID="idLabel" runat="server" Visible="False"></asp:Label>
       <br />
       <asp:Label ID="timeoutLabel" runat="server" Visible="False"></asp:Label>
       <br />
       <asp:HyperLink ID="languageLink" runat="server" NavigateUrl="~/Options.aspx" 
          Visible="False">Click here to choose another language</asp:HyperLink>
       <br />
       <asp:HyperLink ID="recommendationsLink" runat="server" 
          NavigateUrl="~/Recommendations.aspx" Visible="False">Click here to get book recommendations</asp:HyperLink>
       <br />
    
    </div>
    </form>
</body>
</html>
