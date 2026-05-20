<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 160px; top: 14px; position: absolute; width: 350px"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 56px; position: absolute" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 161px; top: 58px; position: absolute; width: 350px"></asp:TextBox>
        <asp:Label ID="lblAppointmentDate" runat="server" style="z-index: 1; left: 10px; top: 200px; position: absolute" Text="Appointment Date"></asp:Label>
        <asp:Calendar ID="calAppointmentDate" runat="server" style="z-index: 1; left: 160px; top: 102px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:TextBox ID="txtAppointmentDate" runat="server" style="z-index: 1; left: 160px; top: 195px; position: absolute; width: 350px; display: none"></asp:TextBox>
        <asp:Label ID="lblAppointmentTime" runat="server" style="z-index: 1; left: 10px; top: 320px; position: absolute" Text="Appointment Time"></asp:Label>
        <asp:DropDownList ID="txtAppointmentTime" runat="server" style="z-index: 1; left: 160px; top: 320px; position: absolute">
            <asp:ListItem Text="11am" Value="11:00:00"></asp:ListItem>
            <asp:ListItem Text="12pm" Value="12:00:00"></asp:ListItem>
            <asp:ListItem Text="1pm" Value="13:00:00"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblNotes" runat="server" style="z-index: 1; left: 10px; top: 370px; position: absolute" Text="Notes"></asp:Label>
        <asp:TextBox ID="txtNotes" runat="server" style="z-index: 1; left: 160px; top: 350px; position: absolute; height: 50px; width: 350px"></asp:TextBox>
        <asp:CheckBox ID="chkEmergency" runat="server" style="z-index: 1; left: 160px; top: 420px; position: absolute" Text="Emergency Appointment?" />
        <asp:Label ID="lblAppointmentNumber" runat="server" style="z-index: 1; left: 10px; top: 470px; position: absolute" Text="Appointment Number"></asp:Label>
        <asp:TextBox ID="txtAppointmentNumber" runat="server" style="z-index: 1; left: 160px; top: 470px; position: absolute; width: 100px" Text=""></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 300px; top: 470px; position: absolute;" Text="Find" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 100px; top: 520px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 200px; top: 520px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 600px; position: absolute"></asp:Label>
    </form>
</body>
</html>
