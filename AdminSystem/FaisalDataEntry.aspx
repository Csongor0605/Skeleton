<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FaisalDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="tblOrderID" runat="server" style="z-index: 1; left: 20px; top: 24px; position: absolute" Text="Order ID" height="36px" width="132px"></asp:Label>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtOrderID" runat="server" style="z-index: 1; left: 167px; top: 20px; position: absolute" height="38px" width="248px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 486px" Text="Find" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="tblSubject" runat="server" style="z-index: 1; left: 20px; top: 146px; position: absolute" Text="Subject" height="36px" width="132px"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="tblName" runat="server" style="z-index: 1; left: 20px; top: 73px; position: absolute" Text="Name" height="36px" width="132px"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 167px; top: 86px; position: absolute" height="38px" width="248px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 20px; top: 374px; position: absolute; height: 34px" Text="Active Order" />
        <asp:TextBox ID="txtSubject" runat="server" style="z-index: 1; left: 167px; top: 150px; position: absolute" height="38px" width="248px"></asp:TextBox>
        <asp:Label ID="tblEmail" runat="server" style="z-index: 1; left: 20px; top: 214px; position: absolute" Text="Email" height="36px" width="132px"></asp:Label>
        <asp:Label ID="tblComplaint" runat="server" style="z-index: 1; left: 20px; top: 258px; position: absolute" Text="Complaint" width="132px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 167px; top: 210px; position: absolute" height="38px" width="248px"></asp:TextBox>
        <asp:TextBox ID="txtComplaint" runat="server" style="z-index: 1; left: 167px; top: 254px; position: absolute" height="38px" width="248px"></asp:TextBox>
        <asp:Label ID="tblDate" runat="server" style="z-index: 1; left: 20px; top: 308px; position: absolute" Text="Date" height="36px" width="132px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 167px; top: 314px; position: absolute" height="38px" width="248px"></asp:TextBox>
        <asp:Label ID="tblError" runat="server" style="z-index: 1; left: 34px; top: 428px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 32px; top: 468px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 104px; top: 466px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
