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

        [TestMethod]
        public void DAvailabilityOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();

            Boolean testData = true;
            // initialising test data
            newDoctor.DAvailability = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.DAvailability, testData);

        }

        [TestMethod]
        public void DPhoneNumberOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "07982651421";
            // setting field to test data
            newDoctor.DPhoneNumber = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.DPhoneNumber, testData);

        }

        [TestMethod]
        public void DEmailOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "doctor@gmail.com";
            // setting field to test data
            newDoctor.DEmail = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.DEmail, testData);

        }

        [TestMethod]
        public void DAddressOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "81 leister drive";
            // setting field to test data
            newDoctor.DAddress = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.DAddress, testData);

        }

        [TestMethod]
        public void DLastNameOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "Nullan";
            // setting field to test data
            newDoctor.DLastName = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.DLastName, testData);

        }

        [TestMethod]
        public void DFirstNameOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "Nullan";
            // setting field to test data
            newDoctor.DFirstName = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.DFirstName, testData);

        }






    }
}
