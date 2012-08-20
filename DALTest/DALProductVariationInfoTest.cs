using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DomainModel;
using System.Collections.Generic;

namespace DALTest
{
    
    
    /// <summary>
    ///This is a test class for DALProductVariationInfoTest and is intended
    ///to contain all DALProductVariationInfoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DALProductVariationInfoTest
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
        ///A test for CreatePV
        ///</summary>
        [TestMethod()]
        public void CreatePVTest()
        {
            char gender = 'M';
            char condition = 'a';
            char size = 'L';

            ProductVariationInfo ProductVariationInfo = new ProductVariationInfo(1, 1, 1, 1, 1, 1, gender, size, 1, (float)1, condition);// TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int result = DALProductVariationInfo.CreatePV(ProductVariationInfo, ref errors);
            int expected = 1;
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        ///A test for UpdateProductVariationInfo
        ///</summary>
        [TestMethod()]
        public void UpdateProductVariationInfoTest()
        {
            char gender = 'M';
            char condition = 'a';
            char size = 'L';

            ProductVariationInfo ProductVariationInfo = new ProductVariationInfo(1, 1, 1, 1, 1, 1, gender, size, 1, (float)1.0, condition); // TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int result = DALProductVariationInfo.UpdateProductVariationInfo(ProductVariationInfo, ref errors);
            Assert.AreEqual(1, result);
        }

        /// <summary>
        ///A test for DeleteProductVariationInfo
        ///</summary>
        [TestMethod()]
        public void DeleteProductVariationInfoTest()
        {
            int product_variation_id = 50; // TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALProductVariationInfo.DeleteProductVariationInfo(product_variation_id, ref errors);
            Assert.AreEqual(expected, actual);
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
            actual = DALProductVariationInfo.UpdateProduct(product_id, product_name, ref errors);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for UpdateBrand
        ///</summary>
        [TestMethod()]
        public void UpdateBrandTest()
        {
            int brand_id = 1; // TODO: Initialize to an appropriate value
            string brand_name = "Hello Kitty"; // TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = DALProductVariationInfo.UpdateBrand(brand_id, brand_name, ref errors);
            Assert.AreEqual(expected, actual);
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
            actual = DALProductVariationInfo.UpdateProductColor(product_color_id, product_color_name, ref errors);
            Assert.AreEqual(expected, actual);
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
            actual = DALProductVariationInfo.UpdateProductCutting(product_cutting_id, product_cutting_name, ref errors);
            Assert.AreEqual(expected, actual);
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
            actual = DALProductVariationInfo.UpdateProductType(product_type_id, product_type_name, ref errors);
            Assert.AreEqual(expected, actual);
        }
    }
}
