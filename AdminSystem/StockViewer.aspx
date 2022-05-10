<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="StockViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="AddStockButton" runat="server" OnClick="AddStockButton_Click" Text="Add Stock" />
        </div>
    </form>
</body>
</html>
