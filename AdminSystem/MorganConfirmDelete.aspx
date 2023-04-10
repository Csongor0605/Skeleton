<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MorganConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 194px; width: 744px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbl1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 294px" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 10px; top: 67px; position: absolute" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" OnClick="BtnNo_Click" style="z-index: 1; left: 72px; top: 67px; position: absolute" Text="No" />
    </form>
</body>
</html>
