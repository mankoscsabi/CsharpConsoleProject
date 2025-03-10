using System    ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatodikprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //VÉLETLEN SZÁM GENERÁLÁS
        int[] tomb = new int[20];
            Random veletlenObjektum = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = veletlenObjektum.Next(0, 100);
            }
            Console.WriteLine("Raktam számokat a tömbbe");
            for (int i = 0; i < tomb.Length; i++)
            {
                int sorsoltSzam = 0;
                do
                {
                     sorsoltSzam = veletlenObjektum.Next(0, 40);    
                }
                while (tomb.Contains(sorsoltSzam));
                tomb[i] = sorsoltSzam;

                Console.WriteLine("Szam {0}: {1}",i+1, tomb[i]);

            }
            Console.WriteLine("Adjon meg egy számot megnézem benne van e a tömbben");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (tomb.Contains(szam))
            {
                Console.WriteLine("A {0} benne van a tömbben",szam);
            }
            else
            {
                Console.WriteLine("A {0} nincs benne a tömbben",szam);
            }
            Console.ReadKey();  

        }
    }
}
