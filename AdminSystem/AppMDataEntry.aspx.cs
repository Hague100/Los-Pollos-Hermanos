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
        //create a new instance of clsAppointments
        clsAppointments AnAppointment = new clsAppointments();
        //capture the patient first name
        AnAppointment.PatientFirstName = txtFirstName.Text;
        //capture the patient last name
        AnAppointment.PatientLastName = txtLastName.Text;
        //capture the date of appointment
        AnAppointment.DateOfAppointment = Convert.ToDateTime(calAppointmentDate.SelectedDate);
        //capture the time of appointment
        string[] timeSplit = txtAppointmentTime.Text.Split(':');
        AnAppointment.TimeOfAppointment = new TimeSpan(Convert.ToInt32(timeSplit[0]), Convert.ToInt32(timeSplit[1]), Convert.ToInt32(timeSplit[2]));
        //capture appointment notes
        AnAppointment.Notes = txtNotes.Text;
        //capture emergency 
        AnAppointment.EmergencyAppointment = chkEmergency.Checked;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnAppointment.Valid(AnAppointment.PatientFirstName, AnAppointment.PatientLastName, AnAppointment.DateOfAppointment.ToString(), AnAppointment.TimeOfAppointment.ToString(), "1", "1", AnAppointment.Notes, AnAppointment.EmergencyAppointment);
        //if the data is valid
        if (Error == "")
        {
            //store the appointment in the session object
            Session["AnAppointment"] = AnAppointment;
            //navigate to view page
            Response.Redirect("AppMViewer.aspx");
        } else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsAppointments AnAppointment = new clsAppointments();
        //variable to store the primary key
        Int32 AppointmentNumber;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AppointmentNumber = Convert.ToInt32(txtAppointmentNumber.Text);
        //find the record
        Found = AnAppointment.Find(AppointmentNumber);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AnAppointment.PatientFirstName;
            txtLastName.Text = AnAppointment.PatientLastName;
            calAppointmentDate.SelectedDate = AnAppointment.DateOfAppointment;
            txtAppointmentTime.Text = AnAppointment.TimeOfAppointment.ToString();
            txtNotes.Text = AnAppointment.Notes;
            chkEmergency.Checked = AnAppointment.EmergencyAppointment;
        }
    }
}