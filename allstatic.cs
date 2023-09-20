using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.staticpro
{
    public class allstatic
    {
        static void Main(string[] args)
        {
            product.get();
            product.getdiscount();

        }
    }
    //static class product

    static class product
    {
        public static int pro_id;
        public static string pro_name;
        public static int proprice;

        static product()
        {
            pro_id = 101;
            pro_name = "guitar";
            proprice = 500;
        }
        public static void get()
        {
            Console.WriteLine($"product id:{pro_id}");
            Console.WriteLine($"product name:{pro_name}");
            Console.WriteLine($"product price: {proprice}");

        }
        public static void getdiscount()
        {
            int d_amt = proprice / 10;
            Console.WriteLine(d_amt);
            Console.WriteLine("price is:"+( proprice-d_amt));
        }
     


    }
}
