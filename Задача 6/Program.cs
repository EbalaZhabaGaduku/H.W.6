using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            int strLengh=1;
            string[] stringArray = startString.Split();
            int max = 0;
            
            foreach (var s in stringArray)
            {
                strLengh = s.Length;
                if (stringArray.Length>max)
                {
                    max = s.Length;
                }
                Console.WriteLine("{1}\nКоличество символов в слове ={0} ", strLengh,s);
                
            }
            Console.WriteLine("\nМаксимальное количество символов={0}", max); 
            
            Console.ReadKey();
        }
    }
}
