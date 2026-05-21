<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedRecList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 559px;
        }
    </style>
</head>
<body style="height: 566px; width: 494px">
    <form id="form1" runat="server">
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 105px; top: 450px; position: absolute" Text="Edit" />
        <asp:ListBox ID="lstMedicalRecordList" runat="server" style="z-index: 1; left: 36px; top: 46px; position: absolute; height: 386px; width: 429px" OnSelectedIndexChanged="lstMedicalRecordList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 38px; top: 450px; position: absolute; height: 26px" Text="Add" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 495px; position: absolute" Text="Error"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 176px; top: 451px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
