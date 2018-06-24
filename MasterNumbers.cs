using System;
using System.Linq;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (IsSymetric(i.ToString()) && SumDivisibleBySevenAndEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }     

        static bool IsSymetric(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }        
            }
            return true;
        }

        static bool SumDivisibleBySevenAndEvenDigit(int number)
        {
            int sum = 0;
            bool evenDigit = false;

            while (number !=0)
            {
                var test = number % 10;
                if (test % 2 == 0)
                {
                    evenDigit = true;
                }
                sum += test;
                number /= 10;
            }

            if (sum % 7 == 0 && evenDigit == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
