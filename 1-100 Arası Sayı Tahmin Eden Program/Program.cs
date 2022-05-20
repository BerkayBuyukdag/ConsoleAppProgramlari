using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100_Arası_Sayı_Tahmin_Eden_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int min = 0, max = 100, tahmin, sayac = 1;
                char cevap;

                Random rnd = new Random();
                while (true)
                {
                    Console.Clear();
                    tahmin = rnd.Next((min + 1), max);
                    Console.WriteLine("Tahminim " + tahmin);
                    Console.WriteLine("tuttuğun sayıdan büyük ise (b)");
                    Console.WriteLine("tuttuğun sayıdan küçük ise (k)");
                    Console.WriteLine("tuttuğun sayı doğru ise (e)");


                    while (true)
                    {
                        cevap = Console.ReadKey().KeyChar;
                        if (cevap == 'e' || cevap == 'b' || cevap == 'k')
                        {
                            break;
                        }
                        Console.WriteLine("lütfen yönlendirmeyi düzgün yapın");
                    }

                    if (cevap == 'e')
                    {
                        break;
                    }
                    else if (cevap == 'b')
                    {

                        max = tahmin;

                    }
                    else if (cevap == 'k')
                    {
                        min = tahmin;
                    }
                    sayac++;
                }
                Console.WriteLine();
                Console.WriteLine("sonucu buldum tuttuğun sayı : " + tahmin);
                Console.WriteLine("Tahmin sayısı " + sayac);

            }
            catch
            {
                Console.WriteLine("yanlış yönlendirme yaptınız !!!");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}