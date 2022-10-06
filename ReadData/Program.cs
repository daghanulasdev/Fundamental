using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sonuc = "";
            int toplam = 0, a = 0, b= 0;
            for (int i = 0; i < args.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(args[i]);
            }
            if(args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if(i==0)
                    {
                        //1.YOL
                        a= Convert.ToInt32(args[i]);
                    }
                    else if (i == 2)
                    {
                        //2.YOL
                        b = int.Parse(args[i]);   

                        
                    }
                    if (args[1] == "+")
                        toplam = (a + b);
                    else if (args[1] == "-")
                        toplam = (a - b);
                    else if (args[1] == "*")
                        toplam = (a * b);
                    else if (args[1] == "/")
                        toplam = (a / b);
                    else
                        Console.WriteLine("Yanlış operatör girdiniz.");

                }

                
                Console.WriteLine("Sonuc:"+toplam);
                Console.ReadLine();
            }

        }
    }
}
