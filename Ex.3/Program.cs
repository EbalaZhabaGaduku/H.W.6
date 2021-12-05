using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char[] ch = new char[100];
            int k = 0, strt = 0, fstrt = 0;
            Console.WriteLine("Введите строку:");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{')
                    strt = i;
                if (s[i] == '}')
                    fstrt = i;
            }
            for (int i = 0; i < strt; i++)
            {
                ch[k] = s[i];
                k++;
            }
            for (int i = fstrt + 1; i < s.Length; i++)
            {
                ch[k] = s[i];
                k++;
            }
            Console.WriteLine("Преобразованная строка");
            Console.WriteLine(ch);
            Console.ReadKey();
        }
    }
}
