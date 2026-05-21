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
        clsRoomCollection allRooms = new clsRoomCollection();
        var query = from rooms in allRooms.RoomList select new { CombinedNo = "FloorNumber." + rooms.FloorNumber + ".RoomNumber." + rooms.RoomNumber};

        lstRoomsList.DataSource = query;

        lstRoomsList.DataValueField = "CombinedNo";

        lstRoomsList.DataBind();
    }

    protected void AddBtn_Click(object sender, EventArgs e)
    {
        Session["FloorNumber"] = -1;
        Session["RoomNumber"] = -1;

        Response.Redirect("RoomMDataEntry.aspx");
    }

    protected void EditBtn_Click(object sender, EventArgs e)
    {
        int FloorNumber = -1;
        int RoomNumber = -1;
        string Keys;
        Keys = lstRoomsList.SelectedValue;

        string[] SubKeys = Keys.Split(' ', '.');

        try 
        {
            FloorNumber = Convert.ToInt32(SubKeys[1]);
            RoomNumber = Convert.ToInt32(SubKeys[3]);
        }
        catch { lblError.Text = "Please Select a record from the list to edit"; }

        //System.Diagnostics.Debug.WriteLine("Room:" + SubKeys[1] + SubKeys[3]);

        if (FloorNumber != -1 &&  RoomNumber != -1) 
        {
            Session["FloorNumber"] = FloorNumber;
            Session["RoomNumber"] = RoomNumber;

            Response.Redirect("RoomMDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record from the list to edit";
        }
    }
}