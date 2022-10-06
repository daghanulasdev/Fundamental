namespace ReadDataLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru1
            //Ekrandan girilen iki sayinin birbiriyle toplaminin,birbiine olan farkinin birbine olan kalani nedir.

            //int sayi1; int sayi2; int toplam; int fark;
            //int kalan;
            //string? giris;
            //Console.WriteLine("1.Sayiyi giriniz:");
            //giris = Console.ReadLine();
            //sayi1 = Convert.ToInt32(giris);
            //Console.WriteLine("2.Sayiyi giriniz:");
            //giris = Console.ReadLine();
            //sayi2 = Convert.ToInt32(giris);
            //toplam = sayi1 + sayi2;
            //fark = sayi1 - sayi2;
            //kalan = toplam % fark;
            //Console.WriteLine("sonuc:"+kalan);





            #endregion



            #region Soru2

            ////dısardan girilenn iki sayinin  toplaminin karesinin 3'e bolumunden kalan
            //int sayi1; int sayi2; int toplam; 
            //int kalan;
            //string? giris;
            //Console.WriteLine("1.Sayiyi giriniz:");
            //giris = Console.ReadLine();
            //sayi1 = Convert.ToInt32(giris);
            //Console.WriteLine("2.Sayiyi giriniz:");
            //giris = Console.ReadLine();
            //sayi2 = Convert.ToInt32(giris);
            //toplam= sayi1 + sayi2;
            //toplam *= toplam; 
            //toplam = toplam / 3;
            //kalan= toplam % 3;
            //Console.WriteLine("Sonuc:" + kalan);

            #endregion



            #region Soru3

            //// disaridan girilen iki sayinin karelerinin toplami ile karelerinin farkinin toplamı
            //int sayi1; int sayi2; int toplam; int fark;
            //int sonuc;
            //string? giris;
            //Console.WriteLine("1.Sayiyi giriniz:");
            //giris = Console.ReadLine();
            //sayi1 = Convert.ToInt32(giris);
            //Console.WriteLine("2.Sayiyi giriniz:");
            //giris = Console.ReadLine();
            //sayi2 = Convert.ToInt32(giris);
            //sayi1 *= sayi1;
            //sayi2 *= sayi2;
            //toplam = sayi1 + sayi2;
            //fark = sayi1 - sayi2;
            //sonuc = toplam + fark;
            //Console.WriteLine("Sonuc:" + sonuc);

            #endregion

            #region Soru4
            //Vize notu %30 Final notu %70 olan bib sistemde -ekrandan okutulacak-
            //iki vize bir final notlarini sonucu gecme kalma durumu
            //float a manuel değer atarsan sonuna f ekle.
           float vize1; float final; float ort; float vize2;
            float sonuc; string? giris;
            
            Console.WriteLine("1.Vizeyi giriniz:");
            giris = Console.ReadLine();
            vize1 = Convert.ToInt32(giris);
            Console.WriteLine("2.Vizeyi giriniz:");
            giris = Console.ReadLine();
            vize2 = Convert.ToInt32(giris);
            Console.WriteLine("Finali giriniz:");
            giris = Console.ReadLine();
            final = Convert.ToInt32(giris);
            
            ort=(vize1+ vize2)/2;
            
            sonuc = ort * 0.3f + final * 0.7f;
            if (sonuc > 45)
            {
                Console.WriteLine("Tebrikler,gectiniz.Donem sonucunuz:" + sonuc);
            }
            else
                Console.WriteLine("Kaldınız.Donem sonucunuz:"+sonuc);



            #endregion



        }
    }
}