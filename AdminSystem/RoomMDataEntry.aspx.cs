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

        string FloorNumber = txtFloorNumber.Text;
        string RoomNumber = txtRoomNumber.Text;
        string WardLocation = listWardLocation.SelectedValue;
        string BedType = listBedType.SelectedValue;
        string DisabilityAccessible = chckbxDisabilityAccessible.Text;
        string HygieneStatus = listHygieneStatus.Text;
        string Inspected = chckbxInspected.Text;
        string Maintained = chckbxMaintained.Text;
        string LastDateCleaned = calLastDateCleaned.ToString();

        string error = "";
        error = Room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);
        if (error == "")
        {
            //Capture the data
            Room.WardLocation = WardLocation;
            Room.BedType = BedType;
            Room.HygieneStatus = HygieneStatus;
            Room.LastDateCleaned = Convert.ToDateTime(LastDateCleaned);
        }
        else
        {
            lblError.Text = error;
        }

            //Store the room Data in the session obj
            Session["Room"] = Room;

        //naivgate to the viewer page
        Response.Redirect("RoomMViewer.aspx");

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsRoom room = new clsRoom();
        Int32 FloorNumber;
        Int32 RoomNumber;

        Boolean Found = false;

        FloorNumber = Convert.ToInt32(txtFloorNumber.Text);
        RoomNumber = Convert.ToInt32(txtRoomNumber.Text);

        Found = room.Find(FloorNumber, RoomNumber);

        if (Found == true)
        {
            lblError.Text = "";

            listWardLocation.SelectedValue = room.WardLocation;
            listBedType.SelectedValue = room.BedType;
            chckbxDisabilityAccessible.Checked = room.DisabilityAccessible;
            listHygieneStatus.SelectedValue = room.HygieneStatus;
            chckbxInspected.Checked = room.Inspected;
            chckbxMaintained.Checked = room.Maintained;
            calLastDateCleaned.SelectedDate = room.LastDateCleaned;
        }
        else
        {
            //Need to make sure the other values get set to empty when this happens
            lblError.Text = "Incorrect";
        }
    }
}