﻿using System;
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
        if (IsPostBack == false)
            DisplayList();
    }

    void DisplayList() 
    {
        clsStaffCollection staffList = new clsStaffCollection();

        staffListBox.DataSource = staffList.StaffList;
        staffListBox.DataValueField = "LoginID";
        staffListBox.DataTextField = "Name";
        staffListBox.DataBind();
    }
}