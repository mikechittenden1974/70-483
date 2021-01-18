using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> cars = new List<string>();
            cars.Add("Chevrolet");
            cars.Add("Honda");
            cars.Add("Lexus");
            cars.Add("Ford");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("\n" + "Now our own collection..." + "\n");

            // Now let's create our own collection

            Car c = new Car();
            c[0] = "Chevrolet";
            c[1] = "Mercedes";
            c[2] = "Dodge";

            // We can't use foreach unless the Car class
            // implements IEnumerable
            foreach (string car in c)
            {
                Console.WriteLine(car);
            }
        }
    }

    // Let's create a class with an indexer
    public class Car : IEnumerable
    {
       
        string[] car= new string[3]; 

        public string this[int carNum]
        {
            get { return car[carNum]; }
            set { car[carNum] = value; }
        }

        // This is our enumerator
        // It implments the IEnumerable interface
        public IEnumerator GetEnumerator()
        {
            foreach (string c in car)
            {
                yield return c;
            }
        }
    }
}
