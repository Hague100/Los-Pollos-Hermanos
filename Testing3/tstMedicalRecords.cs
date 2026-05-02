using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstMedicalRecords
    {
        [TestMethod]
        public void ImstanceOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //test to see that it exists
            Assert.IsNotNull(AMedicalRecords);
        }
    }
}
