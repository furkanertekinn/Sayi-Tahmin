using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusuOdevDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sistemUretSayi = 0;
            int tahminAdet = 1;
            Random rmd= new Random();
            sistemUretSayi = rmd.Next(1, 10);

            while (true)
            {
                Console.Write(tahminAdet +". Deneme Lütfen tahmin ettiğiniz sayıyı giriniz :");
                string girilenDeger = Console.ReadLine();
                int kullaniciDeger = Convert.ToInt32(girilenDeger);
                if (kullaniciDeger==sistemUretSayi)
                {
                    tahminAdet++;
                    Console.WriteLine(tahminAdet +". Deneme Tebrikler doğru tahmin ettinizz!!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(tahminAdet+". Deneme Tahmin edemediniz yeni bir sayı giriniz!");
                    tahminAdet++;
                }

            }
        }
    }
}
