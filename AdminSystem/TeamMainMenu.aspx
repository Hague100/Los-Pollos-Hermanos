<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Main Page</title>
        
        <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <script src="Scripts/bootstrap.bundle.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons.min.css" />

    </head>
    <body class="bg-light-subtle">
        <header class="container-fluid p-5 bg-dark text-white text-center">
             <asp:Label class="h1" ID ="TitileLabel" runat="server" Text="Private Hostpital System"></asp:Label>
        </header>
        <main>
            <form id="form1" runat="server">
               <nav>
                    <div class ="col d-flex justify-content-center">
                        <div class="gap-5 d-flex text-center p-4">
                            <asp:Button class="btn btn-primary" ID="AppMButton" runat="server" Text="Appointments" OnClick="AppMButton_Click" style="width: 150px"/>
                            <asp:Button class="btn btn-primary" ID="DocMButton" runat="server" Text="Doctors" OnClick="DocMButton_Click" style="width: 150px"/>
                            <asp:Button class="btn btn-primary" ID="MedRecMButton" runat="server" Text="Medical Records" OnClick="MedRecMButton_Click" style="width: 150px"/>
                            <asp:Button class="btn btn-primary" ID="PatientsMButton" runat="server" Text="Patients" OnClick="PatientsMButton_Click" style="width: 150px"/>
                            <asp:Button class="btn btn-primary" ID="RoomMButtons" runat="server" Text="Rooms" OnClick="RoomMButtons_Click" style="width: 150px"/>
                        </div>
                    </div>
               </nav>
            </form>
        </main>
        <footer>
        </footer>
        
    </body>
</html>
