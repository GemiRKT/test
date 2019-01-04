using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Haslo2
    {
        public void ZgadujHaslo()
        {
            while (true)
            {
                Console.WriteLine("podaj slowo haslo:");
                string pytanie = Console.ReadLine();
                if (pytanie.Contains("tajemnica"))
                    return;
                else { Console.WriteLine("wpisz ponownie haslo"); }

            }
        }
    }
}