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



    protected void addBtn_Click(object sender, EventArgs e)
    {
        Session["StaffNo"] = -1;
        Response.Redirect("CsongorDataEntry.aspx");
    }

    protected void editBtn_Click(object sender, EventArgs e)
    {
        int loginID;

        if (staffListBox.SelectedIndex != -1)
        {
            loginID = int.Parse(staffListBox.SelectedValue);
            Session["StaffNo"] = loginID;
            Response.Redirect("CsongorDataEntry.aspx");
        }
        else
            errLabel.Text = "Please select a record from the list";
    }

    protected void deleteBtn_Click(object sender, EventArgs e)
    {
        int staffNo;

        if (staffListBox.SelectedIndex != -1)
        {
            staffNo = Convert.ToInt32(staffListBox.SelectedValue);
            Session["StaffNo"] = staffNo;
            Response.Redirect("CsongorConfirmDelete.aspx");
        }
        else
        {
            errLabel.Text = "Please select a Record from list.";
        }
    }

    protected void filterApplyBtn_Click(object sender, EventArgs e)
    {
        clsStaffCollection filteredStaffColl = new clsStaffCollection();
        filteredStaffColl.ReportByName(TextBox1.Text);
        staffListBox.DataSource = filteredStaffColl.StaffList;
        staffListBox.DataValueField = "LoginID";
        staffListBox.DataTextField = "Name";
        staffListBox.DataBind();
    }
}