using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new clsBook instance
        clsBook ABook = new clsBook();
        //get data from session object
        ABook = (clsBook)Session["ABook"];

        //display BookID for the entry
        Response.Write(ABook.BookID + "\n");
        //display Title
        Response.Write(ABook.Title + "\n");
        //display Author for the entry
        Response.Write(ABook.Author +"\n");
        //display Genre
        Response.Write(ABook.Genre + "\n");
        //display Quantity
        Response.Write(ABook.Quantity + "\n");
        //display RestockOrdered (boolean)
        Response.Write(ABook.RestockOrdered + "\n");
        //display Restock_date
        Response.Write(ABook.Restock_DOA + "\n");
        //Display restockorder_quantity
        Response.Write(ABook.Restock_Quantity + "\n");





    }
}