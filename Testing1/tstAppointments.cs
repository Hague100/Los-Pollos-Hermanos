using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstAppointments
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointments = new clsAppointments();
            //test to see that it exists
            Assert.IsNotNull(AnAppointments);
        }
    }
}
