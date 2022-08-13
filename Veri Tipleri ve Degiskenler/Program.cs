using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        byte b = 1;
        sbyte sb = 1;

        short sh = 1;
        ushort ush = 1;

        Int16 i16 = 1;
        int i = 1;
        Int32 i32 = 1;
        Int64 i64 = 1;

        uint ui = 1;
        long l = 1;
        ulong ul = 1;

        float f = 1.0F;
        double d = 1.0D;
        decimal de = 1.0M;

        char ch = '2';
        string str = "Derya";

        bool b1 = true;
        bool b2 = false;

        DateTime dtime = DateTime.Now;

        Console.WriteLine(dtime);

        object o1 = 'x';
        object o2 = 'y';
        object o3 = 1;
        object o4 = 1.0;

        string str1 = string.Empty;
        str1 = "Derya Kalender";
        string name = "Derya";
        string lastName = "Kalender";
        string nameSurname = name + " " + lastName;

        Console.WriteLine(nameSurname);
        
        int int1 = 2;
        int int2 = 4;
        int int3 = int1 * int2;

        bool b3 = 5 > 8;

        string str20 = "20";
        int int20  = 20;
        string newVariable = str20 + int20.ToString();
        
        Console.WriteLine(newVariable);

        int int21 = int20 + Convert.ToInt32(str20);

        Console.WriteLine(int21);

        int int22 = int20 + int.Parse(str20);

        string dTime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(dTime);

        string dTime2 = DateTime.Now.ToString("dd-MM-yyyy");
        Console.WriteLine(dTime2);
        
        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);

        
        Console.ReadLine();

    }
}