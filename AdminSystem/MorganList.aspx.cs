using System;
using System.Collections.Generic;
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
    void DisplayBookAuthors(){
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
        }

 