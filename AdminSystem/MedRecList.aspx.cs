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

        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayMedicalRecords();
        }
    }

    void DisplayMedicalRecords()
    {
        // create an instance of the medical record collection
        clsMedicalRecordCollection MedicalRecords = new clsMedicalRecordCollection();
        // set the data source to list of medical records in the collection
        lstMedicalRecordList.DataSource = MedicalRecords.MedicalRecordList;
        // set the name of the primary key
        lstMedicalRecordList.DataValueField = "recordId";
        // set the data field to display
        lstMedicalRecordList.DataTextField = "AppNotes";
        // bind the data to the list
        lstMedicalRecordList.DataBind();

        //clsAppointments someAppointents = new clsAppointments();
        //someAppointents.Find(3);
    }

    protected void lstMedicalRecordList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store - 1 into the session object to indicate this is a new record 
        Session["recordId"] = -1;

        // redirecr to the data entry page 
        Response.Redirect("MedRecDataEntry.aspx");
    }
}
