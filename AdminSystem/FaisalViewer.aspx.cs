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
        //create new instance of clsComplaint
        clsComplaint Complaint = new clsComplaint();


        //get the data from the session object
        Complaint = (clsComplaint)Session["Complaint"];

        //display the order id for this entry
        Response.Write(Complaint.OrderID);


        //display the name for this entry
        Response.Write(Complaint.Name);


        //display the subject for this entry
        Response.Write(Complaint.Subject);


        //display the email for this entry
        Response.Write(Complaint.Email);


        //display the complaint for this entry
        Response.Write(Complaint.Complaint);


        //display the date for this entry
        Response.Write(Complaint.DateAdded);


        
        
    }
}