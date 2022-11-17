using System.Collections;

namespace ArrayListOrn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList object turunden deger kabul ettigi icin
            // icerisine herhangi bir sey atabilirsiniz.


            ArrayList yenidizi = new ArrayList();
            int [] sayilar = {1,2,3, 4, 5, 6, 7, 8, 9,0};
            yenidizi.Add(15);
            yenidizi.Add("Ali");
            yenidizi.Add(DateTime.Now);
            yenidizi.Add(sayilar);
            yenidizi.Add(true);
            //-------ArrayList icerisinden eleman okumak icin

            //Console.WriteLine(yenidizi[0]);
            //foreach (var item in yenidizi)
            //{
            //    Console.WriteLine(item);
            //}

            //-------Dizi boyutu
            //Console.WriteLine(yenidizi.Count);

            //-------Araya eleman eklemek icin insert kodu kullanilir
            //yenidizi.Insert(2, "Veli");
            //Console.WriteLine(yenidizi[0]);
            //foreach (var item in yenidizi)
            //{
            //    Console.WriteLine(item);
            //}

            //------Diziden elelman silmek icin remove kullanilir.
            //index numarasina gore silmek istersek removeAt kullanilir.
            //yenidizi.Remove("Veli");
            //Console.WriteLine(yenidizi[0]);

            //------siralama icin sort kullanilir. Ancak problemlidir.
            //icerisinde object veri turu tuttugu icin kiyaslanma problemi yasar.
            //yenidizi.Sort();

            foreach (var item in yenidizi)
            {
                Console.WriteLine(item);
            }

        }
    }
}