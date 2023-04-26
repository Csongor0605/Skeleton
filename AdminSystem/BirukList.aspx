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
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 425px; width: 629px"></asp:ListBox>
    </form>
</body>
</html>
