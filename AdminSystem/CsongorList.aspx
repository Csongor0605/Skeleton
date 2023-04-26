<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CsongorList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="staffListBox" runat="server" Height="535px" Width="834px"></asp:ListBox>
        <asp:Label ID="OnSiteLbl" runat="server" Text="On Site?" style="position:absolute; height: 25px; width: 87px; top: 75px; left: 1020px;"></asp:Label>
        <asp:RadioButtonList ID="permissionsList" runat="server" style="position:absolute; top: 106px; left: 869px;">
                <asp:ListItem>Low</asp:ListItem>
                <asp:ListItem>Medium</asp:ListItem>
                <asp:ListItem>High</asp:ListItem>
                <asp:ListItem>Any</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RadioButtonList ID="OnSiteList" runat="server" style="position:absolute; top: 106px; left: 1020px;">
                <asp:ListItem>On Site</asp:ListItem>
                <asp:ListItem>Remote</asp:ListItem>
                <asp:ListItem>Any</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="FilterLbl" runat="server" Text="Filter by" style="position:absolute; height: 22px; width: 68px; top: 38px; left: 869px;"></asp:Label>
        <asp:Label ID="PermissionsLbl" runat="server" Text="Permissions" style="position:absolute; top: 75px; left: 869px;"></asp:Label>
        <asp:Button ID="filterApplyBtn" runat="server" Text="Apply Filter" style="position:absolute; top: 240px; left: 869px; height: 57px; width: 254px;" OnClick="filterApplyBtn_Click"/>
        <p>
            <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" Text="Add" style ="margin:10px"/>
            <asp:Button ID="editBtn" runat="server" Text="Edit" style="margin:10px" OnClick="editBtn_Click"/>
            <asp:Button ID="deleteBtn" runat="server" Text="Delete" style="margin:10px" OnClick="deleteBtn_Click" />
        </p>
        <asp:Label ID="errLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
