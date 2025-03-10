using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alprogramok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metódusok és függvények

            //Metódusok
            //Metódusokat használhatunk a kód újrafelhasználására
            //Metódusokat használhatunk a kód strukturálására
            //Metódusokat használhatunk a kód olvashatóságának növelésére
            //Metódusokat használhatunk a kód karbantarthatóságának növelésére
            //Metódusokat használhatunk a kód tesztelhetőségének növelésére
            //Metódusokat használhatunk a kód újrafelhasználására
            //Metódusokat használhatunk a kód strukturálására
            //Metódusokat használhatunk a kód olvashatóságának növelésére
            //Metódusokat használhatunk a kód karbantarthatóságának növelésére
            //Metódusokat használhatunk a kód tesztelhetőségének növelésére
            //Metódusokat használhatunk a kód újrafelhasználására
            //Metódusokat használhatunk a kód strukturálására
            //Metódusokat használhatunk a kód olvashatóságának növelésére
            //Metódusokat használhatunk a kód karbantarthatóságának növelésére
            //A void kulcsszó azt jelenti, hogy a metódus nem ad vissza értéket
            int a = 0;
            int b = 0;
            Console.WriteLine("Adja meg az első számot");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot");
            b = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("köszönjük a bevitelt\n Gombnyomásra Összead\n ");
            Console.ReadKey();
            osszeadas(a, b);
            Console.ReadKey();
            Console.WriteLine("Gombnyomásra szozás függvénnyel visszaadjuk az eredményt!");
            Console.ReadKey();
            //int szorzat = szorzas(a, b);
            Console.WriteLine("A szorzat: " +szorzas(a,b));
            Console.WriteLine("Gombnyomásra megmondom hogy melyik szám páros vagy páratlan ");
            Console.ReadKey();
            Console.WriteLine("Az első szám:" +Environment.NewLine + parose (a));
            Console.WriteLine("A második szám:" + Environment.NewLine + parose(b));
            Console.ReadKey();
            //SHORT IF
            //A short if egy olyan szerkezet, amely egy feltételt vizsgál, és attól függően hajt végre egy műveletet
            string eredmeny = a > 1 ? "Az első szám 10 Alatti" : "A második szám 10 fölötti";
            Console.WriteLine(eredmeny);
            Console.ReadKey();





            //A függvény
            //A függvény egy olyan metódus, amely visszaad egy értéket

            //<visszatérési típusx > < függvény neve > (< paraméterek >)
            //{
            //kód
            //   return < visszatérési érték >;
            //}
            //Mindig kell visszatérési érték

        }
        // Páratlan vagy páros szöveg függvény
        static string parose(int szam)
        {
            if (szam % 2 == 0)
            {
                return "A szám páros";
            }
            else
            {
                return "A szám páratlan";
            }
        }   
        static void osszeadas(int szam1,int szam2)
        {
            int osszeg = szam1 + szam2;
            Console.WriteLine("A szamok összege " + osszeg);

        }
        //szorzás függvény
        static int szorzas(int szam1, int szam2)
        {
            int szorzat = szam1 * szam2;
            return szorzat;
        }   
    }
}
