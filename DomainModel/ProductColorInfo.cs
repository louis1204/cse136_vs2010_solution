using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductColorInfo
    {
        private int product_Color_id { get; set; }
        private String product_Color_name { get; set; }

        public ProductColorInfo(int product_Color_id_in, String product_Color_name_in)
        {
            this.product_Color_id = product_Color_id_in;
            this.product_Color_name = product_Color_name_in;
        }
    }
}
