using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy harmadik számot!");
            int szam3 = Convert.ToInt32(Console.ReadLine());
            int atlag = (szam1 + szam2 + szam3) / 3;
            Console.WriteLine("A három szám átlaga:"  +atlag + "\n");

            Console.ReadKey();
        }
    }
}
