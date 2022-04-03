using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Connect_Four
{
    class Menu
    {
        public void ShowMenu()
        {
            WriteLine("Welcome to Connect Four");
            WriteLine("Main Menu");
            WriteLine("1: Player vs Player");
            WriteLine("2: Player vs Computer");
            WriteLine("3: How to play(Help)");
            WriteLine("4: Load Last Save");
            WriteLine("5: Exit");

            //Ask the user to enter the item that they want
            int item = PromptForInt("Menu Choice");


        }

        // Prompts the user for an integer, if they enter something invalid, prompts again
        // until they enter a value value.
        public static int PromptForInt(string prompt)
        {
            while (true)
            {
                Write("Enter a number:");
                string input = ReadLine();
                int result;
                if (!int.TryParse(input, out result))
                {
                    WriteLine("Invalid input! Try again.");
                    continue;
                }

                return result;
            }

        }

        public void HelpMenu()
        {
            Menu menu1 = new Menu();

            WriteLine("--- Welcome to Connect Four ---");
        }

    }
}
