<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatMDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 362px;
        }
    </style>
</head>
<body style="height: 380px">
    <form id="form1" runat="server">
        <asp:Label ID="lblPatientId" runat="server" style="z-index: 1; left: 15px; top: 38px; position: absolute" Text="Patient ID" width="126px"></asp:Label>
        <asp:TextBox ID="txtPatientId" runat="server" style="z-index: 1; left: 150px; top: 32px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="lblPName" runat="server" style="z-index: 1; left: 15px; top: 59px; position: absolute" Text="Name" width="126px"></asp:Label>
        <asp:TextBox ID="txtPName" runat="server" style="z-index: 1; left: 150px; top: 59px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPEmail" runat="server" style="z-index: 1; left: 15px; top: 83px; position: absolute" Text="Email" width="126px"></asp:Label>
        <asp:TextBox ID="txtPEmail" runat="server" style="z-index: 1; left: 150px; top: 85px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPDOB" runat="server" style="z-index: 1; left: 15px; top: 140px; position: absolute" Text="Date of Birth" width="126px"></asp:Label>
        <asp:TextBox ID="txtPDOB" runat="server" style="z-index: 1; left: 150px; top: 141px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPHomeAdd" runat="server" style="z-index: 1; left: 15px; top: 168px; position: absolute" Text="Home Address" width="126px"></asp:Label>
        <asp:TextBox ID="txtPHomeAdd" runat="server" style="z-index: 1; left: 150px; top: 167px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPMainDoc" runat="server" style="z-index: 1; left: 15px; top: 196px; position: absolute" Text="Main Doctor ID"></asp:Label>
        <asp:TextBox ID="txtPMainDocId" runat="server" style="z-index: 1; left: 150px; top: 199px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkPAccessReq" runat="server" style="z-index: 1; left: 150px; top: 232px; position: absolute" Text="Access Requirements" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 262px; position: absolute" width="98px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 15px; top: 306px; position: absolute" Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 150px; top: 306px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 366px; top: 31px; position: absolute" Text="Find" width="77px" />
    </form>
</body>
</html>
