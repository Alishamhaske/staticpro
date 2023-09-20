using oopfirstclass_program.interfaceprogram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.staticpro
{
    public class programtest
    {
        static void Main(string[] args)
        {
            stud s1 = new stud(2, "alisha");
            stud s2 = new stud(6, "alisha");

            Console.WriteLine(s1.show());
            Console.WriteLine(s2.show());






        }
    }

    //write code to show static keyword with variable class method , constructor.

    public   class stud
    {
        protected int id;
        private string name;
        static string std_clg="VACOE";

        
        public stud(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public static string total()
        {
          
            return std_clg;
        }
        public string show()
        {
            return $"student id :{id}name: {name}  clg name: {std_clg}";
        }
    }

}
