using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instance of clsMedicalRecords
        clsMedicalRecords AnMedicalRecords = new clsMedicalRecords();
        // get the data from the session object
        AnMedicalRecords = (clsMedicalRecords)Session["AnMedicalRecords"];
        // display the data for this record
        litRecord.Text =
            "Record ID: " + AnMedicalRecords.recordId + "<br />" +
            "Patient ID: " + AnMedicalRecords.PatientID + "<br />" +
            "Doctor ID: " + AnMedicalRecords.DoctorID + "<br />" +
            "Date: " + AnMedicalRecords.Date + "<br />" +
            "Appointment ID: " + AnMedicalRecords.appID + "<br />" +
            "Pending Appointment: " + AnMedicalRecords.pendingApp + "<br />" +
            "Appointment Notes: " + AnMedicalRecords.appNotes;
    }
}