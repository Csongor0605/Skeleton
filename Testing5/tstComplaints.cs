using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstComplaints
    {
        [TestMethod]
        public void InstanceOK()
        {
            // creat an instance of the class we want to creat
            clsComplaint Complaint = new clsComplaint();
            // test to see it exsits 
            Assert.IsNotNull(Complaint);
        }
    }
}
