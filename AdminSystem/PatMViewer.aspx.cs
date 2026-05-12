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
        //create a new instance of clsPatient
        clsPatient aPatient = new clsPatient();
        //get data from session object
        aPatient = (clsPatient)Session["aPatient"];
        //display the patient name for this entry
        Response.Write("Name: " + aPatient.pName);
        Response.Write("<br/>Email: " + aPatient.pEmail);
        Response.Write("<br/>DOB: " + aPatient.pDOB);
        Response.Write("<br/>Home Address" + aPatient.pHomeAdd);
        Response.Write("<br/>Main Doctor ID: " + aPatient.pMainDocId);
        Response.Write("<br/>Access Requirments: " + aPatient.pAccessReq);
    }
}