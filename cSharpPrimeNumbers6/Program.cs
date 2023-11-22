using System;

namespace cSharpPrimeNumbers6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i, flag=0;
            Console.WriteLine("Enter the number...: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                for (i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(num + " is a PRIME number.");
                }
                else
                {
                    Console.WriteLine(num + " is not a PRIME number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a VALID number....!");
            }
        }
    }
}
