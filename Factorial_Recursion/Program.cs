using System;

namespace Factorial_Recursion
{
    class Program
    {

            static void Main(string[] args)

            {

                Console.WriteLine("Enter a Number");

                int num = Convert.ToInt32(Console.ReadLine());

                long fact = FindFactorial(num);

                Console.WriteLine("{0} factorial is {1}", num, fact);

                Console.ReadKey();

            }



            private static long FindFactorial(int number)

            {

                if (number == 0)

                {

                    return 1;

                }

                return number * FindFactorial(number - 1);

            }

        }

    }