<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MorganList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click1" style="z-index: 1; left: 606px; top: 449px; position: absolute; width: 182px; height: 50px" Text="Add" />
        <asp:ListBox ID="LstBoxBookList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 437px; width: 567px"></asp:ListBox>
        <asp:TextBox ID="TxtBxAuthor" runat="server" style="z-index: 1; left: 708px; top: 131px; position: absolute; width: 189px; height: 21px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" style="z-index: 1; left: 599px; top: 81px; position: absolute; width: 81px; height: 38px; right: 366px" Text="Apply" />
        </p>
        <p>
            <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" style="z-index: 1; left: 607px; top: 391px; position: absolute; width: 182px; height: 43px" Text="Edit" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="z-index: 1; left: 607px; top: 331px; position: absolute; width: 182px; height: 43px; margin-top: 0px;" Text="Delete" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 488px; position: absolute; width: 560px; height: 40px"></asp:Label>
        <asp:Button ID="BtnClear" runat="server" OnClick="BtnClear_Click" style="z-index: 1; left: 704px; top: 84px; position: absolute; width: 87px; height: 35px; bottom: 550px" Text="Clear" />
        <asp:Label ID="lblAuthor" runat="server" style="z-index: 1; left: 594px; top: 135px; position: absolute; width: 111px; height: 24px" Text="Enter an Author"></asp:Label>
    </form>
</body>
</html>
