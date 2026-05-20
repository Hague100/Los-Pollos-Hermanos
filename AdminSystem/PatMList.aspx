<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 98px; top: 398px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        </div>
        <asp:ListBox ID="lstPatientList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 338px; width: 475px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 398px; position: absolute" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 461px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 196px; top: 399px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
