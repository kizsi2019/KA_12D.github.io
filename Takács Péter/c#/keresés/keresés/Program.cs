﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keresés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 }; 
            int i = 0;
            while (i < Tömb.Length && Tömb[i] != Feltétel)
            {
                i++;
            }
            if (i < Tömb.Length) Console.WriteLine("A 'Feltétel' feltételnek megfelelő elem sorszáma {0}", i);
            else Console.WriteLine("Nincs");

        }
    }
}
