using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Prıogramlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //arrray - dizi

            string[] kurslar = new string[] { "yazılım Geliştirici Yetiştirme Kampı", "Prıogramlamaya başlangıç için temel kurs",
                "Java", "Python","C++" };
            for (int i = 0 ; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
