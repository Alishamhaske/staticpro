using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.staticpro
{
    public class car
    {
        static void Main(string[] args)
        {
            car1 c1 = new car1(1, "honda");
            car1.total();
            Console.WriteLine(c1.show());

            car1 c2 = new car1(2, "mahindra");
            car1.total();
            Console.WriteLine(c2.show());

            car1 c3 = new car1(2, "BMW");
            car1.total();
            Console.WriteLine(c3.show());

        }
    }

    //1.	Create a class Car with String model and int totalCarSold as static variable in main() method.

    class car1
    {
        private int carid;
        private string modelname;
        static int totalcarsold;

        public car1(int carid, string modelname)
        {
            this.carid = carid;
            this.modelname = modelname;


        }
        public static int total()
        {
            totalcarsold++;
            return totalcarsold;
        }
        public string show()
        {
            return $"carid:{carid}modelname: {modelname}  totolcarsold: {totalcarsold}";
        }
            


    }



}
