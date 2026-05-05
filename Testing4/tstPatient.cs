using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstPatient
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //test to see that it exists
            Assert.IsNotNull(aPatient);
        }
    }
}
