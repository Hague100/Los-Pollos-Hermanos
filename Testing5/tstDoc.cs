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
        public void DoctorIdOk()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();

            Int32 testData = 1;
            // initialising test data
            newDoctor.dId = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dId, testData);

        }

        [TestMethod]
        public void DAvailabilityOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            Boolean testData = true;
            // initialising test data
            newDoctor.dAvailability = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dAvailability, testData);

        }

        [TestMethod]
        public void DPhoneNumberOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "07982651421";
            // setting field to test data
            newDoctor.dPhoneNumber = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dPhoneNumber, testData);

        }

        [TestMethod]
        public void DEmailOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "doctor@gmail.com";
            // setting field to test data
            newDoctor.dEmail = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dEmail, testData);

        }

        [TestMethod]
        public void DAddressOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "81 leister drive";
            // setting field to test data
            newDoctor.dAddress = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dAddress, testData);

        }

        [TestMethod]
        public void DLastNameOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "Nullan";
            // setting field to test data
            newDoctor.dLastName = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dLastName, testData);

        }

        [TestMethod]
        public void DFirstNameOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "Nullan";
            // setting field to test data
            newDoctor.dFirstName = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dFirstName, testData);

        }

        [TestMethod]
        public void FindOk()
        { 
            // new instance of doctor
            clsDoc aDoc = new clsDoc();
            // example doc id
            Int32 docId = 2;
            // found boolean
            Boolean found = false;
            // invoke the method
            found = aDoc.Find(docId);
            //test to see if found is true
            Assert.IsTrue(found);

        }

        [TestMethod]
        public void TestDocIdFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 docId = 1;
            // invoke the method
            found = aDoc.Find(docId);
            // chaeck the doc Id
            if ( aDoc.dId != 1)
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check FirstName property
            if (aDoc.dFirstName != "Thomas")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestLastNameFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check LastName property
            if (aDoc.dLastName != "Hague")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestAddressFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check Address property
            if (aDoc.dAddress != "77 nullviewrd n23ard")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestEmailFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check Email property
            if (aDoc.dEmail != "Thague@gmail.com")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check PhoneNumber property
            if (aDoc.dPhoneNumber != "394850934")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check Availability property
            if (aDoc.dAvailability != true)
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }






    }
}
