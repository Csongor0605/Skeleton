using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if first time page is displayed
        if (IsPostBack == false)
        {
            //update list box
            DisplayBookAuthors();
        }
    }


    //update list box
    void DisplayBookAuthors()
    {
    // create clsBookCollection instances
    clsBookCollection Books = new clsBookCollection();
    // set data source to list of books in collection
     LstBoxBookList.DataSource = Books.BookList;
    // set name of primary key
    LstBoxBookList.DataValueField = "BookID";
     // set data field to display
    LstBoxBookList.DataTextField = "Author";
    //bind data to list
    LstBoxBookList.DataBind();
     }


    protected void BtnAdd_Click1(object sender, EventArgs e)
    {
        // stores -1 to session object to inidcate thsi is a new record
        Session["BookID"] = -1;

        //Debug.WriteLine("hello");

        // redirect to data entry page
        Response.Redirect("MorganDataEntry.aspx");
    }





    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        // priamry key value of record to be edited
        int BookID;

        // if record has been seelcted from list
        if (LstBoxBookList.SelectedIndex != -1)
        {
            // get priamry key value of record to edit
            BookID = Convert.ToInt32(LstBoxBookList.SelectedValue);
            // store data in session object
            Session["BookID"] = BookID;
            // redirect to edit page
            Response.Redirect("MorganDataEntry.aspx");
        }

        else // if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        // primary key value of record to be deleted
        Int32 BookID;

        if(LstBoxBookList.SelectedIndex != -1)
        {
            // get primary key of record to delete
            BookID = Convert.ToInt32(LstBoxBookList.SelectedValue);
            // store data in session object
            Session["BookID"] = BookID;
            // redirect to delete page
            Response.Redirect("MorganConfirmDelete.aspx");
        }
        else
        {
            //display error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        clsBookCollection filteredBooks = new clsBookCollection();

        filteredBooks.FilterByAuthor(TxtBxAuthor.Text);

        LstBoxBookList.DataSource = filteredBooks.BookList;

        // set name of primary key
        LstBoxBookList.DataValueField = "BookID";
        // set data field to display
        LstBoxBookList.DataTextField = "Author";
        //bind data to list
        LstBoxBookList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        clsBookCollection AllBooks = new clsBookCollection();

        AllBooks.FilterByAuthor("");

        TxtBxAuthor.Text = "";

        LstBoxBookList.DataSource = AllBooks.BookList;

        // set name of primary key
        LstBoxBookList.DataValueField = "BookID";
        // set data field to display
        LstBoxBookList.DataTextField = "Author";
        //bind data to list
        LstBoxBookList.DataBind();
    }
}

 