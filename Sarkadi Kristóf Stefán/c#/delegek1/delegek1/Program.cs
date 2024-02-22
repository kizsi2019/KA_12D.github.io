﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegek1
{
    internal class Program
    {
        delegate void VoidDelegate();
        static void Metodus()
        {
            Console.WriteLine("A metodus lefutott");
        }
        static void Main(string[] args)
        {
            VoidDelegate vd = new VoidDelegate(Metodus);
            vd();
            Console.ReadKey();
        }
    }
}
