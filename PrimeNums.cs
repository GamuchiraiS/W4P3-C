using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class PrimeNums
    {
        //variables 
        public int num;
        //constructor
        public PrimeNums(int input)
        {
            num = input;
        }
        //function to determine whether num is a prime
        //or not
        public bool IsPrimeNum(int num)
        {
            //divides the num by i starting at 2 
            //For self: also Prime numbers > 1
            int i;
            for (i = 2; i < num; i++)
            {
                /*if statement to find out if the num
                 * has a remainder equal to 0
                 * If it does, return false
                 */
                if (num % i == 0)
                {
                    return false;
                }
            }
            if (i == num)
            {
                return true;
            }
            //Default: return false;
            return false;
        }
    }
}
