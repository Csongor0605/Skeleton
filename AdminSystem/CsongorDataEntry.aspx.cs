using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    int staffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        staffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            if (staffNo != -1)
            {
                DisplayDetails();
            }
        }
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {

        clsStaff staff = new clsStaff();

        string err = staff.Valid(LoginIDBox.Text.PadLeft(6,'0'),NameTextBox.Text,passwordTextBox.Text,EmailTextBox.Text,Calendar1.SelectedDate.ToString());

        if (err == "")
        {
            staff.PermissionLvl = RadioButtonList1.SelectedItem.ToString().ToCharArray()[0];
            staff.LoginID = int.Parse(LoginIDBox.Text.PadLeft(6, '0'));
            staff.Name = NameTextBox.Text;
            staff.OnSite = CheckBox1.Checked;
            staff.Password = passwordTextBox.Text;
            staff.Email = EmailTextBox.Text;
            staff.StartDate = Calendar1.SelectedDate;


            clsStaffCollection staffColl = new clsStaffCollection();

            if (staffNo == -1)
            {
                staffColl.thisStaff = staff;
                staffColl.Add();
            }
            else
            {
                staffColl.thisStaff.Find(staffNo);
                staffColl.thisStaff = staff;
                staffColl.Update();
            }

            Response.Redirect("CsongorList.aspx");
        }
        else
            ErrorOutputLabel.Text = err;
    }

    //Find Button
    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();
        int loginIDToSearchFor;
        bool found = false;
        loginIDToSearchFor = Convert.ToInt32(LoginIDBox.Text);
        found = staff.Find(loginIDToSearchFor);

        if (found) {
            EmailTextBox.Text = staff.Email;
            NameTextBox.Text = staff.Name;
            switch (staff.PermissionLvl) 
            {
                case 'a':
                    RadioButtonList1.SelectedValue = "High";
                    break;
                case 'b':
                    RadioButtonList1.SelectedValue = "Medium";
                    break;
                case 'c':
                    RadioButtonList1.SelectedValue = "High";
                    break;
            }
            CheckBox1.Checked = staff.OnSite;
            passwordTextBox.Text = staff.Password;
        }
    }

    void DisplayDetails() 
    {
        clsStaffCollection staffColl = new clsStaffCollection();
        staffColl.thisStaff.Find(staffNo);
        NameTextBox.Text = staffColl.thisStaff.Name;
        EmailTextBox.Text = staffColl.thisStaff.Email;
        LoginIDBox.Text = staffColl.thisStaff.LoginID.ToString().PadLeft(6,'0');
        CheckBox1.Checked = staffColl.thisStaff.OnSite;
        passwordTextBox.Text = staffColl.thisStaff.Password;
        Calendar1.SelectedDate = staffColl.thisStaff.StartDate;
        switch (staffColl.thisStaff.PermissionLvl)
        {
            case 'L':
                RadioButtonList1.SelectedValue = "Low";
                break;
            case 'M':
                RadioButtonList1.SelectedValue = "Medium";
                break;
            case 'H':
                RadioButtonList1.SelectedValue = "High";
                break;
            default:
                RadioButtonList1.SelectedValue = "Low";
                break;

        }
    }

    protected void EmailTextBox_TextChanged(object sender, EventArgs e)
    {

    }
}