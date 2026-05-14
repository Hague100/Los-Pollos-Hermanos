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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAppointments();
        }
    }
    void DisplayAppointments()
    {
        //create an instance of the Appointments collection
        clsAppointmentsCollection Appointments = new clsAppointmentsCollection();
        //set the data source to the list of Appointments in the collection
        lstAppointments.DataSource = Appointments.AppointmentsList;
        //set the name of the primary key
        lstAppointments.DataValueField = "AppointmentNumber";
        //set the data field to display
        lstAppointments.DataTextField = "DateOfAppointment";
        //bind the data to the list
        lstAppointments.DataBind();
    }
}