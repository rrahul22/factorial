using System;

namespace FactorialProgram
{
    class Factorial
    {
        public static void Main(string[] args)
        {
            ulong num, result;
            ulong factorial = 1;
            string msg = string.Empty;

            Console.Write("Enter Number : ");
            string input = Console.ReadLine();
            if (!UInt64.TryParse(input, out result))
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
                return;
            }

            num = Convert.ToUInt64(input);

            factorial = GetFactionalUsingRecursion(num, ref msg);

            Console.WriteLine("Factorial Using Recursion -->");
            Console.WriteLine("Factorial is ({0}) so output {1}", msg, factorial);

            msg = string.Empty;
            factorial = 1;

            Console.WriteLine("Factorial Using Iteration -->");

            for (ulong i = num; i > 1; i--)
            {
                msg += i.ToString() + " * ";
                factorial *= i;
            }
            msg += 1.ToString();

            Console.WriteLine("Factorial is ({0}) so output {1}", msg, factorial);

            Console.ReadLine();
        }

        public static ulong GetFactionalUsingRecursion(ulong number, ref string message)
        {
            if (number == 0 || number == 1)
            {
                message += number.ToString();
                return number;
            }
            else
            {
                message += number.ToString() + " * ";
                return number * GetFactionalUsingRecursion(number - 1, ref message);
            }
        }
    }
}
