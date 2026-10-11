using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    static internal class UIManager
    {
        public static void PrintGameGrid()
        {
            Console.WriteLine("" +
                "1 | 2 | 3" +
                "---------" +
                "4 | 5 | 6" +
                "---------" +
                "7 | 8 | 9");
        }

        public static void PrintGameGrid(char[] contents)
        {

            for (int turns = 1; turns <= 9; turns++)
            {
                if (turns % 2 == 1)
                {
                    
                }
            }

        }

    }
}
