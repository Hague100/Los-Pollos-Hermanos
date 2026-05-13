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
        // create new instance of  clsDoctor
        clsDoc aDoc = new clsDoc();
        // capture the First Name
        aDoc.dFirstName = tbFirstName.Text;
        // capture the last Name
        aDoc.dLastName = tbLastName.Text;
        // capture the address
        aDoc.dAddress = tbAddress.Text;
        // capture the email
        aDoc.dEmail = tbEmail.Text;
        // capture the phone number
        aDoc.dPhoneNumber = tbPHoneNumber.Text;
        // capture the check box
        aDoc.dAvailability = cbAvailability.Checked;
        // store the first name in the session object
        Session["aDoc"] = aDoc;
        //button handler when the button is clicked redirect back to page
        Response.Redirect("DocMViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the address class
        clsDoc aDoc = new clsDoc();
        // create a variable to store the primary key
        Int32 doctorId;
        Boolean found = false;
        // get the primary key entered by the user
        doctorId = Convert.ToInt32(tbDoctorId.Text);
        // find the record id
        found = aDoc.Find(doctorId);

        if (found == true)
        {
            // display the values of the properties in form
            lbError.Text = "";
            tbFirstName.Text = aDoc.dFirstName;
            tbLastName.Text = aDoc.dLastName;
            tbAddress.Text = aDoc.dAddress;
            tbEmail.Text = aDoc.dEmail;
            tbPHoneNumber.Text = aDoc.dPhoneNumber;
            cbAvailability.Checked = aDoc.dAvailability;
        }
        else
        {
            // set error message, and then reset all other boxes to differetn values.
            lbError.Text = "Oh Hell nah jit tripping";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbPHoneNumber.Text = "";
            cbAvailability.Checked = false;
        }
    }
}