using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using DomainModel;

namespace DALTest
{
    
    
    /// <summary>
    ///This is a test class for DALProductCuttingTest and is intended
    ///to contain all DALProductCuttingTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DALProductCuttingTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CreateProductCutting
        ///</summary>
        [TestMethod()]
        public void CreateProductCuttingTest()
        {
            string product_cutting_name = string.Empty; // TODO: Initialize to an appropriate value
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALProductCutting.CreateProductCutting(product_cutting_name, ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadProductCuttingDetail
        ///</summary>
        [TestMethod()]
        public void ReadProductCuttingDetailTest()
        {
            int product_cutting_id = 0; // TODO: Initialize to an appropriate value
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            ProductCuttingInfo expected = null; // TODO: Initialize to an appropriate value
            ProductCuttingInfo actual;
            actual = DALProductCutting.ReadProductCuttingDetail(product_cutting_id, ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadProductCuttingList
        ///</summary>
        [TestMethod()]
        public void ReadProductCuttingListTest()
        {
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            List<ProductCuttingInfo> expected = null; // TODO: Initialize to an appropriate value
            List<ProductCuttingInfo> actual;
            actual = DALProductCutting.ReadProductCuttingList(ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateProductCutting
        ///</summary>
        [TestMethod()]
        public void UpdateProductCuttingTest()
        {
            int product_cutting_id = 1; // TODO: Initialize to an appropriate value
            string product_cutting_name = "Midget"; // TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALProductCutting.UpdateProductCutting(product_cutting_id, product_cutting_name, ref errors);
            Assert.AreEqual(expected, actual);
        }
    }
}
