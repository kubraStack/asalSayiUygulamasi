using System;

namespace asalSayıUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uygulama = Asal Sayı
            // Girilen bir sayının asal olup olmadığını kontrol ediniz.
            // Bir sayı sadece kendisine ve 1 'e bölünüyorsa asal sayıdır.

           
            bool asalmi = true;
            System.Console.Write("Sayı: ");
            int sayı = int.Parse(Console.ReadLine());

            if (sayı == 1)
            {
               asalmi = false;
            }
            for (int i = 2; i < sayı; i++)
            {
                if (sayı%i == 0)
                {
                    asalmi = false;
                    break;
                }
            }

            if (asalmi)
            {
                System.Console.WriteLine("Sayı asal sayıdır");
            }else{
                System.Console.WriteLine("Sayı asal değildir");
            }
        }
    }
}
