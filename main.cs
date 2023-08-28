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
//buranın üstündeki int tanımları ders notlarınızın sayı olarak değilde kelime olarak daha hızlı ve sayı değerleri değişse bile içerisindeki sayıların aynı veri olarak tanımlamasını sağlar 
            double ort = (ders_not  + ders_not2 + ders_not3)/3;
            //double int terimini içerisinde bulundurduğu ve ondalıklı sayı kullanabileceği için ortalamaya daha uygundur
            if (ort >= 75)
            {
                Console.WriteLine("A derecesi ile geçtiniz");
                //bu if terimi ders notlarının aritmetik ortalaması eğer 75'e eşit veya 75 den büyükse tırnak işareti içerisindeki cümleyi ekrana yazar
            }
            if ((ort >=65 )&&(ort <75))
            {
                Console.WriteLine("B derecesi ile geçtiniz");
                //bu if terimi ders notlarının aritmetik ortalaması eğer 65'e eşit veya 65 ile 75 arasında ise(75 dahil değildir) tırnak işareti içerisindeki cümleyi ekrana yazar
            }
            if ((ort>=55) && (ort <65))
            {
                Console.WriteLine("C derecesi ile geçtiniz");
                //bu if terimi ders notlarının aritmetik ortalaması eğer 55'e eşit veya 55 ile 65 arasında ise(65 dahil değildir) tırnak işareti içerisindeki cümleyi ekrana yazar
            }
            if ((ort>=45) && (ort < 55))
            {
                Console.WriteLine("D derecesi ile geçtiniz");
                //bu if terimi ders notlarının aritmetik ortalaması eğer 45'e eşit veya 45 ile 55 arasında ise(55 dahil değildir) tırnak işareti içerisindeki cümleyi ekrana yazar
            }
            if (ort<45)
            {
                Console.WriteLine("F derecesi ile KALDINIZ");
                 //bu if terimi ders notlarının aritmetik ortalaması eğer 45 den küçükse tırnak işareti içerisindeki cümleyi ekrana yazar
            }
            Console.WriteLine("puanınız : " + ort);
            //ekrana puanınızı yazar
            Console.ReadKey();
        }
    }
}
