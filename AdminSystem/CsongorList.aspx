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
        <p>
            <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" Text="Add" style ="margin-right:10px"/>
            <asp:Button ID="editBtn" runat="server" Text="Edit" style="margin-left:10px" OnClick="editBtn_Click"/>
        </p>
        <asp:Label ID="errLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
