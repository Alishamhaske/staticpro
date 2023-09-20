using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.staticpro
{
    public class car2obj
    {
        static void Main(string[] args)
        {
            car2 c2 = new car2(2, "honda");
            Console.WriteLine(c2.display());
            car2.totalcarsold = 20;
            Console.WriteLine(c2.display());
            car2 c3 = new car2(3, "BMW");
            Console.WriteLine(c3.display());
            

        }
    }

    //3.Create two object of Car class and change value of static
    //variable by 1st object and print it by accessing 2nd object.

    class car2
    {
        public int carid;
        public string carmodel;
        public static int totalcarsold;

        public car2(int carid,string carmodel)
        {
            this.carid = carid;
            this.carmodel = carmodel;
            totalcarsold++;
        }
        public string display()
        {
            return $" carid:{carid} total car sold:{totalcarsold}";
        }


    }
}

