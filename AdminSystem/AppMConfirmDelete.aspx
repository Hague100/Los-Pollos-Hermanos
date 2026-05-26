<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 141px; top: 202px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 383px; top: 205px; position: absolute" Text="No" />
        <asp:Label runat="server" style="z-index: 1; left: 89px; top: 147px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
    </form>
</body>
</html>
