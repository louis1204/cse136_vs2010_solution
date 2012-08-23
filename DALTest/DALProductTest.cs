using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using DomainModel;

namespace DALTest
{
    
    
    /// <summary>
    ///This is a test class for DALProductTest and is intended
    ///to contain all DALProductTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DALProductTest
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
        ///A test for CreateProduct
        ///</summary>
        [TestMethod()]
        public void CreateProductTest()
        {
            string product_name = string.Empty; // TODO: Initialize to an appropriate value
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALProduct.CreateProduct(product_name, ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadProductDetail
        ///</summary>
        [TestMethod()]
        public void ReadProductDetailTest()
        {
            int product_id = 0; // TODO: Initialize to an appropriate value
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            ProductInfo expected = null; // TODO: Initialize to an appropriate value
            ProductInfo actual;
            actual = DALProduct.ReadProductDetail(product_id, ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadProductList
        ///</summary>
        [TestMethod()]
        public void ReadProductListTest()
        {
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            List<ProductInfo> expected = null; // TODO: Initialize to an appropriate value
            List<ProductInfo> actual;
            actual = DALProduct.ReadProductList(ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateProduct
        ///</summary>
        [TestMethod()]
        public void UpdateProductTest()
        {
            int product_id = 1; // TODO: Initialize to an appropriate value
            string product_name = "Hello Kitty"; // TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALProduct.UpdateProduct(product_id, product_name, ref errors);
            Assert.AreEqual(expected, actual);
        }
    }
}
