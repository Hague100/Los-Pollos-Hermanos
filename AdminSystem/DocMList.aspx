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
               <section style="height: 406px">
                
                   <asp:ListBox ID="DoctorList" runat="server" style="z-index: 1; left: 131px; top: 144px; position: absolute; height: 237px; width: 555px"></asp:ListBox>
                   <asp:Button ID="AddButton" runat="server" style="z-index: 1; left: 131px; top: 400px; position: absolute" Text="Add" OnClick="AddButton_Click" />
                   <asp:Button ID="EditButton" runat="server" style="z-index: 1; left: 201px; top: 400px; position: absolute" Text="Edit" OnClick="EditButton_Click" />
                   <asp:Label ID="ErrorLabel" runat="server" style="z-index: 1; left: 271px; top: 405px; position: absolute; margin-bottom: 0px" Text="Error"></asp:Label>
                
               </section>
            </form>
        </main>
        <footer>
        </footer>
        
    </body>
</html>

