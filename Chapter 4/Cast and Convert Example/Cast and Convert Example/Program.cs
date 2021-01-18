using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast_and_Convert_Example
{
    class Program
    {
        static void Main(string[] args)
        {
	
            // This is an implicit conversion
            // because the long data type is larger
            // than the int data type...
            // No possible loss of data

            int num = 2147483647;
            long bigNum = num;
            
            
            // This requires an explicit conversion 
            int i = 5;
            double d= 10.5;
            //i = d;  // Cannot implicitly convert decimal to int
            i = (int)d;
            Console.WriteLine("The double variable d converted to int: " + i);





            // Cast or Convert.To ?

            int x=7;
            double y=12.6;
            x = (int)y;
            Console.WriteLine("y casted to an int: " + x);

            int xx = 7;
            double yy = 12.6;
            xx=Convert.ToInt32(yy); // Convert.To rounds the converted decimal up
            Console.WriteLine("yy converted to Int:" + xx);  





            // Using Convert with string
            string str = "123";
            int r;
            //r = str; // ERROR can't convert string to int
            //r = (int)str; // ERROR can't convert string to int

            r = Convert.ToInt32(str);

            Console.WriteLine("Using Convert.To to convert string to int: " + r);



           
       

           

       




        }
    }
}
