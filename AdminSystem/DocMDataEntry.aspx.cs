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
        aDoc.DFirstName = tbFirstName.Text;
        // capture the last Name
        aDoc.DLastName = tbLastName.Text;
        // capture the address
        aDoc.DAddress = tbAddress.Text;
        // capture the email
        aDoc.DEmail = tbEmail.Text;
        // capture the phone number
        aDoc.DPhoneNumber = tbPHoneNumber.Text;
        // capture the check box
        aDoc.DAvailability = cbAvailability.Checked;
        // store the first name in the session object
        Session["aDoc"] = aDoc;
        //button handler when the button is clicked redirect back to page
        Response.Redirect("DocMViewer.aspx");
    }
}