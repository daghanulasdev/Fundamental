namespace firstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte 0 to 255
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            //Short
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            //ushort
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            //int
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            //uint
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            //long
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            //ulong
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            //bool true false.
            //char ch="a"
            //string str= "istedigin kadar yaz"
            //DateTime date = new DateTime(); 
            Console.WriteLine(DateTime.Today);
            Console.WriteLine("vamo espana");
        }
    }
}