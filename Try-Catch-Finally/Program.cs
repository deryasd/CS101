internal class Program
{
    private static void Main(string[] args)
    {
        /*try
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
        }
        catch(Exception ex)
        {
            Console.Write("Hata: "+ ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("İşlem tamamlandı.");
        }*/
        
        try
        {
            //int a = int.Parse(null); 
            int a = int.Parse("Test");
            int aa = int.Parse("-23123123123");
        }
        catch(ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz");
            Console.WriteLine(ex);

        }
        catch(FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun değil.");
            Console.WriteLine(ex);

        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Çok küçük ya da büyük bir sayı");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem başarıyla tamamlandı.");
        }
        Console.ReadKey();
    }
}