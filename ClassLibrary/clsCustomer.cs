using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerID { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CustomerReg { get; set; }
        public string CustomerName { get; set; }
        public bool CustomerOrderMade { get; set; }
        public string CustomerPassword { get; set; }
    }
}