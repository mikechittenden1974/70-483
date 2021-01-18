using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password to hash...");
            // Get a password from the user and store it in pw
            string pw = Console.ReadLine();
            Console.WriteLine();

            HashData hd = new HashData();
            Console.WriteLine("The hash value for " + pw + " is: ");
            
            // Create a hashvalue from the user's password
            string pwh = hd.CreateHash(pw);

            // Display the hash value of the user's password
            Console.WriteLine(pwh);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("We could store this hash value in a database...");


            // Get the password from the user again
            Console.WriteLine("When the user attempts to login later, we'll hash their input ");
            Console.WriteLine("and compare the hash to the one stored in the database...");
            Console.WriteLine();
            Console.WriteLine("Enter the password again and I'll see if the hashes match...");
            string pw2 = Console.ReadLine();
            Console.WriteLine();

            // Hash the second password then list them both 
            string pwh2 = hd.CreateHash(pw2);
            Console.WriteLine();
            Console.WriteLine("First hash : " + pwh);
            Console.WriteLine("Second hash: " + pwh2);

            if (pwh == pwh2)
            {
                Console.WriteLine("Files match.");
            }
            else
            {
                Console.WriteLine("No match.");
            }



        }
    }

    public class HashData
    {
        public string CreateHash(string input)
        {
            HashAlgorithm sha = SHA256.Create();
            byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(input));
            return Convert.ToBase64String(hashData);
        }


    }
}
