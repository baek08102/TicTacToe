namespace TicTacToe
{
    class UIManager
    {

        private char[] markersOnGrid = { '.', '.', '.', '.', '.', '.', '.', '.', '.' };

        public void PrintMessages(int player, int position, int difficulty = 1)
        {
            Console.Clear();

            Console.WriteLine($"" +
                $"=== 틱택토 게임 · {difficulty}단계 ===\n" +
                $"두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
            Console.WriteLine();
            Console.WriteLine("위치 번호: ");
            PrintPositionGrid();
            Console.WriteLine();
            Console.WriteLine("현재 보드: ");
            PrintGameGrid();
            Console.WriteLine();
            if (player == 1)
            {
                Console.WriteLine("플레이어 X의 차례입니다.");
            }
            if (player == 2)
            {
                Console.WriteLine("플레이어 O의 차례입니다.");
            }
        }

        private void PrintPositionGrid()
        {
            Console.WriteLine("" +
                "1 | 2 | 3\n" +
                "---------\n" +
                "4 | 5 | 6\n" +
                "---------\n" +
                "7 | 8 | 9");
        }

        private void PrintGameGrid()
        {
            Console.WriteLine($"" +
                $"{markersOnGrid[0]} | {markersOnGrid[1]} | {markersOnGrid[2]}\n" +
                $"---------\n" +
                $"{markersOnGrid[3]} | {markersOnGrid[4]} | {markersOnGrid[5]}\n" +
                $"---------\n" +
                $"{markersOnGrid[6]} | {markersOnGrid[7]} | {markersOnGrid[8]}\n");
        }

        public void setMarkerOnGrid(int player,int position)
        {
            switch (player)
            {
                case 1: 
                    markersOnGrid[position - 1] = 'X';
                    break;
                case 2:
                    markersOnGrid[position - 1] = 'O';
                    break;
            }
        }
    }
}
