<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="709px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged" Width="689px"></asp:ListBox>
        </div>
        <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add" />
        <asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" />
        <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

    </form>
</body>
</html>
