using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        public tstStock()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsStock clsStock = new clsStock();
            Assert.IsNotNull(clsStock);

        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock clsStock = new clsStock();
            string Error = clsStock.Valid("1", "SampleName", "2", "Food", "", DateTime.Now.ToString());
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void InvalidDate()
        {
            clsStock clsStock = new clsStock();
            string Error = clsStock.Valid("1", "SampleName", "2", "Food", "", "2022-05-32 16:36:55");
            Assert.AreEqual(Error, "Time is invalid : ");
        }

        [TestMethod]
        public void DateExtremeMin()
        {
            clsStock clsStock = new clsStock();
            string Error = clsStock.Valid("1", "SampleName", "2", "Food", "", "2021-05-01 16:36:55");
            Assert.AreEqual(Error, "The date cannot be in the past : ");
        }

        [TestMethod]
        public void DateExtremeMax()
        {
            clsStock clsStock = new clsStock();
            string Error = clsStock.Valid("1", "SampleName", "2", "Food", "", "2022-05-29 16:36:55");
            Assert.AreEqual(Error, "The date cannot be in the future : ");
        }


        [TestMethod]
        public void TestStockNotFound() {
            clsStock AnStock = new clsStock();
            AnStock.Id = "1";
            Boolean Found = false;  
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AnStock.Find(Convert.ToString(StockID));
            if(AnStock.Id.Equals("1"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBlankName() {
            clsStock clsStock = new clsStock();
            string Error = clsStock.Valid("1", "", "2", "Food", "", DateTime.Now.ToString());
            Assert.AreEqual(Error, "Name should not be blank : ");
        }

        [TestMethod]
        public void TestTooLongName()
        {
            clsStock clsStock = new clsStock();
            string Error = clsStock.Valid("1", "XXXXXXXXXX YYYYYYYYYY", "2", "Food", "", DateTime.Now.ToString());
            Assert.AreEqual(Error, "The length of name is greater than 20 : ");
        }

        public void TestModifyDateFound()
        {
            clsStock AnStock = new clsStock();
            AnStock.Time = "16/09/2015";
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = AnStock.Find(Convert.ToString(StockID));
            if(AnStock.Time != Convert.ToDateTime("16/09/2015").ToString())
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        // Add more test for Find()?


        [TestMethod]
        public void FindStockOK() // dummy
        {
            clsStock clsStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = clsStock.Find(Convert.ToString(StockID));
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void StockIdPropertyOK()
        {
            clsStock clsStock = new clsStock();
            string TestData = "123";
            clsStock.Id = TestData;
            Assert.AreEqual(clsStock.Id, TestData);

        }

        public void StockNamePropertyOK()
        {
            clsStock clsStock = new clsStock();
            string TestData = "sample";
            clsStock.Name = TestData;
            Assert.AreEqual(clsStock.Name, TestData);

        }

        public void StockTypePropertyOK()
        {
            clsStock AnStock = new clsStock();
            AnStock.Type = "Food";
            Assert.AreEqual(AnStock.Type, "Food");

        }


    }
}
