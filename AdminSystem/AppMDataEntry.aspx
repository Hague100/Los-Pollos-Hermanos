<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 160px; top: 14px; position: absolute; width: 350px"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 56px; position: absolute" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 161px; top: 58px; position: absolute; width: 350px"></asp:TextBox>
        <asp:Label ID="lblAppointmentDate" runat="server" style="z-index: 1; left: 10px; top: 200px; position: absolute" Text="Appointment Date"></asp:Label>
        <asp:Calendar ID="calAppointmentDate" runat="server" style="z-index: 1; left: 160px; top: 102px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:Label ID="lblAppointmentTime" runat="server" style="z-index: 1; left: 10px; top: 320px; position: absolute" Text="Appointment Time"></asp:Label>
        <asp:DropDownList ID="txtAppointmentHour" runat="server" style="z-index: 1; left: 160px; top: 320px; width: 70px; position: absolute">
            <asp:ListItem Text="9am" Value="9:00:00"></asp:ListItem>
            <asp:ListItem Text="10am" Value="10:00:00"></asp:ListItem>
            <asp:ListItem Text="11am" Value="11:00:00"></asp:ListItem>
            <asp:ListItem Text="12pm" Value="12:00:00"></asp:ListItem>
            <asp:ListItem Text="1pm" Value="13:00:00"></asp:ListItem>
            <asp:ListItem Text="2pm" Value="14:00:00"></asp:ListItem>
            <asp:ListItem Text="3pm" Value="15:00:00"></asp:ListItem>
            <asp:ListItem Text="4pm" Value="16:00:00"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="txtAppointmentMinute" runat="server" style="z-index: 1; left: 252px; top: 320px; width: 70px; position: absolute">
            <asp:ListItem Text="00" Value="0"></asp:ListItem>
            <asp:ListItem Text="15" Value="15"></asp:ListItem>
            <asp:ListItem Text="30" Value="30"></asp:ListItem>
            <asp:ListItem Text="45" Value="45"></asp:ListItem>
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
        <asp:Label ID="lbldeez" runat="server" style="font-size: 30px; position: absolute; left: 600px;">time</asp:Label>
    </form>
</body>
</html>
