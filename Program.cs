using System;
using System.Runtime.CompilerServices;
using TicTacToe;

UIManager ui = new UIManager();
GameBoardManager manager = new GameBoardManager();
const int BOARDSIZE = 9;

int player = 1;
int[] position = new int[BOARDSIZE];
int turns = 1;

int[] playerA = new int[5];
int[] playerB = new int[5];

while (true)
{
    bool isValidInput = false;

    ui.PrintMessages(player, position[turns - 1]);

    // 승리 조건 검사 결과 처리
    if (manager.CheckPlayerWin(playerA, playerB) == 1)
    {
        Console.WriteLine("플레이어 X 승리!");
        Console.WriteLine("종료하려면 Enter를 누르세요.");
        Console.ReadKey(true);
        break;
    }
    if (manager.CheckPlayerWin(playerA, playerB) == 2)
    {
        Console.WriteLine("플레이어 O 승리!");
        Console.WriteLine("종료하려면 Enter를 누르세요.");
        Console.ReadKey(true);
        break;
    }

    do
    {
        Console.Write("위치를 선택하세요 (1~9): ");
        int input = int.Parse(Console.ReadLine());

        if (input < 1 || input > BOARDSIZE)
        {
            Console.WriteLine($"1부터 {BOARDSIZE}까지의 번호를 입력하세요.");
            continue;
        }
        else if (turns != 1)
        {
            bool isDuplicate = false;

            foreach (int p in position)
            {
                if (input == p)
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate)
            {
                Console.WriteLine("이미 선택한 칸입니다. 빈칸을 선택하세요. ");
                continue;
            }
        }

        position[turns - 1] = input;
        isValidInput = true;

    } while (!isValidInput);

    // 직전에 입력받은 값 턴 수에 따라 각 플레이어의 입력값 저장하는 배열에 저장
    if (player == 1)
    {
        playerA[(turns - 1) / 2] = position[turns - 1];
    }
    else if (player == 2)
    {
        playerB[(turns - 2) / 2] = position[turns - 1];
    }

    // 현재 플레이어의 정보에 따라 O혹은 X로 기입
    ui.setMarkerOnGrid(player, position[turns - 1]);

    // 입력 처리 완료 시 플레이어 변경
    if (player == 1)
    {
        player = 2;
    }
    else if (player == 2)
    {
        player = 1;
    }

    if (turns == 9)
    {
        Console.WriteLine("무승부입니다!");
        Console.WriteLine("종료하려면 Enter를 누르세요.");
        Console.ReadKey(true);
    }
    // 플레이 턴 수 증가
    turns++;
}