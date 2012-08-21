using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DomainModel;


namespace BL
{
    public static class BLProductVariation
    {
        public static void CreatePV(ProductVariationInfo productVariation, ref List<string> errors)
        {
            if (productVariation == null)
            {
                errors.Add("Product Variation cannot be null");
            }

            else if (productVariation.product_id <= 0)
            {
                errors.Add("Invalid product_id");
            }

            else if (productVariation.product_brand_id <= 0)
            {
                errors.Add("Invalid product_brand_d");
            }
            else if (productVariation.product_cutting_id <= 0)
            {
                errors.Add("Invalid product_cutting_id");
            }
            else if (productVariation.product_color_id <= 0)
            {
                errors.Add("Invalid product_color_id");
            }
            else if (productVariation.sex != 'F' || productVariation.sex != 'M' || productVariation.sex != 'U')
            {
                errors.Add("Invalid sex");
            }
            else if (productVariation.size != "XS" || productVariation.size != "S" || productVariation.size != "M" || productVariation.size != "L" || productVariation.size != "XL" || productVariation.size != "XXL")
            {
                errors.Add("Invalid size");
            }
            else if (productVariation.stock < 0)
            {
                errors.Add("Invalid stock");
            }
            else if (productVariation.price < 0)
            {
                errors.Add("Invalid price");
            }
            else if (productVariation.condition != 'a' || productVariation.condition != 's' || productVariation.condition != 'd')
            {
                errors.Add("Invalid condition");
            }

            if (errors.Count > 0)
                return;

            DALProductVariationInfo.CreatePV(productVariation, ref errors);
        }

        public static void UpdatePV(ProductVariationInfo productVariation, ref List<string> errors)
        {
            if (productVariation == null)
            {
                errors.Add("Product Variation cannot be null");
            }

            else if (productVariation.product_variation_id <= 0)
            {
                errors.Add("Invalid product_variation_id");
            }

            else if (productVariation.product_id <= 0)
            {
                errors.Add("Invalid product_id");
            }

            else if (productVariation.product_brand_id <= 0)
            {
                errors.Add("Invalid product_brand_d");
            }
            else if (productVariation.product_cutting_id <= 0)
            {
                errors.Add("Invalid product_cutting_id");
            }
            else if (productVariation.product_color_id <= 0)
            {
                errors.Add("Invalid product_color_id");
            }
            else if (productVariation.sex != 'F' || productVariation.sex != 'M' || productVariation.sex != 'U')
            {
                errors.Add("Invalid sex");
            }
            else if (productVariation.size != "XS" || productVariation.size != "S" || productVariation.size != "M" || productVariation.size != "L" || productVariation.size != "XL" || productVariation.size != "XXL")
            {
                errors.Add("Invalid size");
            }
            else if (productVariation.stock < 0)
            {
                errors.Add("Invalid stock");
            }
            else if (productVariation.price < 0)
            {
                errors.Add("Invalid price");
            }
            else if (productVariation.condition != 'a' || productVariation.condition != 's' || productVariation.condition != 'd')
            {
                errors.Add("Invalid condition");
            }

            if (errors.Count > 0)
                return;

            DALProductVariationInfo.UpdateProductVariationInfo(productVariation, ref errors);
        }

        public static void DeletePV(int productVariationId, ref List<string> errors)
        {
            if (productVariationId <= 0)
            {
                errors.Add("Product Variation cannot be less than 0");
            }

            if (errors.Count > 0)
                return;

            DALProductVariationInfo.DeleteProductVariationInfo(productVariationId, ref errors);
        }

        public static void UpdateProduct(int productId, string productName, ref List<string> errors)
        {
            if (productId <= 0)
            {
                errors.Add("Product Id cannot be less than 0");
            }

            if (errors.Count > 0)
                return;

            DALProductVariationInfo.UpdateProduct(productId, productName, ref errors);
        }

        public static void UpdateBrand(int brandId, string brandName, ref List<string> errors)
        {
            if (brandId <= 0)
            {
                errors.Add("brand Id cannot be less than 0");
            }

            if (errors.Count > 0)
                return;

            DALProductVariationInfo.UpdateBrand(brandId, brandName, ref errors);
        }

        public static void UpdateProductColor(int productColorId, string productColorName, ref List<string> errors)
        {
            if (productColorId <= 0)
            {
                errors.Add("productColorId cannot be less than 0");
            }

            if (errors.Count > 0)
                return;

            DALProductVariationInfo.UpdateProductColor(productColorId, productColorName, ref errors);
        }

        public static void UpdateProductCutting(int productCuttingId, string productCuttingName, ref List<string> errors)
        {
            if (productCuttingId <= 0)
            {
                errors.Add("productCuttingId cannot be less than 0");
            }

            if (errors.Count > 0)
                return;

            DALProductVariationInfo.UpdateProductCutting(productCuttingId, productCuttingName, ref errors);
        }

        public static void UpdateProductType(int productTypeId, string productTypeName, ref List<string> errors)
        {
            if (productTypeId <= 0)
            {
                errors.Add("productTypeId cannot be less than 0");
            }

            if (errors.Count > 0)
                return;

            DALProductVariationInfo.UpdateProductType(productTypeId, productTypeName, ref errors);
        }
    }
}
