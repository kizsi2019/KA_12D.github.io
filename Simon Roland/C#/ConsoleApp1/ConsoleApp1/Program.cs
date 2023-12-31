﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Helló világ! ");
            //10-es szamrendszerben megadott egesz
            int egesz_szam = 42;
            Console.WriteLine(egesz_szam);

            //az f jelzés jelöli a fordító számára,
            //hogy ez egy float típus
            float lebegopontos = 3.14f;
            Console.WriteLine(lebegopontos);

            //double esetén nem kell külön jelölni
            double d = 1124.333;
            Console.WriteLine(d);

            //egész szám hexadecimális formában
            int hexa = 0xff;
            Console.WriteLine(hexa);

            //hosszú egész oktális formátumban
            long okta = 07123235;
            Console.WriteLine(okta);
            //decimal típus esetén m betű jelzi, hogy a szám egy decimal típus 
            decimal penz = 1224.3m;
            Console.WriteLine(penz);
            //A fordító a változó típusának string-et fog adni.
            var valtozo = "Ez egy szöveg";
            Console.WriteLine(valtozo);
            //futtatás közben fog eldőlni a típus.
            //az eredmény típus szöveg lesz. A 44 szöveggé fog konvertálódni
            dynamic dinamikus = "Ez egy " + 44;
            Console.WriteLine(@"Ez egy speciális \különlege's \t string");
            int a = 1;
            int b = 2;
            //a változóban


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
            //Console.Beep(17, 2000);
            //Console.Clear();
            int f= 3;
            Console.WriteLine(f / 4);
            Console.WriteLine((double)f / 4);
            
            Console.WriteLine("Add meg a négyzet oldalát! ");
            int a = Convert.ToInt32(Console.ReadLine());
            int kerulet = 4 * a;
            int terulet = a * a;
            Console.WriteLine("A négyzet kerülete: "+ kerulet);
            Console.WriteLine("A négyzet területe: " + terulet);
            
            int ma = 21;
            int tegnap = 18;
            var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);

            Console.WriteLine(szoveg);

            Console.WriteLine("Így is lehet: {0}, {1}", ma, tegnap);

            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);

            double d = 1500.42;

            //1500,4200
            Console.WriteLine("{0:00.0000}", d);
            //(1500),42
            Console.WriteLine("{0:(#).##}", d);
            //1500,4
            Console.WriteLine("{0:0.0}", d);
            //1 500
            Console.WriteLine("{0:0,0}", d);
            //150042%
            Console.WriteLine("{0:0%}", d);
            //[Foo  ]
            Console.WriteLine("[{0,-5}]", "Foo");
            //[  Foo]
            Console.WriteLine("[{0,5}]", "Foo");

            //pozitív
            Console.WriteLine("{0:pozitív;negatív;nulla}", 4);
            //negatív
            Console.WriteLine("{0:pozitív;negatív;nulla}", -4);
            //nulla
            Console.WriteLine("{0:pozitív;negatív;nulla}", 0);

            var elso = "c:\\teszt\\foo";
            //picivel egyszerűbb:
            var masodik = @"c:\teszt\foo";

            string nev = "World";
            string hello = $"Hello {nev}!";
            Console.WriteLine(hello);
           
            DateTime a = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(a.DayOfYear);
 
            int szl = 2013;
            int eletkor = DateTime.Now.Year - szl;
            Console.WriteLine("Jóska Pista {0} éves", eletkor);

            var ido = DateTime.Now;

            Console.WriteLine("{0:d}", ido);
            Console.WriteLine("{0:D}", ido);
            Console.WriteLine("{0:t}", ido);
            Console.WriteLine("{0:T}", ido);
            Console.WriteLine("{0:f}", ido);
            Console.WriteLine("{0:F}", ido);
            Console.WriteLine("{0:g}", ido);
            Console.WriteLine("{0:G}", ido);
            Console.WriteLine("{0:M}", ido);
            Console.WriteLine("{0:r}", ido);
            Console.WriteLine("{0:Y}", ido);
            Console.WriteLine("{0:yyyy-mm-dd, dddd tt hh:mm:ss}", ido);

            string teszt = "🐰";
            Console.WriteLine("A szoveg hossza: {0}", teszt.Length);

            var info = new StringInfo(teszt);
            Console.WriteLine("A szoveg valodi hossza: {0}", info.LengthInTextElements);


            int a = Math.Abs(-123);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.5333, 2);
            Console.WriteLine(d);
          

            Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);
             
            Console.WriteLine("Adja meg a kor sugarat");
            double r = Convert.ToInt32(Console.ReadLine());
            double kerulet = 2 * r * Math.PI;
            double terulet = r * r * Math.PI;
            Console.WriteLine("A kor kerulete: "+  Math.Round(kerulet, 2), kerulet);
            Console.WriteLine("A kor terulete: " +  Math.Round(terulet, 2) ,terulet);


  checked
            {
                int a2 = 100000;
                int b2 = 100000;
                long c2 = a2 * b2;
            }
 

            try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
            }

            Console.WriteLine("Adja meg a kor sugarat");
          
           
            Console.WriteLine("A kor kerulete: " + Math.Round(kerulet, 2), kerulet);
            Console.WriteLine("A kor terulete: " + Math.Round(terulet, 2), terulet);
            try
            {
                
                var bevitel = Console.ReadKey
                    
                double r = Convert.ToInt32(Console.ReadLine());
                double kerulet = 2 * r * Math.PI;
                double terulet = r * r * Math.PI;
                if ((r % 1) != 0)
                {
                    throw new Exception("A szám nem páros");
                }
                Console.WriteLine($"A szorzás eredménye: {szam * 2}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA történt");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");
            }
*/
















                Console.ReadKey();
        }
    }
}
