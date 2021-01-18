using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine("Bob");  // use the Patient functionalities

            Child c = new Child();
            c.Examine("Billy");  // Use both Patient and Child functionalities
            c.Innoculate();

        }
    }

    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN {get; set;}

        public void Examine(string pname)
        {
            // Add code for patient examination...
            Console.WriteLine("Exmination of " + pname + " completed...");
        }

        public void Billing(long ssn)
        {
            // Add code to retrive patient billing/balance info
            Console.WriteLine("Billing completed...");
        }
    }

    public class Child : Patient  // Use colon to establish inheritance from Patient
    {
        public void Innoculate()
        {
            // Add code to record innoculation
            Console.WriteLine("Child has been innoculated...");
        }
    }


    }
