using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charSeparator = new char[] {','};
            const char space = ' '; 
            string[] lettersAndNumbers = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r",
                                          "s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9"};
            List<string> listEntry = new List<string>();

            Console.WriteLine("Enter any character among [a-z] and/or [0-9] separated by comma: ");

            string entry = Console.ReadLine();

            string[] elements = entry.Split(charSeparator);

            string concatenated="";

            foreach (string element in elements)
            {
                string elementm =element.Trim(space);
                if (lettersAndNumbers.Any(elementInLettersAndNumbers => elementInLettersAndNumbers == elementm))
                {
                    listEntry.Add(elementm);
                }     
            }

            for (int i=0; i<listEntry.Count(); i++)
            {
                concatenated += listEntry[i];
            }
            Console.WriteLine("\nConcatenated string: \n");
            
            Console.WriteLine(concatenated+"\n");

            Console.Write("Press any key to close the console app...");
            Console.ReadKey();

        }
    }
}
