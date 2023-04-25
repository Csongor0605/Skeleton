<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CsongorConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="confirmationLabel" runat="server" Text="Are you sure you wish to delete this record?"></asp:Label>
        </div>
        <p>
            <asp:Button ID="yesBtn" runat="server" Text="Yes" style="margin:10px" OnClick="yesBtn_Click" />
            <asp:Button ID="noBtn" runat="server" Text="No" style="margin:10px" OnClick="noBtn_Click" />
        </p>
    </form>
</body>
</html>
