using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_And_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object o;
            int x = 25;
            o = x;  // Boxing occurs here

            Console.WriteLine("o= " + o);
            Console.WriteLine("x= " + x);

            o = 123;
            x = (int)o;
            Console.WriteLine("o= " + o);
            Console.WriteLine("x= " + x);
        }
    }
}
