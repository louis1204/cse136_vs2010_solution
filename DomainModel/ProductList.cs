using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductList
    {
        public List<ProductInfo> products = new List<ProductInfo>();

        public ProductList()
        {
            for (int i = 0; i < 10; i++)
            {
                products.Add(new ProductInfo(i, "Nike " + i));
            }
        }

        public List<ProductInfo> GetProductList()
        {
            return products;
        }

        public ProductInfo GetProductDetail(int product_id)
        {
            return products[product_id];
        }
    }
}
