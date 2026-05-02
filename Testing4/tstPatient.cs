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
            clsPatient aPatient = new clsPatient();
            Assert.IsNotNull(aPatient);
        }
    }
}
