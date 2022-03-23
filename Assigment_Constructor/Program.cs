using System;

namespace Assigment_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Tostring();

            Product p2 = new Product(10,"maggi",20000);
            p2.Tostring();


        }
    }
}
