using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }

    }

    void DisplayCustomer()
    {
        //create an instance of the Customer
        clsCustomerCollection BirukList = new clsCustomerCollection();
        //find the record to update
        BirukList.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerID.Text = BirukList.ThisCustomer.CustomerID.ToString();
        txtCustomerName.Text = BirukList.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = BirukList.ThisCustomer.CustomerEmail;
        txtCustomerAddress.Text = BirukList.ThisCustomer.CustomerAddress;
        txtCustomerPassword.Text = BirukList.ThisCustomer.CustomerPassword;
        txtCustomerReg.Text = BirukList.ThisCustomer.DateAdded.ToString();
        chkCustomerOrderMade.Checked = BirukList.ThisCustomer.CustomerOrderMade;


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
            //capture the customer id
            ACustomer.CustomerID = CustomerID; //don't miss this bit
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
            //capture active
            ACustomer.CustomerOrderMade = chkCustomerOrderMade.Checked;
            
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the ThisCustomer property

           //if this is a new record i.e CustomerId = -1 then add the data
           if (CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();

            }
           
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
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
            chkCustomerOrderMade.Checked = ACustomer.CustomerOrderMade;
            
        }

    }
}