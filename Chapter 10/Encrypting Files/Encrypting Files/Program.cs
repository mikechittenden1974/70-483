using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypting_Files
{
    class Program
    {
        static void Main(string[] args)
        {



          ReadFile();

          Console.WriteLine("Press enter to encrypt the file...");
          Console.ReadLine();

          EncryptFile(@"C:\MLFiles\ml.txt");

          ReadFile();

          Console.WriteLine("Press enter to decrypt the file...");
          Console.Read();

          File.Decrypt(@"C:\MLFiles\ml.txt");
 	}
		
        public static void ReadFile()
        {
          int counter = 0;
          string line;

          // Read the file and display it line by line.
          System.IO.StreamReader file =
             new System.IO.StreamReader(@"C:\MLFiles\ml.txt");
          while ((line = file.ReadLine()) != null)
              Console.WriteLine(line);
              counter++;
         
          file.Close();

        }
         

       public static void EncryptFile(string x)
       {
            File.Encrypt(x);
       }

        public static void DecryptFile(string x)
        {
            File.Decrypt(x);
        }

        
    }
}
