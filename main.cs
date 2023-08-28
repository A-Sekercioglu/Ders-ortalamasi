using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ders_not = 25;
            int ders_not2 = 45;
            int ders_not3 = 85;
            double ort = (ders_not  + ders_not2 + ders_not3)/3;
            if (ort >= 75)
            {
                Console.WriteLine("A derecesi ile geçtiniz");
            }
            if ((ort >=65 )&&(ort <75))
            {
                Console.WriteLine("B derecesi ile geçtiniz");
            }
            if ((ort>=55) && (ort <65))
            {
                Console.WriteLine("C derecesi ile geçtiniz");
            }
            if ((ort>=45) && (ort < 55))
            {
                Console.WriteLine("D derecesi ile geçtiniz");
            }
            if (ort<45)
            {
                Console.WriteLine("F derecesi ile KALDINIZ");
            }
            Console.WriteLine("puanınız : " + ort);
            Console.ReadKey();
        }
    }
}
