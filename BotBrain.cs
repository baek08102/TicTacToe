using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    internal class BotBrain
    {
        private int gamemode = 0;

        public void SetGamemode(int gamemode)
        {
            this.gamemode = gamemode;
        }

        private void BotAlgorythm(int[] position)
        {
            int count = 0;
            foreach (int i in position)
            {
                if (i != 0)
                {
                    count++;
                }
            }

            int[] remainIndexes = new int[count];

            switch (gamemode)
            {
                case 1:



                    break;

                case 2:

                    break;
            }

        }
    }
}
