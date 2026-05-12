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
        [TestMethod]
        public void PatientIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aPatient.patientId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.patientId, TestData);

        }

        [TestMethod]
        public void PNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            string TestData = "Test Name";
            //assign the data to the property
            aPatient.pName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.pName, TestData);

        }

        [TestMethod]
        public void pEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            string TestData = "test.email@testemail.com";
            //assign the data to the property
            aPatient.pEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.pEmail, TestData);

        }

        [TestMethod]
        public void PPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            String TestData = "0789 123456";
            //assign the data to the property
            aPatient.pPhoneNO = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.pPhoneNO, TestData);

        }

        [TestMethod]
        public void PDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aPatient.pDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.pDOB, TestData);

        }

        [TestMethod]
        public void PHomeAddPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            String TestData = "Test Street,Leicster,LE11AA";
            //assign the data to the property
            aPatient.pHomeAdd = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.pHomeAdd, TestData);

        }

        [TestMethod]
        public void PAccessReqPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aPatient.pAccessReq = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.pAccessReq, TestData);

        }

        [TestMethod]
        public void PMainDocID()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            aPatient.pMainDocId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.pMainDocId, TestData);

        }
    }
}
