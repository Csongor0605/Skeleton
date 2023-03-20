﻿using System;
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
}