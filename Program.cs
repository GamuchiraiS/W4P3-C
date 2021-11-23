using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: "); //ask user input
            int num = Convert.ToInt32(Console.ReadLine()); //assigns user input to num
            PrimeNums prime = new PrimeNums(num); //instantiate
            prime.IsPrimeNum(num); //call function
            //if the user input 0 or 1
            //tell them the num is not a prime
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " is not a prime number");
            }
            else
            {
                Console.WriteLine(num + " is a prime number.");
            }

            Console.ReadKey();
        }
    }
}
