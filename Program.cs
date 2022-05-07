using System;

namespace LargestNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine("Largest number is:{0}", a);
            }
            else if ((b > c) && (b > a))
            {
                Console.WriteLine("Largest number is: " + b);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }
        }
    }
}

