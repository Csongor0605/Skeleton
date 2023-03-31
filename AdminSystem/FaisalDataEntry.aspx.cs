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
        Complaint.Complaint = txtComplaint.Text;

        //capture the date
        Complaint.DateAdded = Convert.ToDateTime(txtDate.Text);
        
        //store the compalint in the session box
        Session["Complaint"] = Complaint;

        //take you to the viewer page
        Response.Redirect("FaisalViewer.aspx");



 
        
     
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsComplaint Complaint = new clsComplaint();
        //variable to store in the primary key
        Int32 OrderID;
        //variable to store the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(TxtOrderID.Text);
        //find the record
        Found = Complaint.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the properties in this form
            TxtOrderID.Text = Complaint.OrderID.ToString();
            txtName.Text = Complaint.Name;
            txtSubject.Text = Complaint.Subject;
            txtEmail.Text = Complaint.Email;
            txtComplaint.Text = Complaint.Complaint;
            txtDate.Text = Complaint.DateAdded.ToString();
            chkActive.Checked = Complaint.Active;

        }
    }
}