using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductColorInfo
    {
        public int product_color_id { get; set; }
        public String product_color_name { get; set; }

        public ProductColorInfo(int product_color_id_in, String product_color_name_in)
        {
            this.product_color_id = product_color_id_in;
            this.product_color_name = product_color_name_in;
        }
    }
}
