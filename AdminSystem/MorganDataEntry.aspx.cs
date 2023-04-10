using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // varaible to store primary key, page level scope
    Int32 BookID;

    protected void Page_Load (object sender, EventArgs e)
    {
        // get ID of Book to be processed
        BookID = Convert.ToInt32(Session["BookID"]);
        if(IsPostBack == false)
        {
            // if not new record
            if (BookID != -1)
            {
                // display current data for record
                DisplayBook();
            }
        }

   
    }

   

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
            ABook.BookID = BookID; // added for update method

            ABook.Title = txtbxTitle.Text;

            ABook.Author = txtbxAuthor.Text;

            ABook.Genre = txtbxGenre.Text;

            ABook.Quantity = int.Parse(txtbxQuantity.Text);

            ABook.Restock_Ordered = chbxRestockOrdered.Checked;

            ABook.Restock_DOA = DateTime.Parse(txtbxRestock_DOA.Text);

            ABook.Restock_Quantity = int.Parse(txtbxRestock_Quantity.Text);

            // book collection instance
            clsBookCollection BookList = new clsBookCollection();

            // if this is a new record
            if (BookID == -1)
            {
                BookList.ThisBook = ABook;
                // add record
                BookList.Add();
            }

            // otherwise update
            else
            {
                // find record to update
                BookList.ThisBook.Find(BookID);
                //set thisbook property
                BookList.ThisBook = ABook;
                //update record
                BookList.Update();
            }

            //redirect back tp listpage
            Response.Redirect("MorganList.aspx");
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
            chbxRestockOrdered.Checked = ABook.Restock_Ordered;
            txtbxRestock_DOA.Text = ABook.Restock_DOA.ToString();
            txtbxRestock_Quantity.Text = ABook.Restock_Quantity.ToString();
        }
    }


    private void DisplayBook()
    {
        //create clsBook instacne
        clsBookCollection BookList = new clsBookCollection();

        // find record with BookId selected on list page
        BookList.ThisBook.Find(BookID);

        //display values of properties in form
        txtbxBookId.Text = BookList.ThisBook.BookID.ToString();
        txtbxTitle.Text = BookList.ThisBook.Title;
        txtbxAuthor.Text = BookList.ThisBook.Author;
        txtbxGenre.Text = BookList.ThisBook.Genre;
        txtbxQuantity.Text = BookList.ThisBook.Quantity.ToString();
        chbxRestockOrdered.Checked = BookList.ThisBook.Restock_Ordered;
        txtbxRestock_DOA.Text = BookList.ThisBook.Restock_DOA.ToString();
        txtbxRestock_Quantity.Text = BookList.ThisBook.Restock_Quantity.ToString();

    }
}