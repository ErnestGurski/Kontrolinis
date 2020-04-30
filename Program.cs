using System;
using System.Collections.Generic;

namespace Ernest
{
    class Program
    {
        private const int peomWidth = 48;
        private static List<string> dataList = new List<string>();


        private static void PrintStarHeader()
        {
            Console.WriteLine("@"+new String('*', 63)+"@");
        }
        private static void PrintDottedLine()
        {
            Console.WriteLine("@" + new String('-', 63) + "@");
        }

        private static void PrintTableHeader(string col1, string col2, string col3, string col4, string col5)
        {
            Console.WriteLine("@"+"{0, -5}|{1, 9}|{2, -15}|{3, -15}|{4, -15}@", col1, col2, col3, col4, col5);
        }


        private static void PrintTextLeft(string text)
        {
            Console.WriteLine("* {0, " + ((peomWidth - 4) * -1) + "} *", text);
        }
        private static void PrintTextRight(string text)
        {
            Console.WriteLine("* {0, " + (peomWidth - 4) + "} *", text);
        }

        private static void CollectData()
        {
            Console.WriteLine("Enter data separated by spaces: Nr, Auto G. NR, Event Y, Event M. Event D.");
            for(int x=0; x<9; x++)
            {
                Console.WriteLine(x+1);
                dataList.Add(Console.ReadLine());
            }
        }

        private static void PrintTable()
        {
            CollectData();
            PrintStarHeader();
            PrintTableHeader("Nr.", "Auto G.NR", "Event Y.", "Event M.", "Event D.");
            PrintStarHeader();
            for(int x=0; x<9; x++) { 
                var data = dataList[x].Split(' ');
                PrintTableHeader(data[0], data[1], data[2], data[3], data[4]);
                if (x != 8)
                    PrintDottedLine();
            }

            PrintStarHeader();
        }

        private static void CalculateExpresion()
        {
            for (int x = -1; x <= 1000; x += 25)
            {
                double y = Math.Pow(1 + x, 1 / 3) * 25 * Math.Pow(x, -4);
                Console.WriteLine("When X = " + x + " then Y =" + y);
            }
        }

        private static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select program:");
                Console.WriteLine("1. Print table");
                Console.WriteLine("2. Calculate expresion");
                Console.WriteLine();
                Console.WriteLine("To end program enter TERMINATE");

                switch (Console.ReadLine())
                {
                    case "1":
                        PrintTable();
                        break;
                    case "2":
                        CalculateExpresion();
                        break;
                    case "TERMINATE":
                        return;
                    default:
                        Console.WriteLine("ERR!");
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