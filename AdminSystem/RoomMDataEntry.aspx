<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 375px; top: 141px; position: absolute" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblFloorNumber" runat="server" style="z-index: 1; left: 28px; top: 72px; position: absolute; bottom: 566px" Text="Floor Number ID"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblRoomNumber" runat="server" style="z-index: 1; left: 27px; top: 107px; position: absolute" Text="Room Number ID"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtFloorNumber" runat="server" style="z-index: 1; left: 145px; top: 69px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtRoomNumber" runat="server" style="z-index: 1; left: 143px; top: 110px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblWardLocation" runat="server" style="z-index: 1; left: 29px; top: 143px; position: absolute" Text="Ward Location"></asp:Label>
        <asp:DropDownList ID="listWardLocation" runat="server" style="z-index: 1; left: 145px; top: 144px; position: absolute">
            <asp:ListItem Value="General">General</asp:ListItem>
            <asp:ListItem Value="Pediatric">Pediatric</asp:ListItem>
            <asp:ListItem Value="Intensive Care Unit">Intensive Care Unit</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblBedType" runat="server" style="z-index: 1; left: 30px; top: 171px; position: absolute" Text="Bed Type"></asp:Label>
        <asp:DropDownList ID="listBedType" runat="server" style="z-index: 1; left: 147px; top: 175px; position: absolute">
            <asp:ListItem Value="General">General</asp:ListItem>
            <asp:ListItem Value="Heavy">Heavy</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:CheckBox ID="chckbxDisabilityAccessible" runat="server" style="z-index: 1; left: 26px; top: 206px; position: absolute" Text="Disability Accessible" />
        </p>
        <p>
            <asp:CheckBox ID="chckbxInspected" runat="server" style="z-index: 1; left: 24px; top: 268px; position: absolute" Text="Inspected" />
        </p>
        <asp:Label ID="lblHygieneStatus" runat="server" style="z-index: 1; left: 29px; top: 239px; position: absolute" Text="Hygiene Status"></asp:Label>
        <asp:DropDownList ID="listHygieneStatus" runat="server" style="z-index: 1; left: 143px; top: 239px; position: absolute">
            <asp:ListItem Value="Available">Available</asp:ListItem>
            <asp:ListItem Value="Reprocessing">Reprocessing</asp:ListItem>
            <asp:ListItem Value="Occupied">Occupied</asp:ListItem>
        </asp:DropDownList>
        <p>
&nbsp;&nbsp;&nbsp;
        </p>
        <asp:CheckBox ID="chckbxMaintained" runat="server" style="z-index: 1; left: 23px; top: 299px; position: absolute" Text="Maintained" />
        <asp:Calendar ID="calLastDateCleaned" runat="server" style="z-index: 1; left: 21px; top: 364px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:Label ID="lblLastDateCleaned" runat="server" style="z-index: 1; left: 23px; top: 340px; position: absolute" Text="Last Date Cleaned"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 401px; top: 83px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 112px; top: 585px; position: absolute" Text="Submit" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 36px; top: 586px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
