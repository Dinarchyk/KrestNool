using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestNool
{
    internal class Checker
    {
        public static int CheckWin(char[] boardData)
        {

            int horiz = CheckHorizontal(boardData);
            if (horiz!= 0) return horiz;

            int vertical = CheckVertical(boardData);
            if (vertical != 0) return vertical;


            int diagonal = CheckDiagonal(boardData);
            if (diagonal != 0) return diagonal;

            return CheckDraw(boardData);
        }

        private static int CheckHorizontal(char[] boardData)
        {
            if (CheckThreeEqualsIndexes(boardData, 1, 2, 3))
            {
                return 1;
            }
            else if (CheckThreeEqualsIndexes(boardData, 4, 5, 6))
            {
                return 1;
            }
            else if (CheckThreeEqualsIndexes(boardData, 6, 7, 8))
            {
                return 1;
            }
            return 0;
        }

        private static int CheckVertical(char[] boardData)
        {
            if (CheckThreeEqualsIndexes(boardData, 1, 4, 7))
            {
                return 1;
            }
            else if (CheckThreeEqualsIndexes(boardData, 2, 5, 8))
            {
                return 1;
            }
            else if (CheckThreeEqualsIndexes(boardData, 3 ,6, 9))
            {
                return 1;
            }
            return 0;
        }

        private static int CheckDiagonal(char[] boardData)
        {
            if (CheckThreeEqualsIndexes(boardData, 1, 5, 9))
            {
                return 1;
            }
            else if (CheckThreeEqualsIndexes(boardData, 3, 5, 7))
            {
                return 1;
            }
            return 0;
        }

        private static int CheckDraw(char[] boardData)
        {
            if (boardData[1] != '1' && boardData[2] != '2' && boardData[3] != '3' 
                && boardData[4] != '4' && boardData[5] != '5' && boardData[6] != '6' 
                && boardData[7] != '7' && boardData[8] != '8' && boardData[9] != '9')
            {
                return -1;
            }
            return 0;
        }

        private static bool CheckThreeEqualsIndexes(char[] boardData, int one, int two, int three)
        {
            return boardData[one] == boardData[two] && boardData[two] == boardData[three];
        }

        public static void CheckEmptySpaceAndWriteChoice(UserDataObject userData, int choice)
        {
            char[] board = userData.GetBoard();
            bool playerFlag = userData.GetPlayerFlag();
           
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
                userData.SetPlayerFlag(!playerFlag);
            }
            else
            {
                Console.WriteLine("Место занято");
                Console.ReadLine();
            }
        }

        public static void CheckAndWriteVictory(UserDataObject userData)
        {
            if (userData.GetVictoryFlag() != 0)
            {
                Console.Clear();
                BoardWriter.WriteBoardToConsole(userData.GetBoard());
                if (!userData.GetPlayerFlag())
                {
                    Console.WriteLine("Первый игрок победил");
                }
                else
                {
                    Console.WriteLine("Второй игрок победил");
                }
                Console.WriteLine("Желаете начать заново");
                Console.ReadLine();
                userData.PrepareDataToPlay();
            }
        }
    }
}
