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
            DisplayDoctors();
        }
    }


    void DisplayDoctors()
    {
        // create an instance of the doctor collection 
        clsDoctorCollection doctors = new clsDoctorCollection();
        // set the data source to list of doctors in the collection
        DoctorList.DataSource = doctors.doctorList;
        // set the name of the primary key
        DoctorList.DataValueField = "dId";
        // set the data field to display 
        DoctorList.DataTextField = "DLastName";
        // bind the data to the list
        DoctorList.DataBind();
    }
}