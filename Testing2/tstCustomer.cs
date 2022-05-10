using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(CustomerMember);
        }

        [TestMethod]
        public void RegistStatusOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            CustomerMember.RegistStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.RegistStatus, TestData);
        }

        [TestMethod]
        public void UserIdOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            Int32 TestData = 123456;
            //assign the data to the property
            CustomerMember.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.UserId, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            Int32 TestData = 123456;
            //assign the data to the property
            CustomerMember.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.PhoneNumber, TestData);
        }

        [TestMethod]
        public void PassWordOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            Int32 TestData = 123456;
            //assign the data to the property
            CustomerMember.PassWord = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.PassWord, TestData);
        }

        [TestMethod]
        public void UserNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer CustomerMember = new clsCustomer();
            //create some test data
            string TestData = "Michael Jordan";
            //assign the data to the property
            CustomerMember.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerMember.UserName, TestData);
        }
    }
}
