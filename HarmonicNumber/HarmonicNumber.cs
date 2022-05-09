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
            for(int index = 1; index <= number; index++)
            {
                Console.Write("1/"+ index + " + " );
            }
        }
    }
}
