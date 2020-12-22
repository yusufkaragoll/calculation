using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final, not, ortalama;

            Console.WriteLine("vize");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("final");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = vize + final;
            Console.WriteLine("Sonuc:" + ortalama);
        }
    }
}
