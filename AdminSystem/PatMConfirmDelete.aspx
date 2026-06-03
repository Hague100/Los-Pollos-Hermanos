<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatMConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Deletion</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body class="bg-info">
    <header class="container-fluid p-5 bg-primary text-white text-center">
        <h1>Confirm Deletion</h1>
    </header>
    <main class="container my-5">
        <form class="bg-light rounded-4 mx-auto" id="form1" runat="server">
            <div class="row mb-4 text-center p-3">
                <asp:Label class="text-center d-block fw-bold" ID="lblConfirmMsg" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            </div>
            <div class="row mb-4 gap-5 justify-content-center p-3">
                <asp:Button class="btn btn-success" ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" width="50px" />
                <asp:Button class="btn btn-danger" ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" width="50px"/>
            </div>
        </form>
    </main>
</body>
</html>
