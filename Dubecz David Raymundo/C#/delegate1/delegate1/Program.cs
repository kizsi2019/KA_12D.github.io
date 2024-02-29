﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    internal class Program
    {
        delegate void VoidDelegate(); //a delegate létrehozása
        static void Metodus()
        {
            Console.WriteLine("A metódus lefutott!");
        }
        static void Main(string[] args)
        {
            VoidDelegate vd = new VoidDelegate(Metodus); //létrejön a hivatkozás
            vd();//meghívja a megadott metódust, amire hivatkozik
            Console.ReadKey();
        }
    }
}