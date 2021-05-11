using System;

namespace FunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(15, 16);
        }
            static void Sum(int num1, int num2) {

                int sum = num1 + num2;
                Console.WriteLine(sum);
            }
    }
}
