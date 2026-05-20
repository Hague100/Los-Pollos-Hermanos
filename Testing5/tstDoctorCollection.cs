using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstDoctorCollection
    {
        [TestMethod]
        public void InstnceOk()
        {
            // intitialese an instance of the class
            clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
            // test to see if the class/that exists
            Assert.IsNotNull(testDoctorCollection);
        }

        [TestMethod]
        public void DoctorCollectionOk()
        {
            // intitialese an instance of the class
            clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
            // create test data to assignt to the property
            // the test data in this case is a list of objects
            List<clsDoc> testDoctorList = new List<clsDoc>();
            // add item to the list
            // create the item of test data
            clsDoc testDoctor = new clsDoc();
            // set its properties
            testDoctor.dId = 1;
            testDoctor.dFirstName = "Niche";
            testDoctor.dLastName = "cazoi";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            // add the item to the test list
            testDoctorList.Add(testDoctor);
            // assign the data to the property
            testDoctorCollection.doctorList = testDoctorList;
            // test to see that the two values are the same
            Assert.AreEqual(testDoctorCollection.doctorList, testDoctorList);
        }

        //[TestMethod]

        //public void CountPropertyOk()
        //{
        //    // new instance of clsDoctorCollection
        //    clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
        //    // test data
        //    Int32 testCount = 2;
        //    // assign the data to the property
        //    testDoctorCollection.count = testCount;
        //    // make sure the two values are the same
        //    Assert.AreEqual(testDoctorCollection.count, testCount);
        //}

        [TestMethod]

        public void ThisDoctorPropertyOk()
        {
            // create instance of clsDoctorCollection
            clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
            // test data
            clsDoc testDoctor = new clsDoc();
            // set its properties
            testDoctor.dId = 1;
            testDoctor.dFirstName = "Niche";
            testDoctor.dLastName = "cazoi";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            // assign the test data to the property
            testDoctorCollection.thisDoctor = testDoctor;
            Assert.AreEqual(testDoctorCollection.thisDoctor, testDoctor);
        }

        [TestMethod]

        public void ListAndCountOk()
        {
            // create instance of clsDoctorCollection
            clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
            // test data
            List<clsDoc> testDoctorList = new List<clsDoc>();
            clsDoc testDoctor = new clsDoc();
            // set its properties
            testDoctor.dId = 1;
            testDoctor.dFirstName = "Niche";
            testDoctor.dLastName = "cazoi";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            // assign the test data to the property
            testDoctorList.Add(testDoctor);
            testDoctorCollection.doctorList = testDoctorList;
            Assert.AreEqual(testDoctorCollection.count, testDoctorList.Count);
        }

        //[TestMethod]

        //public void TwoRecordsPresent()
        //{
        //    // instance of clsDoctorCollection
        //    clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
        //    // see if two values are the same
        //    Assert.AreEqual(testDoctorCollection.count, 2);
        //}


        [TestMethod]

        public void AddMethodOk()
        {
            // create an instance of doctors list
            clsDoctorCollection allDoctors = new clsDoctorCollection();
            // create test data
            clsDoc testDoctor = new clsDoc();
            // variable to store the primary key
            Int32 primaryKey = 0;
            // set properties
            testDoctor.dFirstName = "ADD";
            testDoctor.dLastName = "Method";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            // sett thisdoctor to the test doctor
            allDoctors.thisDoctor = testDoctor;
            // add the record
            primaryKey = allDoctors.Add();
            // set the primary key of the test data 
            testDoctor.dId = primaryKey;
            // find the record   
            allDoctors.thisDoctor.Find(primaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(allDoctors.thisDoctor, testDoctor);
        }

        [TestMethod]

        public void UpdateMethodOk()
        {
            // create an instance of doctors list
            clsDoctorCollection allDoctors = new clsDoctorCollection();
            // create test data
            clsDoc testDoctor = new clsDoc();
            // variable to store the primary key
            Int32 primaryKey = 0;
            // set properties
            testDoctor.dFirstName = "Update";
            testDoctor.dLastName = "Method";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            // sett thisdoctor to the test doctor
            allDoctors.thisDoctor = testDoctor;
            // add the record
            primaryKey = allDoctors.Add();
            // set the primary key of the test data 
            testDoctor.dId = primaryKey;
            // modify the record
            testDoctor.dFirstName = "UpdatedOne";
            testDoctor.dLastName = "Method";
            testDoctor.dAddress = "34 Drive Drive";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = false;
            // update the record
            allDoctors.Update();
            // find the record
            allDoctors.thisDoctor.Find(primaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(allDoctors.thisDoctor, testDoctor);
        }

    }

}
