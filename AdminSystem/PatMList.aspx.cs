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
        //for first time page displayed
        if (!IsPostBack)
        {
            //update list box
            DisplayPatients();
        }
    }

    void DisplayPatients()
    {
        //create an instance of the Patient collection
        clsPatientCollection patients = new clsPatientCollection();
        //set the data source to list of Patients in the collection
        lstPatientList.DataSource = patients.patientList;
        //set the name of the primary key
        lstPatientList.DataValueField = "patientId";
        //set the data field to display
        lstPatientList.DataTextField = "pName";
        //bind the data to the list
        lstPatientList.DataBind(); 
    }
    
}