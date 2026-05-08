<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 200px; top: 14px; position: absolute; width: 350px"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 56px; position: absolute" Text="Last Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 200px; top: 58px; position: absolute; width: 350px"></asp:TextBox>
        </p>
        <asp:Label ID="lblAppointmentDate" runat="server" style="z-index: 1; left: 16px; top: 200px; position: absolute" Text="Appointment Date"></asp:Label>
        <asp:Calendar ID="calAppointmentDate" runat="server" style="z-index: 1; left: 194px; top: 102px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:Label ID="lblAppointmentTime" runat="server" style="z-index: 1; left: 13px; top: 366px; position: absolute" Text="Appointment Time"></asp:Label>
        <asp:Label ID="lblAppointmentNumber" runat="server" style="z-index: 1; left: 8px; top: 578px; position: absolute" Text="Appointment Number"></asp:Label>
        <asp:TextBox ID="txtAppointmentNumber" runat="server" style="z-index: 1; left: 244px; top: 578px; position: absolute; width: 277px"></asp:TextBox>
        <asp:DropDownList ID="txtAppointmentTime" runat="server" style="z-index: 1; left: 204px; top: 363px; position: absolute">
            <asp:ListItem Text="11am" Value="11:00:00"></asp:ListItem>
            <asp:ListItem Text="12pm" Value="12:00:00"></asp:ListItem>
            <asp:ListItem Text="1pm" Value="13:00:00"></asp:ListItem>
        </asp:DropDownList>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkEmergency" runat="server" style="z-index: 1; left: 158px; top: 528px; position: absolute" Text="Emergency Appointment?" />
        </p>
        <p>
            <asp:TextBox ID="txtNotes" runat="server" style="z-index: 1; left: 198px; top: 406px; position: absolute; height: 94px; width: 350px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 580px; top: 579px; position: absolute; bottom: 80px" Text="Find" />
        </p>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 171px; top: 621px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 331px; top: 619px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 230px; top: 666px; position: absolute"></asp:Label>
        <asp:Label ID="lblNotes" runat="server" style="z-index: 1; left: 36px; top: 453px; position: absolute" Text="Notes"></asp:Label>
    </form>
</body>
</html>
