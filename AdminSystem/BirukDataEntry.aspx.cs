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
        //create a new instance of clsAddress
        clsCustomer ACustomer = new clsCustomer();
        //capture the house no
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        //store the address in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("BirukViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primry key 
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerPassword.Text = ACustomer.CustomerPassword;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtCustomerReg.Text = ACustomer.CustomerReg.ToString();
            txtCustomerOrderMade.Text = ACustomer.CustomerOrderMade.ToString();
            chkActive.Checked = ACustomer.Active;
        }

    }
}