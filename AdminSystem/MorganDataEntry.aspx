<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MorganDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 331px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblBookId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 53px" Text="BookId"></asp:Label>
        <asp:TextBox ID="txtbxBookId" runat="server" height="22px" style="z-index: 1; left: 164px; top: 34px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtbxBookTitle" runat="server" height="22px" style="z-index: 1; left: 164px; top: 60px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAuthor" runat="server" height="19px" style="z-index: 1; left: 12px; top: 91px; position: absolute; width: 146px" Text="Author"></asp:Label>
            <asp:TextBox ID="txtbxAuthor" runat="server" style="z-index: 1; left: 164px; top: 89px; position: absolute; height: 22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtbxGenre" runat="server" height="22px" style="z-index: 1; left: 164px; top: 120px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblBookId0" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 146px; height: 19px; bottom: 723px" Text="BookId"></asp:Label>
            <asp:Label ID="lblGenre" runat="server" height="19px" style="z-index: 1; left: 12px; top: 120px; position: absolute; width: 146px" Text="Genre"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chbxRestockOrdered" runat="server" style="z-index: 1; top: 178px; position: absolute" Text="RestockOrdered" />
        </p>
        <p>
            <asp:Label ID="lblBookId1" runat="server" height="19px" style="z-index: 1; left: 12px; top: 34px; position: absolute; width: 146px; bottom: 723px" Text="BookId"></asp:Label>
            <asp:TextBox ID="txtbxRestock_date" runat="server" height="22px" style="z-index: 1; left: 164px; top: 210px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblBookTitle" runat="server" height="19px" style="z-index: 1; left: 12px; top: 61px; position: absolute; width: 146px" Text="BookTitle"></asp:Label>
        <asp:Label ID="lblRestock_date" runat="server" height="19px" style="z-index: 1; left: 12px; top: 209px; position: absolute" Text="Restock_date" width="146px"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" height="19px" style="z-index: 1; left: 12px; top: 148px; position: absolute; width: 146px" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtbxQuantity" runat="server" height="22px" style="z-index: 1; left: 164px; top: 147px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblRestockOrder_Quantity" runat="server" style="z-index: 1; left: 12px; top: 242px; position: absolute" Text="RestockOrder_Quantity"></asp:Label>
        <asp:TextBox ID="txtbxRestockOrder_Quantity" runat="server" style="z-index: 1; left: 164px; top: 240px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 279px; position: absolute; width: 77px"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 315px; position: absolute; height: 26px" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 59px; top: 314px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
