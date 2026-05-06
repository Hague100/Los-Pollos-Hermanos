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
        //create a new instance of clsPatient
        clsPatient aPatient = new clsPatient();
        //capture the name 
        aPatient.pName = txtPName.Text;
        //email
        aPatient.pEmail = txtPEmail.Text;
        //phone number
        aPatient.pPhoneNO = txtPPhoneNo.Text;
        //dob
        aPatient.pDOB = Convert.ToDateTime(txtPDOB.Text);
        //home address
        aPatient.pHomeAdd = txtPHomeAdd.Text;
        //Main doctor id
        aPatient.pMainDocId = Convert.ToInt32(txtPMainDocId.Text);
        //Access requirements
        aPatient.pAccessReq = chkPAccessReq.Checked;
        //store the address in the session object
        Session["aPatient"] = aPatient;
        //nativigate to view page
        Response.Redirect("PatMViewer.aspx");
    }
}