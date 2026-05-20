using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayRooms();
        }

    }

    void DisplayRooms()
    {
        clsRoomCollection rooms = new clsRoomCollection();
        lstRoomsList.DataSource = rooms.RoomList;

        lstRoomsList.DataValueField = "FloorNumber";
        lstRoomsList.DataValueField = "RoomNumber";

        lstRoomsList.DataTextField = "WardLocation";

        lstRoomsList.DataBind();
    }

    protected void AddBtn_Click(object sender, EventArgs e)
    {
        Session["FloorNumber"] = -1;
        Session["RoomNumber"] = -1;

        Response.Redirect("RoomMDataEntry.aspx");
    }
}