using System;
using System.Collections.Generic;

namespace Console_Menu
{
    class Program
    {
        private static int index = 0;

        private static void Main(string[] args)
        {
            List<string> MainMenu = new List<string>()
            {
                "KundeHåndtering",
                "EjendomsHåndtering",
                "Afslut"
            };

            List<string> KundeHåndteringsMenu = new List<string>()
            {
                "Sjælland",
                "Fyn",
                "Jylland",
                "Tilbage"
            };

            Console.CursorVisible = false;

            while (true)
            {
                string selectedMainMenu = TegnMenu(MainMenu);
                if (selectedMainMenu == "KundeHåndtering")
                {
                    while (true)
                    {
                        string selectedKundeHåndteringsMenu = TegnMenu(KundeHåndteringsMenu);
                        if (selectedKundeHåndteringsMenu == "Sjælland")
                        {
                            Console.Clear();
                            Console.WriteLine("1");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (selectedKundeHåndteringsMenu == "Fyn")
                        {

                        }
                        else if (selectedKundeHåndteringsMenu == "Jylland")
                        {

                        }
                        else if (selectedKundeHåndteringsMenu == "Tilbage")
                        {
                            break;
                        }
                    }
                }
                else if (selectedMainMenu == "EjendomsHåndtering")
                {

                }
                else if (selectedMainMenu == "Afslut")
                {
                    Environment.Exit(0);
                }
            }
        }

        private static string TegnMenu(List<string> items)
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
                if (index == items.Count - 1)
                {
                    //index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
                }
                else { index--; }
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