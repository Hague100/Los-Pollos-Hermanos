<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" style="z-index: 1; left: 82px; top: 507px; position: absolute" Text="Add" />
            <asp:ListBox ID="lstRoomsList" runat="server" style="z-index: 1; left: 78px; top: 18px; position: absolute; height: 456px; width: 474px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
