﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int ma = 21;
                int tegnap = 18;
                var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);
                Console.WriteLine(szoveg);
                Console.WriteLine("Így is lehet: {0}, {1}", ma, tegnap);
                Console.ReadKey();
            }
        }
    }

}
