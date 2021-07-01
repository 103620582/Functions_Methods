using System;

namespace FunctionsMethods
{
    class Program
    {
    
        public static int Spaces(string count) {
            int counter = 0;
            string string1;
            for (int i = 0; i < count.Length; i++) {
                string1 = count.Substring(i,1);
                if (string1 == " ")
                    counter++;
            }
            return counter;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();
            
            Console.WriteLine(input + " contains {0} spaces", Spaces(input));

    }
}
