<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BirukConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-bottom: 88px">
            Are you sure you want to delete this record?<br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 79px; top: 91px; position: absolute" Text="No" />
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 14px; top: 90px; position: absolute" Text="Yes" />
    </form>
</body>
</html>
