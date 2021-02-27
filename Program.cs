using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parzystosc_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("0 kończy działanie programu");
            try
            {
                do
                {
                    Console.Write("Podaj liczbę:");
                    number = GetNumber();
                    if (number % 2 == 0)
                        Console.WriteLine("Liczba parzysta");
                    else
                        Console.WriteLine("Liczba nieparzysta");

                } while (number != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public static int GetNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int number))
                throw new Exception("Podaj prawidłową liczbę.");
            return number;
        }
    }
}
