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
        <asp:Label ID="lblPatientId" runat="server" style="z-index: 1; left: 15px; top: 32px; position: absolute; right: 1182px;" Text="Patient ID" width="98px"></asp:Label>
        <asp:TextBox ID="txtPatientId" runat="server" style="z-index: 1; left: 147px; top: 29px; position: absolute; margin-bottom: 0px" OnTextChanged="txtPatientId_TextChanged"></asp:TextBox>
        <asp:Label ID="lblPName" runat="server" style="z-index: 1; left: 15px; top: 59px; position: absolute" Text="Name" width="98px"></asp:Label>
        <asp:TextBox ID="txtPName" runat="server" style="z-index: 1; left: 147px; top: 56px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPEmail" runat="server" style="z-index: 1; left: 15px; top: 83px; position: absolute" Text="Email" width="98px"></asp:Label>
        <asp:TextBox ID="txtPEmail" runat="server" style="z-index: 1; left: 147px; top: 80px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPDOB" runat="server" style="z-index: 1; left: 15px; top: 111px; position: absolute" Text="Date of Birth" width="98px"></asp:Label>
        <asp:TextBox ID="txtPDOB" runat="server" style="z-index: 1; left: 147px; top: 108px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPHomeAdd" runat="server" style="z-index: 1; left: 15px; top: 138px; position: absolute" Text="Home Address" width="98px"></asp:Label>
        <asp:Label ID="lblPMainDoc" runat="server" style="z-index: 1; left: 15px; top: 164px; position: absolute" Text="Main Doctor ID"></asp:Label>
        <asp:TextBox ID="txtPMainDocId" runat="server" style="z-index: 1; left: 147px; top: 161px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkPAccessReq" runat="server" style="z-index: 1; left: 53px; top: 205px; position: absolute" Text="Access Requirements" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 29px; top: 255px; position: absolute" Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 174px; top: 252px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 366px; top: 25px; position: absolute" Text="Find" width="77px" />
        <asp:TextBox ID="txtPHomeAdd" runat="server" style="z-index: 1; left: 147px; top: 135px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 290px; top: 208px; position: absolute; height: 55px; width: 202px;"></asp:Label>
    </form>
</body>
</html>
