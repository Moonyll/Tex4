using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
         string[] shopping = new string[] { "Carotte", "Oignons", "Pommes de terre", "Salade", "Tomate" };
         for (int i = 0; i < shopping.Length; i++)
         Console.WriteLine(shopping[i]);

        }
    }
}
