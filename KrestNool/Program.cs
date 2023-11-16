using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KrestNool
{
    internal class Program
    {
        static char[] board;
        static bool playerFlag;
        static int flag;
        static void Main(string[] args)
        {
            PrepareDataToPlay();
            while (true)
            {
                Console.Clear();
                if (playerFlag)
                {
                    Console.WriteLine("Ход: Первый игрок");
                }
                else
                {
                    Console.WriteLine("Ход: Второй игрок");
                }
                BoardWriter.WriteBoardToConsole(board);
                int choice = int.Parse(Console.ReadLine());
                if (board[choice] != 'X' && board[choice] != 'O')
                {
                    if (playerFlag)
                    {
                        board[choice] = 'O';
                    }
                    else
                    {
                        board[choice] = 'X';
                    }
                    playerFlag = !playerFlag;
                }
                else
                {
                    Console.WriteLine("Место занято");
                }
                flag = Checker.CheckWin(board);
                if (flag != 0)
                {
                    Console.Clear();
                    BoardWriter.WriteBoardToConsole(board);
                    if (!playerFlag)
                    {
                        Console.WriteLine("Первый игрок победил");
                    }
                    else
                    {
                        Console.WriteLine("Второй игрок победил");
                    }
                    Console.WriteLine("Желаете начать заново");
                    Console.ReadLine();
                    PrepareDataToPlay();
                }
            }
        }

        private static void PrepareDataToPlay()
        {
            board = new char[]{ '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            playerFlag = true;
            flag = 0;
        }
    }
}
