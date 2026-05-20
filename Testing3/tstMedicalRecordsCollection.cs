using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstMedicalRecordCollection
    {
        [TestMethod]
        public void InstnceOk()
        {
            // create an instanceof the class we want to create
            clsMedicalRecordCollection AllMedicalRecords = new clsMedicalRecordCollection();
            // test to see that it exists
            Assert.IsNotNull(AllMedicalRecords);
        }

        [TestMethod]
        public void MedicalRecordListOk()
        {
            // create an instance of the class we want to create
            clsMedicalRecordCollection AllMedicalRecords = new clsMedicalRecordCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsMedicalRecords> TestList = new List<clsMedicalRecords>();
            // add an item to the list
            // create the item of test data
            clsMedicalRecords TestItem = new clsMedicalRecords();
            // set its properties
            TestItem.recordId = 1;
            TestItem.patientId = 1;
            TestItem.AppID = 1;
            TestItem.PendingApp = true;
            TestItem.AppNotes = "Test Notes";
            TestItem.doctorId = 1;
            TestItem.Date = DateTime.Now.Date;
            // add the dat to the list
            TestList.Add(TestItem);
            // assign the data to the property
            AllMedicalRecords.MedicalRecordList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllMedicalRecords.MedicalRecordList, TestList);
        }

        [TestMethod]
        public void ThisMedicalRecordOk()
        {
            // create an instance of the class we want to create
            clsMedicalRecordCollection AllMedicalRecords = new clsMedicalRecordCollection();
            // create some test data to assign to the medical record
            clsMedicalRecords TestRecord = new clsMedicalRecords();
            // set the properties of the test object
            TestRecord.recordId = 1;
            TestRecord.patientId = 1;
            TestRecord.AppID = 1;
            TestRecord.PendingApp = true;
            TestRecord.AppNotes = "Test Notes";
            TestRecord.doctorId = 1;
            TestRecord.Date = DateTime.Now.Date;
            // assign the data to the data
            AllMedicalRecords.ThisMedicalRecord = TestRecord;
            // test to see that the two values are the same
            Assert.AreEqual(AllMedicalRecords.ThisMedicalRecord, TestRecord);
        }


        [TestMethod]
        public void ListAndCountOk()
        {
            // create an instance of the class we want to create
            clsMedicalRecordCollection AllMedicalRecords = new clsMedicalRecordCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsMedicalRecords> TestList = new List<clsMedicalRecords>();
            // add an item to the list
            // create the item of test data
            clsMedicalRecords TestItem = new clsMedicalRecords();
            // set its properties
            TestItem.recordId = 1;
            TestItem.patientId = 1;
            TestItem.AppID = 1;
            TestItem.PendingApp = true;
            TestItem.AppNotes = "Test Notes";
            TestItem.doctorId = 1;
            TestItem.Date = DateTime.Now.Date;
            // add the dat to the list
            TestList.Add(TestItem);
            // assign the data to the property
            AllMedicalRecords.MedicalRecordList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllMedicalRecords.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOk()
        {

            //create an instance of the class we want to create
            clsMedicalRecordCollection AllMedicalRecords = new clsMedicalRecordCollection();
            // create the item of the test data
            clsMedicalRecords TestItem = new clsMedicalRecords();
            // variable to stor the primary key 
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.recordId = 1;
            TestItem.patientId = 1;
            TestItem.appID = 1;
            TestItem.PendingApp = true;
            TestItem.AppNotes = "Test Notes";
            TestItem.doctorId = 1;
            TestItem.Date = DateTime.Now.Date;
            // set ThisMedicalRecord to the test data
            AllMedicalRecords.ThisMedicalRecord = TestItem;
            // add the record
            PrimaryKey = AllMedicalRecords.Add();
            // set the primary key of the test data
            TestItem.recordId = PrimaryKey;
            // find the record
            AllMedicalRecords.ThisMedicalRecord.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllMedicalRecords.ThisMedicalRecord, TestItem);

        }

        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecordCollection AllMedicalRecords = new clsMedicalRecordCollection();
            // create the item of the test data 
            clsMedicalRecords TestItem = new clsMedicalRecords();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set the properties
            TestItem.recordId = 1;
            TestItem.patientId = 1;
            TestItem.appID = 1;
            TestItem.PendingApp = true;
            TestItem.AppNotes = "Test Notes";
            TestItem.doctorId = 1;
            TestItem.Date = DateTime.Now.Date;
            // set ThisMedicalRecord to the test data
            AllMedicalRecords.ThisMedicalRecord = TestItem;
            // add the record
            PrimaryKey = AllMedicalRecords.Add();
            // set the primary key of the test data
            TestItem.recordId = PrimaryKey;
            // modify the test data
            TestItem.patientId = 2;
            TestItem.appID = 2;
            TestItem.PendingApp = false;
            TestItem.AppNotes = "Updated Test Notes";
            TestItem.doctorId = 2;
            TestItem.Date = DateTime.Now.Date;
            // set the record based on the new test data
            AllMedicalRecords.ThisMedicalRecord = TestItem;
            // update the record
            AllMedicalRecords.Update();
            // find the record
            AllMedicalRecords.ThisMedicalRecord.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllMedicalRecords.ThisMedicalRecord, TestItem);
        }
    }
}