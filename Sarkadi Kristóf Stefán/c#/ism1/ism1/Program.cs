﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// Console.WriteLine("Helló világ");
            //Console.WriteLine("hol járunk");
            //10-es szamrendszerben megadott egesz
            int egesz_szam = 42;

            //az f jelzés jelöli a fordító számára,
            //hogy ez egy float típus
            float lebegopontos = 3.14f;

            //double esetén nem kell külön jelölni
            double d = 1124.333;

            //egész szám hexadecimális formában
            int hexa = 0xff;

            //hosszú egész oktális formátumban
            long okta = 07123235;

            //decimal típus esetén m betű jelzi, hogy a szám egy decimal típus 
            decimal penz = 1224.3m;

            //A fordító a változó típusának string-et fog adni.
            var valtozo = "Ez egy szöveg";

            //futtatás közben fog eldőlni a típus.
            //az eredmény típus szöveg lesz. A 44 szöveggé fog konvertálódni
            dynamic dinamikus = "Ez egy " + 44;
            Console.WriteLine(egesz_szam);
            Console.WriteLine(lebegopontos);
            Console.WriteLine(d);
            Console.WriteLine(hexa);
            Console.WriteLine(okta);
            Console.WriteLine(penz);
            Console.WriteLine(valtozo);
            Console.WriteLine(dinamikus);
            string szoszerint = @"Ez egy speciális\különlege's \t string";
            Console.WriteLine(szoszerint);
            int a = 1;
            int b = 2;
            //a változóba a "b nagyobb, mint a" szöveg kerül, mivel a feltétel nem igaz
            string nagyobb = a > b ? "a nagyobb, mint b" : "b nagyobb, mint a";
            Console.WriteLine(nagyobb);
            //17 lesz az eredmény
            var kifejezes = 3 * 6 - 2 + 1 % 2;
            Console.WriteLine(kifejezes);

            //így már helyes és az eredmény 1
            var kifejezes2 = (3 * 6 - 2 + 1) % 2;
            Console.WriteLine(kifejezes2);

            Console.Write("A long tipus merete byte-ban: ");
            //8
            int bytes = sizeof(long);
            Console.WriteLine(bytes);

            //binárisan
            // 0000_0001 << 6 => 0100_0000
            int kettohat = 1 << 6;
            Console.WriteLine(kettohat);

            //binárisan
            //1111_0000 >> 2 => 0011_1100
            int balra = 240 >> 2;
            Console.WriteLine(balra);

            //true
            bool logika = 33 > 22;
            //false
            bool logika2 = (33 / 2) == 0;
            Console.WriteLine(logika);
            Console.WriteLine(logika2);

            string szoveg = "ez egy";
            szoveg += " szép mondat.";

            Console.WriteLine(szoveg);

            int x = 3;
            //4 lesz, mert inkrementálás után ír ki
            Console.WriteLine(++x);
            x = 3;
            //3 lesz, mert kiír és csak utána inkrementálja a változót
            Console.WriteLine(x++);
            //4 lesz, mert itt már a növelt értéket látjuk
            Console.WriteLine(x);
            Console.Beep(900, 2000);
            Console.Clear();*/

            Console.WriteLine("Add meg a négyzet oldalát!");
            int a = Convert.ToInt32(Console.ReadLine());
            int kerulet = 4 * a;
            int terulet = a * a;
            Console.WriteLine("A négyzet kerülete: " + kerulet);
            Console.WriteLine("A négyzet területe: " + terulet);

            Console.ReadKey();

        }
    }
}
