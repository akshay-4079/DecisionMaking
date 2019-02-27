using System;

namespace DecisionMakingHard
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GotoSwitch();
            NestedSwitch();
        }

        private static void NestedSwitch()
        {
            int j = 5;

            switch (j)
            {
                case 5:
                    Console.WriteLine(5);
                    switch (j - 1)
                    {
                        case 4:
                            Console.WriteLine(4);
                            switch (j - 2)
                            {
                                case 3:
                                    Console.WriteLine(3);
                                    break;
                            }
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine(10);
                    break;
                case 15:
                    Console.WriteLine(15);
                    break;
                default:
                    Console.WriteLine(100);
                    break;
            }
        }

        private static void GotoSwitch()
        {
            string statementType = "switch";

            switch (statementType)
            {
                case "DecisionMaking":
                    Console.Write(" is a decision making statement.");
                    break;
                case "if.else":
                    Console.Write("if-else");
                    break;
                case "ternary":
                    Console.Write("Ternary operator");
                    break;
                case "switch":
                    Console.Write("switch statement");
                    goto case "DecisionMaking";
            }
        }
    }
}
