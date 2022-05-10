using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff

    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staffMember = new clsStaff();
            Assert.IsNotNull(staffMember);

        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            Int32 TestData = 442135;
            staffMember.StaffId = TestData;
            Assert.AreEqual(staffMember.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            String TestData = "John Stone";
            staffMember.StaffName = TestData;
            Assert.AreEqual(staffMember.StaffName, TestData);
        }

        [TestMethod]
        public void StaffDateAddedPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            staffMember.StaffDateAdded = TestData;
            Assert.AreEqual(staffMember.StaffDateAdded, TestData);
        }

        [TestMethod]
        public void StaffUsernamePropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            String TestData = "J.Stone23";
            staffMember.StaffUsername = TestData;
            Assert.AreEqual(staffMember.StaffUsername, TestData);
        }

        [TestMethod]
        public void StaffPasswordPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            String TestData = "password123";
            staffMember.StaffPassword = TestData;
            Assert.AreEqual(staffMember.StaffPassword, TestData);
        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            Int32 TestData = 10000;
            staffMember.StaffSalary = TestData;
            Assert.AreEqual(staffMember.StaffSalary, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            String TestData = "Chef";
            staffMember.StaffRole = TestData;
            Assert.AreEqual(staffMember.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffMngrPropertyOK()
        {
            clsStaff staffMember = new clsStaff();
            Boolean TestData = true;
            staffMember.StaffMngr = TestData;
            Assert.AreEqual(staffMember.StaffMngr, TestData);
        }


    }
}
