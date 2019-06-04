using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dic = new Dictionary();
            StreamReader objReader = new StreamReader(@"C:\\dict.txt");
            Console.WriteLine(dic.Punct());
            Console.WriteLine(dic.Words());
            Console.WriteLine(dic.Split());
            /*const int max = 500;
            string str = new string(new char[max]);
            int i = 0;
            int w = 1;

            Console.Write("Введите текс: \n");
            str = Console.ReadLine();
            for (i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                    w++;

            Console.WriteLine(w);
            Console.ReadLine();*/
        }
    }
}
