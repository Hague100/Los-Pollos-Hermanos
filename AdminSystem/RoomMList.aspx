<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="MenuBtn" runat="server" style="z-index: 1; left: 1104px; top: 424px; position: absolute" Text="Return to Menu" OnClick="MenuBtn_Click" width="133px" />
            <asp:Button ID="StatistsBtn" runat="server" style="z-index: 1; left: 948px; top: 424px; position: absolute" Text="Statistics Page" OnClick="StatistsBtn_Click" />
            <asp:Button ID="DeleteBtn" runat="server" style="z-index: 1; left: 794px; top: 474px; position: absolute" Text="Delete" OnClick="DeleteBtn_Click" width="133px" />
            <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" style="z-index: 1; left: 467px; top: 474px; position: absolute; right: 857px;" Text="Add" width="133px" />
        </div>
        <p>
            <asp:Button ID="EditBtn" runat="server" OnClick="EditBtn_Click" style="z-index: 1; left: 627px; top: 474px; position: absolute; height: 26px" Text="Edit" width="133px" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 958px; top: 221px; position: absolute"></asp:Label>
        </p>
        <asp:DropDownList ID="WardList" runat="server" style="z-index: 1; left: 1065px; top: 87px; position: absolute">
            <asp:ListItem Value="General">General</asp:ListItem>
            <asp:ListItem Value="Pediatric">Pediatric</asp:ListItem>
            <asp:ListItem Value="Intensive Care Unit">Intensive Care Unit</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="ApplyBtn" runat="server" style="z-index: 1; left: 952px; top: 125px; position: absolute" Text="Apply Filter" OnClick="ApplyBtn_Click" width="133px" />
        <asp:Button ID="RstFltrBtn" runat="server" style="z-index: 1; left: 1109px; top: 125px; position: absolute" Text="Clear Filter" OnClick="RstFltrBtn_Click" width="133px" />
            <asp:ListBox ID="lstRoomsList" runat="server" style="z-index: 1; left: 458px; top: 78px; position: absolute; height: 381px; width: 474px"></asp:ListBox>
        <p>
        <asp:Label ID="LblFilter" runat="server" style="z-index: 1; left: 952px; top: 87px; position: absolute; " Text="Select a Ward" height="18"></asp:Label>
        </p>
    </form>
</body>
</html>
