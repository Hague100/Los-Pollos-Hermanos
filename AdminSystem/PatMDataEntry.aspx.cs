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
        string pName = txtPName.Text;
        string pEmail = txtPEmail.Text;
        string pDOB = txtPDOB.Text;
        string pHomeAdd = txtPHomeAdd.Text;
        string pMainDocId = txtPMainDocId.Text;
        string pAccessReq = chkPAccessReq.Text;
        //variable for error messages
        string Error = "";
        //validate data
        Error = aPatient.Valid(pName, pEmail, pHomeAdd, pDOB, pMainDocId);
        
        if (Error == "")
        {
            //capture the name 
            aPatient.pName = pName;
            //email
            aPatient.pEmail = pEmail;
            //dob
            aPatient.pDOB = Convert.ToDateTime(pDOB);
            //home address
            aPatient.pHomeAdd = pHomeAdd;
            //Main doctor id
            aPatient.pMainDocId = Convert.ToInt32(pMainDocId);
            
            //store the address in the session object
            Session["aPatient"] = aPatient;
            //nativigate to view page
            Response.Redirect("PatMViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
            //Access requirements
            aPatient.pAccessReq = chkPAccessReq.Checked;
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the patient class
        clsPatient aPatient = new clsPatient();
        //create a variable to store a pk
        Int32 patientId;
        //create a var to store result of the find opp
        Boolean found = false;
        //get pk enterered by user
        patientId = Convert.ToInt32(txtPatientId.Text);
        //find record
        found = aPatient.Find(patientId);
        //if found
        if (found)
        {
            //display the values of the properties in the form
            txtPName.Text = aPatient.pName;
            txtPEmail.Text = aPatient.pEmail;
            txtPDOB.Text = aPatient.pDOB.ToString();
            txtPHomeAdd.Text = aPatient.pHomeAdd;
            txtPMainDocId.Text = aPatient.pMainDocId.ToString();
            chkPAccessReq.Checked = aPatient.pAccessReq;
        }
    }

    protected void txtPatientId_TextChanged(object sender, EventArgs e)
    {

    }
}