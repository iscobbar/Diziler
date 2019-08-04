using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değer atayarak dizi tanımlama
            int[] sayiDizisi = { 3, 5, 77, 45, 33, 21 };

            // Değer atamadan dizi  tanımlama: eleman sayısı ile
            int[] sayiDizisi2 = new int[6];


            Console.WriteLine(sayiDizisi[0]);
            Console.WriteLine(sayiDizisi[3]);
            Console.WriteLine(sayiDizisi[5]);

            Console.WriteLine(sayiDizisi2[0]);
            Console.WriteLine(sayiDizisi2[3]);
            Console.WriteLine(sayiDizisi2[5]);

            // Dizi elemanına değer atama.
            sayiDizisi2[0] = 99;
            sayiDizisi2.SetValue(0, 99);

            // 99 değerini 0-4 arasındaki tüm indislere ata.
            sayiDizisi2.SetValue(99, 0, 1, 2, 3, 4);

            Console.WriteLine(sayiDizisi2[0]);

            string[] isimler = new string[3];
            isimler[0] = "Selda";
            isimler[1] = "Mustafa";
            isimler[2] = "Serhat";
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler); // dizi tipini verir

            char[] harfler = new char[5];

            harfler[0] = 'A';
            harfler[1] = 'B';
            harfler[2] = 'C';
            harfler[3] = 'D';
            harfler[4] = 'E';

            Console.WriteLine(harfler[3]);

            for (int i = 0; i <= 4; i++)
            {
                harfler[i] = 'F';
            }

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(harfler[i]);
            }

            foreach (var harf in harfler)
            {
                Console.WriteLine(harf);
            }


            int[] rastgeleDizi = new int[20];

            Random r = new Random();

            for (int i = 0; i <= 19; i++)
            {
                rastgeleDizi[i] = r.Next(1000);
                Console.WriteLine(rastgeleDizi[i]);
            }
            Console.WriteLine("-------------------------------------");
            // Dizi elemanlarını sıraya sok.
            //Array.Sort(rastgeleDizi);

            // Diziyi tersine çevir.
            Array.Reverse(rastgeleDizi);

            foreach (int sayi in rastgeleDizi)
            {
                Console.WriteLine(sayi);
            }

            // Diziyi ttemizle. 0'dan itibaren 20 elemanı temizle.
            Array.Clear(rastgeleDizi, 0, 20);
            Console.WriteLine("************************************");
            foreach (var sayi in rastgeleDizi)
            {
                Console.WriteLine(sayi);
            }


            string[] sehirler = new string[4];

            sehirler[0] = "Aydın";
            sehirler[1] = "Amasya";
            sehirler[2] = "Yozgat";
            sehirler[3] = "İstanbul";

            // Aranan yoksa -1 döndürür.
            int index = Array.IndexOf(sehirler, "Kars");
            Console.WriteLine(index);

            // Aranan değer varsa indis numarasını döndürür: 45
            int index2 = Array.IndexOf(sehirler, "Yozgat");
            Console.WriteLine(index2);

            // 10. indisten itibaren arama yap. 
            int index3 = Array.IndexOf(sehirler, "Aydın", 10);
            Console.WriteLine(index3);


            string ad = "mehmet";

            for (int i = 0; i < ad.Length; i++)
            {
                Console.WriteLine(ad[i]);
            }
            int sayac = 0;
            foreach (string sehir in sehirler)
            {
                for (int i = 0; i < sehir.Length; i++)
                {
                    string s = sehir[i].ToString().ToUpper();
                    if (s == "A")
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine($"Şehirlerde toplam {sayac} tane a harfi var.");




            // Diziden diziye kopyalama
            int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };

            int[] dizi2 = new int[10];

            // dizi1'i dizi2'ye 0. indisten itibaren kopyala.
            dizi1.CopyTo(dizi2, 0);

            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }

            //--------------------------------------------------------

            int[] dizi11 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };

            int[] dizi12 = { 44, 55, 13, 14, 12, 54, 21, 33, 57, 56 };

            // dizi1'i dizi2'ye 0. indisten itibaren 3 elemanı kopyala.
            // 2. dizide ilk 3 eleman değişir.
            //Array.Copy(dizi1, dizi2, 3);

            // dizi11'in 3. indisinden itibaren 5 elemanı kopyala
            // dizi12'ye 0. indisten itibaren yapıştır.

            Array.Copy(dizi1, 3, dizi2, 0, 5);

            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }


            //--------------------------------------------------------

            int[] dizi111 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };

            int[] dizi112 = { 44, 55, 13, 14, 12, 54, 21, 33, 57, 56 };

            int[] dizi3 = new int[20];

            // dizi3'ün ilk 10 elemanını dizi111'den kopyaladık.
            dizi1.CopyTo(dizi3, 0);
            // dizi3'ün sonraki 10 elemanını dizi112'den kopyaladık.
            Array.Copy(dizi2, 0, dizi3, 10, 10);

            foreach (var item in dizi3)
            {
                Console.WriteLine(item);
            }

            object[] karisikDizi = new object[6];

            karisikDizi[0] = 55;
            karisikDizi[1] = "Text";
            karisikDizi[2] = 'R';
            karisikDizi[3] = 55.6F;
            karisikDizi[4] = 55.9M;
            karisikDizi[5] = 55.9D;

            foreach (var item in karisikDizi)
            {
                if (item is int)
                    Console.WriteLine(item + " int tipinde");
                else if (item is string)
                    Console.WriteLine(item + " string tipinde");
                else if (item is float)
                    Console.WriteLine(item + " float tipinde");
                else if (item is decimal)
                    Console.WriteLine(item + " decimal tipinde");
                else if (item is char)
                    Console.WriteLine(item + " char tipinde");
                else
                {
                    Console.WriteLine(item + " " + item.GetType() + " tipindedir.");
                }
            }






            Console.Read();

        }
    }
}