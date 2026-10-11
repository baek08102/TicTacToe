namespace TicTacToe
{
    internal class GameBoardManager
    {
        //private const int boardSize = 9;
        private readonly int[] guideBoard = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private readonly int[] gameBoard = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private readonly int[,] casesOfWinning ={ {1,2,3}, {4,5,6}, {7,8,9},
                                                  {1,4,7}, {2,5,8}, {3,6,9},
                                                  {1,5,9}, {3,5,7} };
        private int[] gameBoard_playerA = new int[5];
        private int[] gameBoard_playerB = new int[5];

        public int CheckPlayerWin(int[] playerA, int[] playerB)
        {
            int judge = -1;

            for (int i = 0; i < casesOfWinning.GetLength(0); i++)
            {
                int matchCountA = 0;
                int matchCountB = 0;
                for (int j = 0; j < casesOfWinning.GetLength(1); j++)
                {
                    foreach (int a in playerA)
                    {
                        if (a == casesOfWinning[i, j])
                        {
                            matchCountA++;
                        }

                        if (matchCountA == 3)
                        {
                            return judge = 1;
                        }
                    }

                    foreach (int b in playerA)
                    {
                        if (b == casesOfWinning[i, j])
                        {
                            matchCountB++;
                        }

                        if (matchCountA == 3)
                        {
                            return judge = 2;
                        }
                    }
                }
            }

            return judge;
        }
    }
}
