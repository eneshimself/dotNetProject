namespace if_elseif;

class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        // if-else if kullanımı
        if (time >= 6 && time <= 11)
            Console.WriteLine("Gunaydin!");
        else if (time <= 18)
            Console.WriteLine("Iyi Gunler!");
        else
            Console.WriteLine("Iyi Geceler!");
        // ternary if kullanımı
        string sonuc = time <= 18 ? "Iyi Gunler!" : "Iyi Geceler!";

        sonuc = time >=6 && time <= 11 ? "Gunaydin!" : time < 18 ? "Iyi Gunler!" : "Iyi Geceler";

        Console.WriteLine(sonuc);


        // Geçme notu hesaplama

        Console.WriteLine("Lütfen ortalamanızı giriniz!");
        int ortalama = Convert.ToInt32(Console.ReadLine());


        if(ortalama >= 60 && ortalama <= 100)
            Console.Write("Ortalamanız: {0} Başarılı!",ortalama);
        else if(ortalama >= 45 && ortalama < 60)
            Console.Write("Ortalamanız: {0} Koşullu Başarılı!",ortalama);
        else if(ortalama >= 0 && ortalama < 45)
            Console.Write("Ortalamanız: {0} Başarısız!",ortalama);
        else
            Console.Write("Hatalı değer girdiniz!");
            
        
    }
}
