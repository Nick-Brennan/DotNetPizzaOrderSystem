<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="success.aspx.cs" Inherits="BobsPizzaV2.Web.success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="page-header">
                <h1>Success</h1>
            <p class="lead">Your order has been placed!</p>
        </div>
        <p>&nbsp</p>
        <asp:Button ID="returnButton" runat="server" Text="Return to Order Page" CssClass="btn btn-lg btn-success " OnClick="returnButton_Click"/>
    </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
