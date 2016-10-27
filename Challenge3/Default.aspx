<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="POST">
        <div>
            <p>
                <asp:Label runat="server" Text="First Name"></asp:Label>
                <asp:TextBox runat="server" Text="" ID="FirstName"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox runat="server" Text="" ID="LastName"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="City"></asp:Label>
                <asp:TextBox runat="server" Text="" ID="City"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="State"></asp:Label>
                <asp:TextBox runat="server" Text="" ID="State"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="Age"></asp:Label>
                <asp:TextBox runat="server" Text="" TextMode="Number" ID="Age"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" Text="Phone"></asp:Label>
                <asp:TextBox runat="server" Text="" TextMode="Phone" ID="Phone"></asp:TextBox>
            </p>
            <p><asp:Button runat="server" ID="submitButton" Text="Go to Page 2!" OnClick="submitButton_OnClick"/></p>
        </div>
    </form>
</body>
</html>
