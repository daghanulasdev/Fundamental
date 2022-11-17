namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            // while dongusu kosul dogru oldugu surece calisir.
            //Eger kosul yanlıs ise donguden cıkacaktır.

            //Tek sayi girilince sonlanan dongu
            //int sayi=0;
            //while (sayi%2==0)
            //{
            //    Console.WriteLine("Sayi giriniz");
            //    sayi = int.Parse(Console.ReadLine());

            //}

            #region Sayinin basamaklarini bulan dongu
            //Console.WriteLine("En az iki bas bir sayi giriniz");
            //int girilen = int.Parse(Console.ReadLine());
            //int basamak = 0;
            //while (girilen>0)
            //{
            //    basamak++;
            //    girilen = girilen / 10;
            //}
            //Console.WriteLine($"Girdiginiz sayi {basamak} basamaklidir");



            #endregion

            #region Ekrandan girilen sayi 0 olana kadar girilen sayilarin ve tek topl bulunuz
            //int tektoplam=0, cifttoplam = 0;
            //int sayi = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayi giriniz:");
            //    sayi= int.Parse(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        break; //Donguyu kır.
            //    }
            //    else
            //    {
            //        if (sayi % 2 == 0) cifttoplam++;

            //            else
            //             tektoplam++; 
            //    }
            //}

            #endregion

            #region while il sayi tahmin oyunu
            //int tahminhakki = 10, tutulansayi = 0, tahmin = 0; sayac = 0;
            //Random rnd = new Random();
            //tutulansayi = rnd.Next(1, 50);

            //while (true)
            //{
            //    Console.WriteLine("Tahmin giriniz:");
            //    tahmin= int.Parse(Console.ReadLine());
            //    if (tahmin< tutulansayi)
            //    {
            //        Console.WriteLine("Tahmini buyutunuz");
            //        tahminhakki--;
            //    }
            //    else if (tahmin > tutulansayi)
            //    {
            //        Console.WriteLine("Tahmini kucultun");
            //        tahminhakki--;
            //    }
            //    else
            //            {
            //        Console.WriteLine($" Tebrikler {tahminhakki}. denemede buldunuz.");
            //        break;

            //    }
            //}
            //int j; int i;
            //for (i = 1; i <11 ; i++)
            //{
            //    for ( j = 1; j < 11 ; j++)
            //    {
            //        Console.Write($"{i}*{j}={i * j}\t"); 
            //    }

            //}

            //Console.ReadKey();

            //int i; int fibo; int fibo2; int topfibo;
            //Console.WriteLine("Fibonacci icin sayi gir");
            //string? giris = Console.ReadLine();
            //i = Convert.ToInt32(giris);
            //for (i = 1; i <5; i++)
            //{
            //    fibo = 1;
            //    fibo2 = 2;
            //    topfibo = ;

            //    Console.WriteLine(topfibo);
            //}

            #endregion

            #region fibonacci


            //Console.WriteLine("ust limiti giriniz:");
            //int ustLimit = int.Parse(Console.ReadLine());

            //int [] fibonacci = new int[ustLimit];
            //fibonacci[0] = 1;
            //fibonacci[1] = 2;

            //for ( int i=2; i<ustLimit; i++)
            //{
            //    fibonacci[i] = fibonacci[i-1]+ fibonacci[i-2];
            //}
            //for ( int i=0; i<fibonacci.Length; i++)
            //{

            //    if (i>5)
            //    {
            //        Console.WriteLine(fibonacci[i+]+"\t"+ (fibonacci);
            //    }
            //}
            #endregion

            #region 11.10.2022 Dizi boyutunu degistirme
            int[] sayilar = new int[50];
            int[] sayilar2 = new int[70];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar2[i] = sayilar[i];

            }
            // Dizi boyutu 70 yapmak icin



            #endregion


        }
    }
}