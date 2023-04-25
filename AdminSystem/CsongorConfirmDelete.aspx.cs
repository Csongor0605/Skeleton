using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
    using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    int staffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        staffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    protected void yesBtn_Click(object sender, EventArgs e)
    {
        clsStaffCollection staffColl = new clsStaffCollection();
        staffColl.thisStaff.Find(staffNo);
        staffColl.Delete();
        Response.Redirect("CsongorList.aspx");
    }

    protected void noBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("CsongorList.aspx");
    }
}