<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatMStatistics.aspx.cs" Inherits="PatMStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Patient Statistics</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body class="bg-info">
    <header class="container-fluid p-5 bg-primary text-white text-center">
        <h1>Statistics Page</h1>
    </header>
    <main class="container my-5">
        <form id="form1" runat="server">
            <div class="gap-5 d-flex">
                <section class="col bg-light-subtle p-3 rounded-4" id="groupedByDoc">
                    <h3>Patient List - Grouped by Doctor</h3>
                    <asp:GridView class="table table-bordered table-condensed" ID="GridViewStGroupByDoc" runat="server"></asp:GridView>
                </section>
                <section class="col bg-light-subtle p-3 rounded-4" id="groupedByDOB">
                    <h3>Patient List - Grouped by Date of Birth</h3>
                    <asp:GridView class="table table-bordered table-condensed" ID="GridViewStGroupByDOB" runat="server"></asp:GridView>
                </section>
            </div>
            <nav class="gap-5 d-flex text-center p-4">
                <div class="col">
                    <asp:Button class="btn btn-primary" ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return" style="width: 100px"/>
                </div>
                <div class="col">
                    <asp:Button class="btn btn-secondary" ID="btnMainPage" runat="server" OnClick="btnMainPage_Click" Text="Home Page" style="width: 100px"/>
                </div>
            </nav>
        </form>
    </main>
    
</body>
</html>
