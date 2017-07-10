using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    public class PerfectChecker
    {

        public bool IsPerfect(string number)
        {

            int num = int.Parse(number);
            int sum = 0;
            bool perfect;

            for (int factor = 1; factor < num; factor++)
            {
                if (num % factor == 0)
                {
                    sum = sum + factor;
                }
            }

            if (sum == num)
                perfect = true;
            else
                perfect = false;

            return perfect;
        }
    }
}
