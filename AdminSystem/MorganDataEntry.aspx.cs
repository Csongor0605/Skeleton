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
        //ABook.BookID = int.Parse(txtbxBookId.Text);

        // capture BookTitle from BookTitle textboc in data entry page
        //ABook.Title = txtbxTitle.Text;
        string Title = txtbxTitle.Text;

        //capture Book author, from Author Textbox in Data Entry window
        //ABook.Author = txtbxAuthor.Text;
        string Author = txtbxAuthor.Text;

        //capture Book Genre, from Genre Textbox in Data Entry window
        //ABook.Genre = txtbxGenre.Text;
        string Genre = txtbxGenre.Text;

        //capture Book Quantity, from Quantity Textbox in Data Entry window
        //ABook.Quantity = int.Parse(txtbxQuantity.Text);
        string Quantity = txtbxQuantity.Text;

        //capture Book restockordered (Booleans), from checkbox in data entry window
        //ABook.RestockOrdered = chbxRestockOrdered.Checked;

        //capture Book Restock date of Arrival (Datetime), from textbox in data entry window
        //ABook.Restock_DOA = DateTime.Parse(txtbxRestock_DOA.Text);
        string Restock_DOA = txtbxRestock_DOA.Text;

        //capture Book restock Quantity from textbox in Data Entry window
        //ABook.Restock_Quantity = int.Parse(txtbxRestock_Quantity.Text);
        string Restock_Quantity = txtbxRestock_Quantity.Text;

        // Validatte the data
        string Error = ABook.Valid(Title, Author, Genre, Quantity, Restock_DOA, Restock_Quantity);

        if (Error == "")
        {
            //capture the data
            ABook.Title = txtbxTitle.Text;

            ABook.Author = txtbxAuthor.Text;

            ABook.Genre = txtbxGenre.Text;

            ABook.Quantity = int.Parse(txtbxQuantity.Text);

            ABook.RestockOrdered = chbxRestockOrdered.Checked;

            ABook.Restock_DOA = DateTime.Parse(txtbxRestock_DOA.Text);

            ABook.Restock_Quantity = int.Parse(txtbxRestock_Quantity.Text);

            // store address is session object
            Session["ABook"] = ABook;
            //Navigate to viewer page
            Response.Redirect("MorganViewer.aspx");
        }
        else
        {
            // dislay the error message
            lblError.Text = Error;
        }

      
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create clsBook instacne
        clsBook ABook = new clsBook();
        // get primary key entered by user
        int BookID = Convert.ToInt32(txtbxBookId.Text);
        //Find record using primary key
        Boolean Found = ABook.Find(BookID);

        if(Found == true)
        {
            //display values of properties in form
            txtbxTitle.Text = ABook.Title;
            txtbxAuthor.Text = ABook.Author;
            txtbxGenre.Text = ABook.Genre;
            txtbxQuantity.Text = ABook.Quantity.ToString();
            chbxRestockOrdered.Checked = ABook.RestockOrdered;
            txtbxRestock_DOA.Text = ABook.Restock_DOA.ToString();
            txtbxRestock_Quantity.Text = ABook.Restock_Quantity.ToString();
        }
    }
}