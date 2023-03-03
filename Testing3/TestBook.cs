using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class TestBook
    {
        [TestMethod]
        public void TestInstance()
        {
            //create isntacne we want to test
            clsBook ABook = new clsBook();
            //test to see if it exists
            Assert.IsNotNull(ABook);
        }
    }
}
