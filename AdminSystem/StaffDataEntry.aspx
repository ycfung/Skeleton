<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 436px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" Text="Staff ID" width="78px"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblStaffName" runat="server" Text="Name" width="78px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffUsername" runat="server" BorderStyle="None" EnableTheming="True" Text="Username" width="78px"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffPassword" runat="server" Text="Password" width="78px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffSalary" runat="server" Text="Salary" width="78px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffRole" runat="server" Text="Role" width="78px"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffDateAdded" runat="server" Text="Date Added" width="78px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkStaffMngr" runat="server" Text="Manager" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
