using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // story primary key or record to delete
    Int32 BookID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // ID of book to delete from session object
        BookID = Convert.ToInt32(Session["BookID"]);

    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        // clsBookCollection
        clsBookCollection AllBooks = new clsBookCollection();
        // find record
        AllBooks.ThisBook.Find(BookID);
        // delete record
        AllBooks.Delete();
        // redirect to list page
        Response.Redirect("MorganList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MorganList.aspx");
    }
}