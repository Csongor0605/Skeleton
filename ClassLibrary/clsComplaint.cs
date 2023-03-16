using System;

namespace ClassLibrary
{
    public class clsComplaint
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
    }
}