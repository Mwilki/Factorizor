using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    public class PrimeFinder
    {

        public bool PrimeChecker(string number)
        {
            int num = int.Parse(number);
            bool IsPrime = false;
            if (num == 0 || num == 1)
            {
                IsPrime = false;
            }

            for (var i = 1; i < num; i++)
            {
                if (num == 2 || num == 3) { IsPrime = true; }
                else if (num % 2 == 0) { IsPrime = false; }
                else if (num % 3 == 0) { IsPrime = false; }
                else { IsPrime = true; }
            }
            return IsPrime;
        }
    }
}
