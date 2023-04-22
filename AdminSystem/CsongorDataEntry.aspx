<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CsongorDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 613px">
            <asp:Label ID="Name" runat="server" Text="Name" width="138px"></asp:Label><asp:TextBox ID="NameTextBox" runat="server" style="z-index: 1; left: 169px; top: 14px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Login" runat="server" Text="Login ID" width="79px"></asp:Label><asp:TextBox ID="LoginIDBox" style="z-index: 1; left: 169px; top: 50px; position: absolute" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Find" style="position: absolute"/>
            <br />
            <br />
            <asp:Label ID="Email" runat="server" Text="Email" width="138px"></asp:Label><asp:TextBox ID="EmailTextBox" runat="server" style="z-index: 1; left: 169px; top: 91px; position: absolute;" OnTextChanged="EmailTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Password" runat="server" Text="Password" width="138px"></asp:Label><asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 169px; top: 135px; position: absolute;"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="PermissionLvl" runat="server" Text="Permission Level"></asp:Label><br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="z-index: 1; left: 170px; top: 186px; position: absolute; height: 28px; width: 96px" ToolTip="Select Permission Level">
                <asp:ListItem>Low</asp:ListItem>
                <asp:ListItem>Medium</asp:ListItem>
                <asp:ListItem>High</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 169px; top: 286px; position: absolute; height: 161px; width: 309px"></asp:Calendar>
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
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 165px; top: 509px; position: absolute" Text="On Site" />
            <br />
            <br />
            <asp:Label ID="ErrorOutputLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 22px; top: 590px; position: absolute; width: 361px; height: 70px" Text="OK" />
        </div>
    </form>
</body>
</html>
