using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class BrandList
    {
        List<BrandInfo> brands = new List<BrandInfo>();

        public BrandList()
        {
            for (int i = 0; i < 10; i++)
            {
                brands.Add(new BrandInfo(i, "Nike Plus" + i));
            }
        }

        public List<BrandInfo> GetBrandList()
        {
            return brands;
        }

        public BrandInfo GetBrandDetail(int brand_id)
        {
            return brands[brand_id];
        }
    }
}
