using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate_Example
{
    class Program
    {
        delegate void del(int x, int y);

        static void Main(string[] args)
        {
            Mark m = new Mark();

            del d;

            d = m.AddNumbers;

            Console.WriteLine("Invoking delegate d with one target: ");
            d(6, 5);
            Console.WriteLine();

            d += m.MultiplyNumbers;
            Console.WriteLine("Invoking delegate d with 2 targets: ");
            d(6, 5);
            Console.WriteLine();

            d += m.SubtractNumbers;
            Console.WriteLine("Invoking delegate d with 3 targets: ");
            d(6, 5);
            Console.WriteLine();

            d -= m.MultiplyNumbers;
            Console.WriteLine("Removed MultiplyNumbers: ");
            d(6, 5);
            Console.WriteLine();
            
           
        }
    }

    public class Mark
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("AddNumbers: a + b = " + (a+b));
        }

        public void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine("MultiplyNumbers: a * b = " + (a * b));
        }

        public void SubtractNumbers(int a, int b)
        {
            Console.WriteLine("SubtractNumbers: a - b = " + (a - b));
        }
    }
}
