using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add(85.5);
            koleksiyon.Add("selam");


            koleksiyon.Insert(1, "Berkay");//birinci index'e Berkay değerini ekle demek

            int say = koleksiyon.Count;
            //koleksiyon.Clear(); her şeyi siler

            bool kontrol = koleksiyon.Contains("selam");//bu dizide selam diye bir değer var mı diye kontrol ediyor ve true false değer döndürüyor

            int index = koleksiyon.IndexOf("selam");//bu dizide selam içeriğinin kaçıncı index'te olduğunu veriyor

            //koleksiyon.Reverse(); diziyi ters çevirir


            Console.WriteLine("dizideki eleman sayısı : " + say);
            Console.WriteLine("---");
            Console.WriteLine("dizide 'selam' değeri geçiyor mu : " + kontrol);
            Console.WriteLine("---");
            Console.WriteLine("'selam' değerinin indeks numarası : " + index);
            Console.WriteLine("---");


            foreach (var dizi in koleksiyon)
            {
                Console.WriteLine(dizi);
            }

            Console.WriteLine("***");
            ArrayList sayilar = new ArrayList();
            sayilar.Add(2);
            sayilar.Add(100);
            sayilar.Add(34);
            sayilar.Add(55);
            sayilar.Add(4);

            sayilar.Sort(); //diziyi küçükten büyüğe doğru sıralar
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
