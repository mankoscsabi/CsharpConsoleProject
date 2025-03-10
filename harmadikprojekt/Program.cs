using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Most a foreach bejárós ciklust nézzük meg");
            // A foreach ciklus egy olyan ciklus, amely egy kollekció minden elemén végigmegy
            // A foreach ciklus használatakor nem kell a ciklusváltozó értékét növelni, mert a ciklus a kollekció minden elemén végigmegy
            // A foreach ciklus használatakor a ciklusváltozó értéke a kollekció egyes elemei lesznek
            // A foreach ciklus használatakor a ciklusváltozó típusa a kollekció elemeinek típusával egyezik meg
            // A foreach ciklus használatakor a ciklusváltozó értéke nem módosítható
            int[] tomb = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = i + 1;
            }
            Console.WriteLine("Kész a tömb most bejárjuk az elemeket foreach-csel");
            foreach (int elem in tomb)
            {
                Console.WriteLine("Az aktuális szám: {0}", elem);

            }
            Console.ReadKey();
        }
    }
}
