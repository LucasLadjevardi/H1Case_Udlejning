using System;
using System.Collections.Generic;

namespace Udlejningsfirma
{
    class MenuOpsætning
    {
        public static int index { get; set; }
        public static string TegnMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                index++;
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                index--;
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                return items[index];
            }
            else
            {
                return "";
            }
            Console.Clear();
            return "";
        }
    }
}