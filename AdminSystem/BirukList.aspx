<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BirukList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 35px; position: absolute; height: 330px; width: 571px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 13px; top: 381px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 60px; top: 383px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 508px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 111px; top: 383px; position: absolute" Text="Delete" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 164px; top: 435px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEnterEmail" runat="server" style="z-index: 1; left: 14px; top: 436px; position: absolute" Text="Enter a customer email"></asp:Label>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 9px; top: 466px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 78px; top: 464px; position: absolute; height: 26px" Text="Clear" />
    </form>
</body>
</html>
