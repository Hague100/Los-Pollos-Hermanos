using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstDoc
    {
        [TestMethod]
        public void InstanceOk()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // check to see if it exists
            Assert.IsNotNull(newDoctor);

        }
    }
}
