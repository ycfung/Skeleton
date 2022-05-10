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
        <br />
        <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add" />
        <asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" />
        <asp:Button ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" Text="Delete" />
        <br /><br />
        <asp:Label ID="lblFilterType" runat="server" Text="Enter a type"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <br />
        <p>
        <asp:Button ID="ApplyButton" runat="server" OnClick="ApplyButton_Click" Text="Apply" />
        <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" />
        </p>
        <br />
        <p>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

        </p>

    </form>
</body>
</html>
