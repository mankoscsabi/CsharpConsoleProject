using System;

namespace otodikprojekt
{
    internal class Program
    {
        public struct Tanulo
        {
            public string nev;
            public int kor;
            public int jegy;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg hány tanulót fog felvinni! (min:2 max:10)");
            int dbSzam = Convert.ToInt32(Console.ReadLine());
            Tanulo[] tanulok = new Tanulo[dbSzam];

            Console.WriteLine("Struktúra elemek bevitele!");
            for (int i = 0; i < tanulok.Length; i++)
            {
                Console.WriteLine("Kérem adja meg a(z) {0}. tanuló nevét", i + 1);
                tanulok[i].nev = Console.ReadLine();
                Console.WriteLine("Kérem adja meg a(z) {0}. tanuló korát", i + 1);
                tanulok[i].kor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérem adja meg a(z) {0}. tanuló jegyét", i + 1);
                tanulok[i].jegy = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("A bevitel megtörtént");
            foreach (Tanulo egyTanulo in tanulok)
            {
                Console.WriteLine($"Név: {egyTanulo.nev} - Kor: {egyTanulo.kor} éves - Jegye: {egyTanulo.jegy}");
            }

            Console.WriteLine("Legjobb és legrosszabb tanuló kiírása");

            int legjobbJegy = 1;
            int legrosszabbJegy = 5;
            int legjobbTanuloIndex = 0;
            int legrosszabbTanuloIndex = 0;

            for (int i = 0; i < tanulok.Length; i++)
            {
                if (tanulok[i].jegy > legjobbJegy)
                {
                    legjobbJegy = tanulok[i].jegy;
                    legjobbTanuloIndex = i;
                }
                if (tanulok[i].jegy < legrosszabbJegy)
                {
                    legrosszabbJegy = tanulok[i].jegy;
                    legrosszabbTanuloIndex = i;
                }
            }

            Console.WriteLine($"Legjobb tanuló: {tanulok[legjobbTanuloIndex].nev} - Jegye: {tanulok[legjobbTanuloIndex].jegy}");

            string legrosszabbJegySzovegesen = JegySzovegesen(tanulok[legrosszabbTanuloIndex].jegy);
            Console.WriteLine($"Legrosszabb tanuló: {tanulok[legrosszabbTanuloIndex].nev} - Jegye: {legrosszabbJegySzovegesen}");

            Console.ReadKey();
        }

        static string JegySzovegesen(int jegy)
        {
            switch (jegy)
            {
                case 1: return "Elégtelen";
                case 2: return "Elégséges";
                case 3: return "Közepes";
                case 4: return "Jó";
                case 5: return "Jeles";
                default: return " ";
            }
        }
    }
}
