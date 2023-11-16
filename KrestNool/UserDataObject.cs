using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestNool
{
    internal class UserDataObject
    {
        private char[] board;
        private bool playerFlag;
        private int victoryFlag;

        public UserDataObject()
        {
            PrepareDataToPlay();
        }

        public void PrepareDataToPlay()
        {
            board = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            playerFlag = true;
            victoryFlag = 0;
        }

        public char[] GetBoard()
        {
            return board;
        }

        public bool GetPlayerFlag()
        {
            return playerFlag;
        }

        public int GetVictoryFlag()
        {
            return victoryFlag;
        }

        public void SetPlayerFlag(bool newPlayerFlag)
        {
            playerFlag = newPlayerFlag;
        }

        public void SetVictoryFlag(int newVictoryFlag)
        {
            victoryFlag = newVictoryFlag;
        }
    }
}
