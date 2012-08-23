﻿using DAL;
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

            ProductVariationInfo ProductVariationInfo = new ProductVariationInfo(1, 1, 1, 1, 1, 1, gender, "L", 1, (float)1.0, condition);// TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int result = DALProductVariationInfo.CreatePV(ProductVariationInfo, ref errors);
            System.Diagnostics.Debug.WriteLine("RESULT:" + result);
            ProductVariationInfo pv = DALProductVariationInfo.ReadPVDetail(result, ref errors);

            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.product_id);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.product_brand_id);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.product_cutting_id);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.product_color_id);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.product_type_id);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.sex);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.size);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.stock);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.price);
            System.Diagnostics.Debug.WriteLine("RESULT:" + pv.condition);

            Assert.AreEqual(pv.product_id, ProductVariationInfo.product_id);
            Assert.AreEqual(pv.product_brand_id, ProductVariationInfo.product_brand_id);
            Assert.AreEqual(pv.product_cutting_id, ProductVariationInfo.product_cutting_id);
            Assert.AreEqual(pv.product_color_id, ProductVariationInfo.product_color_id);
            Assert.AreEqual(pv.product_type_id, ProductVariationInfo.product_type_id);
            Assert.AreEqual(pv.sex, ProductVariationInfo.sex);
            Assert.AreEqual(pv.size, ProductVariationInfo.size);
            Assert.AreEqual(pv.stock, ProductVariationInfo.stock);
            Assert.AreEqual(pv.price, ProductVariationInfo.price);
            Assert.AreEqual(pv.condition, ProductVariationInfo.condition);
        }

        /// <summary>
        ///A test for UpdateProductVariationInfo
        ///</summary>
        [TestMethod()]
        public void UpdateProductVariationInfoTest()
        {
            char gender = 'M';
            char condition = 'a';

            ProductVariationInfo ProductVariationInfo = new ProductVariationInfo(1, 2, 2, 2, 2, 2, gender, "L", 2, (float)1.0, condition); // TODO: Initialize to an appropriate value
            List<string> errors = new List<string>(); // TODO: Initialize to an appropriate value
            List<string> errorsExpected = new List<string>(); // TODO: Initialize to an appropriate value
            int result = DALProductVariationInfo.UpdateProductVariationInfo(ProductVariationInfo, ref errors);
            ProductVariationInfo pv = new ProductVariationInfo(DALProductVariationInfo.ReadPVDetail(1, ref errors).product_variation_id,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).product_id,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).product_brand_id,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).product_cutting_id,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).product_color_id,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).product_type_id,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).sex,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).size,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).stock,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).price,
                DALProductVariationInfo.ReadPVDetail(1, ref errors).condition);
            Assert.AreEqual(1, result);
            Assert.AreEqual(pv.product_variation_id, 1);
            Assert.AreEqual(pv.product_id, 2);
            Assert.AreEqual(pv.product_brand_id, 2);
            Assert.AreEqual(pv.product_cutting_id, 2);
            Assert.AreEqual(pv.product_color_id, 2);
            Assert.AreEqual(pv.product_type_id, 2);
            Assert.AreEqual(pv.sex, gender);
            Assert.AreEqual(pv.size, "L");
            Assert.AreEqual(pv.stock, 2);
            Assert.AreEqual(pv.price, (float)1.0);
            Assert.AreEqual(pv.condition, condition);
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
            ProductVariationInfo pv = DALProductVariationInfo.ReadPVDetail(50, ref errors);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual('d', pv.condition);
        }
    }
}
