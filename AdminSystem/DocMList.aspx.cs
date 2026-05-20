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

    protected void AddButton_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["dId"] = -1;
        // redirect to the data entry page
        Response.Redirect("DocMDataEntry.aspx");
    }

    protected void EditButton_Click(object sender, EventArgs e)
    {
        // variable to store the primary key  value of the record to be edit
        Int32 DoctorId;
        // if a record has been selected form the list
        if (DoctorList.SelectedIndex != -1)
        {
            // get the primary key of the value of the record to edit
            DoctorId = Convert.ToInt32(DoctorList.SelectedValue);
            // store the data in the session object 
            Session["dId"] = DoctorId;
            // redirect to the edit page
            Response.Redirect("DocMDataEntry.aspx");
        } else
        {
            // if no record has been selected
            ErrorLabel.Text = "Please select record from the list to edit";
        }
    }
}