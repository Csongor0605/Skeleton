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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {

        clsStaff staff = new clsStaff();

        string err = staff.Valid(LoginIDBox.Text,NameTextBox.Text,TextBox1.Text,EmailTextBox.Text,Calendar1.SelectedDate.ToString());

        if (err == "")
        {
            staff.PermissionLvl = RadioButtonList1.SelectedItem.ToString().ToCharArray()[0];

            Session["newStaff"] = staff;

            Response.Redirect("CsongorViewer.aspx");
        }
        else
            ErrorOutputLabel.Text = err;
    }


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
            TextBox1.Text = staff.Password;
        }
    }

    protected void EmailTextBox_TextChanged(object sender, EventArgs e)
    {

    }
}