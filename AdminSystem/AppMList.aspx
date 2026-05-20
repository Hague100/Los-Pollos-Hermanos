<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstAppointments" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 500px; width: 500px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 12px; top: 535px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 141px; top: 537px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 591px; position: absolute"></asp:Label>
    </form>
</body>
</html>
