using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.staticpro
{
    public class changevalue
    {
        static void Main(string[] args)
        {
            changenum c2 = new changenum();
            changenum.id = 20;
            Console.WriteLine(c2.show());
           
        }
    }

    //2Change the value of variable by class name then Print it.
    class changenum
    {
         public static int id=10;

        public int show()
        {
            
            return id;
        }
    }
}
