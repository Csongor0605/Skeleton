<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MorganDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 497px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblBookId" runat="server" style="z-index: 1; left: 16px; top: 34px; position: absolute; width: 146px" Text="BookId" height="19px"></asp:Label>
        <asp:TextBox ID="txtbxBookId" runat="server" height="22px" style="z-index: 1; left: 178px; top: 30px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtbxBookTitle" runat="server" height="22px" style="z-index: 1; left: 178px; top: 67px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAuthor" runat="server" height="19px" style="z-index: 1; left: 16px; top: 103px; position: absolute; width: 146px" Text="Author"></asp:Label>
            <asp:TextBox ID="txtbxAuthor" runat="server" style="z-index: 1; left: 178px; top: 99px; position: absolute; height: 22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtbxGenre" runat="server" height="22px" style="z-index: 1; left: 178px; top: 137px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblGenre" runat="server" height="19px" style="z-index: 1; left: 16px; top: 140px; position: absolute; width: 146px" Text="Genre"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chbxRestockOrdered" runat="server" style="z-index: 1; top: 217px; position: absolute; left: 16px;" Text="RestockOrdered" height="19px" width="146px" />
        </p>
        <p>
            <asp:TextBox ID="txtbxRestock_date" runat="server" height="22px" style="z-index: 1; left: 178px; top: 258px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblBookTitle" runat="server" style="z-index: 1; left: 16px; top: 70px; position: absolute; width: 146px; height: 19px;" Text="BookTitle"></asp:Label>
        <asp:Label ID="lblRestock_date" runat="server" style="z-index: 1; left: 16px; top: 263px; position: absolute; height: 19px;" Text="Restock_date" width="146px"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" height="19px" style="z-index: 1; left: 16px; top: 179px; position: absolute; width: 146px" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtbxQuantity" runat="server" style="z-index: 1; left: 178px; top: 177px; position: absolute; height: 22px;" width="128px"></asp:TextBox>
        <asp:Label ID="lblRestockOrder_Quantity" runat="server" style="z-index: 1; left: 16px; top: 308px; position: absolute" Text="RestockOrder_Quantity"></asp:Label>
        <asp:TextBox ID="txtbxRestockOrder_Quantity" runat="server" style="z-index: 1; left: 178px; top: 300px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 408px; position: absolute; width: 77px"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 453px; position: absolute; height: 26px" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 70px; top: 453px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
