namespace ArrayFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Array sinifi
            //Su ana kadar gordugumuz ilkel diziler bize copk esneklik saglamadi
            //microsoft muh gelistirdigi Array snifi diziler yeniden boyutlandirmak,
            //siralamak temizlemek icin gerekli araclari sunar.

            string[] sehirler = { "Adana", "Ankara", "Izmir", "Istanbul", "Bursa", "Kocaeli", "Samsun", "Mus", "Eskisehir" };
            #region Clear metodu
            //1.parametre kaynak dizi
            //2.parametre nerden baslayacagi
            //3.parametre kac adet silecegi
            //Array.Clear(sehirler,1,2);
            //foreach (var item in sehirler)

            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Copy
            // Array.Copy => Bir diziden başka bir diziye eleman kopyalar.
            //1.kullanım sekli (ilk 4u alır.
            //string[] sehirleryeni = new string[4];
            //Array.Copy(sehirler, sehirleryeni,4);
            //foreach (var item in sehirleryeni)
            //{
            //    Console.WriteLine(item);
            //}


            //2.kullanım sekli(0,1,2 yani izmirden sonra 4 alır.
            //string[] sehirleryeni = new string[4];
            //Array.Copy(sehirler,2,sehirleryeni,0,4);
            //foreach (var item in sehirleryeni)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region IndexOf
            //Dizide aranan elemanin index numarasini dondurur.
            //Console.WriteLine( "Sehir adi giriniz" );
            //string sehir = Console.ReadLine();
            //int index = Array.IndexOf(sehirler, sehir);
            //Console.WriteLine($"{index} {sehir}");
            #endregion
            #region LAstIndexOf 
            //2adet ayni zimbirtidan varsa sondakini verir.
            //Dizide aranan elemanin index numarasini dondurur.
            //Console.WriteLine("Sehir adi giriniz");
            //string sehir = Console.ReadLine();
            //int index = Array.LastIndexOf(sehirler, sehir);
            //Console.WriteLine($"{index} {sehir}");
            #endregion
            #region Resize
            //Array.Resize(ref sehirler, 20);
            //foreach (var item in sehirler) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Sort
            //Array.Sort(sehirler);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Reverse(ters)
            //Array.Reverse(sehirler);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            
            #endregion


        }
    }
}