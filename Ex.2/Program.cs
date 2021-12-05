using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            char[] reverse = startString.ToCharArray();
            Array.Reverse(reverse);
            string secondString = new string(reverse);
            int compare = string.Compare(startString, secondString, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.CompareOptions.IgnoreSymbols);
            if (compare>=1)
            {
                Console.WriteLine("Строка является полиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является полиндромом");
            }
            
            Console.ReadKey();
        }
    }
}
