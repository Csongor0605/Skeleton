using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }

    }
    void DisplayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection 
        lstCustomerList.DataSource = Customers.BirukList;
        //set the name of the primary key
        lstCustomerList.DataTextField = "CustomerID";
        //set the data field to display
        lstCustomerList.DataTextField = "CustomerName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("BirukDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("BirukDataEntry.aspx");
        }
        else//if no record has been selected
        {
            lblError.Text = "please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("BirukConfirmDelete.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByCustomerEmail(txtFilter.Text);
        lstCustomerList.DataSource = Customer.BirukList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "CustomerEmail";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByCustomerEmail("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "CustomerEmail";
        //bind the data to the list
        lstCustomerList.DataBind();

    }
}