using System.Reflection.PortableExecutable;

namespace donguler_while_foreach;

class Program
{
    static void Main(string[] args)
    {
        //While
        //1 den başlayarak consoledan girilen sayıyıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program

        Console.WriteLine("Lütfen bir sayi giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while(sayac <= sayi)
        {
            toplam += sayac;
            sayac ++;
        }
        Console.WriteLine(toplam/sayi);

        // 'a'dan 'z'ye kadar tüm harfleri console a yazdır
        
        char character = 'a';
        while(character <= 'z')
        {
            Console.Write(character);
            character ++;
        }
        Console.Write("\n");
        Console.WriteLine("****** Foreach ******");

        string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
        foreach(var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
