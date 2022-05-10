<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?</div>
        <asp:Button ID="YesButton" runat="server" OnClick="YesButton_Click" Text="Yes" />
        <asp:Button ID="NoButton" runat="server" OnClick="NoButton_Click" Text="No" />
    </form>
</body>
</html>
