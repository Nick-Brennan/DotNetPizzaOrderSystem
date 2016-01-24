<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BobsPizzaV2.Web.Default" %>

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
            <h1>Papa Bob's Pizza: The Reboot</h1>
            <p class="lead">Fuel For the Fire</p>
        </div>

        <div class="form-group">
            <label>Size:</label>
            <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged ="sizeDropDownList_SelectedIndexChanged">
                <asp:ListItem>Choose one...</asp:ListItem>
                <asp:ListItem Value="Small">Small (12&quot; - $12)</asp:ListItem>
                <asp:ListItem Value="Medium">Medium (14&quot; - $14)</asp:ListItem>
                <asp:ListItem Value="Large">Large (16&quot; - $16)</asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <label>Crust:</label>
            <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="sizeDropDownList_SelectedIndexChanged">
                <asp:ListItem>Choose one...</asp:ListItem>
                <asp:ListItem>Regular</asp:ListItem>
                <asp:ListItem>Thin</asp:ListItem>
                <asp:ListItem Value="Thick">Thick (+$2)</asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="sizeDropDownList_SelectedIndexChanged"/>Sausage</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="sizeDropDownList_SelectedIndexChanged"/>Pepperoni</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="sizeDropDownList_SelectedIndexChanged"/>Onions</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="sizeDropDownList_SelectedIndexChanged"/>Green Peppers</label></div>

        <h3>Deliver To:</h3>

        <div class="form-group">
            <label>Name:</label>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Address:</label>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Zip:</label>
            <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Phone:</label>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <h3>Payment:</h3>

        <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="paymentGroup" Checked="true"/>Cash</label></div>
        <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="paymentGroup"/>Credit</label></div>

        <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-primary" OnClick="orderButton_Click" />
        <br />
        <br />
        <asp:Label ID="warningLabel" runat="server" CssClass="bg-danger"></asp:Label>
        <br />
        <h3>Total Cost: <asp:Label ID="priceLabel" runat="server" Text=""></asp:Label></h3>
        <p>&nbsp</p>
    </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
