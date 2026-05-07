<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocMDataEntry - Copy.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Doc Data Entry</title>
    </head>
    <body>
        <header>
        </header>
        <main>
            <form id="form1" runat="server">
                <section>
                    <label id="lblDoctorId">Doctor ID</label>
                    <textbox id="txtbDoctorId">popo</textbox>

                    <label>First Name</label>
                    <textbox>...</textbox>

                    <label>Last Name</label>
                    <textbox></textbox>

                    <label>Address</label>
                    <textbox></textbox>

                    <label>Email</label>
                    <textbox></textbox>

                    <label>Phone number</label>
                    <textbox></textbox>

                    <label>Availability</label>
                    <textbox></textbox>

                </section>
            </form>
        </main>
        <footer>
        </footer>
    </body>

        <style>
            body{
                margin: 1rem;
                padding: 0;
                display: grid;
                grid-template-rows: auto 1fr auto;
                min-height: 100dvh;
            }

            #form1 {
                background-color: red;
                box-shadow: 10px 10px 15px rgba(0, 0, 0, 0.3);
                justify-content: center;
                flex-wrap: wrap;
                display: flex;
                border-radius: 1rem;
                padding: 2rem;
                margin: 5rem;
            }

        
        </style>
</html>
