		using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringWriter_and_StringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be sure to add 'using System.IO'

            StringReadWrite srw = new StringReadWrite();

        }
    }

    public class StringReadWrite
    {
         StringBuilder sb = new StringBuilder();

        public StringReadWrite()
        { 
          

            // Call the WriteData method
            WriteData();

            // Call the ReadData method
            ReadData();
        }

        # region "Write data using StringWriter"
        public void WriteData()
        {
            // Note that we are passing the StringBuilder sb object to the StringWriter
            StringWriter sw = new StringWriter(sb);
            Console.WriteLine("Please enter your first and last name...");
            string name = Console.ReadLine();

            // Write the name to the StringBuilder sb object
            sw.WriteLine("Name: " + name);

            // Close the sw stream object
            sw.Flush();
            sw.Close();
        }
        # endregion


        # region "Read data from StringBuilder"
        public void ReadData()
        {
            // Note we are converting the sb object to a string and passing it to the StringReader
            StringReader sr = new StringReader(sb.ToString());

            Console.WriteLine("Reading the information...");

            // Use Peek to see if another character exists in sb
            while (sr.Peek() > -1)
            {
                // Read a line from the string and display it
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine(" ");
            Console.WriteLine("Thank you!");

            sr.Close();
        }
        # endregion

    }

}
