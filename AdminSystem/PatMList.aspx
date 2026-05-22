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
        <asp:Label ID="lblEntName" runat="server" style="z-index: 1; left: 40px; top: 467px; position: absolute" Text="Enter a Name"></asp:Label>
        <asp:ListBox ID="lstPatientList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 338px; width: 475px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 398px; position: absolute" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 588px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 196px; top: 399px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 31px; top: 526px; position: absolute; right: 514px;" Text="Apply Filter" width="164px" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 210px; top: 467px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 211px; top: 526px; position: absolute" Text="Clear Filter" width="164px" />
        <asp:Button ID="btnStatsPage" runat="server" OnClick="btnStatsPage_Click" style="z-index: 1; left: 398px; top: 527px; position: absolute" Text="Statistics Page" />
    </form>
</body>
</html>
