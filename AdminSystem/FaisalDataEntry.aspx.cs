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

  

        //create a new instance of the clsComplaint
        clsComplaint Complaint = new clsComplaint();

        //capture the order id
        Complaint.OrderID = Convert.ToInt32(TxtOrderID.Text);

        //capture the name
        Complaint.Name = txtName.Text;

        //capture the subject
        Complaint.Subject = txtSubject.Text;

        //capture the email
        Complaint.Email = txtEmail.Text;
        
        //capture the complaint
        Complaint.Text = txtComplaint.Text;

        //capture the date
        Complaint.DateAdded = Convert.ToDateTime(txtDate.Text);
        
        //store the compalint in the session box
        Session["Complaint"] = Complaint;

        //take you to the viewer page
        Response.Redirect("FaisalViewer.aspx");



 
        
     
    }
}