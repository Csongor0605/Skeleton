using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be edited
    Int32 CustomerID;
    //
    //if a record has 
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book class
        clsCustomerCollection BirukList = new clsCustomerCollection();
        //find the record to delete 
        BirukList.ThisCustomer.Find(CustomerID);
        //delete the record
        BirukList.Delete();
        //redirect back to the main page
        Response.Redirect("BirukList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book class
        clsCustomerCollection BirukList = new clsCustomerCollection();
        //find the record to delete 
        BirukList.ThisCustomer.Find(CustomerID);
        //delete the record
        BirukList.Delete();
        //redirect back to the main page
        Response.Redirect("BirukList.aspx");

    }
}