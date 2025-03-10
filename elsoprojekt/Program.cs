using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsoprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.ReadKey();
            Console.ReadLine();
            Console.WriteLine("Kérem adja meg a nevét");
            string nev = Console.ReadLine();
            Console.WriteLine("Hello " + nev); //sima összefűzés
            Console.WriteLine("Hello {0}", nev); //formázott kiírás
            Console.WriteLine($"Hello {nev}"); //string interpoláció
            Console.WriteLine("Hello {0}", nev, "Hello"); //több paraméteres formázott kiírás
            Console.ReadKey();
            Console.WriteLine("Hány éves vagy?");
            int kor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("köszi");
            //Elágazás
            if (kor < 18)
            {
                Console.WriteLine("Sajnálom, de még nem vagy nagykorú");
            }
            else
            {
                Console.WriteLine("Örülök, hogy már nagykorú vagy");
            }
            //swich-case
            switch (kor)
            {
                case 18:
                    Console.WriteLine("18 éves vagy");
                    break;
                case 35:
                    Console.WriteLine("35 éves vagy");
                    break;
                default:
                    Console.WriteLine("Nem 18 és nem 35 éves vagy hanem:" + kor);
                    break;
            }
        }
    }
}
