using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstRoom
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //test to see that it exists
            Assert.IsNotNull(ARoom);
        }
    }
}
