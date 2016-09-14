using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] items = input.Split(' ');

            string longWord = "";

            for(int i =0;i<=items.Length-1;i++)
            {
                if(items[i].Length > longWord.Length)
                {
                    longWord = items[i];
                }
                
            }
            System.Console.WriteLine(longWord);

        }
    }
}
