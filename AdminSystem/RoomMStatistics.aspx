<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMStatistics.aspx.cs" Inherits="RoomMStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridWard" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" style="z-index: 1; left: 29px; top: 104px; position: absolute; height: 133px; width: 187px">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
        </div>
        <p>
            <asp:Label ID="LblTitle" runat="server" style="z-index: 1; left: 32px; top: 16px; position: absolute" Text="Statistics page"></asp:Label>
            <asp:Label ID="LblWard" runat="server" style="z-index: 1; left: 31px; top: 69px; position: absolute" Text="Ward List - Grouped by Ward"></asp:Label>
        </p>
        <asp:Button ID="BackBtn" runat="server" style="z-index: 1; left: 316px; top: 237px; position: absolute" Text="Back To Rooms List" OnClick="BackBtn_Click" />
    </form>
</body>
</html>
