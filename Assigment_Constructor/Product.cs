using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_Constructor
{
    public class Product
    {
        private int product_code;
        private string product_Name;
        private int product_price;
         
        public Product()
        {
            product_code = 101;
            product_Name = "Parle";
            product_price = 15000;
        }

        public Product(int product_code,string product_name,int product_price)
        {
            this.product_code = product_code;
            this.product_Name = product_name;
            this.product_price = product_price;
        }

        public string Tostring()
        {
            return "product code= " + product_code + "Product name= " + product_Name + " product price= " + product_price;
        }

    }
}
