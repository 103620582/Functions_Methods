using System;

namespace FunctionsMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            Welcome();
            NiceDay();
        
        }

        public static void Welcome() {
            Console.WriteLine("What's ya name?");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome friend" + " " + name + "!");
        }

        public static void NiceDay() {
            Console.WriteLine("Have a nice day!");
        }
    
    }
}
