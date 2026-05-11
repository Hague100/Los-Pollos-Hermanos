using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsRoomNumber
        clsRoom Room = new clsRoom();

        //Capture the data
        Room.FloorNumberId = Convert.ToInt32(txtFloorNumber.Text);
        Room.RoomNumberId = Convert.ToInt32(txtRoomNumber.Text);
        Room.WardLocation = listWardLocation.Text;
        Room.BedType = listBedType.Text;
        Room.DisabilityAccessible = chckbxDisabilityAccessible.Checked;
        Room.HygieneStatus = listHygieneStatus.Text;
        Room.Inspected = chckbxInspected.Checked;
        Room.Maintained = chckbxMaintained.Checked;
        Room.LastDateCleaned = Convert.ToDateTime(calLastDateCleaned.SelectedDate);

        //Store the room numer in the session obj
        Session["Room"] = Room;

        //naivgate to the viewer page
        Response.Redirect("RoomMViewer.aspx");

    }
}