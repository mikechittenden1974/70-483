using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // The non-generic way to create a list
            // We'll add integers to this list
            // The integers are upcast to Object type when added
            System.Collections.ArrayList list1 = new System.Collections.ArrayList();
            list1.Add(3);
            list1.Add(5);
            list1.Add(12);

            Console.WriteLine("Non-Generic List Results:");
            foreach(int x in list1)
            {
                Console.WriteLine(x);
            }

            // Now let's add a string to the list
            // We can add strings and integers together in a list
            // without any warning or compile-time error
            //list1.Add("Hello");

            // Now we get an invalid cast
            //foreach (int x in list1)
            //{
            //    Console.WriteLine(x);
            //}


            // Now, let's use a generic List

            List<int> list2 = new List<int>();
            list2.Add(34);
            list2.Add(9);
            list2.Add(11);
            Console.WriteLine("Generic List Results:");

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            // If we try to add a string to the list
            // we get an error
            // list2.Add("Hello");
                                 
        }
    }

   

    
}
