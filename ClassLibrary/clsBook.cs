using System;

namespace ClassLibrary
{
    public class clsBook
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Quantity { get; set; }
        public bool RestockOrdered { get; set; }
        public DateTime Restock_date { get; set; }
        public int RestockOrder_Quantity { get; set; }
    }
}