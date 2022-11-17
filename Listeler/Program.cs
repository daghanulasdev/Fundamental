namespace Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List <> icerisine (<T>ype) verilen tipe burunerek gelir o tiple ilgili ArrayList ozelligine kavusur.
            //Contains tekrarı onler.
            Random random = new Random();
            List<string> sehirler = new List<string>();
            List<int> sayilar = new List<int>();
            sehirler.Add("Adana");
            sehirler.Add("Ankara");
            int a = 0;
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(random.Next(1,100));
                if (i == 32)
                    a = 1;
            }

            sayilar.ForEach(x => Console.WriteLine(x));




        }
    }
}