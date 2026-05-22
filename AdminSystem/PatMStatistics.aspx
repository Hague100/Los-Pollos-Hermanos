<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatMStatistics.aspx.cs" Inherits="PatMStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <header><h1>Statistics Page</h1></header>
    <main>
        <form id="form1" runat="server">
            <section id="groupedByDoc">
                <h3>Patient List - Grouped by Doctor</h3>
                <asp:GridView ID="GridViewStGroupByDoc" runat="server"></asp:GridView>
            </section>
            <section id="groupedByDOB">
                <h3>Patient List - Grouped by Date of Birth</h3>
                <asp:GridView ID="GridViewStGroupByDOB" runat="server"></asp:GridView>
            </section>
        </form>
    </main>
    
</body>
</html>
