<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Challenge3.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" method="POST" class="form-horizontal">
            <div class="form-group">
                <asp:Label runat="server" Text="First Name" AssociatedControlID="FirstName" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox runat="server" Text="" ID="FirstName" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Last Name" AssociatedControlID="LastName" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox runat="server" Text="" ID="LastName" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="City" AssociatedControlID="City" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox runat="server" Text="" ID="City" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="State" AssociatedControlID="State" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox runat="server" Text="" ID="State" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Age" AssociatedControlID="Age" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox runat="server" Text="" TextMode="Number" ID="Age" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Phone" AssociatedControlID="Phone" CssClass="col-sm-2 control-label" />
                <div class="col-sm-10">
                    <asp:TextBox runat="server" Text="" TextMode="Phone" ID="Phone" CssClass="form-control" />
                </div>
            </div>
            <p>
                <asp:HiddenField runat="server" ID="PageNum" Value="Page1" />
            </p>
            <p>
                <asp:Button runat="server" ID="submitButton" Text="Go to Page 2!" PostBackUrl="~/Page2.aspx" CssClass= "btn btn-primary pull-right"/>
            </p>
        </form>
    </div>
</body>
</html>
