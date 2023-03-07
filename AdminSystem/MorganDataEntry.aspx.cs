using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create instance of clsBook, class in classLibrary
        clsBook ABook = new clsBook();

        //capture BookID from BookID textboc in data entry page
        ABook.BookID = int.Parse(txtbxBookId.Text);

        // capture BookTitle from BookTitle textboc in data entry page
        ABook.BookTitle = txtbxBookTitle.Text;

        //capture Book author, from Author Textbox in Data Entry window
        ABook.Author = txtbxAuthor.Text;

        //capture Book Genre, from Genre Textbox in Data Entry window
        ABook.Genre = txtbxGenre.Text;

        //capture Book Quantity, from Quantity Textbox in Data Entry window
        ABook.Quantity = int.Parse(txtbxQuantity.Text);

        //capture Book restockordered (Booleans), from checkbox in data entry window
        ABook.RestockOrdered = chbxRestockOrdered.Checked;

        //capture Book Restock date of Arrival (Datetime), from textbox in data entry window
        ABook.Restock_date = DateTime.Parse(txtbxRestock_date.Text);

        //capture Book restock Quantity from textbox in Data Entry window
        ABook.RestockOrder_Quantity = int.Parse(txtbxRestockOrder_Quantity.Text);

        // store address is session object
        Session["ABook"] = ABook;
        //Navigate to viewer page
        Response.Redirect("MorganViewer.aspx");
    }

  
}