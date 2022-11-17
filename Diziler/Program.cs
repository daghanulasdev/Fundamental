namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            #region infosession.


            /* Array=Dizi
              Birden fazla ayni tipten veriyi bir arada tutmamizi saglayan nesnelerdir.

          Cok kasilasilan hata: Index outside the bounds of the array
            Eger bu hatayi alirsaniz bilinki dizinin boyutunu asacak bi işlem yapmaktadır.
             
             */
            // 1.ci tanımlama [] operatoru ile tanımlanır.
            // Veritip[] diziAdi = new VeriTi[ElemanSayisi]
            //int[] sayilar = new int[3];
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;
            ////burdan sonrası hata verir
            /////Verdigi hata: Index outside the bounds of the array
            //sayilar[3] = 4;

            // //2.tanımlama. Object initilaise
            // //string[] sehirler = new string[3] { "Adana", "Ankara", "İstanbul" };

            // ////3.tanımlama
            // //string[] sehirler2 = { "Adana", "Ankara", "İstanbul" };

            // //char[] alfabe = { 'a', 'b', 'c' };

            // // dizinin eleman sayisi. Lenght propert içindendir.
            // Console.WriteLine("Dizi Boyutunu giriniz");
            // int boyut = Convert.ToInt32(Console.ReadLine());
            //int[] sayilar = new int[boyut];

            // int index = 0;
            // Random rand = new Random();
            // //While Dongusu 
            // while (index < boyut)
            // {
            //     sayilar[index] = rand.Next();

            //     index++;

            // }
            // index = 0;
            // do
            // {
            //     Console.WriteLine(sayilar[index]);
            //     index++;
            // } while (index < boyut);

            #endregion

            #region Sorular 1
            //Rastgalee olusuturulan 50 elemanli bir dizinin 
            //tek ve çift sayilari miktarı
            //    Random rand = new Random();
            //    int[] sayilar = new int[50];
            //    int cift = 0, tek = 0;
            //    for (int i = 0; i < sayilar.Length; i++)
            //    {
            //        sayilar[i] = rand.Next(0, 100);
            //    }
            //    for (int i = 0; i < sayilar.Length; i++)
            //    {
            //        if (sayilar[i] % 2 == 0)
            //        { 
            //            cift++;
            //    }

            //    else
            //    {
            //        tek++;
            //    }
            //}
            //    Console.WriteLine("---Dizidokumu---");
            //    for (int i = 0; i < sayilar.Length; i++)
            //    {
            //        Console.WriteLine(sayilar[i]);

            //    }

            //    Console.WriteLine("--------");
            //Console.WriteLine("Dizideki tek eleman sayisi:"+tek);
            //    Console.WriteLine("dizideki cift eleman sayisi:"+cift);

            #endregion

            #region Ekrandan okunan sayinin fakotriyeli

            //Console.WriteLine("sayi giriniz:");

            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = sayi; i>1 ; i--)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine($"Girilen {sayi} nin faktoriyeli {sonuc}");


#endregion





        }
    }
}