using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Dictionary
    {
        public string Punct()
        {

            string result;
            string str = @"c:\\dict.txt";
            
            if (str.Contains(".,?!..."))
                Console.Write("Строка содержит знаки препинания");
            else
                Console.Write("Строка НЕ содержит знаки препинания");

            result = str;
            return result;
           
            

        }

        public string Words()
        {
            string result;
            string str = @"C:\\dict.txt";
            string[] textMass = str.Split(' ');
            Console.WriteLine("Количество слов:");
            Console.WriteLine(textMass.Length);
            Console.ReadLine();
            result = str;
            return result;

        }

       public string Split()
        {
            string result;
            string str = @"c:\\dict.txt";
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                Console.Write (word);
            }
            result = str;

            return result;
            
         
        }


    }
}
