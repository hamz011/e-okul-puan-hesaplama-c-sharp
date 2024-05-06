using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EokulPuanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int ToplamDersSayisi,TPD=0;
            double ToplamDersOrt=0;
            int dersSayi;
            double dersOrt,topORT, dersNotu;
            Console.Write("Kaç ders var?\t");
            ToplamDersSayisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= ToplamDersSayisi; i++)
            {
                Console.Write($"{i}. ders notu: ");
                dersNotu = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{i}. ders sayısı: ");
                dersSayi = Convert.ToInt32(Console.ReadLine());
                TPD = dersSayi + TPD;
                dersOrt = dersNotu * dersSayi;
                ToplamDersOrt = ToplamDersOrt+ dersOrt;
                dersOrt = 0;
            }
            topORT = ToplamDersOrt / TPD;
            if(topORT>=50 && topORT<=100)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Tebrikler {topORT} ortalama ile Geçtiniz!");
            }
            else if(topORT<50)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Malesef {topORT} ortalama ile Kaldınız!");
            }
            Console.WriteLine(topORT);

            Console.ReadLine();
        }
    }
}
