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
        <asp:Label ID="lblAppointmentTime" runat="server" style="z-index: 1; left: 17px; top: 355px; position: absolute" Text="Appointment Time"></asp:Label>
        <asp:DropDownList ID="txtAppointmentTime" runat="server" style="z-index: 1; left: 204px; top: 355px; position: absolute">
            <asp:ListItem Text="11am" Value="11:00:00"></asp:ListItem>
            <asp:ListItem Text="12pm" Value="12:00:00"></asp:ListItem>
            <asp:ListItem Text="1pm" Value="13:00:00"></asp:ListItem>
        </asp:DropDownList>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkEmergency" runat="server" style="z-index: 1; left: 156px; top: 537px; position: absolute" Text="Emergency Appointment?" />
        </p>
        <p>
            <asp:TextBox ID="txtNotes" runat="server" style="z-index: 1; left: 198px; top: 406px; position: absolute; height: 94px; width: 350px"></asp:TextBox>
        </p>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 153px; top: 586px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 307px; top: 585px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 194px; top: 638px; position: absolute"></asp:Label>
        <asp:Label ID="lblNotes" runat="server" style="z-index: 1; left: 36px; top: 453px; position: absolute" Text="Notes"></asp:Label>
    </form>
</body>
</html>
