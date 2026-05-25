<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocMList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Doc List</title>
    </head>
    <body>
        <header>
        </header>
        <main>
            <form id="form1" runat="server">
               <section style="height: 500px">
                
                   <asp:ListBox ID="DoctorList" runat="server" style="z-index: 1; left: 130px; top: 144px; position: absolute; height: 237px; width: 555px"></asp:ListBox>
                   <asp:Button ID="AddButton" runat="server" style="z-index: 1; left: 130px; top: 400px; position: absolute" Text="Add" OnClick="AddButton_Click" />
                   <asp:Button ID="EditButton" runat="server" style="z-index: 1; left: 200px; top: 400px; position: absolute" Text="Edit" OnClick="EditButton_Click" />
                   <asp:Button ID="DeleteButton" runat="server" style="z-index: 1; left: 270px; top: 400px; position: absolute" Text="Delete" OnClick="DeleteButton_Click" />
                   <asp:Label ID="ErrorLabel" runat="server" style="z-index: 1; left: 130px; top: 450px; position: absolute; margin-bottom: 0px"></asp:Label>        


                   <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 381px; top: 404px; position: absolute" Text="Enter Last Name"></asp:Label>
                   <asp:TextBox ID="FilterTextBox" runat="server" style="z-index: 1; left: 550px; top: 405px; position: absolute"></asp:TextBox>


                   <asp:Button ID="ApplyFilterButton" runat="server" style="z-index: 1; left: 450px; top: 450px; position: absolute" Text="Apply filter" OnClick="ApplyFilterButton_Click" />
                   <asp:Button ID="ClearFilterButton" runat="server" style="z-index: 1; left: 570px; top: 450px; position: absolute" Text="Clear filter" OnClick="ClearFilterButton_Click1" />


                   <asp:Button ID="StatisticButton" runat="server" style="z-index: 1; left: 302px; top: 450px; position: absolute" Text="Statistics" OnClick="StatisticButton_Click" />


               </section>
            </form>
        </main>
        <footer>
        </footer>
        
    </body>
</html>

