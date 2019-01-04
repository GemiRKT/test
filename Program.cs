using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz Haslo");
            Haslo2 wpisz = new Haslo2();
            wpisz.ZgadujHaslo();
            Console.Clear();
            Console.WriteLine("Super odgadles haslo");
            Console.ReadKey();
        }
    }
}
