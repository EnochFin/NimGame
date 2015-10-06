using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    class Program
    {
        static void Main(string[] args)
        {
            HashOfBoards hob = new HashOfBoards();
            Board testBoard = new Board(1, 2, 3);
            System.Console.WriteLine(hob.ToString());
            foreach (Board b in Control.getPossibleMoves(testBoard, hob.getBoards()))
            {
                System.Console.WriteLine(b.ToString());
            }
        }
    }
}
