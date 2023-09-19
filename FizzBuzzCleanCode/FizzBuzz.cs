using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCleanCode
{
    public class FizzBuzz
    {
        public void DecideFizzOrBuzz(int number)
        {
            if (number > 0&&number<101)
            {
                if(IsThree(number)  )
                {
                    Console.WriteLine("Fizz");
                }
                else if(IsFive(number))
                {
                     Console.WriteLine("Buzz");
                }
                else if(IsThreeAndFive(number)) 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }

        }
        
        public bool IsThree(int number) { return number % 3 == 0; }
        public bool IsFive(int number) { return number%5==0; }
        public bool IsThreeAndFive(int number) { return number % 3 == 0 && number % 5 == 0; }
    }
}
