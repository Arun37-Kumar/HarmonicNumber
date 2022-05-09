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
            Console.WriteLine("Enter the number ");
            int number = Convert.ToInt32(Console.ReadLine());
            HarmonicNumber harmonic = new HarmonicNumber();
            harmonic.PrintHarmonicNumber(number);
            Console.ReadLine();

        }

    }
}
