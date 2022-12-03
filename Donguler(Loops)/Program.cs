internal class Program
{
    private static void Main(string[] args)
    {
        //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
        System.Console.WriteLine("Bir sayı giriniz.");
        int sayac = int.Parse(Console.ReadLine());

        for (int i = 0; i <= sayac; i++)
        {
            if(i%2 == 1)
                Console.WriteLine(i);
        }

        // 1 ile 1000 arasındaki tek ve çift sayıların kendi içerisindeki toplamlarını ekrana yazdır.
        
        int tekToplam = 0, ciftToplam = 0;
        for (int i = 0; i <= 1000; i++)
        {
            if(i%2 == 1)
                tekToplam +=i;
            else
                ciftToplam +=i;
        }
        System.Console.WriteLine("1000' e kadar olan tek sayıların toplamı : " + tekToplam);
        System.Console.WriteLine("1000' e kadar olan çift sayıların toplamı : " + ciftToplam);
        Console.ReadLine();

        // break, continue
        for (int i = 0; i < 10; i++)
        {
            if(i == 4)
                //break;
                continue;
            System.Console.WriteLine(i);
        }
    }
}