using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using DomainModel;

namespace BLTest
{
    [TestClass]
    public class BLProductVariationTest
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

        [TestMethod]
        public void CreatePVErrorTest()
        {
            List<string> errors = new List<string>();

            BLProductVariation.CreatePV(null, ref errors);
            Assert.AreEqual(1, errors.Count);
        }

        [TestMethod]
        public void DeletePVErrorTest()
        {
            List<string> errors = new List<string>();

            BLProductVariation.DeletePV(0, ref errors);
            Assert.AreEqual(1, errors.Count);
        }

        [TestMethod]
        public void UpdatePVErrorTest()
        {
            List<string> errors = new List<string>();

            BLProductVariation.UpdatePV(null, ref errors);
            Assert.AreEqual(1, errors.Count);
        }

        [TestMethod]
        public void UpdateProductErrorTest()
        {
            List<string> errors = new List<string>();

            BLProductVariation.UpdateProduct(0, "", ref errors);
            Assert.AreEqual(1, errors.Count);
        }

        [TestMethod]
        public void UpdateBrandErrorTest()
        {
            List<string> errors = new List<string>();

            BLProductVariation.UpdateBrand(0, "", ref errors);
            Assert.AreEqual(1, errors.Count);
        }

        [TestMethod]
        public void UpdateProductColorErrorTest()
        {
            List<string> errors = new List<string>();

            BLProductVariation.UpdateProductColor(0, "", ref errors);
            Assert.AreEqual(1, errors.Count);
        }

        [TestMethod]
        public void UpdateProductCuttingErrorTest()
        {
            List<string> errors = new List<string>();

            BLProductVariation.UpdateProductCutting(0, "", ref errors);
            Assert.AreEqual(1, errors.Count);
        }

        [TestMethod]
        public void UpdateProductTypeErrorTest()
        {
            List<string> errors = new List<string>();

            BLProductVariation.UpdateProductType(0, "", ref errors);
            Assert.AreEqual(1, errors.Count);
        }
    }
}
