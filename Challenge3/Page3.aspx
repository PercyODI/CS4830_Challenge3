<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="Challenge3.Page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>

    <div>
        <div class="container">
            <div class="row col-sm-8 col-sm-offset-2">
                <table class="table table-bordered">
                    <tr>
                        <td>First Name</td>
                        <td runat="server" id="FirstNameTD"></td>
                    </tr>
                    <tr>
                        <td>Last Name</td>
                        <td runat="server" id="LastNameTD"></td>
                    </tr>
                    <tr>
                        <td>City</td>
                        <td runat="server" id="CityTD"></td>
                    </tr>
                    <tr>
                        <td>State</td>
                        <td runat="server" id="StateTD"></td>
                    </tr>
                    <tr>
                        <td>Age</td>
                        <td runat="server" id="AgeTD"></td>
                    </tr>
                    <tr>
                        <td>Phone Number</td>
                        <td runat="server" id="PhoneTD"></td>
                    </tr>
                </table>
            </div>
    </div>
    </div>
    
</body>
</html>
