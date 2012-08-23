using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductVariationList
    {
        public List<ProductVariationInfo> product_variations = new List<ProductVariationInfo>();

        public ProductVariationList()
        {
            for (int i = 0; i < 10; i++)
            {
                product_variations.Add(new ProductVariationInfo(i, i, i, i, i, i, 'M', "L", i, (float)i, 'a' ));
            }
        }

        public List<ProductVariationInfo> GetProductVariationList()
        {
            return product_variations;
        }

        public ProductVariationInfo GetProductVariationDetail(int producuct_variation_id)
        {
            return product_variations[producuct_variation_id];
        }
    }
}
