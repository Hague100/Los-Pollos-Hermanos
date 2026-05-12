using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstPatient
    {
        //good test data
        string patientName = "Test Name";
        string email = "testemail@test.com";
        string address = "1TestDrive,TestCity,Testshire,TE11ST";
        DateTime dateOfBirth = Convert.ToDateTime("01/01/2000");
        Int32 drId = 1;
        Boolean acessibilityReq = true;

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
            string TestData = "Test Street,Leicster,LE11AA";
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
    

    [TestMethod]

        public void FindMethodOk()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create Boolean var to store the results of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 patientId = 2;
            //invoke mthe method
            found = aPatient.Find(patientId);
            //test to see if result is true
            Assert.IsTrue(found);
        }

        [TestMethod]

        public void TestPatientIdFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create Boolean var to store the results of the validation
            Boolean found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 patientId = 6;
            //invoke mthe method
            found = aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.patientId != 6)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPNameFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create Boolean var to store the results of the validation
            Boolean found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 patientId = 6;
            //invoke mthe method
            found = aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.pName != "Test Name")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPEmailFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create Boolean var to store the results of the validation
            Boolean found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 patientId = 6;
            //invoke mthe method
            found = aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.pEmail != "test.email@testemail.com")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPDOBFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create Boolean var to store the results of the validation
            Boolean found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 patientId = 6;
            //invoke mthe method
            found = aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.pDOB != Convert.ToDateTime("01/01/2000"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPHomeAddFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create Boolean var to store the results of the validation
            Boolean found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 patientId = 6;
            //invoke mthe method
            found = aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.pHomeAdd != "1 Test Steet,TestTown,TestShire,TE11AA")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPAccessReqFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create Boolean var to store the results of the validation
            Boolean found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 patientId = 6;
            //invoke mthe method
            found = aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.pAccessReq != false)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPMainDocIdFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create Boolean var to store the results of the validation
            Boolean found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 patientId = 6;
            //invoke mthe method
            found = aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.pMainDocId != 4)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //string varible to store error message
            String Error = "";
            //invoke method
            Error = aPatient.Valid(patientName, email, address, dateOfBirth, drId, acessibilityReq);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void pNameMinLessOne()
        {
            clsPatient aPatient = new clsPatient();
            String Error = "";
            String patientName = "";
            Error = aPatient.Valid(patientName, email, address, dateOfBirth, drId, acessibilityReq);
            Assert.AreNotEqual(Error, "");
        }
    }
}
