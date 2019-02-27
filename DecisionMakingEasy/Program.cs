using System;

namespace DecisionMakingEasy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IfElse();
            NestedIF();
        }

        private static void NestedIF()
        {
            int i = 10;

            if (i > 0)
            {
                if (i <= 100)
                {
                    Console.WriteLine("i is positive number less than 100");
                }
                else
                {
                    Console.WriteLine("i is positive number greater than 100");
                }
            }
        }

        private static void IfElse()
        {
            int i = 10, j = 20;

            if (i > j)
                Console.WriteLine("i is greater than j");
            else if (i < j)
                Console.WriteLine("i is less than j");
            else if (i == j)
                Console.WriteLine("i is equal to j");
        }
    }
}
