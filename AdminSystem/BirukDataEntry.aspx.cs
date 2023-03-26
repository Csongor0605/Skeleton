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
        //capture the customer name
        string CustomerName = txtCustomerName.Text;
        //capture the customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the customer password
        string CustomerPassword = txtCustomerPassword.Text;
        //capture the customer address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the customer registration
        string CustomerReg = txtCustomerReg.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerReg);
        if (Error == "")
        {
            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the customer email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the customer password
            ACustomer.CustomerPassword = CustomerPassword;
            //capture the customer address
            ACustomer.CustomerAddress = CustomerAddress;
            //capture the customer registration
            ACustomer.CustomerReg = Convert.ToDateTime (CustomerReg);
            //store the address in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page
            Response.Write("BirukViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        /*ACustomer.CustomerAddress = txtCustomerAddress.Text;
        //store the address in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("BirukViewer.aspx");*/
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