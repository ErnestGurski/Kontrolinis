using System;

namespace Ernest
{
    class Program
    {
        private const int lenteleWidth = 49;

        private static string[] Lentel = {   
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
            Console.WriteLine(new String('*', lenteleWidth));
        }

        private static void PrintTextLeft(string text)
        {
            Console.WriteLine(text);
        }
        private static void PrintTextRight(string text)
        {
            Console.WriteLine(text);
        }


        private static void PrintLentele()
        {
            PrintStarLine();
			
			PrintTextLeft(Lentel[0]);
            PrintTextRight(Lentel[1]);
            PrintTextLeft(Lentel[2]);
            PrintTextRight(Lentel[3]);
            PrintTextLeft(Lentel[4]);
            PrintTextRight(Lentel[5]);
            PrintTextLeft(Lentel[6]);
            PrintTextLeft(Lentel[7]);


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
                Console.WriteLine("Pasirinkite programa:");
                Console.WriteLine("1.Lentele");
                Console.WriteLine("2.Skaiciavimas");
                Console.WriteLine();
                Console.WriteLine("Baigti rasykite zodi TERMINATE");

                switch (Console.ReadLine())
                {
                    case "1":
                        PrintLentele();
                        break;
                    case "2":
                        CalcExpre();
                        break;
                    case "TERMINATE":
                        return;
                    default:
                        Console.WriteLine("Nera tokios komandos");
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
