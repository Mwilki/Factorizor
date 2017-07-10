using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{

    /// <summary>
    /// Given a number, print the factors per the specification
    /// </summary>
    /// 
    public class FactorFinder
    {


        public string PrintFactors(string number)
        {
            int num = int.Parse(number);

            string factors = "";
            string reformatted = "";
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                   
                    factors += $"{i}" + ", ";
                }
            }
            reformatted = factors.Remove(factors.Length - 2, 1).Trim();

            return reformatted;
        }
    }
}
