using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager
{
    class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        //ctor + two tabs
        public Product()
        {

        }
        public Product(string c, string d, double p)
        {
            Code = c;
            Description = d;
            Price = p;
        }

        //type "public[space]override[space]" and then pick ToString()
        public override string ToString()
        {
            //concatination
            //return "code = "+Code+", description = "+ Description + ", price = " + Price.ToString("C2");
            
            //interpolation
            return $"{Code}|{Description}|{Price}";
        }
    }
}
