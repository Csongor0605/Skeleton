<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CsongorDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 613px">
            <asp:Label ID="Name" runat="server" Text="Name" width="138px"></asp:Label><asp:TextBox ID="NameTextBox" runat="server" style="z-index: 1; left: 171px; top: 14px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Email" runat="server" Text="Email" width="138px"></asp:Label><asp:TextBox ID="EmailTextBox" runat="server" style="z-index: 1; left: 170px; top: 57px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Password" runat="server" Text="Password" width="138px"></asp:Label><asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 170px; top: 102px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="PermissionLvl" runat="server" Text="Permission Level"></asp:Label><br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="z-index: 1; left: 173px; top: 137px; position: absolute; height: 28px; width: 96px">
                <asp:ListItem>Low</asp:ListItem>
                <asp:ListItem>Medium</asp:ListItem>
                <asp:ListItem>High</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 166px; top: 227px; position: absolute; height: 161px; width: 309px"></asp:Calendar>
            <asp:Label ID="StartDate" runat="server" Text="Start Date" width="138px"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 166px; top: 436px; position: absolute" />
            <br />
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 26px; top: 554px; position: absolute; width: 361px; height: 70px" Text="OK" />
            <asp:Label ID="OnSite" runat="server" Text="On Site?" width="138px" Height="18px" style="margin-top: 18px"></asp:Label>
        </div>
    </form>
</body>
</html>
