using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductColorList
    {
        List<ProductColorInfo> ProductColors = new List<ProductColorInfo>();

        public ProductColorList()
        {
            for (int i = 0; i < 10; i++)
            {
                ProductColors.Add(new ProductColorInfo(i, "Red" + i));
            }
        }

        public List<ProductColorInfo> GetProductColorList()
        {
            return ProductColors;
        }

        public ProductColorInfo GetProductColorDetail(int ProductColor_id)
        {
            return ProductColors[ProductColor_id];
        }
    }
}
