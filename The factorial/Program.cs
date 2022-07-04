using System;

namespace The_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, f = 1, i;



            Console.WriteLine("Please Enter the Valeu:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("the number is pozative");

                for (i = 1; i <= num; i++)
                {
                    f = f * i;
                    Console.WriteLine(f);


                }
                Console.WriteLine($"The Factorial of {num} is: {f}");
            }
            else
            {
                Console.WriteLine("The number Nigtive");
            }
        }
    }
}
