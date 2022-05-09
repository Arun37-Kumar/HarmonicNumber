using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber
{
    class HarmonicNumber
    {
        public void PrintHarmonicNumber(int number)
        {
            float sumOfHarmonicNumbers = 0;
            for (float index = 1; index <= number; index++)
            {
                sumOfHarmonicNumbers = (sumOfHarmonicNumbers) + (float)(1 / index);
            }
            Console.WriteLine("Sum is : "+ sumOfHarmonicNumbers);
        }
    }
}
