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
        <asp:Label ID="FilterLbl" runat="server" Text="Filter by name" style="position:absolute; height: 22px; width: 216px; top: 47px; left: 871px;"></asp:Label>
        <asp:Button ID="filterApplyBtn" runat="server" Text="Apply Filter" style="position:absolute; top: 126px; left: 871px; height: 57px; width: 254px;" OnClick="filterApplyBtn_Click"/>
        <asp:TextBox ID="TextBox1" runat="server" style="position:absolute; top: 83px; left: 871px; width: 242px;"></asp:TextBox>
        <p>
            <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" Text="Add" style ="margin:10px"/>
            <asp:Button ID="editBtn" runat="server" Text="Edit" style="margin:10px" OnClick="editBtn_Click"/>
            <asp:Button ID="deleteBtn" runat="server" Text="Delete" style="margin:10px" OnClick="deleteBtn_Click" />
        </p>
        <asp:Label ID="errLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
