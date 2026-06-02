<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.cs" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 250px; top: 538px; position: absolute" Text="Delete" />
        <asp:ListBox ID="lstAppointments" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 500px; width: 500px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 12px; top: 535px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 141px; top: 537px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 538px; top: 486px; position: absolute"></asp:Label>
        <asp:Label ID="lblInput" runat="server" style="z-index: 1; left: 16px; top: 593px; position: absolute" Text="Enter a date"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 170px; top: 587px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 14px; top: 630px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 165px; top: 630px; position: absolute" Text="Clear FIlter" />
        <asp:Button ID="btnStats" runat="server" style="z-index: 1; left: 324px; top: 630px; position: absolute" Text="Statistics Page" OnClick="btnStats_Click" />
    </form>
</body>
</html>
