﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string> shopping = new List<string>();
        shopping.Add("Carotte");
        shopping.Add("Oignons");
        shopping.Add("Pomme de terre");
        shopping.Add("Tomate");
        for (int i = 0; i < shopping.Count; i++)
        Console.WriteLine(shopping[i]); // commentaire sur plusieurs lignes /* au début et à la fin /*
        }
    }
}
