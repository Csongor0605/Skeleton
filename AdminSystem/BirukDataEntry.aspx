<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BirukDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 11px; top: 43px; position: absolute" Text="Customer ID" width="140px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 131px; top: 46px; position: absolute; height: 22px; width: 128px;"></asp:TextBox>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 338px; top: 52px; position: absolute" Text="Find" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 12px; top: 70px; position: absolute; right: 1398px" Text="Customer Name" width="140px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" height="22px" style="z-index: 1; left: 131px; top: 74px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 12px; top: 102px; position: absolute" Text="Customer Email" width="140px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" height="22px" style="z-index: 1; left: 129px; top: 103px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerPassword" runat="server" style="z-index: 1; left: 12px; top: 131px; position: absolute" Text="Customer Password" width="140px"></asp:Label>
        <asp:TextBox ID="txtCustomerPassword" runat="server" height="22px" style="z-index: 1; left: 141px; top: 131px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerReg" runat="server" style="z-index: 1; left: 13px; top: 160px; position: absolute; right: 1377px" Text="Customer Reg" width="140px"></asp:Label>
        <asp:TextBox ID="txtCustomerReg" runat="server" height="22px" style="z-index: 1; left: 119px; top: 160px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 16px; top: 195px; position: absolute" Text="Customer Address" width="140px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" height="22px" style="z-index: 1; left: 139px; top: 195px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerOrderMade" runat="server" style="z-index: 1; left: 17px; top: 221px; position: absolute" Text="Customer Order Made"></asp:Label>
        <asp:TextBox ID="txtCustomerOrderMade" runat="server" style="z-index: 1; left: 161px; top: 221px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 18px; top: 270px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 299px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 9px; top: 331px; position: absolute; height: 26px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 58px; top: 332px; position: absolute; bottom: 319px" Text="Cancel" />
    </form>
</body>
</html>
