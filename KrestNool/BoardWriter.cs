using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestNool
{
    internal class BoardWriter
    {
        public static void WriteBoardToConsole(char[] boardData)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardData[1], boardData[2], boardData[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardData[4], boardData[5], boardData[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardData[7], boardData[8], boardData[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}
