using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductCuttingList
    {
        public List<ProductCuttingInfo> ProductCuttings = new List<ProductCuttingInfo>();

        public ProductCuttingList()
        {
            for (int i = 0; i < 10; i++)
            {
                ProductCuttings.Add(new ProductCuttingInfo(i, "Adult" + i));
            }
        }

        public List<ProductCuttingInfo> GetProductCuttingList()
        {
            return ProductCuttings;
        }

        public ProductCuttingInfo GetProductCuttingDetail(int ProductCutting_id)
        {
            return ProductCuttings[ProductCutting_id];
        }
    }
}
