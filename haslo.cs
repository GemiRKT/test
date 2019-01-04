using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Haslo
    {
        public void Zgaduj()
        {
            String haslowpisane;
            String haslostale = "Zupa Pomidorowa";
            Console.WriteLine("Prosze podac haslo: ");
            haslowpisane = Console.ReadLine();
            if (haslowpisane.Equals(haslostale))
            {
                Console.WriteLine("jestes super odgadles haslo");
            }
            else { Console.WriteLine("jestes baran"); }

        }
    }
}
