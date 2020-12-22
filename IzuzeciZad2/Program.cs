using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite brojilac: ");
                int brojilac = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Unesite imenilac: ");
                int imenilac = Convert.ToInt32(Console.ReadLine());

                int rezultat = brojilac / imenilac;
                Console.WriteLine(rezultat);
            }
            catch (FormatException) { Console.WriteLine("Unesite ispravan format"); }

            catch (OverflowException) { Console.WriteLine($"Dozvoljeni su brojevi od {Int32.MinValue} do {Int32.MaxValue}"); }

            catch (DivideByZeroException) { Console.WriteLine("Imenilac ne moze biti 0"); }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadLine();
        }
    }
}
