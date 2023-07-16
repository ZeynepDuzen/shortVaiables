using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortVaiables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //short s1,s2,toplam;
            //s1 = 18;
            //s2 = 20;
            //toplam = (short)(s1 + s2);
            //Console.WriteLine(toplam);

            short sayi1, sayi2, carpim;
            Console.WriteLine("sayı 1 :");
            sayi1 = short.Parse(Console.ReadLine());
            Console.WriteLine("sayı 2 : ");
            sayi2 = short.Parse(Console.ReadLine());
            carpim = (short)(sayi1*sayi2);     // veya carpim = Convert.ToInt16(sayi1*sayi2);
            Console.WriteLine("sayilarin carpimi : " + carpim);




            Console.Read();
        }
    }
}
