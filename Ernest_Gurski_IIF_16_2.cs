using System;

namespace Ernest
{
    class Program
    {
        private const int peomWidth = 48;

        private static string[] poem = {   
@***********************************************@
@Nr.  |Auto G.NR| Event Y.|   Event M.| Event D.@
@***********************************************@
@    1|ASD463   |     2000|         12|       25@
@-----------------------------------------------@
@    2|SDF987   |     2010|         05|       10@
@***********************************************@
};

        private static void PrintStarLine()
        {
            Console.WriteLine(new String('*', peomWidth));
        }

        private static void PrintTextLeft(string text)
        {
            Console.WriteLine("* {0, " + ((peomWidth - 4) * -1) + "} *", text);
        }
        private static void PrintTextRight(string text)
        {
            Console.WriteLine("* {0, " + (peomWidth - 4) + "} *", text);
        }


        private static void PrintPoem()
        {
            PrintStarLine();

            PrintStarLine();
            PrintTextLeft(new String(' ', 5) + "Poet: William Butler Yeats");
            PrintTextRight("Published: 1899");
            PrintStarLine();
        }

        private static void CalcExpre()
        {
            for (int x = -1; x <= 1000; x += 25)
            {
                double y = Math.Pow(1+x, 1/3) * 25 * Math.Pow(x, -4);
                Console.WriteLine("When X = " + x + " then Y =" + y);
            }
        }

        private static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select program:");
                Console.WriteLine("1. Print poem");
                Console.WriteLine("2. Calculate expresion");
                Console.WriteLine();
                Console.WriteLine("To end program enter TERMINATE");

                switch (Console.ReadLine())
                {
                    case "1":
                        PrintPoem();
                        break;
                    case "2":
                        CalcExpre();
                        break;
                    case "TERMINATE":
                        return;
                    default:
                        Console.WriteLine("No such command");
                        break;
                }
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
