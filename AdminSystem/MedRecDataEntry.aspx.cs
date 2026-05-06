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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create an instance of the cls Medical Record
        clsMedicalRecords AnMedicalRecords = new clsMedicalRecords();


        // get the data entered by the user
        AnMedicalRecords.recordId = int.Parse(txtRecordId.Text);
        AnMedicalRecords.PatientID = int.Parse(txtPatientID.Text);
        AnMedicalRecords.DoctorID = int.Parse(txtDoctorID.Text);
        AnMedicalRecords.Date = DateTime.Parse(txtDate.Text);
        AnMedicalRecords.appID = int.Parse(txtAppID.Text);
        AnMedicalRecords.pendingApp = chkPending.Checked;
        AnMedicalRecords.appNotes = txtAppNotes.Text;


        //store the data in the session object
        Session["AnMedicalRecords"] = AnMedicalRecords;


        //navigate to the view page
        Response.Redirect("MedRecViewer.aspx");
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}