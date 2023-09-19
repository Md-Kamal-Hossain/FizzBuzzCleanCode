using System;

namespace FizzBuzzCleanCode // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());            
            for(int num =0;num<101;num++)
            {
                FizzBuzz fizzBuzz = new FizzBuzz();
                fizzBuzz.DecideFizzOrBuzz(num);
            }
            
        }
    }
}