<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblConfirm" runat="server" style="z-index: 1; left: 133px; top: 221px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="ConfirmBtn" runat="server" OnClick="ConfirmBtn_Click" style="z-index: 1; left: 136px; top: 285px; position: absolute" Text="Yes" />
            <asp:Button ID="CancelBtn" runat="server" style="z-index: 1; left: 305px; top: 285px; position: absolute" Text="No" OnClick="CancelBtn_Click" />
        </div>
    </form>
</body>
</html>
