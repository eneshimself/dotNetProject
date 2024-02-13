using System.Net;

namespace donguler;

class Program
{
    static void Main(string[] args)
    {
        // Ekrandan girilen sayıya kadar olan tek sayıları yazdır

         Console.Write("Lütfen bir sayi giriniz: ");
         int sayac = Convert.ToInt32(Console.ReadLine());
         for (int i = 1; i <= sayac; i++)
         {
             if (i % 2 == 1)
                 Console.WriteLine(i);
         }

        // 1 ile 1000 arasındaki sayıların kendi içlerinde toplamını ekrana yazdır

         int tektop = 0;
         int cifttop = 0;
         for(int i = 0; i <= 1000; i++)
         {
             if(i % 2 == 0)
                 cifttop += i;
             else if(i % 2 == 1)
                 tektop += i;
         }
         Console.WriteLine("Çift Toplam: " + cifttop);
         Console.WriteLine("Tek Toplam: " + tektop);

        // break, continue

        for (int i = 1; i <= 10; i++)
        {
            if (i == 4)
                break;
            Console.WriteLine(i);
        }
        for (int i = 1; i <= 10; i++)
        {
            if (i == 4)
                continue;
            Console.WriteLine(i);
        }
        // sonsuz döngü --> for(;;)
    }
}
