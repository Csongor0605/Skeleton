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
        clsStaff staff = new clsStaff("294038",Calendar1.SelectedDate);
        staff.Email = EmailTextBox.Text;
        staff.Name = NameTextBox.Text;
        staff.PermissionLvl  = RadioButtonList1.SelectedItem.ToString().ToCharArray()[0];
        staff.OnSite = CheckBox1.Checked;
        staff.SetPassword(TextBox1.Text);

        Session["newStaff"] = staff;

        Response.Redirect("CsongorViewer.aspx");
    }
}