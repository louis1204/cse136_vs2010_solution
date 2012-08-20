using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductCuttingInfo
    {
        int product_cutting_id { get; set; }
        String product_cutting_name { get; set; }

        public ProductCuttingInfo(int product_cutting_id_in, String product_cutting_name_in)
        {
            this.product_cutting_id = product_cutting_id_in;
            this.product_cutting_name = product_cutting_name_in;
        }
    }
}
