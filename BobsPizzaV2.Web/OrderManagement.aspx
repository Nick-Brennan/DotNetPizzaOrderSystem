﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="BobsPizzaV2.Web.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>Order Management</h1>
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-responsive table-condensed" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" Text="Completed" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>

    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
