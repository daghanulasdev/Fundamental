namespace ReadData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ekrandan Veri Okuma


            //Console.ForegroundColor = ConsoleColor.Cyan;
            ////Ekrandan Veri Okuma
            ////Degisken tanimlamalari yapilirken veri tipinin sonuna
            ////Eger ki ? konulursa NULL deger alabilir demektir.

            //string? giris;
            //int sayi1, sayi2;
            //DateTime trh;


            //Console.WriteLine("Birinci sayiyi giriniz:");
            //giris =Console.ReadLine(); // Ekrandan sayi okutuyoruz.
            //sayi1 = Convert.ToInt32(giris);

            //Console.WriteLine("Ikinci sayiyi giriniz:");
            //giris = Console.ReadLine(); // Ekrandan sayi okutuyoruz.
            //sayi2 = Convert.ToInt32(giris);

            //Console.WriteLine("Tarih giriniz:");
            //giris=Console.ReadLine();
            //trh = Convert.ToDateTime(giris);

            ////Ekrana gösterme yol1
            //Console.WriteLine("Girilen Sayilar {0} ve {1}",sayi1, sayi2);
            ////YOL2
            //Console.WriteLine("Girilen Sayilar: "+sayi1+" ve "+sayi2);
            //YOL3
            //Console.WriteLine($"Girilen sayilar {sayi1}+  ve  +{ sayi2}");

            //Console.WriteLine("Tarih Giriniz:"+trh);
            #endregion
            #region Aritmetik islemler
            /* Aritmetik op
              Dort islem icin + - * /
            Kalan operatoru %
            Arttirma ++ 
            Eksiltme --   */

            int a = 5; int b = 32; int c = 0; //int d = 5;
            Console.WriteLine($"{b} nin {a} bolumunden kalan {b % a}");

            c=a + b; // Sonuc : 37
            c = 0;
            b++;
            c = a + b; // Sonuc : 38
            //++ solda olursa önce ekler sonra toplar. ++ sagda olursa once toplar sonra ekler.
            c = a + b++;
            //Acik Deklerasyon
            a++; // a=a+1
            b++; // b=b+1
            c = a + b;
            a += 1; // uzerine toplar.1 ekler. +=2 ise 2 ekler.
            b -= 1; // 1 iner
            a *= 2; //a=a*2

            a *= a;
            Console.WriteLine("a:" + a);
            a *= a;
            Console.WriteLine("a:" + a);









            Console.WriteLine("Sonuc:" + c);
            


            #endregion
            Console.WriteLine("Cikmak icin enter bas");
            Console.ReadLine();
            
        }
    }
}
