using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Connect_Four
{
    class Board
    {
        const int width = 7;
        const int height = 6;

        int y = 2;
        int x = 1;
        public void Grid()
        {
            int[,] myArray = new int[width, height];
            myArray[x, y] = 5;

            int value = myArray[x, y];
            WriteLine(value);
        }

        public static void BoardFrame()
        {
            WriteLine("┌───┰────┰───────────────────────┐");
            WriteLine("┠───┃────┃───────────────────────│");
            WriteLine("│───────────────────────────────│");
            WriteLine("│───────────────────────────────│");
            WriteLine("│───────────────────────────────│");
            WriteLine("│───────────────────────────────│");
            WriteLine("└───────────────────────────────┘");

        }



    }
}
                           