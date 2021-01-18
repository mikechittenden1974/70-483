using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Person p = new Person();
            // Assigning a value calls the set accessor
            p.Age = 41;
          
            // Reading a value calls the get accessor
            Console.WriteLine("p.Age= " +  p.Age);

        }

          }



    public class Person
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value > 0) && (value < 15))
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age cannot be over 15...");
                }
            }

            


   }
           
        // Short cut for creating properties
        public int Weight {get; set;}

        // Ever better short cut is to use the prop or propfull snippets
        
        

     


    }
}
