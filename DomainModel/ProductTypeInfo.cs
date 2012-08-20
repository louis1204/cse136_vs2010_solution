using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class ProductTypeInfo
    {
        int product_type_id { get; set; }
        String product_type_name { get; set; }

        public ProductTypeInfo(int product_type_id_in, String product_type_name_in)
        {
            this.product_type_id = product_type_id_in;
            this.product_type_name = product_type_name_in;
        }
    }
}
