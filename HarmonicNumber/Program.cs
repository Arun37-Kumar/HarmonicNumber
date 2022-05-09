using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter the number ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0)
                {
                    Console.WriteLine("Entered Wrong Value!");
                }
                HarmonicNumber harmonic = new HarmonicNumber();
                harmonic.PrintHarmonicNumber(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();

        }

    }
}
