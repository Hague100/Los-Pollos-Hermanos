<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="StatistsBtn" runat="server" style="z-index: 1; left: 366px; top: 606px; position: absolute" Text="Statistics Page" OnClick="StatistsBtn_Click" />
            <asp:Button ID="DeleteBtn" runat="server" style="z-index: 1; left: 300px; top: 505px; position: absolute" Text="Delete" OnClick="DeleteBtn_Click" />
            <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" style="z-index: 1; left: 82px; top: 507px; position: absolute" Text="Add" />
            <asp:ListBox ID="lstRoomsList" runat="server" style="z-index: 1; left: 78px; top: 18px; position: absolute; height: 456px; width: 474px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="EditBtn" runat="server" OnClick="EditBtn_Click" style="z-index: 1; left: 190px; top: 509px; position: absolute; height: 26px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 92px; top: 648px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="LblFilter" runat="server" style="z-index: 1; left: 94px; top: 562px; position: absolute; bottom: 100px" Text="Select a Ward"></asp:Label>
        <asp:DropDownList ID="WardList" runat="server" style="z-index: 1; left: 218px; top: 562px; position: absolute">
            <asp:ListItem Value="General">General</asp:ListItem>
            <asp:ListItem Value="Pediatric">Pediatric</asp:ListItem>
            <asp:ListItem Value="Intensive Care Unit">Intensive Care Unit</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="ApplyBtn" runat="server" style="z-index: 1; left: 96px; top: 604px; position: absolute" Text="Apply Filter" OnClick="ApplyBtn_Click" />
        <asp:Button ID="RstFltrBtn" runat="server" style="z-index: 1; left: 219px; top: 604px; position: absolute" Text="Clear Filter" OnClick="RstFltrBtn_Click" />
    </form>
</body>
</html>
