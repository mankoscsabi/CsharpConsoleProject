using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyedikprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kérem adja meg hány darab tanulót szeretne felvenni!(min2 max10)");
            int tanulokSzama = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Köszönöm. Létrehozom a tömböket a tároláshoz");
            //KÉT TÖMBÖT KÉSZÍTÜNK, EGYET A NEVEKNEK, EGYET A JEGYEKNEK
            string[] nevek = new string[tanulokSzama];
            int[] jegyek = new int[tanulokSzama];
            //A TÖMBÖK FELTÖLTÉSE
            Console.WriteLine("kezdhetjük a bevitelt!");
            // DINAMIKUSAN ANNYISZOR KÉR BE A KONZOL ADATOKAT AHÁNY TANULÓNK LESZ
            for (int i = 0; i < tanulokSzama; i++)
            {
                //NEV BEKÉRÉS
                Console.WriteLine("Kérem adja meg a(z) {0}. tanuló nevét", i + 1);
                nevek[i] = Console.ReadLine();
                //JEGY BEKÉRÉS
                Console.WriteLine("Kérem adja meg a(z) {0}. tanuló jegyét", i + 1);
                jegyek[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("A Bevitel megtörtént");
            Console.WriteLine("Gombnyomásra kiírom a legroszabb tanulót");
            Console.ReadKey();
            //A LEGROSSZABB TANULÓ KIVÁLASZTÁSA
            int legrosszabbJegy = 5;
            int tanuloindex = 0;
            for (int i = 0; i < jegyek.Length; i++)
            {
                //A JELENLEGI LEGROSZABB JEGYTŐL ROSZABB E
                if (jegyek[i] < legrosszabbJegy)
                {
                    legrosszabbJegy = jegyek[i];
                    tanuloindex = i;
                }
            }
            Console.WriteLine("A Legroszabb tanuló: {0}, jegye: {1}", nevek[tanuloindex],legrosszabbJegy);
            Console.ReadKey();

        }
    }
}
