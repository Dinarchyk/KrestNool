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
            if (boardData[1] == boardData[2] && boardData[2] == boardData[3])
            {
                return 1;
            }
            else if (boardData[4] == boardData[5] && boardData[5] == boardData[6])
            {
                return 1;
            }
            else if (boardData[6] == boardData[7] && boardData[7] == boardData[8])
            {
                return 1;
            }
            return 0;
        }

        private static int CheckVertical(char[] boardData)
        {
            if (boardData[1] == boardData[4] && boardData[4] == boardData[7])
            {
                return 1;
            }
            else if (boardData[2] == boardData[5] && boardData[5] == boardData[8])
            {
                return 1;
            }
            else if (boardData[3] == boardData[6] && boardData[6] == boardData[9])
            {
                return 1;
            }
            return 0;
        }

        private static int CheckDiagonal(char[] boardData)
        {
            if (boardData[1] == boardData[5] && boardData[5] == boardData[9])
            {
                return 1;
            }
            else if (boardData[3] == boardData[5] && boardData[5] == boardData[7])
            {
                return 1;
            }
            return 0;
        }

        private static int CheckDraw(char[] boardData)
        {
            if (boardData[1] != '1' && boardData[2] != '2' && boardData[3] != '3' && boardData[4] != '4' && boardData[5] != '5' && boardData[6] != '6' && boardData[7] != '7' && boardData[8] != '8' && boardData[9] != '9')
            {
                return -1;
            }
            return 0;
        }
    }
}
