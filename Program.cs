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
            Console.WriteLine("ktore haslo chcesz zgadnac?: ");
            Console.WriteLine("1.Haslo Noraza");
            Console.WriteLine("2.Haslo Gomeza");
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
               case 1:
                    Haslo wpisz = new Haslo();
                    wpisz.Zgaduj();
                    break;
                case 2:
                    Haslo2 wpisz2 = new Haslo2();
                    wpisz2.ZgadujHaslo();
                    break;
                default:
                    Console.WriteLine("zly wybor, wybierz 1 lub 2 ");
                    break;
            }        
            Console.ReadKey();
        }
    }
}
