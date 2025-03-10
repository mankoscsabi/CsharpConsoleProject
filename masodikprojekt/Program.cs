using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Most a ciklusokat nézzük meg");
            Console.WriteLine("A While ciklus elszámol 20-ig");
            Console.ReadKey();
            int szamlalo = 1;
            while (szamlalo <= 20)
            {
                Console.WriteLine(szamlalo);
                szamlalo++;
            }
            Console.WriteLine("Kész");
            Console.WriteLine("a DO WHILE ciklus fog visszaszámolni");
            Console.ReadKey();
            do
            {
                Console.WriteLine(szamlalo);
                szamlalo--;
            } while (szamlalo > 0);
            Console.WriteLine("A Do While Végzett");
            Console.ReadKey();
            Console.WriteLine("For Ciklus");
            Console.WriteLine("Adjon meg egy számot ameddig elszámolok nullátol,");
            int megadottSzam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= megadottSzam; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
