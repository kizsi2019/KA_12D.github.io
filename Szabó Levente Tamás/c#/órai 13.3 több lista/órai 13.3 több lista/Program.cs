﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_13._3_több_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {10,23,4,30,10,16,19,20,34,10};
            list.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete: {1}", list.Capacity, list.Count);
            Console.ReadKey();
        }
    }
}