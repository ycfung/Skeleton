<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<script runat="server">

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblID" runat="server" Text="ID" width="88px"></asp:Label>
        <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
        <asp:Button ID="FindButton" runat="server" OnClick="Find_Click" Text="Find" />
        <p>
        <asp:Label ID="lblName" runat="server" Text="Name" width="88px"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="88px"></asp:Label>
            <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblType" runat="server" Text="Type" width="88px"></asp:Label>
            <asp:TextBox ID="TextBoxType" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblRemark" runat="server" Text="Remark" width="88px"></asp:Label>
            <asp:TextBox ID="TextBoxRemark" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblModifyTime" runat="server" Text="Modify Time"></asp:Label>
            <asp:TextBox ID="TextBoxTime" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Availablity" runat="server" Text="Available" />
        </p>
        <p>
            <asp:Button ID="ButtonSubmit" runat="server" OnClick="Submit" OnClientClick="onSubmit" Text="Submit" />
            <asp:Button ID="BackButton" runat="server" OnClick="GoBack" Text="Go Back" />
        </p>
    </form>
</body>
</html>
