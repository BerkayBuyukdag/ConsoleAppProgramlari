using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int islem = 0;
                for (int i = 2; i <= 100; i++)
                {
                    for (int j = 1; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            islem++;
                        }
                    }
                    if (islem <= 1)
                        Console.WriteLine(i);
                    islem = 0;
                }
                Console.WriteLine("---");
            }

            while (true)
            {
                int kontrol = 0, sayi;
                Console.Write("sayı gir : "); sayi = int.Parse(Console.ReadLine());

                for (int i = 1; i <= sayi / 2; i++)//sayıyı 1 değilde 2'den başlatınca 4'ü asal alıyor
                {
                    if (sayi % i == 0)
                    {
                        kontrol++;
                    }
                }
                if (kontrol < 2 && sayi > 1)
                {
                    Console.WriteLine("sayı asal");
                }

                else { Console.WriteLine("asal değil"); }
                Console.WriteLine();
            }
        }
    }
}