using System;
using System.Collections.Generic;
using Udlejningsfirma;

namespace Console_Menu
{
    class Menu
    {
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
                string selectedMainMenu = MenuOpsætning.TegnMenu(MainMenu);
                if (selectedMainMenu == "KundeHåndtering")
                {
                    Console.WriteLine("Vælg et område:\n");
                    while (true)
                    {
                        string selectedKundeHåndteringsMenu = MenuOpsætning.TegnMenu(KundeHåndteringsMenu);
                        Console.WriteLine("Vælg et område:\n");
                        if (selectedKundeHåndteringsMenu == "Sjælland")
                        {

                        }
                        else if (selectedKundeHåndteringsMenu == "Fyn")
                        {

                        }
                        else if (selectedKundeHåndteringsMenu == "Jylland")
                        {

                        }
                        else if (selectedKundeHåndteringsMenu == "Tilbage")
                        {
                            Console.Clear();
                            MenuOpsætning.index = 0;
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
    }
}