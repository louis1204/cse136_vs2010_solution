using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductTypeList
    {
        List<ProductTypeInfo> ProductTypes = new List<ProductTypeInfo>();

        public ProductTypeList()
        {
            for (int i = 0; i < 10; i++)
            {
                ProductTypes.Add(new ProductTypeInfo(i, "Tank" + i));
            }
        }

        public List<ProductTypeInfo> GetProductTypeList()
        {
            return ProductTypes;
        }

        public ProductTypeInfo GetProductTypeDetail(int ProductType_id)
        {
            return ProductTypes[ProductType_id];
        }
    }
}
