﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Challenge3.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField runat="server" Value="" ID="CityHF"></asp:HiddenField>
        <asp:HiddenField runat="server" Value="" ID="StateHF"/>
        <asp:Button runat="server" ID="pageThreeButton" Text="To Page 3" CssClass="btn btn-primary btn-block"/>
    </div>
    </form>
</body>
</html>
