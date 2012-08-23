using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using DomainModel;

namespace DALTest
{
    
    
    /// <summary>
    ///This is a test class for DALProductColorTest and is intended
    ///to contain all DALProductColorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DALProductColorTest
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
        ///A test for CreateProductColor
        ///</summary>
        [TestMethod()]
        public void CreateProductColorTest()
        {
            string product_color_name = string.Empty; // TODO: Initialize to an appropriate value
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALProductColor.CreateProductColor(product_color_name, ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadProductColorDetail
        ///</summary>
        [TestMethod()]
        public void ReadProductColorDetailTest()
        {
            int product_color_id = 0; // TODO: Initialize to an appropriate value
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            ProductColorInfo expected = null; // TODO: Initialize to an appropriate value
            ProductColorInfo actual;
            actual = DALProductColor.ReadProductColorDetail(product_color_id, ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadProductColorList
        ///</summary>
        [TestMethod()]
        public void ReadProductColorListTest()
        {
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            List<ProductColorInfo> expected = null; // TODO: Initialize to an appropriate value
            List<ProductColorInfo> actual;
            actual = DALProductColor.ReadProductColorList(ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateProductColor
        ///</summary>
        [TestMethod()]
        public void UpdateProductColorTest()
        {
            int product_color_id = 1; // TODO: Initialize to an appropriate value
            string product_color_name = "Tumeric Yellow"; // TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALProductColor.UpdateProductColor(product_color_id, product_color_name, ref errors);
            Assert.AreEqual(expected, actual);
        }
    }
}
