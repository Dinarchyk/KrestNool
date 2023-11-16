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

        static void Main(string[] args)
        {
            var userData = new UserDataObject();
            userData.PrepareDataToPlay();
            while (true)
            {
                Console.Clear();
                if (userData.GetPlayerFlag())
                {
                    Console.WriteLine("Ход: Первый игрок");
                }
                else
                {
                    Console.WriteLine("Ход: Второй игрок");
                }
                BoardWriter.WriteBoardToConsole(userData.GetBoard());
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                } catch (Exception ignored)
                {
                    Console.WriteLine("Не правильный формат данных, введите число");
                    continue;
                }

                Checker.CheckEmptySpaceAndWriteChoice(userData, choice);
                
                userData.SetVictoryFlag(Checker.CheckWin(userData.GetBoard()));
                Checker.CheckAndWriteVictory(userData);
            }
        }

        
    }
}
