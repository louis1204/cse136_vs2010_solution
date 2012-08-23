using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using DomainModel;

namespace DALTest
{
    
    
    /// <summary>
    ///This is a test class for DALTypeTest and is intended
    ///to contain all DALTypeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DALTypeTest
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
        ///A test for CreateProductType
        ///</summary>
        [TestMethod()]
        public void CreateProductTypeTest()
        {
            string product_type_name = string.Empty; // TODO: Initialize to an appropriate value
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALType.CreateProductType(product_type_name, ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadProductTypeDetail
        ///</summary>
        [TestMethod()]
        public void ReadProductTypeDetailTest()
        {
            int product_type_id = 0; // TODO: Initialize to an appropriate value
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            ProductTypeInfo expected = null; // TODO: Initialize to an appropriate value
            ProductTypeInfo actual;
            actual = DALType.ReadProductTypeDetail(product_type_id, ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReadProductTypeList
        ///</summary>
        [TestMethod()]
        public void ReadProductTypeListTest()
        {
            List<string> errors = null; // TODO: Initialize to an appropriate value
            List<string> errorsExpected = null; // TODO: Initialize to an appropriate value
            List<ProductTypeInfo> expected = null; // TODO: Initialize to an appropriate value
            List<ProductTypeInfo> actual;
            actual = DALType.ReadProductTypeList(ref errors);
            Assert.AreEqual(errorsExpected, errors);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateProductType
        ///</summary>
        [TestMethod()]
        public void UpdateProductTypeTest()
        {
            int product_type_id = 1; // TODO: Initialize to an appropriate value
            string product_type_name = "Football"; // TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALType.UpdateProductType(product_type_id, product_type_name, ref errors);
            Assert.AreEqual(expected, actual);
        }
    }
}
